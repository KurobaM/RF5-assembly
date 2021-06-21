using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C0 RID: 448
[Token(Token = "0x2000160")]
public class CharacterAnimationMonitor : CharaMotionBehaviour
{
	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06000964 RID: 2404 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000965 RID: 2405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A9")]
	private PlayerStatus m_PlayerStatus
	{
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1E8C1D0", Offset = "0x1E8C2D1", VA = "0x1E8C1D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AEF0", Offset = "0x19AFF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1E8C1E0", Offset = "0x1E8C2E1", VA = "0x1E8C1E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AF00", Offset = "0x19B001")]
		set
		{
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000966 RID: 2406 RVA: 0x00004F98 File Offset: 0x00003198
	// (set) Token: 0x06000967 RID: 2407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AA")]
	private float m_Elapsed
	{
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1E8C1F0", Offset = "0x1E8C2F1", VA = "0x1E8C1F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AF10", Offset = "0x19B011")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1E8C200", Offset = "0x1E8C301", VA = "0x1E8C200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AF20", Offset = "0x19B021")]
		set
		{
		}
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081B")]
	[Address(RVA = "0x1E8C210", Offset = "0x1E8C311", VA = "0x1E8C210", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081C")]
	[Address(RVA = "0x1E8CBB0", Offset = "0x1E8CCB1", VA = "0x1E8CBB0", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081D")]
	[Address(RVA = "0x1E8CE50", Offset = "0x1E8CF51", VA = "0x1E8CE50")]
	public CharacterAnimationMonitor()
	{
	}

	// Token: 0x040005C7 RID: 1479
	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x28")]
	public CharacterAnimationParam param;

	// Token: 0x040005C8 RID: 1480
	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0x30")]
	public bool m_StopMove;

	// Token: 0x040005C9 RID: 1481
	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x34")]
	public FaceType m_FaceType;

	// Token: 0x040005CA RID: 1482
	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0x38")]
	private float m_Deltatime;

	// Token: 0x040005CB RID: 1483
	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0x40")]
	private HitSystem m_HitSystem;

	// Token: 0x040005CC RID: 1484
	[Token(Token = "0x4000479")]
	[FieldOffset(Offset = "0x48")]
	public bool m_enablePersonalMotion;

	// Token: 0x040005CD RID: 1485
	[Token(Token = "0x400047A")]
	[FieldOffset(Offset = "0x49")]
	public bool m_enableEnemyCollision;

	// Token: 0x040005CE RID: 1486
	[Token(Token = "0x400047B")]
	[FieldOffset(Offset = "0x4A")]
	public bool m_ignoreShieldVisible;

	// Token: 0x040005CF RID: 1487
	[Token(Token = "0x400047C")]
	[FieldOffset(Offset = "0x4B")]
	public bool m_IsAutoRPHeal;

	// Token: 0x040005D0 RID: 1488
	[Token(Token = "0x400047D")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15CBC0", Offset = "0x15CCC1")]
	public float m_AutoRPHeal_Delta;

	// Token: 0x040005D1 RID: 1489
	[Token(Token = "0x400047E")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CBE0", Offset = "0x15CCE1")]
	private PlayerStatus <m_PlayerStatus>k__BackingField;

	// Token: 0x040005D2 RID: 1490
	[Token(Token = "0x400047F")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CBF0", Offset = "0x15CCF1")]
	private float <m_Elapsed>k__BackingField;
}
