using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;
using UnityEngine.U2D;

// Token: 0x02000B0E RID: 2830
[Token(Token = "0x200075E")]
public class UIMainManager : SingletonMonoBehaviour<UIMainManager>
{
	// Token: 0x170009B7 RID: 2487
	// (get) Token: 0x06004958 RID: 18776 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004959 RID: 18777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007BB")]
	public SpriteAtlas FaceIconAtlas
	{
		[Token(Token = "0x6003D50")]
		[Address(RVA = "0x2022D30", Offset = "0x2022E31", VA = "0x2022D30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8930", Offset = "0x1A8A31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003D51")]
		[Address(RVA = "0x2022D40", Offset = "0x2022E41", VA = "0x2022D40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8940", Offset = "0x1A8A41")]
		private set
		{
		}
	}

	// Token: 0x170009B8 RID: 2488
	// (get) Token: 0x0600495A RID: 18778 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600495B RID: 18779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007BC")]
	public SpriteAtlas MonsterFaceIconAtlas
	{
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x2022D50", Offset = "0x2022E51", VA = "0x2022D50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8950", Offset = "0x1A8A51")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x2022D60", Offset = "0x2022E61", VA = "0x2022D60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8960", Offset = "0x1A8A61")]
		private set
		{
		}
	}

	// Token: 0x170009B9 RID: 2489
	// (get) Token: 0x0600495C RID: 18780 RVA: 0x00017B98 File Offset: 0x00015D98
	[Token(Token = "0x170007BD")]
	public bool isLoadCompleted
	{
		[Token(Token = "0x6003D54")]
		[Address(RVA = "0x2022D70", Offset = "0x2022E71", VA = "0x2022D70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170009BA RID: 2490
	// (get) Token: 0x0600495D RID: 18781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007BE")]
	public UIModelLoader UIModelLoader
	{
		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x2022E50", Offset = "0x2022F51", VA = "0x2022E50")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600495E RID: 18782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D56")]
	[Address(RVA = "0x2022F00", Offset = "0x2023001", VA = "0x2022F00")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600495F RID: 18783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D57")]
	[Address(RVA = "0x2023090", Offset = "0x2023191", VA = "0x2023090")]
	private void Start()
	{
	}

	// Token: 0x06004960 RID: 18784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003D58")]
	public T GetComponent<T>(UIMainManager.AttachId id) where T : class
	{
		return null;
	}

	// Token: 0x06004961 RID: 18785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003D59")]
	[Address(RVA = "0x2023210", Offset = "0x2023311", VA = "0x2023210")]
	public GameObject GetComponent(UIMainManager.AttachId id)
	{
		return null;
	}

	// Token: 0x06004962 RID: 18786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003D5A")]
	public T GetPreload<T>(Prefab id) where T : class
	{
		return null;
	}

	// Token: 0x06004963 RID: 18787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003D5B")]
	public T GetPreload<T>(int id) where T : class
	{
		return null;
	}

	// Token: 0x06004964 RID: 18788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003D5C")]
	[Address(RVA = "0x2021B00", Offset = "0x2021C01", VA = "0x2021B00")]
	public GameObject GetPreload(Prefab id)
	{
		return null;
	}

	// Token: 0x06004965 RID: 18789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003D5D")]
	[Address(RVA = "0x2023330", Offset = "0x2023431", VA = "0x2023330")]
	public GameObject GetPreload(int id)
	{
		return null;
	}

	// Token: 0x06004966 RID: 18790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D5E")]
	[Address(RVA = "0x2023450", Offset = "0x2023551", VA = "0x2023450")]
	private void AddObject(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x06004967 RID: 18791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D5F")]
	[Address(RVA = "0x2023740", Offset = "0x2023841", VA = "0x2023740")]
	private void StartPreload()
	{
	}

	// Token: 0x06004968 RID: 18792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D60")]
	[Address(RVA = "0x2023A40", Offset = "0x2023B41", VA = "0x2023A40")]
	private void SetPreload(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x06004969 RID: 18793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D61")]
	[Address(RVA = "0x2023940", Offset = "0x2023A41", VA = "0x2023940")]
	public void LoadResourceOnGameStart()
	{
	}

	// Token: 0x0600496A RID: 18794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D62")]
	[Address(RVA = "0x2023C60", Offset = "0x2023D61", VA = "0x2023C60")]
	private void LastInit()
	{
	}

	// Token: 0x0600496B RID: 18795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D63")]
	[Address(RVA = "0x2023D40", Offset = "0x2023E41", VA = "0x2023D40")]
	public UIMainManager()
	{
	}

	// Token: 0x0600496C RID: 18796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D64")]
	[Address(RVA = "0x2023F00", Offset = "0x2024001", VA = "0x2023F00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8970", Offset = "0x1A8A71")]
	private void <LoadResourceOnGameStart>b__36_0(AssetHandle<SpriteAtlas> handle)
	{
	}

	// Token: 0x0600496D RID: 18797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D65")]
	[Address(RVA = "0x2023F80", Offset = "0x2024081", VA = "0x2023F80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8980", Offset = "0x1A8A81")]
	private void <LoadResourceOnGameStart>b__36_1(AssetHandle<SpriteAtlas> handle)
	{
	}

	// Token: 0x0400A92A RID: 43306
	[Token(Token = "0x4007F6D")]
	[FieldOffset(Offset = "0x18")]
	private readonly Prefab[] LoadIds;

	// Token: 0x0400A92B RID: 43307
	[Token(Token = "0x4007F6E")]
	[FieldOffset(Offset = "0x20")]
	private readonly int[] PreloadIds;

	// Token: 0x0400A92C RID: 43308
	[Token(Token = "0x4007F6F")]
	[FieldOffset(Offset = "0x28")]
	private readonly bool[] doActiveOnStart;

	// Token: 0x0400A92D RID: 43309
	[Token(Token = "0x4007F70")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> createdObjectList;

	// Token: 0x0400A92E RID: 43310
	[Token(Token = "0x4007F71")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> preloadObjectList;

	// Token: 0x0400A92F RID: 43311
	[Token(Token = "0x4007F72")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<UIMainManager.AttachId, int> AttachDic;

	// Token: 0x0400A930 RID: 43312
	[Token(Token = "0x4007F73")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<int, int> PreloadDic;

	// Token: 0x0400A931 RID: 43313
	[Token(Token = "0x4007F74")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> attachedObjectList;

	// Token: 0x0400A932 RID: 43314
	[Token(Token = "0x4007F75")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1744D0", Offset = "0x1745D1")]
	private SpriteAtlas <FaceIconAtlas>k__BackingField;

	// Token: 0x0400A933 RID: 43315
	[Token(Token = "0x4007F76")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1744E0", Offset = "0x1745E1")]
	private SpriteAtlas <MonsterFaceIconAtlas>k__BackingField;

	// Token: 0x0400A934 RID: 43316
	[Token(Token = "0x4007F77")]
	[FieldOffset(Offset = "0x68")]
	private int loadingNo;

	// Token: 0x0400A935 RID: 43317
	[Token(Token = "0x4007F78")]
	[FieldOffset(Offset = "0x70")]
	public UIItemParameterText ItemParameterText;

	// Token: 0x0400A936 RID: 43318
	[Token(Token = "0x4007F79")]
	[FieldOffset(Offset = "0x78")]
	public UIModelLoader _UIModelLoader;

	// Token: 0x0400A937 RID: 43319
	[Token(Token = "0x4007F7A")]
	[FieldOffset(Offset = "0x80")]
	private GameObject preloadObject;

	// Token: 0x02000B0F RID: 2831
	[Token(Token = "0x2001332")]
	public enum AttachId
	{
		// Token: 0x0400A939 RID: 43321
		[Token(Token = "0x401B621")]
		UICamera,
		// Token: 0x0400A93A RID: 43322
		[Token(Token = "0x401B622")]
		UIMainManager,
		// Token: 0x0400A93B RID: 43323
		[Token(Token = "0x401B623")]
		PlayerEquipModelLoader = 100,
		// Token: 0x0400A93C RID: 43324
		[Token(Token = "0x401B624")]
		UIModelLoaderForViewer,
		// Token: 0x0400A93D RID: 43325
		[Token(Token = "0x401B625")]
		UiLoadingStreamer = 200
	}
}
