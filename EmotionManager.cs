using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;

// Token: 0x02000277 RID: 631
[Token(Token = "0x20001F6")]
public class EmotionManager : SingletonMonoBehaviour<EmotionManager>
{
	// Token: 0x170002DF RID: 735
	// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x000072A8 File Offset: 0x000054A8
	// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002B5")]
	public bool InitCompleted
	{
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x22B0860", Offset = "0x22B0961", VA = "0x22B0860")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C290", Offset = "0x19C391")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x22B0870", Offset = "0x22B0971", VA = "0x22B0870")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C2A0", Offset = "0x19C3A1")]
		private set
		{
		}
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E3B")]
	[Address(RVA = "0x22B0880", Offset = "0x22B0981", VA = "0x22B0880")]
	public void Init()
	{
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E3C")]
	[Address(RVA = "0x22B09C0", Offset = "0x22B0AC1", VA = "0x22B09C0")]
	public void LoadReasource(EmotionType type, Prefab id)
	{
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0x22B0AF0", Offset = "0x22B0BF1", VA = "0x22B0AF0")]
	public void RemoveAll()
	{
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x000072C0 File Offset: 0x000054C0
	[Token(Token = "0x6000E3E")]
	[Address(RVA = "0x22AFB50", Offset = "0x22AFC51", VA = "0x22AFB50")]
	public bool Create(EmotionType type, Vector3 position, Transform parent, out EmotionEffectController effect)
	{
		return default(bool);
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x000072D8 File Offset: 0x000054D8
	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0x22AF540", Offset = "0x22AF641", VA = "0x22AF540")]
	public bool Regist(EmotionController controller)
	{
		return default(bool);
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x000072F0 File Offset: 0x000054F0
	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x22AF6C0", Offset = "0x22AF7C1", VA = "0x22AF6C0")]
	public bool Remove(EmotionController controller)
	{
		return default(bool);
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x22B0C60", Offset = "0x22B0D61", VA = "0x22B0C60")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x22B0C70", Offset = "0x22B0D71", VA = "0x22B0C70")]
	private void Update()
	{
	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x22B0D90", Offset = "0x22B0E91", VA = "0x22B0D90")]
	public void DoStopAll()
	{
	}

	// Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x22AEF30", Offset = "0x22AF031", VA = "0x22AEF30")]
	public static EmotionEffectController Timeline_OnBehaviourPlay(EmotionType type, Transform parent, Vector3 position)
	{
		return null;
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x22B0EB0", Offset = "0x22B0FB1", VA = "0x22B0EB0")]
	public EmotionManager()
	{
	}

	// Token: 0x040008FB RID: 2299
	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<EmotionType, Prefab> m_EmotionLoaderIds;

	// Token: 0x040008FC RID: 2300
	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x18")]
	private List<EmotionType> m_EntryList;

	// Token: 0x040008FD RID: 2301
	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0x20")]
	private Register<EmotionController> m_Register;

	// Token: 0x040008FE RID: 2302
	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E940", Offset = "0x15EA41")]
	private bool <InitCompleted>k__BackingField;

	// Token: 0x02000278 RID: 632
	[Token(Token = "0x200100A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1572B0", Offset = "0x1573B1")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C74")]
		[Address(RVA = "0x22B0AE0", Offset = "0x22B0BE1", VA = "0x22B0AE0")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C75")]
		[Address(RVA = "0x22B1240", Offset = "0x22B1341", VA = "0x22B1240")]
		internal void <LoadReasource>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x4018E57")]
		[FieldOffset(Offset = "0x10")]
		public EmotionManager <>4__this;

		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4018E58")]
		[FieldOffset(Offset = "0x18")]
		public EmotionType type;
	}
}
