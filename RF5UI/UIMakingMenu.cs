using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace RF5UI
{
	// Token: 0x02000E9A RID: 3738
	[Token(Token = "0x2000993")]
	public class UIMakingMenu : CursorLinkConnector
	{
		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060061AE RID: 25006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EF")]
		private AdvDialogControl AdvDialogControl
		{
			[Token(Token = "0x60050DC")]
			[Address(RVA = "0x1F2D9D0", Offset = "0x1F2DAD1", VA = "0x1F2D9D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060061AF RID: 25007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F0")]
		private string PlayerName
		{
			[Token(Token = "0x60050DD")]
			[Address(RVA = "0x1F2DAE0", Offset = "0x1F2DBE1", VA = "0x1F2DAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DE")]
		[Address(RVA = "0x1F2DC60", Offset = "0x1F2DD61", VA = "0x1F2DC60")]
		private List<int> GetMakingIds(MakingID[] Table, bool Checker)
		{
			return null;
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050DF")]
		[Address(RVA = "0x1F2DE00", Offset = "0x1F2DF01", VA = "0x1F2DE00")]
		private void SetBackUI(bool open)
		{
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		[Token(Token = "0x60050E0")]
		[Address(RVA = "0x1F2DE90", Offset = "0x1F2DF91", VA = "0x1F2DE90")]
		private int GetSeasonFromMakingId(int id)
		{
			return 0;
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050E1")]
		[Address(RVA = "0x1F2DF20", Offset = "0x1F2E021", VA = "0x1F2DF20")]
		private MakingID[] GetNowSeasonFestivalTable()
		{
			return null;
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E2")]
		[Address(RVA = "0x1F2E580", Offset = "0x1F2E681", VA = "0x1F2E580")]
		private void SetNormalMakingID()
		{
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E3")]
		[Address(RVA = "0x1F2E770", Offset = "0x1F2E871", VA = "0x1F2E770")]
		private void SetMakingIDOnTutorialRuck()
		{
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E4")]
		[Address(RVA = "0x1F2E930", Offset = "0x1F2EA31", VA = "0x1F2E930")]
		private void SetMakingIDOnTutorialFes()
		{
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E5")]
		[Address(RVA = "0x1F2EAE0", Offset = "0x1F2EBE1", VA = "0x1F2EAE0")]
		private void SetMakingID()
		{
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E6")]
		[Address(RVA = "0x1F2EB80", Offset = "0x1F2EC81", VA = "0x1F2EB80")]
		private void SetChoiceID()
		{
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E7")]
		[Address(RVA = "0x1F2ECA0", Offset = "0x1F2EDA1", VA = "0x1F2ECA0")]
		private void ShowHeadChoice()
		{
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E8")]
		[Address(RVA = "0x1F2F420", Offset = "0x1F2F521", VA = "0x1F2F420")]
		private void ShowMakingChoice(int headId, [Optional] List<int> idList)
		{
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050E9")]
		[Address(RVA = "0x1F30C80", Offset = "0x1F30D81", VA = "0x1F30C80")]
		private void CallbackHead(int select)
		{
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EA")]
		[Address(RVA = "0x1F31080", Offset = "0x1F31181", VA = "0x1F31080")]
		private void CallBackFromNotEnough()
		{
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EB")]
		[Address(RVA = "0x1F31090", Offset = "0x1F31191", VA = "0x1F31090")]
		private void CallbackMakingSelect(int select)
		{
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EC")]
		[Address(RVA = "0x1F32080", Offset = "0x1F32181", VA = "0x1F32080")]
		public void HeadEquipItemRelease(int select)
		{
		}

		// Token: 0x060061BF RID: 25023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050ED")]
		[Address(RVA = "0x1F32210", Offset = "0x1F32311", VA = "0x1F32210")]
		public void CancelLoadOtherSave()
		{
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EE")]
		[Address(RVA = "0x1F32220", Offset = "0x1F32321", VA = "0x1F32220")]
		public void LicenseQuizFail()
		{
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050EF")]
		[Address(RVA = "0x1F31CC0", Offset = "0x1F31DC1", VA = "0x1F31CC0")]
		public void DoSuccess(MakingID MakingID)
		{
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F0")]
		[Address(RVA = "0x1F32290", Offset = "0x1F32391", VA = "0x1F32290")]
		private void DoSuccessAnimate()
		{
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F1")]
		[Address(RVA = "0x1F324C0", Offset = "0x1F325C1", VA = "0x1F324C0")]
		public void SuccessAnimateEnd()
		{
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F2")]
		[Address(RVA = "0x1F31BD0", Offset = "0x1F31CD1", VA = "0x1F31BD0")]
		public void SuccessEnd(MakingID MakingID)
		{
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F3")]
		[Address(RVA = "0x1F32900", Offset = "0x1F32A01", VA = "0x1F32900")]
		public void SuccessAnimateEndAfterAdv()
		{
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050F4")]
		[Address(RVA = "0x1F32A30", Offset = "0x1F32B31", VA = "0x1F32A30")]
		private string GetDoAfterScript()
		{
			return null;
		}

		// Token: 0x060061C7 RID: 25031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F5")]
		[Address(RVA = "0x1F32DB0", Offset = "0x1F32EB1", VA = "0x1F32DB0")]
		public void AfterScriptAfterSuccessAnimateEnd()
		{
		}

		// Token: 0x060061C8 RID: 25032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F6")]
		[Address(RVA = "0x1F30EA0", Offset = "0x1F30FA1", VA = "0x1F30EA0")]
		private void Close()
		{
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F7")]
		[Address(RVA = "0x1F323A0", Offset = "0x1F324A1", VA = "0x1F323A0")]
		private void SetPause()
		{
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F8")]
		[Address(RVA = "0x1F2F370", Offset = "0x1F2F471", VA = "0x1F2F370")]
		private void AppearBustup()
		{
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050F9")]
		[Address(RVA = "0x1F32F10", Offset = "0x1F33011", VA = "0x1F32F10")]
		private void ClearBustup()
		{
		}

		// Token: 0x060061CC RID: 25036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FA")]
		[Address(RVA = "0x1F32FC0", Offset = "0x1F330C1", VA = "0x1F32FC0")]
		public void BackToMenu()
		{
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FB")]
		[Address(RVA = "0x1F32FE0", Offset = "0x1F330E1", VA = "0x1F32FE0")]
		private void Start()
		{
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FC")]
		[Address(RVA = "0x1F330C0", Offset = "0x1F331C1", VA = "0x1F330C0")]
		private void InitMoneyText()
		{
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FD")]
		[Address(RVA = "0x1F33390", Offset = "0x1F33491", VA = "0x1F33390")]
		private void LateUpdate()
		{
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FE")]
		[Address(RVA = "0x1F30C70", Offset = "0x1F30D71", VA = "0x1F30C70")]
		private string ConvertToFullWidth(string halfWidthStr)
		{
			return null;
		}

		// Token: 0x060061D1 RID: 25041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FF")]
		[Address(RVA = "0x1F33800", Offset = "0x1F33901", VA = "0x1F33800")]
		public UIMakingMenu()
		{
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005100")]
		[Address(RVA = "0x1F33A00", Offset = "0x1F33B01", VA = "0x1F33A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC7D0", Offset = "0x1AC8D1")]
		private void <CallbackMakingSelect>b__32_0(int a)
		{
		}

		// Token: 0x0400C16B RID: 49515
		[Token(Token = "0x40090FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private PopupChoiceControl PopupChoiceControl;

		// Token: 0x0400C16C RID: 49516
		[Token(Token = "0x40090FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<int> makingHeadChoiceIDs;

		// Token: 0x0400C16D RID: 49517
		[Token(Token = "0x4009100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<List<int>> makingIDs;

		// Token: 0x0400C16E RID: 49518
		[Token(Token = "0x4009101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MakingTable MakingTable;

		// Token: 0x0400C16F RID: 49519
		[Token(Token = "0x4009102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIFadeOnOffAnimate UIFadeOnOffAnimate;

		// Token: 0x0400C170 RID: 49520
		[Token(Token = "0x4009103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIOnOffAnimate PlayerMoneyBarAnimate;

		// Token: 0x0400C171 RID: 49521
		[Token(Token = "0x4009104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int selectedHeadId;

		// Token: 0x0400C172 RID: 49522
		[Token(Token = "0x4009105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Animator OrderSuccessAnimator;

		// Token: 0x0400C173 RID: 49523
		[Token(Token = "0x4009106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Animator useOrderSuccessAnimator;

		// Token: 0x0400C174 RID: 49524
		[Token(Token = "0x4009107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private MakingID DoSuccessID;

		// Token: 0x0400C175 RID: 49525
		[Token(Token = "0x4009108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool isWaitingAfterSuccessTalkEnd;

		// Token: 0x0400C176 RID: 49526
		[Token(Token = "0x4009109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<int> selectNpcList;

		// Token: 0x0400C177 RID: 49527
		[Token(Token = "0x400910A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AdvDialogControl _AdvDialogControl;

		// Token: 0x0400C178 RID: 49528
		[Token(Token = "0x400910B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UISaveMenuManager UIMakingSaveLoadMenu;

		// Token: 0x0400C179 RID: 49529
		[Token(Token = "0x400910C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly string[] SeasonTextId;

		// Token: 0x0400C17A RID: 49530
		[Token(Token = "0x400910D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text PlayerMoneyText;

		// Token: 0x0400C17B RID: 49531
		[Token(Token = "0x400910E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Text PlayerPointText;

		// Token: 0x0400C17C RID: 49532
		[Token(Token = "0x400910F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text PlayerStoneText;

		// Token: 0x0400C17D RID: 49533
		[Token(Token = "0x4009110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text PlayerLumberText;

		// Token: 0x0400C17E RID: 49534
		[Token(Token = "0x4009111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private long NowDispPlayerMoney;

		// Token: 0x0400C17F RID: 49535
		[Token(Token = "0x4009112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private long NowDispPlayerPoint;

		// Token: 0x0400C180 RID: 49536
		[Token(Token = "0x4009113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private long NowDispPlayerStone;

		// Token: 0x0400C181 RID: 49537
		[Token(Token = "0x4009114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private long NowDispPlayerLumber;
	}
}
