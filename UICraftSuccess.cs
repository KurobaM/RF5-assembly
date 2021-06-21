using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

// Token: 0x02000ACC RID: 2764
[Token(Token = "0x200073E")]
public class UICraftSuccess : MonoBehaviour
{
	// Token: 0x060047CA RID: 18378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C22")]
	[Address(RVA = "0x2008C50", Offset = "0x2008D51", VA = "0x2008C50")]
	private void Awake()
	{
	}

	// Token: 0x060047CB RID: 18379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C23")]
	[Address(RVA = "0x2008010", Offset = "0x2008111", VA = "0x2008010")]
	public void Play(bool _dual_work = false, [Optional] UnityAction _callback)
	{
	}

	// Token: 0x060047CC RID: 18380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003C24")]
	[Address(RVA = "0x2008CE0", Offset = "0x2008DE1", VA = "0x2008CE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8160", Offset = "0x1A8261")]
	private IEnumerator PlayDualWorkResult()
	{
		return null;
	}

	// Token: 0x060047CD RID: 18381 RVA: 0x000176A0 File Offset: 0x000158A0
	[Token(Token = "0x6003C25")]
	[Address(RVA = "0x2007990", Offset = "0x2007A91", VA = "0x2007990")]
	public bool IsDone()
	{
		return default(bool);
	}

	// Token: 0x060047CE RID: 18382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C26")]
	[Address(RVA = "0x20071F0", Offset = "0x20072F1", VA = "0x20071F0")]
	public void SetResultItem(ItemData _item)
	{
	}

	// Token: 0x060047CF RID: 18383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C27")]
	[Address(RVA = "0x2007340", Offset = "0x2007441", VA = "0x2007340")]
	public void SetResultItem(ItemData _item, int _craft_num)
	{
	}

	// Token: 0x060047D0 RID: 18384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003C28")]
	[Address(RVA = "0x2008D90", Offset = "0x2008E91", VA = "0x2008D90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A81D0", Offset = "0x1A82D1")]
	private IEnumerator PlaySemiTransAnim(bool _flag)
	{
		return null;
	}

	// Token: 0x060047D1 RID: 18385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C29")]
	[Address(RVA = "0x2008E50", Offset = "0x2008F51", VA = "0x2008E50")]
	public UICraftSuccess()
	{
	}

	// Token: 0x060047D2 RID: 18386 RVA: 0x000176B8 File Offset: 0x000158B8
	[Token(Token = "0x6003C2A")]
	[Address(RVA = "0x2008E60", Offset = "0x2008F61", VA = "0x2008E60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8240", Offset = "0x1A8341")]
	private bool <PlayDualWorkResult>b__7_0()
	{
		return default(bool);
	}

	// Token: 0x0400A730 RID: 42800
	[Token(Token = "0x4007E5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image resultImage;

	// Token: 0x0400A731 RID: 42801
	[Token(Token = "0x4007E60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text resultText;

	// Token: 0x0400A732 RID: 42802
	[Token(Token = "0x4007E61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image semiTrans;

	// Token: 0x0400A733 RID: 42803
	[Token(Token = "0x4007E62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private PlayableDirector playableDirector;

	// Token: 0x0400A734 RID: 42804
	[Token(Token = "0x4007E63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private UnityAction callBack;

	// Token: 0x02000ACD RID: 2765
	[Token(Token = "0x2001310")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159280", Offset = "0x159381")]
	private sealed class <PlayDualWorkResult>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060047D3 RID: 18387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768C")]
		[Address(RVA = "0x2008D60", Offset = "0x2008E61", VA = "0x2008D60")]
		[DebuggerHidden]
		public <PlayDualWorkResult>d__7(int <>1__state)
		{
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768D")]
		[Address(RVA = "0x2008EC0", Offset = "0x2008FC1", VA = "0x2008EC0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x000176D0 File Offset: 0x000158D0
		[Token(Token = "0x600768E")]
		[Address(RVA = "0x2008ED0", Offset = "0x2008FD1", VA = "0x2008ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060047D6 RID: 18390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D9F")]
		private object Current
		{
			[Token(Token = "0x600768F")]
			[Address(RVA = "0x20090E0", Offset = "0x20091E1", VA = "0x20090E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007690")]
		[Address(RVA = "0x20090F0", Offset = "0x20091F1", VA = "0x20090F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060047D8 RID: 18392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA0")]
		private object Current
		{
			[Token(Token = "0x6007691")]
			[Address(RVA = "0x2009150", Offset = "0x2009251", VA = "0x2009150", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A735 RID: 42805
		[Token(Token = "0x401B534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A736 RID: 42806
		[Token(Token = "0x401B535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A737 RID: 42807
		[Token(Token = "0x401B536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UICraftSuccess <>4__this;
	}

	// Token: 0x02000ACE RID: 2766
	[Token(Token = "0x2001311")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159290", Offset = "0x159391")]
	private sealed class <PlaySemiTransAnim>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060047D9 RID: 18393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007692")]
		[Address(RVA = "0x2008E20", Offset = "0x2008F21", VA = "0x2008E20")]
		[DebuggerHidden]
		public <PlaySemiTransAnim>d__11(int <>1__state)
		{
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007693")]
		[Address(RVA = "0x2009160", Offset = "0x2009261", VA = "0x2009160", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x000176E8 File Offset: 0x000158E8
		[Token(Token = "0x6007694")]
		[Address(RVA = "0x2009170", Offset = "0x2009271", VA = "0x2009170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060047DC RID: 18396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA1")]
		private object Current
		{
			[Token(Token = "0x6007695")]
			[Address(RVA = "0x2009370", Offset = "0x2009471", VA = "0x2009370", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007696")]
		[Address(RVA = "0x2009380", Offset = "0x2009481", VA = "0x2009380", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060047DE RID: 18398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA2")]
		private object Current
		{
			[Token(Token = "0x6007697")]
			[Address(RVA = "0x20093E0", Offset = "0x20094E1", VA = "0x20093E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A738 RID: 42808
		[Token(Token = "0x401B537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A739 RID: 42809
		[Token(Token = "0x401B538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A73A RID: 42810
		[Token(Token = "0x401B539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _flag;

		// Token: 0x0400A73B RID: 42811
		[Token(Token = "0x401B53A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UICraftSuccess <>4__this;

		// Token: 0x0400A73C RID: 42812
		[Token(Token = "0x401B53B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <timeCount>5__2;

		// Token: 0x0400A73D RID: 42813
		[Token(Token = "0x401B53C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <speed>5__3;

		// Token: 0x0400A73E RID: 42814
		[Token(Token = "0x401B53D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <rate>5__4;
	}
}
