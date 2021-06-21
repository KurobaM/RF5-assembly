using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000B19 RID: 2841
[Token(Token = "0x2000767")]
public abstract class SpriteAssetLoader : SingletonMonoBehaviour<SpriteAssetLoader>
{
	// Token: 0x06004988 RID: 18824 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003D80")]
	[Address(RVA = "0x2387AD0", Offset = "0x2387BD1", VA = "0x2387AD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8990", Offset = "0x1A8A91")]
	private IEnumerator LoadData(string path, UnityAction<SpriteDataResource> func)
	{
		return null;
	}

	// Token: 0x06004989 RID: 18825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D81")]
	[Address(RVA = "0x2387BA0", Offset = "0x2387CA1", VA = "0x2387BA0")]
	public void Load(int spriteNum, Image image)
	{
	}

	// Token: 0x0600498A RID: 18826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D82")]
	[Address(RVA = "0x2387E20", Offset = "0x2387F21", VA = "0x2387E20")]
	private void ImageLoaded(SpriteDataResource spriteDataResource)
	{
	}

	// Token: 0x0600498B RID: 18827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D83")]
	[Address(RVA = "0x23880D0", Offset = "0x23881D1", VA = "0x23880D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600498C RID: 18828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D84")]
	[Address(RVA = "0x2388110", Offset = "0x2388211", VA = "0x2388110")]
	protected SpriteAssetLoader()
	{
	}

	// Token: 0x0400A94F RID: 43343
	[Token(Token = "0x4007F8A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Sprite LoadingSprite;

	// Token: 0x0400A950 RID: 43344
	[Token(Token = "0x4007F8B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite DefaultSprite;

	// Token: 0x0400A951 RID: 43345
	[Token(Token = "0x4007F8C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string Path;

	// Token: 0x0400A952 RID: 43346
	[Token(Token = "0x4007F8D")]
	[FieldOffset(Offset = "0x30")]
	private Image Image;

	// Token: 0x0400A953 RID: 43347
	[Token(Token = "0x4007F8E")]
	[FieldOffset(Offset = "0x38")]
	private int SpriteNum;

	// Token: 0x0400A954 RID: 43348
	[Token(Token = "0x4007F8F")]
	[FieldOffset(Offset = "0x40")]
	private IEnumerator SpriteLoadCoroutine;

	// Token: 0x0400A955 RID: 43349
	[Token(Token = "0x4007F90")]
	[FieldOffset(Offset = "0x48")]
	private bool loading;

	// Token: 0x0400A956 RID: 43350
	[Token(Token = "0x4007F91")]
	[FieldOffset(Offset = "0x50")]
	private SpriteDataResource SpriteDataResource;

	// Token: 0x02000B1A RID: 2842
	[Token(Token = "0x2001334")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1593B0", Offset = "0x1594B1")]
	private sealed class <LoadData>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600498D RID: 18829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EC")]
		[Address(RVA = "0x2387B70", Offset = "0x2387C71", VA = "0x2387B70")]
		[DebuggerHidden]
		public <LoadData>d__8(int <>1__state)
		{
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076ED")]
		[Address(RVA = "0x2388170", Offset = "0x2388271", VA = "0x2388170", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x00017BB0 File Offset: 0x00015DB0
		[Token(Token = "0x60076EE")]
		[Address(RVA = "0x2388180", Offset = "0x2388281", VA = "0x2388180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06004990 RID: 18832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB9")]
		private object Current
		{
			[Token(Token = "0x60076EF")]
			[Address(RVA = "0x2388240", Offset = "0x2388341", VA = "0x2388240", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076F0")]
		[Address(RVA = "0x2388250", Offset = "0x2388351", VA = "0x2388250", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06004992 RID: 18834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBA")]
		private object Current
		{
			[Token(Token = "0x60076F1")]
			[Address(RVA = "0x23882B0", Offset = "0x23883B1", VA = "0x23882B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A957 RID: 43351
		[Token(Token = "0x401B628")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A958 RID: 43352
		[Token(Token = "0x401B629")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A959 RID: 43353
		[Token(Token = "0x401B62A")]
		[FieldOffset(Offset = "0x20")]
		public string path;

		// Token: 0x0400A95A RID: 43354
		[Token(Token = "0x401B62B")]
		[FieldOffset(Offset = "0x28")]
		public UnityAction<SpriteDataResource> func;
	}
}
