using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200017E RID: 382
[Token(Token = "0x200012B")]
[Serializable]
public class BulletHitChara : BulletHitModule<CharacterBase>
{
	// Token: 0x060007FC RID: 2044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x2195730", Offset = "0x2195831", VA = "0x2195730", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00004C38 File Offset: 0x00002E38
	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x21957C0", Offset = "0x21958C1", VA = "0x21957C0", Slot = "13")]
	public override bool OnHit(BulletBase bullet, CharacterBase chara, Vector3 point, Vector3 normal)
	{
		return default(bool);
	}

	// Token: 0x060007FE RID: 2046 RVA: 0x00004C50 File Offset: 0x00002E50
	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x2195A00", Offset = "0x2195B01", VA = "0x2195A00")]
	private bool CheckAlliance(CharacterBase owner, CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x2195AE0", Offset = "0x2195BE1", VA = "0x2195AE0")]
	private void TakeDamage(BulletBase bullet, CharacterBase other, Vector3 point, Vector3 normal)
	{
	}

	// Token: 0x06000800 RID: 2048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x2195FA0", Offset = "0x21960A1", VA = "0x2195FA0")]
	public BulletHitChara()
	{
	}

	// Token: 0x040004A5 RID: 1189
	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public BulletHitAlliance hitAlliance;

	// Token: 0x040004A6 RID: 1190
	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public BulletHitCharaEvent hitEventType;

	// Token: 0x040004A7 RID: 1191
	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public BulletHitChara.HitEvent onHitEvent;

	// Token: 0x0200017F RID: 383
	[Token(Token = "0x2000FDC")]
	[Serializable]
	public class HitEvent : UnityEvent<CharacterBase, Vector3, Vector3>
	{
		// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C18")]
		[Address(RVA = "0x2196060", Offset = "0x2196161", VA = "0x2196060")]
		public HitEvent()
		{
		}
	}
}
