using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000190 RID: 400
[Token(Token = "0x200013B")]
[Serializable]
public class BulletMainModule : IBulletModule
{
	// Token: 0x0600083A RID: 2106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070A")]
	[Address(RVA = "0x218FC50", Offset = "0x218FD51", VA = "0x218FC50", Slot = "4")]
	public void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070B")]
	[Address(RVA = "0x2190120", Offset = "0x2190221", VA = "0x2190120", Slot = "5")]
	public void OnUpdate(BulletBase bullet)
	{
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070C")]
	[Address(RVA = "0x2190500", Offset = "0x2190601", VA = "0x2190500", Slot = "6")]
	public void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070D")]
	[Address(RVA = "0x2190880", Offset = "0x2190981", VA = "0x2190880")]
	public void OnHit(BulletBase bullet, Collider collider, Vector3 point, Vector3 normal)
	{
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070E")]
	[Address(RVA = "0x2190E70", Offset = "0x2190F71", VA = "0x2190E70")]
	public void OnDead(BulletBase bullet)
	{
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070F")]
	[Address(RVA = "0x21912A0", Offset = "0x21913A1", VA = "0x21912A0")]
	public void DoExtension(BulletBase bullet)
	{
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000710")]
	[Address(RVA = "0x21916E0", Offset = "0x21917E1", VA = "0x21916E0")]
	public BulletMainModule()
	{
	}

	// Token: 0x040004D8 RID: 1240
	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int maxHitCount;

	// Token: 0x040004D9 RID: 1241
	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public BulletHitChara hitChara;

	// Token: 0x040004DA RID: 1242
	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public BulletHitObstacle hitObstacle;

	// Token: 0x040004DB RID: 1243
	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public BulletLaserNew laser;

	// Token: 0x040004DC RID: 1244
	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public List<BulletSubModule> modules;

	// Token: 0x040004DD RID: 1245
	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x38")]
	private int m_hitCount;
}
