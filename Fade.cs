using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000650 RID: 1616
[Token(Token = "0x2000488")]
public class Fade : MonoBehaviour
{
	// Token: 0x06002834 RID: 10292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002206")]
	[Address(RVA = "0x21C60E0", Offset = "0x21C61E1", VA = "0x21C60E0")]
	private void Awake()
	{
	}

	// Token: 0x06002835 RID: 10293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002207")]
	[Address(RVA = "0x21C6210", Offset = "0x21C6311", VA = "0x21C6210")]
	private void Update()
	{
	}

	// Token: 0x06002836 RID: 10294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002208")]
	[Address(RVA = "0x21C63F0", Offset = "0x21C64F1", VA = "0x21C63F0")]
	private void OnValidate()
	{
	}

	// Token: 0x06002837 RID: 10295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002209")]
	[Address(RVA = "0x21C6240", Offset = "0x21C6341", VA = "0x21C6240")]
	private void LoadLoadingAnim()
	{
	}

	// Token: 0x06002838 RID: 10296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220A")]
	[Address(RVA = "0x21C64C0", Offset = "0x21C65C1", VA = "0x21C64C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1EC0", Offset = "0x1A1FC1")]
	private IEnumerator FadeoutCoroutine(float time, Action action, bool onLoad)
	{
		return null;
	}

	// Token: 0x06002839 RID: 10297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220B")]
	[Address(RVA = "0x21C65B0", Offset = "0x21C66B1", VA = "0x21C65B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1F30", Offset = "0x1A2031")]
	private IEnumerator FadeinCoroutine(float time, Action action)
	{
		return null;
	}

	// Token: 0x0600283A RID: 10298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220C")]
	[Address(RVA = "0x21C6690", Offset = "0x21C6791", VA = "0x21C6690")]
	public Coroutine FadeOut(float time, Action action, Color color, bool onload)
	{
		return null;
	}

	// Token: 0x0600283B RID: 10299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220D")]
	[Address(RVA = "0x21C6AF0", Offset = "0x21C6BF1", VA = "0x21C6AF0")]
	public Coroutine FadeOut(float time)
	{
		return null;
	}

	// Token: 0x0600283C RID: 10300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220E")]
	[Address(RVA = "0x21C6B50", Offset = "0x21C6C51", VA = "0x21C6B50")]
	public Coroutine FadeIn(float time, Action action, Color color, bool onload)
	{
		return null;
	}

	// Token: 0x0600283D RID: 10301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220F")]
	[Address(RVA = "0x21C6FA0", Offset = "0x21C70A1", VA = "0x21C6FA0")]
	public Coroutine FadeIn(float time)
	{
		return null;
	}

	// Token: 0x0600283E RID: 10302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002210")]
	[Address(RVA = "0x21C7000", Offset = "0x21C7101", VA = "0x21C7000")]
	public void SetStep(Fade.FADE_STEP set_step)
	{
	}

	// Token: 0x0600283F RID: 10303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002211")]
	[Address(RVA = "0x21C7010", Offset = "0x21C7111", VA = "0x21C7010")]
	public Fade()
	{
	}

	// Token: 0x06002840 RID: 10304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002212")]
	[Address(RVA = "0x21C7020", Offset = "0x21C7121", VA = "0x21C7020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1FA0", Offset = "0x1A20A1")]
	private void <LoadLoadingAnim>b__12_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04006F9E RID: 28574
	[Token(Token = "0x400682C")]
	[FieldOffset(Offset = "0x18")]
	private IFade fade;

	// Token: 0x04006F9F RID: 28575
	[Token(Token = "0x400682D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x1685B0", Offset = "0x1686B1")]
	private float cutoutRange;

