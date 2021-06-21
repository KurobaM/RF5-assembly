using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000F8 RID: 248
[Token(Token = "0x20000C3")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x144D00", Offset = "0x144E01")]
public class PartyData
{
	// Token: 0x0600055C RID: 1372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000481")]
	[Address(RVA = "0x213AC70", Offset = "0x213AD71", VA = "0x213AC70")]
	public PartyData()
	{
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x213AC80", Offset = "0x213AD81", VA = "0x213AC80")]
	public PartyData(int no)
	{
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000483")]
	[Address(RVA = "0x213ACE0", Offset = "0x213ADE1", VA = "0x213ACE0")]
	public void Clear()
	{
	}

	// Token: 0x040002C8 RID: 712
	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x15BB20", Offset = "0x15BC21")]
	public int PartyNo;

	// Token: 0x040002C9 RID: 713
	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x15BB40", Offset = "0x15BC41")]
	public PartyType PartyType;

	// Token: 0x040002CA RID: 714
	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x15BB60", Offset = "0x15BC61")]
	public ActorID ActorId;

	// Token: 0x040002CB RID: 715
	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x15BB80", Offset = "0x15BC81")]
	public uint DataID;

	// Token: 0x040002CC RID: 716
	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x15BBA0", Offset = "0x15BCA1")]
	public EnemyStatusData StatusData;

	// Token: 0x040002CD RID: 717
	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x15BBC0", Offset = "0x15BCC1")]
	public int PartyOutTime;
}
