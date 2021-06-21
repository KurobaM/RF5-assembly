using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x02000AF0 RID: 2800
[Token(Token = "0x2000750")]
public class UITitle : MonoBehaviour
{
	// Token: 0x0600489C RID: 18588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CCD")]
	[Address(RVA = "0x21232E0", Offset = "0x21233E1", VA = "0x21232E0")]
	private void Start()
	{
	}

	// Token: 0x0600489D RID: 18589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CCE")]
	[Address(RVA = "0x21233F0", Offset = "0x21234F1", VA = "0x21233F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600489E RID: 18590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003CCF")]
	[Address(RVA = "0x2123370", Offset = "0x2123471", VA = "0x2123370")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8480", Offset = "0x1A8581")]
	private IEnumerator createPrefab()
	{
		return null;
	}

	// Token: 0x0600489F RID: 18591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CD0")]
	[Address(RVA = "0x2123530", Offset = "0x2123631", VA = "0x2123530")]
	public UITitle()
	{
	}

	// Token: 0x060048A0 RID: 18592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CD1")]
	[Address(RVA = "0x2123540", Offset = "0x2123641", VA = "0x2123540")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A84F0", Offset = "0x1A85F1")]
	private void <createPrefab>b__5_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x0400A897 RID: 43159
	[Token(Token = "0x4007F1F")]
	[FieldOffset(Offset = "0x18")]
	private int loadPriority;

	// Token: 0x0400A898 RID: 43160
	[Token(Token = "0x4007F20")]
	[FieldOffset(Offset = "0x1C")]
	private int step;

	// Token: 0x0400A899 RID: 43161
	[Token(Token = "0x4007F21")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_TitlePrefab;

	// Token: 0x02000AF1 RID: 2801
	[Token(Token = "0x2001322")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159300", Offset = "0x159401")]
	private sealed class <createPrefab>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060048A1 RID: 18593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B3")]
		[Address(RVA = "0x2123500", Offset = "0x2123601", VA = "0x2123500")]
		[DebuggerHidden]
		public <createPrefab>d__5(int <>1__state)
		{
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B4")]
		[Address(RVA = "0x2123660", Offset = "0x2123761", VA = "0x2123660", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x00017928 File Offset: 0x00015B28
		[Token(Token = "0x60076B5")]
		[Address(RVA = "0x2123670", Offset = "0x2123771", VA = "0x2123670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x060048A4 RID: 18596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA9")]
		private object Current
		{
			[Token(Token = "0x60076B6")]
			[Address(RVA = "0x21237B0", Offset = "0x21238B1", VA = "0x21237B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B7")]
		[Address(RVA = "0x21237C0", Offset = "0x21238C1", VA = "0x21237C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DAA")]
		private object Current
		{
			[Token(Token = "0x60076B8")]
			[Address(RVA = "0x2123820", Offset = "0x2123921", VA = "0x2123820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A89A RID: 43162
		[Token(Token = "0x401B5DB")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A89B RID: 43163
		[Token(Token = "0x401B5DC")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A89C RID: 43164
		[Token(Token = "0x401B5DD")]
		[FieldOffset(Offset = "0x20")]
		public UITitle <>4__this;
	}
}
