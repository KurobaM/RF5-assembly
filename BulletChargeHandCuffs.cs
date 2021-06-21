using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000185 RID: 389
[Token(Token = "0x2000131")]
[Serializable]
public class BulletChargeHandCuffs : BulletHandCuffs
{
	// Token: 0x06000812 RID: 2066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x2191E70", Offset = "0x2191F71", VA = "0x2191E70", Slot = "9")]
	public override void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x00004C80 File Offset: 0x00002E80
	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x2191F10", Offset = "0x2192011", VA = "0x2191F10", Slot = "13")]
	protected override bool Judge(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x21928D0", Offset = "0x21929D1", VA = "0x21928D0", Slot = "14")]
	public override void OnSuccess(CharacterBase chara, Vector3 point, Vector3 normal)
	{
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x2192B60", Offset = "0x2192C61", VA = "0x2192B60")]
	public BulletChargeHandCuffs()
	{
	}

	// Token: 0x040004B4 RID: 1204
	[Token(Token = "0x4000399")]
	protected const float HandCuffsHitEffectScale = 2.5f;

	// Token: 0x040004B5 RID: 1205
	[Token(Token = "0x400039A")]
	private const EffectID SuccessEffectID = EffectID.Effect_BattleHandcuffs_Hit;

	// Token: 0x040004B6 RID: 1206
	[Token(Token = "0x400039B")]
	private const SoundID SuccessSoundID = SoundID.RF5_SE_chara_motion34;

	// Token: 0x040004B7 RID: 1207
	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public OnGroundItemPickupCollider pickupCollider;

	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000FDD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1571E0", Offset = "0x1572E1")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x06000816 RID: 2070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C19")]
		[Address(RVA = "0x2192550", Offset = "0x2192651", VA = "0x2192550")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C1A")]
		[Address(RVA = "0x2192B80", Offset = "0x2192C81", VA = "0x2192B80")]
		internal void <Judge>b__0()
		{
		}

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x4018D8E")]
		[FieldOffset(Offset = "0x10")]
		public MonsterControllerBase monsterController;
	}
}
