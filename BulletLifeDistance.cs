using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200018E RID: 398
[Token(Token = "0x2000139")]
[Serializable]
public class BulletLifeDistance : BulletSubModule
{
	// Token: 0x06000833 RID: 2099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000703")]
	[Address(RVA = "0x21972E0", Offset = "0x21973E1", VA = "0x21972E0", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000704")]
	[Address(RVA = "0x21973D0", Offset = "0x21974D1", VA = "0x21973D0", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000705")]
	[Address(RVA = "0x2197520", Offset = "0x2197621", VA = "0x2197520")]
	public BulletLifeDistance()
	{
	}

	// Token: 0x040004D4 RID: 1236
	[Token(Token = "0x40003B8")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float maxDistance;

	// Token: 0x040004D5 RID: 1237
	[Token(Token = "0x40003B9")]
	[FieldOffset(Offset = "0x20")]
	private float currentDistance;

	// Token: 0x040004D6 RID: 1238
	[Token(Token = "0x40003BA")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 curentPosition;
}