	// Token: 0x04006FA0 RID: 28576
	[Token(Token = "0x400682E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject parentObject;

	// Token: 0x04006FA1 RID: 28577
	[Token(Token = "0x400682F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject objAnimChara;

	// Token: 0x04006FA2 RID: 28578
	[Token(Token = "0x4006830")]
	[FieldOffset(Offset = "0x38")]
	private GameObject objAnimText;

	// Token: 0x04006FA3 RID: 28579
	[Token(Token = "0x4006831")]
	[FieldOffset(Offset = "0x40")]
	private Image imgAnimChara;

	// Token: 0x04006FA4 RID: 28580
	[Token(Token = "0x4006832")]
	[FieldOffset(Offset = "0x48")]
	private Image imgAnimText;

	// Token: 0x04006FA5 RID: 28581
	[Token(Token = "0x4006833")]
	[FieldOffset(Offset = "0x50")]
	private Fade.FADE_STEP step;

	// Token: 0x02000651 RID: 1617
	[Token(Token = "0x2001151")]
	public enum FADE_STEP
	{
		// Token: 0x04006FA7 RID: 28583
		[Token(Token = "0x40193E6")]
		NONE = -1,
		// Token: 0x04006FA8 RID: 28584
		[Token(Token = "0x40193E7")]
		INIT,
		// Token: 0x04006FA9 RID: 28585
		[Token(Token = "0x40193E8")]
		LOAD_PREFAB,
		// Token: 0x04006FAA RID: 28586
		[Token(Token = "0x40193E9")]
		LOADING_PREFAB,
		// Token: 0x04006FAB RID: 28587
		[Token(Token = "0x40193EA")]
		LOADEND_PREFAB,
		// Token: 0x04006FAC RID: 28588
		[Token(Token = "0x40193EB")]
		STAY
	}

	// Token: 0x02000652 RID: 1618
	[Token(Token = "0x2001152")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1581A0", Offset = "0x1582A1")]
	private sealed class <FadeoutCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002841 RID: 10305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007119")]
		[Address(RVA = "0x21C6580", Offset = "0x21C6681", VA = "0x21C6580")]
		[DebuggerHidden]
		public <FadeoutCoroutine>d__13(int <>1__state)
		{
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600711A")]
		[Address(RVA = "0x21C7440", Offset = "0x21C7541", VA = "0x21C7440", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		[Token(Token = "0x600711B")]
		[Address(RVA = "0x21C7450", Offset = "0x21C7551", VA = "0x21C7450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D03")]
		private object Current
		{
			[Token(Token = "0x600711C")]
			[Address(RVA = "0x21C7730", Offset = "0x21C7831", VA = "0x21C7730", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600711D")]
		[Address(RVA = "0x21C7740", Offset = "0x21C7841", VA = "0x21C7740", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002846 RID: 10310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D04")]
		private object Current
		{
			[Token(Token = "0x600711E")]
			[Address(RVA = "0x21C77A0", Offset = "0x21C78A1", VA = "0x21C77A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006FAD RID: 28589
		[Token(Token = "0x40193EC")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006FAE RID: 28590
		[Token(Token = "0x40193ED")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006FAF RID: 28591
		[Token(Token = "0x40193EE")]
		[FieldOffset(Offset = "0x20")]
		public Fade <>4__this;

		// Token: 0x04006FB0 RID: 28592
		[Token(Token = "0x40193EF")]
		[FieldOffset(Offset = "0x28")]
		public float time;

		// Token: 0x04006FB1 RID: 28593
		[Token(Token = "0x40193F0")]
		[FieldOffset(Offset = "0x2C")]
		public bool onLoad;

		// Token: 0x04006FB2 RID: 28594
		[Token(Token = "0x40193F1")]
		[FieldOffset(Offset = "0x30")]
		public Action action;

		// Token: 0x04006FB3 RID: 28595
		[Token(Token = "0x40193F2")]
		[FieldOffset(Offset = "0x38")]
		private float <startTime>5__2;

		// Token: 0x04006FB4 RID: 28596
		[Token(Token = "0x40193F3")]
		[FieldOffset(Offset = "0x40")]
		private WaitForEndOfFrame <endFrame>5__3;
	}

	// Token: 0x02000653 RID: 1619
	[Token(Token = "0x2001153")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1581B0", Offset = "0x1582B1")]
	private sealed class <FadeinCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002847 RID: 10311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600711F")]
		[Address(RVA = "0x21C6660", Offset = "0x21C6761", VA = "0x21C6660")]
		[DebuggerHidden]
		public <FadeinCoroutine>d__14(int <>1__state)
		{
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007120")]
		[Address(RVA = "0x21C7190", Offset = "0x21C7291", VA = "0x21C7190", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x0000FF00 File Offset: 0x0000E100
		[Token(Token = "0x6007121")]
		[Address(RVA = "0x21C71A0", Offset = "0x21C72A1", VA = "0x21C71A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D05")]
		private object Current
		{
			[Token(Token = "0x6007122")]
			[Address(RVA = "0x21C73C0", Offset = "0x21C74C1", VA = "0x21C73C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007123")]
		[Address(RVA = "0x21C73D0", Offset = "0x21C74D1", VA = "0x21C73D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D06")]
		private object Current
		{
			[Token(Token = "0x6007124")]
			[Address(RVA = "0x21C7430", Offset = "0x21C7531", VA = "0x21C7430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006FB5 RID: 28597
		[Token(Token = "0x40193F4")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006FB6 RID: 28598
		[Token(Token = "0x40193F5")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006FB7 RID: 28599
		[Token(Token = "0x40193F6")]
		[FieldOffset(Offset = "0x20")]
		public Fade <>4__this;

		// Token: 0x04006FB8 RID: 28600
		[Token(Token = "0x40193F7")]
		[FieldOffset(Offset = "0x28")]
		public float time;

		// Token: 0x04006FB9 RID: 28601
		[Token(Token = "0x40193F8")]
		[FieldOffset(Offset = "0x30")]
		public Action action;

		// Token: 0x04006FBA RID: 28602
		[Token(Token = "0x40193F9")]
		[FieldOffset(Offset = "0x38")]
		private float <startTime>5__2;

		// Token: 0x04006FBB RID: 28603
		[Token(Token = "0x40193FA")]
		[FieldOffset(Offset = "0x40")]
		private WaitForEndOfFrame <endFrame>5__3;
	}
}
