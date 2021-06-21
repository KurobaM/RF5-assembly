using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200086C RID: 2156
[Token(Token = "0x2000590")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146800", Offset = "0x146901")]
[Serializable]
public class NpcPatrolRoute
{
	// Token: 0x06003927 RID: 14631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FAB")]
	[Address(RVA = "0x1F53B90", Offset = "0x1F53C91", VA = "0x1F53B90")]
	public NpcPatrolRoute()
	{
	}

	// Token: 0x04007C5E RID: 31838
	[Token(Token = "0x4007071")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D6A0", Offset = "0x16D7A1")]
	[SerializeField]
	public string TargetSeatName;

	// Token: 0x04007C5F RID: 31839
	[Token(Token = "0x4007072")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D6F0", Offset = "0x16D7F1")]
	[SerializeField]
	public string TargetPoint;

	// Token: 0x04007C60 RID: 31840
	[Token(Token = "0x4007073")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D740", Offset = "0x16D841")]
	[SerializeField]
	public int Rate;

	// Token: 0x04007C61 RID: 31841
	[Token(Token = "0x4007074")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D790", Offset = "0x16D891")]
	[SerializeField]
	public int RotatePatternNumber;
}
