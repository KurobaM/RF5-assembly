using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

// Token: 0x02000AC6 RID: 2758
[Token(Token = "0x200073D")]
public class UICraftResult : MonoBehaviour
{
	// Token: 0x060047A8 RID: 18344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C14")]
	[Address(RVA = "0x2006C90", Offset = "0x2006D91", VA = "0x2006C90")]
	private void Start()
	{
	}

	// Token: 0x060047A9 RID: 18345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C15")]
	[Address(RVA = "0x2006F20", Offset = "0x2007021", VA = "0x2006F20")]
	private void Update()
	{
	}

	// Token: 0x060047AA RID: 18346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C16")]
	[Address(RVA = "0x2007050", Offset = "0x2007151", VA = "0x2007050")]
	private void OnDestroy()
	{
	}

	// Token: 0x060047AB RID: 18347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C17")]
	[Address(RVA = "0x20062A0", Offset = "0x20063A1", VA = "0x20062A0")]
	public void PlayResult(bool _success, [Optional] UnityAction _call_back)
	{
	}

	// Token: 0x060047AC RID: 18348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003C18")]
	[Address(RVA = "0x20070D0", Offset = "0x20071D1", VA = "0x20070D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8050", Offset = "0x1A8151")]
	private IEnumerator PlayResultCoro(bool _success, [Optional] UnityAction _call_back)
	{
		return null;
	}

	// Token: 0x060047AD RID: 18349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C19")]
	[Address(RVA = "0x2006260", Offset = "0x2006361", VA = "0x2006260")]
	public void CheckCraftResultType(CraftCategoryId _craft_id)
	{
	}

	// Token: 0x060047AE RID: 18350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C1A")]
	[Address(RVA = "0x20071B0", Offset = "0x20072B1", VA = "0x20071B0")]
	public void CheckCraftResultType(bool _weapon)
	{
	}

	// Token: 0x060047AF RID: 18351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C1B")]
	[Address(RVA = "0x20071D0", Offset = "0x20072D1", VA = "0x20071D0")]
	public void SetResultItem(ItemData _item)
	{
	}

	// Token: 0x060047B0 RID: 18352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C1C")]
	[Address(RVA = "0x2006280", Offset = "0x2006381", VA = "0x2006280")]
	public void SetResultItem(ItemData _item, int _craft_num)
	{
	}

	// Token: 0x060047B1 RID: 18353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003C1D")]
	[Address(RVA = "0x20074E0", Offset = "0x20075E1", VA = "0x20074E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A80C0", Offset = "0x1A81C1")]
	private IEnumerator PlaySemiTransAnim(bool _flag)
	{
		return null;
	}

	// Token: 0x060047B2 RID: 18354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C1E")]
	[Address(RVA = "0x20075A0", Offset = "0x20076A1", VA = "0x20075A0")]
	public UICraftResult()
	{
	}

