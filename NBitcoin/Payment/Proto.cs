﻿#if !NOPROTOBUF
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled

// Generated from: PaymentRequest.proto
namespace Proto
{
	using payments = Proto;
	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Output")]
	internal partial class Output : global::ProtoBuf.IExtensible
	{
		public Output()
		{
		}

		private ulong? _amount;
		[global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"amount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
		public ulong amount
		{
			get
			{
				return _amount ?? (ulong)0;
			}
			set
			{
				_amount = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool amountSpecified
		{
			get
			{
				return this._amount != null;
			}
			set
			{
				if(value == (this._amount == null))
					this._amount = value ? this.amount : (ulong?)null;
			}
		}
		private bool ShouldSerializeamount()
		{
			return amountSpecified;
		}
		private void Resetamount()
		{
			amountSpecified = false;
		}

		private byte[] _script;
		[global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"script", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public byte[] script
		{
			get
			{
				return _script;
			}
			set
			{
				_script = value;
			}
		}
		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}

	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"PaymentDetails")]
	internal partial class PaymentDetails : global::ProtoBuf.IExtensible
	{
		public PaymentDetails()
		{
		}

		private string _network;
		[global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"network", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public string network
		{
			get
			{
				return _network ?? @"main";
			}
			set
			{
				_network = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool networkSpecified
		{
			get
			{
				return this._network != null;
			}
			set
			{
				if(value == (this._network == null))
					this._network = value ? this.network : (string)null;
			}
		}
		private bool ShouldSerializenetwork()
		{
			return networkSpecified;
		}
		private void Resetnetwork()
		{
			networkSpecified = false;
		}

		private readonly global::System.Collections.Generic.List<payments.Output> _outputs = new global::System.Collections.Generic.List<payments.Output>();
		[global::ProtoBuf.ProtoMember(2, Name = @"outputs", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public global::System.Collections.Generic.List<payments.Output> outputs
		{
			get
			{
				return _outputs;
			}
		}

		private ulong _time;
		[global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
		public ulong time
		{
			get
			{
				return _time;
			}
			set
			{
				_time = value;
			}
		}
		private ulong? _expires;
		[global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"expires", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
		public ulong expires
		{
			get
			{
				return _expires ?? default(ulong);
			}
			set
			{
				_expires = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool expiresSpecified
		{
			get
			{
				return this._expires != null;
			}
			set
			{
				if(value == (this._expires == null))
					this._expires = value ? this.expires : (ulong?)null;
			}
		}
		private bool ShouldSerializeexpires()
		{
			return expiresSpecified;
		}
		private void Resetexpires()
		{
			expiresSpecified = false;
		}

		private string _memo;
		[global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"memo", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public string memo
		{
			get
			{
				return _memo ?? "";
			}
			set
			{
				_memo = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool memoSpecified
		{
			get
			{
				return this._memo != null;
			}
			set
			{
				if(value == (this._memo == null))
					this._memo = value ? this.memo : (string)null;
			}
		}
		private bool ShouldSerializememo()
		{
			return memoSpecified;
		}
		private void Resetmemo()
		{
			memoSpecified = false;
		}

		private string _payment_url;
		[global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"payment_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public string payment_url
		{
			get
			{
				return _payment_url ?? "";
			}
			set
			{
				_payment_url = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool payment_urlSpecified
		{
			get
			{
				return this._payment_url != null;
			}
			set
			{
				if(value == (this._payment_url == null))
					this._payment_url = value ? this.payment_url : (string)null;
			}
		}
		private bool ShouldSerializepayment_url()
		{
			return payment_urlSpecified;
		}
		private void Resetpayment_url()
		{
			payment_urlSpecified = false;
		}

		private byte[] _merchant_data;
		[global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"merchant_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public byte[] merchant_data
		{
			get
			{
				return _merchant_data;
			}
			set
			{
				_merchant_data = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool merchant_dataSpecified
		{
			get
			{
				return this._merchant_data != null;
			}
			set
			{
				if(value == (this._merchant_data == null))
					this._merchant_data = value ? this.merchant_data : (byte[])null;
			}
		}
		private bool ShouldSerializemerchant_data()
		{
			return merchant_dataSpecified;
		}
		private void Resetmerchant_data()
		{
			merchant_dataSpecified = false;
		}

		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}

	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"PaymentRequest")]
	internal partial class PaymentRequest : global::ProtoBuf.IExtensible
	{
		public PaymentRequest()
		{
		}

		private uint? _payment_details_version;
		[global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"payment_details_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
		public uint payment_details_version
		{
			get
			{
				return _payment_details_version ?? (uint)1;
			}
			set
			{
				_payment_details_version = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool payment_details_versionSpecified
		{
			get
			{
				return this._payment_details_version != null;
			}
			set
			{
				if(value == (this._payment_details_version == null))
					this._payment_details_version = value ? this.payment_details_version : (uint?)null;
			}
		}
		private bool ShouldSerializepayment_details_version()
		{
			return payment_details_versionSpecified;
		}
		private void Resetpayment_details_version()
		{
			payment_details_versionSpecified = false;
		}

		private string _pki_type;
		[global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"pki_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public string pki_type
		{
			get
			{
				return _pki_type ?? @"none";
			}
			set
			{
				_pki_type = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool pki_typeSpecified
		{
			get
			{
				return this._pki_type != null;
			}
			set
			{
				if(value == (this._pki_type == null))
					this._pki_type = value ? this.pki_type : (string)null;
			}
		}
		private bool ShouldSerializepki_type()
		{
			return pki_typeSpecified;
		}
		private void Resetpki_type()
		{
			pki_typeSpecified = false;
		}

		private byte[] _pki_data;
		[global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"pki_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public byte[] pki_data
		{
			get
			{
				return _pki_data;
			}
			set
			{
				_pki_data = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool pki_dataSpecified
		{
			get
			{
				return this._pki_data != null;
			}
			set
			{
				if(value == (this._pki_data == null))
					this._pki_data = value ? this.pki_data : (byte[])null;
			}
		}
		private bool ShouldSerializepki_data()
		{
			return pki_dataSpecified;
		}
		private void Resetpki_data()
		{
			pki_dataSpecified = false;
		}

		private byte[] _serialized_payment_details;
		[global::ProtoBuf.ProtoMember(4, IsRequired = true, Name = @"serialized_payment_details", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public byte[] serialized_payment_details
		{
			get
			{
				return _serialized_payment_details;
			}
			set
			{
				_serialized_payment_details = value;
			}
		}
		private byte[] _signature;
		[global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public byte[] signature
		{
			get
			{
				return _signature;
			}
			set
			{
				_signature = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool signatureSpecified
		{
			get
			{
				return this._signature != null;
			}
			set
			{
				if(value == (this._signature == null))
					this._signature = value ? this.signature : (byte[])null;
			}
		}
		private bool ShouldSerializesignature()
		{
			return signatureSpecified;
		}
		private void Resetsignature()
		{
			signatureSpecified = false;
		}

		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}

	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"X509Certificates")]
	internal partial class X509Certificates : global::ProtoBuf.IExtensible
	{
		public X509Certificates()
		{
		}

		private readonly global::System.Collections.Generic.List<byte[]> _certificate = new global::System.Collections.Generic.List<byte[]>();
		[global::ProtoBuf.ProtoMember(1, Name = @"certificate", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public global::System.Collections.Generic.List<byte[]> certificate
		{
			get
			{
				return _certificate;
			}
		}

		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}

	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Payment")]
	internal partial class Payment : global::ProtoBuf.IExtensible
	{
		public Payment()
		{
		}

		private byte[] _merchant_data;
		[global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"merchant_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public byte[] merchant_data
		{
			get
			{
				return _merchant_data;
			}
			set
			{
				_merchant_data = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool merchant_dataSpecified
		{
			get
			{
				return this._merchant_data != null;
			}
			set
			{
				if(value == (this._merchant_data == null))
					this._merchant_data = value ? this.merchant_data : (byte[])null;
			}
		}
		private bool ShouldSerializemerchant_data()
		{
			return merchant_dataSpecified;
		}
		private void Resetmerchant_data()
		{
			merchant_dataSpecified = false;
		}

		private readonly global::System.Collections.Generic.List<byte[]> _transactions = new global::System.Collections.Generic.List<byte[]>();
		[global::ProtoBuf.ProtoMember(2, Name = @"transactions", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public global::System.Collections.Generic.List<byte[]> transactions
		{
			get
			{
				return _transactions;
			}
		}

		private readonly global::System.Collections.Generic.List<payments.Output> _refund_to = new global::System.Collections.Generic.List<payments.Output>();
		[global::ProtoBuf.ProtoMember(3, Name = @"refund_to", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public global::System.Collections.Generic.List<payments.Output> refund_to
		{
			get
			{
				return _refund_to;
			}
		}

		private string _memo;
		[global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"memo", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public string memo
		{
			get
			{
				return _memo ?? "";
			}
			set
			{
				_memo = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool memoSpecified
		{
			get
			{
				return this._memo != null;
			}
			set
			{
				if(value == (this._memo == null))
					this._memo = value ? this.memo : (string)null;
			}
		}
		private bool ShouldSerializememo()
		{
			return memoSpecified;
		}
		private void Resetmemo()
		{
			memoSpecified = false;
		}

		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}

	[global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"PaymentACK")]
	internal partial class PaymentACK : global::ProtoBuf.IExtensible
	{
		public PaymentACK()
		{
		}

		private payments.Payment _payment;
		[global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"payment", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public payments.Payment payment
		{
			get
			{
				return _payment;
			}
			set
			{
				_payment = value;
			}
		}
		private string _memo;
		[global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"memo", DataFormat = global::ProtoBuf.DataFormat.Default)]
		public string memo
		{
			get
			{
				return _memo ?? "";
			}
			set
			{
				_memo = value;
			}
		}
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.ComponentModel.Browsable(false)]
		public bool memoSpecified
		{
			get
			{
				return this._memo != null;
			}
			set
			{
				if(value == (this._memo == null))
					this._memo = value ? this.memo : (string)null;
			}
		}
		private bool ShouldSerializememo()
		{
			return memoSpecified;
		}
		private void Resetmemo()
		{
			memoSpecified = false;
		}

		private global::ProtoBuf.IExtension extensionObject;
		global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing);
		}
	}

}
#endif