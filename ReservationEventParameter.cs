using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004AE RID: 1198
[Token(Token = "0x200037A")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145E80", Offset = "0x145F81")]
[SerializeField]
public class ReservationEventParameter
{
	// Token: 0x06001D37 RID: 7479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001948")]
	[Address(RVA = "0x248AD10", Offset = "0x248AE11", VA = "0x248AD10")]
	public void Init()
	{
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001949")]
	[Address(RVA = "0x248AD20", Offset = "0x248AE21", VA = "0x248AD20")]
	public ReservationEventParameter()
	{
	}

	// Token: 0x040062D4 RID: 25300
	[Token(Token = "0x4005DBD")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164C80", Offset = "0x164D81")]
	[SerializeField]
	public int EventId;

	// Token: 0x040062D5 RID: 25301
	[Token(Token = "0x4005DBE")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164CD0", Offset = "0x164DD1")]
	[SerializeField]
	public int NpcId;

	// Token: 0x040062D6 RID: 25302
	[Token(Token = "0x4005DBF")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164D20", Offset = "0x164E21")]
	[SerializeField]
	public int Progress;
}
