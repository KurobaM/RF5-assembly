using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SplineMesh;
using UnityEngine;

// Token: 0x020005F4 RID: 1524
[Token(Token = "0x2000449")]
public class MoveCloud : MonoBehaviour
{
	// Token: 0x060025A7 RID: 9639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x1E10130", Offset = "0x1E10231", VA = "0x1E10130")]
	private void Awake()
	{
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FC4")]
	[Address(RVA = "0x1E102B0", Offset = "0x1E103B1", VA = "0x1E102B0")]
	private void Start()
	{
	}

	// Token: 0x060025A9 RID: 9641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FC5")]
	[Address(RVA = "0x1E103A0", Offset = "0x1E104A1", VA = "0x1E103A0")]
	private void Update()
	{
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FC6")]
	[Address(RVA = "0x1E103D0", Offset = "0x1E104D1", VA = "0x1E103D0")]
	private void Update0()
	{
	}

	// Token: 0x060025AB RID: 9643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0x1E10700", Offset = "0x1E10801", VA = "0x1E10700")]
	private void Update1()
	{
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0x1E10840", Offset = "0x1E10941", VA = "0x1E10840")]
	public void Break()
	{
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FC9")]
	[Address(RVA = "0x1E10210", Offset = "0x1E10311", VA = "0x1E10210")]
	private void FadeInit()
	{
	}

	// Token: 0x060025AE RID: 9646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FCA")]
	[Address(RVA = "0x1E102C0", Offset = "0x1E103C1", VA = "0x1E102C0")]
	private void FadeIn(float time = 1f)
	{
	}

	// Token: 0x060025AF RID: 9647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FCB")]
	[Address(RVA = "0x1E10A40", Offset = "0x1E10B41", VA = "0x1E10A40")]
	private void FadeOut(float time = 1f)
	{
	}

	// Token: 0x060025B0 RID: 9648 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FCC")]
	[Address(RVA = "0x1E10BE0", Offset = "0x1E10CE1", VA = "0x1E10BE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1850", Offset = "0x1A1951")]
	private IEnumerator Fade(float start, float end, float fade_time)
	{
		return null;
	}

	// Token: 0x060025B1 RID: 9649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FCD")]
	[Address(RVA = "0x1E10B20", Offset = "0x1E10C21", VA = "0x1E10B20")]
	private void SetAlpha(float alpha)
	{
	}

	// Token: 0x060025B2 RID: 9650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0x1E10CB0", Offset = "0x1E10DB1", VA = "0x1E10CB0")]
	public MoveCloud()
	{
	}

	// Token: 0x04006CE1 RID: 27873
	[Token(Token = "0x4006600")]
	[FieldOffset(Offset = "0x18")]
	public Spline Spline;

	// Token: 0x04006CE2 RID: 27874
	[Token(Token = "0x4006601")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	// Token: 0x04006CE3 RID: 27875
	[Token(Token = "0x4006602")]
	[FieldOffset(Offset = "0x24")]
	public float FadeInTime;

	// Token: 0x04006CE4 RID: 27876
	[Token(Token = "0x4006603")]
	[FieldOffset(Offset = "0x28")]
	public float FadeOutTime;

	// Token: 0x04006CE5 RID: 27877
	[Token(Token = "0x4006604")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167BF0", Offset = "0x167CF1")]
	public float LerpValue;

	// Token: 0x04006CE6 RID: 27878
	[Token(Token = "0x4006605")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Vector3 Rotation;

	// Token: 0x04006CE7 RID: 27879
	[Token(Token = "0x4006606")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float DelayTime;

	// Token: 0x04006CE8 RID: 27880
	[Token(Token = "0x4006607")]
	[FieldOffset(Offset = "0x40")]
	private bool IsBreak;

	// Token: 0x04006CE9 RID: 27881
	[Token(Token = "0x4006608")]
	[FieldOffset(Offset = "0x44")]
	private float MovedDistance;

	// Token: 0x04006CEA RID: 27882
	[Token(Token = "0x4006609")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 PrebPoint;

	// Token: 0x04006CEB RID: 27883
	[Token(Token = "0x400660A")]
	[FieldOffset(Offset = "0x54")]
	private CurveSample Sample;

	// Token: 0x04006CEC RID: 27884
	[Token(Token = "0x400660B")]
	[FieldOffset(Offset = "0x9C")]
	private Quaternion target_rot;

	// Token: 0x04006CED RID: 27885
	[Token(Token = "0x400660C")]
	[FieldOffset(Offset = "0xB0")]
	private Renderer _renderer;

	// Token: 0x04006CEE RID: 27886
	[Token(Token = "0x400660D")]
	[FieldOffset(Offset = "0xB8")]
	private MaterialPropertyBlock materialPropertyBlock;

	// Token: 0x04006CEF RID: 27887
	[Token(Token = "0x400660E")]
	[FieldOffset(Offset = "0xC0")]
	private Coroutine fadeCoroutine;

	// Token: 0x020005F5 RID: 1525
	[Token(Token = "0x2001134")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1580A0", Offset = "0x1581A1")]
	private sealed class <Fade>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060025B3 RID: 9651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CF")]
		[Address(RVA = "0x1E10C80", Offset = "0x1E10D81", VA = "0x1E10C80")]
		[DebuggerHidden]
		public <Fade>d__24(int <>1__state)
		{
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D0")]
		[Address(RVA = "0x1E10CD0", Offset = "0x1E10DD1", VA = "0x1E10CD0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x0000F030 File Offset: 0x0000D230
		[Token(Token = "0x60070D1")]
		[Address(RVA = "0x1E10CE0", Offset = "0x1E10DE1", VA = "0x1E10CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF9")]
		private object Current
		{
			[Token(Token = "0x60070D2")]
			[Address(RVA = "0x1E10E10", Offset = "0x1E10F11", VA = "0x1E10E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070D3")]
		[Address(RVA = "0x1E10E20", Offset = "0x1E10F21", VA = "0x1E10E20", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFA")]
		private object Current
		{
			[Token(Token = "0x60070D4")]
			[Address(RVA = "0x1E10E80", Offset = "0x1E10F81", VA = "0x1E10E80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006CF0 RID: 27888
		[Token(Token = "0x4019354")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006CF1 RID: 27889
		[Token(Token = "0x4019355")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006CF2 RID: 27890
		[Token(Token = "0x4019356")]
		[FieldOffset(Offset = "0x20")]
		public float fade_time;

		// Token: 0x04006CF3 RID: 27891
		[Token(Token = "0x4019357")]
		[FieldOffset(Offset = "0x28")]
		public MoveCloud <>4__this;

		// Token: 0x04006CF4 RID: 27892
		[Token(Token = "0x4019358")]
		[FieldOffset(Offset = "0x30")]
		public float end;

		// Token: 0x04006CF5 RID: 27893
		[Token(Token = "0x4019359")]
		[FieldOffset(Offset = "0x34")]
		public float start;

		// Token: 0x04006CF6 RID: 27894
		[Token(Token = "0x401935A")]
		[FieldOffset(Offset = "0x38")]
		private float <time>5__2;
	}
}
