using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BB4 RID: 2996
[Token(Token = "0x20007C7")]
[Attribute(Name = "HelpURLAttribute", RVA = "0x147580", Offset = "0x147681")]
public class Streamer : MonoBehaviour
{
	// Token: 0x170009F1 RID: 2545
	// (get) Token: 0x06004C96 RID: 19606 RVA: 0x00018600 File Offset: 0x00016800
	[Token(Token = "0x170007ED")]
	public float LoadingProgress
	{
		[Token(Token = "0x600403F")]
		[Address(RVA = "0x238BE30", Offset = "0x238BF31", VA = "0x238BE30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06004C97 RID: 19607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004040")]
	[Address(RVA = "0x238BED0", Offset = "0x238BFD1", VA = "0x238BED0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06004C98 RID: 19608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004041")]
	[Address(RVA = "0x238C260", Offset = "0x238C361", VA = "0x238C260")]
	private void Start()
	{
	}

	// Token: 0x06004C99 RID: 19609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004042")]
	[Address(RVA = "0x238C400", Offset = "0x238C501", VA = "0x238C400")]
	private void OnEnable()
	{
	}

	// Token: 0x06004C9A RID: 19610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004043")]
	[Address(RVA = "0x238C520", Offset = "0x238C621", VA = "0x238C520")]
	private void OnDisable()
	{
	}

	// Token: 0x06004C9B RID: 19611 RVA: 0x00018618 File Offset: 0x00016818
	[Token(Token = "0x6004044")]
	[Address(RVA = "0x238C560", Offset = "0x238C661", VA = "0x238C560")]
	private int mod(int x, int m)
	{
		return 0;
	}

	// Token: 0x06004C9C RID: 19612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004045")]
	[Address(RVA = "0x238C580", Offset = "0x238C681", VA = "0x238C580", Slot = "5")]
	public virtual void AddSceneGO(string sceneName, GameObject sceneGO)
	{
	}

	// Token: 0x06004C9D RID: 19613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004046")]
	[Address(RVA = "0x238CAC0", Offset = "0x238CBC1", VA = "0x238CAC0")]
	private void Update()
	{
	}

	// Token: 0x06004C9E RID: 19614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004047")]
	[Address(RVA = "0x238CAD0", Offset = "0x238CBD1", VA = "0x238CAD0", Slot = "6")]
	protected virtual void LoadLevelAsyncManage()
	{
	}

	// Token: 0x06004C9F RID: 19615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004048")]
	[Address(RVA = "0x238C380", Offset = "0x238C481", VA = "0x238C380")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8DA0", Offset = "0x1A8EA1")]
	private IEnumerator PositionChecker()
	{
		return null;
	}

	// Token: 0x06004CA0 RID: 19616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004049")]
	[Address(RVA = "0x238CCB0", Offset = "0x238CDB1", VA = "0x238CCB0")]
	public void CheckPositionTiles(bool isForce = false)
	{
	}

	// Token: 0x06004CA1 RID: 19617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600404A")]
	[Address(RVA = "0x238CF50", Offset = "0x238D051", VA = "0x238CF50", Slot = "7")]
	protected virtual void SceneLoading()
	{
	}

	// Token: 0x06004CA2 RID: 19618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600404B")]
	[Address(RVA = "0x238D960", Offset = "0x238DA61", VA = "0x238D960", Slot = "8")]
	public virtual void SceneUnloading()
	{
	}

	// Token: 0x06004CA3 RID: 19619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600404C")]
	[Address(RVA = "0x238E1E0", Offset = "0x238E2E1", VA = "0x238E1E0", Slot = "9")]
	public virtual void UnloadAllScenes()
	{
	}

	// Token: 0x06004CA4 RID: 19620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600404D")]
	[Address(RVA = "0x238E710", Offset = "0x238E811", VA = "0x238E710")]
	public static void UnloadAssets(Streamer streamer)
	{
	}

	// Token: 0x06004CA5 RID: 19621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600404E")]
	[Address(RVA = "0x238E870", Offset = "0x238E971", VA = "0x238E870")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8E10", Offset = "0x1A8F11")]
	public IEnumerator UnloadAssetsWait()
	{
		return null;
	}

	// Token: 0x06004CA6 RID: 19622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600404F")]
	[Address(RVA = "0x238C060", Offset = "0x238C161", VA = "0x238C060")]
	private void PrepareScenesArray()
	{
	}

	// Token: 0x06004CA7 RID: 19623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004050")]
	[Address(RVA = "0x238C870", Offset = "0x238C971", VA = "0x238C870")]
	public static void SceneNameToPos(SceneCollection sceneCollection, string sceneName, out int posX, out int posY, out int posZ)
	{
	}

	// Token: 0x06004CA8 RID: 19624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004051")]
	[Address(RVA = "0x238E900", Offset = "0x238EA01", VA = "0x238E900")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06004CA9 RID: 19625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004052")]
	[Address(RVA = "0x238ECB0", Offset = "0x238EDB1", VA = "0x238ECB0")]
	public Streamer()
	{
	}

	// Token: 0x0400AE15 RID: 44565
	[Token(Token = "0x400833C")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176330", Offset = "0x176431")]
	public bool streamerActive;

	// Token: 0x0400AE16 RID: 44566
	[Token(Token = "0x400833D")]
	[FieldOffset(Offset = "0x0")]
	public static string STREAMERTAG;

	// Token: 0x0400AE17 RID: 44567
	[Token(Token = "0x400833E")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x176370", Offset = "0x176471")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176370", Offset = "0x176471")]
	public SceneCollection sceneCollection;

	// Token: 0x0400AE18 RID: 44568
	[Token(Token = "0x400833F")]
	[FieldOffset(Offset = "0x28")]
	public SceneSplit[] splits;

	// Token: 0x0400AE19 RID: 44569
	[Token(Token = "0x4008340")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1763D0", Offset = "0x1764D1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1763D0", Offset = "0x1764D1")]
	public Vector3 loadingRange;

	// Token: 0x0400AE1A RID: 44570
	[Token(Token = "0x4008341")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176430", Offset = "0x176531")]
	public bool useLoadingRangeMin;

	// Token: 0x0400AE1B RID: 44571
	[Token(Token = "0x4008342")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176470", Offset = "0x176571")]
	public Vector3 loadingRangeMin;

	// Token: 0x0400AE1C RID: 44572
	[Token(Token = "0x4008343")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1764B0", Offset = "0x1765B1")]
	public Vector3 deloadingRange;

	// Token: 0x0400AE1D RID: 44573
	[Token(Token = "0x4008344")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1764F0", Offset = "0x1765F1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1764F0", Offset = "0x1765F1")]
	public float positionCheckTime;

	// Token: 0x0400AE1E RID: 44574
	[Token(Token = "0x4008345")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176550", Offset = "0x176651")]
	public float destroyTileDelay;

	// Token: 0x0400AE1F RID: 44575
	[Token(Token = "0x4008346")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176590", Offset = "0x176691")]
	public int maxParallelSceneLoading;

	// Token: 0x0400AE20 RID: 44576
	[Token(Token = "0x4008347")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1765D0", Offset = "0x1766D1")]
	public int sceneLoadWaitFrames;

	// Token: 0x0400AE21 RID: 44577
	[Token(Token = "0x4008348")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x176610", Offset = "0x176711")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176610", Offset = "0x176711")]
	public TerrainNeighbours terrainNeighbours;

	// Token: 0x0400AE22 RID: 44578
	[Token(Token = "0x4008349")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x176660", Offset = "0x176761")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176660", Offset = "0x176761")]
	public bool looping;

	// Token: 0x0400AE23 RID: 44579
	[Token(Token = "0x400834A")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x1766B0", Offset = "0x1767B1")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1766B0", Offset = "0x1767B1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1766B0", Offset = "0x1767B1")]
	public Transform player;

	// Token: 0x0400AE24 RID: 44580
	[Token(Token = "0x400834B")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176730", Offset = "0x176831")]
	public bool spawnedPlayer;

	// Token: 0x0400AE25 RID: 44581
	[Token(Token = "0x400834C")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "HideInInspector", RVA = "0x176770", Offset = "0x176871")]
	public string playerTag;

	// Token: 0x0400AE26 RID: 44582
	[Token(Token = "0x400834D")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "HideInInspector", RVA = "0x176780", Offset = "0x176881")]
	public bool showLoadingScreen;

	// Token: 0x0400AE27 RID: 44583
	[Token(Token = "0x400834E")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "HideInInspector", RVA = "0x176790", Offset = "0x176891")]
	public UILoadingStreamer loadingStreamer;

	// Token: 0x0400AE28 RID: 44584
	[Token(Token = "0x400834F")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "HideInInspector", RVA = "0x1767A0", Offset = "0x1768A1")]
	public bool initialized;

	// Token: 0x0400AE29 RID: 44585
	[Token(Token = "0x4008350")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "HideInInspector", RVA = "0x1767B0", Offset = "0x1768B1")]
	public int tilesToLoad;

	// Token: 0x0400AE2A RID: 44586
	[Token(Token = "0x4008351")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "HideInInspector", RVA = "0x1767C0", Offset = "0x1768C1")]
	public int tilesLoaded;

	// Token: 0x0400AE2B RID: 44587
	[Token(Token = "0x4008352")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "HideInInspector", RVA = "0x1767D0", Offset = "0x1768D1")]
	public WorldMover worldMover;

	// Token: 0x0400AE2C RID: 44588
	[Token(Token = "0x4008353")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "HideInInspector", RVA = "0x1767E0", Offset = "0x1768E1")]
	public Vector3 currentMove;

	// Token: 0x0400AE2D RID: 44589
	[Token(Token = "0x4008354")]
	[FieldOffset(Offset = "0xC4")]
	protected int xPos;

	// Token: 0x0400AE2E RID: 44590
	[Token(Token = "0x4008355")]
	[FieldOffset(Offset = "0xC8")]
	protected int yPos;

	// Token: 0x0400AE2F RID: 44591
	[Token(Token = "0x4008356")]
	[FieldOffset(Offset = "0xCC")]
	protected int zPos;

	// Token: 0x0400AE30 RID: 44592
	[Token(Token = "0x4008357")]
	[FieldOffset(Offset = "0xD0")]
	public Dictionary<int[], SceneSplit> scenesArray;

	// Token: 0x0400AE31 RID: 44593
	[Token(Token = "0x4008358")]
	[FieldOffset(Offset = "0xD8")]
	[Attribute(Name = "HideInInspector", RVA = "0x1767F0", Offset = "0x1768F1")]
	public List<SceneSplit> loadedScenes;

	// Token: 0x0400AE32 RID: 44594
	[Token(Token = "0x4008359")]
	[FieldOffset(Offset = "0xE0")]
	protected int currentlySceneLoading;

	// Token: 0x0400AE33 RID: 44595
	[Token(Token = "0x400835A")]
	[FieldOffset(Offset = "0xE8")]
	protected List<SceneSplit> scenesToLoad;

	// Token: 0x0400AE34 RID: 44596
	[Token(Token = "0x400835B")]
	[FieldOffset(Offset = "0xF0")]
	protected int sceneLoadFrameNext;

	// Token: 0x0400AE35 RID: 44597
	[Token(Token = "0x400835C")]
	[FieldOffset(Offset = "0xF4")]
	protected bool sceneLoadFramesNextWaited;

	// Token: 0x0400AE36 RID: 44598
	[Token(Token = "0x400835D")]
	[FieldOffset(Offset = "0xF8")]
	protected int xLimity;

	// Token: 0x0400AE37 RID: 44599
	[Token(Token = "0x400835E")]
	[FieldOffset(Offset = "0xFC")]
	protected int xLimitx;

	// Token: 0x0400AE38 RID: 44600
	[Token(Token = "0x400835F")]
	[FieldOffset(Offset = "0x100")]
	protected int xRange;

	// Token: 0x0400AE39 RID: 44601
	[Token(Token = "0x4008360")]
	[FieldOffset(Offset = "0x104")]
	protected int yLimity;

	// Token: 0x0400AE3A RID: 44602
	[Token(Token = "0x4008361")]
	[FieldOffset(Offset = "0x108")]
	protected int yLimitx;

	// Token: 0x0400AE3B RID: 44603
	[Token(Token = "0x4008362")]
	[FieldOffset(Offset = "0x10C")]
	protected int yRange;

	// Token: 0x0400AE3C RID: 44604
	[Token(Token = "0x4008363")]
	[FieldOffset(Offset = "0x110")]
	protected int zLimity;

	// Token: 0x0400AE3D RID: 44605
	[Token(Token = "0x4008364")]
	[FieldOffset(Offset = "0x114")]
	protected int zLimitx;

	// Token: 0x0400AE3E RID: 44606
	[Token(Token = "0x4008365")]
	[FieldOffset(Offset = "0x118")]
	protected int zRange;

	// Token: 0x0400AE3F RID: 44607
	[Token(Token = "0x4008366")]
	[FieldOffset(Offset = "0x8")]
	private static bool canUnload;

	// Token: 0x0400AE40 RID: 44608
	[Token(Token = "0x4008367")]
	[FieldOffset(Offset = "0xC")]
	private static float waitTillNextUnload;

	// Token: 0x0400AE41 RID: 44609
	[Token(Token = "0x4008368")]
	[FieldOffset(Offset = "0x10")]
	private static bool unloadNext;

	// Token: 0x0400AE42 RID: 44610
	[Token(Token = "0x4008369")]
	[FieldOffset(Offset = "0x120")]
	protected Coroutine PositionCheckerCoroutine;

	// Token: 0x02000BB5 RID: 2997
	[Token(Token = "0x200136D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159490", Offset = "0x159591")]
	private sealed class <PositionChecker>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004CAB RID: 19627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007739")]
		[Address(RVA = "0x238CC80", Offset = "0x238CD81", VA = "0x238CC80")]
		[DebuggerHidden]
		public <PositionChecker>d__56(int <>1__state)
		{
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600773A")]
		[Address(RVA = "0x238EF10", Offset = "0x238F011", VA = "0x238EF10", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x00018630 File Offset: 0x00016830
		[Token(Token = "0x600773B")]
		[Address(RVA = "0x238EF20", Offset = "0x238F021", VA = "0x238EF20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06004CAE RID: 19630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC1")]
		private object Current
		{
			[Token(Token = "0x600773C")]
			[Address(RVA = "0x238F160", Offset = "0x238F261", VA = "0x238F160", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600773D")]
		[Address(RVA = "0x238F170", Offset = "0x238F271", VA = "0x238F170", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06004CB0 RID: 19632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC2")]
		private object Current
		{
			[Token(Token = "0x600773E")]
			[Address(RVA = "0x238F1D0", Offset = "0x238F2D1", VA = "0x238F1D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400AE43 RID: 44611
		[Token(Token = "0x401B732")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400AE44 RID: 44612
		[Token(Token = "0x401B733")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400AE45 RID: 44613
		[Token(Token = "0x401B734")]
		[FieldOffset(Offset = "0x20")]
		public Streamer <>4__this;

		// Token: 0x0400AE46 RID: 44614
		[Token(Token = "0x401B735")]
		[FieldOffset(Offset = "0x28")]
		private global::WaitForSecondsRealtime <waitForSecondsRealtime>5__2;
	}

	// Token: 0x02000BB6 RID: 2998
	[Token(Token = "0x200136E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1594A0", Offset = "0x1595A1")]
	private sealed class <UnloadAssetsWait>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004CB1 RID: 19633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600773F")]
		[Address(RVA = "0x238E8D0", Offset = "0x238E9D1", VA = "0x238E8D0")]
		[DebuggerHidden]
		public <UnloadAssetsWait>d__62(int <>1__state)
		{
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007740")]
		[Address(RVA = "0x238F1E0", Offset = "0x238F2E1", VA = "0x238F1E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x00018648 File Offset: 0x00016848
		[Token(Token = "0x6007741")]
		[Address(RVA = "0x238F1F0", Offset = "0x238F2F1", VA = "0x238F1F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC3")]
		private object Current
		{
			[Token(Token = "0x6007742")]
			[Address(RVA = "0x238F3F0", Offset = "0x238F4F1", VA = "0x238F3F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007743")]
		[Address(RVA = "0x238F400", Offset = "0x238F501", VA = "0x238F400", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06004CB6 RID: 19638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC4")]
		private object Current
		{
			[Token(Token = "0x6007744")]
			[Address(RVA = "0x238F460", Offset = "0x238F561", VA = "0x238F460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400AE47 RID: 44615
		[Token(Token = "0x401B736")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400AE48 RID: 44616
		[Token(Token = "0x401B737")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400AE49 RID: 44617
		[Token(Token = "0x401B738")]
		[FieldOffset(Offset = "0x20")]
		private global::WaitForSecondsRealtime <waitForSecondsRealtime>5__2;
	}
}
