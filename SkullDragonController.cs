using System;
using System.Collections.Generic;
using Define;
using DG.Tweening;
using DG.Tweening.Core;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000765 RID: 1893
[Token(Token = "0x2000516")]
public class SkullDragonController : BossMonsterContoroller
{
	// Token: 0x170006E3 RID: 1763
	// (get) Token: 0x060030D5 RID: 12501 RVA: 0x000110D0 File Offset: 0x0000F2D0
	// (set) Token: 0x060030D6 RID: 12502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000575")]
	public bool IsFireCharge
	{
		[Token(Token = "0x600290C")]
		[Address(RVA = "0x1DEB550", Offset = "0x1DEB651", VA = "0x1DEB550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A44B0", Offset = "0x1A45B1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600290D")]
		[Address(RVA = "0x1DEB560", Offset = "0x1DEB661", VA = "0x1DEB560")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A44C0", Offset = "0x1A45C1")]
		set
		{
		}
	}

	// Token: 0x170006E4 RID: 1764
	// (get) Token: 0x060030D7 RID: 12503 RVA: 0x000110E8 File Offset: 0x0000F2E8
	// (set) Token: 0x060030D8 RID: 12504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000576")]
	public bool IsBreathAttack
	{
		[Token(Token = "0x600290E")]
		[Address(RVA = "0x1DEB570", Offset = "0x1DEB671", VA = "0x1DEB570")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A44D0", Offset = "0x1A45D1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x1DEB580", Offset = "0x1DEB681", VA = "0x1DEB580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A44E0", Offset = "0x1A45E1")]
		set
		{
		}
	}

	// Token: 0x060030D9 RID: 12505 RVA: 0x00011100 File Offset: 0x0000F300
	[Token(Token = "0x6002910")]
	[Address(RVA = "0x1DEB590", Offset = "0x1DEB691", VA = "0x1DEB590", Slot = "9")]
	public override bool IsCanNotLockon(CharacterBase lockonCharacter)
	{
		return default(bool);
	}

	// Token: 0x060030DA RID: 12506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002911")]
	[Address(RVA = "0x1DEB5E0", Offset = "0x1DEB6E1", VA = "0x1DEB5E0")]
	public void SetupSkullHead()
	{
	}

	// Token: 0x060030DB RID: 12507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002912")]
	[Address(RVA = "0x1DEB9A0", Offset = "0x1DEBAA1", VA = "0x1DEB9A0", Slot = "130")]
	public override void OnSetBodyPartsType(BodyPartsCollision bodyPartsCollision)
	{
	}

	// Token: 0x060030DC RID: 12508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002913")]
	[Address(RVA = "0x1DEBA60", Offset = "0x1DEBB61", VA = "0x1DEBA60")]
	public void SetDisplayHead(bool isDisplay)
	{
	}

	// Token: 0x060030DD RID: 12509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002914")]
	[Address(RVA = "0x1DEBB90", Offset = "0x1DEBC91", VA = "0x1DEBB90")]
	public void SetDisplayCore(bool isDisplay)
	{
	}

	// Token: 0x060030DE RID: 12510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002915")]
	[Address(RVA = "0x1DEBC40", Offset = "0x1DEBD41", VA = "0x1DEBC40")]
	public void SetLookOn(bool isLookOn, float damage)
	{
	}

	// Token: 0x060030DF RID: 12511 RVA: 0x00011118 File Offset: 0x0000F318
	[Token(Token = "0x6002916")]
	[Address(RVA = "0x1DEBCB0", Offset = "0x1DEBDB1", VA = "0x1DEBCB0", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x060030E0 RID: 12512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002917")]
	[Address(RVA = "0x1DEC090", Offset = "0x1DEC191", VA = "0x1DEC090")]
	public void Accidental(float damage)
	{
	}

	// Token: 0x060030E1 RID: 12513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002918")]
	[Address(RVA = "0x1DEA920", Offset = "0x1DEAA21", VA = "0x1DEA920")]
	public void SetBreathAttack(bool state)
	{
	}

	// Token: 0x060030E2 RID: 12514 RVA: 0x00011130 File Offset: 0x0000F330
	[Token(Token = "0x6002919")]
	[Address(RVA = "0x1DEC120", Offset = "0x1DEC221", VA = "0x1DEC120")]
	public float CheckSoulCount()
	{
		return 0f;
	}

	// Token: 0x060030E3 RID: 12515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600291A")]
	[Address(RVA = "0x1DEC130", Offset = "0x1DEC231", VA = "0x1DEC130", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x060030E4 RID: 12516 RVA: 0x00011148 File Offset: 0x0000F348
	[Token(Token = "0x600291B")]
	[Address(RVA = "0x1DEC2C0", Offset = "0x1DEC3C1", VA = "0x1DEC2C0")]
	private bool IsShinanasaso(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x060030E5 RID: 12517 RVA: 0x00011160 File Offset: 0x0000F360
	[Token(Token = "0x600291C")]
	[Address(RVA = "0x1DEC2D0", Offset = "0x1DEC3D1", VA = "0x1DEC2D0")]
	private bool IsInStage(StorageType storageType, ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x060030E6 RID: 12518 RVA: 0x00011178 File Offset: 0x0000F378
	[Token(Token = "0x600291D")]
	[Address(RVA = "0x1DEC3F0", Offset = "0x1DEC4F1", VA = "0x1DEC3F0")]
	private bool IsOnGroundShianasaso()
	{
		return default(bool);
	}

	// Token: 0x060030E7 RID: 12519 RVA: 0x00011190 File Offset: 0x0000F390
	[Token(Token = "0x600291E")]
	[Address(RVA = "0x1DEC520", Offset = "0x1DEC621", VA = "0x1DEC520")]
	private bool IsExistShianasaso()
	{
		return default(bool);
	}

	// Token: 0x060030E8 RID: 12520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600291F")]
	[Address(RVA = "0x1DEC5F0", Offset = "0x1DEC6F1", VA = "0x1DEC5F0", Slot = "120")]
	protected override List<MonsterControllerBase.DropItemDataParameter> GetDoropItemList()
	{
		return null;
	}

	// Token: 0x060030E9 RID: 12521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002920")]
	[Address(RVA = "0x1DEC6C0", Offset = "0x1DEC7C1", VA = "0x1DEC6C0", Slot = "118")]
	protected override MonsterControllerBase.DropItemDataParameter GetHandCuffsDropItem()
	{
		return null;
	}

	// Token: 0x060030EA RID: 12522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002921")]
	[Address(RVA = "0x1DECCA0", Offset = "0x1DECDA1", VA = "0x1DECCA0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x060030EB RID: 12523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002922")]
	[Address(RVA = "0x1DECCD0", Offset = "0x1DECDD1", VA = "0x1DECCD0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x060030EC RID: 12524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002923")]
	[Address(RVA = "0x1DECF50", Offset = "0x1DED051", VA = "0x1DECF50")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x060030ED RID: 12525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002924")]
	[Address(RVA = "0x1DED030", Offset = "0x1DED131", VA = "0x1DED030")]
	public SkullDragonController()
	{
	}

	// Token: 0x060030EE RID: 12526 RVA: 0x000111A8 File Offset: 0x0000F3A8
	[Token(Token = "0x6002925")]
	[Address(RVA = "0x1DED040", Offset = "0x1DED141", VA = "0x1DED040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A44F0", Offset = "0x1A45F1")]
	private bool <GetDoropItemList>b__39_0(MonsterControllerBase.DropItemDataParameter param)
	{
		return default(bool);
	}

	// Token: 0x060030EF RID: 12527 RVA: 0x000111C0 File Offset: 0x0000F3C0
	[Token(Token = "0x6002926")]
	[Address(RVA = "0x1DED070", Offset = "0x1DED171", VA = "0x1DED070")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4500", Offset = "0x1A4601")]
	private bool <GetHandCuffsDropItem>b__40_0(DropItemParam param)
	{
		return default(bool);
	}

	// Token: 0x060030F0 RID: 12528 RVA: 0x000111D8 File Offset: 0x0000F3D8
	[Token(Token = "0x6002927")]
	[Address(RVA = "0x1DED080", Offset = "0x1DED181", VA = "0x1DED080")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4510", Offset = "0x1A4611")]
	private bool <GetHandCuffsDropItem>b__40_1(DropItemParam param)
	{
		return default(bool);
	}

	// Token: 0x060030F1 RID: 12529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002928")]
	[Address(RVA = "0x1DED090", Offset = "0x1DED191", VA = "0x1DED090")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4520", Offset = "0x1A4621")]
	private void <CreateProjectileEvent>b__43_0()
	{
	}

	// Token: 0x040075F2 RID: 30194
	[Token(Token = "0x4006C17")]
	private const string HeadBoneName = "Head";

	// Token: 0x040075F3 RID: 30195
	[Token(Token = "0x4006C18")]
	[FieldOffset(Offset = "0x508")]
	public bool IsFilledTailDamage;

	// Token: 0x040075F4 RID: 30196
	[Token(Token = "0x4006C19")]
	[FieldOffset(Offset = "0x509")]
	public bool IsHeadAttack;

	// Token: 0x040075F5 RID: 30197
	[Token(Token = "0x4006C1A")]
	[FieldOffset(Offset = "0x50A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169930", Offset = "0x169A31")]
	private bool <IsFireCharge>k__BackingField;

	// Token: 0x040075F6 RID: 30198
	[Token(Token = "0x4006C1B")]
	[FieldOffset(Offset = "0x50C")]
	public float IsChargeTime;

	// Token: 0x040075F7 RID: 30199
	[Token(Token = "0x4006C1C")]
	[FieldOffset(Offset = "0x510")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169940", Offset = "0x169A41")]
	private bool <IsBreathAttack>k__BackingField;

	// Token: 0x040075F8 RID: 30200
	[Token(Token = "0x4006C1D")]
	[FieldOffset(Offset = "0x518")]
	public GameObject headobj;

	// Token: 0x040075F9 RID: 30201
	[Token(Token = "0x4006C1E")]
	[FieldOffset(Offset = "0x520")]
	private SkinnedMeshRenderer HeadSkin;

	// Token: 0x040075FA RID: 30202
	[Token(Token = "0x4006C1F")]
	[FieldOffset(Offset = "0x528")]
	public float ShoutSoul;

	// Token: 0x040075FB RID: 30203
	[Token(Token = "0x4006C20")]
	[FieldOffset(Offset = "0x530")]
	private SkullDragonController.SkullHeadController HeadController;

	// Token: 0x040075FC RID: 30204
	[Token(Token = "0x4006C21")]
	[FieldOffset(Offset = "0x538")]
	private SkinnedMeshRenderer SkinnedMeshRenderer;

	// Token: 0x040075FD RID: 30205
	[Token(Token = "0x4006C22")]
	[FieldOffset(Offset = "0x540")]
	private Material DefaultMaterial;

	// Token: 0x040075FE RID: 30206
	[Token(Token = "0x4006C23")]
	private const string CorePointName = "CorePoint";

	// Token: 0x040075FF RID: 30207
	[Token(Token = "0x4006C24")]
	[FieldOffset(Offset = "0x548")]
	private bool IsDisplayHead;

	// Token: 0x04007600 RID: 30208
	[Token(Token = "0x4006C25")]
	[FieldOffset(Offset = "0x550")]
	private SkullDragonController.CoreController CorePoint;

	// Token: 0x02000766 RID: 1894
	[Token(Token = "0x20011D6")]
	private class SkullHeadController
	{
		// Token: 0x060030F2 RID: 12530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072B4")]
		[Address(RVA = "0x1DEB980", Offset = "0x1DEBA81", VA = "0x1DEB980")]
		public SkullHeadController()
		{
		}

		// Token: 0x04007601 RID: 30209
		[Token(Token = "0x4019644")]
		[FieldOffset(Offset = "0x10")]
		public Transform Transform;

		// Token: 0x04007602 RID: 30210
		[Token(Token = "0x4019645")]
		[FieldOffset(Offset = "0x18")]
		public Sequence RespawnSequence;
	}

	// Token: 0x02000767 RID: 1895
	[Token(Token = "0x20011D7")]
	public enum BodyParts
	{
		// Token: 0x04007604 RID: 30212
		[Token(Token = "0x4019647")]
		None,
		// Token: 0x04007605 RID: 30213
		[Token(Token = "0x4019648")]
		Head,
		// Token: 0x04007606 RID: 30214
		[Token(Token = "0x4019649")]
		Body,
		// Token: 0x04007607 RID: 30215
		[Token(Token = "0x401964A")]
		Tail
	}

	// Token: 0x02000768 RID: 1896
	[Token(Token = "0x20011D8")]
	private class CoreController
	{
		// Token: 0x060030F3 RID: 12531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072B5")]
		[Address(RVA = "0x1DEB990", Offset = "0x1DEBA91", VA = "0x1DEB990")]
		public CoreController()
		{
		}

		// Token: 0x04007608 RID: 30216
		[Token(Token = "0x401964B")]
		[FieldOffset(Offset = "0x10")]
		public Transform Transform;
	}

	// Token: 0x02000769 RID: 1897
	[Token(Token = "0x20011D9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1586C0", Offset = "0x1587C1")]
	private sealed class <>c__DisplayClass25_0
	{
		// Token: 0x060030F4 RID: 12532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072B6")]
		[Address(RVA = "0x1DEB970", Offset = "0x1DEBA71", VA = "0x1DEB970")]
		public <>c__DisplayClass25_0()
		{
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072B7")]
		[Address(RVA = "0x1DED1A0", Offset = "0x1DED2A1", VA = "0x1DED1A0")]
		internal void <SetupSkullHead>b__1(Vector3 scale)
		{
		}

		// Token: 0x04007609 RID: 30217
		[Token(Token = "0x401964C")]
		[FieldOffset(Offset = "0x10")]
		public Transform headTransform;
	}

	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x20011DA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1586D0", Offset = "0x1587D1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060030F7 RID: 12535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072B9")]
		[Address(RVA = "0x1DED120", Offset = "0x1DED221", VA = "0x1DED120")]
		public <>c()
		{
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x000111F0 File Offset: 0x0000F3F0
		[Token(Token = "0x60072BA")]
		[Address(RVA = "0x1DED130", Offset = "0x1DED231", VA = "0x1DED130")]
		internal Vector3 <SetupSkullHead>b__25_0()
		{
			return default(Vector3);
		}

		// Token: 0x0400760A RID: 30218
		[Token(Token = "0x401964D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SkullDragonController.<>c <>9;

		// Token: 0x0400760B RID: 30219
		[Token(Token = "0x401964E")]
		[FieldOffset(Offset = "0x8")]
		public static DOGetter<Vector3> <>9__25_0;
	}
}
