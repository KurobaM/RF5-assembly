using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000187 RID: 391
[Token(Token = "0x2000132")]
[Serializable]
public class BulletCurve : BulletSubModule
{
	// Token: 0x06000818 RID: 2072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x21937F0", Offset = "0x21938F1", VA = "0x21937F0", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x2193930", Offset = "0x2193A31", VA = "0x2193930", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x2193D50", Offset = "0x2193E51", VA = "0x2193D50")]
	public BulletCurve()
	{
	}

	// Token: 0x040004B9 RID: 1209
	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public Vector3 speed;

	// Token: 0x040004BA RID: 1210
	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float duration;
}
