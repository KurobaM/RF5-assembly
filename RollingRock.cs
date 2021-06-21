using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RF5_Sound;
using SplineMesh;
using UnityEngine;

// Token: 0x020005F9 RID: 1529
[Token(Token = "0x200044D")]
public class RollingRock : MonoBehaviour
{
	// Token: 0x060025CB RID: 9675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FE1")]
	[Address(RVA = "0x24930F0", Offset = "0x24931F1", VA = "0x24930F0")]
	private void Awake()
	{
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FE2")]
	[Address(RVA = "0x2493350", Offset = "0x2493451", VA = "0x2493350")]
	private void Start()
	{
	}

	// Token: 0x060025CD RID: 9677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FE3")]
	[Address(RVA = "0x2493520", Offset = "0x2493621", VA = "0x2493520")]
	private void OnDestroy()
	{
	}

	// Token: 0x060025CE RID: 9678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FE4")]
	[Address(RVA = "0x2493640", Offset = "0x2493741", VA = "0x2493640")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060025CF RID: 9679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FE5")]
	[Address(RVA = "0x2493AE0", Offset = "0x2493BE1", VA = "0x2493AE0")]
	private void Update()
	{
	}

	// Token: 0x060025D0 RID: 9680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FE6")]
	[Address(RVA = "0x2493E10", Offset = "0x2493F11", VA = "0x2493E10")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060025D1 RID: 9681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FE7")]
	[Address(RVA = "0x2493780", Offset = "0x2493881", VA = "0x2493780")]
	private void Break()
	{
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FE8")]
	[Address(RVA = "0x24931F0", Offset = "0x24932F1", VA = "0x24931F0")]
	private void FadeInit()
	{
	}

	// Token: 0x060025D3 RID: 9683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0x2493440", Offset = "0x2493541", VA = "0x2493440")]
	private void FadeIn(float time = 1f)
	{
	}

	// Token: 0x060025D4 RID: 9684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FEA")]
	[Address(RVA = "0x2494470", Offset = "0x2494571", VA = "0x2494470")]
	private void FadeOut(float time = 1f)
	{
	}

	// Token: 0x060025D5 RID: 9685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0x24943D0", Offset = "0x24944D1", VA = "0x24943D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A18E0", Offset = "0x1A19E1")]
	private IEnumerator Fade(float start, float end, float fade_time)
	{
		return null;
	}

	// Token: 0x060025D6 RID: 9686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0x24942B0", Offset = "0x24943B1", VA = "0x24942B0")]
	private void SetAlpha(float alpha)
	{
	}

	// Token: 0x060025D7 RID: 9687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FED")]
	[Address(RVA = "0x2493530", Offset = "0x2493631", VA = "0x2493530")]
	private void FadeDestory()
	{
	}

	// Token: 0x060025D8 RID: 9688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0x24941E0", Offset = "0x24942E1", VA = "0x24941E0")]
	private void FadeWaitStart(float time)
	{
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0x2494550", Offset = "0x2494651", VA = "0x2494550")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1950", Offset = "0x1A1A51")]
	private IEnumerator FadeWait(float fade_time)
	{
		return null;
	}

	// Token: 0x060025DA RID: 9690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0x24945E0", Offset = "0x24946E1", VA = "0x24945E0")]
	public RollingRock()
	{
	}

	// Token: 0x04006D0C RID: 27916
	[Token(Token = "0x4006624")]
	[FieldOffset(Offset = "0x18")]
	public Spline Spline;

	// Token: 0x04006D0D RID: 27917
	[Token(Token = "0x4006625")]
	[FieldOffset(Offset = "0x20")]
	public float Damage;

	// Token: 0x04006D0E RID: 27918
	[Token(Token = "0x4006626")]
	[FieldOffset(Offset = "0x24")]
	public float AttackKnockbackPower;

	// Token: 0x04006D0F RID: 27919
	[Token(Token = "0x4006627")]
	[FieldOffset(Offset = "0x28")]
	public float MoveSpeed;

	// Token: 0x04006D10 RID: 27920
	[Token(Token = "0x4006628")]
	[FieldOffset(Offset = "0x2C")]
	public float FadeInTime;

	// Token: 0x04006D11 RID: 27921
	[Token(Token = "0x4006629")]
	[FieldOffset(Offset = "0x30")]
	public float FadeOutTime;

	// Token: 0x04006D12 RID: 27922
	[Token(Token = "0x400662A")]
	[FieldOffset(Offset = "0x34")]
	public float FadeOutStartTime;

	// Token: 0x04006D13 RID: 27923
	[Token(Token = "0x400662B")]
	[FieldOffset(Offset = "0x38")]
	private SphereCollider SphereCollider;

	// Token: 0x04006D14 RID: 27924
	[Token(Token = "0x400662C")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody[] Rigidbodys;

	// Token: 0x04006D15 RID: 27925
	[Token(Token = "0x400662D")]
	[FieldOffset(Offset = "0x48")]
	private MeshCollider[] MeshColliders;

	// Token: 0x04006D16 RID: 27926
	[Token(Token = "0x400662E")]
	[FieldOffset(Offset = "0x50")]
	private bool IsBreak;

	// Token: 0x04006D17 RID: 27927
	[Token(Token = "0x400662F")]
	[FieldOffset(Offset = "0x54")]
	private float MovedDistance;

	// Token: 0x04006D18 RID: 27928
	[Token(Token = "0x4006630")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 PrebPoint;

	// Token: 0x04006D19 RID: 27929
	[Token(Token = "0x4006631")]
	[FieldOffset(Offset = "0x64")]
	private Quaternion CurrentRolling;

	// Token: 0x04006D1A RID: 27930
	[Token(Token = "0x4006632")]
	[FieldOffset(Offset = "0x78")]
	private Transform Children;

	// Token: 0x04006D1B RID: 27931
	[Token(Token = "0x4006633")]
	private const SoundID BreakSe = SoundID.RF5_SE_field_gimmick8;

	// Token: 0x04006D1C RID: 27932
	[Token(Token = "0x4006634")]
	private const SoundID GorogoroSe = SoundID.RF5_SE_field_gimmick7;

	// Token: 0x04006D1D RID: 27933
	[Token(Token = "0x4006635")]
	[FieldOffset(Offset = "0x80")]
	private SEController Gorogoro;

	// Token: 0x04006D1E RID: 27934
	[Token(Token = "0x4006636")]
	[FieldOffset(Offset = "0x88")]
	private CurveSample Sample;

	// Token: 0x04006D1F RID: 27935
	[Token(Token = "0x4006637")]
	[FieldOffset(Offset = "0xD0")]
	private Renderer[] _renderer;

	// Token: 0x04006D20 RID: 27936
	[Token(Token = "0x4006638")]
	[FieldOffset(Offset = "0xD8")]
	private Material[] _materials;

	// Token: 0x04006D21 RID: 27937
	[Token(Token = "0x4006639")]
	[FieldOffset(Offset = "0xE0")]
	private Coroutine fadeCoroutine;

	// Token: 0x020005FA RID: 1530
	[Token(Token = "0x2001135")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1580B0", Offset = "0x1581B1")]
	private sealed class <Fade>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060025DB RID: 9691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D5")]
		[Address(RVA = "0x29A0D70", Offset = "0x29A0E71", VA = "0x29A0D70")]
		[DebuggerHidden]
		public <Fade>d__32(int <>1__state)
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D6")]
		[Address(RVA = "0x29A0DA0", Offset = "0x29A0EA1", VA = "0x29A0DA0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x0000F060 File Offset: 0x0000D260
		[Token(Token = "0x60070D7")]
		[Address(RVA = "0x29A0DB0", Offset = "0x29A0EB1", VA = "0x29A0DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFB")]
		private object Current
		{
			[Token(Token = "0x60070D8")]
			[Address(RVA = "0x29A0EE0", Offset = "0x29A0FE1", VA = "0x29A0EE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D9")]
		[Address(RVA = "0x29A0EF0", Offset = "0x29A0FF1", VA = "0x29A0EF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFC")]
		private object Current
		{
			[Token(Token = "0x60070DA")]
			[Address(RVA = "0x29A0F50", Offset = "0x29A1051", VA = "0x29A0F50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006D22 RID: 27938
		[Token(Token = "0x401935B")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006D23 RID: 27939
		[Token(Token = "0x401935C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006D24 RID: 27940
		[Token(Token = "0x401935D")]
		[FieldOffset(Offset = "0x20")]
		public float fade_time;

		// Token: 0x04006D25 RID: 27941
		[Token(Token = "0x401935E")]
		[FieldOffset(Offset = "0x28")]
		public RollingRock <>4__this;

		// Token: 0x04006D26 RID: 27942
		[Token(Token = "0x401935F")]
		[FieldOffset(Offset = "0x30")]
		public float end;

		// Token: 0x04006D27 RID: 27943
		[Token(Token = "0x4019360")]
		[FieldOffset(Offset = "0x34")]
		public float start;

		// Token: 0x04006D28 RID: 27944
		[Token(Token = "0x4019361")]
		[FieldOffset(Offset = "0x38")]
		private float <time>5__2;
	}

	// Token: 0x020005FB RID: 1531
	[Token(Token = "0x2001136")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1580C0", Offset = "0x1581C1")]
	private sealed class <FadeWait>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060025E1 RID: 9697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070DB")]
		[Address(RVA = "0x29A0F60", Offset = "0x29A1061", VA = "0x29A0F60")]
		[DebuggerHidden]
		public <FadeWait>d__36(int <>1__state)
		{
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070DC")]
		[Address(RVA = "0x29A0F90", Offset = "0x29A1091", VA = "0x29A0F90", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x0000F078 File Offset: 0x0000D278
		[Token(Token = "0x60070DD")]
		[Address(RVA = "0x29A0FA0", Offset = "0x29A10A1", VA = "0x29A0FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFD")]
		private object Current
		{
			[Token(Token = "0x60070DE")]
			[Address(RVA = "0x29A1070", Offset = "0x29A1171", VA = "0x29A1070", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070DF")]
		[Address(RVA = "0x29A1080", Offset = "0x29A1181", VA = "0x29A1080", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFE")]
		private object Current
		{
			[Token(Token = "0x60070E0")]
			[Address(RVA = "0x29A10E0", Offset = "0x29A11E1", VA = "0x29A10E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006D29 RID: 27945
		[Token(Token = "0x4019362")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006D2A RID: 27946
		[Token(Token = "0x4019363")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006D2B RID: 27947
		[Token(Token = "0x4019364")]
		[FieldOffset(Offset = "0x20")]
		public float fade_time;

		// Token: 0x04006D2C RID: 27948
		[Token(Token = "0x4019365")]
		[FieldOffset(Offset = "0x28")]
		public RollingRock <>4__this;

		// Token: 0x04006D2D RID: 27949
		[Token(Token = "0x4019366")]
		[FieldOffset(Offset = "0x30")]
		private float <time>5__2;
	}
}
