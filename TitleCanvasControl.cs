using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using Loader;
using SaveData;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

// Token: 0x02000AE2 RID: 2786
[Token(Token = "0x200074B")]
public class TitleCanvasControl : MonoBehaviour
{
	// Token: 0x06004855 RID: 18517
	[Token(Token = "0x6003C94")]
	[Address(RVA = "0x206DEB0", Offset = "0x206DFB1", VA = "0x206DEB0")]
	[PreserveSig]
	private static extern void OpenURL(string url);

	// Token: 0x17000997 RID: 2455
	// (get) Token: 0x06004856 RID: 18518 RVA: 0x00017820 File Offset: 0x00015A20
	[Token(Token = "0x170007AF")]
	public bool IsOffInput
	{
		[Token(Token = "0x6003C95")]
		[Address(RVA = "0x206DEE0", Offset = "0x206DFE1", VA = "0x206DEE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06004857 RID: 18519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C96")]
	[Address(RVA = "0x206DEF0", Offset = "0x206DFF1", VA = "0x206DEF0")]
	private void Start()
	{
	}

	// Token: 0x06004858 RID: 18520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C97")]
	[Address(RVA = "0x206E320", Offset = "0x206E421", VA = "0x206E320")]
	private void Update()
	{
	}

	// Token: 0x06004859 RID: 18521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C98")]
	[Address(RVA = "0x206F6F0", Offset = "0x206F7F1", VA = "0x206F6F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600485A RID: 18522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C99")]
	[Address(RVA = "0x206F470", Offset = "0x206F571", VA = "0x206F470")]
	private void DoButton()
	{
	}

	// Token: 0x0600485B RID: 18523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C9A")]
	[Address(RVA = "0x206F080", Offset = "0x206F181", VA = "0x206F080")]
	private void updatePressButton()
	{
	}

	// Token: 0x0600485C RID: 18524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003C9B")]
	[Address(RVA = "0x206F7E0", Offset = "0x206F8E1", VA = "0x206F7E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8330", Offset = "0x1A8431")]
	private IEnumerator createBg(int id)
	{
		return null;
	}

	// Token: 0x0600485D RID: 18525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C9C")]
	[Address(RVA = "0x206F8A0", Offset = "0x206F9A1", VA = "0x206F8A0")]
	private void initUI()
	{
	}

	// Token: 0x0600485E RID: 18526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C9D")]
	[Address(RVA = "0x206EDA0", Offset = "0x206EEA1", VA = "0x206EDA0")]
	private void setUI()
	{
	}

	// Token: 0x0600485F RID: 18527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C9E")]
	[Address(RVA = "0x206F5E0", Offset = "0x206F6E1", VA = "0x206F5E0")]
	private void updateMovieFade()
	{
	}

	// Token: 0x06004860 RID: 18528 RVA: 0x00017838 File Offset: 0x00015A38
	[Token(Token = "0x6003C9F")]
	[Address(RVA = "0x206E000", Offset = "0x206E101", VA = "0x206E000")]
	private int getButtonMax()
	{
		return 0;
	}

	// Token: 0x06004861 RID: 18529 RVA: 0x00017850 File Offset: 0x00015A50
	[Token(Token = "0x6003CA0")]
	[Address(RVA = "0x206F8E0", Offset = "0x206F9E1", VA = "0x206F8E0")]
	private int getTitleMenuType(RegionDefine.Region region)
	{
		return 0;
	}

	// Token: 0x06004862 RID: 18530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CA1")]
	[Address(RVA = "0x206E0A0", Offset = "0x206E1A1", VA = "0x206E0A0")]
	private void initButtonMenu()
	{
	}

	// Token: 0x06004863 RID: 18531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CA2")]
	[Address(RVA = "0x206FB40", Offset = "0x206FC41", VA = "0x206FB40")]
	private void SetFocusButtonMenu(TitleCanvasControl.TitleButtonType type)
	{
	}

	// Token: 0x06004864 RID: 18532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CA3")]
	[Address(RVA = "0x206F900", Offset = "0x206FA01", VA = "0x206F900")]
	private void initButtonPos()
	{
	}

	// Token: 0x06004865 RID: 18533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CA4")]
	[Address(RVA = "0x206F1D0", Offset = "0x206F2D1", VA = "0x206F1D0")]
	private void updateButtonNo(int addVal)
	{
	}

	// Token: 0x06004866 RID: 18534 RVA: 0x00017868 File Offset: 0x00015A68
	[Token(Token = "0x6003CA5")]
	[Address(RVA = "0x206FD50", Offset = "0x206FE51", VA = "0x206FD50")]
	private bool IsGameData()
	{
		return default(bool);
	}

	// Token: 0x06004867 RID: 18535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CA6")]
	[Address(RVA = "0x206DA50", Offset = "0x206DB51", VA = "0x206DA50")]
	public void StartButton(TitleCanvasControl.TitleButtonType type)
	{
	}

	// Token: 0x06004868 RID: 18536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CA7")]
	[Address(RVA = "0x206FE30", Offset = "0x206FF31", VA = "0x206FE30")]
	private void OpenOnlineManual(string manualUrl)
	{
	}

	// Token: 0x06004869 RID: 18537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CA8")]
	[Address(RVA = "0x206F310", Offset = "0x206F411", VA = "0x206F310")]
	private void setButtonActive(bool flag)
	{
	}

	// Token: 0x0600486A RID: 18538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CA9")]
	[Address(RVA = "0x206FE60", Offset = "0x206FF61", VA = "0x206FE60")]
	public void titleCanvasReset()
	{
	}

	// Token: 0x0600486B RID: 18539 RVA: 0x00017880 File Offset: 0x00015A80
	[Token(Token = "0x6003CAA")]
	[Address(RVA = "0x206FFC0", Offset = "0x20700C1", VA = "0x206FFC0")]
	public TitleCanvasControl.TitleStep getStep()
	{
		return TitleCanvasControl.TitleStep.Init;
	}

	// Token: 0x0600486C RID: 18540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CAB")]
	[Address(RVA = "0x206FFD0", Offset = "0x20700D1", VA = "0x206FFD0")]
	public void setStep(TitleCanvasControl.TitleStep stepno)
	{
	}

	// Token: 0x0600486D RID: 18541 RVA: 0x00017898 File Offset: 0x00015A98
	[Token(Token = "0x6003CAC")]
	[Address(RVA = "0x206FFE0", Offset = "0x20700E1", VA = "0x206FFE0")]
	public bool getInputFlg()
	{
		return default(bool);
	}

	// Token: 0x0600486E RID: 18542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CAD")]
	[Address(RVA = "0x206FFF0", Offset = "0x20700F1", VA = "0x206FFF0")]
	public void setInputFlg(bool flg)
	{
	}

	// Token: 0x0600486F RID: 18543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CAE")]
	[Address(RVA = "0x2070000", Offset = "0x2070101", VA = "0x2070000")]
	public void setMovieFadeOut(float time)
	{
	}

	// Token: 0x06004870 RID: 18544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CAF")]
	[Address(RVA = "0x2070010", Offset = "0x2070111", VA = "0x2070010")]
	public void setMovieFadeIn(float time)
	{
	}

	// Token: 0x06004871 RID: 18545 RVA: 0x000178B0 File Offset: 0x00015AB0
	[Token(Token = "0x6003CB0")]
	[Address(RVA = "0x2070030", Offset = "0x2070131", VA = "0x2070030")]
	public bool isPlayingMovieFade()
	{
		return default(bool);
	}

	// Token: 0x06004872 RID: 18546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CB1")]
	[Address(RVA = "0x206D830", Offset = "0x206D931", VA = "0x206D830")]
	public void touchTitleButton(int no)
	{
	}

	// Token: 0x06004873 RID: 18547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CB2")]
	[Address(RVA = "0x2070040", Offset = "0x2070141", VA = "0x2070040")]
	public TitleCanvasControl()
	{
	}

	// Token: 0x06004874 RID: 18548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CB3")]
	[Address(RVA = "0x2070B70", Offset = "0x2070C71", VA = "0x2070B70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A83A0", Offset = "0x1A84A1")]
	private void <Update>b__58_1(DLCID[] dlcids)
	{
	}

	// Token: 0x06004875 RID: 18549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CB4")]
	[Address(RVA = "0x2070FE0", Offset = "0x20710E1", VA = "0x2070FE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A83B0", Offset = "0x1A84B1")]
	private void <Update>b__58_0(bool a)
	{
	}

	// Token: 0x06004876 RID: 18550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CB5")]
	[Address(RVA = "0x2070FF0", Offset = "0x20710F1", VA = "0x2070FF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A83C0", Offset = "0x1A84C1")]
	private void <StartButton>b__73_1(bool a)
	{
	}

	// Token: 0x06004877 RID: 18551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CB6")]
	[Address(RVA = "0x20710F0", Offset = "0x20711F1", VA = "0x20710F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A83D0", Offset = "0x1A84D1")]
	private void <StartButton>b__73_0()
	{
	}

	// Token: 0x06004878 RID: 18552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CB7")]
	[Address(RVA = "0x2071100", Offset = "0x2071201", VA = "0x2071100")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A83E0", Offset = "0x1A84E1")]
	private void <StartButton>b__73_2(bool a)
	{
	}

	// Token: 0x0400A7C0 RID: 42944
	[Token(Token = "0x4007ECC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TitleButton[] ButtonList;

	// Token: 0x0400A7C1 RID: 42945
	[Token(Token = "0x4007ECD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int focusing;

	// Token: 0x0400A7C2 RID: 42946
	[Token(Token = "0x4007ECE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Canvas buttonCanvas;

	// Token: 0x0400A7C3 RID: 42947
	[Token(Token = "0x4007ECF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform buttonCanRect;

	// Token: 0x0400A7C4 RID: 42948
	[Token(Token = "0x4007ED0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Canvas pressCanvas;

	// Token: 0x0400A7C5 RID: 42949
	[Token(Token = "0x4007ED1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image pressText;

	// Token: 0x0400A7C6 RID: 42950
	[Token(Token = "0x4007ED2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image pressBorder;

	// Token: 0x0400A7C7 RID: 42951
	[Token(Token = "0x4007ED3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform menuBgRect;

	// Token: 0x0400A7C8 RID: 42952
	[Token(Token = "0x4007ED4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private VoiceComment voiceComment;

	// Token: 0x0400A7C9 RID: 42953
	[Token(Token = "0x4007ED5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private LanguageWindow langWindowCntl;

	// Token: 0x0400A7CA RID: 42954
	[Token(Token = "0x4007ED6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private LoadLogoAnim loadLogoAnimCntl;

	// Token: 0x0400A7CB RID: 42955
	[Token(Token = "0x4007ED7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image imgFade;

	// Token: 0x0400A7CC RID: 42956
	[Token(Token = "0x4007ED8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject objTouchScreen;

	// Token: 0x0400A7CD RID: 42957
	[Token(Token = "0x4007ED9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private TwoChoicePopupLite TwoChoicePopupLite;

	// Token: 0x0400A7CE RID: 42958
	[Token(Token = "0x4007EDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private NoChoicePopupLite NoChoicePopupLite;

	// Token: 0x0400A7CF RID: 42959
	[Token(Token = "0x4007EDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private TitleCanvasControl.TitleButtonType btnType;

	// Token: 0x0400A7D0 RID: 42960
	[Token(Token = "0x4007EDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool ButtonStarted;

	// Token: 0x0400A7D1 RID: 42961
	[Token(Token = "0x4007EDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float fadeTime;

	// Token: 0x0400A7D2 RID: 42962
	[Token(Token = "0x4007EDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float fadeTimeMax;

	// Token: 0x0400A7D3 RID: 42963
	[Token(Token = "0x4007EDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int fadeType;

	// Token: 0x0400A7D4 RID: 42964
	[Token(Token = "0x4007EE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Sprite _sprBg;

	// Token: 0x0400A7D5 RID: 42965
	[Token(Token = "0x4007EE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Image _imgBg;

	// Token: 0x0400A7D6 RID: 42966
	[Token(Token = "0x4007EE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int _sprId;

	// Token: 0x0400A7D7 RID: 42967
	[Token(Token = "0x4007EE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private TitleCanvasControl.TitleStep step;

	// Token: 0x0400A7D8 RID: 42968
	[Token(Token = "0x4007EE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float pressSin;

	// Token: 0x0400A7D9 RID: 42969
	[Token(Token = "0x4007EE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private TitleMenu titleMenu;

	// Token: 0x0400A7DA RID: 42970
	[Token(Token = "0x4007EE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float stayTime;

	// Token: 0x0400A7DB RID: 42971
	[Token(Token = "0x4007EE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int charaAnimStep;

	// Token: 0x0400A7DC RID: 42972
	[Token(Token = "0x4007EE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool inputFlg;

	// Token: 0x0400A7DD RID: 42973
	[Token(Token = "0x4007EE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
	private bool m_touchBtn;

	// Token: 0x0400A7DE RID: 42974
	[Token(Token = "0x4007EEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private SoundID callId;

	// Token: 0x0400A7DF RID: 42975
	[Token(Token = "0x4007EEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private PlayableDirector logoAnimTimeline;

	// Token: 0x0400A7E0 RID: 42976
	[Token(Token = "0x4007EEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool autosaveMessFlg;

	// Token: 0x0400A7E1 RID: 42977
	[Token(Token = "0x4007EED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private SoundID[] TitleCallList;

	// Token: 0x0400A7E2 RID: 42978
	[Token(Token = "0x4007EEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int[] TitleCallRate;

	// Token: 0x0400A7E3 RID: 42979
	[Token(Token = "0x4007EEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Dictionary<TitleCanvasControl.TitleCallID, RF5SystemData.FLAG> TitleCallIdToFlag;

	// Token: 0x0400A7E4 RID: 42980
	[Token(Token = "0x4007EF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private TitleCanvasControl.TitleButtonType[,] menuList;

	// Token: 0x0400A7E5 RID: 42981
	[Token(Token = "0x4007EF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float[,] MenuBtnLayoutList;

	// Token: 0x0400A7E6 RID: 42982
	[Token(Token = "0x4007EF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int[] MenuListLayoutY;

	// Token: 0x0400A7E7 RID: 42983
	[Token(Token = "0x4007EF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int btnListMax;

	// Token: 0x0400A7E8 RID: 42984
	[Token(Token = "0x4007EF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private int btnSelect;

	// Token: 0x0400A7E9 RID: 42985
	[Token(Token = "0x4007EF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private int btnListType;

	// Token: 0x0400A7EA RID: 42986
	[Token(Token = "0x4007EF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private string[] dlcTextName4sp;

	// Token: 0x0400A7EB RID: 42987
	[Token(Token = "0x4007EF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private string[] dlcTextNameLimited;

	// Token: 0x0400A7EC RID: 42988
	[Token(Token = "0x4007EF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private string[] dlcTextNameShopList;

	// Token: 0x0400A7ED RID: 42989
	[Token(Token = "0x4007EF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private string dlcCosInfoTextName;

	// Token: 0x0400A7EE RID: 42990
	[Token(Token = "0x4007EFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private string dlcItemInfoTextName;

	// Token: 0x0400A7EF RID: 42991
	[Token(Token = "0x4007EFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private List<string> dlcMessList;

	// Token: 0x0400A7F0 RID: 42992
	[Token(Token = "0x4007EFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private bool addDLCCosFlg;

	// Token: 0x0400A7F1 RID: 42993
	[Token(Token = "0x4007EFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
	private bool addDLCItemFlg;

	// Token: 0x0400A7F2 RID: 42994
	[Token(Token = "0x4007EFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[SerializeField]
	private GameObject LoadGamePage;

	// Token: 0x02000AE3 RID: 2787
	[Token(Token = "0x2001319")]
	public enum TitleButtonType
	{
		// Token: 0x0400A7F4 RID: 42996
		[Token(Token = "0x401B558")]
		None = -1,
		// Token: 0x0400A7F5 RID: 42997
		[Token(Token = "0x401B559")]
		StartDebugGame,
		// Token: 0x0400A7F6 RID: 42998
		[Token(Token = "0x401B55A")]
		StartGame,
		// Token: 0x0400A7F7 RID: 42999
		[Token(Token = "0x401B55B")]
		OpenLoadMenu,
		// Token: 0x0400A7F8 RID: 43000
		[Token(Token = "0x401B55C")]
		OpenVoiceComment,
		// Token: 0x0400A7F9 RID: 43001
		[Token(Token = "0x401B55D")]
		OpenOnlineManual,
		// Token: 0x0400A7FA RID: 43002
		[Token(Token = "0x401B55E")]
		OpenLanguage
	}

	// Token: 0x02000AE4 RID: 2788
	[Token(Token = "0x200131A")]
	public enum TitleStep
	{
		// Token: 0x0400A7FC RID: 43004
		[Token(Token = "0x401B560")]
		Init,
		// Token: 0x0400A7FD RID: 43005
		[Token(Token = "0x401B561")]
		FadeEnd,
		// Token: 0x0400A7FE RID: 43006
		[Token(Token = "0x401B562")]
		TitleAnimStart,
		// Token: 0x0400A7FF RID: 43007
		[Token(Token = "0x401B563")]
		TitleAnim,
		// Token: 0x0400A800 RID: 43008
		[Token(Token = "0x401B564")]
		PressAny,
		// Token: 0x0400A801 RID: 43009
		[Token(Token = "0x401B565")]
		Check4SpData,
		// Token: 0x0400A802 RID: 43010
		[Token(Token = "0x401B566")]
		CheckDLC,
		// Token: 0x0400A803 RID: 43011
		[Token(Token = "0x401B567")]
		CheckDLC_,
		// Token: 0x0400A804 RID: 43012
		[Token(Token = "0x401B568")]
		StayDLC,
		// Token: 0x0400A805 RID: 43013
		[Token(Token = "0x401B569")]
		StayDLC_,
		// Token: 0x0400A806 RID: 43014
		[Token(Token = "0x401B56A")]
		EndDLC,
		// Token: 0x0400A807 RID: 43015
		[Token(Token = "0x401B56B")]
		OpenMenu,
		// Token: 0x0400A808 RID: 43016
		[Token(Token = "0x401B56C")]
		OpenMenu_,
		// Token: 0x0400A809 RID: 43017
		[Token(Token = "0x401B56D")]
		SelectMenu,
		// Token: 0x0400A80A RID: 43018
		[Token(Token = "0x401B56E")]
		SelectLang,
		// Token: 0x0400A80B RID: 43019
		[Token(Token = "0x401B56F")]
		ChangeLang,
		// Token: 0x0400A80C RID: 43020
		[Token(Token = "0x401B570")]
		ChangeEndLang,
		// Token: 0x0400A80D RID: 43021
		[Token(Token = "0x401B571")]
		SelectLoad,
		// Token: 0x0400A80E RID: 43022
		[Token(Token = "0x401B572")]
		SelectVoiceComment,
		// Token: 0x0400A80F RID: 43023
		[Token(Token = "0x401B573")]
		offInput,
		// Token: 0x0400A810 RID: 43024
		[Token(Token = "0x401B574")]
		StayFadeGameStart,
		// Token: 0x0400A811 RID: 43025
		[Token(Token = "0x401B575")]
		EndFadeGameStart,
		// Token: 0x0400A812 RID: 43026
		[Token(Token = "0x401B576")]
		SelectManual,
		// Token: 0x0400A813 RID: 43027
		[Token(Token = "0x401B577")]
		StayGameStart
	}

	// Token: 0x02000AE5 RID: 2789
	[Token(Token = "0x200131B")]
	public enum TitleCallID
	{
		// Token: 0x0400A815 RID: 43029
		[Token(Token = "0x401B579")]
		VOICE_Are_2_001_1,
		// Token: 0x0400A816 RID: 43030
		[Token(Token = "0x401B57A")]
		VOICE_Are_2_001_2,
		// Token: 0x0400A817 RID: 43031
		[Token(Token = "0x401B57B")]
		VOICE_Ali_2_001_1,
		// Token: 0x0400A818 RID: 43032
		[Token(Token = "0x401B57C")]
		VOICE_Ali_2_001_2,
		// Token: 0x0400A819 RID: 43033
		[Token(Token = "0x401B57D")]
		VOICE_Prs_2_001,
		// Token: 0x0400A81A RID: 43034
		[Token(Token = "0x401B57E")]
		VOICE_Prs_2_002,
		// Token: 0x0400A81B RID: 43035
		[Token(Token = "0x401B57F")]
		VOICE_Luy_2_001,
		// Token: 0x0400A81C RID: 43036
		[Token(Token = "0x401B580")]
		VOICE_Luy_2_002,
		// Token: 0x0400A81D RID: 43037
		[Token(Token = "0x401B581")]
		VOICE_Sca_2_001,
		// Token: 0x0400A81E RID: 43038
		[Token(Token = "0x401B582")]
		VOICE_Sca_2_002,
		// Token: 0x0400A81F RID: 43039
		[Token(Token = "0x401B583")]
		VOICE_Fuq_2_001,
		// Token: 0x0400A820 RID: 43040
		[Token(Token = "0x401B584")]
		VOICE_Fuq_2_002,
		// Token: 0x0400A821 RID: 43041
		[Token(Token = "0x401B585")]
		VOICE_Bea_2_001,
		// Token: 0x0400A822 RID: 43042
		[Token(Token = "0x401B586")]
		VOICE_Bea_2_002,
		// Token: 0x0400A823 RID: 43043
		[Token(Token = "0x401B587")]
		VOICE_Ldm_2_001,
		// Token: 0x0400A824 RID: 43044
		[Token(Token = "0x401B588")]
		VOICE_Ldm_2_002,
		// Token: 0x0400A825 RID: 43045
		[Token(Token = "0x401B589")]
		VOICE_Mtn_2_001,
		// Token: 0x0400A826 RID: 43046
		[Token(Token = "0x401B58A")]
		VOICE_Mtn_2_002,
		// Token: 0x0400A827 RID: 43047
		[Token(Token = "0x401B58B")]
		VOICE_Cec_2_001,
		// Token: 0x0400A828 RID: 43048
		[Token(Token = "0x401B58C")]
		VOICE_Cec_2_002,
		// Token: 0x0400A829 RID: 43049
		[Token(Token = "0x401B58D")]
		VOICE_Mur_2_001,
		// Token: 0x0400A82A RID: 43050
		[Token(Token = "0x401B58E")]
		VOICE_Mur_2_002,
		// Token: 0x0400A82B RID: 43051
		[Token(Token = "0x401B58F")]
		VOICE_Lyk_2_001,
		// Token: 0x0400A82C RID: 43052
		[Token(Token = "0x401B590")]
		VOICE_Lyk_2_002,
		// Token: 0x0400A82D RID: 43053
		[Token(Token = "0x401B591")]
		VOICE_Reh_2_001,
		// Token: 0x0400A82E RID: 43054
		[Token(Token = "0x401B592")]
		VOICE_Reh_2_002,
		// Token: 0x0400A82F RID: 43055
		[Token(Token = "0x401B593")]
		VOICE_Luc_2_001,
		// Token: 0x0400A830 RID: 43056
		[Token(Token = "0x401B594")]
		VOICE_Luc_2_002,
		// Token: 0x0400A831 RID: 43057
		[Token(Token = "0x401B595")]
		VOICE_Els_2_001,
		// Token: 0x0400A832 RID: 43058
		[Token(Token = "0x401B596")]
		VOICE_Els_2_002,
		// Token: 0x0400A833 RID: 43059
		[Token(Token = "0x401B597")]
		VOICE_Pal_2_001,
		// Token: 0x0400A834 RID: 43060
		[Token(Token = "0x401B598")]
		VOICE_Pal_2_002,
		// Token: 0x0400A835 RID: 43061
		[Token(Token = "0x401B599")]
		VOICE_Hez_2_001,
		// Token: 0x0400A836 RID: 43062
		[Token(Token = "0x401B59A")]
		VOICE_Hez_2_002,
		// Token: 0x0400A837 RID: 43063
		[Token(Token = "0x401B59B")]
		VOICE_Rad_2_001,
		// Token: 0x0400A838 RID: 43064
		[Token(Token = "0x401B59C")]
		VOICE_Rad_2_002,
		// Token: 0x0400A839 RID: 43065
		[Token(Token = "0x401B59D")]
		VOICE_Yuk_2_001,
		// Token: 0x0400A83A RID: 43066
		[Token(Token = "0x401B59E")]
		VOICE_Yuk_2_002,
		// Token: 0x0400A83B RID: 43067
		[Token(Token = "0x401B59F")]
		VOICE_Sim_2_001,
		// Token: 0x0400A83C RID: 43068
		[Token(Token = "0x401B5A0")]
		VOICE_Sim_2_002,
		// Token: 0x0400A83D RID: 43069
		[Token(Token = "0x401B5A1")]
		VOICE_Mis_2_001,
		// Token: 0x0400A83E RID: 43070
		[Token(Token = "0x401B5A2")]
		VOICE_Mis_2_002,
		// Token: 0x0400A83F RID: 43071
		[Token(Token = "0x401B5A3")]
		VOICE_Ter_2_001_1,
		// Token: 0x0400A840 RID: 43072
		[Token(Token = "0x401B5A4")]
		VOICE_Ter_2_001_2,
		// Token: 0x0400A841 RID: 43073
		[Token(Token = "0x401B5A5")]
		VOICE_Ter_2_001_3,
		// Token: 0x0400A842 RID: 43074
		[Token(Token = "0x401B5A6")]
		VOICE_Riv_2_001_1,
		// Token: 0x0400A843 RID: 43075
		[Token(Token = "0x401B5A7")]
		VOICE_Riv_2_001_2,
		// Token: 0x0400A844 RID: 43076
		[Token(Token = "0x401B5A8")]
		VOICE_Led_2_001_1,
		// Token: 0x0400A845 RID: 43077
		[Token(Token = "0x401B5A9")]
		VOICE_Led_2_001_2,
		// Token: 0x0400A846 RID: 43078
		[Token(Token = "0x401B5AA")]
		VOICE_Dou_2_001,
		// Token: 0x0400A847 RID: 43079
		[Token(Token = "0x401B5AB")]
		VOICE_Dou_2_002,
		// Token: 0x0400A848 RID: 43080
		[Token(Token = "0x401B5AC")]
		VOICE_Jul_2_001,
		// Token: 0x0400A849 RID: 43081
		[Token(Token = "0x401B5AD")]
		VOICE_Jul_2_002,
		// Token: 0x0400A84A RID: 43082
		[Token(Token = "0x401B5AE")]
		VOICE_Hna_2_001,
		// Token: 0x0400A84B RID: 43083
		[Token(Token = "0x401B5AF")]
		VOICE_Hna_2_002,
		// Token: 0x0400A84C RID: 43084
		[Token(Token = "0x401B5B0")]
		VOICE_CB1_2_001,
		// Token: 0x0400A84D RID: 43085
		[Token(Token = "0x401B5B1")]
		VOICE_CB2_2_001,
		// Token: 0x0400A84E RID: 43086
		[Token(Token = "0x401B5B2")]
		VOICE_CB3_2_001,
		// Token: 0x0400A84F RID: 43087
		[Token(Token = "0x401B5B3")]
		VOICE_CG1_2_001,
		// Token: 0x0400A850 RID: 43088
		[Token(Token = "0x401B5B4")]
		VOICE_CG2_2_001,
		// Token: 0x0400A851 RID: 43089
		[Token(Token = "0x401B5B5")]
		VOICE_CG3_2_001,
		// Token: 0x0400A852 RID: 43090
		[Token(Token = "0x401B5B6")]
		VOICE_Gan_2_001_1,
		// Token: 0x0400A853 RID: 43091
		[Token(Token = "0x401B5B7")]
		VOICE_Gan_2_001_2,
		// Token: 0x0400A854 RID: 43092
		[Token(Token = "0x401B5B8")]
		VOICE_Osw_2_001_1,
		// Token: 0x0400A855 RID: 43093
		[Token(Token = "0x401B5B9")]
		VOICE_Osw_2_001_2,
		// Token: 0x0400A856 RID: 43094
		[Token(Token = "0x401B5BA")]
		Length
	}

	// Token: 0x02000AE6 RID: 2790
	[Token(Token = "0x200131C")]
	public enum TitleMenuType
	{
		// Token: 0x0400A858 RID: 43096
		[Token(Token = "0x401B5BC")]
		ALL,
		// Token: 0x0400A859 RID: 43097
		[Token(Token = "0x401B5BD")]
		OFF_LANG,
		// Token: 0x0400A85A RID: 43098
		[Token(Token = "0x401B5BE")]
		OFF_VOICE,
		// Token: 0x0400A85B RID: 43099
		[Token(Token = "0x401B5BF")]
		DEBUG_ALL,
		// Token: 0x0400A85C RID: 43100
		[Token(Token = "0x401B5C0")]
		DEBUG_OFFLANG,
		// Token: 0x0400A85D RID: 43101
		[Token(Token = "0x401B5C1")]
		DEBUG_OFFVOICE
	}

	// Token: 0x02000AE7 RID: 2791
	[Token(Token = "0x200131D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1592D0", Offset = "0x1593D1")]
	private sealed class <>c__DisplayClass62_0
	{
		// Token: 0x06004879 RID: 18553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A5")]
		[Address(RVA = "0x20711E0", Offset = "0x20712E1", VA = "0x20711E0")]
		public <>c__DisplayClass62_0()
		{
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A6")]
		[Address(RVA = "0x20711F0", Offset = "0x20712F1", VA = "0x20711F0")]
		internal void <createBg>b__0(AssetHandle<Sprite> handle)
		{
		}

		// Token: 0x0400A85E RID: 43102
		[Token(Token = "0x401B5C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TitleCanvasControl <>4__this;

		// Token: 0x0400A85F RID: 43103
		[Token(Token = "0x401B5C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int id;
	}

	// Token: 0x02000AE8 RID: 2792
	[Token(Token = "0x200131E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1592E0", Offset = "0x1593E1")]
	private sealed class <createBg>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600487B RID: 18555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A7")]
		[Address(RVA = "0x206F870", Offset = "0x206F971", VA = "0x206F870")]
		[DebuggerHidden]
		public <createBg>d__62(int <>1__state)
		{
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A8")]
		[Address(RVA = "0x2071350", Offset = "0x2071451", VA = "0x2071350", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x000178C8 File Offset: 0x00015AC8
		[Token(Token = "0x60076A9")]
		[Address(RVA = "0x2071360", Offset = "0x2071461", VA = "0x2071360", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA5")]
		private object Current
		{
			[Token(Token = "0x60076AA")]
			[Address(RVA = "0x20714E0", Offset = "0x20715E1", VA = "0x20714E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AB")]
		[Address(RVA = "0x20714F0", Offset = "0x20715F1", VA = "0x20714F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06004880 RID: 18560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DA6")]
		private object Current
		{
			[Token(Token = "0x60076AC")]
			[Address(RVA = "0x2071550", Offset = "0x2071651", VA = "0x2071550", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A860 RID: 43104
		[Token(Token = "0x401B5C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A861 RID: 43105
		[Token(Token = "0x401B5C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A862 RID: 43106
		[Token(Token = "0x401B5C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TitleCanvasControl <>4__this;

		// Token: 0x0400A863 RID: 43107
		[Token(Token = "0x401B5C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int id;
	}
}
