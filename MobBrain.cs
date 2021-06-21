using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000294 RID: 660
[Token(Token = "0x200020D")]
public class MobBrain : CharacterInput
{
	// Token: 0x17000305 RID: 773
	// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002DB")]
	public NavMeshAgent NavMeshAgent
	{
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x1D76B90", Offset = "0x1D76C91", VA = "0x1D76B90")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000306 RID: 774
	// (get) Token: 0x060010F8 RID: 4344 RVA: 0x00007D28 File Offset: 0x00005F28
	// (set) Token: 0x060010F9 RID: 4345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002DC")]
	public bool Pause
	{
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x1D76BB0", Offset = "0x1D76CB1", VA = "0x1D76BB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x1D76BC0", Offset = "0x1D76CC1", VA = "0x1D76BC0")]
		set
		{
		}
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x1D76C20", Offset = "0x1D76D21", VA = "0x1D76C20", Slot = "4")]
	protected override void Start()
	{
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x1D76C80", Offset = "0x1D76D81", VA = "0x1D76C80")]
	protected void OnEnable()
	{
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x1D76C90", Offset = "0x1D76D91", VA = "0x1D76C90")]
	protected void OnDisable()
	{
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x1D76D20", Offset = "0x1D76E21", VA = "0x1D76D20")]
	public void Update()
	{
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x1D76D30", Offset = "0x1D76E31", VA = "0x1D76D30")]
	public void OnUpdate()
	{
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x1D76E00", Offset = "0x1D76F01", VA = "0x1D76E00")]
	public void UpdateBrainState()
	{
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00007D40 File Offset: 0x00005F40
	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x1D76FF0", Offset = "0x1D770F1", VA = "0x1D76FF0")]
	private MobBrain.MoveResult Move()
	{
		return MobBrain.MoveResult.Continue;
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00007D58 File Offset: 0x00005F58
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x1D77300", Offset = "0x1D77401", VA = "0x1D77300")]
	private Vector3 GetObstacleAvoidToward(Vector3 pos, Vector3 center, Vector3 toward)
	{
		return default(Vector3);
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x1D778B0", Offset = "0x1D779B1", VA = "0x1D778B0")]
	public static void UpdatePathFinding()
	{
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x1D77C00", Offset = "0x1D77D01", VA = "0x1D77C00")]
	public MobBrain()
	{
	}

	// Token: 0x04000980 RID: 2432
	[Token(Token = "0x400077F")]
	private const float ObstacleEnableDistance = 40f;

	// Token: 0x04000981 RID: 2433
	[Token(Token = "0x4000780")]
	private const float ObstacleCheckDistance = 1.5f;

	// Token: 0x04000982 RID: 2434
	[Token(Token = "0x4000781")]
	private const float ObstacleCheckRadius = 0.75f;

	// Token: 0x04000983 RID: 2435
	[Token(Token = "0x4000782")]
	private const float DecelerateRemainingDistance = 3f;

	// Token: 0x04000984 RID: 2436
	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x0")]
	private static float[] ObstacleCheckAngle;

	// Token: 0x04000985 RID: 2437
	[Token(Token = "0x4000784")]
	private const float ObstacleAvoidDuration = 1.5f;

	// Token: 0x04000986 RID: 2438
	[Token(Token = "0x4000785")]
	private const float ObstacleAvoicCoolTime = 0.5f;

	// Token: 0x04000987 RID: 2439
	[Token(Token = "0x4000786")]
	private const float IgnoreObstacleDuration = 1f;

	// Token: 0x04000988 RID: 2440
	[Token(Token = "0x4000787")]
	private const int BrainPathMaxPosition = 24;

	// Token: 0x04000989 RID: 2441
	[Token(Token = "0x4000788")]
	[FieldOffset(Offset = "0x20")]
	private MobBrainState m_currentState;

	// Token: 0x0400098A RID: 2442
	[Token(Token = "0x4000789")]
	[FieldOffset(Offset = "0x24")]
	private MobBrainState m_prevState;

	// Token: 0x0400098B RID: 2443
	[Token(Token = "0x400078A")]
	[FieldOffset(Offset = "0x28")]
	private float m_duration;

	// Token: 0x0400098C RID: 2444
	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0x2C")]
	private float m_elapsed;

	// Token: 0x0400098D RID: 2445
	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_targetPosition;

	// Token: 0x0400098E RID: 2446
	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool m_isPause;

	// Token: 0x0400098F RID: 2447
	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<Transform> m_moveTargets;

	// Token: 0x04000990 RID: 2448
	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float m_moveSpeedRate;

	// Token: 0x04000991 RID: 2449
	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x4C")]
	private float m_avoidElapsed;

	// Token: 0x04000992 RID: 2450
	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x50")]
	private float m_avoidCoolTime;

	// Token: 0x04000993 RID: 2451
	[Token(Token = "0x4000792")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_avoidDirection;

	// Token: 0x04000994 RID: 2452
	[Token(Token = "0x4000793")]
	[FieldOffset(Offset = "0x60")]
	private bool m_ignore;

	// Token: 0x04000995 RID: 2453
	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x64")]
	private float m_ignoreElapsed;

	// Token: 0x04000996 RID: 2454
	[Token(Token = "0x4000795")]
	[FieldOffset(Offset = "0x8")]
	private static List<MobBrain> m_PathFindingQueue;

	// Token: 0x04000997 RID: 2455
	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x10")]
	private static MobBrain m_CurrentPathFinder;

	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2001010")]
	protected enum MoveResult
	{
		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4018E75")]
		Continue,
		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x4018E76")]
		Complete,
		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x4018E77")]
		Suspension
	}

	// Token: 0x02000296 RID: 662
	[Token(Token = "0x2001011")]
	protected enum MobAction
	{
		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x4018E79")]
		Wait,
		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x4018E7A")]
		Move,
		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x4018E7B")]
		Length
	}
}
