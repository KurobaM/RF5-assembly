using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000ADB RID: 2779
[Token(Token = "0x2000748")]
public class LanguageWindow : MonoBehaviour
{
	// Token: 0x17000992 RID: 2450
	// (get) Token: 0x0600482D RID: 18477 RVA: 0x00017778 File Offset: 0x00015978
	// (set) Token: 0x0600482E RID: 18478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007AC")]
	public int selectLngNo
	{
		[Token(Token = "0x6003C72")]
		[Address(RVA = "0x2301C50", Offset = "0x2301D51", VA = "0x2301C50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003C73")]
		[Address(RVA = "0x2301CA0", Offset = "0x2301DA1", VA = "0x2301CA0")]
		set
		{
		}
	}

	// Token: 0x17000993 RID: 2451
	// (get) Token: 0x0600482F RID: 18479 RVA: 0x00017790 File Offset: 0x00015990
	// (set) Token: 0x06004830 RID: 18480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007AD")]
	public int selectVoiceNo
	{
		[Token(Token = "0x6003C74")]
		[Address(RVA = "0x2301D00", Offset = "0x2301E01", VA = "0x2301D00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003C75")]
		[Address(RVA = "0x2301D50", Offset = "0x2301E51", VA = "0x2301D50")]
		set
		{
		}
	}

	// Token: 0x06004831 RID: 18481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C76")]
	[Address(RVA = "0x2301DB0", Offset = "0x2301EB1", VA = "0x2301DB0")]
	private void Start()
	{
	}

	// Token: 0x06004832 RID: 18482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C77")]
	[Address(RVA = "0x2301DC0", Offset = "0x2301EC1", VA = "0x2301DC0")]
	private void Update()
	{
	}

	// Token: 0x06004833 RID: 18483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C78")]
	[Address(RVA = "0x2302010", Offset = "0x2302111", VA = "0x2302010")]
	private void initParam()
	{
	}

	// Token: 0x06004834 RID: 18484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C79")]
	[Address(RVA = "0x2302100", Offset = "0x2302201", VA = "0x2302100")]
	private void createInfoWindow(LanguageWindow.WindowType type)
	{
	}

	// Token: 0x06004835 RID: 18485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C7A")]
	[Address(RVA = "0x2301F20", Offset = "0x2302021", VA = "0x2301F20")]
	private void activeButton(int moveNum)
	{
	}

	// Token: 0x06004836 RID: 18486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C7B")]
	[Address(RVA = "0x2302610", Offset = "0x2302711", VA = "0x2302610")]
	private void setButton(LanguageWindow.LngButtonType type)
	{
	}

	// Token: 0x06004837 RID: 18487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C7C")]
	[Address(RVA = "0x2302770", Offset = "0x2302871", VA = "0x2302770")]
	public void onWindow()
	{
	}

	// Token: 0x06004838 RID: 18488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C7D")]
	[Address(RVA = "0x2302AC0", Offset = "0x2302BC1", VA = "0x2302AC0")]
	public void offWindow()
	{
	}

	// Token: 0x06004839 RID: 18489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C7E")]
	[Address(RVA = "0x2302AF0", Offset = "0x2302BF1", VA = "0x2302AF0")]
	public void StartButton(LanguageWindow.LngButtonType type)
	{
	}

	// Token: 0x0600483A RID: 18490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C7F")]
	[Address(RVA = "0x2302E10", Offset = "0x2302F11", VA = "0x2302E10")]
	public void LRButton(LanguageWindow.LngButtonType type, int addVal)
	{
	}

	// Token: 0x0600483B RID: 18491 RVA: 0x000177A8 File Offset: 0x000159A8
	[Token(Token = "0x6003C80")]
	[Address(RVA = "0x23031E0", Offset = "0x23032E1", VA = "0x23031E0")]
	public LanguageWindow.LngStep getStep()
	{
		return LanguageWindow.LngStep.Init;
	}

	// Token: 0x0600483C RID: 18492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C81")]
	[Address(RVA = "0x23031F0", Offset = "0x23032F1", VA = "0x23031F0")]
	public void touchLngButton(int no)
	{
	}

	// Token: 0x0600483D RID: 18493 RVA: 0x000177C0 File Offset: 0x000159C0
	[Token(Token = "0x6003C82")]
	[Address(RVA = "0x2303470", Offset = "0x2303571", VA = "0x2303470")]
	public bool getChangeLang()
	{
		return default(bool);
	}

	// Token: 0x0600483E RID: 18494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C83")]
	[Address(RVA = "0x2303480", Offset = "0x2303581", VA = "0x2303480")]
	public LanguageWindow()
	{
	}

