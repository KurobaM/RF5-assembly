using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000800 RID: 2048
[Token(Token = "0x2000546")]
public class NpcLifeCycleDataRecord
{
	// Token: 0x060036BB RID: 14011 RVA: 0x00012E10 File Offset: 0x00011010
	[Token(Token = "0x6002D83")]
	[Address(RVA = "0x1F48160", Offset = "0x1F48261", VA = "0x1F48160")]
	public static int Compare(NpcLifeCycleDataRecord a, NpcLifeCycleDataRecord b)
	{
		return 0;
	}

	// Token: 0x060036BC RID: 14012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D84")]
	[Address(RVA = "0x1F48190", Offset = "0x1F48291", VA = "0x1F48190")]
	public NpcLifeCycleDataRecord()
	{
	}

	// Token: 0x040079AA RID: 31146
	[Token(Token = "0x4006E39")]
	[FieldOffset(Offset = "0x10")]
	public NPCID NpcId;

	// Token: 0x040079AB RID: 31147
	[Token(Token = "0x4006E3A")]
	[FieldOffset(Offset = "0x14")]
	public int ExtractTime;

	// Token: 0x040079AC RID: 31148
	[Token(Token = "0x4006E3B")]
	[FieldOffset(Offset = "0x18")]
	public int ExtractMargine;

	// Token: 0x040079AD RID: 31149
	[Token(Token = "0x4006E3C")]
	[FieldOffset(Offset = "0x1C")]
	public int Time;
}
