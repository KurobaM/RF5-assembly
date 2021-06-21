using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

// Token: 0x02000BAD RID: 2989
[Token(Token = "0x20007C2")]
[Attribute(Name = "HelpURLAttribute", RVA = "0x147530", Offset = "0x147631")]
public class RF5Streamer : Streamer
{
	// Token: 0x170009EE RID: 2542
	// (get) Token: 0x06004C7A RID: 19578 RVA: 0x00018558 File Offset: 0x00016758
	[Token(Token = "0x170007EA")]
	public bool IsInit
	{
		[Token(Token = "0x6004027")]
		[Address(RVA = "0x217B9A0", Offset = "0x217BAA1", VA = "0x217B9A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170009EF RID: 2543
	// (get) Token: 0x06004C7B RID: 19579 RVA: 0x00018570 File Offset: 0x00016770
	[Token(Token = "0x170007EB")]
	public bool IsCurrentLoadEnd
	{
		[Token(Token = "0x6004028")]
		[Address(RVA = "0x21765E0", Offset = "0x21766E1", VA = "0x21765E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170009F0 RID: 2544
	// (get) Token: 0x06004C7C RID: 19580 RVA: 0x00018588 File Offset: 0x00016788
	[Token(Token = "0x170007EC")]
	public bool IsLoadComplete
	{
		[Token(Token = "0x6004029")]
		[Address(RVA = "0x217B9B0", Offset = "0x217BAB1", VA = "0x217B9B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06004C7D RID: 19581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600402A")]
	[Address(RVA = "0x217BA30", Offset = "0x217BB31", VA = "0x217BA30")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004C7E RID: 19582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600402B")]
	[Address(RVA = "0x217BA40", Offset = "0x217BB41", VA = "0x217BA40", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06004C7F RID: 19583 RVA: 0x000185A0 File Offset: 0x000167A0
	[Token(Token = "0x600402C")]
	[Address(RVA = "0x217BAF0", Offset = "0x217BBF1", VA = "0x217BAF0")]
	private int mod(int x, int m)
	{
		return 0;
	}

	// Token: 0x06004C80 RID: 19584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600402D")]
	[Address(RVA = "0x217BB10", Offset = "0x217BC11", VA = "0x217BB10", Slot = "5")]
	public override void AddSceneGO(string sceneName, GameObject sceneGO)
	{
	}

	// Token: 0x06004C81 RID: 19585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600402E")]
	[Address(RVA = "0x217BB60", Offset = "0x217BC61", VA = "0x217BB60")]
	private void SetEnabledOverLap(string sceneName, GameObject sceneGO, bool setEnabled)
	{
	}

	// Token: 0x06004C82 RID: 19586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600402F")]
	[Address(RVA = "0x217BED0", Offset = "0x217BFD1", VA = "0x217BED0")]
	private void Update()
	{
	}

	// Token: 0x06004C83 RID: 19587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004030")]
	[Address(RVA = "0x217BEE0", Offset = "0x217BFE1", VA = "0x217BEE0", Slot = "6")]
	protected override void LoadLevelAsyncManage()
	{
	}

	// Token: 0x06004C84 RID: 19588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004031")]
	[Address(RVA = "0x217C120", Offset = "0x217C221", VA = "0x217C120")]
	protected void OnLoadCompleted(AsyncOperationHandle<SceneInstance> handle)
	{
	}

	// Token: 0x06004C85 RID: 19589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004032")]
	[Address(RVA = "0x217C370", Offset = "0x217C471", VA = "0x217C370", Slot = "7")]
	protected override void SceneLoading()
	{
	}

	// Token: 0x06004C86 RID: 19590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004033")]
	[Address(RVA = "0x217CD90", Offset = "0x217CE91", VA = "0x217CD90", Slot = "8")]
	public override void SceneUnloading()
	{
	}

	// Token: 0x06004C87 RID: 19591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004034")]
	[Address(RVA = "0x217D8A0", Offset = "0x217D9A1", VA = "0x217D8A0", Slot = "9")]
	public override void UnloadAllScenes()
	{
	}

	// Token: 0x06004C88 RID: 19592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004035")]
	[Address(RVA = "0x217E020", Offset = "0x217E121", VA = "0x217E020")]
	public void SetEnableLoadData(bool enable)
	{
	}

	// Token: 0x06004C89 RID: 19593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004036")]
	[Address(RVA = "0x217E220", Offset = "0x217E321", VA = "0x217E220")]
	public RF5Streamer()
	{
	}

	// Token: 0x0400ADEC RID: 44524
	[Token(Token = "0x4008315")]
	[FieldOffset(Offset = "0x128")]
	private Dictionary<int, SceneInstance> loadSceneDictionary;

	// Token: 0x0400ADED RID: 44525
	[Token(Token = "0x4008316")]
	[FieldOffset(Offset = "0x130")]
	private Dictionary<int, string> loadRequest;

	// Token: 0x0400ADEE RID: 44526
	[Token(Token = "0x4008317")]
	[FieldOffset(Offset = "0x138")]
	public RF5Streamer OverLapStreamer;

	// Token: 0x02000BAE RID: 2990
	[Token(Token = "0x200136B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159470", Offset = "0x159571")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x06004C8A RID: 19594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007735")]
		[Address(RVA = "0x217BEB0", Offset = "0x217BFB1", VA = "0x217BEB0")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x000185B8 File Offset: 0x000167B8
		[Token(Token = "0x6007736")]
		[Address(RVA = "0x217E290", Offset = "0x217E391", VA = "0x217E290")]
		internal bool <SetEnabledOverLap>b__0(SceneSplit s)
		{
			return default(bool);
		}

		// Token: 0x0400ADEF RID: 44527
		[Token(Token = "0x401B730")]
		[FieldOffset(Offset = "0x10")]
		public string targetName;
	}

	// Token: 0x02000BAF RID: 2991
	[Token(Token = "0x200136C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159480", Offset = "0x159581")]
	private sealed class <>c__DisplayClass13_1
	{
		// Token: 0x06004C8C RID: 19596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007737")]
		[Address(RVA = "0x217BEC0", Offset = "0x217BFC1", VA = "0x217BEC0")]
		public <>c__DisplayClass13_1()
		{
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x000185D0 File Offset: 0x000167D0
		[Token(Token = "0x6007738")]
		[Address(RVA = "0x217E2C0", Offset = "0x217E3C1", VA = "0x217E2C0")]
		internal bool <SetEnabledOverLap>b__1(SceneSplit s)
		{
			return default(bool);
		}

		// Token: 0x0400ADF0 RID: 44528
		[Token(Token = "0x401B731")]
		[FieldOffset(Offset = "0x10")]
		public string targetName;
	}
}