	// Token: 0x060047B3 RID: 18355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C1F")]
	[Address(RVA = "0x2007620", Offset = "0x2007721", VA = "0x2007620")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8130", Offset = "0x1A8231")]
	private void <Start>b__10_0(AssetHandle<GameObject> _handle)
	{
	}

	// Token: 0x060047B4 RID: 18356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C20")]
	[Address(RVA = "0x2007710", Offset = "0x2007811", VA = "0x2007710")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8140", Offset = "0x1A8241")]
	private void <Start>b__10_1(AssetHandle<GameObject> _handle)
	{
	}

	// Token: 0x060047B5 RID: 18357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C21")]
	[Address(RVA = "0x2007800", Offset = "0x2007901", VA = "0x2007800")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8150", Offset = "0x1A8251")]
	private void <Start>b__10_3()
	{
	}

	// Token: 0x0400A70A RID: 42762
	[Token(Token = "0x4007E56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private NonFocusButton skipButton;

	// Token: 0x0400A70B RID: 42763
	[Token(Token = "0x4007E57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image semiTrans;

	// Token: 0x0400A70C RID: 42764
	[Token(Token = "0x4007E58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PlayableDirector[] resultTimeline;

	// Token: 0x0400A70D RID: 42765
	[Token(Token = "0x4007E59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private UICraftSuccess successTimeline;

	// Token: 0x0400A70E RID: 42766
	[Token(Token = "0x4007E5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly int SUCCESS_ID;

	// Token: 0x0400A70F RID: 42767
	[Token(Token = "0x4007E5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PlayableDirector failedTimeline;

	// Token: 0x0400A710 RID: 42768
	[Token(Token = "0x4007E5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly int FAILED_ID;

	// Token: 0x0400A711 RID: 42769
	[Token(Token = "0x4007E5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private UICraftResult.CraftResultType resultType;

	// Token: 0x0400A712 RID: 42770
	[Token(Token = "0x4007E5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isPlaying;

	// Token: 0x02000AC7 RID: 2759
	[Token(Token = "0x200130B")]
	public enum CraftResultType
	{
		// Token: 0x0400A714 RID: 42772
		[Token(Token = "0x401B518")]
		Bake,
		// Token: 0x0400A715 RID: 42773
		[Token(Token = "0x401B519")]
		BlackSmith,
		// Token: 0x0400A716 RID: 42774
		[Token(Token = "0x401B51A")]
		Deco,
		// Token: 0x0400A717 RID: 42775
		[Token(Token = "0x401B51B")]
		Hand,
		// Token: 0x0400A718 RID: 42776
		[Token(Token = "0x401B51C")]
		Knife,
		// Token: 0x0400A719 RID: 42777
		[Token(Token = "0x401B51D")]
		Mixer,
		// Token: 0x0400A71A RID: 42778
		[Token(Token = "0x401B51E")]
		Oven,
		// Token: 0x0400A71B RID: 42779
		[Token(Token = "0x401B51F")]
		Pan,
		// Token: 0x0400A71C RID: 42780
		[Token(Token = "0x401B520")]
		Phamacy,
		// Token: 0x0400A71D RID: 42781
		[Token(Token = "0x401B521")]
		Steam,
		// Token: 0x0400A71E RID: 42782
		[Token(Token = "0x401B522")]
		Max
	}

	// Token: 0x02000AC8 RID: 2760
	[Token(Token = "0x200130C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159240", Offset = "0x159341")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060047B7 RID: 18359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007679")]
		[Address(RVA = "0x2007880", Offset = "0x2007981", VA = "0x2007880")]
		public <>c()
		{
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767A")]
		[Address(RVA = "0x2007890", Offset = "0x2007991", VA = "0x2007890")]
		internal void <Start>b__10_2()
		{
		}

		// Token: 0x0400A71F RID: 42783
		[Token(Token = "0x401B523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UICraftResult.<>c <>9;

		// Token: 0x0400A720 RID: 42784
		[Token(Token = "0x401B524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static UnityAction <>9__10_2;
	}

	// Token: 0x02000AC9 RID: 2761
	[Token(Token = "0x200130D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159250", Offset = "0x159351")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x060047B9 RID: 18361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600767B")]
		[Address(RVA = "0x20078F0", Offset = "0x20079F1", VA = "0x20078F0")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x00017610 File Offset: 0x00015810
		[Token(Token = "0x600767C")]
		[Address(RVA = "0x2007900", Offset = "0x2007A01", VA = "0x2007900")]
		internal bool <PlayResultCoro>b__0()
		{
			return default(bool);
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x00017628 File Offset: 0x00015828
		[Token(Token = "0x600767D")]
		[Address(RVA = "0x2007910", Offset = "0x2007A11", VA = "0x2007910")]
		internal bool <PlayResultCoro>b__1()
		{
			return default(bool);
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x00017640 File Offset: 0x00015840
		[Token(Token = "0x600767E")]
		[Address(RVA = "0x2007930", Offset = "0x2007A31", VA = "0x2007930")]
		internal bool <PlayResultCoro>b__2()
		{
			return default(bool);
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x00017658 File Offset: 0x00015858
		[Token(Token = "0x600767F")]
		[Address(RVA = "0x20079F0", Offset = "0x2007AF1", VA = "0x20079F0")]
		internal bool <PlayResultCoro>b__3()
		{
			return default(bool);
		}

		// Token: 0x0400A721 RID: 42785
		[Token(Token = "0x401B525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isLoading;

		// Token: 0x0400A722 RID: 42786
		[Token(Token = "0x401B526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UICraftResult <>4__this;
	}

	// Token: 0x02000ACA RID: 2762
	[Token(Token = "0x200130E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159260", Offset = "0x159361")]
	private sealed class <PlayResultCoro>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060047BE RID: 18366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007680")]
		[Address(RVA = "0x2007180", Offset = "0x2007281", VA = "0x2007180")]
		[DebuggerHidden]
		public <PlayResultCoro>d__14(int <>1__state)
		{
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007681")]
		[Address(RVA = "0x2007A60", Offset = "0x2007B61", VA = "0x2007A60", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x00017670 File Offset: 0x00015870
		[Token(Token = "0x6007682")]
		[Address(RVA = "0x2007A70", Offset = "0x2007B71", VA = "0x2007A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D9B")]
		private object Current
		{
			[Token(Token = "0x6007683")]
			[Address(RVA = "0x20080E0", Offset = "0x20081E1", VA = "0x20080E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007684")]
		[Address(RVA = "0x20080F0", Offset = "0x20081F1", VA = "0x20080F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D9C")]
		private object Current
		{
			[Token(Token = "0x6007685")]
			[Address(RVA = "0x2008150", Offset = "0x2008251", VA = "0x2008150", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A723 RID: 42787
		[Token(Token = "0x401B527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A724 RID: 42788
		[Token(Token = "0x401B528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A725 RID: 42789
		[Token(Token = "0x401B529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UICraftResult <>4__this;

		// Token: 0x0400A726 RID: 42790
		[Token(Token = "0x401B52A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UICraftResult.<>c__DisplayClass14_0 <>8__1;

		// Token: 0x0400A727 RID: 42791
		[Token(Token = "0x401B52B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool _success;

		// Token: 0x0400A728 RID: 42792
		[Token(Token = "0x401B52C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityAction _call_back;
	}

	// Token: 0x02000ACB RID: 2763
	[Token(Token = "0x200130F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159270", Offset = "0x159371")]
	private sealed class <PlaySemiTransAnim>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060047C4 RID: 18372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007686")]
		[Address(RVA = "0x2007570", Offset = "0x2007671", VA = "0x2007570")]
		[DebuggerHidden]
		public <PlaySemiTransAnim>d__19(int <>1__state)
		{
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007687")]
		[Address(RVA = "0x2008160", Offset = "0x2008261", VA = "0x2008160", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x00017688 File Offset: 0x00015888
		[Token(Token = "0x6007688")]
		[Address(RVA = "0x2008170", Offset = "0x2008271", VA = "0x2008170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D9D")]
		private object Current
		{
			[Token(Token = "0x6007689")]
			[Address(RVA = "0x2008370", Offset = "0x2008471", VA = "0x2008370", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768A")]
		[Address(RVA = "0x2008380", Offset = "0x2008481", VA = "0x2008380", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060047C9 RID: 18377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D9E")]
		private object Current
		{
			[Token(Token = "0x600768B")]
			[Address(RVA = "0x20083E0", Offset = "0x20084E1", VA = "0x20083E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A729 RID: 42793
		[Token(Token = "0x401B52D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A72A RID: 42794
		[Token(Token = "0x401B52E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A72B RID: 42795
		[Token(Token = "0x401B52F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _flag;

		// Token: 0x0400A72C RID: 42796
		[Token(Token = "0x401B530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UICraftResult <>4__this;

		// Token: 0x0400A72D RID: 42797
		[Token(Token = "0x401B531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <timeCount>5__2;

		// Token: 0x0400A72E RID: 42798
		[Token(Token = "0x401B532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <speed>5__3;

		// Token: 0x0400A72F RID: 42799
		[Token(Token = "0x401B533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <rate>5__4;
	}
}
