using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200099D RID: 2461
[Token(Token = "0x2000675")]
public class HUDController : MonoBehaviour
{
	// Token: 0x17000903 RID: 2307
	// (get) Token: 0x06004056 RID: 16470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000737")]
	public static HUDController Instance
	{
		[Token(Token = "0x600359F")]
		[Address(RVA = "0x2044D40", Offset = "0x2044E41", VA = "0x2044D40")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000904 RID: 2308
	// (get) Token: 0x06004057 RID: 16471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000738")]
	public AnimationCurve SlideCurve
	{
		[Token(Token = "0x60035A0")]
		[Address(RVA = "0x2044DB0", Offset = "0x2044EB1", VA = "0x2044DB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000905 RID: 2309
	// (get) Token: 0x06004058 RID: 16472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000739")]
	public AnimationCurve FadeCurve
	{
		[Token(Token = "0x60035A1")]
		[Address(RVA = "0x2044DC0", Offset = "0x2044EC1", VA = "0x2044DC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000906 RID: 2310
	// (get) Token: 0x06004059 RID: 16473 RVA: 0x00015C30 File Offset: 0x00013E30
	// (set) Token: 0x0600405A RID: 16474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700073A")]
	public bool FocusingMagnifier
	{
		[Token(Token = "0x60035A2")]
		[Address(RVA = "0x2044DD0", Offset = "0x2044ED1", VA = "0x2044DD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7300", Offset = "0x1A7401")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60035A3")]
		[Address(RVA = "0x2044DE0", Offset = "0x2044EE1", VA = "0x2044DE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7310", Offset = "0x1A7411")]
		private set
		{
		}
	}

	// Token: 0x17000907 RID: 2311
	// (get) Token: 0x0600405B RID: 16475 RVA: 0x00015C48 File Offset: 0x00013E48
	// (set) Token: 0x0600405C RID: 16476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700073B")]
	public bool IsAllHide
	{
		[Token(Token = "0x60035A4")]
		[Address(RVA = "0x2044DF0", Offset = "0x2044EF1", VA = "0x2044DF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7320", Offset = "0x1A7421")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60035A5")]
		[Address(RVA = "0x2044E00", Offset = "0x2044F01", VA = "0x2044E00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7330", Offset = "0x1A7431")]
		private set
		{
		}
	}

	// Token: 0x0600405D RID: 16477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035A6")]
	[Address(RVA = "0x2044E10", Offset = "0x2044F11", VA = "0x2044E10")]
	public static void AddHuman(Transform _transform)
	{
	}

	// Token: 0x0600405E RID: 16478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035A7")]
	[Address(RVA = "0x2045190", Offset = "0x2045291", VA = "0x2045190")]
	public static void AddEnemy(Transform _transform)
	{
	}

	// Token: 0x0600405F RID: 16479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035A8")]
	[Address(RVA = "0x2045510", Offset = "0x2045611", VA = "0x2045510")]
	public static void RemoveEnemy(Transform _transform)
	{
	}

	// Token: 0x06004060 RID: 16480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035A9")]
	[Address(RVA = "0x2045700", Offset = "0x2045801", VA = "0x2045700")]
	private void Awake()
	{
	}

	// Token: 0x06004061 RID: 16481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035AA")]
	[Address(RVA = "0x20463F0", Offset = "0x20464F1", VA = "0x20463F0")]
	private void CheckPlayerMove()
	{
	}

	// Token: 0x06004062 RID: 16482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035AB")]
	[Address(RVA = "0x2046600", Offset = "0x2046701", VA = "0x2046600")]
	public void SetAllFadeTime(float time)
	{
	}

	// Token: 0x06004063 RID: 16483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035AC")]
	[Address(RVA = "0x2045F30", Offset = "0x2046031", VA = "0x2045F30")]
	public void SetAllHide(bool s)
	{
	}

	// Token: 0x06004064 RID: 16484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035AD")]
	[Address(RVA = "0x2046AF0", Offset = "0x2046BF1", VA = "0x2046AF0")]
	private void CheckSetButton()
	{
	}

	// Token: 0x06004065 RID: 16485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035AE")]
	[Address(RVA = "0x2046B90", Offset = "0x2046C91", VA = "0x2046B90")]
	public void MinimapSwitcher()
	{
	}

	// Token: 0x06004066 RID: 16486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035AF")]
	[Address(RVA = "0x2046F40", Offset = "0x2047041", VA = "0x2046F40")]
	private void Update()
	{
	}

	// Token: 0x06004067 RID: 16487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B0")]
	[Address(RVA = "0x2047390", Offset = "0x2047491", VA = "0x2047390")]
	public void SetEnterSafeZone()
	{
	}

	// Token: 0x06004068 RID: 16488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B1")]
	[Address(RVA = "0x20473A0", Offset = "0x20474A1", VA = "0x20473A0")]
	public void SetExitSafeZone()
	{
	}

	// Token: 0x06004069 RID: 16489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B2")]
	[Address(RVA = "0x20473B0", Offset = "0x20474B1", VA = "0x20473B0")]
	public void SetExitEnemyZone()
	{
	}

	// Token: 0x0600406A RID: 16490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60035B3")]
	[Address(RVA = "0x20473C0", Offset = "0x20474C1", VA = "0x20473C0")]
	public static OrderHUDBlock AddHudBlock(OrderData data)
	{
		return null;
	}

	// Token: 0x0600406B RID: 16491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B4")]
	[Address(RVA = "0x2047580", Offset = "0x2047681", VA = "0x2047580")]
	public void CheckPartnerForceFadeOut()
	{
	}

	// Token: 0x0600406C RID: 16492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B5")]
	[Address(RVA = "0x20476D0", Offset = "0x20477D1", VA = "0x20476D0")]
	public void OnPartnerChange()
	{
	}

	// Token: 0x0600406D RID: 16493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B6")]
	[Address(RVA = "0x2047780", Offset = "0x2047881", VA = "0x2047780")]
	public void OnPlayerMoveStat(HUDController.PlayerMoveStat playerMoveStat)
	{
	}

	// Token: 0x0600406E RID: 16494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B7")]
	[Address(RVA = "0x2045AD0", Offset = "0x2045BD1", VA = "0x2045AD0")]
	private void SetHUDFadeMoveToTable()
	{
	}

	// Token: 0x0600406F RID: 16495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B8")]
	[Address(RVA = "0x20472C0", Offset = "0x20473C1", VA = "0x20472C0")]
	private void SetFadeTime()
	{
	}

	// Token: 0x06004070 RID: 16496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035B9")]
	[Address(RVA = "0x2043C30", Offset = "0x2043D31", VA = "0x2043C30")]
	public void SetCharacterFadeTimeEnd(HUDCharactorStatus.CharactorType charaType)
	{
	}

	// Token: 0x06004071 RID: 16497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035BA")]
	[Address(RVA = "0x2043F00", Offset = "0x2044001", VA = "0x2043F00")]
	public void SetHUDState(HUDController.HUD_DoState doState)
	{
	}

	// Token: 0x06004072 RID: 16498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035BB")]
	[Address(RVA = "0x2047790", Offset = "0x2047891", VA = "0x2047790")]
	public void SetMagnifier(string text = "")
	{
	}

	// Token: 0x06004073 RID: 16499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035BC")]
	[Address(RVA = "0x2047880", Offset = "0x2047981", VA = "0x2047880")]
	public void OnQuickMenu(bool flag)
	{
	}

	// Token: 0x06004074 RID: 16500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035BD")]
	[Address(RVA = "0x2046390", Offset = "0x2046491", VA = "0x2046390")]
	public void TurnOnTimeClockText(bool stat)
	{
	}

	// Token: 0x06004075 RID: 16501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035BE")]
	[Address(RVA = "0x2047AA0", Offset = "0x2047BA1", VA = "0x2047AA0")]
	public void SetAreaChangeText(string AreaName)
	{
	}

	// Token: 0x06004076 RID: 16502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035BF")]
	[Address(RVA = "0x2047260", Offset = "0x2047361", VA = "0x2047260")]
	public void TurnCrossfire(bool OnOff)
	{
	}

	// Token: 0x06004077 RID: 16503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C0")]
	[Address(RVA = "0x2047B60", Offset = "0x2047C61", VA = "0x2047B60")]
	public void DispTempMoney()
	{
	}

	// Token: 0x06004078 RID: 16504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C1")]
	[Address(RVA = "0x2047F00", Offset = "0x2048001", VA = "0x2047F00")]
	public void EndTempMoney()
	{
	}

	// Token: 0x06004079 RID: 16505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C2")]
	[Address(RVA = "0x2047FD0", Offset = "0x20480D1", VA = "0x2047FD0")]
	public void InitGameMain()
	{
	}

	// Token: 0x0600407A RID: 16506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C3")]
	[Address(RVA = "0x2048020", Offset = "0x2048121", VA = "0x2048020")]
	public HUDController()
	{
	}

	// Token: 0x04009ED0 RID: 40656
	[Token(Token = "0x40077C3")]
	[FieldOffset(Offset = "0x0")]
	public static HUDController _Instance;

	// Token: 0x04009ED1 RID: 40657
	[Token(Token = "0x40077C4")]
	[FieldOffset(Offset = "0x8")]
	private static float[,] SetFadeTimeTable;

	// Token: 0x04009ED2 RID: 40658
	[Token(Token = "0x40077C5")]
	[FieldOffset(Offset = "0x18")]
	private float[] nowFrameSetFade;

	// Token: 0x04009ED3 RID: 40659
	[Token(Token = "0x40077C6")]
	[FieldOffset(Offset = "0x20")]
	private HUDFadeMove[] HUDFadeMoves;

	// Token: 0x04009ED4 RID: 40660
	[Token(Token = "0x40077C7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve slideCurve;

	// Token: 0x04009ED5 RID: 40661
	[Token(Token = "0x40077C8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve fadeCurve;

	// Token: 0x04009ED6 RID: 40662
	[Token(Token = "0x40077C9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private HUDFadeMove MiniMapObj;

	// Token: 0x04009ED7 RID: 40663
	[Token(Token = "0x40077CA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private HUDFadeMove AreaNameObj;

	// Token: 0x04009ED8 RID: 40664
	[Token(Token = "0x40077CB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private HUDFadeMove TimeClockObj;

	// Token: 0x04009ED9 RID: 40665
	[Token(Token = "0x40077CC")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private HUDFadeMove MoneyPointObj;

	// Token: 0x04009EDA RID: 40666
	[Token(Token = "0x40077CD")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private HUDFadeMove PlayerStatusObj;

	// Token: 0x04009EDB RID: 40667
	[Token(Token = "0x40077CE")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private HUDFadeMove PartnerAStatusObj;

	// Token: 0x04009EDC RID: 40668
	[Token(Token = "0x40077CF")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private HUDFadeMove PartnerBStatusObj;

	// Token: 0x04009EDD RID: 40669
	[Token(Token = "0x40077D0")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private HUDFadeMove PartnerCStatusObj;

	// Token: 0x04009EDE RID: 40670
	[Token(Token = "0x40077D1")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private HUDFadeMove RightDownMenuObj;

	// Token: 0x04009EDF RID: 40671
	[Token(Token = "0x40077D2")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private HUDFadeMove LeftDownMenuObj;

	// Token: 0x04009EE0 RID: 40672
	[Token(Token = "0x40077D3")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private HUDFadeMove MagnifierObj;

	// Token: 0x04009EE1 RID: 40673
	[Token(Token = "0x40077D4")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private HUDFadeMove WateringPotObj;

	// Token: 0x04009EE2 RID: 40674
	[Token(Token = "0x40077D5")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private HUDFadeMove MapCalendarObj;

	// Token: 0x04009EE3 RID: 40675
	[Token(Token = "0x40077D6")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private OrderPopControl OrderPopControl;

	// Token: 0x04009EE4 RID: 40676
	[Token(Token = "0x40077D7")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private HUDCharactorStatus PlayerStatus;

	// Token: 0x04009EE5 RID: 40677
	[Token(Token = "0x40077D8")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private HUDCharactorStatus PartnerAStatus;

	// Token: 0x04009EE6 RID: 40678
	[Token(Token = "0x40077D9")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private HUDCharactorStatus PartnerBStatus;

	// Token: 0x04009EE7 RID: 40679
	[Token(Token = "0x40077DA")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private HUDCharactorStatus PartnerCStatus;

	// Token: 0x04009EE8 RID: 40680
	[Token(Token = "0x40077DB")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Text AreaNameText;

	// Token: 0x04009EE9 RID: 40681
	[Token(Token = "0x40077DC")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Text MagnifierText;

	// Token: 0x04009EEA RID: 40682
	[Token(Token = "0x40077DD")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private GameObject CrossfireObj;

	// Token: 0x04009EEB RID: 40683
	[Token(Token = "0x40077DE")]
	[FieldOffset(Offset = "0xE0")]
	private bool CrossfireIsUsOpened;

	// Token: 0x04009EEC RID: 40684
	[Token(Token = "0x40077DF")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Text TimeClockText;

	// Token: 0x04009EED RID: 40685
	[Token(Token = "0x40077E0")]
	[FieldOffset(Offset = "0xF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1701C0", Offset = "0x1702C1")]
	private bool <FocusingMagnifier>k__BackingField;

	// Token: 0x04009EEE RID: 40686
	[Token(Token = "0x40077E1")]
	[FieldOffset(Offset = "0xF1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1701D0", Offset = "0x1702D1")]
	private bool <IsAllHide>k__BackingField;

	// Token: 0x04009EEF RID: 40687
	[Token(Token = "0x40077E2")]
	[FieldOffset(Offset = "0xF8")]
	public List<Transform> HumanList;

	// Token: 0x04009EF0 RID: 40688
	[Token(Token = "0x40077E3")]
	[FieldOffset(Offset = "0x100")]
	public List<Transform> EnemyList;

	// Token: 0x04009EF1 RID: 40689
	[Token(Token = "0x40077E4")]
	[FieldOffset(Offset = "0x108")]
	private Vector3 PlayerPos;

	// Token: 0x04009EF2 RID: 40690
	[Token(Token = "0x40077E5")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private Transform[] MinimapParents;

	// Token: 0x04009EF3 RID: 40691
	[Token(Token = "0x40077E6")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private RectTransform MinimapRect;

	// Token: 0x04009EF4 RID: 40692
	[Token(Token = "0x40077E7")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private HUDMinimapControl MiniMapCtrl;

	// Token: 0x04009EF5 RID: 40693
	[Token(Token = "0x40077E8")]
	[FieldOffset(Offset = "0x130")]
	private int usingMinimapNo;

	// Token: 0x04009EF6 RID: 40694
	[Token(Token = "0x40077E9")]
	[FieldOffset(Offset = "0x138")]
	private HUDFadeMove tempMoneyDisp;

	// Token: 0x0200099E RID: 2462
	[Token(Token = "0x20012AA")]
	public enum HUD_DoState
	{
		// Token: 0x04009EF8 RID: 40696
		[Token(Token = "0x401B371")]
		StartUp,
		// Token: 0x04009EF9 RID: 40697
		[Token(Token = "0x401B372")]
		EndHide,
		// Token: 0x04009EFA RID: 40698
		[Token(Token = "0x401B373")]
		ChangeArea,
		// Token: 0x04009EFB RID: 40699
		[Token(Token = "0x401B374")]
		CloseMenu,
		// Token: 0x04009EFC RID: 40700
		[Token(Token = "0x401B375")]
		StatusChange,
		// Token: 0x04009EFD RID: 40701
		[Token(Token = "0x401B376")]
		ItemHolding,
		// Token: 0x04009EFE RID: 40702
		[Token(Token = "0x401B377")]
		PushSetButton,
		// Token: 0x04009EFF RID: 40703
		[Token(Token = "0x401B378")]
		AddMoneyPoint,
		// Token: 0x04009F00 RID: 40704
		[Token(Token = "0x401B379")]
		PlayerMove,
		// Token: 0x04009F01 RID: 40705
		[Token(Token = "0x401B37A")]
		BadStatus,
		// Token: 0x04009F02 RID: 40706
		[Token(Token = "0x401B37B")]
		Magnifier,
		// Token: 0x04009F03 RID: 40707
		[Token(Token = "0x401B37C")]
		ItemOnHandMove,
		// Token: 0x04009F04 RID: 40708
		[Token(Token = "0x401B37D")]
		TreasureFound,
		// Token: 0x04009F05 RID: 40709
		[Token(Token = "0x401B37E")]
		Max
	}

	// Token: 0x0200099F RID: 2463
	[Token(Token = "0x20012AB")]
	private enum HUD_FadeItems
	{
		// Token: 0x04009F07 RID: 40711
		[Token(Token = "0x401B380")]
		MiniMap,
		// Token: 0x04009F08 RID: 40712
		[Token(Token = "0x401B381")]
		AreaName,
		// Token: 0x04009F09 RID: 40713
		[Token(Token = "0x401B382")]
		TimeClock,
		// Token: 0x04009F0A RID: 40714
		[Token(Token = "0x401B383")]
		MoneyPoint,
		// Token: 0x04009F0B RID: 40715
		[Token(Token = "0x401B384")]
		PlayerStatus,
		// Token: 0x04009F0C RID: 40716
		[Token(Token = "0x401B385")]
		PartnerAStatus,
		// Token: 0x04009F0D RID: 40717
		[Token(Token = "0x401B386")]
		PartnerBStatus,
		// Token: 0x04009F0E RID: 40718
		[Token(Token = "0x401B387")]
		PartnerCStatus,
		// Token: 0x04009F0F RID: 40719
		[Token(Token = "0x401B388")]
		RightDownMenu,
		// Token: 0x04009F10 RID: 40720
		[Token(Token = "0x401B389")]
		LeftDownMenu,
		// Token: 0x04009F11 RID: 40721
		[Token(Token = "0x401B38A")]
		Magnifier,
		// Token: 0x04009F12 RID: 40722
		[Token(Token = "0x401B38B")]
		WateringPot,
		// Token: 0x04009F13 RID: 40723
		[Token(Token = "0x401B38C")]
		MapCalendar,
		// Token: 0x04009F14 RID: 40724
		[Token(Token = "0x401B38D")]
		Max
	}

	// Token: 0x020009A0 RID: 2464
	[Token(Token = "0x20012AC")]
	public enum PlayerMoveStat
	{
		// Token: 0x04009F16 RID: 40726
		[Token(Token = "0x401B38F")]
		Moving,
		// Token: 0x04009F17 RID: 40727
		[Token(Token = "0x401B390")]
		Breaking,
		// Token: 0x04009F18 RID: 40728
		[Token(Token = "0x401B391")]
		AFK
	}
}
