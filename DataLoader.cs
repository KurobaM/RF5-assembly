using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020002E0 RID: 736
[Token(Token = "0x200023F")]
public abstract class DataLoader<E, T> : SingletonMonoBehaviour<T> where E : Enum where T : MonoBehaviour
{
	// Token: 0x1700037C RID: 892
	// (get) Token: 0x06001394 RID: 5012 RVA: 0x00008D90 File Offset: 0x00006F90
	[Token(Token = "0x17000344")]
	public bool IsCompleted
	{
		[Token(Token = "0x60011C8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700037D RID: 893
	// (get) Token: 0x06001395 RID: 5013 RVA: 0x00008DA8 File Offset: 0x00006FA8
	[Token(Token = "0x17000345")]
	public bool IsLoading
	{
		[Token(Token = "0x60011C9")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700037E RID: 894
	// (get) Token: 0x06001396 RID: 5014 RVA: 0x00008DC0 File Offset: 0x00006FC0
	[Token(Token = "0x17000346")]
	protected virtual int LoadPriority
	{
		[Token(Token = "0x60011CA")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x00008DD8 File Offset: 0x00006FD8
	[Token(Token = "0x60011CB")]
	public bool Load()
	{
		return default(bool);
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CC")]
	private void Load_internal(E id)
	{
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011CD")]
	public ScriptableObject Get(E id)
	{
		return null;
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CE")]
	public void Reset()
	{
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011CF")]
	protected DataLoader()
	{
	}

	// Token: 0x04000AF9 RID: 2809
	[Token(Token = "0x4000893")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<E, ScriptableObject> LoadedDic;

	// Token: 0x04000AFA RID: 2810
	[Token(Token = "0x4000894")]
	[FieldOffset(Offset = "0x0")]
	private int LoadCount;

	// Token: 0x04000AFB RID: 2811
	[Token(Token = "0x4000895")]
	[FieldOffset(Offset = "0x0")]
	private int LoadCountMax;

	// Token: 0x020002E1 RID: 737
	[Token(Token = "0x200102A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157390", Offset = "0x157491")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x0600139C RID: 5020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB7")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB8")]
		internal void <Load_internal>b__0(AssetHandle<ScriptableObject> handle)
		{
		}

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4018ED9")]
		[FieldOffset(Offset = "0x0")]
		public DataLoader<E, T> <>4__this;

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4018EDA")]
		[FieldOffset(Offset = "0x0")]
		public E id;
	}
}
