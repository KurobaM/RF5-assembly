using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RF5_Sound;
using UnityEngine;

// Token: 0x020005EC RID: 1516
[Token(Token = "0x2000444")]
public class GimmickThunderbolt : GimmickBase
{
	// Token: 0x06002554 RID: 9556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F7C")]
	[Address(RVA = "0x1FEA3B0", Offset = "0x1FEA4B1", VA = "0x1FEA3B0", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x06002555 RID: 9557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F7D")]
	[Address(RVA = "0x1FEA5B0", Offset = "0x1FEA6B1", VA = "0x1FEA5B0")]
	private void Update()
	{
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F7E")]
	[Address(RVA = "0x1FEA920", Offset = "0x1FEAA21", VA = "0x1FEA920", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F7F")]
	[Address(RVA = "0x1FEA880", Offset = "0x1FEA981", VA = "0x1FEA880")]
	private void StartEffect()
	{
	}

	// Token: 0x06002558 RID: 9560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F80")]
	[Address(RVA = "0x1FEAD90", Offset = "0x1FEAE91", VA = "0x1FEAD90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A16D0", Offset = "0x1A17D1")]
	private IEnumerator ThunderboltCoroutine()
	{
		return null;
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F81")]
	[Address(RVA = "0x1FEAE40", Offset = "0x1FEAF41", VA = "0x1FEAE40")]
	private void StopSignEffect()
	{
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F82")]
	[Address(RVA = "0x1FEAEF0", Offset = "0x1FEAFF1", VA = "0x1FEAEF0")]
	private void PlaySignEffect(Vector3 pos, Quaternion rot, float scale)
	{
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F83")]
	[Address(RVA = "0x1FEABA0", Offset = "0x1FEACA1", VA = "0x1FEABA0")]
	private void StopThunderEffect()
	{
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F84")]
	[Address(RVA = "0x1FEB090", Offset = "0x1FEB191", VA = "0x1FEB090")]
	private void PlayThunderEffect(Vector3 pos, Quaternion rot, float scale)
	{
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F85")]
	[Address(RVA = "0x1FEB360", Offset = "0x1FEB461", VA = "0x1FEB360")]
	private void CreateThunderbolt(Vector3 pos, float scale, float damage)
	{
	}

	// Token: 0x0600255E RID: 9566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F86")]
	[Address(RVA = "0x1FEACB0", Offset = "0x1FEADB1", VA = "0x1FEACB0")]
	private void DeleteThunderbolt()
	{
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F87")]
	[Address(RVA = "0x1FEB610", Offset = "0x1FEB711", VA = "0x1FEB610")]
	private void OnStayEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F88")]
	[Address(RVA = "0x1FEB720", Offset = "0x1FEB821", VA = "0x1FEB720")]
	private void OnExitEvent(Collider fromCollider, Collider toCollider)
	{
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F89")]
	[Address(RVA = "0x1FEB830", Offset = "0x1FEB931", VA = "0x1FEB830")]
	public GimmickThunderbolt()
	{
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F8A")]
	[Address(RVA = "0x1FEB930", Offset = "0x1FEBA31", VA = "0x1FEB930")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1740", Offset = "0x1A1841")]
	private void <Start>b__26_0(ParticleSystem obj)
	{
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F8B")]
	[Address(RVA = "0x1FEB9A0", Offset = "0x1FEBAA1", VA = "0x1FEB9A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1750", Offset = "0x1A1851")]
	private void <Start>b__26_1(ParticleSystem obj)
	{
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F8C")]
	[Address(RVA = "0x1FEBA10", Offset = "0x1FEBB11", VA = "0x1FEBA10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1760", Offset = "0x1A1861")]
	private void <Start>b__26_2(ParticleSystem obj)
	{
	}

	// Token: 0x04006C9C RID: 27804
	[Token(Token = "0x40065C4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GimmickThunderbolt.ThunderboltType Type;

	// Token: 0x04006C9D RID: 27805
	[Token(Token = "0x40065C5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject Target;

	// Token: 0x04006C9E RID: 27806
	[Token(Token = "0x40065C6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167850", Offset = "0x167951")]
	private float Damage;

	// Token: 0x04006C9F RID: 27807
	[Token(Token = "0x40065C7")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float AttackKnockbackPower;

	// Token: 0x04006CA0 RID: 27808
	[Token(Token = "0x40065C8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float EffectScale;

	// Token: 0x04006CA1 RID: 27809
	[Token(Token = "0x40065C9")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1678C0", Offset = "0x1679C1")]
	protected float A_Second;

	// Token: 0x04006CA2 RID: 27810
	[Token(Token = "0x40065CA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x167910", Offset = "0x167A11")]
	protected float B_Second_Min;

	// Token: 0x04006CA3 RID: 27811
	[Token(Token = "0x40065CB")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x167960", Offset = "0x167A61")]
	protected float B_Second_Max;

	// Token: 0x04006CA4 RID: 27812
	[Token(Token = "0x40065CC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1679B0", Offset = "0x167AB1")]
	protected float C_Second;

	// Token: 0x04006CA5 RID: 27813
	[Token(Token = "0x40065CD")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Attribute(Name = "TooltipAttribute", RVA = "0x167A00", Offset = "0x167B01")]
	protected float D_Second;

	// Token: 0x04006CA6 RID: 27814
	[Token(Token = "0x40065CE")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x167A50", Offset = "0x167B51")]
	private Vector3 DamageCenter;

	// Token: 0x04006CA7 RID: 27815
	[Token(Token = "0x40065CF")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float DamageRadius;

	// Token: 0x04006CA8 RID: 27816
	[Token(Token = "0x40065D0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float DamageHeight;

	// Token: 0x04006CA9 RID: 27817
	[Token(Token = "0x40065D1")]
	[FieldOffset(Offset = "0x68")]
	private SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;

	// Token: 0x04006CAA RID: 27818
	[Token(Token = "0x40065D2")]
	[FieldOffset(Offset = "0x70")]
	private bool stayRoom;

	// Token: 0x04006CAB RID: 27819
	[Token(Token = "0x40065D3")]
	[FieldOffset(Offset = "0x71")]
	private bool startEffect;

	// Token: 0x04006CAC RID: 27820
	[Token(Token = "0x40065D4")]
	[FieldOffset(Offset = "0x78")]
	private ParticleSystem sign_effect_;

	// Token: 0x04006CAD RID: 27821
	[Token(Token = "0x40065D5")]
	[FieldOffset(Offset = "0x80")]
	private ParticleSystem thunder_effect_;

	// Token: 0x04006CAE RID: 27822
	[Token(Token = "0x40065D6")]
	[FieldOffset(Offset = "0x88")]
	private ParticleSystem thunder_loop_effect_;

	// Token: 0x04006CAF RID: 27823
	[Token(Token = "0x40065D7")]
	[FieldOffset(Offset = "0x90")]
	private Coroutine coroutine_;

	// Token: 0x04006CB0 RID: 27824
	[Token(Token = "0x40065D8")]
	[FieldOffset(Offset = "0x98")]
	private float CurrentTime;

	// Token: 0x04006CB1 RID: 27825
	[Token(Token = "0x40065D9")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 targetPos;

	// Token: 0x04006CB2 RID: 27826
	[Token(Token = "0x40065DA")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject Thunderbolt;

	// Token: 0x04006CB3 RID: 27827
	[Token(Token = "0x40065DB")]
	[FieldOffset(Offset = "0xB0")]
	private SoundID soundID;

	// Token: 0x04006CB4 RID: 27828
	[Token(Token = "0x40065DC")]
	[FieldOffset(Offset = "0xB8")]
	private SEController se_controller;

	// Token: 0x020005ED RID: 1517
	[Token(Token = "0x2001131")]
	public enum ThunderboltType
	{
		// Token: 0x04006CB6 RID: 27830
		[Token(Token = "0x401934C")]
		TYPE_A,
		// Token: 0x04006CB7 RID: 27831
		[Token(Token = "0x401934D")]
		TYPE_B
	}

	// Token: 0x020005EE RID: 1518
	[Token(Token = "0x2001132")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158080", Offset = "0x158181")]
	private sealed class <ThunderboltCoroutine>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002565 RID: 9573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C3")]
		[Address(RVA = "0x1FEAE10", Offset = "0x1FEAF11", VA = "0x1FEAE10")]
		[DebuggerHidden]
		public <ThunderboltCoroutine>d__30(int <>1__state)
		{
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C4")]
		[Address(RVA = "0x1FEBA80", Offset = "0x1FEBB81", VA = "0x1FEBA80", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[Token(Token = "0x60070C5")]
		[Address(RVA = "0x1FEBA90", Offset = "0x1FEBB91", VA = "0x1FEBA90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF5")]
		private object Current
		{
			[Token(Token = "0x60070C6")]
			[Address(RVA = "0x1FEBD60", Offset = "0x1FEBE61", VA = "0x1FEBD60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C7")]
		[Address(RVA = "0x1FEBD70", Offset = "0x1FEBE71", VA = "0x1FEBD70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF6")]
		private object Current
		{
			[Token(Token = "0x60070C8")]
			[Address(RVA = "0x1FEBDD0", Offset = "0x1FEBED1", VA = "0x1FEBDD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006CB8 RID: 27832
		[Token(Token = "0x401934E")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006CB9 RID: 27833
		[Token(Token = "0x401934F")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006CBA RID: 27834
		[Token(Token = "0x4019350")]
		[FieldOffset(Offset = "0x20")]
		public GimmickThunderbolt <>4__this;
	}
}
