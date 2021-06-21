using System;
using Define;
using Il2CppDummyDll;
using RF5UI;
using SaveData;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A4A RID: 2634
[Token(Token = "0x20006ED")]
public class UISaveBlockButton : UIButtonLinkerInScrollBox
{
	// Token: 0x060044C1 RID: 17601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600399E")]
	[Address(RVA = "0x1EB0390", Offset = "0x1EB0491", VA = "0x1EB0390", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x060044C2 RID: 17602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600399F")]
	[Address(RVA = "0x1EB0420", Offset = "0x1EB0521", VA = "0x1EB0420")]
	public void SetSaveData(RF5ThumbnailData thumbSaveData, int saveNo, NextTargetDataTable nextTargetDataTable)
	{
	}

	// Token: 0x060044C3 RID: 17603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039A0")]
	[Address(RVA = "0x1EB1170", Offset = "0x1EB1271", VA = "0x1EB1170")]
	public void SetState(bool state)
	{
	}

	// Token: 0x060044C4 RID: 17604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039A1")]
	[Address(RVA = "0x1EB19A0", Offset = "0x1EB1AA1", VA = "0x1EB19A0", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x060044C5 RID: 17605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039A2")]
	[Address(RVA = "0x1EB19D0", Offset = "0x1EB1AD1", VA = "0x1EB19D0", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x060044C6 RID: 17606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039A3")]
	[Address(RVA = "0x1EB1A00", Offset = "0x1EB1B01", VA = "0x1EB1A00")]
	private void OnEnable()
	{
	}

	// Token: 0x060044C7 RID: 17607 RVA: 0x00016D88 File Offset: 0x00014F88
	[Token(Token = "0x60039A4")]
	[Address(RVA = "0x1EB1A30", Offset = "0x1EB1B31", VA = "0x1EB1A30", Slot = "12")]
	protected override bool CanUpdateCursor()
	{
		return default(bool);
	}

	// Token: 0x060044C8 RID: 17608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039A5")]
	[Address(RVA = "0x1EB1A70", Offset = "0x1EB1B71", VA = "0x1EB1A70", Slot = "13")]
	protected override void InitInputLayer()
	{
	}

	// Token: 0x060044C9 RID: 17609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039A6")]
	[Address(RVA = "0x1EB1AA0", Offset = "0x1EB1BA1", VA = "0x1EB1AA0", Slot = "14")]
	protected override void ClearInputLayer()
	{
	}

	// Token: 0x060044CA RID: 17610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039A7")]
	[Address(RVA = "0x1EB1AD0", Offset = "0x1EB1BD1", VA = "0x1EB1AD0")]
	public UISaveBlockButton()
	{
	}

	// Token: 0x0400A3A6 RID: 41894
	[Token(Token = "0x4007BC9")]
	[FieldOffset(Offset = "0x70")]
	private UISaveMenuManager UISaveMenuManager;

	// Token: 0x0400A3A7 RID: 41895
	[Token(Token = "0x4007BCA")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image OffImage;

	// Token: 0x0400A3A8 RID: 41896
	[Token(Token = "0x4007BCB")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image OnImage;

	// Token: 0x0400A3A9 RID: 41897
	[Token(Token = "0x4007BCC")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Image CharactorImage;

	// Token: 0x0400A3AA RID: 41898
	[Token(Token = "0x4007BCD")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Image MarryCharactorImage;

	// Token: 0x0400A3AB RID: 41899
	[Token(Token = "0x4007BCE")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Image OnlyPlayerCharactorImage;

	// Token: 0x0400A3AC RID: 41900
	[Token(Token = "0x4007BCF")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Text SaveBlockIdText;

	// Token: 0x0400A3AD RID: 41901
	[Token(Token = "0x4007BD0")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Text CharactorText;

	// Token: 0x0400A3AE RID: 41902
	[Token(Token = "0x4007BD1")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Text LvText;

	// Token: 0x0400A3AF RID: 41903
	[Token(Token = "0x4007BD2")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Text DiffText;

	// Token: 0x0400A3B0 RID: 41904
	[Token(Token = "0x4007BD3")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Text PlaceText;

	// Token: 0x0400A3B1 RID: 41905
	[Token(Token = "0x4007BD4")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Text TimeText;

	// Token: 0x0400A3B2 RID: 41906
	[Token(Token = "0x4007BD5")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Text NextMissionText;

	// Token: 0x0400A3B3 RID: 41907
	[Token(Token = "0x4007BD6")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private SText NoSaveDataText;

	// Token: 0x0400A3B4 RID: 41908
	[Token(Token = "0x4007BD7")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Sprite MaleCharaSprite;

	// Token: 0x0400A3B5 RID: 41909
	[Token(Token = "0x4007BD8")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Sprite FemaleCharaSprite;

	// Token: 0x0400A3B6 RID: 41910
	[Token(Token = "0x4007BD9")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Sprite[] NPCMaleCharaSprite;

	// Token: 0x0400A3B7 RID: 41911
	[Token(Token = "0x4007BDA")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Sprite[] NPCFemaleCharaSprite;

	// Token: 0x0400A3B8 RID: 41912
	[Token(Token = "0x4007BDB")]
	[FieldOffset(Offset = "0x100")]
	private NPCID marriedNPCID;

	// Token: 0x0400A3B9 RID: 41913
	[Token(Token = "0x4007BDC")]
	[FieldOffset(Offset = "0x104")]
	private bool isPlayerMale;

	// Token: 0x0400A3BA RID: 41914
	[Token(Token = "0x4007BDD")]
	[FieldOffset(Offset = "0x105")]
	private bool isSaved;

	// Token: 0x0400A3BB RID: 41915
	[Token(Token = "0x4007BDE")]
	[FieldOffset(Offset = "0x108")]
	private readonly string[] SeasonStr;
}
