using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006DE RID: 1758
[Token(Token = "0x20004DC")]
public class DeadtreeController : BossMonsterContoroller
{
	// Token: 0x170006A5 RID: 1701
	// (get) Token: 0x06002B2F RID: 11055 RVA: 0x000107A0 File Offset: 0x0000E9A0
	[Token(Token = "0x1700054B")]
	public bool ExistBurr
	{
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x1DF5640", Offset = "0x1DF5741", VA = "0x1DF5640")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002B30 RID: 11056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002466")]
	[Address(RVA = "0x1DF5650", Offset = "0x1DF5751", VA = "0x1DF5650")]
	public void ChangeRuntimeAnimator(bool isInGround)
	{
	}

	// Token: 0x06002B31 RID: 11057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002467")]
	[Address(RVA = "0x1DF56B0", Offset = "0x1DF57B1", VA = "0x1DF56B0")]
	public void SetupChestnut()
	{
	}

	// Token: 0x06002B32 RID: 11058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002468")]
	[Address(RVA = "0x1DF5A60", Offset = "0x1DF5B61", VA = "0x1DF5A60")]
	public void SetDisplayChestnut(bool isDisplay)
	{
	}

	// Token: 0x06002B33 RID: 11059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002469")]
	[Address(RVA = "0x1DF5E60", Offset = "0x1DF5F61", VA = "0x1DF5E60")]
	public void SetDisplayMash(bool isDisplay)
	{
	}

	// Token: 0x06002B34 RID: 11060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600246A")]
	[Address(RVA = "0x1DF5F40", Offset = "0x1DF6041", VA = "0x1DF5F40")]
	public void SetHeal(bool isHeal)
	{
	}

	// Token: 0x06002B35 RID: 11061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600246B")]
	[Address(RVA = "0x1DF5F50", Offset = "0x1DF6051", VA = "0x1DF5F50")]
	public void SetJumpCount(bool set, float jump)
	{
	}

	// Token: 0x06002B36 RID: 11062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600246C")]
	[Address(RVA = "0x1DF5F80", Offset = "0x1DF6081", VA = "0x1DF5F80", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002B37 RID: 11063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600246D")]
	[Address(RVA = "0x1DF61A0", Offset = "0x1DF62A1", VA = "0x1DF61A0", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002B38 RID: 11064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600246E")]
	[Address(RVA = "0x1DF6310", Offset = "0x1DF6411", VA = "0x1DF6310", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002B39 RID: 11065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600246F")]
	[Address(RVA = "0x1DF6430", Offset = "0x1DF6531", VA = "0x1DF6430")]
	public void SetMuteki(bool isflag)
	{
	}

	// Token: 0x06002B3A RID: 11066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002470")]
	[Address(RVA = "0x1DF6470", Offset = "0x1DF6571", VA = "0x1DF6470")]
	public void SetRangeEffect(bool play)
	{
	}

	// Token: 0x06002B3B RID: 11067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002471")]
	[Address(RVA = "0x1DF64A0", Offset = "0x1DF65A1", VA = "0x1DF64A0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002B3C RID: 11068 RVA: 0x000107B8 File Offset: 0x0000E9B8
	[Token(Token = "0x6002472")]
	[Address(RVA = "0x1DF67A0", Offset = "0x1DF68A1", VA = "0x1DF67A0")]
	public bool JumpCheck()
	{
		return default(bool);
	}

	// Token: 0x06002B3D RID: 11069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002473")]
	[Address(RVA = "0x1DF6920", Offset = "0x1DF6A21", VA = "0x1DF6920")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002B3E RID: 11070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002474")]
	[Address(RVA = "0x1DF6AD0", Offset = "0x1DF6BD1", VA = "0x1DF6AD0")]
	public DeadtreeController()
	{
	}

	// Token: 0x06002B3F RID: 11071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002475")]
	[Address(RVA = "0x1DF6C50", Offset = "0x1DF6D51", VA = "0x1DF6C50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A29E0", Offset = "0x1A2AE1")]
	private void <OnSetup>b__26_0(ParticleSystem particle)
	{
	}

	// Token: 0x040072B7 RID: 29367
	[Token(Token = "0x4006A27")]
	[FieldOffset(Offset = "0x508")]
	private readonly List<string> ChestnutNameList;

	// Token: 0x040072B8 RID: 29368
	[Token(Token = "0x4006A28")]
	[FieldOffset(Offset = "0x510")]
	private List<DeadtreeController.ChestnutController> ChestnutControllerList;

	// Token: 0x040072B9 RID: 29369
	[Token(Token = "0x4006A29")]
	[FieldOffset(Offset = "0x518")]
	[SerializeField]
	private RuntimeAnimatorController InGroundRuntimeAnimatorController;

	// Token: 0x040072BA RID: 29370
	[Token(Token = "0x4006A2A")]
	[FieldOffset(Offset = "0x520")]
	[SerializeField]
	private RuntimeAnimatorController RuntimeAnimatorController;

	// Token: 0x040072BB RID: 29371
	[Token(Token = "0x4006A2B")]
	[FieldOffset(Offset = "0x528")]
	private bool IsDisplayBurr;

	// Token: 0x040072BC RID: 29372
	[Token(Token = "0x4006A2C")]
	[FieldOffset(Offset = "0x52C")]
	public float DisplayTimer;

	// Token: 0x040072BD RID: 29373
	[Token(Token = "0x4006A2D")]
	[FieldOffset(Offset = "0x530")]
	public bool IsMashHeal;

	// Token: 0x040072BE RID: 29374
	[Token(Token = "0x4006A2E")]
	private const string MushPointName = "MashRoomPos";

	// Token: 0x040072BF RID: 29375
	[Token(Token = "0x4006A2F")]
	private const string BaseMushName = "MushroomBase";

	// Token: 0x040072C0 RID: 29376
	[Token(Token = "0x4006A30")]
	[FieldOffset(Offset = "0x538")]
	private DeadtreeController.MashController MashPoint;

	// Token: 0x040072C1 RID: 29377
	[Token(Token = "0x4006A31")]
	[FieldOffset(Offset = "0x540")]
	private DeadtreeController.MashController BaseMashPoint;

	// Token: 0x040072C2 RID: 29378
	[Token(Token = "0x4006A32")]
	[FieldOffset(Offset = "0x548")]
	public float jumpCount;

	// Token: 0x040072C3 RID: 29379
	[Token(Token = "0x4006A33")]
	[FieldOffset(Offset = "0x54C")]
	public Vector3 JumpPos;

	// Token: 0x040072C4 RID: 29380
	[Token(Token = "0x4006A34")]
	[FieldOffset(Offset = "0x558")]
	public bool JumpSearch;

	// Token: 0x040072C5 RID: 29381
	[Token(Token = "0x4006A35")]
	[FieldOffset(Offset = "0x560")]
	private ParticleSystem JumpPointEffect;

	// Token: 0x040072C6 RID: 29382
	[Token(Token = "0x4006A36")]
	[FieldOffset(Offset = "0x568")]
	public bool RangeSearch;

	// Token: 0x020006DF RID: 1759
	[Token(Token = "0x200118A")]
	private class ChestnutController
	{
		// Token: 0x06002B40 RID: 11072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B5")]
		[Address(RVA = "0x1DF5A50", Offset = "0x1DF5B51", VA = "0x1DF5A50")]
		public ChestnutController()
		{
		}

		// Token: 0x040072C7 RID: 29383
		[Token(Token = "0x40194FE")]
		[FieldOffset(Offset = "0x10")]
		public Transform Transform;

		// Token: 0x040072C8 RID: 29384
		[Token(Token = "0x40194FF")]
		[FieldOffset(Offset = "0x18")]
		public Sequence RespawnSequence;
	}

	// Token: 0x020006E0 RID: 1760
	[Token(Token = "0x200118B")]
	private class MashController
	{
		// Token: 0x06002B41 RID: 11073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B6")]
		[Address(RVA = "0x1DF6190", Offset = "0x1DF6291", VA = "0x1DF6190")]
		public MashController()
		{
		}

		// Token: 0x040072C9 RID: 29385
		[Token(Token = "0x4019500")]
		[FieldOffset(Offset = "0x10")]
		public Transform Transform;
	}
}
