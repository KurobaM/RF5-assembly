using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000180 RID: 384
[Token(Token = "0x200012C")]
[Serializable]
public class BulletHitObstacle : BulletHitModule<Collider>
{
	// Token: 0x06000802 RID: 2050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x21960B0", Offset = "0x21961B1", VA = "0x21960B0", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00004C68 File Offset: 0x00002E68
	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x2196120", Offset = "0x2196221", VA = "0x2196120", Slot = "13")]
	public override bool OnHit(BulletBase bullet, Collider obstacle, Vector3 point, Vector3 normal)
	{
		return default(bool);
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x21963C0", Offset = "0x21964C1", VA = "0x21963C0")]
	public BulletHitObstacle()
	{
	}

	// Token: 0x040004A8 RID: 1192
	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public BulletHitObstacleEvent hitEventType;
}
