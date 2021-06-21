using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x020005D2 RID: 1490
[Token(Token = "0x2000432")]
[Attribute(Name = "RequireComponent", RVA = "0x146140", Offset = "0x146241")]
[Attribute(Name = "RequireComponent", RVA = "0x146140", Offset = "0x146241")]
public class GimmickBreakeObject : GimmickBase
{
	// Token: 0x170005EE RID: 1518
	// (get) Token: 0x0600248C RID: 9356 RVA: 0x0000EC70 File Offset: 0x0000CE70
	// (set) Token: 0x0600248D RID: 9357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004C0")]
	public bool IsBreakFade
	{
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x1FDF950", Offset = "0x1FDFA51", VA = "0x1FDF950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1350", Offset = "0x1A1451")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x1FDF960", Offset = "0x1FDFA61", VA = "0x1FDF960")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1360", Offset = "0x1A1461")]
		protected set
		{
		}
	}

	// Token: 0x0600248E RID: 9358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED4")]
	[Address(RVA = "0x1FDF970", Offset = "0x1FDFA71", VA = "0x1FDF970", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x0600248F RID: 9359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED5")]
	[Address(RVA = "0x1FDFA00", Offset = "0x1FDFB01", VA = "0x1FDFA00")]
	private void LoadEffect()
	{
	}

	// Token: 0x06002490 RID: 9360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED6")]
	[Address(RVA = "0x1FDFB70", Offset = "0x1FDFC71", VA = "0x1FDFB70", Slot = "11")]
	protected virtual void SetEnableCollider(bool isEnable)
	{
	}

	// Token: 0x06002491 RID: 9361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED7")]
	[Address(RVA = "0x1FDFC80", Offset = "0x1FDFD81", VA = "0x1FDFC80", Slot = "12")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06002492 RID: 9362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED8")]
	[Address(RVA = "0x1FDFE50", Offset = "0x1FDFF51", VA = "0x1FDFE50", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x06002493 RID: 9363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED9")]
	[Address(RVA = "0x1FDFE60", Offset = "0x1FDFF61", VA = "0x1FDFE60", Slot = "7")]
	public override void SetGimmickState(bool newState)
	{
	}

	// Token: 0x06002494 RID: 9364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EDA")]
	[Address(RVA = "0x1FDFEE0", Offset = "0x1FDFFE1", VA = "0x1FDFEE0", Slot = "9")]
	public override void Init()
	{
	}

	// Token: 0x06002495 RID: 9365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EDB")]
	[Address(RVA = "0x1FDFFD0", Offset = "0x1FE00D1", VA = "0x1FDFFD0", Slot = "13")]
	public virtual void SetGimmickFlag(bool setValue)
	{
	}

	// Token: 0x06002496 RID: 9366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EDC")]
	[Address(RVA = "0x1FE0090", Offset = "0x1FE0191", VA = "0x1FE0090", Slot = "10")]
	public override void SetGimmickActiveFlag(bool isActive)
	{
	}

	// Token: 0x06002497 RID: 9367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EDD")]
	[Address(RVA = "0x1FE0210", Offset = "0x1FE0311", VA = "0x1FE0210", Slot = "14")]
	public virtual void Breake(Vector3 hitPoint)
	{
	}

	// Token: 0x06002498 RID: 9368 RVA: 0x0000EC88 File Offset: 0x0000CE88
	[Token(Token = "0x6001EDE")]
	[Address(RVA = "0x1FE0560", Offset = "0x1FE0661", VA = "0x1FE0560", Slot = "15")]
	public virtual bool InvalieEffect(ref DamageInfo damageInfo)
	{
		return default(bool);
	}

	// Token: 0x06002499 RID: 9369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EDF")]
	[Address(RVA = "0x1FE03C0", Offset = "0x1FE04C1", VA = "0x1FE03C0")]
	private void FadeInit()
	{
	}

	// Token: 0x0600249A RID: 9370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EE0")]
	[Address(RVA = "0x1FE0740", Offset = "0x1FE0841", VA = "0x1FE0740")]
	private void FadeIn(float time = 1f, [Optional] Action action)
	{
	}

	// Token: 0x0600249B RID: 9371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EE1")]
	[Address(RVA = "0x1FE0470", Offset = "0x1FE0571", VA = "0x1FE0470")]
	private void FadeOut(float time = 1f, [Optional] Action action)
	{
	}

	// Token: 0x0600249C RID: 9372 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0x1FE0830", Offset = "0x1FE0931", VA = "0x1FE0830")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1370", Offset = "0x1A1471")]
	private IEnumerator Fade(float start, float end, float fade_time, [Optional] Action action)
	{
		return null;
	}

	// Token: 0x0600249D RID: 9373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0x1FE00F0", Offset = "0x1FE01F1", VA = "0x1FE00F0")]
	private void SetAlpha(float alpha)
	{
	}

	// Token: 0x0600249E RID: 9374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EE4")]
	[Address(RVA = "0x1FE0920", Offset = "0x1FE0A21", VA = "0x1FE0920")]
	private void FadeWaitStart(float time)
	{
	}

	// Token: 0x0600249F RID: 9375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EE5")]
	[Address(RVA = "0x1FE09F0", Offset = "0x1FE0AF1", VA = "0x1FE09F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A13E0", Offset = "0x1A14E1")]
	private IEnumerator FadeWait(float fade_time)
	{
		return null;
	}

	// Token: 0x060024A0 RID: 9376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EE6")]
	[Address(RVA = "0x1FE0AB0", Offset = "0x1FE0BB1", VA = "0x1FE0AB0")]
	public GimmickBreakeObject()
	{
	}

	// Token: 0x060024A1 RID: 9377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EE7")]
	[Address(RVA = "0x1FE0B20", Offset = "0x1FE0C21", VA = "0x1FE0B20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1450", Offset = "0x1A1551")]
	private void <LoadEffect>b__17_0(ParticleSystem effect)
	{
	}

	// Token: 0x060024A2 RID: 9378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0x1FE0C10", Offset = "0x1FE0D11", VA = "0x1FE0C10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1460", Offset = "0x1A1561")]
	private void <Breake>b__25_0()
	{
	}

	// Token: 0x060024A3 RID: 9379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0x1FE0C30", Offset = "0x1FE0D31", VA = "0x1FE0C30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1470", Offset = "0x1A1571")]
	private void <Breake>b__25_1()
	{
	}

	// Token: 0x04006BF5 RID: 27637
	[Token(Token = "0x4006545")]
	protected const string EffectRootName = "EffectRoot";

	// Token: 0x04006BF6 RID: 27638
	[Token(Token = "0x4006546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public EffectID EffectId;

	// Token: 0x04006BF7 RID: 27639
	[Token(Token = "0x4006547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform EffectRoot;

	// Token: 0x04006BF8 RID: 27640
	[Token(Token = "0x4006548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string SpawnItemIDString;

	// Token: 0x04006BF9 RID: 27641
	[Token(Token = "0x4006549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ItemID SpawnItemID;

	// Token: 0x04006BFA RID: 27642
	[Token(Token = "0x400654A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public int SpawnCount;

	// Token: 0x04006BFB RID: 27643
	[Token(Token = "0x400654B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float FadeOutTime;

	// Token: 0x04006BFC RID: 27644
	[Token(Token = "0x400654C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	protected SoundID SeId;

	// Token: 0x04006BFD RID: 27645
	[Token(Token = "0x400654D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Collider WallCollider;

	// Token: 0x04006BFE RID: 27646
	[Token(Token = "0x400654E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private NavMeshObstacle NavMeshObstacle;

	// Token: 0x04006BFF RID: 27647
	[Token(Token = "0x400654F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject Object;

	// Token: 0x04006C00 RID: 27648
	[Token(Token = "0x4006550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ParticleSystem Effect;

	// Token: 0x04006C01 RID: 27649
	[Token(Token = "0x4006551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x167190", Offset = "0x167291")]
	private bool <IsBreakFade>k__BackingField;

	// Token: 0x04006C02 RID: 27650
	[Token(Token = "0x4006552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Renderer[] _renderer;

	// Token: 0x04006C03 RID: 27651
	[Token(Token = "0x4006553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private MaterialPropertyBlock materialPropertyBlock;

	// Token: 0x04006C04 RID: 27652
	[Token(Token = "0x4006554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Coroutine fadeCoroutine;

	// Token: 0x020005D3 RID: 1491
	[Token(Token = "0x2001129")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158030", Offset = "0x158131")]
	private sealed class <Fade>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060024A4 RID: 9380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A5")]
		[Address(RVA = "0x1FE08F0", Offset = "0x1FE09F1", VA = "0x1FE08F0")]
		[DebuggerHidden]
		public <Fade>d__33(int <>1__state)
		{
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A6")]
		[Address(RVA = "0x1FE0F30", Offset = "0x1FE1031", VA = "0x1FE0F30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		[Token(Token = "0x60070A7")]
		[Address(RVA = "0x1FE0F40", Offset = "0x1FE1041", VA = "0x1FE0F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEB")]
		private object Current
		{
			[Token(Token = "0x60070A8")]
			[Address(RVA = "0x1FE1080", Offset = "0x1FE1181", VA = "0x1FE1080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A9")]
		[Address(RVA = "0x1FE1090", Offset = "0x1FE1191", VA = "0x1FE1090", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEC")]
		private object Current
		{
			[Token(Token = "0x60070AA")]
			[Address(RVA = "0x1FE10F0", Offset = "0x1FE11F1", VA = "0x1FE10F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006C05 RID: 27653
		[Token(Token = "0x4019323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006C06 RID: 27654
		[Token(Token = "0x4019324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006C07 RID: 27655
		[Token(Token = "0x4019325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fade_time;

		// Token: 0x04006C08 RID: 27656
		[Token(Token = "0x4019326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GimmickBreakeObject <>4__this;

		// Token: 0x04006C09 RID: 27657
		[Token(Token = "0x4019327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float end;

		// Token: 0x04006C0A RID: 27658
		[Token(Token = "0x4019328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float start;

		// Token: 0x04006C0B RID: 27659
		[Token(Token = "0x4019329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action action;

		// Token: 0x04006C0C RID: 27660
		[Token(Token = "0x401932A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <time>5__2;
	}

	// Token: 0x020005D4 RID: 1492
	[Token(Token = "0x200112A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158040", Offset = "0x158141")]
	private sealed class <FadeWait>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060024AA RID: 9386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070AB")]
		[Address(RVA = "0x1FE0A80", Offset = "0x1FE0B81", VA = "0x1FE0A80")]
		[DebuggerHidden]
		public <FadeWait>d__36(int <>1__state)
		{
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070AC")]
		[Address(RVA = "0x1FE1100", Offset = "0x1FE1201", VA = "0x1FE1100", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		[Token(Token = "0x60070AD")]
		[Address(RVA = "0x1FE1110", Offset = "0x1FE1211", VA = "0x1FE1110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CED")]
		private object Current
		{
			[Token(Token = "0x60070AE")]
			[Address(RVA = "0x1FE11E0", Offset = "0x1FE12E1", VA = "0x1FE11E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070AF")]
		[Address(RVA = "0x1FE11F0", Offset = "0x1FE12F1", VA = "0x1FE11F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEE")]
		private object Current
		{
			[Token(Token = "0x60070B0")]
			[Address(RVA = "0x1FE1250", Offset = "0x1FE1351", VA = "0x1FE1250", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006C0D RID: 27661
		[Token(Token = "0x401932B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006C0E RID: 27662
		[Token(Token = "0x401932C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006C0F RID: 27663
		[Token(Token = "0x401932D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fade_time;

		// Token: 0x04006C10 RID: 27664
		[Token(Token = "0x401932E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GimmickBreakeObject <>4__this;

		// Token: 0x04006C11 RID: 27665
		[Token(Token = "0x401932F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;
	}
}
