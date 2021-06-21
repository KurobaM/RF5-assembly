using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;
using UnityEngine.UI;

// Token: 0x02000A80 RID: 2688
[Token(Token = "0x200070E")]
public class MovieRoom : UIScrollBoxBase
{
	// Token: 0x1700096C RID: 2412
	// (get) Token: 0x0600460E RID: 17934 RVA: 0x000171D8 File Offset: 0x000153D8
	// (set) Token: 0x0600460F RID: 17935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000792")]
	public static bool IsActive
	{
		[Token(Token = "0x6003AAB")]
		[Address(RVA = "0x1E12FC0", Offset = "0x1E130C1", VA = "0x1E12FC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7CD0", Offset = "0x1A7DD1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003AAC")]
		[Address(RVA = "0x1E13030", Offset = "0x1E13131", VA = "0x1E13030")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7CE0", Offset = "0x1A7DE1")]
		private set
		{
		}
	}

	// Token: 0x1700096D RID: 2413
	// (get) Token: 0x06004610 RID: 17936 RVA: 0x000171F0 File Offset: 0x000153F0
	// (set) Token: 0x06004611 RID: 17937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000793")]
	public static int NowPlayingNpc
	{
		[Token(Token = "0x6003AAD")]
		[Address(RVA = "0x1E130A0", Offset = "0x1E131A1", VA = "0x1E130A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7CF0", Offset = "0x1A7DF1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003AAE")]
		[Address(RVA = "0x1E13110", Offset = "0x1E13211", VA = "0x1E13110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7D00", Offset = "0x1A7E01")]
		private set
		{
		}
	}

	// Token: 0x06004612 RID: 17938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AAF")]
	[Address(RVA = "0x1E13180", Offset = "0x1E13281", VA = "0x1E13180", Slot = "8")]
	protected override void Start()
	{
	}

	// Token: 0x06004613 RID: 17939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB0")]
	[Address(RVA = "0x1E13AF0", Offset = "0x1E13BF1", VA = "0x1E13AF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004614 RID: 17940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB1")]
	[Address(RVA = "0x1E13BC0", Offset = "0x1E13CC1", VA = "0x1E13BC0")]
	private void Close()
	{
	}

	// Token: 0x06004615 RID: 17941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB2")]
	[Address(RVA = "0x1E13F30", Offset = "0x1E14031", VA = "0x1E13F30", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x06004616 RID: 17942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB3")]
	[Address(RVA = "0x1E140B0", Offset = "0x1E141B1", VA = "0x1E140B0")]
	private void InputSubmit()
	{
	}

	// Token: 0x06004617 RID: 17943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB4")]
	[Address(RVA = "0x1E148F0", Offset = "0x1E149F1", VA = "0x1E148F0")]
	public void OnSlotTouch(UIMovieSlot _slot)
	{
	}

	// Token: 0x06004618 RID: 17944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB5")]
	[Address(RVA = "0x1E13720", Offset = "0x1E13821", VA = "0x1E13720")]
	private void UpdateFocusMovie()
	{
	}

	// Token: 0x06004619 RID: 17945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003AB6")]
	[Address(RVA = "0x1E14A50", Offset = "0x1E14B51", VA = "0x1E14A50")]
	private Sprite GetMoviePreviewSprite()
	{
		return null;
	}

	// Token: 0x0600461A RID: 17946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003AB7")]
	[Address(RVA = "0x1E14CE0", Offset = "0x1E14DE1", VA = "0x1E14CE0")]
	public string GetMovieName(int _index)
	{
		return null;
	}

	// Token: 0x0600461B RID: 17947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003AB8")]
	[Address(RVA = "0x1E149D0", Offset = "0x1E14AD1", VA = "0x1E149D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A7D10", Offset = "0x1A7E11")]
	private IEnumerator MoviePreviewImageFlash()
	{
		return null;
	}

	// Token: 0x0600461C RID: 17948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AB9")]
	[Address(RVA = "0x1E14230", Offset = "0x1E14331", VA = "0x1E14230")]
	private void PlayMovie(MovieRoomData _data)
	{
	}

	// Token: 0x0600461D RID: 17949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABA")]
	[Address(RVA = "0x1E14F80", Offset = "0x1E15081", VA = "0x1E14F80")]
	private void EndMovie(MovieRoomData _data)
	{
	}

	// Token: 0x0600461E RID: 17950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABB")]
	[Address(RVA = "0x1E144A0", Offset = "0x1E145A1", VA = "0x1E144A0")]
	private void PlayShortPlay(MovieRoomData _data)
	{
	}

	// Token: 0x0600461F RID: 17951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003ABC")]
	[Address(RVA = "0x1E15050", Offset = "0x1E15151", VA = "0x1E15050")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A7D80", Offset = "0x1A7E81")]
	private IEnumerator CheckEnableSkipShortPlay(MovieRoomSkip _skip, MovieID _id)
	{
		return null;
	}

	// Token: 0x06004620 RID: 17952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABD")]
	[Address(RVA = "0x1E15120", Offset = "0x1E15221", VA = "0x1E15120")]
	private void EndShortPlay(MovieRoomData _data)
	{
	}

	// Token: 0x06004621 RID: 17953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABE")]
	[Address(RVA = "0x1E15300", Offset = "0x1E15401", VA = "0x1E15300")]
	private void PlayStaffRoll(string _script)
	{
	}

	// Token: 0x06004622 RID: 17954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ABF")]
	[Address(RVA = "0x1E15510", Offset = "0x1E15611", VA = "0x1E15510")]
	private void EndStaffRoll()
	{
	}

	// Token: 0x06004623 RID: 17955 RVA: 0x00017208 File Offset: 0x00015408
	[Token(Token = "0x6003AC0")]
	[Address(RVA = "0x1E15030", Offset = "0x1E15131", VA = "0x1E15030")]
	private bool IsMarriage(MovieID _id)
	{
		return default(bool);
	}

	// Token: 0x06004624 RID: 17956 RVA: 0x00017220 File Offset: 0x00015420
	[Token(Token = "0x6003AC1")]
	[Address(RVA = "0x1E155E0", Offset = "0x1E156E1", VA = "0x1E155E0", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x06004625 RID: 17957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC2")]
	[Address(RVA = "0x1E155F0", Offset = "0x1E156F1", VA = "0x1E155F0", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x06004626 RID: 17958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC3")]
	[Address(RVA = "0x1E15690", Offset = "0x1E15791", VA = "0x1E15690", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x06004627 RID: 17959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC4")]
	[Address(RVA = "0x1E156A0", Offset = "0x1E157A1", VA = "0x1E156A0")]
	public MovieRoom()
	{
	}

	// Token: 0x06004629 RID: 17961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC6")]
	[Address(RVA = "0x1E157E0", Offset = "0x1E158E1", VA = "0x1E157E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7DF0", Offset = "0x1A7EF1")]
	private void <Start>b__27_0(AssetHandle<GameObject> _handle)
	{
	}

	// Token: 0x0600462A RID: 17962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC7")]
	[Address(RVA = "0x1E15870", Offset = "0x1E15971", VA = "0x1E15870")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7E00", Offset = "0x1A7F01")]
	private void <Start>b__27_1(AssetHandle<SpriteAtlas> _handle)
	{
	}

	// Token: 0x0600462B RID: 17963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC8")]
	[Address(RVA = "0x1E15940", Offset = "0x1E15A41", VA = "0x1E15940")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7E10", Offset = "0x1A7F11")]
	private void <EndMovie>b__38_0()
	{
	}

	// Token: 0x0600462C RID: 17964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AC9")]
	[Address(RVA = "0x1E15A70", Offset = "0x1E15B71", VA = "0x1E15A70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7E20", Offset = "0x1A7F21")]
	private void <EndMovie>b__38_1()
	{
	}

	// Token: 0x0600462D RID: 17965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ACA")]
	[Address(RVA = "0x1E15AD0", Offset = "0x1E15BD1", VA = "0x1E15AD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7E30", Offset = "0x1A7F31")]
	private void <EndStaffRoll>b__43_0()
	{
	}

	// Token: 0x0600462E RID: 17966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ACB")]
	[Address(RVA = "0x1E15BD0", Offset = "0x1E15CD1", VA = "0x1E15BD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7E40", Offset = "0x1A7F41")]
	private void <EndStaffRoll>b__43_1()
	{
	}

	// Token: 0x0600462F RID: 17967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ACC")]
	[Address(RVA = "0x1E15DD0", Offset = "0x1E15ED1", VA = "0x1E15DD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7E50", Offset = "0x1A7F51")]
	private void <EndStaffRoll>b__43_2()
	{
	}

	// Token: 0x0400A518 RID: 42264
	[Token(Token = "0x4007CBF")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x172F80", Offset = "0x173081")]
	private static bool <IsActive>k__BackingField;

	// Token: 0x0400A519 RID: 42265
	[Token(Token = "0x4007CC0")]
	[FieldOffset(Offset = "0x4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x172F90", Offset = "0x173091")]
	private static int <NowPlayingNpc>k__BackingField;

	// Token: 0x0400A51A RID: 42266
	[Token(Token = "0x4007CC1")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text movieNameText;

	// Token: 0x0400A51B RID: 42267
	[Token(Token = "0x4007CC2")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text movieContentText;

	// Token: 0x0400A51C RID: 42268
	[Token(Token = "0x4007CC3")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image previewImage;

	// Token: 0x0400A51D RID: 42269
	[Token(Token = "0x4007CC4")]
	[FieldOffset(Offset = "0x80")]
	private SpriteAtlas movieSpriteAtlas;

	// Token: 0x0400A51E RID: 42270
	[Token(Token = "0x4007CC5")]
	private const int MOVIE_SPRITE_ATLAS_ID = 19766;

	// Token: 0x0400A51F RID: 42271
	[Token(Token = "0x4007CC6")]
	private const string LOCKED_PREVIEW_IMAGE = "sn_dammy";

	// Token: 0x0400A520 RID: 42272
	[Token(Token = "0x4007CC7")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<string, Sprite> movieSpriteDict;

	// Token: 0x0400A521 RID: 42273
	[Token(Token = "0x4007CC8")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float flashSpeed;

	// Token: 0x0400A522 RID: 42274
	[Token(Token = "0x4007CC9")]
	[FieldOffset(Offset = "0x98")]
	private MovieRoomSkip movieSkip;

	// Token: 0x0400A523 RID: 42275
	[Token(Token = "0x4007CCA")]
	[FieldOffset(Offset = "0xA0")]
	private readonly int MOVIE_SKIP_ID;

	// Token: 0x0400A524 RID: 42276
	[Token(Token = "0x4007CCB")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject uiObject;

	// Token: 0x0400A525 RID: 42277
	[Token(Token = "0x4007CCC")]
	[FieldOffset(Offset = "0xB0")]
	private MovieRoomDataTable movieRoomDataTable;

	// Token: 0x0400A526 RID: 42278
	[Token(Token = "0x4007CCD")]
	[FieldOffset(Offset = "0xB8")]
	private BGMID currentBGM;

	// Token: 0x0400A527 RID: 42279
	[Token(Token = "0x4007CCE")]
	[FieldOffset(Offset = "0xBC")]
	private VariationNo playerVariation;

	// Token: 0x0400A528 RID: 42280
	[Token(Token = "0x4007CCF")]
	[FieldOffset(Offset = "0xC0")]
	private VariationNo npcVariation;

	// Token: 0x0400A529 RID: 42281
	[Token(Token = "0x4007CD0")]
	[FieldOffset(Offset = "0xC4")]
	private Vector3 playerPos;

	// Token: 0x0400A52A RID: 42282
	[Token(Token = "0x4007CD1")]
	[FieldOffset(Offset = "0xD0")]
	private Quaternion playerRot;

	// Token: 0x0400A52B RID: 42283
	[Token(Token = "0x4007CD2")]
	[FieldOffset(Offset = "0xE0")]
	private bool isPlaying;

	// Token: 0x0400A52C RID: 42284
	[Token(Token = "0x4007CD3")]
	[FieldOffset(Offset = "0xE4")]
	private float startInputDelay;

	// Token: 0x02000A81 RID: 2689
	[Token(Token = "0x20012F4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159160", Offset = "0x159261")]
	private sealed class <MoviePreviewImageFlash>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004630 RID: 17968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007647")]
		[Address(RVA = "0x1E14ED0", Offset = "0x1E14FD1", VA = "0x1E14ED0")]
		[DebuggerHidden]
		public <MoviePreviewImageFlash>d__36(int <>1__state)
		{
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007648")]
		[Address(RVA = "0x1E16CD0", Offset = "0x1E16DD1", VA = "0x1E16CD0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x00017238 File Offset: 0x00015438
		[Token(Token = "0x6007649")]
		[Address(RVA = "0x1E16CE0", Offset = "0x1E16DE1", VA = "0x1E16CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06004633 RID: 17971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D97")]
		private object Current
		{
			[Token(Token = "0x600764A")]
			[Address(RVA = "0x1E16EF0", Offset = "0x1E16FF1", VA = "0x1E16EF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764B")]
		[Address(RVA = "0x1E16F00", Offset = "0x1E17001", VA = "0x1E16F00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06004635 RID: 17973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D98")]
		private object Current
		{
			[Token(Token = "0x600764C")]
			[Address(RVA = "0x1E16F60", Offset = "0x1E17061", VA = "0x1E16F60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A52D RID: 42285
		[Token(Token = "0x401B4BC")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A52E RID: 42286
		[Token(Token = "0x401B4BD")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A52F RID: 42287
		[Token(Token = "0x401B4BE")]
		[FieldOffset(Offset = "0x20")]
		public MovieRoom <>4__this;

		// Token: 0x0400A530 RID: 42288
		[Token(Token = "0x401B4BF")]
		[FieldOffset(Offset = "0x28")]
		private float <rate>5__2;
	}

	// Token: 0x02000A82 RID: 2690
	[Token(Token = "0x20012F5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159170", Offset = "0x159271")]
	private sealed class <>c__DisplayClass37_0
	{
		// Token: 0x06004636 RID: 17974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764D")]
		[Address(RVA = "0x1E14F00", Offset = "0x1E15001", VA = "0x1E14F00")]
		public <>c__DisplayClass37_0()
		{
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764E")]
		[Address(RVA = "0x1E15F20", Offset = "0x1E16021", VA = "0x1E15F20")]
		internal void <PlayMovie>b__0()
		{
		}

		// Token: 0x0400A531 RID: 42289
		[Token(Token = "0x401B4C0")]
		[FieldOffset(Offset = "0x10")]
		public MovieRoomSkip skip;

		// Token: 0x0400A532 RID: 42290
		[Token(Token = "0x401B4C1")]
		[FieldOffset(Offset = "0x18")]
		public MovieRoom <>4__this;

		// Token: 0x0400A533 RID: 42291
		[Token(Token = "0x401B4C2")]
		[FieldOffset(Offset = "0x20")]
		public MovieRoomData _data;
	}

	// Token: 0x02000A83 RID: 2691
	[Token(Token = "0x20012F6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159180", Offset = "0x159281")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004639 RID: 17977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007650")]
		[Address(RVA = "0x1E15EA0", Offset = "0x1E15FA1", VA = "0x1E15EA0")]
		public <>c()
		{
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007651")]
		[Address(RVA = "0x1E15EB0", Offset = "0x1E15FB1", VA = "0x1E15EB0")]
		internal void <PlayMovie>b__37_1()
		{
		}

		// Token: 0x0400A534 RID: 42292
		[Token(Token = "0x401B4C3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MovieRoom.<>c <>9;

		// Token: 0x0400A535 RID: 42293
		[Token(Token = "0x401B4C4")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction <>9__37_1;
	}

	// Token: 0x02000A84 RID: 2692
	[Token(Token = "0x20012F7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159190", Offset = "0x159291")]
	private sealed class <>c__DisplayClass39_0
	{
		// Token: 0x0600463B RID: 17979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007652")]
		[Address(RVA = "0x1E15020", Offset = "0x1E15121", VA = "0x1E15020")]
		public <>c__DisplayClass39_0()
		{
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007653")]
		[Address(RVA = "0x1E16060", Offset = "0x1E16161", VA = "0x1E16060")]
		internal void <PlayShortPlay>b__0()
		{
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007654")]
		[Address(RVA = "0x1E160F0", Offset = "0x1E161F1", VA = "0x1E160F0")]
		internal void <PlayShortPlay>b__1()
		{
		}

		// Token: 0x0400A536 RID: 42294
		[Token(Token = "0x401B4C5")]
		[FieldOffset(Offset = "0x10")]
		public MovieRoomSkip skip;

		// Token: 0x0400A537 RID: 42295
		[Token(Token = "0x401B4C6")]
		[FieldOffset(Offset = "0x18")]
		public MovieRoom <>4__this;

		// Token: 0x0400A538 RID: 42296
		[Token(Token = "0x401B4C7")]
		[FieldOffset(Offset = "0x20")]
		public MovieRoomData _data;
	}

	// Token: 0x02000A85 RID: 2693
	[Token(Token = "0x20012F8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1591A0", Offset = "0x1592A1")]
	private sealed class <CheckEnableSkipShortPlay>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600463E RID: 17982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007655")]
		[Address(RVA = "0x1E150F0", Offset = "0x1E151F1", VA = "0x1E150F0")]
		[DebuggerHidden]
		public <CheckEnableSkipShortPlay>d__40(int <>1__state)
		{
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007656")]
		[Address(RVA = "0x1E16B00", Offset = "0x1E16C01", VA = "0x1E16B00", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x00017250 File Offset: 0x00015450
		[Token(Token = "0x6007657")]
		[Address(RVA = "0x1E16B10", Offset = "0x1E16C11", VA = "0x1E16B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06004641 RID: 17985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D99")]
		private object Current
		{
			[Token(Token = "0x6007658")]
			[Address(RVA = "0x1E16C50", Offset = "0x1E16D51", VA = "0x1E16C50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007659")]
		[Address(RVA = "0x1E16C60", Offset = "0x1E16D61", VA = "0x1E16C60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06004643 RID: 17987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D9A")]
		private object Current
		{
			[Token(Token = "0x600765A")]
			[Address(RVA = "0x1E16CC0", Offset = "0x1E16DC1", VA = "0x1E16CC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A539 RID: 42297
		[Token(Token = "0x401B4C8")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A53A RID: 42298
		[Token(Token = "0x401B4C9")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A53B RID: 42299
		[Token(Token = "0x401B4CA")]
		[FieldOffset(Offset = "0x20")]
		public MovieRoom <>4__this;

		// Token: 0x0400A53C RID: 42300
		[Token(Token = "0x401B4CB")]
		[FieldOffset(Offset = "0x28")]
		public MovieID _id;

		// Token: 0x0400A53D RID: 42301
		[Token(Token = "0x401B4CC")]
		[FieldOffset(Offset = "0x30")]
		public MovieRoomSkip _skip;
	}

	// Token: 0x02000A86 RID: 2694
	[Token(Token = "0x20012F9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1591B0", Offset = "0x1592B1")]
	private sealed class <>c__DisplayClass41_0
	{
		// Token: 0x06004644 RID: 17988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765B")]
		[Address(RVA = "0x1E152F0", Offset = "0x1E153F1", VA = "0x1E152F0")]
		public <>c__DisplayClass41_0()
		{
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765C")]
		[Address(RVA = "0x1E163D0", Offset = "0x1E164D1", VA = "0x1E163D0")]
		internal void <EndShortPlay>b__0()
		{
		}

		// Token: 0x0400A53E RID: 42302
		[Token(Token = "0x401B4CD")]
		[FieldOffset(Offset = "0x10")]
		public MovieRoom <>4__this;

		// Token: 0x0400A53F RID: 42303
		[Token(Token = "0x401B4CE")]
		[FieldOffset(Offset = "0x18")]
		public MovieRoomData _data;
	}

	// Token: 0x02000A87 RID: 2695
	[Token(Token = "0x20012FA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1591C0", Offset = "0x1592C1")]
	private sealed class <>c__DisplayClass42_0
	{
		// Token: 0x06004646 RID: 17990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765D")]
		[Address(RVA = "0x1E15500", Offset = "0x1E15601", VA = "0x1E15500")]
		public <>c__DisplayClass42_0()
		{
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765E")]
		[Address(RVA = "0x1E16840", Offset = "0x1E16941", VA = "0x1E16840")]
		internal void <PlayStaffRoll>b__0()
		{
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765F")]
		[Address(RVA = "0x1E168D0", Offset = "0x1E169D1", VA = "0x1E168D0")]
		internal void <PlayStaffRoll>b__1()
		{
		}

		// Token: 0x0400A540 RID: 42304
		[Token(Token = "0x401B4CF")]
		[FieldOffset(Offset = "0x10")]
		public MovieRoomSkip skip;

		// Token: 0x0400A541 RID: 42305
		[Token(Token = "0x401B4D0")]
		[FieldOffset(Offset = "0x18")]
		public MovieRoom <>4__this;
	}
}
