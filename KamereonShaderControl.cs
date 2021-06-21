using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200071A RID: 1818
[Token(Token = "0x20004F8")]
public class KamereonShaderControl : MonoBehaviour
{
	// Token: 0x170006C5 RID: 1733
	// (get) Token: 0x06002E06 RID: 11782 RVA: 0x00010C80 File Offset: 0x0000EE80
	// (set) Token: 0x06002E07 RID: 11783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000567")]
	private bool isInit
	{
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x2244FA0", Offset = "0x22450A1", VA = "0x2244FA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A36E0", Offset = "0x1A37E1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x2244FB0", Offset = "0x22450B1", VA = "0x2244FB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A36F0", Offset = "0x1A37F1")]
		set
		{
		}
	}

	// Token: 0x06002E08 RID: 11784 RVA: 0x00010C98 File Offset: 0x0000EE98
	[Token(Token = "0x60026D4")]
	[Address(RVA = "0x2244FC0", Offset = "0x22450C1", VA = "0x2244FC0")]
	private KamereonShaderControl.ShaderProperty GetNowProperty()
	{
		return default(KamereonShaderControl.ShaderProperty);
	}

	// Token: 0x06002E09 RID: 11785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026D5")]
	[Address(RVA = "0x22450B0", Offset = "0x22451B1", VA = "0x22450B0")]
	public void Init()
	{
	}

	// Token: 0x06002E0A RID: 11786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026D6")]
	[Address(RVA = "0x22451E0", Offset = "0x22452E1", VA = "0x22451E0")]
	private void GetProperty()
	{
	}

	// Token: 0x06002E0B RID: 11787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026D7")]
	[Address(RVA = "0x22444A0", Offset = "0x22445A1", VA = "0x22444A0")]
	public void Play(KamereonShaderControl.PlayType type, float fadeTime = 1f, int param = -1)
	{
	}

	// Token: 0x06002E0C RID: 11788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026D8")]
	[Address(RVA = "0x22452B0", Offset = "0x22453B1", VA = "0x22452B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A3700", Offset = "0x1A3801")]
	private IEnumerator PlayDefaultAsync()
	{
		return null;
	}

