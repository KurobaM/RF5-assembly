using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005E2 RID: 1506
[Token(Token = "0x200043E")]
public class GimmickMagicArrowShot : MonoBehaviour
{
	// Token: 0x06002502 RID: 9474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F3C")]
	[Address(RVA = "0x1FE58A0", Offset = "0x1FE59A1", VA = "0x1FE58A0")]
	public void SetSpeed(Vector3 dir, float damage, float knockback)
	{
	}

	// Token: 0x06002503 RID: 9475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F3D")]
	[Address(RVA = "0x1FE6110", Offset = "0x1FE6211", VA = "0x1FE6110")]
	private void Awake()
	{
	}

	// Token: 0x06002504 RID: 9476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F3E")]
	[Address(RVA = "0x1FE6530", Offset = "0x1FE6631", VA = "0x1FE6530")]
	private void Start()
	{
	}

	// Token: 0x06002505 RID: 9477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F3F")]
	[Address(RVA = "0x1FE65D0", Offset = "0x1FE66D1", VA = "0x1FE65D0")]
	private void Update()
	{
	}

	// Token: 0x06002506 RID: 9478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F40")]
	[Address(RVA = "0x1FE67A0", Offset = "0x1FE68A1", VA = "0x1FE67A0")]
	private void OnStayEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x06002507 RID: 9479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F41")]
	[Address(RVA = "0x1FE6CF0", Offset = "0x1FE6DF1", VA = "0x1FE6CF0")]
	public void FadeOut(float time = 1f)
	{
	}

	// Token: 0x06002508 RID: 9480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F42")]
	[Address(RVA = "0x1FE6DD0", Offset = "0x1FE6ED1", VA = "0x1FE6DD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1530", Offset = "0x1A1631")]
	private IEnumerator Fade(float start, float end, float fade_time)
	{
		return null;
	}

	// Token: 0x06002509 RID: 9481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F43")]
	[Address(RVA = "0x1FE64B0", Offset = "0x1FE65B1", VA = "0x1FE64B0")]
	public void SetAlpha(float alpha)
	{
	}

	// Token: 0x0600250A RID: 9482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F44")]
	[Address(RVA = "0x1FE6C20", Offset = "0x1FE6D21", VA = "0x1FE6C20")]
	public void ShotEffectStop(float time = 1f)
	{
	}

	// Token: 0x0600250B RID: 9483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F45")]
	[Address(RVA = "0x1FE6EA0", Offset = "0x1FE6FA1", VA = "0x1FE6EA0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A15A0", Offset = "0x1A16A1")]
	private IEnumerator Wait(float time)
	{
		return null;
	}

	// Token: 0x0600250C RID: 9484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F46")]
	[Address(RVA = "0x1FE6F60", Offset = "0x1FE7061", VA = "0x1FE6F60")]
	public GimmickMagicArrowShot()
	{
	}

	// Token: 0x0600250D RID: 9485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F47")]
	[Address(RVA = "0x1FE6FE0", Offset = "0x1FE70E1", VA = "0x1FE6FE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1610", Offset = "0x1A1711")]
	private void <Awake>b__11_0(ParticleSystem obj)
	{
	}

	// Token: 0x04006C5F RID: 27743
	[Token(Token = "0x4006599")]
	[FieldOffset(Offset = "0x18")]
	public float ColliderStartTime;

	// Token: 0x04006C60 RID: 27744
	[Token(Token = "0x400659A")]
	[FieldOffset(Offset = "0x1C")]
	public float FadeOutTime;

	// Token: 0x04006C61 RID: 27745
	[Token(Token = "0x400659B")]
	[FieldOffset(Offset = "0x20")]
	public float ShotEffectStopTime;

	// Token: 0x04006C62 RID: 27746
	[Token(Token = "0x400659C")]
	[FieldOffset(Offset = "0x24")]
	private float arrowDamage;

	// Token: 0x04006C63 RID: 27747
	[Token(Token = "0x400659D")]
	[FieldOffset(Offset = "0x28")]
	private float AttackKnockbackPower;

