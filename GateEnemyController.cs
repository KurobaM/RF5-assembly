using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006FB RID: 1787
[Token(Token = "0x20004E8")]
public class GateEnemyController : MonsterControllerBase
{
	// Token: 0x06002CAD RID: 11437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025AD")]
	[Address(RVA = "0x1FA2980", Offset = "0x1FA2A81", VA = "0x1FA2980", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x06002CAE RID: 11438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025AE")]
	[Address(RVA = "0x1FA2A10", Offset = "0x1FA2B11", VA = "0x1FA2A10", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x06002CAF RID: 11439 RVA: 0x000109F8 File Offset: 0x0000EBF8
	[Token(Token = "0x17000557")]
	public override Vector3 GetTakeLockonPos
	{
		[Token(Token = "0x60025AF")]
		[Address(RVA = "0x1FA2F30", Offset = "0x1FA3031", VA = "0x1FA2F30", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06002CB0 RID: 11440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025B0")]
	[Address(RVA = "0x1FA2FF0", Offset = "0x1FA30F1", VA = "0x1FA2FF0")]
	private void SetupParticleSystem()
	{
	}

	// Token: 0x06002CB1 RID: 11441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025B1")]
	[Address(RVA = "0x1FA1F50", Offset = "0x1FA2051", VA = "0x1FA1F50")]
	public void OnSummon()
	{
	}

	// Token: 0x06002CB2 RID: 11442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025B2")]
	[Address(RVA = "0x1FA1130", Offset = "0x1FA1231", VA = "0x1FA1130")]
	public void SetupMove(GateMovePoint[] gateMovePoints, float moveWaitTime, float moveCompleteTime)
	{
	}

	// Token: 0x06002CB3 RID: 11443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025B3")]
	[Address(RVA = "0x1FA2A60", Offset = "0x1FA2B61", VA = "0x1FA2A60")]
	private void UpdateGateMove()
	{
	}

	// Token: 0x06002CB4 RID: 11444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025B4")]
	[Address(RVA = "0x1F9FDC0", Offset = "0x1F9FEC1", VA = "0x1F9FDC0")]
	public void OnSweep()
	{
	}

	// Token: 0x06002CB5 RID: 11445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025B5")]
	[Address(RVA = "0x1FA3490", Offset = "0x1FA3591", VA = "0x1FA3490")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A3120", Offset = "0x1A3221")]
	private IEnumerator SweepWait()
	{
		return null;
	}

	// Token: 0x06002CB6 RID: 11446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025B6")]
	[Address(RVA = "0x1FA2C70", Offset = "0x1FA2D71", VA = "0x1FA2C70")]
	private void UpdateSweep()
	{
	}

	// Token: 0x06002CB7 RID: 11447 RVA: 0x00010A10 File Offset: 0x0000EC10
	[Token(Token = "0x60025B7")]
	[Address(RVA = "0x1FA3540", Offset = "0x1FA3641", VA = "0x1FA3540", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06002CB8 RID: 11448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025B8")]
	[Address(RVA = "0x1FA3720", Offset = "0x1FA3821", VA = "0x1FA3720", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002CB9 RID: 11449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025B9")]
	[Address(RVA = "0x1FA3790", Offset = "0x1FA3891", VA = "0x1FA3790", Slot = "109")]
	public override void SetStatusController(MonsterStatusBase statusController)
	{
	}

	// Token: 0x06002CBA RID: 11450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025BA")]
	[Address(RVA = "0x1FA3880", Offset = "0x1FA3981", VA = "0x1FA3880")]
	public GateEnemyController()
	{
	}

	// Token: 0x06002CBB RID: 11451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025BB")]
	[Address(RVA = "0x1FA3990", Offset = "0x1FA3A91", VA = "0x1FA3990")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3190", Offset = "0x1A3291")]
	private void <SetStatusController>b__31_0()
	{
	}

	// Token: 0x04007386 RID: 29574
	[Token(Token = "0x4006AA3")]
	[FieldOffset(Offset = "0x4E8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169710", Offset = "0x169811")]
	[SerializeField]
	private GateEnemyModelContainer GateEnemyModelContainer;

	// Token: 0x04007387 RID: 29575
	[Token(Token = "0x4006AA4")]
	[FieldOffset(Offset = "0x4F0")]
	[SerializeField]
	public float SweepWaitTime;

	// Token: 0x04007388 RID: 29576
	[Token(Token = "0x4006AA5")]
	[FieldOffset(Offset = "0x4F4")]
	[SerializeField]
	private float SweepTime;

	// Token: 0x04007389 RID: 29577
	[Token(Token = "0x4006AA6")]
	[FieldOffset(Offset = "0x4F8")]
	[SerializeField]
	private AnimationCurve SweepScale;

	// Token: 0x0400738A RID: 29578
	[Token(Token = "0x4006AA7")]
	[FieldOffset(Offset = "0x500")]
	[SerializeField]
	private AnimationCurve SweepSpeed;

	// Token: 0x0400738B RID: 29579
	[Token(Token = "0x4006AA8")]
	[FieldOffset(Offset = "0x508")]
	[SerializeField]
	private AnimationCurve EaseInOut;

	// Token: 0x0400738C RID: 29580
	[Token(Token = "0x4006AA9")]
	[FieldOffset(Offset = "0x510")]
	private bool IsSweep;

	// Token: 0x0400738D RID: 29581
	[Token(Token = "0x4006AAA")]
	[FieldOffset(Offset = "0x518")]
	private Coroutine SweepCoroutine;

	// Token: 0x0400738E RID: 29582
	[Token(Token = "0x4006AAB")]
	[FieldOffset(Offset = "0x520")]
	private float SweepTimer;

	// Token: 0x0400738F RID: 29583
	[Token(Token = "0x4006AAC")]
	[FieldOffset(Offset = "0x528")]
	private ParticleSystem[] ChildrenParticle;

	// Token: 0x04007390 RID: 29584
	[Token(Token = "0x4006AAD")]
	[FieldOffset(Offset = "0x530")]
	private GateMovePoint[] GateMovePoints;

	// Token: 0x04007391 RID: 29585
	[Token(Token = "0x4006AAE")]
	[FieldOffset(Offset = "0x538")]
	private int NextMoveIndex;

	// Token: 0x04007392 RID: 29586
	[Token(Token = "0x4006AAF")]
	[FieldOffset(Offset = "0x53C")]
	private int NowIndex;

	// Token: 0x04007393 RID: 29587
	[Token(Token = "0x4006AB0")]
	[FieldOffset(Offset = "0x540")]
	private bool IsMove;

	// Token: 0x04007394 RID: 29588
	[Token(Token = "0x4006AB1")]
	[FieldOffset(Offset = "0x544")]
	private float MoveCompleteTime;

	// Token: 0x04007395 RID: 29589
	[Token(Token = "0x4006AB2")]
	[FieldOffset(Offset = "0x548")]
	private float MoveLerpTimer;

	// Token: 0x04007396 RID: 29590
	[Token(Token = "0x4006AB3")]
	[FieldOffset(Offset = "0x54C")]
	private float MoveWaitElpasedTimer;

	// Token: 0x04007397 RID: 29591
	[Token(Token = "0x4006AB4")]
	[FieldOffset(Offset = "0x550")]
	private float MoveWaitTime;

	// Token: 0x020006FC RID: 1788
	[Token(Token = "0x200119A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158410", Offset = "0x158511")]
	private sealed class <SweepWait>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002CBC RID: 11452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071EB")]
		[Address(RVA = "0x1FA3510", Offset = "0x1FA3611", VA = "0x1FA3510")]
		[DebuggerHidden]
		public <SweepWait>d__27(int <>1__state)
		{
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071EC")]
		[Address(RVA = "0x1FA3BC0", Offset = "0x1FA3CC1", VA = "0x1FA3BC0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00010A28 File Offset: 0x0000EC28
		[Token(Token = "0x60071ED")]
		[Address(RVA = "0x1FA3BD0", Offset = "0x1FA3CD1", VA = "0x1FA3BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D19")]
		private object Current
		{
			[Token(Token = "0x60071EE")]
			[Address(RVA = "0x1FA3CA0", Offset = "0x1FA3DA1", VA = "0x1FA3CA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071EF")]
		[Address(RVA = "0x1FA3CB0", Offset = "0x1FA3DB1", VA = "0x1FA3CB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1A")]
		private object Current
		{
			[Token(Token = "0x60071F0")]
			[Address(RVA = "0x1FA3D10", Offset = "0x1FA3E11", VA = "0x1FA3D10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007398 RID: 29592
		[Token(Token = "0x401954C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007399 RID: 29593
		[Token(Token = "0x401954D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400739A RID: 29594
		[Token(Token = "0x401954E")]
		[FieldOffset(Offset = "0x20")]
		public GateEnemyController <>4__this;

		// Token: 0x0400739B RID: 29595
		[Token(Token = "0x401954F")]
		[FieldOffset(Offset = "0x28")]
		private float <timer>5__2;
	}
}
