using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

// Token: 0x0200065F RID: 1631
[Token(Token = "0x200048E")]
public class MainScene : SingletonMonoBehaviour<MainScene>
{
	// Token: 0x06002883 RID: 10371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002245")]
	[Address(RVA = "0x1F16860", Offset = "0x1F16961", VA = "0x1F16860", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06002884 RID: 10372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002246")]
	[Address(RVA = "0x1F168E0", Offset = "0x1F169E1", VA = "0x1F168E0")]
	private void Start()
	{
	}

	// Token: 0x06002885 RID: 10373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002247")]
	[Address(RVA = "0x1F16990", Offset = "0x1F16A91", VA = "0x1F16990")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002886 RID: 10374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002248")]
	[Address(RVA = "0x1F169A0", Offset = "0x1F16AA1", VA = "0x1F169A0")]
	public void AllDestroy()
	{
	}

	// Token: 0x06002887 RID: 10375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002249")]
	[Address(RVA = "0x1F169B0", Offset = "0x1F16AB1", VA = "0x1F169B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A2010", Offset = "0x1A2111")]
	private IEnumerator UnloadOperation()
	{
		return null;
	}

	// Token: 0x06002888 RID: 10376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600224A")]
	[Address(RVA = "0x1F16A60", Offset = "0x1F16B61", VA = "0x1F16A60")]
	private void Update()
	{
	}

	// Token: 0x06002889 RID: 10377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600224B")]
	[Address(RVA = "0x1F17320", Offset = "0x1F17421", VA = "0x1F17320")]
	public static void LoadScene(MainScene.SCENE nextScene)
	{
	}

	// Token: 0x0600288A RID: 10378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600224C")]
	[Address(RVA = "0x1F17390", Offset = "0x1F17491", VA = "0x1F17390")]
	private void InstanceLoadScene(MainScene.SCENE nextScene)
	{
	}

	// Token: 0x0600288B RID: 10379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600224D")]
	[Address(RVA = "0x1F173A0", Offset = "0x1F174A1", VA = "0x1F173A0")]
	public static void SetEnableCamera(bool value)
	{
	}

	// Token: 0x0600288C RID: 10380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600224E")]
	[Address(RVA = "0x1F17410", Offset = "0x1F17511", VA = "0x1F17410")]
	public static void SetEnableAudioListener(bool value)
	{
	}

	// Token: 0x0600288D RID: 10381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600224F")]
	[Address(RVA = "0x1F17480", Offset = "0x1F17581", VA = "0x1F17480")]
	public MainScene()
	{
	}

	// Token: 0x0600288E RID: 10382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002250")]
	[Address(RVA = "0x1F174E0", Offset = "0x1F175E1", VA = "0x1F174E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2080", Offset = "0x1A2181")]
	private void <Update>b__20_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04006FE7 RID: 28647
	[Token(Token = "0x4006849")]
	[FieldOffset(Offset = "0x18")]
	private MainScene.MODE m_mode;

	// Token: 0x04006FE8 RID: 28648
	[Token(Token = "0x400684A")]
	[FieldOffset(Offset = "0x1C")]
	private MainScene.SCENE m_currentScene;

	// Token: 0x04006FE9 RID: 28649
	[Token(Token = "0x400684B")]
	[FieldOffset(Offset = "0x20")]
	private MainScene.SCENE m_nextScene;

	// Token: 0x04006FEA RID: 28650
	[Token(Token = "0x400684C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Camera m_Camera;

	// Token: 0x04006FEB RID: 28651
	[Token(Token = "0x400684D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioListener m_AudioListener;

	// Token: 0x04006FEC RID: 28652
	[Token(Token = "0x400684E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public string[] m_SceneNames;

	// Token: 0x04006FED RID: 28653
	[Token(Token = "0x400684F")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_FadeCanvas_GameObject;

	// Token: 0x04006FEE RID: 28654
	[Token(Token = "0x4006850")]
	[FieldOffset(Offset = "0x48")]
	private AsyncOperationHandle<SceneInstance> m_aoHandle;

	// Token: 0x04006FEF RID: 28655
	[Token(Token = "0x4006851")]
	[FieldOffset(Offset = "0x60")]
	private Scene m_activeScene;

	// Token: 0x04006FF0 RID: 28656
	[Token(Token = "0x4006852")]
	[FieldOffset(Offset = "0x64")]
	private bool UnloadDone;

	// Token: 0x04006FF1 RID: 28657
	[Token(Token = "0x4006853")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_LogoPrefab;

	// Token: 0x04006FF2 RID: 28658
	[Token(Token = "0x4006854")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsLogoWait;

	// Token: 0x04006FF3 RID: 28659
	[Token(Token = "0x4006855")]
	private const int LogoLoadPriority = 100;

	// Token: 0x02000660 RID: 1632
	[Token(Token = "0x200115A")]
	private enum MODE
	{
		// Token: 0x04006FF5 RID: 28661
		[Token(Token = "0x4019412")]
		NONE,
		// Token: 0x04006FF6 RID: 28662
		[Token(Token = "0x4019413")]
		INIT,
		// Token: 0x04006FF7 RID: 28663
		[Token(Token = "0x4019414")]
		INIT_SYSTEMDATA_LOAD,
		// Token: 0x04006FF8 RID: 28664
		[Token(Token = "0x4019415")]
		WAIT_SYSTEMDATA_LOAD,
		// Token: 0x04006FF9 RID: 28665
		[Token(Token = "0x4019416")]
		INIT_LOGO_LOAD,
		// Token: 0x04006FFA RID: 28666
		[Token(Token = "0x4019417")]
		WAIT_LOGO_LOAD,
		// Token: 0x04006FFB RID: 28667
		[Token(Token = "0x4019418")]
		INIT_SYSTEM_STARTUP,
		// Token: 0x04006FFC RID: 28668
		[Token(Token = "0x4019419")]
		WAIT_SYSTEM_STARTUP,
		// Token: 0x04006FFD RID: 28669
		[Token(Token = "0x401941A")]
		INIT_DOWNLOAD,
		// Token: 0x04006FFE RID: 28670
		[Token(Token = "0x401941B")]
		WAIT_DOWNLOAD,
		// Token: 0x04006FFF RID: 28671
		[Token(Token = "0x401941C")]
		INIT_GAMEDATA,
		// Token: 0x04007000 RID: 28672
		[Token(Token = "0x401941D")]
		WAIT_GAMEDATA,
		// Token: 0x04007001 RID: 28673
		[Token(Token = "0x401941E")]
		INIT_SCENE_LOAD,
		// Token: 0x04007002 RID: 28674
		[Token(Token = "0x401941F")]
		WAIT_SCENE_LOAD,
		// Token: 0x04007003 RID: 28675
		[Token(Token = "0x4019420")]
		INIT_SCENE_UNLOAD,
		// Token: 0x04007004 RID: 28676
		[Token(Token = "0x4019421")]
		WAIT_SCENE_UNLOAD,
		// Token: 0x04007005 RID: 28677
		[Token(Token = "0x4019422")]
		ERROR,
		// Token: 0x04007006 RID: 28678
		[Token(Token = "0x4019423")]
		END
	}

	// Token: 0x02000661 RID: 1633
	[Token(Token = "0x200115B")]
	public enum SCENE
	{
		// Token: 0x04007008 RID: 28680
		[Token(Token = "0x4019425")]
		NONE = -1,
		// Token: 0x04007009 RID: 28681
		[Token(Token = "0x4019426")]
		TITLE,
		// Token: 0x0400700A RID: 28682
		[Token(Token = "0x4019427")]
		GAME
	}

	// Token: 0x02000662 RID: 1634
	[Token(Token = "0x200115C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1581E0", Offset = "0x1582E1")]
	private sealed class <UnloadOperation>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600288F RID: 10383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007129")]
		[Address(RVA = "0x1F16A30", Offset = "0x1F16B31", VA = "0x1F16A30")]
		[DebuggerHidden]
		public <UnloadOperation>d__19(int <>1__state)
		{
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600712A")]
		[Address(RVA = "0x1F175A0", Offset = "0x1F176A1", VA = "0x1F175A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00010020 File Offset: 0x0000E220
		[Token(Token = "0x600712B")]
		[Address(RVA = "0x1F175B0", Offset = "0x1F176B1", VA = "0x1F175B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D07")]
		private object Current
		{
			[Token(Token = "0x600712C")]
			[Address(RVA = "0x1F178A0", Offset = "0x1F179A1", VA = "0x1F178A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600712D")]
		[Address(RVA = "0x1F178B0", Offset = "0x1F179B1", VA = "0x1F178B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D08")]
		private object Current
		{
			[Token(Token = "0x600712E")]
			[Address(RVA = "0x1F17910", Offset = "0x1F17A11", VA = "0x1F17910", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400700B RID: 28683
		[Token(Token = "0x4019428")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400700C RID: 28684
		[Token(Token = "0x4019429")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400700D RID: 28685
		[Token(Token = "0x401942A")]
		[FieldOffset(Offset = "0x20")]
		public MainScene <>4__this;
	}
}
