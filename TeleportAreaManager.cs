using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using DataTable;
using Define;
using DG.Tweening;
using Field;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200058F RID: 1423
[Token(Token = "0x20003FE")]
public class TeleportAreaManager : SingletonMonoBehaviour<TeleportAreaManager>
{
	// Token: 0x1700059D RID: 1437
	// (get) Token: 0x06002299 RID: 8857 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600229A RID: 8858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000481")]
	public string SceneName
	{
		[Token(Token = "0x6001D21")]
		[Address(RVA = "0x1F5EC20", Offset = "0x1F5ED21", VA = "0x1F5EC20")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x1F5EC30", Offset = "0x1F5ED31", VA = "0x1F5EC30")]
		set
		{
		}
	}

	// Token: 0x1700059E RID: 1438
	// (get) Token: 0x0600229B RID: 8859 RVA: 0x0000E190 File Offset: 0x0000C390
	// (set) Token: 0x0600229C RID: 8860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000482")]
	public FieldPlaceId FieldPlaceId
	{
		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x1F5EC40", Offset = "0x1F5ED41", VA = "0x1F5EC40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0C90", Offset = "0x1A0D91")]
		get
		{
			return FieldPlaceId.None;
		}
		[Token(Token = "0x6001D24")]
		[Address(RVA = "0x1F5EC50", Offset = "0x1F5ED51", VA = "0x1F5EC50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0CA0", Offset = "0x1A0DA1")]
		private set
		{
		}
	}

	// Token: 0x1700059F RID: 1439
	// (get) Token: 0x0600229D RID: 8861 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
	// (set) Token: 0x0600229E RID: 8862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000483")]
	public FieldPlaceId FieldMapAreaPlaceId
	{
		[Token(Token = "0x6001D25")]
		[Address(RVA = "0x1F5EC60", Offset = "0x1F5ED61", VA = "0x1F5EC60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0CB0", Offset = "0x1A0DB1")]
		get
		{
			return FieldPlaceId.None;
		}
		[Token(Token = "0x6001D26")]
		[Address(RVA = "0x1F5EC70", Offset = "0x1F5ED71", VA = "0x1F5EC70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0CC0", Offset = "0x1A0DC1")]
		private set
		{
		}
	}

	// Token: 0x170005A0 RID: 1440
	// (get) Token: 0x0600229F RID: 8863 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
	// (set) Token: 0x060022A0 RID: 8864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000484")]
	public FieldSceneId FieldSceneId
	{
		[Token(Token = "0x6001D27")]
		[Address(RVA = "0x1F5EC80", Offset = "0x1F5ED81", VA = "0x1F5EC80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0CD0", Offset = "0x1A0DD1")]
		get
		{
			return FieldSceneId.Empty;
		}
		[Token(Token = "0x6001D28")]
		[Address(RVA = "0x1F5EC90", Offset = "0x1F5ED91", VA = "0x1F5EC90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0CE0", Offset = "0x1A0DE1")]
		private set
		{
		}
	}

	// Token: 0x170005A1 RID: 1441
	// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
	[Token(Token = "0x17000485")]
	public bool IsPlayerInKyoten
	{
		[Token(Token = "0x6001D29")]
		[Address(RVA = "0x1F5ECA0", Offset = "0x1F5EDA1", VA = "0x1F5ECA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005A2 RID: 1442
	// (get) Token: 0x060022A2 RID: 8866 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060022A3 RID: 8867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000486")]
	public Stack<FieldSceneId> FieldSceneIdStack
	{
		[Token(Token = "0x6001D2A")]
		[Address(RVA = "0x1F5ECB0", Offset = "0x1F5EDB1", VA = "0x1F5ECB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0CF0", Offset = "0x1A0DF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0x1F5ECC0", Offset = "0x1F5EDC1", VA = "0x1F5ECC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0D00", Offset = "0x1A0E01")]
		private set
		{
		}
	}

	// Token: 0x170005A3 RID: 1443
	// (get) Token: 0x060022A4 RID: 8868 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
	[Token(Token = "0x17000487")]
	public FieldSceneId CurrentFieldSceneIdStack
	{
		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x1F5ECD0", Offset = "0x1F5EDD1", VA = "0x1F5ECD0")]
		get
		{
			return FieldSceneId.Empty;
		}
	}

	// Token: 0x170005A4 RID: 1444
	// (get) Token: 0x060022A5 RID: 8869 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060022A6 RID: 8870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000488")]
	public string PrevSceneName
	{
		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x1F5ED50", Offset = "0x1F5EE51", VA = "0x1F5ED50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x1F5ED60", Offset = "0x1F5EE61", VA = "0x1F5ED60")]
		set
		{
		}
	}

	// Token: 0x170005A5 RID: 1445
	// (get) Token: 0x060022A7 RID: 8871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000489")]
	public Stack<string> SceneNameStack
	{
		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x1F5ED70", Offset = "0x1F5EE71", VA = "0x1F5ED70")]
		get
		{
			return null;
		}
	}

	// Token: 0x170005A6 RID: 1446
	// (get) Token: 0x060022A8 RID: 8872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700048A")]
	public string CurrentSceneNameStack
	{
		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x1F5ED80", Offset = "0x1F5EE81", VA = "0x1F5ED80")]
		get
		{
			return null;
		}
	}

	// Token: 0x170005A7 RID: 1447
	// (get) Token: 0x060022A9 RID: 8873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700048B")]
	public FieldSceneData.Data[] SceneDataTable
	{
		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x1F5EE40", Offset = "0x1F5EF41", VA = "0x1F5EE40")]
		get
		{
			return null;
		}
	}

	// Token: 0x170005A8 RID: 1448
	// (get) Token: 0x060022AA RID: 8874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700048C")]
	public PlayerTeleport PlayerTeleport
	{
		[Token(Token = "0x6001D32")]
		[Address(RVA = "0x1F5EE60", Offset = "0x1F5EF61", VA = "0x1F5EE60")]
		get
		{
			return null;
		}
	}

	// Token: 0x170005A9 RID: 1449
	// (get) Token: 0x060022AB RID: 8875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700048D")]
	public PlayerMover PlayerMover
	{
		[Token(Token = "0x6001D33")]
		[Address(RVA = "0x1F5EE70", Offset = "0x1F5EF71", VA = "0x1F5EE70")]
		get
		{
			return null;
		}
	}

	// Token: 0x170005AA RID: 1450
	// (get) Token: 0x060022AC RID: 8876 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060022AD RID: 8877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700048E")]
	public Streamer[] Streamers
	{
		[Token(Token = "0x6001D34")]
		[Address(RVA = "0x1F5EE80", Offset = "0x1F5EF81", VA = "0x1F5EE80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D35")]
		[Address(RVA = "0x1F5EE90", Offset = "0x1F5EF91", VA = "0x1F5EE90")]
		private set
		{
		}
	}

	// Token: 0x170005AB RID: 1451
	// (get) Token: 0x060022AE RID: 8878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700048F")]
	public static CharacterMoveSetting CharacterMoveSetting
	{
		[Token(Token = "0x6001D36")]
		[Address(RVA = "0x1F5EEA0", Offset = "0x1F5EFA1", VA = "0x1F5EEA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170005AC RID: 1452
	// (get) Token: 0x060022AF RID: 8879 RVA: 0x0000E208 File Offset: 0x0000C408
	// (set) Token: 0x060022B0 RID: 8880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000490")]
	public LayerMask GroundLayer
	{
		[Token(Token = "0x6001D37")]
		[Address(RVA = "0x1F5EF50", Offset = "0x1F5F051", VA = "0x1F5EF50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0D10", Offset = "0x1A0E11")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x6001D38")]
		[Address(RVA = "0x1F5EF60", Offset = "0x1F5F061", VA = "0x1F5EF60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0D20", Offset = "0x1A0E21")]
		private set
		{
		}
	}

	// Token: 0x170005AD RID: 1453
	// (get) Token: 0x060022B1 RID: 8881 RVA: 0x0000E220 File Offset: 0x0000C420
	// (set) Token: 0x060022B2 RID: 8882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000491")]
	public bool IsTeleporting
	{
		[Token(Token = "0x6001D39")]
		[Address(RVA = "0x1F5EF70", Offset = "0x1F5F071", VA = "0x1F5EF70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0D30", Offset = "0x1A0E31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D3A")]
		[Address(RVA = "0x1F5EF80", Offset = "0x1F5F081", VA = "0x1F5EF80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0D40", Offset = "0x1A0E41")]
		set
		{
		}
	}

	// Token: 0x170005AE RID: 1454
	// (get) Token: 0x060022B3 RID: 8883 RVA: 0x0000E238 File Offset: 0x0000C438
	// (set) Token: 0x060022B4 RID: 8884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000492")]
	public bool IsShortPlayLock
	{
		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0x1F5EF90", Offset = "0x1F5F091", VA = "0x1F5EF90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0D50", Offset = "0x1A0E51")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x1F5EFA0", Offset = "0x1F5F0A1", VA = "0x1F5EFA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0D60", Offset = "0x1A0E61")]
		set
		{
		}
	}

	// Token: 0x170005AF RID: 1455
	// (get) Token: 0x060022B5 RID: 8885 RVA: 0x0000E250 File Offset: 0x0000C450
	// (set) Token: 0x060022B6 RID: 8886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000493")]
	public bool IsTeleportEndFade
	{
		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0x1F5EFB0", Offset = "0x1F5F0B1", VA = "0x1F5EFB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0D70", Offset = "0x1A0E71")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0x1F5EFC0", Offset = "0x1F5F0C1", VA = "0x1F5EFC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0D80", Offset = "0x1A0E81")]
		private set
		{
		}
	}

	// Token: 0x170005B0 RID: 1456
	// (get) Token: 0x060022B7 RID: 8887 RVA: 0x0000E268 File Offset: 0x0000C468
	// (set) Token: 0x060022B8 RID: 8888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000494")]
	public bool IsCameraCulling
	{
		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x1F5EFD0", Offset = "0x1F5F0D1", VA = "0x1F5EFD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0D90", Offset = "0x1A0E91")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D40")]
		[Address(RVA = "0x1F5EFE0", Offset = "0x1F5F0E1", VA = "0x1F5EFE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0DA0", Offset = "0x1A0EA1")]
		private set
		{
		}
	}

	// Token: 0x170005B1 RID: 1457
	// (get) Token: 0x060022B9 RID: 8889 RVA: 0x0000E280 File Offset: 0x0000C480
	[Token(Token = "0x17000495")]
	public static bool IsInDoor
	{
		[Token(Token = "0x6001D41")]
		[Address(RVA = "0x1F5EFF0", Offset = "0x1F5F0F1", VA = "0x1F5EFF0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005B2 RID: 1458
	// (get) Token: 0x060022BA RID: 8890 RVA: 0x0000E298 File Offset: 0x0000C498
	[Token(Token = "0x17000496")]
	public static bool IsInTown
	{
		[Token(Token = "0x6001D42")]
		[Address(RVA = "0x1F5F060", Offset = "0x1F5F161", VA = "0x1F5F060")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005B3 RID: 1459
	// (get) Token: 0x060022BB RID: 8891 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
	[Token(Token = "0x17000497")]
	public static bool IsInTownArea
	{
		[Token(Token = "0x6001D43")]
		[Address(RVA = "0x1F5F1D0", Offset = "0x1F5F2D1", VA = "0x1F5F1D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005B4 RID: 1460
	// (get) Token: 0x060022BC RID: 8892 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
	[Token(Token = "0x17000498")]
	public static bool IsDungeon
	{
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x1F5F2E0", Offset = "0x1F5F3E1", VA = "0x1F5F2E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005B5 RID: 1461
	// (get) Token: 0x060022BD RID: 8893 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
	[Token(Token = "0x17000499")]
	public static bool IsField
	{
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x1F5F350", Offset = "0x1F5F451", VA = "0x1F5F350")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005B6 RID: 1462
	// (get) Token: 0x060022BE RID: 8894 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
	// (set) Token: 0x060022BF RID: 8895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700049A")]
	public bool IsUseCpuBoost
	{
		[Token(Token = "0x6001D46")]
		[Address(RVA = "0x1F5F440", Offset = "0x1F5F541", VA = "0x1F5F440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0DB0", Offset = "0x1A0EB1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D47")]
		[Address(RVA = "0x1F5F450", Offset = "0x1F5F551", VA = "0x1F5F450")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0DC0", Offset = "0x1A0EC1")]
		set
		{
		}
	}

	// Token: 0x170005B7 RID: 1463
	// (get) Token: 0x060022C0 RID: 8896 RVA: 0x0000E310 File Offset: 0x0000C510
	[Token(Token = "0x1700049B")]
	public static bool IsCreatedNaviMeshSurfaces
	{
		[Token(Token = "0x6001D48")]
		[Address(RVA = "0x1F5F460", Offset = "0x1F5F561", VA = "0x1F5F460")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005B8 RID: 1464
	// (get) Token: 0x060022C1 RID: 8897 RVA: 0x0000E328 File Offset: 0x0000C528
	[Token(Token = "0x1700049C")]
	public static bool IsStartFestivalResultScript
	{
		[Token(Token = "0x6001D49")]
		[Address(RVA = "0x1F5F520", Offset = "0x1F5F621", VA = "0x1F5F520")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060022C2 RID: 8898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0x1F5F5C0", Offset = "0x1F5F6C1", VA = "0x1F5F5C0")]
	public static void InitializeForNewGame()
	{
	}

	// Token: 0x060022C3 RID: 8899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0x1F5F5D0", Offset = "0x1F5F6D1", VA = "0x1F5F5D0")]
	public static void UnloadAllScene()
	{
	}

	// Token: 0x060022C4 RID: 8900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0x1F5F6A0", Offset = "0x1F5F7A1", VA = "0x1F5F6A0")]
	public Dictionary<string, TeleportPortalData> GetTeleportPositionDataTable(string sceneName)
	{
		return null;
	}

	// Token: 0x060022C5 RID: 8901 RVA: 0x0000E340 File Offset: 0x0000C540
	[Token(Token = "0x6001D4D")]
	[Address(RVA = "0x1F5F820", Offset = "0x1F5F921", VA = "0x1F5F820")]
	public FieldSceneData.Data GetSceneData(string sceneName)
	{
		return default(FieldSceneData.Data);
	}

	// Token: 0x060022C6 RID: 8902 RVA: 0x0000E358 File Offset: 0x0000C558
	[Token(Token = "0x6001D4E")]
	[Address(RVA = "0x1F5F940", Offset = "0x1F5FA41", VA = "0x1F5F940")]
	public FieldSceneData.Data GetSceneData(int sceneId)
	{
		return default(FieldSceneData.Data);
	}

	// Token: 0x060022C7 RID: 8903 RVA: 0x0000E370 File Offset: 0x0000C570
	[Token(Token = "0x6001D4F")]
	[Address(RVA = "0x1F5F9B0", Offset = "0x1F5FAB1", VA = "0x1F5F9B0")]
	public static ItemLevelWeightID GetItemLevelWeightID()
	{
		return ItemLevelWeightID.None;
	}

	// Token: 0x060022C8 RID: 8904 RVA: 0x0000E388 File Offset: 0x0000C588
	[Token(Token = "0x6001D50")]
	[Address(RVA = "0x1F5FA20", Offset = "0x1F5FB21", VA = "0x1F5FA20")]
	public static int GetEquipItemLevelCap()
	{
		return 0;
	}

	// Token: 0x060022C9 RID: 8905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D51")]
	[Address(RVA = "0x1F5FA90", Offset = "0x1F5FB91", VA = "0x1F5FA90")]
	public TeleportPortalData GetTeleportPositionData(string teleportPositionName, string sceneName)
	{
		return null;
	}

	// Token: 0x060022CA RID: 8906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D52")]
	[Address(RVA = "0x1F5FB50", Offset = "0x1F5FC51", VA = "0x1F5FB50")]
	public FieldTeleportDataTable GetFieldTeleportData(FieldTeleportID id)
	{
		return null;
	}

	// Token: 0x060022CB RID: 8907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D53")]
	[Address(RVA = "0x1F5FBE0", Offset = "0x1F5FCE1", VA = "0x1F5FBE0")]
	private void SetEnableStreamer(string enableSceneName, string disableSceneName, ref List<Streamer> list, bool isKeep)
	{
	}

	// Token: 0x060022CC RID: 8908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D54")]
	[Address(RVA = "0x1F5FE70", Offset = "0x1F5FF71", VA = "0x1F5FE70")]
	private void SetPlayerTransform(PlayerTeleport playerTeleport, Transform targetTransform)
	{
	}

	// Token: 0x060022CD RID: 8909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D55")]
	[Address(RVA = "0x1F5FFB0", Offset = "0x1F600B1", VA = "0x1F5FFB0")]
	private void SetWorldStreamerParam(string nowSceneName, string nextSceneName, string teleportName, bool isKeep)
	{
	}

	// Token: 0x060022CE RID: 8910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D56")]
	[Address(RVA = "0x1F60AA0", Offset = "0x1F60BA1", VA = "0x1F60AA0")]
	private void WorldStreamerMove()
	{
	}

	// Token: 0x060022CF RID: 8911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D57")]
	[Address(RVA = "0x1F60C80", Offset = "0x1F60D81", VA = "0x1F60C80")]
	private void UpdatePlaceId()
	{
	}

	// Token: 0x060022D0 RID: 8912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D58")]
	[Address(RVA = "0x1F60FD0", Offset = "0x1F610D1", VA = "0x1F60FD0")]
	private void BeginPlayerMover()
	{
	}

	// Token: 0x060022D1 RID: 8913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D59")]
	[Address(RVA = "0x1F60BF0", Offset = "0x1F60CF1", VA = "0x1F60BF0")]
	private void OnDonePlayerMover()
	{
	}

	// Token: 0x060022D2 RID: 8914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D5A")]
	[Address(RVA = "0x1F612C0", Offset = "0x1F613C1", VA = "0x1F612C0")]
	private void OnDonePlayerMoverInvoke()
	{
	}

	// Token: 0x060022D3 RID: 8915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D5B")]
	[Address(RVA = "0x1F61240", Offset = "0x1F61341", VA = "0x1F61240")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0DD0", Offset = "0x1A0ED1")]
	public IEnumerator WaitLoadPlayerMover()
	{
		return null;
	}

	// Token: 0x060022D4 RID: 8916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D5C")]
	[Address(RVA = "0x1F61750", Offset = "0x1F61851", VA = "0x1F61750")]
	private EventStartPoint GetEventStartPointPlayerLandOn()
	{
		return null;
	}

	// Token: 0x060022D5 RID: 8917 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
	[Token(Token = "0x6001D5D")]
	[Address(RVA = "0x1F60310", Offset = "0x1F60411", VA = "0x1F60310")]
	private bool SetPlayerPosition(PlayerTeleport playerTeleport, string teleportName, string sceneName)
	{
		return default(bool);
	}

	// Token: 0x060022D6 RID: 8918 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
	[Token(Token = "0x6001D5E")]
	[Address(RVA = "0x1F61C30", Offset = "0x1F61D31", VA = "0x1F61C30")]
	private bool SceneNameIfMatches(string checkSceneName, string targetSceneName)
	{
		return default(bool);
	}

	// Token: 0x060022D7 RID: 8919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D5F")]
	[Address(RVA = "0x1F61C50", Offset = "0x1F61D51", VA = "0x1F61C50")]
	public void SceneUnloadAsync(string loadSceneName, bool isPopScene, Action onLoadCompleteAction)
	{
	}

	// Token: 0x060022D8 RID: 8920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D60")]
	[Address(RVA = "0x1F61C90", Offset = "0x1F61D91", VA = "0x1F61C90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0E40", Offset = "0x1A0F41")]
	public IEnumerator SceneUnloadAsyncCoroutine(string loadSceneName, bool isPopScene, Action onLoadCompleteAction)
	{
		return null;
	}

	// Token: 0x060022D9 RID: 8921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D61")]
	[Address(RVA = "0x1F61D80", Offset = "0x1F61E81", VA = "0x1F61D80")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0EB0", Offset = "0x1A0FB1")]
	public IEnumerator ScenePopWaitAsync()
	{
		return null;
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D62")]
	[Address(RVA = "0x1F61E30", Offset = "0x1F61F31", VA = "0x1F61E30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0F20", Offset = "0x1A1021")]
	public IEnumerator LoadObjectWaitAsync()
	{
		return null;
	}

	// Token: 0x060022DB RID: 8923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D63")]
	[Address(RVA = "0x1F61EC0", Offset = "0x1F61FC1", VA = "0x1F61EC0")]
	private void OnLoadComplete()
	{
	}

	// Token: 0x060022DC RID: 8924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D64")]
	[Address(RVA = "0x1F61F50", Offset = "0x1F62051", VA = "0x1F61F50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0F90", Offset = "0x1A1091")]
	public IEnumerator OnLoadCompleteCoroutine()
	{
		return null;
	}

	// Token: 0x060022DD RID: 8925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D65")]
	[Address(RVA = "0x1F62000", Offset = "0x1F62101", VA = "0x1F62000")]
	private void LoadCompleteCommon(bool isSceneLoad)
	{
	}

	// Token: 0x060022DE RID: 8926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D66")]
	[Address(RVA = "0x1F62390", Offset = "0x1F62491", VA = "0x1F62390")]
	public void FieldSceneSetting(string NextSceneName)
	{
	}

	// Token: 0x060022DF RID: 8927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D67")]
	[Address(RVA = "0x1F62760", Offset = "0x1F62861", VA = "0x1F62760")]
	private void NpcLoad(FieldPlaceId id, bool checkArea)
	{
	}

	// Token: 0x060022E0 RID: 8928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D68")]
	[Address(RVA = "0x1F62950", Offset = "0x1F62A51", VA = "0x1F62950")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1000", Offset = "0x1A1101")]
	private IEnumerator SceneChangeLoad()
	{
		return null;
	}

	// Token: 0x060022E1 RID: 8929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D69")]
	[Address(RVA = "0x1F622C0", Offset = "0x1F623C1", VA = "0x1F622C0")]
	private void SetSceneImageEffectsParam(FieldSceneData.Data loadSceneParam)
	{
	}

	// Token: 0x060022E2 RID: 8930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D6A")]
	[Address(RVA = "0x1F62A00", Offset = "0x1F62B01", VA = "0x1F62A00")]
	private void PushSceneAdjust()
	{
	}

	// Token: 0x060022E3 RID: 8931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D6B")]
	[Address(RVA = "0x1F62C00", Offset = "0x1F62D01", VA = "0x1F62C00")]
	public void ScenePush(string loadSceneName, Action onLoadCompleteAction)
	{
	}

	// Token: 0x060022E4 RID: 8932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D6C")]
	[Address(RVA = "0x1F62EF0", Offset = "0x1F62FF1", VA = "0x1F62EF0")]
	private void SceneAddAsync(string loadSceneName, Action onLoadCompleteAction)
	{
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D6D")]
	[Address(RVA = "0x1F63550", Offset = "0x1F63651", VA = "0x1F63550")]
	public Streamer[] FindStreamers()
	{
		return null;
	}

	// Token: 0x060022E6 RID: 8934 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
	[Token(Token = "0x6001D6E")]
	[Address(RVA = "0x1F63750", Offset = "0x1F63851", VA = "0x1F63750")]
	public bool IsUseWorldStearmer()
	{
		return default(bool);
	}

	// Token: 0x060022E7 RID: 8935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D6F")]
	[Address(RVA = "0x1F63790", Offset = "0x1F63891", VA = "0x1F63790")]
	public void TeleportPosition(Vector3 position, Quaternion rotation)
	{
	}

	// Token: 0x060022E8 RID: 8936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D70")]
	[Address(RVA = "0x1F63CE0", Offset = "0x1F63DE1", VA = "0x1F63CE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1070", Offset = "0x1A1171")]
	public IEnumerator TeleportPositionCoroutine()
	{
		return null;
	}

	// Token: 0x060022E9 RID: 8937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D71")]
	[Address(RVA = "0x1F63D90", Offset = "0x1F63E91", VA = "0x1F63D90")]
	public void TeleportPlayerPosition()
	{
	}

	// Token: 0x060022EA RID: 8938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D72")]
	[Address(RVA = "0x1F63E70", Offset = "0x1F63F71", VA = "0x1F63E70")]
	public void TeleportScene(int sceneId, Vector3 position, Vector3 rotation, [Optional] Action onLoadCompleteAction)
	{
	}

	// Token: 0x060022EB RID: 8939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D73")]
	[Address(RVA = "0x1F646C0", Offset = "0x1F647C1", VA = "0x1F646C0")]
	public void TeleportScene(FieldTeleportID fieldTeleportID, [Optional] Action onLoadCompleteAction)
	{
	}

	// Token: 0x060022EC RID: 8940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D74")]
	[Address(RVA = "0x1F64920", Offset = "0x1F64A21", VA = "0x1F64920")]
	public void TeleportScene(string sceneName, [Optional] Action onLoadCompleteAction)
	{
	}

	// Token: 0x060022ED RID: 8941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D75")]
	[Address(RVA = "0x1F649A0", Offset = "0x1F64AA1", VA = "0x1F649A0")]
	public void TeleportScene(string sceneName, Vector3 position, Vector3 rotation, [Optional] Action onLoadCompleteAction)
	{
	}

	// Token: 0x060022EE RID: 8942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D76")]
	[Address(RVA = "0x1F64A80", Offset = "0x1F64B81", VA = "0x1F64A80")]
	public void TeleportScene(int sceneId, string teleportPortal, [Optional] Action onLoadCompleteAction)
	{
	}

	// Token: 0x060022EF RID: 8943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D77")]
	[Address(RVA = "0x1F64020", Offset = "0x1F64121", VA = "0x1F64020")]
	public void TeleportScene(string sceneName, string teleportPortal, [Optional] Action onLoadCompleteAction)
	{
	}

	// Token: 0x060022F0 RID: 8944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D78")]
	[Address(RVA = "0x1F62E70", Offset = "0x1F62F71", VA = "0x1F62E70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A10E0", Offset = "0x1A11E1")]
	public IEnumerator LoadSceneBgm()
	{
		return null;
	}

	// Token: 0x060022F1 RID: 8945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D79")]
	[Address(RVA = "0x1F64D20", Offset = "0x1F64E21", VA = "0x1F64D20")]
	public void SetSceneBgm([Optional] string sceneName)
	{
	}

	// Token: 0x060022F2 RID: 8946 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
	[Token(Token = "0x6001D7A")]
	[Address(RVA = "0x1F65160", Offset = "0x1F65261", VA = "0x1F65160")]
	public BGMID GetFieldBGMId(FieldPlaceId fieldPlaceId = FieldPlaceId.None)
	{
		return BGMID.BGM_EMPTY;
	}

	// Token: 0x060022F3 RID: 8947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D7B")]
	[Address(RVA = "0x1F64FB0", Offset = "0x1F650B1", VA = "0x1F64FB0")]
	public void SetFieldBgm(FieldPlaceId fieldPlaceId = FieldPlaceId.None)
	{
	}

	// Token: 0x060022F4 RID: 8948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D7C")]
	[Address(RVA = "0x1F650A0", Offset = "0x1F651A1", VA = "0x1F650A0")]
	public void PlayHomeBGM()
	{
	}

	// Token: 0x060022F5 RID: 8949 RVA: 0x0000E400 File Offset: 0x0000C600
	[Token(Token = "0x6001D7D")]
	[Address(RVA = "0x1F65200", Offset = "0x1F65301", VA = "0x1F65200")]
	public BGMID GetHomeBGMId()
	{
		return BGMID.BGM_EMPTY;
	}

	// Token: 0x060022F6 RID: 8950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D7E")]
	[Address(RVA = "0x1F65270", Offset = "0x1F65371", VA = "0x1F65270", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060022F7 RID: 8951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D7F")]
	[Address(RVA = "0x1F65470", Offset = "0x1F65571", VA = "0x1F65470")]
	private void Start()
	{
	}

	// Token: 0x060022F8 RID: 8952 RVA: 0x0000E418 File Offset: 0x0000C618
	[Token(Token = "0x6001D80")]
	[Address(RVA = "0x1F65700", Offset = "0x1F65801", VA = "0x1F65700")]
	public bool IsLoadCompletedStreamer()
	{
		return default(bool);
	}

	// Token: 0x060022F9 RID: 8953 RVA: 0x0000E430 File Offset: 0x0000C630
	[Token(Token = "0x6001D81")]
	[Address(RVA = "0x1F65860", Offset = "0x1F65961", VA = "0x1F65860")]
	public bool IsTransitionCompleted()
	{
		return default(bool);
	}

	// Token: 0x060022FA RID: 8954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D82")]
	[Address(RVA = "0x1F658A0", Offset = "0x1F659A1", VA = "0x1F658A0")]
	public void SetWorldStreamerTarget(Transform transform)
	{
	}

	// Token: 0x060022FB RID: 8955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D83")]
	[Address(RVA = "0x1F65A50", Offset = "0x1F65B51", VA = "0x1F65A50")]
	public void SetWorldStreamerTargetPosition(float x, float y, float z, int intensity = -1)
	{
	}

	// Token: 0x060022FC RID: 8956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D84")]
	[Address(RVA = "0x1F65C10", Offset = "0x1F65D11", VA = "0x1F65C10")]
	public void RemoveWorldStreamerTargetPosition()
	{
	}

	// Token: 0x060022FD RID: 8957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D85")]
	[Address(RVA = "0x1F65C20", Offset = "0x1F65D21", VA = "0x1F65C20")]
	public void SetWorldStreamerTargetPositionIntensity(int value)
	{
	}

	// Token: 0x060022FE RID: 8958 RVA: 0x0000E448 File Offset: 0x0000C648
	[Token(Token = "0x6001D86")]
	[Address(RVA = "0x1F65C30", Offset = "0x1F65D31", VA = "0x1F65C30")]
	public int GetWorldStreamerTargetPositionIntensity()
	{
		return 0;
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D87")]
	[Address(RVA = "0x1F65C40", Offset = "0x1F65D41", VA = "0x1F65C40")]
	public void ResetWorldStreamerTargetPositionIntensity()
	{
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D88")]
	[Address(RVA = "0x1F65C50", Offset = "0x1F65D51", VA = "0x1F65C50")]
	public void CheckPositionStreamers()
	{
	}

	// Token: 0x06002301 RID: 8961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D89")]
	[Address(RVA = "0x1F65CD0", Offset = "0x1F65DD1", VA = "0x1F65CD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A1150", Offset = "0x1A1251")]
	public IEnumerator UnloadStearmerSceneAsync([Optional] Action completeAction)
	{
		return null;
	}

	// Token: 0x06002302 RID: 8962 RVA: 0x0000E460 File Offset: 0x0000C660
	[Token(Token = "0x6001D8A")]
	[Address(RVA = "0x1F65D80", Offset = "0x1F65E81", VA = "0x1F65D80")]
	public bool CheckUseSceneWeather(string sceneName)
	{
		return default(bool);
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D8B")]
	[Address(RVA = "0x1F60150", Offset = "0x1F60251", VA = "0x1F60150")]
	public Transform GetStreamerTargetTransform()
	{
		return null;
	}

	// Token: 0x06002304 RID: 8964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D8C")]
	[Address(RVA = "0x1F65DB0", Offset = "0x1F65EB1", VA = "0x1F65DB0")]
	public void AddDragonRope(TeleportDragonRope dragonRope)
	{
	}

	// Token: 0x06002305 RID: 8965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D8D")]
	[Address(RVA = "0x1F65E20", Offset = "0x1F65F21", VA = "0x1F65E20")]
	public void RemoveDragonRope(TeleportDragonRope dragonRope)
	{
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D8E")]
	[Address(RVA = "0x1F65E90", Offset = "0x1F65F91", VA = "0x1F65E90")]
	private void OnSceneChangeSetTeleportPoint()
	{
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D8F")]
	[Address(RVA = "0x1F660F0", Offset = "0x1F661F1", VA = "0x1F660F0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06002308 RID: 8968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D90")]
	[Address(RVA = "0x1F66180", Offset = "0x1F66281", VA = "0x1F66180")]
	public void SetRestrictionArea(FieldRestrictionType restrictionType)
	{
	}

	// Token: 0x06002309 RID: 8969 RVA: 0x0000E478 File Offset: 0x0000C678
	[Token(Token = "0x6001D91")]
	[Address(RVA = "0x1F66190", Offset = "0x1F66291", VA = "0x1F66190")]
	public FieldRestrictionType GetRestrictionArea()
	{
		return (FieldRestrictionType)0;
	}

	// Token: 0x0600230A RID: 8970 RVA: 0x0000E490 File Offset: 0x0000C690
	[Token(Token = "0x6001D92")]
	[Address(RVA = "0x1F661A0", Offset = "0x1F662A1", VA = "0x1F661A0")]
	public bool IsSaveRestriction()
	{
		return default(bool);
	}

	// Token: 0x0600230B RID: 8971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D93")]
	[Address(RVA = "0x1F661C0", Offset = "0x1F662C1", VA = "0x1F661C0")]
	public void ClearFieldMapAreaPlaceId()
	{
	}

	// Token: 0x0600230C RID: 8972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D94")]
	[Address(RVA = "0x1F60F70", Offset = "0x1F61071", VA = "0x1F60F70")]
	public void SetFieldMapAreaPlaceId(FieldPlaceId placeId)
	{
	}

	// Token: 0x0600230D RID: 8973 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
	[Token(Token = "0x6001D95")]
	[Address(RVA = "0x1F64BF0", Offset = "0x1F64CF1", VA = "0x1F64BF0")]
	public FieldPlaceId UpdateFieldPlaceId(bool checkArea)
	{
		return FieldPlaceId.None;
	}

	// Token: 0x0600230E RID: 8974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D96")]
	[Address(RVA = "0x1F661D0", Offset = "0x1F662D1", VA = "0x1F661D0")]
	public string GetNamingPlaceName()
	{
		return null;
	}

	// Token: 0x0600230F RID: 8975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D97")]
	[Address(RVA = "0x1F662F0", Offset = "0x1F663F1", VA = "0x1F662F0")]
	public string GetFieldPlaceName()
	{
		return null;
	}

	// Token: 0x06002310 RID: 8976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D98")]
	[Address(RVA = "0x1F66390", Offset = "0x1F66491", VA = "0x1F66390")]
	public static string GetFieldPlaceName(FieldPlaceId fieldPlaceId)
	{
		return null;
	}

	// Token: 0x06002311 RID: 8977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D99")]
	[Address(RVA = "0x1F66570", Offset = "0x1F66671", VA = "0x1F66570")]
	public void AddMapFieldCollider(MapFieldCollider addCollider)
	{
	}

	// Token: 0x06002312 RID: 8978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D9A")]
	[Address(RVA = "0x1F665E0", Offset = "0x1F666E1", VA = "0x1F665E0")]
	public void RemoveMapFieldCollider(MapFieldCollider removeCollider)
	{
	}

	// Token: 0x06002313 RID: 8979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D9B")]
	[Address(RVA = "0x1F66650", Offset = "0x1F66751", VA = "0x1F66650")]
	public TeleportAreaManager()
	{
	}

	// Token: 0x06002315 RID: 8981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D9D")]
	[Address(RVA = "0x1F66920", Offset = "0x1F66A21", VA = "0x1F66920")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A11C0", Offset = "0x1A12C1")]
	private void <TeleportScene>b__167_0()
	{
	}

	// Token: 0x04006AB6 RID: 27318
	[Token(Token = "0x4006439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _SceneName;

	// Token: 0x04006AB7 RID: 27319
	[Token(Token = "0x400643A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166780", Offset = "0x166881")]
	private FieldPlaceId <FieldPlaceId>k__BackingField;

	// Token: 0x04006AB8 RID: 27320
	[Token(Token = "0x400643B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166790", Offset = "0x166891")]
	private FieldPlaceId <FieldMapAreaPlaceId>k__BackingField;

	// Token: 0x04006AB9 RID: 27321
	[Token(Token = "0x400643C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1667A0", Offset = "0x1668A1")]
	private FieldSceneId <FieldSceneId>k__BackingField;

	// Token: 0x04006ABA RID: 27322
	[Token(Token = "0x400643D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1667B0", Offset = "0x1668B1")]
	private Stack<FieldSceneId> <FieldSceneIdStack>k__BackingField;

	// Token: 0x04006ABB RID: 27323
	[Token(Token = "0x400643E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string _PrevSceneName;

	// Token: 0x04006ABC RID: 27324
	[Token(Token = "0x400643F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Stack<string> _SceneNameStack;

	// Token: 0x04006ABD RID: 27325
	[Token(Token = "0x4006440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private TeleportPositionDataObject[] _TeleportPositionDataObjects;

	// Token: 0x04006ABE RID: 27326
	[Token(Token = "0x4006441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Dictionary<string, TeleportPositionDataObject> TeleportPositionDataTable;

	// Token: 0x04006ABF RID: 27327
	[Token(Token = "0x4006442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private FieldTeleportDataTableArray FieldTeleportDataTableArray;

	// Token: 0x04006AC0 RID: 27328
	[Token(Token = "0x4006443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private FieldSceneData _SceneDataTable;

	// Token: 0x04006AC1 RID: 27329
	[Token(Token = "0x4006444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private PlayerTeleport _PlayerTeleport;

	// Token: 0x04006AC2 RID: 27330
	[Token(Token = "0x4006445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private PlayerMover _PlayerMover;

	// Token: 0x04006AC3 RID: 27331
	[Token(Token = "0x4006446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Streamer[] _Streamers;

	// Token: 0x04006AC4 RID: 27332
	[Token(Token = "0x4006447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform StreamerTargetTransform;

	// Token: 0x04006AC5 RID: 27333
	[Token(Token = "0x4006448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string DefaultFieldSceneName;

	// Token: 0x04006AC6 RID: 27334
	[Token(Token = "0x4006449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float _DetectGroundRayDistance;

	// Token: 0x04006AC7 RID: 27335
	[Token(Token = "0x400644A")]
	protected const float kBackstepDistance = 0.05f;

	// Token: 0x04006AC8 RID: 27336
	[Token(Token = "0x400644B")]
	private const string MapNameBeginIdString = "MAPNAME_SCENE_FieldMap";

	// Token: 0x04006AC9 RID: 27337
	[Token(Token = "0x400644C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int MapNameBeginId;

	// Token: 0x04006ACA RID: 27338
	[Token(Token = "0x400644D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166830", Offset = "0x166931")]
	private LayerMask <GroundLayer>k__BackingField;

	// Token: 0x04006ACB RID: 27339
	[Token(Token = "0x400644E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private HashSet<TeleportDragonRope> TeleportDragonRopesHashSet;

	// Token: 0x04006ACC RID: 27340
	[Token(Token = "0x400644F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public UnityEvent OnBeginTeleport;

	// Token: 0x04006ACD RID: 27341
	[Token(Token = "0x4006450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public UnityEvent OnSceneLoadComplete;

	// Token: 0x04006ACE RID: 27342
	[Token(Token = "0x4006451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public UnityEvent OnSceneChangeComplete;

	// Token: 0x04006ACF RID: 27343
	[Token(Token = "0x4006452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public UnityEvent OnEndTeleport;

	// Token: 0x04006AD0 RID: 27344
	[Token(Token = "0x4006453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public UnityEvent OnResetPlaceID;

	// Token: 0x04006AD1 RID: 27345
	[Token(Token = "0x4006454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public HashSet<Func<IEnumerator>> OnSceneChangeLoadFuncs;

	// Token: 0x04006AD2 RID: 27346
	[Token(Token = "0x4006455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Action _OnLoadCompleteAction;

	// Token: 0x04006AD3 RID: 27347
	[Token(Token = "0x4006456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public bool IsTeleportEnable;

	// Token: 0x04006AD4 RID: 27348
	[Token(Token = "0x4006457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166840", Offset = "0x166941")]
	private bool <IsTeleporting>k__BackingField;

	// Token: 0x04006AD5 RID: 27349
	[Token(Token = "0x4006458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166850", Offset = "0x166951")]
	private bool <IsShortPlayLock>k__BackingField;

	// Token: 0x04006AD6 RID: 27350
	[Token(Token = "0x4006459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166860", Offset = "0x166961")]
	private bool <IsTeleportEndFade>k__BackingField;

	// Token: 0x04006AD7 RID: 27351
	[Token(Token = "0x400645A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166870", Offset = "0x166971")]
	private bool <IsCameraCulling>k__BackingField;

	// Token: 0x04006AD8 RID: 27352
	[Token(Token = "0x400645B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static FieldSceneData.Data loadSceneParam;

	// Token: 0x04006AD9 RID: 27353
	[Token(Token = "0x400645C")]
	private const int PhysicCollidersCount = 16;

	// Token: 0x04006ADA RID: 27354
	[Token(Token = "0x400645D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Collider[] PhysicColliders;

	// Token: 0x04006ADB RID: 27355
	[Token(Token = "0x400645E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string loadSceneName;

	// Token: 0x04006ADC RID: 27356
	[Token(Token = "0x400645F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private string teleportName;

	// Token: 0x04006ADD RID: 27357
	[Token(Token = "0x4006460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Vector3 TargetPosition;

	// Token: 0x04006ADE RID: 27358
	[Token(Token = "0x4006461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Quaternion TargetQuaternion;

	// Token: 0x04006ADF RID: 27359
	[Token(Token = "0x4006462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private bool PrevPause;

	// Token: 0x04006AE0 RID: 27360
	[Token(Token = "0x4006463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x115")]
	private bool PrevFade;

	// Token: 0x04006AE1 RID: 27361
	[Token(Token = "0x4006464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private RigidbodyInterpolation PrevInterpolation;

	// Token: 0x04006AE2 RID: 27362
	[Token(Token = "0x4006465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166880", Offset = "0x166981")]
	private bool <IsUseCpuBoost>k__BackingField;

	// Token: 0x04006AE3 RID: 27363
	[Token(Token = "0x4006466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
	private bool IsCreatingNaviMeshSurfaces;

	// Token: 0x04006AE4 RID: 27364
	[Token(Token = "0x4006467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11E")]
	public bool isCreatedNaviMeshSurfaces;

	// Token: 0x04006AE5 RID: 27365
	[Token(Token = "0x4006468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public FieldRestrictionType prevFieldRestrictionType;

	// Token: 0x04006AE6 RID: 27366
	[Token(Token = "0x4006469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public FieldRestrictionType nowFieldRestrictionType;

	// Token: 0x04006AE7 RID: 27367
	[Token(Token = "0x400646A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private HashSet<MapFieldCollider> MapFieldColliders;

	// Token: 0x04006AE8 RID: 27368
	[Token(Token = "0x400646B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private GameObject worldStreamerTargetObject;

	// Token: 0x04006AE9 RID: 27369
	[Token(Token = "0x400646C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool isSetWorldStreamerTargetObject;

	// Token: 0x04006AEA RID: 27370
	[Token(Token = "0x400646D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private int worldStreamerTargetIntensity;

	// Token: 0x02000590 RID: 1424
	[Token(Token = "0x200111A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157F60", Offset = "0x158061")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002317 RID: 8983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007064")]
		[Address(RVA = "0x1F66A00", Offset = "0x1F66B01", VA = "0x1F66A00")]
		public <>c()
		{
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007065")]
		[Address(RVA = "0x1F66A10", Offset = "0x1F66B11", VA = "0x1F66A10")]
		internal void <OnDonePlayerMoverInvoke>b__138_0()
		{
		}

		// Token: 0x04006AEB RID: 27371
		[Token(Token = "0x40192F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TeleportAreaManager.<>c <>9;

		// Token: 0x04006AEC RID: 27372
		[Token(Token = "0x40192F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static TweenCallback <>9__138_0;
	}

	// Token: 0x02000591 RID: 1425
	[Token(Token = "0x200111B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157F70", Offset = "0x158071")]
	private sealed class <WaitLoadPlayerMover>d__139 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002319 RID: 8985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007066")]
		[Address(RVA = "0x1F61BF0", Offset = "0x1F61CF1", VA = "0x1F61BF0")]
		[DebuggerHidden]
		public <WaitLoadPlayerMover>d__139(int <>1__state)
		{
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007067")]
		[Address(RVA = "0x1F69730", Offset = "0x1F69831", VA = "0x1F69730", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		[Token(Token = "0x6007068")]
		[Address(RVA = "0x1F69740", Offset = "0x1F69841", VA = "0x1F69740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD9")]
		private object Current
		{
			[Token(Token = "0x6007069")]
			[Address(RVA = "0x1F69950", Offset = "0x1F69A51", VA = "0x1F69950", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600706A")]
		[Address(RVA = "0x1F69960", Offset = "0x1F69A61", VA = "0x1F69960", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDA")]
		private object Current
		{
			[Token(Token = "0x600706B")]
			[Address(RVA = "0x1F699C0", Offset = "0x1F69AC1", VA = "0x1F699C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006AED RID: 27373
		[Token(Token = "0x40192F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006AEE RID: 27374
		[Token(Token = "0x40192F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006AEF RID: 27375
		[Token(Token = "0x40192F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportAreaManager <>4__this;
	}

	// Token: 0x02000592 RID: 1426
	[Token(Token = "0x200111C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157F80", Offset = "0x158081")]
	private sealed class <>c__DisplayClass141_0
	{
		// Token: 0x0600231F RID: 8991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600706C")]
		[Address(RVA = "0x1F61C20", Offset = "0x1F61D21", VA = "0x1F61C20")]
		public <>c__DisplayClass141_0()
		{
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		[Token(Token = "0x600706D")]
		[Address(RVA = "0x1F66B30", Offset = "0x1F66C31", VA = "0x1F66B30")]
		internal bool <SetPlayerPosition>b__0(PlayerTeleport p)
		{
			return default(bool);
		}

		// Token: 0x04006AF0 RID: 27376
		[Token(Token = "0x40192F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string teleportName;

		// Token: 0x04006AF1 RID: 27377
		[Token(Token = "0x40192F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TeleportAreaManager <>4__this;

		// Token: 0x04006AF2 RID: 27378
		[Token(Token = "0x40192F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string sceneName;
	}

	// Token: 0x02000593 RID: 1427
	[Token(Token = "0x200111D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157F90", Offset = "0x158091")]
	private sealed class <SceneUnloadAsyncCoroutine>d__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002321 RID: 8993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600706E")]
		[Address(RVA = "0x1F61D50", Offset = "0x1F61E51", VA = "0x1F61D50")]
		[DebuggerHidden]
		public <SceneUnloadAsyncCoroutine>d__144(int <>1__state)
		{
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600706F")]
		[Address(RVA = "0x1F67D30", Offset = "0x1F67E31", VA = "0x1F67D30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		[Token(Token = "0x6007070")]
		[Address(RVA = "0x1F67E00", Offset = "0x1F67F01", VA = "0x1F67E00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007071")]
		[Address(RVA = "0x1F67DA0", Offset = "0x1F67EA1", VA = "0x1F67DA0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDB")]
		private object Current
		{
			[Token(Token = "0x6007072")]
			[Address(RVA = "0x1F68CC0", Offset = "0x1F68DC1", VA = "0x1F68CC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007073")]
		[Address(RVA = "0x1F68CD0", Offset = "0x1F68DD1", VA = "0x1F68CD0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDC")]
		private object Current
		{
			[Token(Token = "0x6007074")]
			[Address(RVA = "0x1F68D30", Offset = "0x1F68E31", VA = "0x1F68D30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006AF3 RID: 27379
		[Token(Token = "0x40192F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006AF4 RID: 27380
		[Token(Token = "0x40192F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006AF5 RID: 27381
		[Token(Token = "0x40192FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportAreaManager <>4__this;

		// Token: 0x04006AF6 RID: 27382
		[Token(Token = "0x40192FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isPopScene;

		// Token: 0x04006AF7 RID: 27383
		[Token(Token = "0x40192FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string loadSceneName;

		// Token: 0x04006AF8 RID: 27384
		[Token(Token = "0x40192FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onLoadCompleteAction;

		// Token: 0x04006AF9 RID: 27385
		[Token(Token = "0x40192FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <sceneName>5__2;

		// Token: 0x04006AFA RID: 27386
		[Token(Token = "0x40192FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<RF5Streamer>.Enumerator <>7__wrap2;

		// Token: 0x04006AFB RID: 27387
		[Token(Token = "0x4019300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RF5Streamer <streamer>5__4;
	}

	// Token: 0x02000594 RID: 1428
	[Token(Token = "0x200111E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157FA0", Offset = "0x1580A1")]
	private sealed class <ScenePopWaitAsync>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002328 RID: 9000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007075")]
		[Address(RVA = "0x1F61E00", Offset = "0x1F61F01", VA = "0x1F61E00")]
		[DebuggerHidden]
		public <ScenePopWaitAsync>d__145(int <>1__state)
		{
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007076")]
		[Address(RVA = "0x1F67B90", Offset = "0x1F67C91", VA = "0x1F67B90", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x0000E508 File Offset: 0x0000C708
		[Token(Token = "0x6007077")]
		[Address(RVA = "0x1F67BA0", Offset = "0x1F67CA1", VA = "0x1F67BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDD")]
		private object Current
		{
			[Token(Token = "0x6007078")]
			[Address(RVA = "0x1F67CB0", Offset = "0x1F67DB1", VA = "0x1F67CB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007079")]
		[Address(RVA = "0x1F67CC0", Offset = "0x1F67DC1", VA = "0x1F67CC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDE")]
		private object Current
		{
			[Token(Token = "0x600707A")]
			[Address(RVA = "0x1F67D20", Offset = "0x1F67E21", VA = "0x1F67D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006AFC RID: 27388
		[Token(Token = "0x4019301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006AFD RID: 27389
		[Token(Token = "0x4019302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006AFE RID: 27390
		[Token(Token = "0x4019303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportAreaManager <>4__this;
	}

	// Token: 0x02000595 RID: 1429
	[Token(Token = "0x200111F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157FB0", Offset = "0x1580B1")]
	private sealed class <LoadObjectWaitAsync>d__146 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600232E RID: 9006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600707B")]
		[Address(RVA = "0x1F61E90", Offset = "0x1F61F91", VA = "0x1F61E90")]
		[DebuggerHidden]
		public <LoadObjectWaitAsync>d__146(int <>1__state)
		{
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600707C")]
		[Address(RVA = "0x1F66FE0", Offset = "0x1F670E1", VA = "0x1F66FE0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0000E520 File Offset: 0x0000C720
		[Token(Token = "0x600707D")]
		[Address(RVA = "0x1F66FF0", Offset = "0x1F670F1", VA = "0x1F66FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDF")]
		private object Current
		{
			[Token(Token = "0x600707E")]
			[Address(RVA = "0x1F67090", Offset = "0x1F67191", VA = "0x1F67090", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600707F")]
		[Address(RVA = "0x1F670A0", Offset = "0x1F671A1", VA = "0x1F670A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE0")]
		private object Current
		{
			[Token(Token = "0x6007080")]
			[Address(RVA = "0x1F67100", Offset = "0x1F67201", VA = "0x1F67100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006AFF RID: 27391
		[Token(Token = "0x4019304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006B00 RID: 27392
		[Token(Token = "0x4019305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}

	// Token: 0x02000596 RID: 1430
	[Token(Token = "0x2001120")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157FC0", Offset = "0x1580C1")]
	private sealed class <OnLoadCompleteCoroutine>d__148 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002334 RID: 9012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007081")]
		[Address(RVA = "0x1F61FD0", Offset = "0x1F620D1", VA = "0x1F61FD0")]
		[DebuggerHidden]
		public <OnLoadCompleteCoroutine>d__148(int <>1__state)
		{
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007082")]
		[Address(RVA = "0x1F675E0", Offset = "0x1F676E1", VA = "0x1F675E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x6007083")]
		[Address(RVA = "0x1F675F0", Offset = "0x1F676F1", VA = "0x1F675F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE1")]
		private object Current
		{
			[Token(Token = "0x6007084")]
			[Address(RVA = "0x1F677B0", Offset = "0x1F678B1", VA = "0x1F677B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007085")]
		[Address(RVA = "0x1F677C0", Offset = "0x1F678C1", VA = "0x1F677C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE2")]
		private object Current
		{
			[Token(Token = "0x6007086")]
			[Address(RVA = "0x1F67820", Offset = "0x1F67921", VA = "0x1F67820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006B01 RID: 27393
		[Token(Token = "0x4019306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006B02 RID: 27394
		[Token(Token = "0x4019307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006B03 RID: 27395
		[Token(Token = "0x4019308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportAreaManager <>4__this;
	}

	// Token: 0x02000597 RID: 1431
	[Token(Token = "0x2001121")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157FD0", Offset = "0x1580D1")]
	private sealed class <>c__DisplayClass150_0
	{
		// Token: 0x0600233A RID: 9018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007087")]
		[Address(RVA = "0x1F62750", Offset = "0x1F62851", VA = "0x1F62750")]
		public <>c__DisplayClass150_0()
		{
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007088")]
		[Address(RVA = "0x1F66BD0", Offset = "0x1F66CD1", VA = "0x1F66BD0")]
		internal void <FieldSceneSetting>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x04006B04 RID: 27396
		[Token(Token = "0x4019309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject naviMeshSurfaces;

		// Token: 0x04006B05 RID: 27397
		[Token(Token = "0x401930A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TeleportAreaManager <>4__this;
	}

	// Token: 0x02000598 RID: 1432
	[Token(Token = "0x2001122")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157FE0", Offset = "0x1580E1")]
	private sealed class <SceneChangeLoad>d__152 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600233C RID: 9020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007089")]
		[Address(RVA = "0x1F629D0", Offset = "0x1F62AD1", VA = "0x1F629D0")]
		[DebuggerHidden]
		public <SceneChangeLoad>d__152(int <>1__state)
		{
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708A")]
		[Address(RVA = "0x1F67830", Offset = "0x1F67931", VA = "0x1F67830", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x0000E550 File Offset: 0x0000C750
		[Token(Token = "0x600708B")]
		[Address(RVA = "0x1F67900", Offset = "0x1F67A01", VA = "0x1F67900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708C")]
		[Address(RVA = "0x1F678A0", Offset = "0x1F679A1", VA = "0x1F678A0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE3")]
		private object Current
		{
			[Token(Token = "0x600708D")]
			[Address(RVA = "0x1F67B10", Offset = "0x1F67C11", VA = "0x1F67B10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600708E")]
		[Address(RVA = "0x1F67B20", Offset = "0x1F67C21", VA = "0x1F67B20", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE4")]
		private object Current
		{
			[Token(Token = "0x600708F")]
			[Address(RVA = "0x1F67B80", Offset = "0x1F67C81", VA = "0x1F67B80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006B06 RID: 27398
		[Token(Token = "0x401930B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006B07 RID: 27399
		[Token(Token = "0x401930C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006B08 RID: 27400
		[Token(Token = "0x401930D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportAreaManager <>4__this;

		// Token: 0x04006B09 RID: 27401
		[Token(Token = "0x401930E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<Func<IEnumerator>>.Enumerator <>7__wrap1;
	}

	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2001123")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157FF0", Offset = "0x1580F1")]
	private sealed class <TeleportPositionCoroutine>d__160 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002343 RID: 9027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007090")]
		[Address(RVA = "0x1F63D60", Offset = "0x1F63E61", VA = "0x1F63D60")]
		[DebuggerHidden]
		public <TeleportPositionCoroutine>d__160(int <>1__state)
		{
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007091")]
		[Address(RVA = "0x1F68D40", Offset = "0x1F68E41", VA = "0x1F68D40", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0000E568 File Offset: 0x0000C768
		[Token(Token = "0x6007092")]
		[Address(RVA = "0x1F68D50", Offset = "0x1F68E51", VA = "0x1F68D50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE5")]
		private object Current
		{
			[Token(Token = "0x6007093")]
			[Address(RVA = "0x1F68EA0", Offset = "0x1F68FA1", VA = "0x1F68EA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007094")]
		[Address(RVA = "0x1F68EB0", Offset = "0x1F68FB1", VA = "0x1F68EB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE6")]
		private object Current
		{
			[Token(Token = "0x6007095")]
			[Address(RVA = "0x1F68F10", Offset = "0x1F69011", VA = "0x1F68F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006B0A RID: 27402
		[Token(Token = "0x401930F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006B0B RID: 27403
		[Token(Token = "0x4019310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006B0C RID: 27404
		[Token(Token = "0x4019311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportAreaManager <>4__this;
	}

	// Token: 0x0200059A RID: 1434
	[Token(Token = "0x2001124")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158000", Offset = "0x158101")]
	private sealed class <>c__DisplayClass168_0
	{
		// Token: 0x06002349 RID: 9033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007096")]
		[Address(RVA = "0x1F66FC0", Offset = "0x1F670C1", VA = "0x1F66FC0")]
		public <>c__DisplayClass168_0()
		{
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007097")]
		[Address(RVA = "0x1F66FD0", Offset = "0x1F670D1", VA = "0x1F66FD0")]
		internal void <LoadSceneBgm>b__0(AudioClip data)
		{
		}

		// Token: 0x04006B0D RID: 27405
		[Token(Token = "0x4019312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isBgmLoad;
	}

	// Token: 0x0200059B RID: 1435
	[Token(Token = "0x2001125")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158010", Offset = "0x158111")]
	private sealed class <LoadSceneBgm>d__168 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600234B RID: 9035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007098")]
		[Address(RVA = "0x1F64CF0", Offset = "0x1F64DF1", VA = "0x1F64CF0")]
		[DebuggerHidden]
		public <LoadSceneBgm>d__168(int <>1__state)
		{
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007099")]
		[Address(RVA = "0x1F67110", Offset = "0x1F67211", VA = "0x1F67110", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0000E580 File Offset: 0x0000C780
		[Token(Token = "0x600709A")]
		[Address(RVA = "0x1F67120", Offset = "0x1F67221", VA = "0x1F67120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE7")]
		private object Current
		{
			[Token(Token = "0x600709B")]
			[Address(RVA = "0x1F67560", Offset = "0x1F67661", VA = "0x1F67560", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709C")]
		[Address(RVA = "0x1F67570", Offset = "0x1F67671", VA = "0x1F67570", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE8")]
		private object Current
		{
			[Token(Token = "0x600709D")]
			[Address(RVA = "0x1F675D0", Offset = "0x1F676D1", VA = "0x1F675D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006B0E RID: 27406
		[Token(Token = "0x4019313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006B0F RID: 27407
		[Token(Token = "0x4019314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006B10 RID: 27408
		[Token(Token = "0x4019315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportAreaManager <>4__this;

		// Token: 0x04006B11 RID: 27409
		[Token(Token = "0x4019316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TeleportAreaManager.<>c__DisplayClass168_0 <>8__1;
	}

	// Token: 0x0200059C RID: 1436
	[Token(Token = "0x2001126")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158020", Offset = "0x158121")]
	private sealed class <UnloadStearmerSceneAsync>d__185 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002351 RID: 9041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709E")]
		[Address(RVA = "0x1F65D50", Offset = "0x1F65E51", VA = "0x1F65D50")]
		[DebuggerHidden]
		public <UnloadStearmerSceneAsync>d__185(int <>1__state)
		{
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600709F")]
		[Address(RVA = "0x1F68F20", Offset = "0x1F69021", VA = "0x1F68F20", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x0000E598 File Offset: 0x0000C798
		[Token(Token = "0x60070A0")]
		[Address(RVA = "0x1F68FF0", Offset = "0x1F690F1", VA = "0x1F68FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A1")]
		[Address(RVA = "0x1F68F90", Offset = "0x1F69091", VA = "0x1F68F90")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE9")]
		private object Current
		{
			[Token(Token = "0x60070A2")]
			[Address(RVA = "0x1F696B0", Offset = "0x1F697B1", VA = "0x1F696B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070A3")]
		[Address(RVA = "0x1F696C0", Offset = "0x1F697C1", VA = "0x1F696C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEA")]
		private object Current
		{
			[Token(Token = "0x60070A4")]
			[Address(RVA = "0x1F69720", Offset = "0x1F69821", VA = "0x1F69720", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006B12 RID: 27410
		[Token(Token = "0x4019317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006B13 RID: 27411
		[Token(Token = "0x4019318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006B14 RID: 27412
		[Token(Token = "0x4019319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action completeAction;

		// Token: 0x04006B15 RID: 27413
		[Token(Token = "0x401931A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<RF5Streamer>.Enumerator <>7__wrap1;

		// Token: 0x04006B16 RID: 27414
		[Token(Token = "0x401931B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RF5Streamer <streamer>5__3;
	}
}
