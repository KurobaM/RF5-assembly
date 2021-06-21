using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A68 RID: 2664
[Token(Token = "0x20006FF")]
public class SystemTextGenerator : MonoBehaviour
{
	// Token: 0x17000965 RID: 2405
	// (get) Token: 0x06004582 RID: 17794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700078D")]
	public static SystemTextGenerator MySystemTextGenerator
	{
		[Token(Token = "0x6003A2E")]
		[Address(RVA = "0x1FB5330", Offset = "0x1FB5431", VA = "0x1FB5330")]
		get
		{
			return null;
		}
	}

	// Token: 0x06004583 RID: 17795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A2F")]
	[Address(RVA = "0x1FB5380", Offset = "0x1FB5481", VA = "0x1FB5380")]
	public void AddSystemMessage(string text)
	{
	}

	// Token: 0x06004584 RID: 17796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003A30")]
	[Address(RVA = "0x1FB5420", Offset = "0x1FB5521", VA = "0x1FB5420")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A7B70", Offset = "0x1A7C71")]
	private IEnumerator impl_AddSystemMessage(string text)
	{
		return null;
	}

	// Token: 0x06004585 RID: 17797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A31")]
	[Address(RVA = "0x1FB4F90", Offset = "0x1FB5091", VA = "0x1FB4F90")]
	public void OnDestroyTextDisp(SystemTextDisp systemTextDisp)
	{
	}

	// Token: 0x06004586 RID: 17798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A32")]
	[Address(RVA = "0x1FB5640", Offset = "0x1FB5741", VA = "0x1FB5640")]
	private void Awake()
	{
	}

	// Token: 0x06004587 RID: 17799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A33")]
	[Address(RVA = "0x1FB54F0", Offset = "0x1FB55F1", VA = "0x1FB54F0")]
	private void AdjustPosition()
	{
	}

	// Token: 0x06004588 RID: 17800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A34")]
	[Address(RVA = "0x1FB56D0", Offset = "0x1FB57D1", VA = "0x1FB56D0")]
	private void Update()
	{
	}

	// Token: 0x06004589 RID: 17801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A35")]
	[Address(RVA = "0x1FB57C0", Offset = "0x1FB58C1", VA = "0x1FB57C0")]
	public SystemTextGenerator()
	{
	}

	// Token: 0x0400A454 RID: 42068
	[Token(Token = "0x4007C41")]
	[FieldOffset(Offset = "0x0")]
	private static SystemTextGenerator _SystemTextGenerator;

	// Token: 0x0400A455 RID: 42069
	[Token(Token = "0x4007C42")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SystemTextDisp SystemTextDispPrefabs;

	// Token: 0x0400A456 RID: 42070
	[Token(Token = "0x4007C43")]
	[FieldOffset(Offset = "0x20")]
	private List<SystemTextDisp> SystemTextDispList;

	// Token: 0x02000A69 RID: 2665
	[Token(Token = "0x20012EB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159120", Offset = "0x159221")]
	private sealed class <impl_AddSystemMessage>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600458A RID: 17802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007638")]
		[Address(RVA = "0x1FB54C0", Offset = "0x1FB55C1", VA = "0x1FB54C0")]
		[DebuggerHidden]
		public <impl_AddSystemMessage>d__6(int <>1__state)
		{
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007639")]
		[Address(RVA = "0x1FB57D0", Offset = "0x1FB58D1", VA = "0x1FB57D0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00017100 File Offset: 0x00015300
		[Token(Token = "0x600763A")]
		[Address(RVA = "0x1FB57E0", Offset = "0x1FB58E1", VA = "0x1FB57E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D95")]
		private object Current
		{
			[Token(Token = "0x600763B")]
			[Address(RVA = "0x1FB5970", Offset = "0x1FB5A71", VA = "0x1FB5970", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600763C")]
		[Address(RVA = "0x1FB5980", Offset = "0x1FB5A81", VA = "0x1FB5980", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x0600458F RID: 17807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D96")]
		private object Current
		{
			[Token(Token = "0x600763D")]
			[Address(RVA = "0x1FB59E0", Offset = "0x1FB5AE1", VA = "0x1FB59E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A457 RID: 42071
		[Token(Token = "0x401B476")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A458 RID: 42072
		[Token(Token = "0x401B477")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A459 RID: 42073
		[Token(Token = "0x401B478")]
		[FieldOffset(Offset = "0x20")]
		public SystemTextGenerator <>4__this;

		// Token: 0x0400A45A RID: 42074
		[Token(Token = "0x401B479")]
		[FieldOffset(Offset = "0x28")]
		public string text;
	}
}
