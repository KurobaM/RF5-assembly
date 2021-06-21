using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020002F6 RID: 758
[Token(Token = "0x200024D")]
public class ResourceManager<T> where T : UnityEngine.Object
{
	// Token: 0x0600141E RID: 5150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001246")]
	public ResourceManager(MonoBehaviour owner, int cacheNum)
	{
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001247")]
	public void Load(int id, [Optional] UnityAction<int, T> callback, int priority = 0)
	{
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x00009108 File Offset: 0x00007308
	[Token(Token = "0x6001248")]
	public bool IsLoaded(int key)
	{
		return default(bool);
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001249")]
	public void RemoveAll()
	{
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124A")]
	private void LoadAndCallback(ResourceManager<T>.ManagerInfo addData, int priority)
	{
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600124B")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19CB80", Offset = "0x19CC81")]
	private IEnumerator CallbackNextFrame(UnityAction<int, T> callback, int id, T tmp)
	{
		return null;
	}

	// Token: 0x04000B61 RID: 2913
	[Token(Token = "0x40008E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int CacheNum;

	// Token: 0x04000B62 RID: 2914
	[Token(Token = "0x40008E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private MonoBehaviour OwnerGameObject;

	// Token: 0x04000B63 RID: 2915
	[Token(Token = "0x40008E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public UnityAction<T> OnLoadCommon;

	// Token: 0x04000B64 RID: 2916
	[Token(Token = "0x40008E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<ResourceManager<T>.ManagerInfo> Resources;

	// Token: 0x04000B65 RID: 2917
	[Token(Token = "0x40008E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<int, ResourceManager<T>.ManagerInfo> ResourcesDic;

	// Token: 0x020002F7 RID: 759
	[Token(Token = "0x2001032")]
	private class ManagerInfo
	{
		// Token: 0x06001424 RID: 5156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC3")]
		public ManagerInfo(int key)
		{
		}

		// Token: 0x04000B66 RID: 2918
		[Token(Token = "0x4018EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Key;

		// Token: 0x04000B67 RID: 2919
		[Token(Token = "0x4018EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool IsLoaded;

		// Token: 0x04000B68 RID: 2920
		[Token(Token = "0x4018EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<UnityAction<int, T>> CallbackList;
	}

	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x2001033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1573C0", Offset = "0x1574C1")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x06001425 RID: 5157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC4")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC5")]
		internal void <LoadAndCallback>b__0(AssetHandle<T> handle)
		{
		}

		// Token: 0x04000B69 RID: 2921
		[Token(Token = "0x4018EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ResourceManager<T>.ManagerInfo addData;

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4018EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ResourceManager<T> <>4__this;
	}

	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x2001034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1573D0", Offset = "0x1574D1")]
	private sealed class <CallbackNextFrame>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001427 RID: 5159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC6")]
		[DebuggerHidden]
		public <CallbackNextFrame>d__11(int <>1__state)
		{
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC7")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x6006CC8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF5")]
		private object Current
		{
			[Token(Token = "0x6006CC9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCA")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF6")]
		private object Current
		{
			[Token(Token = "0x6006CCB")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B6B RID: 2923
		[Token(Token = "0x4018EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4018EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object <>2__current;

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4018EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UnityAction<int, T> callback;

		// Token: 0x04000B6E RID: 2926
		[Token(Token = "0x4018EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int id;

		// Token: 0x04000B6F RID: 2927
		[Token(Token = "0x4018EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T tmp;
	}
}