	// Token: 0x0400A78D RID: 42893
	[Token(Token = "0x4007EA8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject winBg;

	// Token: 0x0400A78E RID: 42894
	[Token(Token = "0x4007EA9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform windowMask;

	// Token: 0x0400A78F RID: 42895
	[Token(Token = "0x4007EAA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform windowAcs;

	// Token: 0x0400A790 RID: 42896
	[Token(Token = "0x4007EAB")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform windowFrm;

	// Token: 0x0400A791 RID: 42897
	[Token(Token = "0x4007EAC")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform rectLng;

	// Token: 0x0400A792 RID: 42898
	[Token(Token = "0x4007EAD")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform rectVoice;

	// Token: 0x0400A793 RID: 42899
	[Token(Token = "0x4007EAE")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform rectOk;

	// Token: 0x0400A794 RID: 42900
	[Token(Token = "0x4007EAF")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text InfoTitleL;

	// Token: 0x0400A795 RID: 42901
	[Token(Token = "0x4007EB0")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text InfoTitleV;

	// Token: 0x0400A796 RID: 42902
	[Token(Token = "0x4007EB1")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text InfoBtnTextL;

	// Token: 0x0400A797 RID: 42903
	[Token(Token = "0x4007EB2")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text InfoBtnTextV;

	// Token: 0x0400A798 RID: 42904
	[Token(Token = "0x4007EB3")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private TitleLangButton[] ButtonListLV;

	// Token: 0x0400A799 RID: 42905
	[Token(Token = "0x4007EB4")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private TitleLangButton[] ButtonListL;

	// Token: 0x0400A79A RID: 42906
	[Token(Token = "0x4007EB5")]
	[FieldOffset(Offset = "0x80")]
	private int focusing;

	// Token: 0x0400A79B RID: 42907
	[Token(Token = "0x4007EB6")]
	[FieldOffset(Offset = "0x0")]
	private static int _selectLngNo;

	// Token: 0x0400A79C RID: 42908
	[Token(Token = "0x4007EB7")]
	[FieldOffset(Offset = "0x4")]
	private static int _selectVoiceNo;

	// Token: 0x0400A79D RID: 42909
	[Token(Token = "0x4007EB8")]
	[FieldOffset(Offset = "0x84")]
	private LanguageWindow.LngButtonType btnType;

	// Token: 0x0400A79E RID: 42910
	[Token(Token = "0x4007EB9")]
	[FieldOffset(Offset = "0x88")]
	private bool ButtonStarted;

	// Token: 0x0400A79F RID: 42911
	[Token(Token = "0x4007EBA")]
	[FieldOffset(Offset = "0x8C")]
	private LanguageWindow.LngStep step;

	// Token: 0x0400A7A0 RID: 42912
	[Token(Token = "0x4007EBB")]
	[FieldOffset(Offset = "0x90")]
	private LanguageWindow.WindowType winMode;

	// Token: 0x0400A7A1 RID: 42913
	[Token(Token = "0x4007EBC")]
	[FieldOffset(Offset = "0x94")]
	private int langCnt;

	// Token: 0x0400A7A2 RID: 42914
	[Token(Token = "0x4007EBD")]
	[FieldOffset(Offset = "0x98")]
	private bool changeLang;

	// Token: 0x0400A7A3 RID: 42915
	[Token(Token = "0x4007EBE")]
	[FieldOffset(Offset = "0x9C")]
	private SystemLanguage voiceLang;

	// Token: 0x0400A7A4 RID: 42916
	[Token(Token = "0x4007EBF")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<SystemLanguage, string> LanguageString;

	// Token: 0x0400A7A5 RID: 42917
	[Token(Token = "0x4007EC0")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<SystemLanguage, string> LanguageVoiceString;

	// Token: 0x0400A7A6 RID: 42918
	[Token(Token = "0x4007EC1")]
	[FieldOffset(Offset = "0xB0")]
	private Vector2[] WindowSizeTbl;

	// Token: 0x0400A7A7 RID: 42919
	[Token(Token = "0x4007EC2")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2[] LngBtnPosTbl;

	// Token: 0x0400A7A8 RID: 42920
	[Token(Token = "0x4007EC3")]
	[FieldOffset(Offset = "0xC0")]
	private Vector2[] voiceBtnPosTbl;

	// Token: 0x0400A7A9 RID: 42921
	[Token(Token = "0x4007EC4")]
	[FieldOffset(Offset = "0xC8")]
	private Vector2[] okBtnPosTbl;

	// Token: 0x02000ADC RID: 2780
	[Token(Token = "0x2001315")]
	public enum LngButtonType
	{
		// Token: 0x0400A7AB RID: 42923
		[Token(Token = "0x401B549")]
		SettingLanguage,
		// Token: 0x0400A7AC RID: 42924
		[Token(Token = "0x401B54A")]
		SettingVoice,
		// Token: 0x0400A7AD RID: 42925
		[Token(Token = "0x401B54B")]
		Ok,
		// Token: 0x0400A7AE RID: 42926
		[Token(Token = "0x401B54C")]
		Cancel
	}

	// Token: 0x02000ADD RID: 2781
	[Token(Token = "0x2001316")]
	public enum LngStep
	{
		// Token: 0x0400A7B0 RID: 42928
		[Token(Token = "0x401B54E")]
		Init,
		// Token: 0x0400A7B1 RID: 42929
		[Token(Token = "0x401B54F")]
		Input,
		// Token: 0x0400A7B2 RID: 42930
		[Token(Token = "0x401B550")]
		End
	}

	// Token: 0x02000ADE RID: 2782
	[Token(Token = "0x2001317")]
	public enum WindowType
	{
		// Token: 0x0400A7B4 RID: 42932
		[Token(Token = "0x401B552")]
		LangAndVoice,
		// Token: 0x0400A7B5 RID: 42933
		[Token(Token = "0x401B553")]
		LangOnly
	}
}
