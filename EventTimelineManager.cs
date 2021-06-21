using System;
using Il2CppDummyDll;
using Loader;
using RF5Input;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

// Token: 0x020008D1 RID: 2257
[Token(Token = "0x20005DF")]
public class EventTimelineManager : SingletonMonoBehaviour<EventTimelineManager>
{
	// Token: 0x06003B94 RID: 15252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031F6")]
	[Address(RVA = "0x21BC030", Offset = "0x21BC131", VA = "0x21BC030")]
	private void Start()
	{
	}

	// Token: 0x06003B95 RID: 15253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031F7")]
	[Address(RVA = "0x21BC0F0", Offset = "0x21BC1F1", VA = "0x21BC0F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06003B96 RID: 15254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031F8")]
	[Address(RVA = "0x21BC160", Offset = "0x21BC261", VA = "0x21BC160")]
	public void OnSetupTimeLine(string timelineName, bool IsEventScriptCalled = false)
	{
	}

	// Token: 0x06003B97 RID: 15255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031F9")]
	[Address(RVA = "0x21BC3F0", Offset = "0x21BC4F1", VA = "0x21BC3F0")]
	public void OnStartTimeLine()
	{
	}

	// Token: 0x06003B98 RID: 15256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031FA")]
	[Address(RVA = "0x21BC400", Offset = "0x21BC501", VA = "0x21BC400")]
	public void OnStopTimeLine()
	{
	}

	// Token: 0x06003B99 RID: 15257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031FB")]
	[Address(RVA = "0x21BC470", Offset = "0x21BC571", VA = "0x21BC470")]
	public void OnPlayableDirectorEnd()
	{
	}

	// Token: 0x06003B9A RID: 15258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031FC")]
	[Address(RVA = "0x21BC560", Offset = "0x21BC661", VA = "0x21BC560")]
	private void OnPlayableDirectorStopped(PlayableDirector aDirector)
	{
	}

	// Token: 0x06003B9B RID: 15259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031FD")]
	[Address(RVA = "0x21BC5E0", Offset = "0x21BC6E1", VA = "0x21BC5E0")]
	public void Pause(bool _endOfDialogClose)
	{
	}

	// Token: 0x06003B9C RID: 15260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031FE")]
	[Address(RVA = "0x21BC690", Offset = "0x21BC791", VA = "0x21BC690")]
	public void ResumeTimeline()
	{
	}

	// Token: 0x06003B9D RID: 15261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031FF")]
	[Address(RVA = "0x21BC7E0", Offset = "0x21BC8E1", VA = "0x21BC7E0")]
	public EventTimelineManager()
	{
	}

	// Token: 0x06003B9E RID: 15262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003200")]
	[Address(RVA = "0x21BC870", Offset = "0x21BC971", VA = "0x21BC870")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A66B0", Offset = "0x1A67B1")]
	private void <Start>b__13_0(AssetHandle<GameObject> _handle)
	{
	}

	// Token: 0x04007E40 RID: 32320
	[Token(Token = "0x40071FA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject TimelineObject;

	// Token: 0x04007E41 RID: 32321
	[Token(Token = "0x40071FB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool loopStart;

	// Token: 0x04007E42 RID: 32322
	[Token(Token = "0x40071FC")]
	[FieldOffset(Offset = "0x24")]
	public float timeOfLoopEnd;

	// Token: 0x04007E43 RID: 32323
	[Token(Token = "0x40071FD")]
	[FieldOffset(Offset = "0x28")]
	public TimeMachineCondition condition;

	// Token: 0x04007E44 RID: 32324
	[Token(Token = "0x40071FE")]
	[FieldOffset(Offset = "0x30")]
	private TimelineControl _timelineControl;

	// Token: 0x04007E45 RID: 32325
	[Token(Token = "0x40071FF")]
	[FieldOffset(Offset = "0x38")]
	public PlayableDirector director;

	// Token: 0x04007E46 RID: 32326
	[Token(Token = "0x4007200")]
	[FieldOffset(Offset = "0x40")]
	public bool pause;

	// Token: 0x04007E47 RID: 32327
	[Token(Token = "0x4007201")]
	[FieldOffset(Offset = "0x41")]
	public bool endOfDialogClose;

	// Token: 0x04007E48 RID: 32328
	[Token(Token = "0x4007202")]
	[FieldOffset(Offset = "0x44")]
	public int LoaderId;

	// Token: 0x04007E49 RID: 32329
	[Token(Token = "0x4007203")]
	[FieldOffset(Offset = "0x48")]
	private MovieRoomSkip MovieSkip;

	// Token: 0x04007E4A RID: 32330
	[Token(Token = "0x4007204")]
	[FieldOffset(Offset = "0x50")]
	private readonly int MOVIE_SKIP_ID;

	// Token: 0x04007E4B RID: 32331
	[Token(Token = "0x4007205")]
	private const Key ACTIVE_KEY = Key.B;

	// Token: 0x04007E4C RID: 32332
	[Token(Token = "0x4007206")]
	[FieldOffset(Offset = "0x58")]
	public UnityEvent OnSetupEvent;

	// Token: 0x020008D2 RID: 2258
	[Token(Token = "0x2001275")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158DA0", Offset = "0x158EA1")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x06003B9F RID: 15263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007485")]
		[Address(RVA = "0x21BC3E0", Offset = "0x21BC4E1", VA = "0x21BC3E0")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007486")]
		[Address(RVA = "0x21BC910", Offset = "0x21BCA11", VA = "0x21BC910")]
		internal void <OnSetupTimeLine>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007487")]
		[Address(RVA = "0x21BCE40", Offset = "0x21BCF41", VA = "0x21BCE40")]
		internal void <OnSetupTimeLine>b__3()
		{
		}

		// Token: 0x04007E4D RID: 32333
		[Token(Token = "0x40198AB")]
		[FieldOffset(Offset = "0x10")]
		public EventTimelineManager <>4__this;

		// Token: 0x04007E4E RID: 32334
		[Token(Token = "0x40198AC")]
		[FieldOffset(Offset = "0x18")]
		public bool IsEventScriptCalled;

		// Token: 0x04007E4F RID: 32335
		[Token(Token = "0x40198AD")]
		[FieldOffset(Offset = "0x20")]
		public UnityAction <>9__3;
	}

	// Token: 0x020008D3 RID: 2259
	[Token(Token = "0x2001276")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158DB0", Offset = "0x158EB1")]
	private sealed class <>c__DisplayClass15_1
	{
		// Token: 0x06003BA2 RID: 15266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007488")]
		[Address(RVA = "0x21BCE30", Offset = "0x21BCF31", VA = "0x21BCE30")]
		public <>c__DisplayClass15_1()
		{
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007489")]
		[Address(RVA = "0x21BCEC0", Offset = "0x21BCFC1", VA = "0x21BCEC0")]
		internal void <OnSetupTimeLine>b__1()
		{
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748A")]
		[Address(RVA = "0x21BCF80", Offset = "0x21BD081", VA = "0x21BCF80")]
		internal void <OnSetupTimeLine>b__2()
		{
		}

		// Token: 0x04007E50 RID: 32336
		[Token(Token = "0x40198AE")]
		[FieldOffset(Offset = "0x10")]
		public MovieRoomSkip skip;

		// Token: 0x04007E51 RID: 32337
		[Token(Token = "0x40198AF")]
		[FieldOffset(Offset = "0x18")]
		public EventTimelineManager.<>c__DisplayClass15_0 CS$<>8__locals1;
	}
}
