using System;
using Il2CppDummyDll;
using RF5_Sound;
using UIADV;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000916 RID: 2326
[Token(Token = "0x200061A")]
public class AdvDialogControl : MonoBehaviour
{
	// Token: 0x170008C1 RID: 2241
	// (get) Token: 0x06003CF9 RID: 15609 RVA: 0x00015318 File Offset: 0x00013518
	[Token(Token = "0x17000702")]
	public bool IsByTheWayShaking
	{
		[Token(Token = "0x600334A")]
		[Address(RVA = "0x1D5B4F0", Offset = "0x1D5B5F1", VA = "0x1D5B4F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170008C2 RID: 2242
	// (get) Token: 0x06003CFA RID: 15610 RVA: 0x00015330 File Offset: 0x00013530
	[Token(Token = "0x17000703")]
	public bool IsByTheWayViewing
	{
		[Token(Token = "0x600334B")]
		[Address(RVA = "0x1D5B530", Offset = "0x1D5B631", VA = "0x1D5B530")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06003CFB RID: 15611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600334C")]
	[Address(RVA = "0x1D5B550", Offset = "0x1D5B651", VA = "0x1D5B550")]
	public void Open()
	{
	}

	// Token: 0x06003CFC RID: 15612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600334D")]
	[Address(RVA = "0x1D5B580", Offset = "0x1D5B681", VA = "0x1D5B580")]
	public void Close()
	{
	}

	// Token: 0x06003CFD RID: 15613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600334E")]
	[Address(RVA = "0x1D5B730", Offset = "0x1D5B831", VA = "0x1D5B730")]
	public void SetByTheWayActive(bool value, ByTheWayType ByTheWayType = ByTheWayType.LV1)
	{
	}

	// Token: 0x06003CFE RID: 15614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600334F")]
	[Address(RVA = "0x1D5B840", Offset = "0x1D5B941", VA = "0x1D5B840")]
	private void SetShakeByTheWayIcon(bool value)
	{
	}

	// Token: 0x06003CFF RID: 15615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003350")]
	[Address(RVA = "0x1D5B880", Offset = "0x1D5B981", VA = "0x1D5B880")]
	public void SetTextBySpeaker(string str, int speakerChId)
	{
	}

	// Token: 0x06003D00 RID: 15616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003351")]
	[Address(RVA = "0x1D5B900", Offset = "0x1D5BA01", VA = "0x1D5B900")]
	public void ChangeChatWindow(int chatWindowId)
	{
	}

	// Token: 0x06003D01 RID: 15617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003352")]
	[Address(RVA = "0x1D5B610", Offset = "0x1D5B711", VA = "0x1D5B610")]
	public void CloseAllCharactor()
	{
	}

	// Token: 0x06003D02 RID: 15618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003353")]
	[Address(RVA = "0x1D5B980", Offset = "0x1D5BA81", VA = "0x1D5B980")]
	public void PlayMouth(int _positionId, VoiceController voiceController)
	{
	}

	// Token: 0x06003D03 RID: 15619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003354")]
	[Address(RVA = "0x1D5BC70", Offset = "0x1D5BD71", VA = "0x1D5BC70")]
	public void StopMouth(int _positionId)
	{
	}

	// Token: 0x06003D04 RID: 15620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003355")]
	[Address(RVA = "0x1D5BB00", Offset = "0x1D5BC01", VA = "0x1D5BB00")]
	public void StopAllMouth()
	{
	}

	// Token: 0x06003D05 RID: 15621 RVA: 0x00015348 File Offset: 0x00013548
	[Token(Token = "0x6003356")]
	[Address(RVA = "0x1D5BDC0", Offset = "0x1D5BEC1", VA = "0x1D5BDC0")]
	private int UseAdvCharactor(int _charactorId, int _positionId, int _variationId)
	{
		return 0;
	}

	// Token: 0x06003D06 RID: 15622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003357")]
	[Address(RVA = "0x1D5C060", Offset = "0x1D5C161", VA = "0x1D5C060")]
	public void SetCharaLayerToFront(int _positionId)
	{
	}

	// Token: 0x06003D07 RID: 15623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003358")]
	[Address(RVA = "0x1D5C0B0", Offset = "0x1D5C1B1", VA = "0x1D5C0B0")]
	public void SetCharaLayerToBack(int _positionId)
	{
	}

	// Token: 0x06003D08 RID: 15624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003359")]
	[Address(RVA = "0x1D5C100", Offset = "0x1D5C201", VA = "0x1D5C100")]
	public void SetEmocon(int _positionId, int no, int loop = 0)
	{
	}

	// Token: 0x06003D09 RID: 15625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600335A")]
	[Address(RVA = "0x1D5C210", Offset = "0x1D5C311", VA = "0x1D5C210")]
	public void EndEmoconLoop(int _positionId, int no, int loop = 0)
	{
	}

	// Token: 0x06003D0A RID: 15626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600335B")]
	[Address(RVA = "0x1D5C310", Offset = "0x1D5C411", VA = "0x1D5C310")]
	public void EndEmocon(int _positionId)
	{
	}

	// Token: 0x06003D0B RID: 15627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600335C")]
	[Address(RVA = "0x1D5C470", Offset = "0x1D5C571", VA = "0x1D5C470")]
	public void CharacterSwapFilter(ref int charaId, ref int variationId)
	{
	}

	// Token: 0x06003D0C RID: 15628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600335D")]
	[Address(RVA = "0x1D5C540", Offset = "0x1D5C641", VA = "0x1D5C540")]
	private void PlayerGenderCheck(ref int charaId)
	{
	}

	// Token: 0x06003D0D RID: 15629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600335E")]
	[Address(RVA = "0x1D5C5D0", Offset = "0x1D5C6D1", VA = "0x1D5C5D0")]
	public void AppearCharacter(int charaId, int variationId, int _positionId, int motionId, int EyeVar = 0, int EyeBrowsVar = 0, int MouthVar = 0)
	{
	}

	// Token: 0x06003D0E RID: 15630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600335F")]
	[Address(RVA = "0x1D5C7D0", Offset = "0x1D5C8D1", VA = "0x1D5C7D0")]
	public void UpdateCharacter(int charaId, int variationId, int _positionId, int motionId = 0, int EyeVar = 0, int EyeBrowsVar = 0, int MouthVar = 0)
	{
	}

	// Token: 0x06003D0F RID: 15631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003360")]
	[Address(RVA = "0x1D5C9E0", Offset = "0x1D5CAE1", VA = "0x1D5C9E0")]
	public void DisappearCharacter(int charaId, int variationId, int _positionId, int motionId, int EyeVar = 0, int EyeBrowsVar = 0, int MouthVar = 0)
	{
	}

	// Token: 0x06003D10 RID: 15632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003361")]
	[Address(RVA = "0x1D5CCB0", Offset = "0x1D5CDB1", VA = "0x1D5CCB0")]
	public void PlayCharaAnim(int _positionId, AdvCharaImageControl.CharaAnimateType type)
	{
	}

	// Token: 0x06003D11 RID: 15633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003362")]
	[Address(RVA = "0x1D5CDE0", Offset = "0x1D5CEE1", VA = "0x1D5CDE0")]
	public void OpenSingleImage(int imageId, int x = 0, int y = 0, int _time = 150)
	{
	}

	// Token: 0x06003D12 RID: 15634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003363")]
	[Address(RVA = "0x1D5CE00", Offset = "0x1D5CF01", VA = "0x1D5CE00")]
	public void EndSingleImage(int imageId = 0, int _time = 150)
	{
	}

	// Token: 0x06003D13 RID: 15635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003364")]
	[Address(RVA = "0x1D5CE30", Offset = "0x1D5CF31", VA = "0x1D5CE30")]
	public void StartStaffRoll(int type, float time)
	{
	}

	// Token: 0x06003D14 RID: 15636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003365")]
	[Address(RVA = "0x1D5CE50", Offset = "0x1D5CF51", VA = "0x1D5CE50")]
	public void EndStaffRoll()
	{
	}

	// Token: 0x06003D15 RID: 15637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003366")]
	[Address(RVA = "0x1D5CE70", Offset = "0x1D5CF71", VA = "0x1D5CE70")]
	private void Start()
	{
	}

	// Token: 0x06003D16 RID: 15638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003367")]
	[Address(RVA = "0x1D5D0A0", Offset = "0x1D5D1A1", VA = "0x1D5D0A0")]
	private void Update()
	{
	}

	// Token: 0x06003D17 RID: 15639 RVA: 0x00015360 File Offset: 0x00013560
	[Token(Token = "0x6003368")]
	[Address(RVA = "0x1D5D370", Offset = "0x1D5D471", VA = "0x1D5D370")]
	public int ConvertCostumeFromNormal(int charaId, int variationId)
	{
		return 0;
	}

	// Token: 0x06003D18 RID: 15640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003369")]
	[Address(RVA = "0x1D5D580", Offset = "0x1D5D681", VA = "0x1D5D580")]
	public AdvDialogControl()
	{
	}

	// Token: 0x06003D19 RID: 15641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600336A")]
	[Address(RVA = "0x1D5D690", Offset = "0x1D5D791", VA = "0x1D5D690")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6C30", Offset = "0x1A6D31")]
	private void <Start>b__45_1(BaseEventData _data)
	{
	}

	// Token: 0x04007F63 RID: 32611
	[Token(Token = "0x40072F6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform[] CharaBasePoint;

	// Token: 0x04007F64 RID: 32612
	[Token(Token = "0x40072F7")]
	[FieldOffset(Offset = "0x20")]
	private AdvCharaImageControl[] AdvCharaImageControls;

	// Token: 0x04007F65 RID: 32613
	[Token(Token = "0x40072F8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AdvCharaImageControl AdvCharaImageControlPrefab;

	// Token: 0x04007F66 RID: 32614
	[Token(Token = "0x40072F9")]
	[FieldOffset(Offset = "0x30")]
	public NameWindow NameText;

	// Token: 0x04007F67 RID: 32615
	[Token(Token = "0x40072FA")]
	[FieldOffset(Offset = "0x38")]
	public TextWindow ChatText;

	// Token: 0x04007F68 RID: 32616
	[Token(Token = "0x40072FB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AdvByTheWayMove ByTheWayIcon;

	// Token: 0x04007F69 RID: 32617
	[Token(Token = "0x40072FC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private SText byTheWayText;

	// Token: 0x04007F6A RID: 32618
	[Token(Token = "0x40072FD")]
	[FieldOffset(Offset = "0x50")]
	private bool ByTheWayShaking;

	// Token: 0x04007F6B RID: 32619
	[Token(Token = "0x40072FE")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AdvChatWindowOnOff ChatWindow;

	// Token: 0x04007F6C RID: 32620
	[Token(Token = "0x40072FF")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image[] ChatWindowImage;

	// Token: 0x04007F6D RID: 32621
	[Token(Token = "0x4007300")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AdvShowOneImage AdvShowOneImage;

	// Token: 0x04007F6E RID: 32622
	[Token(Token = "0x4007301")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AdvStaffRollBase AdvStaffRollBase;

	// Token: 0x04007F6F RID: 32623
	[Token(Token = "0x4007302")]
	[FieldOffset(Offset = "0x78")]
	public SpriteDataResource FaceData;

	// Token: 0x04007F70 RID: 32624
	[Token(Token = "0x4007303")]
	[FieldOffset(Offset = "0x80")]
	private bool Opened;

	// Token: 0x04007F71 RID: 32625
	[Token(Token = "0x4007304")]
	[FieldOffset(Offset = "0x88")]
	private VoiceController OnTextPlayingVoiceController;

	// Token: 0x04007F72 RID: 32626
	[Token(Token = "0x4007305")]
	[FieldOffset(Offset = "0x90")]
	private readonly bool[] hasSwimsuitPajama;

	// Token: 0x04007F73 RID: 32627
	[Token(Token = "0x4007306")]
	[FieldOffset(Offset = "0x98")]
	private readonly bool[] HasMarryForm;

	// Token: 0x02000917 RID: 2327
	[Token(Token = "0x200127F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158E00", Offset = "0x158F01")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003D1B RID: 15643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007497")]
		[Address(RVA = "0x1D5D780", Offset = "0x1D5D881", VA = "0x1D5D780")]
		public <>c()
		{
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007498")]
		[Address(RVA = "0x1D5D790", Offset = "0x1D5D891", VA = "0x1D5D790")]
		internal void <Start>b__45_0(BaseEventData _data)
		{
		}

		// Token: 0x04007F74 RID: 32628
		[Token(Token = "0x40198D2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AdvDialogControl.<>c <>9;

		// Token: 0x04007F75 RID: 32629
		[Token(Token = "0x40198D3")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction<BaseEventData> <>9__45_0;
	}
}
