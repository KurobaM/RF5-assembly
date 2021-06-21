using System;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A09 RID: 2569
[Token(Token = "0x20006BC")]
public class EquipStatusMenu : MonoBehaviour
{
	// Token: 0x06004349 RID: 17225 RVA: 0x00016830 File Offset: 0x00014A30
	[Token(Token = "0x600384A")]
	[Address(RVA = "0x22B9F80", Offset = "0x22BA081", VA = "0x22B9F80")]
	private EquipSlotType GetSlotType(ItemType ItemType)
	{
		return EquipSlotType.RuneRX;
	}

	// Token: 0x0600434A RID: 17226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600384B")]
	[Address(RVA = "0x22B9FB0", Offset = "0x22BA0B1", VA = "0x22B9FB0")]
	private void AddItemToEquip(HumanEquip equip, ItemData itemData)
	{
	}

	// Token: 0x0600434B RID: 17227 RVA: 0x00016848 File Offset: 0x00014A48
	[Token(Token = "0x600384C")]
	[Address(RVA = "0x22BA030", Offset = "0x22BA131", VA = "0x22BA030")]
	private Parameter GetParameter(ActorID actor_id, bool UseWeaponStatus, bool UseToolStatus, [Optional] ItemData itemData)
	{
		return default(Parameter);
	}

	// Token: 0x0600434C RID: 17228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600384D")]
	[Address(RVA = "0x22BA160", Offset = "0x22BA261", VA = "0x22BA160")]
	public void SetStatusNPC(ActorID actor_id, bool UseWeaponStatus, bool UseToolStatus)
	{
	}

	// Token: 0x0600434D RID: 17229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600384E")]
	[Address(RVA = "0x22BB020", Offset = "0x22BB121", VA = "0x22BB020")]
	private void ShowDifText(Text Txt, Image iconImg, int defaultVal, int equipedVal, bool isResistParameter = false)
	{
	}

	// Token: 0x0600434E RID: 17230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600384F")]
	[Address(RVA = "0x22BB230", Offset = "0x22BB331", VA = "0x22BB230")]
	private void ShowDifText(Text Txt, Image iconImg, float _defaultVal, float _equipedVal, bool isResistParameter = false)
	{
	}

	// Token: 0x0600434F RID: 17231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003850")]
	[Address(RVA = "0x22BB4F0", Offset = "0x22BB5F1", VA = "0x22BB4F0")]
	public void SetDifItemParameter(ActorID actorID, bool UseWeaponStatus, bool UseToolStatus, ItemData itemData)
	{
	}

	// Token: 0x06004350 RID: 17232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003851")]
	[Address(RVA = "0x22BB9B0", Offset = "0x22BBAB1", VA = "0x22BB9B0")]
	public void ClearDifItemParamter()
	{
	}

	// Token: 0x06004351 RID: 17233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003852")]
	[Address(RVA = "0x22BBF10", Offset = "0x22BC011", VA = "0x22BBF10")]
	public EquipStatusMenu()
	{
	}

