using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using RF5UI;
using RF5UI.BUTTONHINT;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000B0B RID: 2827
[Token(Token = "0x200075D")]
public class UIMainController : SingletonMonoBehaviour<UIMainController>
{
	// Token: 0x170009AE RID: 2478
	// (get) Token: 0x06004918 RID: 18712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007B2")]
	public RectTransform CharactorLog
	{
		[Token(Token = "0x6003D10")]
		[Address(RVA = "0x2020170", Offset = "0x2020271", VA = "0x2020170")]
		get
		{
			return null;
		}
	}

	// Token: 0x170009AF RID: 2479
	// (get) Token: 0x06004919 RID: 18713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007B3")]
	public RectTransform MinigameUI
	{
		[Token(Token = "0x6003D11")]
		[Address(RVA = "0x2020180", Offset = "0x2020281", VA = "0x2020180")]
		get
		{
			return null;
		}
	}

	// Token: 0x170009B0 RID: 2480
	// (get) Token: 0x0600491A RID: 18714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007B4")]
	public Canvas SystemCanvas
	{
		[Token(Token = "0x6003D12")]
		[Address(RVA = "0x2020190", Offset = "0x2020291", VA = "0x2020190")]
		get
		{
			return null;
		}
	}

	// Token: 0x170009B1 RID: 2481
	// (get) Token: 0x0600491B RID: 18715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007B5")]
	public Camera UICamera
	{
		[Token(Token = "0x6003D13")]
		[Address(RVA = "0x20201A0", Offset = "0x20202A1", VA = "0x20201A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170009B2 RID: 2482
	// (get) Token: 0x0600491C RID: 18716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007B6")]
	public List<Light> RealtimeBakeLightList
	{
		[Token(Token = "0x6003D14")]
		[Address(RVA = "0x2020210", Offset = "0x2020311", VA = "0x2020210")]
		get
		{
			return null;
		}
	}

	// Token: 0x170009B3 RID: 2483
	// (get) Token: 0x0600491D RID: 18717 RVA: 0x00017A60 File Offset: 0x00015C60
	// (set) Token: 0x0600491E RID: 18718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007B7")]
	public bool PlayerHoldNotItemOnHand
	{
		[Token(Token = "0x6003D15")]
		[Address(RVA = "0x2020220", Offset = "0x2020321", VA = "0x2020220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8850", Offset = "0x1A8951")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003D16")]
		[Address(RVA = "0x2020230", Offset = "0x2020331", VA = "0x2020230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8860", Offset = "0x1A8961")]
		private set
		{
		}
	}

	// Token: 0x170009B4 RID: 2484
	// (get) Token: 0x0600491F RID: 18719 RVA: 0x00017A78 File Offset: 0x00015C78
	// (set) Token: 0x06004920 RID: 18720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007B8")]
	public bool PlayerRiding
	{
		[Token(Token = "0x6003D17")]
		[Address(RVA = "0x2020240", Offset = "0x2020341", VA = "0x2020240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8870", Offset = "0x1A8971")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003D18")]
		[Address(RVA = "0x2020250", Offset = "0x2020351", VA = "0x2020250")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8880", Offset = "0x1A8981")]
		private set
		{
		}
	}

	// Token: 0x170009B5 RID: 2485
	// (get) Token: 0x06004921 RID: 18721 RVA: 0x00017A90 File Offset: 0x00015C90
	[Token(Token = "0x170007B9")]
	public bool PlayerBlockHoldItemByUI
	{
		[Token(Token = "0x6003D19")]
		[Address(RVA = "0x201A8C0", Offset = "0x201A9C1", VA = "0x201A8C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06004922 RID: 18722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D1A")]
	[Address(RVA = "0x2020260", Offset = "0x2020361", VA = "0x2020260")]
	public void ReCheckEquipNotItemOnHand()
	{
	}

	// Token: 0x06004923 RID: 18723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D1B")]
	[Address(RVA = "0x20203E0", Offset = "0x20204E1", VA = "0x20203E0")]
	public void AddRealtimeBakeLight(Light light)
	{
	}

	// Token: 0x06004924 RID: 18724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D1C")]
	[Address(RVA = "0x2020480", Offset = "0x2020581", VA = "0x2020480")]
	public void RemoveRealtimeBakeLight(Light light)
	{
	}

	// Token: 0x06004925 RID: 18725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D1D")]
	[Address(RVA = "0x2020520", Offset = "0x2020621", VA = "0x2020520")]
	public void ClearRealtimeBakeLightList()
	{
	}

	// Token: 0x06004926 RID: 18726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D1E")]
	[Address(RVA = "0x2020580", Offset = "0x2020681", VA = "0x2020580")]
	public void SetRealtimeBakeLightList(bool isEnable)
	{
	}

	// Token: 0x06004927 RID: 18727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D1F")]
	[Address(RVA = "0x2020680", Offset = "0x2020781", VA = "0x2020680")]
	public void OpenRenameMobSelector()
	{
	}

	// Token: 0x06004928 RID: 18728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D20")]
	[Address(RVA = "0x2020700", Offset = "0x2020801", VA = "0x2020700")]
	public void EndRenameMobSelector()
	{
	}

	// Token: 0x06004929 RID: 18729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D21")]
	[Address(RVA = "0x2020710", Offset = "0x2020811", VA = "0x2020710")]
	private void CheckMapSet()
	{
	}

	// Token: 0x0600492A RID: 18730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D22")]
	[Address(RVA = "0x201E020", Offset = "0x201E121", VA = "0x201E020")]
	public void SetStartInputState(UIMainController.UIInputState inputState)
	{
	}

	// Token: 0x0600492B RID: 18731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D23")]
	[Address(RVA = "0x201E4E0", Offset = "0x201E5E1", VA = "0x201E4E0")]
	public void ReleaseInputState(UIMainController.UIInputState inputState)
	{
	}

	// Token: 0x0600492C RID: 18732 RVA: 0x00017AA8 File Offset: 0x00015CA8
	[Token(Token = "0x6003D24")]
	[Address(RVA = "0x2020960", Offset = "0x2020A61", VA = "0x2020960")]
	public bool IsOtherInputUsing(UIMainController.UIInputState myInputState)
	{
		return default(bool);
	}

	// Token: 0x0600492D RID: 18733 RVA: 0x00017AC0 File Offset: 0x00015CC0
	[Token(Token = "0x6003D25")]
	[Address(RVA = "0x201A1D0", Offset = "0x201A2D1", VA = "0x201A1D0")]
	public bool IsUsing(UIMainController.UIInputState myInputState)
	{
		return default(bool);
	}

	// Token: 0x0600492E RID: 18734 RVA: 0x00017AD8 File Offset: 0x00015CD8
	[Token(Token = "0x6003D26")]
	[Address(RVA = "0x2020970", Offset = "0x2020A71", VA = "0x2020970")]
	public bool IsUISystemBlockInput()
	{
		return default(bool);
	}

	// Token: 0x0600492F RID: 18735 RVA: 0x00017AF0 File Offset: 0x00015CF0
	[Token(Token = "0x6003D27")]
	[Address(RVA = "0x2020990", Offset = "0x2020A91", VA = "0x2020990")]
	public bool IsBlockCursorInput()
	{
		return default(bool);
	}

	// Token: 0x06004930 RID: 18736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D28")]
	[Address(RVA = "0x20209B0", Offset = "0x2020AB1", VA = "0x20209B0")]
	public void TurnOnHud()
	{
	}

	// Token: 0x06004931 RID: 18737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D29")]
	[Address(RVA = "0x2020A20", Offset = "0x2020B21", VA = "0x2020A20")]
	public void TurnOffHud()
	{
	}

	// Token: 0x06004932 RID: 18738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D2A")]
	[Address(RVA = "0x2020A90", Offset = "0x2020B91", VA = "0x2020A90")]
	private void AddScreenFadeUsing(bool fadeUsing, int filter)
	{
	}

	// Token: 0x06004933 RID: 18739 RVA: 0x00017B08 File Offset: 0x00015D08
	[Token(Token = "0x6003D2B")]
	[Address(RVA = "0x2020B50", Offset = "0x2020C51", VA = "0x2020B50")]
	public bool IsScreenFadeUsing()
	{
		return default(bool);
	}

	// Token: 0x06004934 RID: 18740 RVA: 0x00017B20 File Offset: 0x00015D20
	[Token(Token = "0x6003D2C")]
	[Address(RVA = "0x2020BC0", Offset = "0x2020CC1", VA = "0x2020BC0")]
	public bool IsUnderAdvToBlack()
	{
		return default(bool);
	}

	// Token: 0x06004935 RID: 18741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D2D")]
	[Address(RVA = "0x2020C20", Offset = "0x2020D21", VA = "0x2020C20")]
	public void ScreenFadeChat(float fadeTime, Color fadeColor, int fadeStat = 2)
	{
	}

	// Token: 0x06004936 RID: 18742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D2E")]
	[Address(RVA = "0x2020DE0", Offset = "0x2020EE1", VA = "0x2020DE0")]
	public void ScreenFadeChat(float fadeTime, int fadeStat)
	{
	}

	// Token: 0x06004937 RID: 18743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D2F")]
	[Address(RVA = "0x2020FA0", Offset = "0x20210A1", VA = "0x2020FA0")]
	public void ScreenFade(float fadeTime, Color fadeColor, int fadeStat = 2)
	{
	}

	// Token: 0x06004938 RID: 18744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D30")]
	[Address(RVA = "0x2021160", Offset = "0x2021261", VA = "0x2021160")]
	public void ScreenFade(float fadeTime, int fadeStat)
	{
	}

	// Token: 0x06004939 RID: 18745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D31")]
	[Address(RVA = "0x2021330", Offset = "0x2021431", VA = "0x2021330")]
	public void OverAdvDialogFade(float fadeTime, Color fadeColor, int fadeStat = 2)
	{
	}

	// Token: 0x0600493A RID: 18746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D32")]
	[Address(RVA = "0x20214F0", Offset = "0x20215F1", VA = "0x20214F0")]
	public void OverAdvDialogFade(float fadeTime, int fadeStat)
	{
	}

	// Token: 0x0600493B RID: 18747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D33")]
	[Address(RVA = "0x20216C0", Offset = "0x20217C1", VA = "0x20216C0")]
	public void OverAdvChoiceFade(float fadeTime, Color fadeColor, int fadeStat = 2)
	{
	}

	// Token: 0x0600493C RID: 18748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D34")]
	[Address(RVA = "0x2021880", Offset = "0x2021981", VA = "0x2021880")]
	public void OverAdvChoiceFade(float fadeTime, int fadeStat)
	{
	}

	// Token: 0x0600493D RID: 18749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003D35")]
	[Address(RVA = "0x2021A50", Offset = "0x2021B51", VA = "0x2021A50")]
	public GameObject GetSimpleHpBar()
	{
		return null;
	}

	// Token: 0x0600493E RID: 18750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D36")]
	[Address(RVA = "0x2021B10", Offset = "0x2021C11", VA = "0x2021B10")]
	public void ShowDamage(Vector3 _position, float _damage, UIDamageType _type, bool _is_crit = false, bool _is_weak = false, bool _is_resist = false)
	{
	}

	// Token: 0x0600493F RID: 18751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D37")]
	[Address(RVA = "0x2021C60", Offset = "0x2021D61", VA = "0x2021C60")]
	public void OpenTwoChoicePopup(UnityAction<bool> unityAction, string str, bool StartOnYesButton = true)
	{
	}

	// Token: 0x06004940 RID: 18752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D38")]
	[Address(RVA = "0x2021D40", Offset = "0x2021E41", VA = "0x2021D40")]
	public void OpenNoChoicePopup(UnityAction<bool> unityAction, string str, TextAnchor anchor = TextAnchor.MiddleCenter)
	{
	}

	// Token: 0x06004941 RID: 18753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D39")]
	[Address(RVA = "0x2021E20", Offset = "0x2021F21", VA = "0x2021E20")]
	public void EndTwoChoicePopup()
	{
	}

	// Token: 0x06004942 RID: 18754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D3A")]
	[Address(RVA = "0x2021E30", Offset = "0x2021F31", VA = "0x2021E30")]
	public void EndNoChoicePopup()
	{
	}

	// Token: 0x06004943 RID: 18755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D3B")]
	[Address(RVA = "0x2021E40", Offset = "0x2021F41", VA = "0x2021E40")]
	public void SetCutInTelop(string textId, float stayTime, bool PlaySE)
	{
	}

	// Token: 0x06004944 RID: 18756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D3C")]
	[Address(RVA = "0x2021F10", Offset = "0x2022011", VA = "0x2021F10")]
	private void Update()
	{
	}

	// Token: 0x170009B6 RID: 2486
	// (get) Token: 0x06004945 RID: 18757 RVA: 0x00017B38 File Offset: 0x00015D38
	// (set) Token: 0x06004946 RID: 18758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007BA")]
	public ButtonGuideId usingButtonGuideId
	{
		[Token(Token = "0x6003D3D")]
		[Address(RVA = "0x2021F20", Offset = "0x2022021", VA = "0x2021F20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8890", Offset = "0x1A8991")]
		get
		{
			return ButtonGuideId.None;
		}
		[Token(Token = "0x6003D3E")]
		[Address(RVA = "0x2021F30", Offset = "0x2022031", VA = "0x2021F30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A88A0", Offset = "0x1A89A1")]
		private set
		{
		}
	}

	// Token: 0x06004947 RID: 18759 RVA: 0x00017B50 File Offset: 0x00015D50
	[Token(Token = "0x6003D3F")]
	[Address(RVA = "0x2021F40", Offset = "0x2022041", VA = "0x2021F40")]
	public ButtonGuideId GetNowButtonHintId()
	{
		return ButtonGuideId.None;
	}

	// Token: 0x06004948 RID: 18760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D40")]
	[Address(RVA = "0x201A1E0", Offset = "0x201A2E1", VA = "0x201A1E0")]
	public void SetButtonHint(ButtonGuideId id)
	{
	}

	// Token: 0x06004949 RID: 18761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D41")]
	[Address(RVA = "0x2021F50", Offset = "0x2022051", VA = "0x2021F50")]
	public void SetButtonHint(ButtonType buttonType, TextId textId = TextId.BTNHINT_000)
	{
	}

	// Token: 0x0600494A RID: 18762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D42")]
	[Address(RVA = "0x201E590", Offset = "0x201E691", VA = "0x201E590")]
	public void ClearButtonHint()
	{
	}

	// Token: 0x0600494B RID: 18763 RVA: 0x00017B68 File Offset: 0x00015D68
	[Token(Token = "0x6003D43")]
	[Address(RVA = "0x2012360", Offset = "0x2012461", VA = "0x2012360")]
	public static bool CheckStorageFurniture(StorageType storageType)
	{
		return default(bool);
	}

	// Token: 0x0600494C RID: 18764 RVA: 0x00017B80 File Offset: 0x00015D80
	[Token(Token = "0x6003D44")]
	[Address(RVA = "0x2021F90", Offset = "0x2022091", VA = "0x2021F90")]
	public static bool EnableOpenMenu()
	{
		return default(bool);
	}

	// Token: 0x0600494D RID: 18765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D45")]
	[Address(RVA = "0x2022110", Offset = "0x2022211", VA = "0x2022110")]
	public static void DoScriptUICommand(int valueA)
	{
	}

	// Token: 0x0600494E RID: 18766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D46")]
	[Address(RVA = "0x2022420", Offset = "0x2022521", VA = "0x2022420")]
	public UIMainController()
	{
	}

	// Token: 0x06004950 RID: 18768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D48")]
	[Address(RVA = "0x20224D0", Offset = "0x20225D1", VA = "0x20224D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A88B0", Offset = "0x1A89B1")]
	private void <ScreenFadeChat>b__70_0(bool fade)
	{
	}

	// Token: 0x06004951 RID: 18769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D49")]
	[Address(RVA = "0x2022580", Offset = "0x2022681", VA = "0x2022580")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A88C0", Offset = "0x1A89C1")]
	private void <ScreenFadeChat>b__71_0(bool fade)
	{
	}

	// Token: 0x06004952 RID: 18770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D4A")]
	[Address(RVA = "0x2022630", Offset = "0x2022731", VA = "0x2022630")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A88D0", Offset = "0x1A89D1")]
	private void <ScreenFade>b__72_0(bool fade)
	{
	}

	// Token: 0x06004953 RID: 18771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D4B")]
	[Address(RVA = "0x20226F0", Offset = "0x20227F1", VA = "0x20226F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A88E0", Offset = "0x1A89E1")]
	private void <ScreenFade>b__73_0(bool fade)
	{
	}

	// Token: 0x06004954 RID: 18772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D4C")]
	[Address(RVA = "0x20227B0", Offset = "0x20228B1", VA = "0x20227B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A88F0", Offset = "0x1A89F1")]
	private void <OverAdvDialogFade>b__74_0(bool fade)
	{
	}

	// Token: 0x06004955 RID: 18773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D4D")]
	[Address(RVA = "0x2022870", Offset = "0x2022971", VA = "0x2022870")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8900", Offset = "0x1A8A01")]
	private void <OverAdvDialogFade>b__75_0(bool fade)
	{
	}

	// Token: 0x06004956 RID: 18774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D4E")]
	[Address(RVA = "0x2022930", Offset = "0x2022A31", VA = "0x2022930")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8910", Offset = "0x1A8A11")]
	private void <OverAdvChoiceFade>b__76_0(bool fade)
	{
	}

	// Token: 0x06004957 RID: 18775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D4F")]
	[Address(RVA = "0x20229F0", Offset = "0x2022AF1", VA = "0x20229F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8920", Offset = "0x1A8A21")]
	private void <OverAdvChoiceFade>b__77_0(bool fade)
	{
	}

	// Token: 0x0400A8F9 RID: 43257
	[Token(Token = "0x4007F4C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject[] HUDMainObjectList;

	// Token: 0x0400A8FA RID: 43258
	[Token(Token = "0x4007F4D")]
	[FieldOffset(Offset = "0x20")]
	private uint inputStateFlag;

	// Token: 0x0400A8FB RID: 43259
	[Token(Token = "0x4007F4E")]
	private const uint CursorInputStateBlocker = 15848U;

	// Token: 0x0400A8FC RID: 43260
	[Token(Token = "0x4007F4F")]
	private const uint UISystemInputStateBlocker = 16376U;

	// Token: 0x0400A8FD RID: 43261
	[Token(Token = "0x4007F50")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform _CharactorLog;

	// Token: 0x0400A8FE RID: 43262
	[Token(Token = "0x4007F51")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UIFadeScreen UIFadeScreenAdvChatBlur;

	// Token: 0x0400A8FF RID: 43263
	[Token(Token = "0x4007F52")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UIFadeScreen UIFadeScreenUnderAdv;

	// Token: 0x0400A900 RID: 43264
	[Token(Token = "0x4007F53")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UIFadeScreen UIFadeScreenOverAdv;

	// Token: 0x0400A901 RID: 43265
	[Token(Token = "0x4007F54")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UIFadeScreen UIFadeScreenOverChoice;

	// Token: 0x0400A902 RID: 43266
	[Token(Token = "0x4007F55")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform DamageHpParent;

	// Token: 0x0400A903 RID: 43267
	[Token(Token = "0x4007F56")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private TwoChoicePopupMain TwoChoicePopupMain;

	// Token: 0x0400A904 RID: 43268
	[Token(Token = "0x4007F57")]
	[FieldOffset(Offset = "0x60")]
	private TwoChoicePopupMain nowTwoChoicePopupMain;

	// Token: 0x0400A905 RID: 43269
	[Token(Token = "0x4007F58")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private NoChoicePopupMain NoChoicePopupMain;

	// Token: 0x0400A906 RID: 43270
	[Token(Token = "0x4007F59")]
	[FieldOffset(Offset = "0x70")]
	private NoChoicePopupMain nowNoChoicePopupMain;

	// Token: 0x0400A907 RID: 43271
	[Token(Token = "0x4007F5A")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private CutInTelopControl CutInTelopControl;

	// Token: 0x0400A908 RID: 43272
	[Token(Token = "0x4007F5B")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private RectTransform _MinigameUI;

	// Token: 0x0400A909 RID: 43273
	[Token(Token = "0x4007F5C")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private ButtonHintMain ButtonHintMain;

	// Token: 0x0400A90A RID: 43274
	[Token(Token = "0x4007F5D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Canvas AddSystemPopupCanvas;

	// Token: 0x0400A90B RID: 43275
	[Token(Token = "0x4007F5E")]
	[FieldOffset(Offset = "0x98")]
	public GameObject UIBackScreenObject;

	// Token: 0x0400A90C RID: 43276
	[Token(Token = "0x4007F5F")]
	[FieldOffset(Offset = "0xA0")]
	public CampMenuMain CampMenuMain;

	// Token: 0x0400A90D RID: 43277
	[Token(Token = "0x4007F60")]
	[FieldOffset(Offset = "0xA8")]
	public string CurrentMap;

	// Token: 0x0400A90E RID: 43278
	[Token(Token = "0x4007F61")]
	[FieldOffset(Offset = "0xB0")]
	public string FieldSceneName;

	// Token: 0x0400A90F RID: 43279
	[Token(Token = "0x4007F62")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject SetOnField;

	// Token: 0x0400A910 RID: 43280
	[Token(Token = "0x4007F63")]
	[FieldOffset(Offset = "0xC0")]
	private List<Light> _RealtimeBakeLightList;

	// Token: 0x0400A911 RID: 43281
	[Token(Token = "0x4007F64")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1744A0", Offset = "0x1745A1")]
	private bool <PlayerHoldNotItemOnHand>k__BackingField;

	// Token: 0x0400A912 RID: 43282
	[Token(Token = "0x4007F65")]
	[FieldOffset(Offset = "0xC9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1744B0", Offset = "0x1745B1")]
	private bool <PlayerRiding>k__BackingField;

	// Token: 0x0400A913 RID: 43283
	[Token(Token = "0x4007F66")]
	[FieldOffset(Offset = "0xD0")]
	private RenameMobControl RenameMobControl;

	// Token: 0x0400A914 RID: 43284
	[Token(Token = "0x4007F67")]
	[FieldOffset(Offset = "0x0")]
	private static int ScreenFadeUsing;

	// Token: 0x0400A915 RID: 43285
	[Token(Token = "0x4007F68")]
	private const int ScreenFilter_AdvChatBlur = 1;

	// Token: 0x0400A916 RID: 43286
	[Token(Token = "0x4007F69")]
	private const int ScreenFilter_UnderAdv = 2;

	// Token: 0x0400A917 RID: 43287
	[Token(Token = "0x4007F6A")]
	private const int ScreenFilter_OverAdv = 4;

	// Token: 0x0400A918 RID: 43288
	[Token(Token = "0x4007F6B")]
	private const int ScreenFilter_OverChoice = 8;

	// Token: 0x0400A919 RID: 43289
	[Token(Token = "0x4007F6C")]
	[FieldOffset(Offset = "0xD8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1744C0", Offset = "0x1745C1")]
	private ButtonGuideId <usingButtonGuideId>k__BackingField;

	// Token: 0x02000B0C RID: 2828
	[Token(Token = "0x2001330")]
	public enum UIInputState
	{
		// Token: 0x0400A91B RID: 43291
		[Token(Token = "0x401B611")]
		Camp = 1,
		// Token: 0x0400A91C RID: 43292
		[Token(Token = "0x401B612")]
		Loader = 4,
		// Token: 0x0400A91D RID: 43293
		[Token(Token = "0x401B613")]
		ChoicesPopup = 8,
		// Token: 0x0400A91E RID: 43294
		[Token(Token = "0x401B614")]
		TalkDialog = 16,
		// Token: 0x0400A91F RID: 43295
		[Token(Token = "0x401B615")]
		Quick = 32,
		// Token: 0x0400A920 RID: 43296
		[Token(Token = "0x401B616")]
		Shop = 64,
		// Token: 0x0400A921 RID: 43297
		[Token(Token = "0x401B617")]
		Debug = 128,
		// Token: 0x0400A922 RID: 43298
		[Token(Token = "0x401B618")]
		CampEquip = 256,
		// Token: 0x0400A923 RID: 43299
		[Token(Token = "0x401B619")]
		CampFriendPage = 512,
		// Token: 0x0400A924 RID: 43300
		[Token(Token = "0x401B61A")]
		TwoChoicesPopup = 1024,
		// Token: 0x0400A925 RID: 43301
		[Token(Token = "0x401B61B")]
		MiniGame = 2048,
		// Token: 0x0400A926 RID: 43302
		[Token(Token = "0x401B61C")]
		Saving = 4096,
		// Token: 0x0400A927 RID: 43303
		[Token(Token = "0x401B61D")]
		SortMenu = 8192
	}

	// Token: 0x02000B0D RID: 2829
	[Token(Token = "0x2001331")]
	private struct StorageFurenitureID
	{
		// Token: 0x0400A928 RID: 43304
		[Token(Token = "0x401B61E")]
		[FieldOffset(Offset = "0x0")]
		private StorageType storage;

		// Token: 0x0400A929 RID: 43305
		[Token(Token = "0x401B61F")]
		[FieldOffset(Offset = "0x4")]
		private FurnitureID furniture;
	}
}
