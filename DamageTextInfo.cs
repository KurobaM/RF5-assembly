using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000896 RID: 2198
[Token(Token = "0x20005AE")]
public struct DamageTextInfo
{
	// Token: 0x060039D5 RID: 14805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003045")]
	[Address(RVA = "0x2DDAF0", Offset = "0x2DDBF1", VA = "0x2DDAF0")]
	public DamageTextInfo(UIDamageType uIDamageType, int value, Vector3 position, bool isCritical = false, bool isWeek = false, bool isRegist = false)
	{
	}

	// Token: 0x04007D63 RID: 32099
	[Token(Token = "0x4007158")]
	[FieldOffset(Offset = "0x0")]
	public UIDamageType UIDamageType;

	// Token: 0x04007D64 RID: 32100
	[Token(Token = "0x4007159")]
	[FieldOffset(Offset = "0x4")]
	public int Value;

	// Token: 0x04007D65 RID: 32101
	[Token(Token = "0x400715A")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 position;

	// Token: 0x04007D66 RID: 32102
	[Token(Token = "0x400715B")]
	[FieldOffset(Offset = "0x14")]
	public bool IsCritical;

	// Token: 0x04007D67 RID: 32103
	[Token(Token = "0x400715C")]
	[FieldOffset(Offset = "0x15")]
	public bool IsWeek;

	// Token: 0x04007D68 RID: 32104
	[Token(Token = "0x400715D")]
	[FieldOffset(Offset = "0x16")]
	public bool IsRegist;
}
