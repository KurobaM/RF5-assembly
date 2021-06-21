using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Field;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityStandardAssets.ImageEffects;

// Token: 0x020008F3 RID: 2291
[Token(Token = "0x20005FF")]
public class TimelineControl : MonoBehaviour
{
	// Token: 0x170008B3 RID: 2227
	// (get) Token: 0x06003C33 RID: 15411 RVA: 0x000150A8 File Offset: 0x000132A8
	// (set) Token: 0x06003C34 RID: 15412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006F6")]
	public TimelineControl.PlayingState State
	{
		[Token(Token = "0x600328F")]
		[Address(RVA = "0x206BA60", Offset = "0x206BB61", VA = "0x206BA60")]
		get
		{
			return TimelineControl.PlayingState.Wait;
		}
		[Token(Token = "0x6003290")]
		[Address(RVA = "0x206BA70", Offset = "0x206BB71", VA = "0x206BA70")]
		private set
		{
		}
	}

	// Token: 0x06003C35 RID: 15413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003291")]
	[Address(RVA = "0x206BA80", Offset = "0x206BB81", VA = "0x206BA80")]
	public void Init()
	{
	}

	// Token: 0x06003C36 RID: 15414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003292")]
	[Address(RVA = "0x206BE10", Offset = "0x206BF11", VA = "0x206BE10")]
	public void Play()
	{
	}

	// Token: 0x06003C37 RID: 15415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003293")]
	[Address(RVA = "0x206BF20", Offset = "0x206C021", VA = "0x206BF20")]
	public void Pause()
	{
	}

	// Token: 0x06003C38 RID: 15416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003294")]
	[Address(RVA = "0x206BF90", Offset = "0x206C091", VA = "0x206BF90")]
	public void Resume()
	{
	}

	// Token: 0x06003C39 RID: 15417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003295")]
	[Address(RVA = "0x206C000", Offset = "0x206C101", VA = "0x206C000")]
	public void Stop()
	{
	}

	// Token: 0x06003C3A RID: 15418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003296")]
	[Address(RVA = "0x206C0E0", Offset = "0x206C1E1", VA = "0x206C0E0")]
	public void EndTimelineAddAction(UnityAction endCallback)
	{
	}

	// Token: 0x06003C3B RID: 15419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003297")]
	[Address(RVA = "0x206C170", Offset = "0x206C271", VA = "0x206C170")]
	public void InitEventAddAction(UnityAction action)
	{
	}

	// Token: 0x06003C3C RID: 15420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003298")]
	[Address(RVA = "0x206C200", Offset = "0x206C301", VA = "0x206C200")]
	public void PlayEventAddAction(UnityAction action)
	{
	}

	// Token: 0x06003C3D RID: 15421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003299")]
	[Address(RVA = "0x206C290", Offset = "0x206C391", VA = "0x206C290")]
	public void DisableEventAddAction(UnityAction action)
	{
	}

	// Token: 0x06003C3E RID: 15422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600329A")]
	[Address(RVA = "0x206BCB0", Offset = "0x206BDB1", VA = "0x206BCB0")]
	public void SetupActiveSceneCameraEffect()
	{
	}

	// Token: 0x06003C3F RID: 15423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600329B")]
	[Address(RVA = "0x206C320", Offset = "0x206C421", VA = "0x206C320")]
	public void PlayBGM(BGMID bgmId)
	{
	}

	// Token: 0x06003C40 RID: 15424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600329C")]
	[Address(RVA = "0x206C330", Offset = "0x206C431", VA = "0x206C330")]
	public void StopBGM(BGMID bgmId)
	{
	}

	// Token: 0x06003C41 RID: 15425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600329D")]
	[Address(RVA = "0x206C340", Offset = "0x206C441", VA = "0x206C340")]
	private void Awake()
	{
	}

	// Token: 0x06003C42 RID: 15426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600329E")]
	[Address(RVA = "0x206C350", Offset = "0x206C451", VA = "0x206C350")]
	private void Start()
	{
	}

	// Token: 0x06003C43 RID: 15427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600329F")]
	[Address(RVA = "0x206BEA0", Offset = "0x206BFA1", VA = "0x206BEA0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A6A40", Offset = "0x1A6B41")]
	private IEnumerator PlayAsync()
	{
		return null;
	}

	// Token: 0x06003C44 RID: 15428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032A0")]
	[Address(RVA = "0x206C4A0", Offset = "0x206C5A1", VA = "0x206C4A0")]
	private void OnDisable()
	{
	}

	// Token: 0x06003C45 RID: 15429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032A1")]
	[Address(RVA = "0x206C540", Offset = "0x206C641", VA = "0x206C540")]
	public TimelineControl()
	{
	}

