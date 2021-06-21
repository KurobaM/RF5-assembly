using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Loader
{
	// Token: 0x02001022 RID: 4130
	[Token(Token = "0x2000A74")]
	public class AssetHandle<T> : AssetHandle where T : UnityEngine.Object
	{
		// Token: 0x06006834 RID: 26676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056BC")]
		public static AssetHandle<T> Create(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only)
		{
			return null;
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056BD")]
		public static AssetHandle<T> GetHandle(int id)
		{
			return null;
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06006836 RID: 26678 RVA: 0x000239B8 File Offset: 0x00021BB8
		// (set) Token: 0x06006837 RID: 26679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A70")]
		public AsyncOperationHandle<T> AoHandle
		{
			[Token(Token = "0x60056BE")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD120", Offset = "0x1AD221")]
			get
			{
				return default(AsyncOperationHandle<T>);
			}
			[Token(Token = "0x60056BF")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD130", Offset = "0x1AD231")]
			private set
			{
			}
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C0")]
		private void Set(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only)
		{
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C1")]
		private void Add(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only)
		{
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C2")]
		public override void Remove(bool force = false)
		{
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x000239D0 File Offset: 0x00021BD0
		[Token(Token = "0x60056C3")]
		public override bool LoadAsync(bool load = true)
		{
			return default(bool);
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x000239E8 File Offset: 0x00021BE8
		[Token(Token = "0x60056C4")]
		private static bool LoadAsyncNone(AssetHandle<T> handle, bool load)
		{
			return default(bool);
		}

		// Token: 0x0600683D RID: 26685 RVA: 0x00023A00 File Offset: 0x00021C00
		[Token(Token = "0x60056C5")]
		private static bool LoadAsyncEntry(AssetHandle<T> handle, bool load)
		{
			return default(bool);
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C6")]
		private void Unload(bool release = true, bool remove = true)
		{
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C7")]
		private void OnComplete(AsyncOperationHandle<T> handle)
		{
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06006840 RID: 26688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A71")]
		public T Result
		{
			[Token(Token = "0x60056C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C9")]
		public AssetHandle()
		{
		}

		// Token: 0x0400C783 RID: 51075
		[Token(Token = "0x400940D")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180300", Offset = "0x180401")]
		private AsyncOperationHandle<T> <AoHandle>k__BackingField;

		// Token: 0x0400C784 RID: 51076
		[Token(Token = "0x400940E")]
		[FieldOffset(Offset = "0x0")]
		private UnityAction<AssetHandle<T>> Callback;

		// Token: 0x0400C785 RID: 51077
		[Token(Token = "0x400940F")]
		[FieldOffset(Offset = "0x0")]
		private static AssetHandle<T>.LoadAsyncVJ[] loadAsyncVJ;

		// Token: 0x02001023 RID: 4131
		// (Invoke) Token: 0x06006844 RID: 26692
		[Token(Token = "0x200151A")]
		private delegate bool LoadAsyncVJ(AssetHandle<T> handle, bool load);
	}
}
