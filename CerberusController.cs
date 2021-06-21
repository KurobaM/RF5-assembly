using System;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006D5 RID: 1749
[Token(Token = "0x20004D8")]
public class CerberusController : BossMonsterContoroller
{
	// Token: 0x06002AE6 RID: 10982 RVA: 0x000106F8 File Offset: 0x0000E8F8
	[Token(Token = "0x6002429")]
	[Address(RVA = "0x1E7F9A0", Offset = "0x1E7FAA1", VA = "0x1E7F9A0", Slot = "9")]
	public override bool IsCanNotLockon(CharacterBase lockonCharacter)
	{
		return default(bool);
	}

	// Token: 0x06002AE7 RID: 10983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600242A")]
	[Address(RVA = "0x1E7FA00", Offset = "0x1E7FB01", VA = "0x1E7FA00")]
	private void StartSplitAttack()
	{
	}

	// Token: 0x06002AE8 RID: 10984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600242B")]
	[Address(RVA = "0x1E7FC80", Offset = "0x1E7FD81", VA = "0x1E7FC80")]
	private void EndSplitAttack()
	{
	}

	// Token: 0x06002AE9 RID: 10985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600242C")]
	[Address(RVA = "0x1E7FE00", Offset = "0x1E7FF01", VA = "0x1E7FE00")]
	private void SetJumpPoint()
	{
	}

	// Token: 0x06002AEA RID: 10986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600242D")]
	[Address(RVA = "0x1E7FF50", Offset = "0x1E80051", VA = "0x1E7FF50")]
	private void EraseJumpPoint()
	{
	}

	// Token: 0x06002AEB RID: 10987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600242E")]
	[Address(RVA = "0x1E7FF80", Offset = "0x1E80081", VA = "0x1E7FF80")]
	private void DogsFall()
	{
	}

	// Token: 0x06002AEC RID: 10988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600242F")]
	[Address(RVA = "0x1E80630", Offset = "0x1E80731", VA = "0x1E80630")]
	private void DogRunTween(CerberusController.DogParam dog)
	{
	}

	// Token: 0x06002AED RID: 10989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002430")]
	[Address(RVA = "0x1E807D0", Offset = "0x1E808D1", VA = "0x1E807D0", Slot = "109")]
	public override void SetStatusController(MonsterStatusBase statusController)
	{
	}