	// Token: 0x04006C64 RID: 27748
	[Token(Token = "0x400659E")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 Dir;

	// Token: 0x04006C65 RID: 27749
	[Token(Token = "0x400659F")]
	[FieldOffset(Offset = "0x38")]
	private float Life;

	// Token: 0x04006C66 RID: 27750
	[Token(Token = "0x40065A0")]
	[FieldOffset(Offset = "0x40")]
	private SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;

	// Token: 0x04006C67 RID: 27751
	[Token(Token = "0x40065A1")]
	[FieldOffset(Offset = "0x48")]
	private CapsuleCollider _collider;

	// Token: 0x04006C68 RID: 27752
	[Token(Token = "0x40065A2")]
	[FieldOffset(Offset = "0x50")]
	private ParticleSystem Monster_Goblin_Ork01;

	// Token: 0x04006C69 RID: 27753
	[Token(Token = "0x40065A3")]
	[FieldOffset(Offset = "0x58")]
	private Renderer _renderer;

	// Token: 0x04006C6A RID: 27754
	[Token(Token = "0x40065A4")]
	[FieldOffset(Offset = "0x60")]
	private MaterialPropertyBlock materialPropertyBlock;

	// Token: 0x04006C6B RID: 27755
	[Token(Token = "0x40065A5")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine fadeCoroutine;

	// Token: 0x04006C6C RID: 27756
	[Token(Token = "0x40065A6")]
	[FieldOffset(Offset = "0x70")]
	private Coroutine stopCoroutine;

	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x200112D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158050", Offset = "0x158151")]
	private sealed class <Fade>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600250E RID: 9486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B1")]
		[Address(RVA = "0x1FE6E70", Offset = "0x1FE6F71", VA = "0x1FE6E70")]
		[DebuggerHidden]
		public <Fade>d__19(int <>1__state)
		{
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B2")]
		[Address(RVA = "0x1FE6FF0", Offset = "0x1FE70F1", VA = "0x1FE6FF0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x60070B3")]
		[Address(RVA = "0x1FE7000", Offset = "0x1FE7101", VA = "0x1FE7000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEF")]
		private object Current
		{
			[Token(Token = "0x60070B4")]
			[Address(RVA = "0x1FE71C0", Offset = "0x1FE72C1", VA = "0x1FE71C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B5")]
		[Address(RVA = "0x1FE71D0", Offset = "0x1FE72D1", VA = "0x1FE71D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF0")]
		private object Current
		{
			[Token(Token = "0x60070B6")]
			[Address(RVA = "0x1FE7230", Offset = "0x1FE7331", VA = "0x1FE7230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006C6D RID: 27757
		[Token(Token = "0x4019339")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006C6E RID: 27758
		[Token(Token = "0x401933A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006C6F RID: 27759
		[Token(Token = "0x401933B")]
		[FieldOffset(Offset = "0x20")]
		public float fade_time;

		// Token: 0x04006C70 RID: 27760
		[Token(Token = "0x401933C")]
		[FieldOffset(Offset = "0x28")]
		public GimmickMagicArrowShot <>4__this;

		// Token: 0x04006C71 RID: 27761
		[Token(Token = "0x401933D")]
		[FieldOffset(Offset = "0x30")]
		public float end;

		// Token: 0x04006C72 RID: 27762
		[Token(Token = "0x401933E")]
		[FieldOffset(Offset = "0x34")]
		public float start;

		// Token: 0x04006C73 RID: 27763
		[Token(Token = "0x401933F")]
		[FieldOffset(Offset = "0x38")]
		private float <time>5__2;
	}

	// Token: 0x020005E4 RID: 1508
	[Token(Token = "0x200112E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158060", Offset = "0x158161")]
	private sealed class <Wait>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002514 RID: 9492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B7")]
		[Address(RVA = "0x1FE6F30", Offset = "0x1FE7031", VA = "0x1FE6F30")]
		[DebuggerHidden]
		public <Wait>d__23(int <>1__state)
		{
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070B8")]
		[Address(RVA = "0x1FE7240", Offset = "0x1FE7341", VA = "0x1FE7240", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[Token(Token = "0x60070B9")]
		[Address(RVA = "0x1FE7250", Offset = "0x1FE7351", VA = "0x1FE7250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF1")]
		private object Current
		{
			[Token(Token = "0x60070BA")]
			[Address(RVA = "0x1FE73A0", Offset = "0x1FE74A1", VA = "0x1FE73A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BB")]
		[Address(RVA = "0x1FE73B0", Offset = "0x1FE74B1", VA = "0x1FE73B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF2")]
		private object Current
		{
			[Token(Token = "0x60070BC")]
			[Address(RVA = "0x1FE7410", Offset = "0x1FE7511", VA = "0x1FE7410", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006C74 RID: 27764
		[Token(Token = "0x4019340")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006C75 RID: 27765
		[Token(Token = "0x4019341")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006C76 RID: 27766
		[Token(Token = "0x4019342")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		// Token: 0x04006C77 RID: 27767
		[Token(Token = "0x4019343")]
		[FieldOffset(Offset = "0x28")]
		public GimmickMagicArrowShot <>4__this;
	}
}
