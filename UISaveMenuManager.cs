using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RF5UI;
using RF5UI.BUTTONHINT;
using SaveData;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000A4D RID: 2637
[Token(Token = "0x20006F0")]
public class UISaveMenuManager : UIScrollBoxBase
{
	// Token: 0x17000956 RID: 2390
	// (get) Token: 0x060044D3 RID: 17619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000782")]
	private NextTargetDataTable NextTargetDataTable
	{
		[Token(Token = "0x60039B0")]
		[Address(RVA = "0x1EB2320", Offset = "0x1EB2421", VA = "0x1EB2320")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000957 RID: 2391
	// (get) Token: 0x060044D4 RID: 17620 RVA: 0x00016DA0 File Offset: 0x00014FA0
	[Token(Token = "0x17000783")]
	public bool CampScreen
	{
		[Token(Token = "0x60039B1")]
		[Address(RVA = "0x1EB1160", Offset = "0x1EB1261", VA = "0x1EB1160")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000958 RID: 2392
	// (get) Token: 0x060044D5 RID: 17621 RVA: 0x00016DB8 File Offset: 0x00014FB8
	[Token(Token = "0x17000784")]
	public bool TitleLoadScreen
	{
		[Token(Token = "0x60039B2")]
		[Address(RVA = "0x1EB1980", Offset = "0x1EB1A81", VA = "0x1EB1980")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000959 RID: 2393
	// (get) Token: 0x060044D6 RID: 17622 RVA: 0x00016DD0 File Offset: 0x00014FD0
	[Token(Token = "0x17000785")]
	public bool MakingScreen
	{
		[Token(Token = "0x60039B3")]
		[Address(RVA = "0x1EB1990", Offset = "0x1EB1A91", VA = "0x1EB1990")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060044D7 RID: 17623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039B4")]
	[Address(RVA = "0x1EB2420", Offset = "0x1EB2521", VA = "0x1EB2420", Slot = "8")]
	protected override void Start()
	{
	}

	// Token: 0x060044D8 RID: 17624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039B5")]
	[Address(RVA = "0x1EB2470", Offset = "0x1EB2571", VA = "0x1EB2470", Slot = "10")]
	protected override void OnDisable()
	{
	}

	// Token: 0x060044D9 RID: 17625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039B6")]
	[Address(RVA = "0x1EB2520", Offset = "0x1EB2621", VA = "0x1EB2520")]
	private void SetThumpDataSave()
	{
	}

	// Token: 0x060044DA RID: 17626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039B7")]
	[Address(RVA = "0x1EB2610", Offset = "0x1EB2711", VA = "0x1EB2610")]
	public void ChangeState(UISaveMenuManager.PageState state)
	{
	}

	// Token: 0x060044DB RID: 17627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039B8")]
	[Address(RVA = "0x1EB2870", Offset = "0x1EB2971", VA = "0x1EB2870")]
	private void OnEnable()
	{
	}

	// Token: 0x060044DC RID: 17628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039B9")]
	[Address(RVA = "0x1EB2AB0", Offset = "0x1EB2BB1", VA = "0x1EB2AB0")]
	public void FocusLatestSlot()
	{
	}

	// Token: 0x060044DD RID: 17629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60039BA")]
	[Address(RVA = "0x1EB2A30", Offset = "0x1EB2B31", VA = "0x1EB2A30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A7930", Offset = "0x1A7A31")]
	private IEnumerator SetupButtonHint()
	{
		return null;
	}

	// Token: 0x060044DE RID: 17630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039BB")]
	[Address(RVA = "0x1EB2D70", Offset = "0x1EB2E71", VA = "0x1EB2D70", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x060044DF RID: 17631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039BC")]
	[Address(RVA = "0x1EB3580", Offset = "0x1EB3681", VA = "0x1EB3580")]
	private void DoAfterSaved(ErrorCode errCode)
	{
	}

	// Token: 0x060044E0 RID: 17632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039BD")]
	[Address(RVA = "0x1EB3730", Offset = "0x1EB3831", VA = "0x1EB3730")]
	private void LoadGame(int focusingNo)
	{
	}

	// Token: 0x060044E1 RID: 17633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039BE")]
	[Address(RVA = "0x1EB2DA0", Offset = "0x1EB2EA1", VA = "0x1EB2DA0")]
	private void UpdateLoadSave()
	{
	}

	// Token: 0x060044E2 RID: 17634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039BF")]
	[Address(RVA = "0x1EB3830", Offset = "0x1EB3931", VA = "0x1EB3830")]
	private void OpenDeleteCheckPopup()
	{
	}

	// Token: 0x060044E3 RID: 17635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60039C0")]
	[Address(RVA = "0x1EB3AE0", Offset = "0x1EB3BE1", VA = "0x1EB3AE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A79A0", Offset = "0x1A7AA1")]
	private IEnumerator OpenDeletedPopup()
	{
		return null;
	}

	// Token: 0x060044E4 RID: 17636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039C1")]
	[Address(RVA = "0x1EB3B90", Offset = "0x1EB3C91", VA = "0x1EB3B90")]
	public void DoSaveBlockAction()
	{
	}

	// Token: 0x060044E5 RID: 17637 RVA: 0x00016DE8 File Offset: 0x00014FE8
	[Token(Token = "0x60039C2")]
	[Address(RVA = "0x1EB4530", Offset = "0x1EB4631", VA = "0x1EB4530")]
	private bool CheckCanDoSaveAction()
	{
		return default(bool);
	}

	// Token: 0x060044E6 RID: 17638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039C3")]
	[Address(RVA = "0x1EB45E0", Offset = "0x1EB46E1", VA = "0x1EB45E0")]
	public void OpenMakingUILoadPage(UIMakingMenu _UIMakingMenu)
	{
	}

	// Token: 0x060044E7 RID: 17639 RVA: 0x00016E00 File Offset: 0x00015000
	[Token(Token = "0x60039C4")]
	[Address(RVA = "0x1EB4620", Offset = "0x1EB4721", VA = "0x1EB4620", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x060044E8 RID: 17640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039C5")]
	[Address(RVA = "0x1EB4670", Offset = "0x1EB4771", VA = "0x1EB4670", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x060044E9 RID: 17641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039C6")]
	[Address(RVA = "0x1EB4770", Offset = "0x1EB4871", VA = "0x1EB4770", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x060044EA RID: 17642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039C7")]
	[Address(RVA = "0x1EB4840", Offset = "0x1EB4941", VA = "0x1EB4840")]
	public UISaveMenuManager()
	{
	}

	// Token: 0x060044EB RID: 17643 RVA: 0x00016E18 File Offset: 0x00015018
	[Token(Token = "0x60039C8")]
	[Address(RVA = "0x1EB4860", Offset = "0x1EB4961", VA = "0x1EB4860")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7A10", Offset = "0x1A7B11")]
	private bool <SetupButtonHint>b__36_0()
	{
		return default(bool);
	}

	// Token: 0x060044EC RID: 17644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039C9")]
	[Address(RVA = "0x1EB4880", Offset = "0x1EB4981", VA = "0x1EB4880")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7A20", Offset = "0x1A7B21")]
	private void <DoAfterSaved>b__38_0(bool a)
	{
	}

	// Token: 0x060044ED RID: 17645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039CA")]
	[Address(RVA = "0x1EB4950", Offset = "0x1EB4A51", VA = "0x1EB4950")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7A30", Offset = "0x1A7B31")]
	private void <DoAfterSaved>b__38_1(bool a)
	{
	}

	// Token: 0x060044EE RID: 17646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039CB")]
	[Address(RVA = "0x1EB4A20", Offset = "0x1EB4B21", VA = "0x1EB4A20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7A40", Offset = "0x1A7B41")]
	private void <UpdateLoadSave>b__41_0(bool a)
	{
	}

	// Token: 0x060044EF RID: 17647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039CC")]
	[Address(RVA = "0x1EB4AB0", Offset = "0x1EB4BB1", VA = "0x1EB4AB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7A50", Offset = "0x1A7B51")]
	private void <UpdateLoadSave>b__41_2(bool select)
	{
	}

	// Token: 0x060044F0 RID: 17648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039CD")]
	[Address(RVA = "0x1EB4AC0", Offset = "0x1EB4BC1", VA = "0x1EB4AC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7A60", Offset = "0x1A7B61")]
	private void <UpdateLoadSave>b__41_1(bool select)
	{
	}

	// Token: 0x060044F1 RID: 17649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039CE")]
	[Address(RVA = "0x1EB4AD0", Offset = "0x1EB4BD1", VA = "0x1EB4AD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7A70", Offset = "0x1A7B71")]
	private void <OpenDeleteCheckPopup>b__42_1(bool select)
	{
	}

	// Token: 0x060044F2 RID: 17650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039CF")]
	[Address(RVA = "0x1EB4C20", Offset = "0x1EB4D21", VA = "0x1EB4C20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7A80", Offset = "0x1A7B81")]
	private void <OpenDeleteCheckPopup>b__42_2(ErrorCode a)
	{
	}

	// Token: 0x060044F3 RID: 17651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039D0")]
	[Address(RVA = "0x1EB4C30", Offset = "0x1EB4D31", VA = "0x1EB4C30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7A90", Offset = "0x1A7B91")]
	private void <OpenDeleteCheckPopup>b__42_0(bool select)
	{
	}

	// Token: 0x060044F4 RID: 17652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039D1")]
	[Address(RVA = "0x1EB4E20", Offset = "0x1EB4F21", VA = "0x1EB4E20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7AA0", Offset = "0x1A7BA1")]
	private void <OpenDeleteCheckPopup>b__42_3(ErrorCode a)
	{
	}

	// Token: 0x060044F5 RID: 17653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039D2")]
	[Address(RVA = "0x1EB4E30", Offset = "0x1EB4F31", VA = "0x1EB4E30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7AB0", Offset = "0x1A7BB1")]
	private void <OpenDeletedPopup>b__43_1(bool select)
	{
	}

	// Token: 0x060044F6 RID: 17654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039D3")]
	[Address(RVA = "0x1EB4EB0", Offset = "0x1EB4FB1", VA = "0x1EB4EB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7AC0", Offset = "0x1A7BC1")]
	private void <OpenDeletedPopup>b__43_0(bool select)
	{
	}

	// Token: 0x0400A3C9 RID: 41929
	[Token(Token = "0x4007BEC")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UISaveMenuManager.PageState StartState;

	// Token: 0x0400A3CA RID: 41930
	[Token(Token = "0x4007BED")]
	[FieldOffset(Offset = "0x6C")]
	public UISaveMenuManager.PageState nowState;

	// Token: 0x0400A3CB RID: 41931
	[Token(Token = "0x4007BEE")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject NowSaving;

	// Token: 0x0400A3CC RID: 41932
	[Token(Token = "0x4007BEF")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject NowLoading;

	// Token: 0x0400A3CD RID: 41933
	[Token(Token = "0x4007BF0")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject NowDeleting;

	// Token: 0x0400A3CE RID: 41934
	[Token(Token = "0x4007BF1")]
	[FieldOffset(Offset = "0x88")]
	private bool isDeleted;

	// Token: 0x0400A3CF RID: 41935
	[Token(Token = "0x4007BF2")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private CursorLinker TopSaveObject;

	// Token: 0x0400A3D0 RID: 41936
	[Token(Token = "0x4007BF3")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private CursorLinker TopLoadObject;

	// Token: 0x0400A3D1 RID: 41937
	[Token(Token = "0x4007BF4")]
	[FieldOffset(Offset = "0xA0")]
	private int LoadingIndex;

	// Token: 0x0400A3D2 RID: 41938
	[Token(Token = "0x4007BF5")]
	[FieldOffset(Offset = "0xA8")]
	private NextTargetDataTable nextTargetDataTable;

	// Token: 0x0400A3D3 RID: 41939
	[Token(Token = "0x4007BF6")]
	[FieldOffset(Offset = "0xB0")]
	private UIMakingMenu UIMakingMenu;

	// Token: 0x0400A3D4 RID: 41940
	[Token(Token = "0x4007BF7")]
	[FieldOffset(Offset = "0xB8")]
	private UISaveMenuManager.StepState step;

	// Token: 0x0400A3D5 RID: 41941
	[Token(Token = "0x4007BF8")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	public UISaveMenuManager.SavePageType PageType;

	// Token: 0x0400A3D6 RID: 41942
	[Token(Token = "0x4007BF9")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private TwoChoicePopupLite TwoChoicePopupLite;

	// Token: 0x0400A3D7 RID: 41943
	[Token(Token = "0x4007BFA")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private NoChoicePopupLite NoChoicePopupLite;

	// Token: 0x0400A3D8 RID: 41944
	[Token(Token = "0x4007BFB")]
	[FieldOffset(Offset = "0xD0")]
	private List<RF5ThumbnailData> thumbSaveDatas;

	// Token: 0x0400A3D9 RID: 41945
	[Token(Token = "0x4007BFC")]
	[FieldOffset(Offset = "0xD8")]
	private int latestSaveSlot;

	// Token: 0x0400A3DA RID: 41946
	[Token(Token = "0x4007BFD")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private CursorControllerLite cursorControllerLite;

	// Token: 0x0400A3DB RID: 41947
	[Token(Token = "0x4007BFE")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private ButtonHintMain buttonHint;

	// Token: 0x0400A3DC RID: 41948
	[Token(Token = "0x4007BFF")]
	[FieldOffset(Offset = "0xF0")]
	private bool onPopupSelectingOnTitle;

	// Token: 0x02000A4E RID: 2638
	[Token(Token = "0x20012DF")]
	public enum PageState
	{
		// Token: 0x0400A3DE RID: 41950
		[Token(Token = "0x401B441")]
		None = -1,
		// Token: 0x0400A3DF RID: 41951
		[Token(Token = "0x401B442")]
		Save,
		// Token: 0x0400A3E0 RID: 41952
		[Token(Token = "0x401B443")]
		Load
	}

	// Token: 0x02000A4F RID: 2639
	[Token(Token = "0x20012E0")]
	public enum SavePageType
	{
		// Token: 0x0400A3E2 RID: 41954
		[Token(Token = "0x401B445")]
		Camp,
		// Token: 0x0400A3E3 RID: 41955
		[Token(Token = "0x401B446")]
		Title,
		// Token: 0x0400A3E4 RID: 41956
		[Token(Token = "0x401B447")]
		Making
	}

	// Token: 0x02000A50 RID: 2640
	[Token(Token = "0x20012E1")]
	private enum StepState
	{
		// Token: 0x0400A3E6 RID: 41958
		[Token(Token = "0x401B449")]
		STAY,
		// Token: 0x0400A3E7 RID: 41959
		[Token(Token = "0x401B44A")]
		SAVE,
		// Token: 0x0400A3E8 RID: 41960
		[Token(Token = "0x401B44B")]
		SAVEEND,
		// Token: 0x0400A3E9 RID: 41961
		[Token(Token = "0x401B44C")]
		LOAD,
		// Token: 0x0400A3EA RID: 41962
		[Token(Token = "0x401B44D")]
		LOADEND,
		// Token: 0x0400A3EB RID: 41963
		[Token(Token = "0x401B44E")]
		LOADFAIL,
		// Token: 0x0400A3EC RID: 41964
		[Token(Token = "0x401B44F")]
		DELETING
	}

	// Token: 0x02000A51 RID: 2641
	[Token(Token = "0x20012E2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1590A0", Offset = "0x1591A1")]
	private sealed class <SetupButtonHint>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060044F7 RID: 17655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007607")]
		[Address(RVA = "0x1EB2D40", Offset = "0x1EB2E41", VA = "0x1EB2D40")]
		[DebuggerHidden]
		public <SetupButtonHint>d__36(int <>1__state)
		{
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007608")]
		[Address(RVA = "0x1EB5720", Offset = "0x1EB5821", VA = "0x1EB5720", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00016E30 File Offset: 0x00015030
		[Token(Token = "0x6007609")]
		[Address(RVA = "0x1EB5730", Offset = "0x1EB5831", VA = "0x1EB5730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D91")]
		private object Current
		{
			[Token(Token = "0x600760A")]
			[Address(RVA = "0x1EB5840", Offset = "0x1EB5941", VA = "0x1EB5840", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600760B")]
		[Address(RVA = "0x1EB5850", Offset = "0x1EB5951", VA = "0x1EB5850", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D92")]
		private object Current
		{
			[Token(Token = "0x600760C")]
			[Address(RVA = "0x1EB58B0", Offset = "0x1EB59B1", VA = "0x1EB58B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A3ED RID: 41965
		[Token(Token = "0x401B450")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A3EE RID: 41966
		[Token(Token = "0x401B451")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A3EF RID: 41967
		[Token(Token = "0x401B452")]
		[FieldOffset(Offset = "0x20")]
		public UISaveMenuManager <>4__this;
	}

	// Token: 0x02000A52 RID: 2642
	[Token(Token = "0x20012E3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1590B0", Offset = "0x1591B1")]
	private sealed class <OpenDeletedPopup>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060044FD RID: 17661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600760D")]
		[Address(RVA = "0x1EB3B60", Offset = "0x1EB3C61", VA = "0x1EB3B60")]
		[DebuggerHidden]
		public <OpenDeletedPopup>d__43(int <>1__state)
		{
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600760E")]
		[Address(RVA = "0x1EB5320", Offset = "0x1EB5421", VA = "0x1EB5320", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00016E48 File Offset: 0x00015048
		[Token(Token = "0x600760F")]
		[Address(RVA = "0x1EB5330", Offset = "0x1EB5431", VA = "0x1EB5330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06004500 RID: 17664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D93")]
		private object Current
		{
			[Token(Token = "0x6007610")]
			[Address(RVA = "0x1EB56A0", Offset = "0x1EB57A1", VA = "0x1EB56A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007611")]
		[Address(RVA = "0x1EB56B0", Offset = "0x1EB57B1", VA = "0x1EB56B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D94")]
		private object Current
		{
			[Token(Token = "0x6007612")]
			[Address(RVA = "0x1EB5710", Offset = "0x1EB5811", VA = "0x1EB5710", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A3F0 RID: 41968
		[Token(Token = "0x401B453")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A3F1 RID: 41969
		[Token(Token = "0x401B454")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A3F2 RID: 41970
		[Token(Token = "0x401B455")]
		[FieldOffset(Offset = "0x20")]
		public UISaveMenuManager <>4__this;

		// Token: 0x0400A3F3 RID: 41971
		[Token(Token = "0x401B456")]
		[FieldOffset(Offset = "0x28")]
		private float <timeCount>5__2;
	}

	// Token: 0x02000A53 RID: 2643
	[Token(Token = "0x20012E4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1590C0", Offset = "0x1591C1")]
	private sealed class <>c__DisplayClass44_0
	{
		// Token: 0x06004503 RID: 17667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007613")]
		[Address(RVA = "0x1EB4520", Offset = "0x1EB4621", VA = "0x1EB4520")]
		public <>c__DisplayClass44_0()
		{
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007614")]
		[Address(RVA = "0x1EB4FD0", Offset = "0x1EB50D1", VA = "0x1EB4FD0")]
		internal void <DoSaveBlockAction>b__2(bool a)
		{
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007615")]
		[Address(RVA = "0x1EB5090", Offset = "0x1EB5191", VA = "0x1EB5090")]
		internal void <DoSaveBlockAction>b__3(bool a)
		{
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007616")]
		[Address(RVA = "0x1EB5130", Offset = "0x1EB5231", VA = "0x1EB5130")]
		internal void <DoSaveBlockAction>b__1(bool a)
		{
		}

		// Token: 0x0400A3F4 RID: 41972
		[Token(Token = "0x401B457")]
		[FieldOffset(Offset = "0x10")]
		public UISaveMenuManager <>4__this;

		// Token: 0x0400A3F5 RID: 41973
		[Token(Token = "0x401B458")]
		[FieldOffset(Offset = "0x18")]
		public int focusIndex;
	}

	// Token: 0x02000A54 RID: 2644
	[Token(Token = "0x20012E5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1590D0", Offset = "0x1591D1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004508 RID: 17672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007618")]
		[Address(RVA = "0x1EB4FB0", Offset = "0x1EB50B1", VA = "0x1EB4FB0")]
		public <>c()
		{
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007619")]
		[Address(RVA = "0x1EB4FC0", Offset = "0x1EB50C1", VA = "0x1EB4FC0")]
		internal void <DoSaveBlockAction>b__44_0(bool select)
		{
		}

		// Token: 0x0400A3F6 RID: 41974
		[Token(Token = "0x401B459")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UISaveMenuManager.<>c <>9;

		// Token: 0x0400A3F7 RID: 41975
		[Token(Token = "0x401B45A")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction<bool> <>9__44_0;
	}
}
