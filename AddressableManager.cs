using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

// Token: 0x02000302 RID: 770
[Token(Token = "0x200024F")]
public static class AddressableManager
{
	// Token: 0x0600145A RID: 5210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600125E")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19CD40", Offset = "0x19CE41")]
	public static IEnumerator LoadResourceAsset<T>(string assetName, [Optional] Transform parent, [Optional] UnityAction<T> callback) where T : UnityEngine.Object
	{
		return null;
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600125F")]
	public static void ReleaseResourceAsset<T>(T obj)
	{
	}

	// Token: 0x04000B99 RID: 2969
	[Token(Token = "0x40008EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool addressableInit;

	// Token: 0x02000303 RID: 771
	[Token(Token = "0x200103C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157440", Offset = "0x157541")]
	private sealed class <>c__DisplayClass1_0<T> where T : UnityEngine.Object
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE7")]
		public <>c__DisplayClass1_0()
		{
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE8")]
		internal void <LoadResourceAsset>b__0(AsyncOperationHandle<T> op)
		{
		}

		// Token: 0x04000B9A RID: 2970
		[Token(Token = "0x4018F21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ret_object;

		// Token: 0x04000B9B RID: 2971
		[Token(Token = "0x4018F22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool isloaded;
	}

	// Token: 0x02000304 RID: 772
	[Token(Token = "0x200103D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157450", Offset = "0x157551")]
	private sealed class <LoadResourceAsset>d__1<T> : IEnumerator<object>, IEnumerator, IDisposable where T : UnityEngine.Object
	{
		// Token: 0x0600145F RID: 5215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE9")]
		[DebuggerHidden]
		public <LoadResourceAsset>d__1(int <>1__state)
		{
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CEA")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x6006CEB")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFD")]
		private object Current
		{
			[Token(Token = "0x6006CEC")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CED")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFE")]
		private object Current
		{
			[Token(Token = "0x6006CEE")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B9C RID: 2972
		[Token(Token = "0x4018F23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x04000B9D RID: 2973
		[Token(Token = "0x4018F24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		// Token: 0x04000B9E RID: 2974
		[Token(Token = "0x4018F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string assetName;

		// Token: 0x04000B9F RID: 2975
		[Token(Token = "0x4018F26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AddressableManager.<>c__DisplayClass1_0<T> <>8__1;

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4018F27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UnityAction<T> callback;

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4018F28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform parent;
	}
}
