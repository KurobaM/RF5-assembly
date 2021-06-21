using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x02000542 RID: 1346
[Token(Token = "0x20003D2")]
public class SnowmanManager : SingletonMonoBehaviour<SnowmanManager>
{
	// Token: 0x17000543 RID: 1347
	// (get) Token: 0x0600207A RID: 8314 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600207B RID: 8315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000444")]
	public GameObject SnowballPrefab
	{
		[Token(Token = "0x6001B97")]
		[Address(RVA = "0x22542F0", Offset = "0x22543F1", VA = "0x22542F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0410", Offset = "0x1A0511")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x2254300", Offset = "0x2254401", VA = "0x2254300")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0420", Offset = "0x1A0521")]
		private set
		{
		}
	}

	// Token: 0x17000544 RID: 1348
	// (get) Token: 0x0600207C RID: 8316 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600207D RID: 8317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000445")]
	public List<FestivalSnowball> FestivalSnowballs
	{
		[Token(Token = "0x6001B99")]
		[Address(RVA = "0x2254310", Offset = "0x2254411", VA = "0x2254310")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0430", Offset = "0x1A0531")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B9A")]
		[Address(RVA = "0x2254320", Offset = "0x2254421", VA = "0x2254320")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0440", Offset = "0x1A0541")]
		private set
		{
		}
	}

	// Token: 0x17000545 RID: 1349
	// (get) Token: 0x0600207E RID: 8318 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600207F RID: 8319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000446")]
	public List<SnowmanManager.Mocomoco> Mocomocos
	{
		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x2254330", Offset = "0x2254431", VA = "0x2254330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0450", Offset = "0x1A0551")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x2254340", Offset = "0x2254441", VA = "0x2254340")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0460", Offset = "0x1A0561")]
		private set
		{
		}
	}

	// Token: 0x17000546 RID: 1350
	// (get) Token: 0x06002080 RID: 8320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000447")]
	public SnowmanCamera Camera
	{
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x2254350", Offset = "0x2254451", VA = "0x2254350")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000547 RID: 1351
	// (get) Token: 0x06002081 RID: 8321 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002082 RID: 8322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000448")]
	public SnowmanPlayer SnowmanPlayer
	{
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x2254360", Offset = "0x2254461", VA = "0x2254360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0470", Offset = "0x1A0571")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x2254370", Offset = "0x2254471", VA = "0x2254370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0480", Offset = "0x1A0581")]
		private set
		{
		}
	}

	// Token: 0x17000548 RID: 1352
	// (get) Token: 0x06002083 RID: 8323 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002084 RID: 8324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000449")]
	public ParticleSystem SpeedUpEffect
	{
		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x2254380", Offset = "0x2254481", VA = "0x2254380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0490", Offset = "0x1A0591")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x2254390", Offset = "0x2254491", VA = "0x2254390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A04A0", Offset = "0x1A05A1")]
		private set
		{
		}
	}

	// Token: 0x17000549 RID: 1353
	// (get) Token: 0x06002085 RID: 8325 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002086 RID: 8326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700044A")]
	public SnowmanManager.CurrentObject[] CurrentObjectList
	{
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x22543A0", Offset = "0x22544A1", VA = "0x22543A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A04B0", Offset = "0x1A05B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x22543B0", Offset = "0x22544B1", VA = "0x22543B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A04C0", Offset = "0x1A05C1")]
		private set
		{
		}
	}

	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x06002087 RID: 8327 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
	// (set) Token: 0x06002088 RID: 8328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700044B")]
	public int CurrentObjectCount
	{
		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x22543C0", Offset = "0x22544C1", VA = "0x22543C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A04D0", Offset = "0x1A05D1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x22543D0", Offset = "0x22544D1", VA = "0x22543D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A04E0", Offset = "0x1A05E1")]
		private set
		{
		}
	}

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x06002089 RID: 8329 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600208A RID: 8330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700044C")]
	public SnowballDataTable SnowballDataTable
	{
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x22543E0", Offset = "0x22544E1", VA = "0x22543E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A04F0", Offset = "0x1A05F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x22543F0", Offset = "0x22544F1", VA = "0x22543F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0500", Offset = "0x1A0601")]
		private set
		{
		}
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BA8")]
	[Address(RVA = "0x2254400", Offset = "0x2254501", VA = "0x2254400", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BA9")]
	[Address(RVA = "0x2254470", Offset = "0x2254571", VA = "0x2254470")]
	private void Start()
	{
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BAA")]
	[Address(RVA = "0x2254B30", Offset = "0x2254C31", VA = "0x2254B30")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BAB")]
	[Address(RVA = "0x2254BB0", Offset = "0x2254CB1", VA = "0x2254BB0")]
	private void InitMocomoco()
	{
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BAC")]
	[Address(RVA = "0x2254F10", Offset = "0x2255011", VA = "0x2254F10")]
	private void CharaSetup()
	{
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
	[Token(Token = "0x6001BAD")]
	[Address(RVA = "0x2255040", Offset = "0x2255141", VA = "0x2255040")]
	private bool IsLoading()
	{
		return default(bool);
	}

	// Token: 0x06002091 RID: 8337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BAE")]
	[Address(RVA = "0x2255170", Offset = "0x2255271", VA = "0x2255170")]
	private void Update()
	{
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BAF")]
	[Address(RVA = "0x2254DE0", Offset = "0x2254EE1", VA = "0x2254DE0")]
	private void LoadMocomoco(SnowmanManager.Mocomoco _mocomoco)
	{
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB0")]
	[Address(RVA = "0x22556F0", Offset = "0x22557F1", VA = "0x22556F0")]
	private GameObject SummonMocomoco(SnowmanObjectID _id, Vector3 _pos)
	{
		return null;
	}

	// Token: 0x06002094 RID: 8340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BB1")]
	[Address(RVA = "0x2255AF0", Offset = "0x2255BF1", VA = "0x2255AF0")]
	private void ResetMocomoco()
	{
	}

	// Token: 0x06002095 RID: 8341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB2")]
	[Address(RVA = "0x2255660", Offset = "0x2255761", VA = "0x2255660")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0510", Offset = "0x1A0611")]
	private IEnumerator SnowmanGame()
	{
		return null;
	}

	// Token: 0x06002096 RID: 8342 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
	[Token(Token = "0x6001BB3")]
	[Address(RVA = "0x2255F50", Offset = "0x2256051", VA = "0x2255F50")]
	private SnowmanObjectType GetSnowmanObjectType(SnowmanObjectID _id)
	{
		return SnowmanObjectType.None;
	}

	// Token: 0x06002097 RID: 8343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BB4")]
	[Address(RVA = "0x2255F90", Offset = "0x2256091", VA = "0x2255F90")]
	private void ResetInvincible()
	{
	}

	// Token: 0x06002098 RID: 8344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BB5")]
	[Address(RVA = "0x2255FE0", Offset = "0x22560E1", VA = "0x2255FE0")]
	public void MinimapSwitcher()
	{
	}

	// Token: 0x06002099 RID: 8345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BB6")]
	[Address(RVA = "0x2256000", Offset = "0x2256101", VA = "0x2256000")]
	public void SetNormalScale()
	{
	}

	// Token: 0x0600209A RID: 8346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BB7")]
	[Address(RVA = "0x2256020", Offset = "0x2256121", VA = "0x2256020")]
	public SnowmanManager()
	{
	}

	// Token: 0x0600209B RID: 8347 RVA: 0x0000D608 File Offset: 0x0000B808
	[Token(Token = "0x6001BB8")]
	[Address(RVA = "0x2256180", Offset = "0x2256281", VA = "0x2256180")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0580", Offset = "0x1A0681")]
	private bool <Start>b__52_0(Transform obj)
	{
		return default(bool);
	}

	// Token: 0x0600209C RID: 8348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BB9")]
	[Address(RVA = "0x22561D0", Offset = "0x22562D1", VA = "0x22561D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0590", Offset = "0x1A0691")]
	private void <Start>b__52_1(ParticleSystem _effect)
	{
	}

	// Token: 0x0600209D RID: 8349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BBA")]
	[Address(RVA = "0x22562D0", Offset = "0x22563D1", VA = "0x22562D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A05A0", Offset = "0x1A06A1")]
	private void <Start>b__52_2(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x0600209E RID: 8350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BBB")]
	[Address(RVA = "0x2256350", Offset = "0x2256451", VA = "0x2256350")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A05B0", Offset = "0x1A06B1")]
	private void <Start>b__52_3(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x0400676E RID: 26478
	[Token(Token = "0x4006170")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165DF0", Offset = "0x165EF1")]
	private GameObject <SnowballPrefab>k__BackingField;

	// Token: 0x0400676F RID: 26479
	[Token(Token = "0x4006171")]
	[FieldOffset(Offset = "0x20")]
	private readonly int SNOWBALL_PREFAB_ID;

	// Token: 0x04006770 RID: 26480
	[Token(Token = "0x4006172")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165E00", Offset = "0x165F01")]
	private List<FestivalSnowball> <FestivalSnowballs>k__BackingField;

	// Token: 0x04006771 RID: 26481
	[Token(Token = "0x4006173")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165E10", Offset = "0x165F11")]
	private List<SnowmanManager.Mocomoco> <Mocomocos>k__BackingField;

	// Token: 0x04006772 RID: 26482
	[Token(Token = "0x4006174")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SnowmanCamera snowmanCamera;

	// Token: 0x04006773 RID: 26483
	[Token(Token = "0x4006175")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165E30", Offset = "0x165F31")]
	private SnowmanPlayer <SnowmanPlayer>k__BackingField;

	// Token: 0x04006774 RID: 26484
	[Token(Token = "0x4006176")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165E40", Offset = "0x165F41")]
	private ParticleSystem <SpeedUpEffect>k__BackingField;

	// Token: 0x04006775 RID: 26485
	[Token(Token = "0x4006177")]
	private const int OBJECT_MAX = 30;

	// Token: 0x04006776 RID: 26486
	[Token(Token = "0x4006178")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165E50", Offset = "0x165F51")]
	private SnowmanManager.CurrentObject[] <CurrentObjectList>k__BackingField;

	// Token: 0x04006777 RID: 26487
	[Token(Token = "0x4006179")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165E60", Offset = "0x165F61")]
	private int <CurrentObjectCount>k__BackingField;

	// Token: 0x04006778 RID: 26488
	[Token(Token = "0x400617A")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165E70", Offset = "0x165F71")]
	private SnowballDataTable <SnowballDataTable>k__BackingField;

	// Token: 0x04006779 RID: 26489
	[Token(Token = "0x400617B")]
	[FieldOffset(Offset = "0x68")]
	private List<Transform> popPoints;

	// Token: 0x0400677A RID: 26490
	[Token(Token = "0x400617C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject playerPos;

	// Token: 0x0400677B RID: 26491
	[Token(Token = "0x400617D")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject spawnPos;

	// Token: 0x0400677C RID: 26492
	[Token(Token = "0x400617E")]
	[FieldOffset(Offset = "0x80")]
	private SnowballObjectSpawnDataTable snowballObjectSpawnDataTable;

	// Token: 0x0400677D RID: 26493
	[Token(Token = "0x400617F")]
	private const float SNOWBALL_RADIUS = 0.5f;

	// Token: 0x0400677E RID: 26494
	[Token(Token = "0x4006180")]
	[FieldOffset(Offset = "0x88")]
	private int loadCount;

	// Token: 0x0400677F RID: 26495
	[Token(Token = "0x4006181")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Canvas canvas;

	// Token: 0x04006780 RID: 26496
	[Token(Token = "0x4006182")]
	[FieldOffset(Offset = "0x98")]
	private readonly int MINIMAP_PREFAB_ID;

	// Token: 0x04006781 RID: 26497
	[Token(Token = "0x4006183")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject minimapObj;

	// Token: 0x04006782 RID: 26498
	[Token(Token = "0x4006184")]
	[FieldOffset(Offset = "0xA8")]
	private FesMinimapControl minimapContl;

	// Token: 0x04006783 RID: 26499
	[Token(Token = "0x4006185")]
	[FieldOffset(Offset = "0xB0")]
	private SnowmanManager.State state;

	// Token: 0x02000543 RID: 1347
	[Token(Token = "0x20010F9")]
	public class Mocomoco
	{
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CBC")]
		public MocomocoData MocomocoData
		{
			[Token(Token = "0x6006FCE")]
			[Address(RVA = "0x2256F70", Offset = "0x2257071", VA = "0x2256F70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1CB0", Offset = "0x1B1DB1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FCF")]
			[Address(RVA = "0x2256F80", Offset = "0x2257081", VA = "0x2256F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1CC0", Offset = "0x1B1DC1")]
			private set
			{
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CBD")]
		public MonsterControllerBase MocomocoController
		{
			[Token(Token = "0x6006FD0")]
			[Address(RVA = "0x2256F90", Offset = "0x2257091", VA = "0x2256F90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1CD0", Offset = "0x1B1DD1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FD1")]
			[Address(RVA = "0x2256FA0", Offset = "0x22570A1", VA = "0x2256FA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1CE0", Offset = "0x1B1DE1")]
			private set
			{
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CBE")]
		public EnemyBehaviorController EnemyBehaviorController
		{
			[Token(Token = "0x6006FD2")]
			[Address(RVA = "0x2256FB0", Offset = "0x22570B1", VA = "0x2256FB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1CF0", Offset = "0x1B1DF1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FD3")]
			[Address(RVA = "0x2256FC0", Offset = "0x22570C1", VA = "0x2256FC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1D00", Offset = "0x1B1E01")]
			private set
			{
			}
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD4")]
		[Address(RVA = "0x2254DA0", Offset = "0x2254EA1", VA = "0x2254DA0")]
		public Mocomoco(MocomocoData _mocomoco_data)
		{
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD5")]
		[Address(RVA = "0x2256670", Offset = "0x2256771", VA = "0x2256670")]
		public void SetController(MonsterControllerBase _controller)
		{
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD6")]
		[Address(RVA = "0x2256730", Offset = "0x2256831", VA = "0x2256730")]
		public void SetBehaviorController(EnemyBehaviorController _behavior_controller)
		{
		}

		// Token: 0x04006784 RID: 26500
		[Token(Token = "0x4019271")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194FD0", Offset = "0x1950D1")]
		private MocomocoData <MocomocoData>k__BackingField;

		// Token: 0x04006785 RID: 26501
		[Token(Token = "0x4019272")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194FE0", Offset = "0x1950E1")]
		private MonsterControllerBase <MocomocoController>k__BackingField;

		// Token: 0x04006786 RID: 26502
		[Token(Token = "0x4019273")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194FF0", Offset = "0x1950F1")]
		private EnemyBehaviorController <EnemyBehaviorController>k__BackingField;
	}

	// Token: 0x02000544 RID: 1348
	[Token(Token = "0x20010FA")]
	public class CurrentObject
	{
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CBF")]
		public GameObject GameObject
		{
			[Token(Token = "0x6006FD7")]
			[Address(RVA = "0x2256F00", Offset = "0x2257001", VA = "0x2256F00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1D10", Offset = "0x1B1E11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FD8")]
			[Address(RVA = "0x2256F10", Offset = "0x2257011", VA = "0x2256F10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1D20", Offset = "0x1B1E21")]
			set
			{
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0000D620 File Offset: 0x0000B820
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CC0")]
		public SnowmanObjectID SnowmanObjectID
		{
			[Token(Token = "0x6006FD9")]
			[Address(RVA = "0x2256F20", Offset = "0x2257021", VA = "0x2256F20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1D30", Offset = "0x1B1E31")]
			get
			{
				return SnowmanObjectID.None;
			}
			[Token(Token = "0x6006FDA")]
			[Address(RVA = "0x2256F30", Offset = "0x2257031", VA = "0x2256F30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1D40", Offset = "0x1B1E41")]
			set
			{
			}
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDB")]
		[Address(RVA = "0x2256F40", Offset = "0x2257041", VA = "0x2256F40")]
		public void Clear()
		{
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDC")]
		[Address(RVA = "0x2254B20", Offset = "0x2254C21", VA = "0x2254B20")]
		public CurrentObject()
		{
		}

		// Token: 0x04006787 RID: 26503
		[Token(Token = "0x4019274")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195000", Offset = "0x195101")]
		private GameObject <GameObject>k__BackingField;

		// Token: 0x04006788 RID: 26504
		[Token(Token = "0x4019275")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195010", Offset = "0x195111")]
		private SnowmanObjectID <SnowmanObjectID>k__BackingField;
	}

	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x20010FB")]
	private enum State
	{
		// Token: 0x0400678A RID: 26506
		[Token(Token = "0x4019277")]
		None,
		// Token: 0x0400678B RID: 26507
		[Token(Token = "0x4019278")]
		Begin,
		// Token: 0x0400678C RID: 26508
		[Token(Token = "0x4019279")]
		Load,
		// Token: 0x0400678D RID: 26509
		[Token(Token = "0x401927A")]
		CountDown,
		// Token: 0x0400678E RID: 26510
		[Token(Token = "0x401927B")]
		Main,
		// Token: 0x0400678F RID: 26511
		[Token(Token = "0x401927C")]
		End
	}

	// Token: 0x02000546 RID: 1350
	[Token(Token = "0x20010FC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157D90", Offset = "0x157E91")]
	private sealed class <>c__DisplayClass58_0
	{
		// Token: 0x060020AE RID: 8366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDD")]
		[Address(RVA = "0x22556E0", Offset = "0x22557E1", VA = "0x22556E0")]
		public <>c__DisplayClass58_0()
		{
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDE")]
		[Address(RVA = "0x2256480", Offset = "0x2256581", VA = "0x2256480")]
		internal void <LoadMocomoco>b__0(MonsterControllerBase _controller)
		{
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDF")]
		[Address(RVA = "0x2256680", Offset = "0x2256781", VA = "0x2256680")]
		internal void <LoadMocomoco>b__1(EnemyBehaviorController behaviorcontroller)
		{
		}

		// Token: 0x04006790 RID: 26512
		[Token(Token = "0x401927D")]
		[FieldOffset(Offset = "0x10")]
		public SnowmanManager.Mocomoco _mocomoco;

		// Token: 0x04006791 RID: 26513
		[Token(Token = "0x401927E")]
		[FieldOffset(Offset = "0x18")]
		public SnowmanManager <>4__this;

		// Token: 0x04006792 RID: 26514
		[Token(Token = "0x401927F")]
		[FieldOffset(Offset = "0x20")]
		public Action<EnemyBehaviorController> <>9__1;
	}

	// Token: 0x02000547 RID: 1351
	[Token(Token = "0x20010FD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157DA0", Offset = "0x157EA1")]
	private sealed class <SnowmanGame>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060020B1 RID: 8369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE0")]
		[Address(RVA = "0x2255F20", Offset = "0x2256021", VA = "0x2255F20")]
		[DebuggerHidden]
		public <SnowmanGame>d__61(int <>1__state)
		{
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE1")]
		[Address(RVA = "0x2256740", Offset = "0x2256841", VA = "0x2256740", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x0000D638 File Offset: 0x0000B838
		[Token(Token = "0x6006FE2")]
		[Address(RVA = "0x2256750", Offset = "0x2256851", VA = "0x2256750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC1")]
		private object Current
		{
			[Token(Token = "0x6006FE3")]
			[Address(RVA = "0x2256E80", Offset = "0x2256F81", VA = "0x2256E80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE4")]
		[Address(RVA = "0x2256E90", Offset = "0x2256F91", VA = "0x2256E90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC2")]
		private object Current
		{
			[Token(Token = "0x6006FE5")]
			[Address(RVA = "0x2256EF0", Offset = "0x2256FF1", VA = "0x2256EF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006793 RID: 26515
		[Token(Token = "0x4019280")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006794 RID: 26516
		[Token(Token = "0x4019281")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006795 RID: 26517
		[Token(Token = "0x4019282")]
		[FieldOffset(Offset = "0x20")]
		public SnowmanManager <>4__this;

		// Token: 0x04006796 RID: 26518
		[Token(Token = "0x4019283")]
		[FieldOffset(Offset = "0x28")]
		private int <term>5__2;

		// Token: 0x04006797 RID: 26519
		[Token(Token = "0x4019284")]
		[FieldOffset(Offset = "0x2C")]
		private int <count>5__3;
	}
}
