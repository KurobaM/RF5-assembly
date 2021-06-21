using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200065C RID: 1628
[Token(Token = "0x200048D")]
public class GameMain : SingletonMonoBehaviour<GameMain>
{
	// Token: 0x17000672 RID: 1650
	// (get) Token: 0x06002872 RID: 10354 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
	[Token(Token = "0x17000528")]
	public static bool IsInit
	{
		[Token(Token = "0x6002234")]
		[Address(RVA = "0x23F9310", Offset = "0x23F9411", VA = "0x23F9310")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000673 RID: 1651
	// (get) Token: 0x06002873 RID: 10355 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
	[Token(Token = "0x17000529")]
	public static Scene Scene
	{
		[Token(Token = "0x6002235")]
		[Address(RVA = "0x23F93C0", Offset = "0x23F94C1", VA = "0x23F93C0")]
		get
		{
			return default(Scene);
		}
	}

	// Token: 0x17000674 RID: 1652
	// (get) Token: 0x06002874 RID: 10356 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002875 RID: 10357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700052A")]
	public string CurrentSceneName
	{
		[Token(Token = "0x6002236")]
		[Address(RVA = "0x23F9440", Offset = "0x23F9541", VA = "0x23F9440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1FF0", Offset = "0x1A20F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002237")]
		[Address(RVA = "0x23F9450", Offset = "0x23F9551", VA = "0x23F9450")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2000", Offset = "0x1A2101")]
		private set
		{
		}
	}

	// Token: 0x17000675 RID: 1653
	// (get) Token: 0x06002876 RID: 10358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700052B")]
	public static Transform ObjectRoot
	{
		[Token(Token = "0x6002238")]
		[Address(RVA = "0x23F9460", Offset = "0x23F9561", VA = "0x23F9460")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002877 RID: 10359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002239")]
	[Address(RVA = "0x23F94C0", Offset = "0x23F95C1", VA = "0x23F94C0")]
	private void InitializeGameMain()
	{
	}

	// Token: 0x06002878 RID: 10360 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
	[Token(Token = "0x600223A")]
	[Address(RVA = "0x23F9840", Offset = "0x23F9941", VA = "0x23F9840")]
	private bool IsInitializeManager()
	{
		return default(bool);
	}

	// Token: 0x06002879 RID: 10361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600223B")]
	[Address(RVA = "0x23F9AB0", Offset = "0x23F9BB1", VA = "0x23F9AB0")]
	private void InitializeAfterSceneLoaded()
	{
	}

	// Token: 0x0600287A RID: 10362 RVA: 0x00010008 File Offset: 0x0000E208
	[Token(Token = "0x600223C")]
	[Address(RVA = "0x23F9E70", Offset = "0x23F9F71", VA = "0x23F9E70")]
	private bool IsOpenScene()
	{
		return default(bool);
	}

	// Token: 0x0600287B RID: 10363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600223D")]
	[Address(RVA = "0x23F9F40", Offset = "0x23FA041", VA = "0x23F9F40", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600287C RID: 10364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600223E")]
	[Address(RVA = "0x23FA050", Offset = "0x23FA151", VA = "0x23FA050")]
	private void Start()
	{
	}

	// Token: 0x0600287D RID: 10365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600223F")]
	[Address(RVA = "0x23FA080", Offset = "0x23FA181", VA = "0x23FA080")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600287E RID: 10366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002240")]
	[Address(RVA = "0x23FA0A0", Offset = "0x23FA1A1", VA = "0x23FA0A0")]
	public static void EndScene()
	{
	}

	// Token: 0x0600287F RID: 10367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002241")]
	[Address(RVA = "0x23FA090", Offset = "0x23FA191", VA = "0x23FA090")]
	public void AllDestroy()
	{
	}

	// Token: 0x06002880 RID: 10368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002242")]
	[Address(RVA = "0x23FA1A0", Offset = "0x23FA2A1", VA = "0x23FA1A0")]
	private void FieldLoadStart()
	{
	}

	// Token: 0x06002881 RID: 10369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002243")]
	[Address(RVA = "0x23FA350", Offset = "0x23FA451", VA = "0x23FA350")]
	private void Update()
	{
	}

	// Token: 0x06002882 RID: 10370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002244")]
	[Address(RVA = "0x23FA800", Offset = "0x23FA901", VA = "0x23FA800")]
	public GameMain()
	{
	}

	// Token: 0x04006FD1 RID: 28625
	[Token(Token = "0x4006840")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] AwakeOnScenes;

	// Token: 0x04006FD2 RID: 28626
	[Token(Token = "0x4006841")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform ObjectRootTransform;

	// Token: 0x04006FD3 RID: 28627
	[Token(Token = "0x4006842")]
	public const string SceneName = "GameMain";

	// Token: 0x04006FD4 RID: 28628
	[Token(Token = "0x4006843")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168720", Offset = "0x168821")]
	private string <CurrentSceneName>k__BackingField;

	// Token: 0x04006FD5 RID: 28629
	[Token(Token = "0x4006844")]
	[FieldOffset(Offset = "0x30")]
	private GameMain.MODE m_mode;

	// Token: 0x04006FD6 RID: 28630
	[Token(Token = "0x4006845")]
	[FieldOffset(Offset = "0x34")]
	private Scene m_activeScene;

	// Token: 0x04006FD7 RID: 28631
	[Token(Token = "0x4006846")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsSetPosition;

	// Token: 0x04006FD8 RID: 28632
	[Token(Token = "0x4006847")]
	[FieldOffset(Offset = "0x3C")]
	private GameMain.SCENE m_currentScene;

	// Token: 0x04006FD9 RID: 28633
	[Token(Token = "0x4006848")]
	[FieldOffset(Offset = "0x40")]
	private GameMain.SCENE m_nextScene;

	// Token: 0x0200065D RID: 1629
	[Token(Token = "0x2001158")]
	private enum MODE
	{
		// Token: 0x04006FDB RID: 28635
		[Token(Token = "0x4019405")]
		NONE,
		// Token: 0x04006FDC RID: 28636
		[Token(Token = "0x4019406")]
		INIT_START_SCENE,
		// Token: 0x04006FDD RID: 28637
		[Token(Token = "0x4019407")]
		WAIT_START_SCENE,
		// Token: 0x04006FDE RID: 28638
		[Token(Token = "0x4019408")]
		INIT_FIELD_SCENE,
		// Token: 0x04006FDF RID: 28639
		[Token(Token = "0x4019409")]
		WAIT_FIELD_SCENE,
		// Token: 0x04006FE0 RID: 28640
		[Token(Token = "0x401940A")]
		WAIT_OPEN_SCENE,
		// Token: 0x04006FE1 RID: 28641
		[Token(Token = "0x401940B")]
		WAIT_CLEANUP,
		// Token: 0x04006FE2 RID: 28642
		[Token(Token = "0x401940C")]
		ERROR,
		// Token: 0x04006FE3 RID: 28643
		[Token(Token = "0x401940D")]
		END
	}

	// Token: 0x0200065E RID: 1630
	[Token(Token = "0x2001159")]
	private enum SCENE
	{
		// Token: 0x04006FE5 RID: 28645
		[Token(Token = "0x401940F")]
		NONE = -1,
		// Token: 0x04006FE6 RID: 28646
		[Token(Token = "0x4019410")]
		FIELD
	}
}
