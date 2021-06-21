using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002CA RID: 714
[Token(Token = "0x200022D")]
public class SpcMonsterController : MonsterControllerBase
{
	// Token: 0x17000365 RID: 869
	// (get) Token: 0x06001306 RID: 4870 RVA: 0x000089E8 File Offset: 0x00006BE8
	[Token(Token = "0x17000335")]
	private Vector3 lookat
	{
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x2261D80", Offset = "0x2261E81", VA = "0x2261D80")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001156")]
	[Address(RVA = "0x2261DA0", Offset = "0x2261EA1", VA = "0x2261DA0", Slot = "146")]
	public override string GetFocusName()
	{
		return null;
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001157")]
	[Address(RVA = "0x2261DF0", Offset = "0x2261EF1", VA = "0x2261DF0", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001158")]
	[Address(RVA = "0x2261EB0", Offset = "0x2261FB1", VA = "0x2261EB0", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001159")]
	[Address(RVA = "0x2262610", Offset = "0x2262711", VA = "0x2262610", Slot = "107")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19C8E0", Offset = "0x19C9E1")]
	public override IEnumerator SetupAsync([Optional] Action callBack)
	{
		return null;
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x22626E0", Offset = "0x22627E1", VA = "0x22626E0")]
	public void SetShortPlayMovePosition(Vector3 _targetPosition, float _moveSpeed, float _locomotion)
	{
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x22627B0", Offset = "0x22628B1", VA = "0x22627B0", Slot = "123")]
	public override void ShortPlay()
	{
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115C")]
	[Address(RVA = "0x2262800", Offset = "0x2262901", VA = "0x2262800", Slot = "124")]
	public override void ShortPlayExit()
	{
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115D")]
	[Address(RVA = "0x2262190", Offset = "0x2262291", VA = "0x2262190")]
	public void UpdateMovePosition()
	{
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115E")]
	[Address(RVA = "0x2261EE0", Offset = "0x2261FE1", VA = "0x2261EE0")]
	public void UpdateOnGround()
	{
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600115F")]
	[Address(RVA = "0x2262C50", Offset = "0x2262D51", VA = "0x2262C50")]
	public void LookAtTargetShortPlay(Quaternion q)
	{
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001160")]
	[Address(RVA = "0x2262DC0", Offset = "0x2262EC1", VA = "0x2262DC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19C950", Offset = "0x19CA51")]
	public IEnumerator LookAtTargetShortPlayEnd()
	{
		return null;
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001161")]
	[Address(RVA = "0x22628D0", Offset = "0x22629D1", VA = "0x22628D0")]
	private void UpdateLookAtRotation()
	{
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001162")]
	[Address(RVA = "0x2262E70", Offset = "0x2262F71", VA = "0x2262E70")]
	public SpcMonsterController()
	{
	}

	// Token: 0x04000ABB RID: 2747
	[Token(Token = "0x4000862")]
	private const float MaxSpeedTime = 1f;

	// Token: 0x04000ABC RID: 2748
	[Token(Token = "0x4000863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
	[SerializeField]
	public bool IsSlowdown;

	// Token: 0x04000ABD RID: 2749
	[Token(Token = "0x4000864")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E9")]
	[SerializeField]
	public bool IsStop;

	// Token: 0x04000ABE RID: 2750
	[Token(Token = "0x4000865")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4EA")]
	[SerializeField]
	public bool IsHurry;

	// Token: 0x04000ABF RID: 2751
	[Token(Token = "0x4000866")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4EC")]
	[SerializeField]
	public float ShortPlayMoveSpeed;

	// Token: 0x04000AC0 RID: 2752
	[Token(Token = "0x4000867")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
	[SerializeField]
	public float ShortPlayLocomotion;

	// Token: 0x04000AC1 RID: 2753
	[Token(Token = "0x4000868")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F4")]
	[SerializeField]
	public float ShortPlayTargetMoveSpeed;

	// Token: 0x04000AC2 RID: 2754
	[Token(Token = "0x4000869")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
	[SerializeField]
	public float ShortPlayTargetLocomotion;

	// Token: 0x04000AC3 RID: 2755
	[Token(Token = "0x400086A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
	public Transform ShortPlayLookAtTarget;

	// Token: 0x04000AC4 RID: 2756
	[Token(Token = "0x400086B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
	public Vector3 lookatRotate;

	// Token: 0x04000AC5 RID: 2757
	[Token(Token = "0x400086C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x514")]
	private LookAtState lookAtState;

	// Token: 0x04000AC6 RID: 2758
	[Token(Token = "0x400086D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
	public float Acceleration;

	// Token: 0x04000AC7 RID: 2759
	[Token(Token = "0x400086E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51C")]
	public Quaternion ShortPlayRotation;

	// Token: 0x020002CB RID: 715
	[Token(Token = "0x2001026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157360", Offset = "0x157461")]
	private sealed class <SetupAsync>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001314 RID: 4884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9C")]
		[Address(RVA = "0x22626B0", Offset = "0x22627B1", VA = "0x22626B0")]
		[DebuggerHidden]
		public <SetupAsync>d__18(int <>1__state)
		{
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9D")]
		[Address(RVA = "0x2263060", Offset = "0x2263161", VA = "0x2263060", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x6006C9E")]
		[Address(RVA = "0x2263070", Offset = "0x2263171", VA = "0x2263070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BED")]
		private object Current
		{
			[Token(Token = "0x6006C9F")]
			[Address(RVA = "0x2263100", Offset = "0x2263201", VA = "0x2263100", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA0")]
		[Address(RVA = "0x2263110", Offset = "0x2263211", VA = "0x2263110", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEE")]
		private object Current
		{
			[Token(Token = "0x6006CA1")]
			[Address(RVA = "0x2263170", Offset = "0x2263271", VA = "0x2263170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4018ECC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4018ECD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4018ECE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpcMonsterController <>4__this;

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4018ECF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;
	}

	// Token: 0x020002CC RID: 716
	[Token(Token = "0x2001027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157370", Offset = "0x157471")]
	private sealed class <LookAtTargetShortPlayEnd>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600131A RID: 4890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA2")]
		[Address(RVA = "0x2262E40", Offset = "0x2262F41", VA = "0x2262E40")]
		[DebuggerHidden]
		public <LookAtTargetShortPlayEnd>d__25(int <>1__state)
		{
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA3")]
		[Address(RVA = "0x2262EF0", Offset = "0x2262FF1", VA = "0x2262EF0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x6006CA4")]
		[Address(RVA = "0x2262F00", Offset = "0x2263001", VA = "0x2262F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEF")]
		private object Current
		{
			[Token(Token = "0x6006CA5")]
			[Address(RVA = "0x2262FE0", Offset = "0x22630E1", VA = "0x2262FE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA6")]
		[Address(RVA = "0x2262FF0", Offset = "0x22630F1", VA = "0x2262FF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF0")]
		private object Current
		{
			[Token(Token = "0x6006CA7")]
			[Address(RVA = "0x2263050", Offset = "0x2263151", VA = "0x2263050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4018ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4018ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4018ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpcMonsterController <>4__this;
	}
}
