using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x02000ADF RID: 2783
[Token(Token = "0x2000749")]
public class LoadLogoAnim : MonoBehaviour
{
	// Token: 0x0600483F RID: 18495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C84")]
	[Address(RVA = "0x23105C0", Offset = "0x23106C1", VA = "0x23105C0")]
	private void Start()
	{
	}

	// Token: 0x06004840 RID: 18496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C85")]
	[Address(RVA = "0x23106D0", Offset = "0x23107D1", VA = "0x23106D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004841 RID: 18497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003C86")]
	[Address(RVA = "0x2310650", Offset = "0x2310751", VA = "0x2310650")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8290", Offset = "0x1A8391")]
	private IEnumerator createPrefab()
	{
		return null;
	}

	// Token: 0x06004842 RID: 18498 RVA: 0x000177D8 File Offset: 0x000159D8
	[Token(Token = "0x6003C87")]
	[Address(RVA = "0x2310770", Offset = "0x2310871", VA = "0x2310770")]
	public int getStep()
	{
		return 0;
	}

	// Token: 0x06004843 RID: 18499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003C88")]
	[Address(RVA = "0x2310780", Offset = "0x2310881", VA = "0x2310780")]
	public PlayableDirector getDirector()
	{
		return null;
	}

	// Token: 0x06004844 RID: 18500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C89")]
	[Address(RVA = "0x2310790", Offset = "0x2310891", VA = "0x2310790")]
	public LoadLogoAnim()
	{
	}

	// Token: 0x06004845 RID: 18501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C8A")]
	[Address(RVA = "0x23107A0", Offset = "0x23108A1", VA = "0x23107A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8300", Offset = "0x1A8401")]
	private void <createPrefab>b__4_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x0400A7B6 RID: 42934
	[Token(Token = "0x4007EC5")]
	[FieldOffset(Offset = "0x18")]
	private int step;

	// Token: 0x0400A7B7 RID: 42935
	[Token(Token = "0x4007EC6")]
	[FieldOffset(Offset = "0x20")]
	private PlayableDirector logoAnimDirecter;

	// Token: 0x02000AE0 RID: 2784
	[Token(Token = "0x2001318")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1592C0", Offset = "0x1593C1")]
	private sealed class <createPrefab>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004846 RID: 18502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600769F")]
		[Address(RVA = "0x2310740", Offset = "0x2310841", VA = "0x2310740")]
		[DebuggerHidden]
		public <createPrefab>d__4(int <>1__state)
		{
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A0")]
		[Address(RVA = "0x2310900", Offset = "0x2310A01", VA = "0x2310900", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x000177F0 File Offset: 0x000159F0
		[Token(Token = "0x60076A1")]
		[Address(RVA = "0x2310910", Offset = "0x2310A11", VA = "0x2310910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06004849 RID: 18505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA3")]
		private object Current
		{
			[Token(Token = "0x60076A2")]
			[Address(RVA = "0x2310A50", Offset = "0x2310B51", VA = "0x2310A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A3")]
		[Address(RVA = "0x2310A60", Offset = "0x2310B61", VA = "0x2310A60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA4")]
		private object Current
		{
			[Token(Token = "0x60076A4")]
			[Address(RVA = "0x2310AC0", Offset = "0x2310BC1", VA = "0x2310AC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A7B8 RID: 42936
		[Token(Token = "0x401B554")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A7B9 RID: 42937
		[Token(Token = "0x401B555")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A7BA RID: 42938
		[Token(Token = "0x401B556")]
		[FieldOffset(Offset = "0x20")]
		public LoadLogoAnim <>4__this;
	}
}
