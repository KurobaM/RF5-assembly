using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000949 RID: 2377
[Token(Token = "0x200063A")]
public class UICanvasGroupAnimation : MonoBehaviour
{
	// Token: 0x06003F03 RID: 16131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600346A")]
	[Address(RVA = "0x20023B0", Offset = "0x20024B1", VA = "0x20023B0")]
	private void Awake()
	{
	}

	// Token: 0x06003F04 RID: 16132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600346B")]
	[Address(RVA = "0x2002460", Offset = "0x2002561", VA = "0x2002460")]
	private void OnEnable()
	{
	}

	// Token: 0x06003F05 RID: 16133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600346C")]
	[Address(RVA = "0x2002650", Offset = "0x2002751", VA = "0x2002650")]
	private void OnDisable()
	{
	}

	// Token: 0x06003F06 RID: 16134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600346D")]
	[Address(RVA = "0x20025C0", Offset = "0x20026C1", VA = "0x20025C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A6FA0", Offset = "0x1A70A1")]
	public IEnumerator OnSlideAnimation(bool _flag)
	{
		return null;
	}

	// Token: 0x06003F07 RID: 16135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600346E")]
	[Address(RVA = "0x2002770", Offset = "0x2002871", VA = "0x2002770")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A7010", Offset = "0x1A7111")]
	public IEnumerator OnRoundAnimation([Optional] UnityAction _first_call_back, [Optional] CursorLinker _cursor)
	{
		return null;
	}

	// Token: 0x06003F08 RID: 16136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600346F")]
	[Address(RVA = "0x2002850", Offset = "0x2002951", VA = "0x2002850")]
	public UICanvasGroupAnimation()
	{
	}

	// Token: 0x04008087 RID: 32903
	[Token(Token = "0x40073CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CanvasGroup canvasGroup;

	// Token: 0x04008088 RID: 32904
	[Token(Token = "0x40073CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform rectTrans;

	// Token: 0x04008089 RID: 32905
	[Token(Token = "0x40073CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float animTime;

	// Token: 0x0400808A RID: 32906
	[Token(Token = "0x40073CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float roundAnimTime;

	// Token: 0x0400808B RID: 32907
	[Token(Token = "0x40073CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve fadeCurve;

	// Token: 0x0400808C RID: 32908
	[Token(Token = "0x40073CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve slideCurve;

	// Token: 0x0400808D RID: 32909
	[Token(Token = "0x40073D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector2 slideRange;

	// Token: 0x0400808E RID: 32910
	[Token(Token = "0x40073D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector2 objectPos;

	// Token: 0x0200094A RID: 2378
	[Token(Token = "0x2001291")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158E80", Offset = "0x158F81")]
	private sealed class <OnSlideAnimation>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003F09 RID: 16137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600757D")]
		[Address(RVA = "0x2002740", Offset = "0x2002841", VA = "0x2002740")]
		[DebuggerHidden]
		public <OnSlideAnimation>d__11(int <>1__state)
		{
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600757E")]
		[Address(RVA = "0x2002B80", Offset = "0x2002C81", VA = "0x2002B80", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x00015738 File Offset: 0x00013938
		[Token(Token = "0x600757F")]
		[Address(RVA = "0x2002B90", Offset = "0x2002C91", VA = "0x2002B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D82")]
		private object Current
		{
			[Token(Token = "0x6007580")]
			[Address(RVA = "0x2002F60", Offset = "0x2003061", VA = "0x2002F60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007581")]
		[Address(RVA = "0x2002F70", Offset = "0x2003071", VA = "0x2002F70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D83")]
		private object Current
		{
			[Token(Token = "0x6007582")]
			[Address(RVA = "0x2002FD0", Offset = "0x20030D1", VA = "0x2002FD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400808F RID: 32911
		[Token(Token = "0x4019920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04008090 RID: 32912
		[Token(Token = "0x4019921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04008091 RID: 32913
		[Token(Token = "0x4019922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UICanvasGroupAnimation <>4__this;

		// Token: 0x04008092 RID: 32914
		[Token(Token = "0x4019923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool _flag;

		// Token: 0x04008093 RID: 32915
		[Token(Token = "0x4019924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <curveSpeed>5__2;

		// Token: 0x04008094 RID: 32916
		[Token(Token = "0x4019925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <timeCount>5__3;

		// Token: 0x04008095 RID: 32917
		[Token(Token = "0x4019926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <curveRate>5__4;

		// Token: 0x04008096 RID: 32918
		[Token(Token = "0x4019927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 <start>5__5;

		// Token: 0x04008097 RID: 32919
		[Token(Token = "0x4019928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 <slidePos>5__6;
	}

	// Token: 0x0200094B RID: 2379
	[Token(Token = "0x2001292")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158E90", Offset = "0x158F91")]
	private sealed class <OnRoundAnimation>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003F0F RID: 16143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007583")]
		[Address(RVA = "0x2002820", Offset = "0x2002921", VA = "0x2002820")]
		[DebuggerHidden]
		public <OnRoundAnimation>d__12(int <>1__state)
		{
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007584")]
		[Address(RVA = "0x20028E0", Offset = "0x20029E1", VA = "0x20028E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x00015750 File Offset: 0x00013950
		[Token(Token = "0x6007585")]
		[Address(RVA = "0x20028F0", Offset = "0x20029F1", VA = "0x20028F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06003F12 RID: 16146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D84")]
		private object Current
		{
			[Token(Token = "0x6007586")]
			[Address(RVA = "0x2002B00", Offset = "0x2002C01", VA = "0x2002B00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007587")]
		[Address(RVA = "0x2002B10", Offset = "0x2002C11", VA = "0x2002B10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D85")]
		private object Current
		{
			[Token(Token = "0x6007588")]
			[Address(RVA = "0x2002B70", Offset = "0x2002C71", VA = "0x2002B70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04008098 RID: 32920
		[Token(Token = "0x4019929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04008099 RID: 32921
		[Token(Token = "0x401992A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400809A RID: 32922
		[Token(Token = "0x401992B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UICanvasGroupAnimation <>4__this;

		// Token: 0x0400809B RID: 32923
		[Token(Token = "0x401992C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction _first_call_back;

		// Token: 0x0400809C RID: 32924
		[Token(Token = "0x401992D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CursorLinker _cursor;
	}
}
