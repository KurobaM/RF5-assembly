using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200018B RID: 395
[Token(Token = "0x2000136")]
[Serializable]
public class BulletHoming : BulletSubModule
{
	// Token: 0x06000829 RID: 2089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x2196410", Offset = "0x2196511", VA = "0x2196410", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x2196530", Offset = "0x2196631", VA = "0x2196530", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x2196890", Offset = "0x2196991", VA = "0x2196890")]
	public BulletHoming()
	{
	}

	// Token: 0x040004C7 RID: 1223
	[Token(Token = "0x40003AB")]
	private const float HomingInductiveMax = 100f;

	// Token: 0x040004C8 RID: 1224
	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float starttime;

	// Token: 0x040004C9 RID: 1225
	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float range;

	// Token: 0x040004CA RID: 1226
	[Token(Token = "0x40003AE")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float inductive;
}
