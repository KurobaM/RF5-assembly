using System;
using System.Text;
using Il2CppDummyDll;

namespace BinaryStream
{
	// Token: 0x020011CE RID: 4558
	[Token(Token = "0x2000BA3")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x14A250", Offset = "0x14A351")]
	public class BinaryReader
	{
		// Token: 0x06007138 RID: 28984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF4")]
		[Address(RVA = "0x2450970", Offset = "0x2450A71", VA = "0x2450970")]
		public BinaryReader()
		{
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF5")]
		[Address(RVA = "0x24509B0", Offset = "0x2450AB1", VA = "0x24509B0")]
		public BinaryReader(byte[] data)
		{
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF6")]
		[Address(RVA = "0x2450A00", Offset = "0x2450B01", VA = "0x2450A00")]
		public BinaryReader(string name)
		{
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF7")]
		[Address(RVA = "0x2450AE0", Offset = "0x2450BE1", VA = "0x2450AE0")]
		public void SetData(byte[] data)
		{
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x0600713C RID: 28988 RVA: 0x00027048 File Offset: 0x00025248
		[Token(Token = "0x17000B2B")]
		public bool Ready
		{
			[Token(Token = "0x6005DF8")]
			[Address(RVA = "0x2450B20", Offset = "0x2450C21", VA = "0x2450B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x0600713D RID: 28989 RVA: 0x00027060 File Offset: 0x00025260
		[Token(Token = "0x17000B2C")]
		public int Size
		{
			[Token(Token = "0x6005DF9")]
			[Address(RVA = "0x2450B30", Offset = "0x2450C31", VA = "0x2450B30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x0600713E RID: 28990 RVA: 0x00027078 File Offset: 0x00025278
		// (set) Token: 0x0600713F RID: 28991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B2D")]
		public int Pos
		{
			[Token(Token = "0x6005DFA")]
			[Address(RVA = "0x2450B50", Offset = "0x2450C51", VA = "0x2450B50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005DFB")]
			[Address(RVA = "0x2450B60", Offset = "0x2450C61", VA = "0x2450B60")]
			set
			{
			}
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DFC")]
		[Address(RVA = "0x2450BA0", Offset = "0x2450CA1", VA = "0x2450BA0")]
		public byte[] GetBuffer()
		{
			return null;
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06007141 RID: 28993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B2E")]
		public byte[] Data
		{
			[Token(Token = "0x6005DFD")]
			[Address(RVA = "0x2450BB0", Offset = "0x2450CB1", VA = "0x2450BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06007142 RID: 28994 RVA: 0x00027090 File Offset: 0x00025290
		// (set) Token: 0x06007143 RID: 28995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B2F")]
		public byte Item
		{
			[Token(Token = "0x6005DFE")]
			[Address(RVA = "0x2450BC0", Offset = "0x2450CC1", VA = "0x2450BC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005DFF")]
			[Address(RVA = "0x2450C00", Offset = "0x2450D01", VA = "0x2450C00")]
			set
			{
			}
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x000270A8 File Offset: 0x000252A8
		[Token(Token = "0x6005E00")]
		[Address(RVA = "0x2450C40", Offset = "0x2450D41", VA = "0x2450C40")]
		public bool GetBool()
		{
			return default(bool);
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x000270C0 File Offset: 0x000252C0
		[Token(Token = "0x6005E01")]
		[Address(RVA = "0x2450C90", Offset = "0x2450D91", VA = "0x2450C90")]
		public byte GetByte()
		{
			return 0;
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x000270D8 File Offset: 0x000252D8
		[Token(Token = "0x6005E02")]
		[Address(RVA = "0x2450CE0", Offset = "0x2450DE1", VA = "0x2450CE0")]
		public short GetShort()
		{
			return 0;
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x000270F0 File Offset: 0x000252F0
		[Token(Token = "0x6005E03")]
		[Address(RVA = "0x2450D50", Offset = "0x2450E51", VA = "0x2450D50")]
		public ushort GetUShort()
		{
			return 0;
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x00027108 File Offset: 0x00025308
		[Token(Token = "0x6005E04")]
		[Address(RVA = "0x2450DC0", Offset = "0x2450EC1", VA = "0x2450DC0")]
		public int GetInt()
		{
			return 0;
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x00027120 File Offset: 0x00025320
		[Token(Token = "0x6005E05")]
		[Address(RVA = "0x2450E70", Offset = "0x2450F71", VA = "0x2450E70")]
		public uint GetUInt()
		{
			return 0U;
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x00027138 File Offset: 0x00025338
		[Token(Token = "0x6005E06")]
		[Address(RVA = "0x2450F20", Offset = "0x2451021", VA = "0x2450F20")]
		public long GetLong()
		{
			return 0L;
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x00027150 File Offset: 0x00025350
		[Token(Token = "0x6005E07")]
		[Address(RVA = "0x2451050", Offset = "0x2451151", VA = "0x2451050")]
		public ulong GetULong()
		{
			return 0UL;
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x00027168 File Offset: 0x00025368
		[Token(Token = "0x6005E08")]
		[Address(RVA = "0x2451180", Offset = "0x2451281", VA = "0x2451180")]
		public float GetFloat()
		{
			return 0f;
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E09")]
		[Address(RVA = "0x2451250", Offset = "0x2451351", VA = "0x2451250")]
		public string GetString()
		{
			return null;
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E0A")]
		[Address(RVA = "0x2451380", Offset = "0x2451481", VA = "0x2451380")]
		public string GetStringAscii()
		{
			return null;
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E0B")]
		[Address(RVA = "0x2451490", Offset = "0x2451591", VA = "0x2451490")]
		public byte[] GetByteArray(int size)
		{
			return null;
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E0C")]
		[Address(RVA = "0x2451580", Offset = "0x2451681", VA = "0x2451580")]
		public char[] GetCharArray(int size)
		{
			return null;
		}

		// Token: 0x04018302 RID: 99074
		[Token(Token = "0x4014D6E")]
		[FieldOffset(Offset = "0x10")]
		protected byte[] data_;

		// Token: 0x04018303 RID: 99075
		[Token(Token = "0x4014D6F")]
		[FieldOffset(Offset = "0x18")]
		protected int pos_;

		// Token: 0x04018304 RID: 99076
		[Token(Token = "0x4014D70")]
		[FieldOffset(Offset = "0x1C")]
		private bool ready_;

		// Token: 0x04018305 RID: 99077
		[Token(Token = "0x4014D71")]
		[FieldOffset(Offset = "0x20")]
		private StringBuilder builder_;
	}
}