	// Token: 0x06002E0D RID: 11789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026D9")]
	[Address(RVA = "0x2245330", Offset = "0x2245431", VA = "0x2245330")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A3770", Offset = "0x1A3871")]
	private IEnumerator PlayAlphaAsync(bool isRainbow)
	{
		return null;
	}

	// Token: 0x06002E0E RID: 11790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026DA")]
	[Address(RVA = "0x22454C0", Offset = "0x22455C1", VA = "0x22454C0")]
	private void SetDefault()
	{
	}

	// Token: 0x06002E0F RID: 11791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026DB")]
	[Address(RVA = "0x2245500", Offset = "0x2245601", VA = "0x2245500")]
	private void SetDefault(float timer, KamereonShaderControl.ShaderProperty now)
	{
	}

	// Token: 0x06002E10 RID: 11792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026DC")]
	[Address(RVA = "0x22456C0", Offset = "0x22457C1", VA = "0x22456C0")]
	private void SetAlpha(bool isRainbow)
	{
	}

	// Token: 0x06002E11 RID: 11793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026DD")]
	[Address(RVA = "0x2245700", Offset = "0x2245801", VA = "0x2245700")]
	private void SetAlpha(bool isRainbow, float timer, KamereonShaderControl.ShaderProperty now)
	{
	}

	// Token: 0x06002E12 RID: 11794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026DE")]
	[Address(RVA = "0x22453C0", Offset = "0x22454C1", VA = "0x22453C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A37E0", Offset = "0x1A38E1")]
	private IEnumerator PlayAlphaLoopAsync(bool isRainbow, int count = -1)
	{
		return null;
	}

	// Token: 0x06002E13 RID: 11795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026DF")]
	[Address(RVA = "0x2245940", Offset = "0x2245A41", VA = "0x2245940")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A3850", Offset = "0x1A3951")]
	private IEnumerator PlayRainbowAsync()
	{
		return null;
	}

	// Token: 0x06002E14 RID: 11796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026E0")]
	[Address(RVA = "0x22459F0", Offset = "0x2245AF1", VA = "0x22459F0")]
	private void PlayyRainbowLoop()
	{
	}

	// Token: 0x06002E15 RID: 11797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026E1")]
	[Address(RVA = "0x2245A40", Offset = "0x2245B41", VA = "0x2245A40")]
	public void EnableShadow(bool b)
	{
	}

	// Token: 0x06002E16 RID: 11798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026E2")]
	[Address(RVA = "0x2245A70", Offset = "0x2245B71", VA = "0x2245A70")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002E17 RID: 11799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60026E3")]
	[Address(RVA = "0x2245B40", Offset = "0x2245C41", VA = "0x2245B40")]
	public KamereonShaderControl()
	{
	}

	// Token: 0x04007434 RID: 29748
	[Token(Token = "0x4006B0B")]
	[FieldOffset(Offset = "0x18")]
	private int sp_Alpha;

	// Token: 0x04007435 RID: 29749
	[Token(Token = "0x4006B0C")]
	[FieldOffset(Offset = "0x1C")]
	private int sp_AlphaRimValue;

	// Token: 0x04007436 RID: 29750
	[Token(Token = "0x4006B0D")]
	[FieldOffset(Offset = "0x20")]
	private int sp_White;

	// Token: 0x04007437 RID: 29751
	[Token(Token = "0x4006B0E")]
	[FieldOffset(Offset = "0x24")]
	private int sp_Centor;

	// Token: 0x04007438 RID: 29752
	[Token(Token = "0x4006B0F")]
	[FieldOffset(Offset = "0x28")]
	private int sp_Fade;

	// Token: 0x04007439 RID: 29753
	[Token(Token = "0x4006B10")]
	[FieldOffset(Offset = "0x2C")]
	private int sp_RainbowBlend;

	// Token: 0x0400743A RID: 29754
	[Token(Token = "0x4006B11")]
	[FieldOffset(Offset = "0x30")]
	private float fadeTime;

	// Token: 0x0400743B RID: 29755
	[Token(Token = "0x4006B12")]
	[FieldOffset(Offset = "0x34")]
	private float alphaLoopTime;

	// Token: 0x0400743C RID: 29756
	[Token(Token = "0x4006B13")]
	[FieldOffset(Offset = "0x38")]
	private float loopLightSpeed;

	// Token: 0x0400743D RID: 29757
	[Token(Token = "0x4006B14")]
	[FieldOffset(Offset = "0x3C")]
	private int rainbowParam;

	// Token: 0x0400743E RID: 29758
	[Token(Token = "0x4006B15")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Renderer targetRenderer;

	// Token: 0x0400743F RID: 29759
	[Token(Token = "0x4006B16")]
	[FieldOffset(Offset = "0x48")]
	private Material iMaterial;

	// Token: 0x04007440 RID: 29760
	[Token(Token = "0x4006B17")]
	[FieldOffset(Offset = "0x50")]
	private IEnumerator coroutine;

	// Token: 0x04007441 RID: 29761
	[Token(Token = "0x4006B18")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169890", Offset = "0x169991")]
	private bool <isInit>k__BackingField;

	// Token: 0x04007442 RID: 29762
	[Token(Token = "0x4006B19")]
	[FieldOffset(Offset = "0x5C")]
	private readonly KamereonShaderControl.ShaderProperty defaultProperty;

	// Token: 0x04007443 RID: 29763
	[Token(Token = "0x4006B1A")]
	[FieldOffset(Offset = "0x78")]
	private readonly KamereonShaderControl.ShaderProperty alphaProperty;

	// Token: 0x0200071B RID: 1819
	[Token(Token = "0x20011A9")]
	public enum PlayType
	{
		// Token: 0x04007445 RID: 29765
		[Token(Token = "0x4019593")]
		Default,
		// Token: 0x04007446 RID: 29766
		[Token(Token = "0x4019594")]
		AlphaLoop,
		// Token: 0x04007447 RID: 29767
		[Token(Token = "0x4019595")]
		Alpha,
		// Token: 0x04007448 RID: 29768
		[Token(Token = "0x4019596")]
		Rainbow,
		// Token: 0x04007449 RID: 29769
		[Token(Token = "0x4019597")]
		RainbowLoop
	}

	// Token: 0x0200071C RID: 1820
	[Token(Token = "0x20011AA")]
	private struct ShaderProperty
	{
		// Token: 0x0400744A RID: 29770
		[Token(Token = "0x4019598")]
		[FieldOffset(Offset = "0x0")]
		public float alpha;

		// Token: 0x0400744B RID: 29771
		[Token(Token = "0x4019599")]
		[FieldOffset(Offset = "0x4")]
		public float alphaRimValue;

		// Token: 0x0400744C RID: 29772
		[Token(Token = "0x401959A")]
		[FieldOffset(Offset = "0x8")]
		public float white;

		// Token: 0x0400744D RID: 29773
		[Token(Token = "0x401959B")]
		[FieldOffset(Offset = "0xC")]
		public float centor;

		// Token: 0x0400744E RID: 29774
		[Token(Token = "0x401959C")]
		[FieldOffset(Offset = "0x10")]
		public float fade;

		// Token: 0x0400744F RID: 29775
		[Token(Token = "0x401959D")]
		[FieldOffset(Offset = "0x14")]
		public float rainbowBlend;

		// Token: 0x04007450 RID: 29776
		[Token(Token = "0x401959E")]
		[FieldOffset(Offset = "0x18")]
		public int renderQueue;
	}

	// Token: 0x0200071D RID: 1821
	[Token(Token = "0x20011AB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1584A0", Offset = "0x1585A1")]
	private sealed class <PlayDefaultAsync>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002E18 RID: 11800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600721F")]
		[Address(RVA = "0x2245460", Offset = "0x2245561", VA = "0x2245460")]
		[DebuggerHidden]
		public <PlayDefaultAsync>d__25(int <>1__state)
		{
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007220")]
		[Address(RVA = "0x2245FC0", Offset = "0x22460C1", VA = "0x2245FC0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		[Token(Token = "0x6007221")]
		[Address(RVA = "0x2245FD0", Offset = "0x22460D1", VA = "0x2245FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1B")]
		private object Current
		{
			[Token(Token = "0x6007222")]
			[Address(RVA = "0x2246110", Offset = "0x2246211", VA = "0x2246110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007223")]
		[Address(RVA = "0x2246120", Offset = "0x2246221", VA = "0x2246120", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1C")]
		private object Current
		{
			[Token(Token = "0x6007224")]
			[Address(RVA = "0x2246180", Offset = "0x2246281", VA = "0x2246180", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007451 RID: 29777
		[Token(Token = "0x401959F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007452 RID: 29778
		[Token(Token = "0x40195A0")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007453 RID: 29779
		[Token(Token = "0x40195A1")]
		[FieldOffset(Offset = "0x20")]
		public KamereonShaderControl <>4__this;

		// Token: 0x04007454 RID: 29780
		[Token(Token = "0x40195A2")]
		[FieldOffset(Offset = "0x28")]
		private KamereonShaderControl.ShaderProperty <now>5__2;

		// Token: 0x04007455 RID: 29781
		[Token(Token = "0x40195A3")]
		[FieldOffset(Offset = "0x44")]
		private float <timer>5__3;
	}

	// Token: 0x0200071E RID: 1822
	[Token(Token = "0x20011AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1584B0", Offset = "0x1585B1")]
	private sealed class <PlayAlphaAsync>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002E1E RID: 11806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007225")]
		[Address(RVA = "0x2245490", Offset = "0x2245591", VA = "0x2245490")]
		[DebuggerHidden]
		public <PlayAlphaAsync>d__26(int <>1__state)
		{
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007226")]
		[Address(RVA = "0x2245BA0", Offset = "0x2245CA1", VA = "0x2245BA0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		[Token(Token = "0x6007227")]
		[Address(RVA = "0x2245BB0", Offset = "0x2245CB1", VA = "0x2245BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1D")]
		private object Current
		{
			[Token(Token = "0x6007228")]
			[Address(RVA = "0x2245D10", Offset = "0x2245E11", VA = "0x2245D10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007229")]
		[Address(RVA = "0x2245D20", Offset = "0x2245E21", VA = "0x2245D20", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1E")]
		private object Current
		{
			[Token(Token = "0x600722A")]
			[Address(RVA = "0x2245D80", Offset = "0x2245E81", VA = "0x2245D80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007456 RID: 29782
		[Token(Token = "0x40195A4")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007457 RID: 29783
		[Token(Token = "0x40195A5")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007458 RID: 29784
		[Token(Token = "0x40195A6")]
		[FieldOffset(Offset = "0x20")]
		public KamereonShaderControl <>4__this;

		// Token: 0x04007459 RID: 29785
		[Token(Token = "0x40195A7")]
		[FieldOffset(Offset = "0x28")]
		public bool isRainbow;

		// Token: 0x0400745A RID: 29786
		[Token(Token = "0x40195A8")]
		[FieldOffset(Offset = "0x2C")]
		private KamereonShaderControl.ShaderProperty <now>5__2;

		// Token: 0x0400745B RID: 29787
		[Token(Token = "0x40195A9")]
		[FieldOffset(Offset = "0x48")]
		private float <timer>5__3;
	}

	// Token: 0x0200071F RID: 1823
	[Token(Token = "0x20011AD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1584C0", Offset = "0x1585C1")]
	private sealed class <PlayAlphaLoopAsync>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002E24 RID: 11812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722B")]
		[Address(RVA = "0x2245910", Offset = "0x2245A11", VA = "0x2245910")]
		[DebuggerHidden]
		public <PlayAlphaLoopAsync>d__31(int <>1__state)
		{
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722C")]
		[Address(RVA = "0x2245D90", Offset = "0x2245E91", VA = "0x2245D90", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		[Token(Token = "0x600722D")]
		[Address(RVA = "0x2245DA0", Offset = "0x2245EA1", VA = "0x2245DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1F")]
		private object Current
		{
			[Token(Token = "0x600722E")]
			[Address(RVA = "0x2245F40", Offset = "0x2246041", VA = "0x2245F40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722F")]
		[Address(RVA = "0x2245F50", Offset = "0x2246051", VA = "0x2245F50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D20")]
		private object Current
		{
			[Token(Token = "0x6007230")]
			[Address(RVA = "0x2245FB0", Offset = "0x22460B1", VA = "0x2245FB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400745C RID: 29788
		[Token(Token = "0x40195AA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400745D RID: 29789
		[Token(Token = "0x40195AB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400745E RID: 29790
		[Token(Token = "0x40195AC")]
		[FieldOffset(Offset = "0x20")]
		public KamereonShaderControl <>4__this;

		// Token: 0x0400745F RID: 29791
		[Token(Token = "0x40195AD")]
		[FieldOffset(Offset = "0x28")]
		public bool isRainbow;

		// Token: 0x04007460 RID: 29792
		[Token(Token = "0x40195AE")]
		[FieldOffset(Offset = "0x2C")]
		public int count;

		// Token: 0x04007461 RID: 29793
		[Token(Token = "0x40195AF")]
		[FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		// Token: 0x04007462 RID: 29794
		[Token(Token = "0x40195B0")]
		[FieldOffset(Offset = "0x34")]
		private float <timer>5__3;

		// Token: 0x04007463 RID: 29795
		[Token(Token = "0x40195B1")]
		[FieldOffset(Offset = "0x38")]
		private float <setValue>5__4;

		// Token: 0x04007464 RID: 29796
		[Token(Token = "0x40195B2")]
		[FieldOffset(Offset = "0x3C")]
		private int <counter>5__5;
	}

	// Token: 0x02000720 RID: 1824
	[Token(Token = "0x20011AE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1584D0", Offset = "0x1585D1")]
	private sealed class <PlayRainbowAsync>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002E2A RID: 11818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007231")]
		[Address(RVA = "0x22459C0", Offset = "0x2245AC1", VA = "0x22459C0")]
		[DebuggerHidden]
		public <PlayRainbowAsync>d__32(int <>1__state)
		{
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007232")]
		[Address(RVA = "0x2246190", Offset = "0x2246291", VA = "0x2246190", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		[Token(Token = "0x6007233")]
		[Address(RVA = "0x22461A0", Offset = "0x22462A1", VA = "0x22461A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D21")]
		private object Current
		{
			[Token(Token = "0x6007234")]
			[Address(RVA = "0x2246330", Offset = "0x2246431", VA = "0x2246330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007235")]
		[Address(RVA = "0x2246340", Offset = "0x2246441", VA = "0x2246340", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D22")]
		private object Current
		{
			[Token(Token = "0x6007236")]
			[Address(RVA = "0x22463A0", Offset = "0x22464A1", VA = "0x22463A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007465 RID: 29797
		[Token(Token = "0x40195B3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007466 RID: 29798
		[Token(Token = "0x40195B4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007467 RID: 29799
		[Token(Token = "0x40195B5")]
		[FieldOffset(Offset = "0x20")]
		public KamereonShaderControl <>4__this;

		// Token: 0x04007468 RID: 29800
		[Token(Token = "0x40195B6")]
		[FieldOffset(Offset = "0x28")]
		private KamereonShaderControl.ShaderProperty <now>5__2;

		// Token: 0x04007469 RID: 29801
		[Token(Token = "0x40195B7")]
		[FieldOffset(Offset = "0x44")]
		private float <timer>5__3;
	}
}