	// Token: 0x0400A1FE RID: 41470
	[Token(Token = "0x4007A57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text Txt_Hp;

	// Token: 0x0400A1FF RID: 41471
	[Token(Token = "0x4007A58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text Txt_Rp;

	// Token: 0x0400A200 RID: 41472
	[Token(Token = "0x4007A59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text Txt_Lv;

	// Token: 0x0400A201 RID: 41473
	[Token(Token = "0x4007A5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image Img_HpGauge;

	// Token: 0x0400A202 RID: 41474
	[Token(Token = "0x4007A5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image Img_RpGauge;

	// Token: 0x0400A203 RID: 41475
	[Token(Token = "0x4007A5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image Img_ExpGauge;

	// Token: 0x0400A204 RID: 41476
	[Token(Token = "0x4007A5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text Txt_Atk;

	// Token: 0x0400A205 RID: 41477
	[Token(Token = "0x4007A5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text Txt_Def;

	// Token: 0x0400A206 RID: 41478
	[Token(Token = "0x4007A5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text Txt_MAtk;

	// Token: 0x0400A207 RID: 41479
	[Token(Token = "0x4007A60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text Txt_MDef;

	// Token: 0x0400A208 RID: 41480
	[Token(Token = "0x4007A61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text Txt_Str;

	// Token: 0x0400A209 RID: 41481
	[Token(Token = "0x4007A62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text Txt_Vit;

	// Token: 0x0400A20A RID: 41482
	[Token(Token = "0x4007A63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Text Txt_Int;

	// Token: 0x0400A20B RID: 41483
	[Token(Token = "0x4007A64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text Txt_NPCName;

	// Token: 0x0400A20C RID: 41484
	[Token(Token = "0x4007A65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Text Txt_DifAtk;

	// Token: 0x0400A20D RID: 41485
	[Token(Token = "0x4007A66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text Txt_DifDef;

	// Token: 0x0400A20E RID: 41486
	[Token(Token = "0x4007A67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text Txt_DifMAtk;

	// Token: 0x0400A20F RID: 41487
	[Token(Token = "0x4007A68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Text Txt_DifMDef;

	// Token: 0x0400A210 RID: 41488
	[Token(Token = "0x4007A69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Text Txt_DifStr;

	// Token: 0x0400A211 RID: 41489
	[Token(Token = "0x4007A6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Text Txt_DifVit;

	// Token: 0x0400A212 RID: 41490
	[Token(Token = "0x4007A6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Text Txt_DifInt;

	// Token: 0x0400A213 RID: 41491
	[Token(Token = "0x4007A6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Text Txt_ResistFire;

	// Token: 0x0400A214 RID: 41492
	[Token(Token = "0x4007A6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Text Txt_ResistWater;

	// Token: 0x0400A215 RID: 41493
	[Token(Token = "0x4007A6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Text Txt_ResistEarth;

	// Token: 0x0400A216 RID: 41494
	[Token(Token = "0x4007A6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private Text Txt_ResistWind;

	// Token: 0x0400A217 RID: 41495
	[Token(Token = "0x4007A70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Text Txt_ResistShine;

	// Token: 0x0400A218 RID: 41496
	[Token(Token = "0x4007A71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Text Txt_ResistDark;

	// Token: 0x0400A219 RID: 41497
	[Token(Token = "0x4007A72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Text Txt_ResistLove;

	// Token: 0x0400A21A RID: 41498
	[Token(Token = "0x4007A73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Image Icon_DifAtk;

	// Token: 0x0400A21B RID: 41499
	[Token(Token = "0x4007A74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Image Icon_DifDef;

	// Token: 0x0400A21C RID: 41500
	[Token(Token = "0x4007A75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private Image Icon_DifMAtk;

	// Token: 0x0400A21D RID: 41501
	[Token(Token = "0x4007A76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[SerializeField]
	private Image Icon_DifMDef;

	// Token: 0x0400A21E RID: 41502
	[Token(Token = "0x4007A77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	private Image Icon_DifStr;

	// Token: 0x0400A21F RID: 41503
	[Token(Token = "0x4007A78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	private Image Icon_DifVit;

	// Token: 0x0400A220 RID: 41504
	[Token(Token = "0x4007A79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[SerializeField]
	private Image Icon_DifInt;

	// Token: 0x0400A221 RID: 41505
	[Token(Token = "0x4007A7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[SerializeField]
	private Image Icon_ResistFire;

	// Token: 0x0400A222 RID: 41506
	[Token(Token = "0x4007A7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[SerializeField]
	private Image Icon_ResistWater;

	// Token: 0x0400A223 RID: 41507
	[Token(Token = "0x4007A7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[SerializeField]
	private Image Icon_ResistEarth;

	// Token: 0x0400A224 RID: 41508
	[Token(Token = "0x4007A7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	private Image Icon_ResistWind;

	// Token: 0x0400A225 RID: 41509
	[Token(Token = "0x4007A7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	private Image Icon_ResistShine;

	// Token: 0x0400A226 RID: 41510
	[Token(Token = "0x4007A7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[SerializeField]
	private Image Icon_ResistDark;

	// Token: 0x0400A227 RID: 41511
	[Token(Token = "0x4007A80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[SerializeField]
	private Image Icon_ResistLove;

	// Token: 0x0400A228 RID: 41512
	[Token(Token = "0x4007A81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[SerializeField]
	private Sprite parameterUpIcon;

	// Token: 0x0400A229 RID: 41513
	[Token(Token = "0x4007A82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[SerializeField]
	private Sprite parameterDownIcon;

	// Token: 0x0400A22A RID: 41514
	[Token(Token = "0x4007A83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[SerializeField]
	private Sprite resistParameterUpIcon;

	// Token: 0x0400A22B RID: 41515
	[Token(Token = "0x4007A84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[SerializeField]
	private Sprite resistParameterDownIcon;

	// Token: 0x0400A22C RID: 41516
	[Token(Token = "0x4007A85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private int charaId;

	// Token: 0x0400A22D RID: 41517
	[Token(Token = "0x4007A86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private readonly Color PARAMETERUP_COLOR;

	// Token: 0x0400A22E RID: 41518
	[Token(Token = "0x4007A87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private readonly Color PARAMETERDOWN_COLOR;
}
