using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000625 RID: 1573
[Token(Token = "0x2000471")]
public class EquipItemLoader
{
	// Token: 0x060026D6 RID: 9942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020CC")]
	public static T Load<T>(string path) where T : UnityEngine.Object
	{
		return null;
	}

	// Token: 0x060026D7 RID: 9943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020CD")]
	[Address(RVA = "0x22B9260", Offset = "0x22B9361", VA = "0x22B9260")]
	public static UnityEngine.Object Load(string path)
	{
		return null;
	}

	// Token: 0x060026D8 RID: 9944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020CE")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1B40", Offset = "0x1A1C41")]
	public static IEnumerator LoadAsync<T>(string path, Action<T> completed) where T : UnityEngine.Object
	{
		return null;
	}

	// Token: 0x060026D9 RID: 9945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020CF")]
	[Address(RVA = "0x22B92B0", Offset = "0x22B93B1", VA = "0x22B92B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1BB0", Offset = "0x1A1CB1")]
	public static IEnumerator LoadAsync(string path, Action<UnityEngine.Object> completed)
	{
		return null;
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020D0")]
	[Address(RVA = "0x22B9380", Offset = "0x22B9481", VA = "0x22B9380")]
	public EquipItemLoader()
	{
	}

	// Token: 0x02000626 RID: 1574
	[Token(Token = "0x200113D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158100", Offset = "0x158201")]
	private sealed class <LoadAsync>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UnityEngine.Object
	{
		// Token: 0x060026DB RID: 9947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F5")]
		[DebuggerHidden]
		public <LoadAsync>d__2(int <>1__state)
		{
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F6")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x0000F528 File Offset: 0x0000D728
		[Token(Token = "0x60070F7")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFF")]
		private object Current
		{
			[Token(Token = "0x60070F8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F9")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D00")]
		private object Current
		{
			[Token(Token = "0x60070FA")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006DB0 RID: 28080
		[Token(Token = "0x401937F")]
		[FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x04006DB1 RID: 28081
		[Token(Token = "0x4019380")]
		[FieldOffset(Offset = "0x0")]
		private object <>2__current;

		// Token: 0x04006DB2 RID: 28082
		[Token(Token = "0x4019381")]
		[FieldOffset(Offset = "0x0")]
		public string path;

		// Token: 0x04006DB3 RID: 28083
		[Token(Token = "0x4019382")]
		[FieldOffset(Offset = "0x0")]
		public Action<T> completed;

		// Token: 0x04006DB4 RID: 28084
		[Token(Token = "0x4019383")]
		[FieldOffset(Offset = "0x0")]
		private ResourceRequest <request>5__2;
	}

	// Token: 0x02000627 RID: 1575
	[Token(Token = "0x200113E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158110", Offset = "0x158211")]
	private sealed class <LoadAsync>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060026E1 RID: 9953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070FB")]
		[Address(RVA = "0x22B9350", Offset = "0x22B9451", VA = "0x22B9350")]
		[DebuggerHidden]
		public <LoadAsync>d__3(int <>1__state)
		{
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070FC")]
		[Address(RVA = "0x22B9390", Offset = "0x22B9491", VA = "0x22B9390", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x60070FD")]
		[Address(RVA = "0x22B93A0", Offset = "0x22B94A1", VA = "0x22B93A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060026E4 RID: 9956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D01")]
		private object Current
		{
			[Token(Token = "0x60070FE")]
			[Address(RVA = "0x22B9430", Offset = "0x22B9531", VA = "0x22B9430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070FF")]
		[Address(RVA = "0x22B9440", Offset = "0x22B9541", VA = "0x22B9440", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D02")]
		private object Current
		{
			[Token(Token = "0x6007100")]
			[Address(RVA = "0x22B94A0", Offset = "0x22B95A1", VA = "0x22B94A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006DB5 RID: 28085
		[Token(Token = "0x4019384")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006DB6 RID: 28086
		[Token(Token = "0x4019385")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006DB7 RID: 28087
		[Token(Token = "0x4019386")]
		[FieldOffset(Offset = "0x20")]
		public string path;

		// Token: 0x04006DB8 RID: 28088
		[Token(Token = "0x4019387")]
		[FieldOffset(Offset = "0x28")]
		public Action<UnityEngine.Object> completed;
	}
}
