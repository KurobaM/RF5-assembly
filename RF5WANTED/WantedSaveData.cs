using System;
using Define;
using Il2CppDummyDll;

namespace RF5WANTED
{
	// Token: 0x02000E84 RID: 3716
	[Token(Token = "0x2000984")]
	[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x1496D0", Offset = "0x1497D1")]
	public class WantedSaveData
	{
		// Token: 0x06006155 RID: 24917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005094")]
		[Address(RVA = "0x1F37A70", Offset = "0x1F37B71", VA = "0x1F37A70")]
		public WantedSaveData()
		{
		}

		// Token: 0x0400C0F8 RID: 49400
		[Token(Token = "0x400909A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17ED10", Offset = "0x17EE11")]
		public int GeneratedTime;

		// Token: 0x0400C0F9 RID: 49401
		[Token(Token = "0x400909B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17ED30", Offset = "0x17EE31")]
		public int Seed;

		// Token: 0x0400C0FA RID: 49402
		[Token(Token = "0x400909C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17ED50", Offset = "0x17EE51")]
		public bool Accepted;

		// Token: 0x0400C0FB RID: 49403
		[Token(Token = "0x400909D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17ED70", Offset = "0x17EE71")]
		public WantedID AcceptedID;

		// Token: 0x0400C0FC RID: 49404
		[Token(Token = "0x400909E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17ED90", Offset = "0x17EE91")]
		public bool Finished;

		// Token: 0x0400C0FD RID: 49405
		[Token(Token = "0x400909F")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EDB0", Offset = "0x17EEB1")]
		public int AcceptedSeed;

		// Token: 0x0400C0FE RID: 49406
		[Token(Token = "0x40090A0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EDD0", Offset = "0x17EED1")]
		public int RandomDataNo;

		// Token: 0x0400C0FF RID: 49407
		[Token(Token = "0x40090A1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EDF0", Offset = "0x17EEF1")]
		public bool[] firstCompleted;

		// Token: 0x0400C100 RID: 49408
		[Token(Token = "0x40090A2")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EE10", Offset = "0x17EF11")]
		public bool[] todayCompleted;

		// Token: 0x0400C101 RID: 49409
		[Token(Token = "0x40090A3")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EE30", Offset = "0x17EF31")]
		public int finishedCount;

		// Token: 0x0400C102 RID: 49410
		[Token(Token = "0x40090A4")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EE50", Offset = "0x17EF51")]
		public int score;
	}
}
