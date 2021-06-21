using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200050C RID: 1292
[Token(Token = "0x20003AF")]
public class FestivalParamter : ScriptableObject
{
	// Token: 0x06001F74 RID: 8052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ADE")]
	[Address(RVA = "0x1F81120", Offset = "0x1F81221", VA = "0x1F81120")]
	public FestivalParamter()
	{
	}

	// Token: 0x04006663 RID: 26211
	[Token(Token = "0x40060B4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float CheerInterval;

	// Token: 0x04006664 RID: 26212
	[Token(Token = "0x40060B5")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float BaffamoBaseSpeed;

	// Token: 0x04006665 RID: 26213
	[Token(Token = "0x40060B6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int NormalRollingScore;

	// Token: 0x04006666 RID: 26214
	[Token(Token = "0x40060B7")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int JustRollingScore;

	// Token: 0x04006667 RID: 26215
	[Token(Token = "0x40060B8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float JustRollingDistance;

	// Token: 0x04006668 RID: 26216
	[Token(Token = "0x40060B9")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int NeedScoreInTurn2;

	// Token: 0x04006669 RID: 26217
	[Token(Token = "0x40060BA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int NeedScoreInTurn3;

	// Token: 0x0400666A RID: 26218
	[Token(Token = "0x40060BB")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public float BeanBaseSpeed;
}
