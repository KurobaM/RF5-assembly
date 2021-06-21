using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EEE RID: 3822
	[Token(Token = "0x20009C9")]
	public class SaveDataHeader
	{
		// Token: 0x06006401 RID: 25601 RVA: 0x000217C8 File Offset: 0x0001F9C8
		[Token(Token = "0x600530D")]
		[Address(RVA = "0x21D0210", Offset = "0x21D0311", VA = "0x21D0210")]
		private bool ReadCheck(BinaryReader reader)
		{
			return default(bool);
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530E")]
		[Address(RVA = "0x21CEDB0", Offset = "0x21CEEB1", VA = "0x21CEDB0")]
		public SaveDataHeader()
		{
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530F")]
		[Address(RVA = "0x21CEE50", Offset = "0x21CEF51", VA = "0x21CEE50")]
		public void Initialize(uint version)
		{
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005310")]
		[Address(RVA = "0x21CEFC0", Offset = "0x21CF0C1", VA = "0x21CEFC0")]
		public void Update(uint version)
		{
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005311")]
		[Address(RVA = "0x21CF3B0", Offset = "0x21CF4B1", VA = "0x21CF3B0")]
		public void Write(BinaryWriter writer)
		{
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005312")]
		[Address(RVA = "0x21CF9A0", Offset = "0x21CFAA1", VA = "0x21CF9A0")]
		public void Read(BinaryReader reader)
		{
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005313")]
		[Address(RVA = "0x21D0260", Offset = "0x21D0361", VA = "0x21D0260")]
		public void SetSaveTime(DateTime dateTime)
		{
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06006408 RID: 25608 RVA: 0x000217E0 File Offset: 0x0001F9E0
		[Token(Token = "0x17000A1F")]
		public bool IsEncryption
		{
			[Token(Token = "0x6005314")]
			[Address(RVA = "0x21CF4C0", Offset = "0x21CF5C1", VA = "0x21CF4C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x000217F8 File Offset: 0x0001F9F8
		[Token(Token = "0x6005315")]
		[Address(RVA = "0x21D0320", Offset = "0x21D0421", VA = "0x21D0320")]
		public DateTime GetSaveTime()
		{
			return default(DateTime);
		}

		// Token: 0x0400C3E2 RID: 50146
		[Token(Token = "0x40092C1")]
		public const int SIZE = 32;

		// Token: 0x0400C3E3 RID: 50147
		[Token(Token = "0x40092C2")]
		[FieldOffset(Offset = "0x10")]
		public ulong UID;

		// Token: 0x0400C3E4 RID: 50148
		[Token(Token = "0x40092C3")]
		[FieldOffset(Offset = "0x18")]
		public uint Version;

		// Token: 0x0400C3E5 RID: 50149
		[Token(Token = "0x40092C4")]
		[FieldOffset(Offset = "0x20")]
		public char[] Project;

		// Token: 0x0400C3E6 RID: 50150
		[Token(Token = "0x40092C5")]
		[FieldOffset(Offset = "0x28")]
		public uint WCnt;

		// Token: 0x0400C3E7 RID: 50151
		[Token(Token = "0x40092C6")]
		[FieldOffset(Offset = "0x2C")]
		public uint WOpt;

		// Token: 0x0400C3E8 RID: 50152
		[Token(Token = "0x40092C7")]
		[FieldOffset(Offset = "0x30")]
		private SaveTime SaveTime;
	}
}