	// Token: 0x06002AEE RID: 10990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002431")]
	[Address(RVA = "0x1E80990", Offset = "0x1E80A91", VA = "0x1E80990", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002AEF RID: 10991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002432")]
	[Address(RVA = "0x1E80A40", Offset = "0x1E80B41", VA = "0x1E80A40", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002AF0 RID: 10992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002433")]
	[Address(RVA = "0x1E80BB0", Offset = "0x1E80CB1", VA = "0x1E80BB0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002AF1 RID: 10993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002434")]
	[Address(RVA = "0x1E80E70", Offset = "0x1E80F71", VA = "0x1E80E70", Slot = "138")]
	public override void StartActionScript(int actionIndex)
	{
	}

	// Token: 0x06002AF2 RID: 10994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002435")]
	[Address(RVA = "0x1E80E80", Offset = "0x1E80F81", VA = "0x1E80E80", Slot = "24")]
	public override void OnEvent(int index, bool param)
	{
	}

	// Token: 0x06002AF3 RID: 10995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002436")]
	[Address(RVA = "0x1E80EA0", Offset = "0x1E80FA1", VA = "0x1E80EA0", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002AF4 RID: 10996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002437")]
	[Address(RVA = "0x1E80EB0", Offset = "0x1E80FB1", VA = "0x1E80EB0")]
	public CerberusController()
	{
	}

	// Token: 0x06002AF6 RID: 10998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002439")]
	[Address(RVA = "0x1E81040", Offset = "0x1E81141", VA = "0x1E81040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A28E0", Offset = "0x1A29E1")]
	private void <StartSplitAttack>b__12_0()
	{
	}

	// Token: 0x06002AF7 RID: 10999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600243A")]
	[Address(RVA = "0x1E81060", Offset = "0x1E81161", VA = "0x1E81060")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A28F0", Offset = "0x1A29F1")]
	private void <EndSplitAttack>b__13_0()
	{
	}

	// Token: 0x06002AF8 RID: 11000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600243B")]
	[Address(RVA = "0x1E810D0", Offset = "0x1E811D1", VA = "0x1E810D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2900", Offset = "0x1A2A01")]
	private void <SetStatusController>b__18_0(MonsterModelDataID id, GameObject monster)
	{
	}

	// Token: 0x06002AF9 RID: 11001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600243C")]
	[Address(RVA = "0x1E811F0", Offset = "0x1E812F1", VA = "0x1E811F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2910", Offset = "0x1A2A11")]
	private void <Start>b__19_0(ParticleSystem particle)
	{
	}

	// Token: 0x0400728E RID: 29326
	[Token(Token = "0x4006A12")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE;

	// Token: 0x0400728F RID: 29327
	[Token(Token = "0x4006A13")]
	[FieldOffset(Offset = "0x508")]
	[SerializeField]
	private List<AttackCollider> DogAttackColliderList;

	// Token: 0x04007290 RID: 29328
	[Token(Token = "0x4006A14")]
	[FieldOffset(Offset = "0x510")]
	private bool IsSplitAttack;

	// Token: 0x04007291 RID: 29329
	[Token(Token = "0x4006A15")]
	[FieldOffset(Offset = "0x511")]
	public bool IsOpossum;

	// Token: 0x04007292 RID: 29330
	[Token(Token = "0x4006A16")]
	[FieldOffset(Offset = "0x512")]
	public bool IsEndOpossumAnimation;

	// Token: 0x04007293 RID: 29331
	[Token(Token = "0x4006A17")]
	[FieldOffset(Offset = "0x518")]
	private readonly List<MonsterModelDataID> DogDataIDs;

	// Token: 0x04007294 RID: 29332
	[Token(Token = "0x4006A18")]
	[FieldOffset(Offset = "0x520")]
	private List<CerberusController.DogParam> Dogs;

	// Token: 0x04007295 RID: 29333
	[Token(Token = "0x4006A19")]
	[FieldOffset(Offset = "0x528")]
	private Vector3 SplitAttackStartPosition;

	// Token: 0x04007296 RID: 29334
	[Token(Token = "0x4006A1A")]
	[FieldOffset(Offset = "0x534")]
	private Vector3 EndPosition;

	// Token: 0x04007297 RID: 29335
	[Token(Token = "0x4006A1B")]
	[FieldOffset(Offset = "0x540")]
	private ParticleSystem JumpPointEffect;

	// Token: 0x020006D6 RID: 1750
	[Token(Token = "0x2001185")]
	public class DogParam
	{
		// Token: 0x06002AFA RID: 11002 RVA: 0x00010710 File Offset: 0x0000E910
		[Token(Token = "0x60071A8")]
		[Address(RVA = "0x1E81570", Offset = "0x1E81671", VA = "0x1E81570")]
		public Vector3 GetTargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A9")]
		[Address(RVA = "0x1E811E0", Offset = "0x1E812E1", VA = "0x1E811E0")]
		public DogParam()
		{
		}

		// Token: 0x04007298 RID: 29336
		[Token(Token = "0x40194EA")]
		[FieldOffset(Offset = "0x10")]
		public GameObject Controller;

		// Token: 0x04007299 RID: 29337
		[Token(Token = "0x40194EB")]
		[FieldOffset(Offset = "0x18")]
		public AttackCollider AttackCollider;

		// Token: 0x0400729A RID: 29338
		[Token(Token = "0x40194EC")]
		[FieldOffset(Offset = "0x20")]
		public Animator Animator;

		// Token: 0x0400729B RID: 29339
		[Token(Token = "0x40194ED")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 FallStartPosition;

		// Token: 0x0400729C RID: 29340
		[Token(Token = "0x40194EE")]
		[FieldOffset(Offset = "0x38")]
		public Transform TargetTransform;

		// Token: 0x0400729D RID: 29341
		[Token(Token = "0x40194EF")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 TargetPosition;

		// Token: 0x0400729E RID: 29342
		[Token(Token = "0x40194F0")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 LocalInitPosition;

		// Token: 0x0400729F RID: 29343
		[Token(Token = "0x40194F1")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 LocalDirection;

		// Token: 0x040072A0 RID: 29344
		[Token(Token = "0x40194F2")]
		[FieldOffset(Offset = "0x64")]
		public float MovedLength;

		// Token: 0x040072A1 RID: 29345
		[Token(Token = "0x40194F3")]
		[FieldOffset(Offset = "0x68")]
		public int TurnCount;
	}

	// Token: 0x020006D7 RID: 1751
	[Token(Token = "0x2001186")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158370", Offset = "0x158471")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x06002AFC RID: 11004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071AA")]
		[Address(RVA = "0x1E80620", Offset = "0x1E80721", VA = "0x1E80620")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071AB")]
		[Address(RVA = "0x1E81440", Offset = "0x1E81541", VA = "0x1E81440")]
		internal void <DogsFall>b__1(float t)
		{
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071AC")]
		[Address(RVA = "0x1E81620", Offset = "0x1E81721", VA = "0x1E81620")]
		internal void <DogsFall>b__2()
		{
		}

		// Token: 0x040072A2 RID: 29346
		[Token(Token = "0x40194F4")]
		[FieldOffset(Offset = "0x10")]
		public CerberusController.DogParam dog;

		// Token: 0x040072A3 RID: 29347
		[Token(Token = "0x40194F5")]
		[FieldOffset(Offset = "0x18")]
		public CerberusController <>4__this;
	}

	// Token: 0x020006D8 RID: 1752
	[Token(Token = "0x2001187")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158380", Offset = "0x158481")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002B00 RID: 11008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071AE")]
		[Address(RVA = "0x1E81420", Offset = "0x1E81521", VA = "0x1E81420")]
		public <>c()
		{
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00010728 File Offset: 0x0000E928
		[Token(Token = "0x60071AF")]
		[Address(RVA = "0x1E81430", Offset = "0x1E81531", VA = "0x1E81430")]
		internal float <DogsFall>b__16_0()
		{
			return 0f;
		}

		// Token: 0x040072A4 RID: 29348
		[Token(Token = "0x40194F6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CerberusController.<>c <>9;

		// Token: 0x040072A5 RID: 29349
		[Token(Token = "0x40194F7")]
		[FieldOffset(Offset = "0x8")]
		public static DOGetter<float> <>9__16_0;
	}

	// Token: 0x020006D9 RID: 1753
	[Token(Token = "0x2001188")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158390", Offset = "0x158491")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x06002B02 RID: 11010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B0")]
		[Address(RVA = "0x1E807C0", Offset = "0x1E808C1", VA = "0x1E807C0")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00010740 File Offset: 0x0000E940
		[Token(Token = "0x60071B1")]
		[Address(RVA = "0x1E816A0", Offset = "0x1E817A1", VA = "0x1E816A0")]
		internal float <DogRunTween>b__0()
		{
			return 0f;
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B2")]
		[Address(RVA = "0x1E816C0", Offset = "0x1E817C1", VA = "0x1E816C0")]
		internal void <DogRunTween>b__1(float t)
		{
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B3")]
		[Address(RVA = "0x1E81A70", Offset = "0x1E81B71", VA = "0x1E81A70")]
		internal void <DogRunTween>b__2()
		{
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B4")]
		[Address(RVA = "0x1E81CC0", Offset = "0x1E81DC1", VA = "0x1E81CC0")]
		internal void <DogRunTween>b__3()
		{
		}

		// Token: 0x040072A6 RID: 29350
		[Token(Token = "0x40194F8")]
		[FieldOffset(Offset = "0x10")]
		public CerberusController.DogParam dog;

		// Token: 0x040072A7 RID: 29351
		[Token(Token = "0x40194F9")]
		[FieldOffset(Offset = "0x18")]
		public CerberusController <>4__this;

		// Token: 0x040072A8 RID: 29352
		[Token(Token = "0x40194FA")]
		[FieldOffset(Offset = "0x20")]
		public TweenCallback <>9__3;
	}
}
