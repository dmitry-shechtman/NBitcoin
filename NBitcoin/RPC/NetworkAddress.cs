﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NBitcoin.RPC
{
	public class NetworkAddress : IBitcoinSerializable
	{
		uint time;
		ulong service;
		byte[] ip = new byte[16];
		ushort port;

		public IPEndPoint Endpoint
		{
			get
			{
				return new IPEndPoint(new IPAddress(ip), port);
			}
			set
			{
				port = (ushort)value.Port;
				var ipBytes = value.Address.GetAddressBytes();
				if(ipBytes.Length == 16)
				{
					ip = ipBytes;
				}
				else if(ipBytes.Length == 4)
				{
					//Convert to ipv4 mapped to ipv6
					//In these addresses, the first 80 bits are zero, the next 16 bits are one, and the remaining 32 bits are the IPv4 address
					ip = new byte[16];
					Array.Copy(ipBytes, 0, ip, 12, 4);
					Array.Copy(new byte[] { 0xFF, 0xFF }, 0, ip, 10, 2);
				}
				else
					throw new NotSupportedException("Invalid IP address type");
			}
		}

		public Node ToNode(RPCServer client)
		{
			return new Node(this, client);
		}

		public DateTimeOffset Time
		{
			get
			{
				return Utils.UnixTimeToDateTime(time);
			}
			set
			{
				time = Utils.DateTimeToUnixTime(value);
			}
		}

		#region IBitcoinSerializable Members

		public void ReadWrite(BitcoinStream stream)
		{
			if(stream.ProtocolVersion >= ProtocolVersion.CADDR_TIME_VERSION)
				stream.ReadWrite(ref time);
			stream.ReadWrite(ref service);
			stream.ReadWrite(ref ip);
			using(stream.BigEndianScope())
			{
				stream.ReadWrite(ref port);
			}
		}

		#endregion

	}
}