	// Token: 0x06003C46 RID: 15430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032A2")]
	[Address(RVA = "0x206C550", Offset = "0x206C651", VA = "0x206C550")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6AB0", Offset = "0x1A6BB1")]
	private void <Init>b__15_0(PlayableDirector d)
	{
	}

	// Token: 0x06003C47 RID: 15431 RVA: 0x000150C0 File Offset: 0x000132C0
	[Token(Token = "0x60032A3")]
	[Address(RVA = "0x206C560", Offset = "0x206C661", VA = "0x206C560")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6AC0", Offset = "0x1A6BC1")]
	private bool <PlayAsync>b__29_0()
	{
		return default(bool);
	}

	// Token: 0x04007EA9 RID: 32425
	[Token(Token = "0x400725E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PlayableDirector playableDirector;

	// Token: 0x04007EAA RID: 32426
	[Token(Token = "0x400725F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FieldSceneData FieldSceneData;

	// Token: 0x04007EAB RID: 32427
	[Token(Token = "0x4007260")]
	[FieldOffset(Offset = "0x28")]
	public Camera TimelineCamera;

	// Token: 0x04007EAC RID: 32428
	[Token(Token = "0x4007261")]
	[FieldOffset(Offset = "0x30")]
	private FxPro FxPro;

	// Token: 0x04007EAD RID: 32429
	[Token(Token = "0x4007262")]
	[FieldOffset(Offset = "0x38")]
	public Bloom Bloom;

	// Token: 0x04007EAE RID: 32430
	[Token(Token = "0x4007263")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x16ED50", Offset = "0x16EE51")]
	[SerializeField]
	private TimelineControl.PlayingState _playingState;

	// Token: 0x04007EAF RID: 32431
	[Token(Token = "0x4007264")]
	[FieldOffset(Offset = "0x48")]
	private UnityAction _initAction;

	// Token: 0x04007EB0 RID: 32432
	[Token(Token = "0x4007265")]
	[FieldOffset(Offset = "0x50")]
	private UnityAction _playAction;

	// Token: 0x04007EB1 RID: 32433
	[Token(Token = "0x4007266")]
	[FieldOffset(Offset = "0x58")]
	private UnityAction _endAction;

	// Token: 0x04007EB2 RID: 32434
	[Token(Token = "0x4007267")]
	[FieldOffset(Offset = "0x60")]
	private UnityAction _disableAction;

	// Token: 0x04007EB3 RID: 32435
	[Token(Token = "0x4007268")]
	[FieldOffset(Offset = "0x68")]
	private bool _isInit;

	// Token: 0x020008F4 RID: 2292
	[Token(Token = "0x2001277")]
	public enum PlayingState
	{
		// Token: 0x04007EB5 RID: 32437
		[Token(Token = "0x40198B1")]
		Wait,
		// Token: 0x04007EB6 RID: 32438
		[Token(Token = "0x40198B2")]
		InitStart,
		// Token: 0x04007EB7 RID: 32439
		[Token(Token = "0x40198B3")]
		Init,
		// Token: 0x04007EB8 RID: 32440
		[Token(Token = "0x40198B4")]
		Playing,
		// Token: 0x04007EB9 RID: 32441
		[Token(Token = "0x40198B5")]
		Pause,
		// Token: 0x04007EBA RID: 32442
		[Token(Token = "0x40198B6")]
		Stop
	}

	// Token: 0x020008F5 RID: 2293
	[Token(Token = "0x2001278")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158DC0", Offset = "0x158EC1")]
	private sealed class <PlayAsync>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003C48 RID: 15432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748B")]
		[Address(RVA = "0x206C470", Offset = "0x206C571", VA = "0x206C470")]
		[DebuggerHidden]
		public <PlayAsync>d__29(int <>1__state)
		{
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748C")]
		[Address(RVA = "0x206C570", Offset = "0x206C671", VA = "0x206C570", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x000150D8 File Offset: 0x000132D8
		[Token(Token = "0x600748D")]
		[Address(RVA = "0x206C580", Offset = "0x206C681", VA = "0x206C580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06003C4B RID: 15435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7A")]
		private object Current
		{
			[Token(Token = "0x600748E")]
			[Address(RVA = "0x206C6F0", Offset = "0x206C7F1", VA = "0x206C6F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748F")]
		[Address(RVA = "0x206C700", Offset = "0x206C801", VA = "0x206C700", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7B")]
		private object Current
		{
			[Token(Token = "0x6007490")]
			[Address(RVA = "0x206C760", Offset = "0x206C861", VA = "0x206C760", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007EBB RID: 32443
		[Token(Token = "0x40198B7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007EBC RID: 32444
		[Token(Token = "0x40198B8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007EBD RID: 32445
		[Token(Token = "0x40198B9")]
		[FieldOffset(Offset = "0x20")]
		public TimelineControl <>4__this;
	}
}
