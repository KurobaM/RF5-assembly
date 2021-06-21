using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000188 RID: 392
[Token(Token = "0x2000133")]
[Serializable]
public class BulletExplosion : BulletSubModule
{
	// Token: 0x0600081B RID: 2075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x2194390", Offset = "0x2194491", VA = "0x2194390", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x2194430", Offset = "0x2194531", VA = "0x2194430", Slot = "10")]
	public override void OnHit(BulletBase bullet)
	{
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x2194CB0", Offset = "0x2194DB1", VA = "0x2194CB0", Slot = "11")]
	public override void OnDead(BulletBase bullet)
	{
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x2194440", Offset = "0x2194541", VA = "0x2194440")]
	private void DoExplosion(BulletBase bullet)
	{
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x2194CC0", Offset = "0x2194DC1", VA = "0x2194CC0")]
	public BulletExplosion()
	{
	}

	// Token: 0x040004BB RID: 1211
	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private BulletExplosionType type;

	// Token: 0x040004BC RID: 1212
	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float radius;

	// Token: 0x040004BD RID: 1213
	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private EffectID effectID;

	// Token: 0x040004BE RID: 1214
	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float effectScale;

	// Token: 0x040004BF RID: 1215
	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private MagicParamID paramID;
}
