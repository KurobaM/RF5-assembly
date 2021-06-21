using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005E5 RID: 1509
[Token(Token = "0x200043F")]
public class GimmickMagicCircle : GimmickBase
{
	// Token: 0x0600251A RID: 9498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F48")]
	[Address(RVA = "0x1FE7420", Offset = "0x1FE7521", VA = "0x1FE7420", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F49")]
	[Address(RVA = "0x1FE7560", Offset = "0x1FE7661", VA = "0x1FE7560")]
	private void Update()
	{
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F4A")]
	[Address(RVA = "0x1FE77C0", Offset = "0x1FE78C1", VA = "0x1FE77C0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x0600251D RID: 9501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F4B")]
	[Address(RVA = "0x1FE75B0", Offset = "0x1FE76B1", VA = "0x1FE75B0")]
	private void DamageRp()
	{
	}

	// Token: 0x0600251E RID: 9502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F4C")]
	[Address(RVA = "0x1FE78F0", Offset = "0x1FE79F1", VA = "0x1FE78F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1620", Offset = "0x1A1721")]
	private IEnumerator RemoveCoroutine()
	{
		return null;
	}

	// Token: 0x0600251F RID: 9503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F4D")]
	[Address(RVA = "0x1FE79A0", Offset = "0x1FE7AA1", VA = "0x1FE79A0")]
	private void OnEnterEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x06002520 RID: 9504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F4E")]
	[Address(RVA = "0x1FE7A20", Offset = "0x1FE7B21", VA = "0x1FE7A20")]
	public GimmickMagicCircle()
	{
	}

	// Token: 0x06002521 RID: 9505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F4F")]
	[Address(RVA = "0x1FE7A30", Offset = "0x1FE7B31", VA = "0x1FE7A30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1690", Offset = "0x1A1791")]
	private void <Start>b__6_0(ParticleSystem obj)
	{
	}

	// Token: 0x04006C78 RID: 27768
	[Token(Token = "0x40065A7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167520", Offset = "0x167621")]
	private float DamagePercent;

	// Token: 0x04006C79 RID: 27769
	[Token(Token = "0x40065A8")]
	[FieldOffset(Offset = "0x28")]
	private SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;

	// Token: 0x04006C7A RID: 27770
	[Token(Token = "0x40065A9")]
	[FieldOffset(Offset = "0x30")]
	private bool stayRoom;

	// Token: 0x04006C7B RID: 27771
	[Token(Token = "0x40065AA")]
	[FieldOffset(Offset = "0x31")]
	private bool startDamage;

	// Token: 0x04006C7C RID: 27772
	[Token(Token = "0x40065AB")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem splash_effect_;

	// Token: 0x04006C7D RID: 27773
	[Token(Token = "0x40065AC")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine coroutine_;

	// Token: 0x020005E6 RID: 1510
	[Token(Token = "0x200112F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158070", Offset = "0x158171")]
	private sealed class <RemoveCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002522 RID: 9506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BD")]
		[Address(RVA = "0x1FE7970", Offset = "0x1FE7A71", VA = "0x1FE7970")]
		[DebuggerHidden]
		public <RemoveCoroutine>d__10(int <>1__state)
		{
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070BE")]
		[Address(RVA = "0x1FE7AA0", Offset = "0x1FE7BA1", VA = "0x1FE7AA0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x60070BF")]
		[Address(RVA = "0x1FE7AB0", Offset = "0x1FE7BB1", VA = "0x1FE7AB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF3")]
		private object Current
		{
			[Token(Token = "0x60070C0")]
			[Address(RVA = "0x1FE7D60", Offset = "0x1FE7E61", VA = "0x1FE7D60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C1")]
		[Address(RVA = "0x1FE7D70", Offset = "0x1FE7E71", VA = "0x1FE7D70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF4")]
		private object Current
		{
			[Token(Token = "0x60070C2")]
			[Address(RVA = "0x1FE7DD0", Offset = "0x1FE7ED1", VA = "0x1FE7DD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006C7E RID: 27774
		[Token(Token = "0x4019344")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006C7F RID: 27775
		[Token(Token = "0x4019345")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006C80 RID: 27776
		[Token(Token = "0x4019346")]
		[FieldOffset(Offset = "0x20")]
		public GimmickMagicCircle <>4__this;
	}
}
