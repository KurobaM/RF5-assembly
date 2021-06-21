using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E2 RID: 738
[Token(Token = "0x2000240")]
public struct HitResult
{
	// Token: 0x04000AFE RID: 2814
	[Token(Token = "0x4000896")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 point;

	// Token: 0x04000AFF RID: 2815
	[Token(Token = "0x4000897")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 normal;

	// Token: 0x04000B00 RID: 2816
	[Token(Token = "0x4000898")]
	[FieldOffset(Offset = "0x18")]
	public float distance;

	// Token: 0x04000B01 RID: 2817
	[Token(Token = "0x4000899")]
	[FieldOffset(Offset = "0x20")]
	public Collider collider;
}
