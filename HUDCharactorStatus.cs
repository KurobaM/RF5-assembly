using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200099B RID: 2459
[Token(Token = "0x2000674")]
public class HUDCharactorStatus : MonoBehaviour
{
	// Token: 0x0600404B RID: 16459 RVA: 0x00015C18 File Offset: 0x00013E18
	[Token(Token = "0x6003594")]
	[Address(RVA = "0x2042D90", Offset = "0x2042E91", VA = "0x2042D90")]
	public HUDCharactorStatus.CharactorType GetCharactorType()
	{
		return HUDCharactorStatus.CharactorType.Player;
	}

	// Token: 0x0600404C RID: 16460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003595")]
	[Address(RVA = "0x2042DA0", Offset = "0x2042EA1", VA = "0x2042DA0")]
	private void SetNpcIdFromPartner(int partnerid)
	{
	}

	// Token: 0x0600404D RID: 16461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003596")]
	[Address(RVA = "0x20431D0", Offset = "0x20432D1", VA = "0x20431D0")]
	private CharacterStatusBase GetCharacter()
	{
		return null;
	}

	// Token: 0x0600404E RID: 16462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003597")]
	[Address(RVA = "0x20432E0", Offset = "0x20433E1", VA = "0x20432E0")]
	private void CheckCharaChange()
	{
	}

	// Token: 0x0600404F RID: 16463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003598")]
	[Address(RVA = "0x2043480", Offset = "0x2043581", VA = "0x2043480")]
	public void CharaChange()
	{
	}

	// Token: 0x06004050 RID: 16464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003599")]
	[Address(RVA = "0x2043E40", Offset = "0x2043F41", VA = "0x2043E40")]
	private void UpdateGauge(Image gauge, float max, float current)
	{
	}

	// Token: 0x06004051 RID: 16465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600359A")]
	[Address(RVA = "0x2044570", Offset = "0x2044671", VA = "0x2044570")]
	private void OnUpdateHp(CharacterStatusBase status, int amount)
	{
	}

	// Token: 0x06004052 RID: 16466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600359B")]
	[Address(RVA = "0x2044A70", Offset = "0x2044B71", VA = "0x2044A70")]
	private void OnUpdateRp(CharacterStatusBase status, int amount)
	{
	}

	// Token: 0x06004053 RID: 16467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600359C")]
	[Address(RVA = "0x2044C10", Offset = "0x2044D11", VA = "0x2044C10")]
	private void Update()
	{
	}

	// Token: 0x06004054 RID: 16468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600359D")]
	[Address(RVA = "0x2044CA0", Offset = "0x2044DA1", VA = "0x2044CA0")]
	private void Start()
	{
	}

	// Token: 0x06004055 RID: 16469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600359E")]
	[Address(RVA = "0x2044CB0", Offset = "0x2044DB1", VA = "0x2044CB0")]
	public HUDCharactorStatus()
	{
	}

	// Token: 0x04009EAF RID: 40623
	[Token(Token = "0x40077A7")]
	[FieldOffset(Offset = "0x18")]
	private readonly int[] PartnerIdTable;

	// Token: 0x04009EB0 RID: 40624
	[Token(Token = "0x40077A8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HUDCharactorStatus.CharactorType charactorType;

	// Token: 0x04009EB1 RID: 40625
	[Token(Token = "0x40077A9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image HpGauge;

	// Token: 0x04009EB2 RID: 40626
	[Token(Token = "0x40077AA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private HUDDamageHpBar HUDDamageHpBar;

	// Token: 0x04009EB3 RID: 40627
	[Token(Token = "0x40077AB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image RpGauge;

	// Token: 0x04009EB4 RID: 40628
	[Token(Token = "0x40077AC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UIFaceIconLoader UIFaceIconLoader;

	// Token: 0x04009EB5 RID: 40629
	[Token(Token = "0x40077AD")]
	[FieldOffset(Offset = "0x48")]
	private float prevHpGageSize;

	// Token: 0x04009EB6 RID: 40630
	[Token(Token = "0x40077AE")]
	[FieldOffset(Offset = "0x4C")]
	private float prevRpGageSize;

	// Token: 0x04009EB7 RID: 40631
	[Token(Token = "0x40077AF")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private HUDBadStatusIconDisp HUDBadStatusIconDisp;

	// Token: 0x04009EB8 RID: 40632
	[Token(Token = "0x40077B0")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private HUDPartnerBuffIcon partnerBuffIcon;

	// Token: 0x04009EB9 RID: 40633
	[Token(Token = "0x40077B1")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public Image CanDualImage;

	// Token: 0x04009EBA RID: 40634
	[Token(Token = "0x40077B2")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public Image DualGaugeImage;

	// Token: 0x04009EBB RID: 40635
	[Token(Token = "0x40077B3")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public Image SelectDualImage;

	// Token: 0x04009EBC RID: 40636
	[Token(Token = "0x40077B4")]
	[FieldOffset(Offset = "0x78")]
	public CharacterStatusBase Status;

	// Token: 0x04009EBD RID: 40637
	[Token(Token = "0x40077B5")]
	[FieldOffset(Offset = "0x80")]
	public bool CharacterAttached;

	// Token: 0x04009EBE RID: 40638
	[Token(Token = "0x40077B6")]
	[FieldOffset(Offset = "0x84")]
	private NPCID npcId;

	// Token: 0x04009EBF RID: 40639
	[Token(Token = "0x40077B7")]
	[FieldOffset(Offset = "0x88")]
	private PartyBase ptBase;

	// Token: 0x04009EC0 RID: 40640
	[Token(Token = "0x40077B8")]
	[FieldOffset(Offset = "0x90")]
	private PartyHuman pthuman;

	// Token: 0x04009EC1 RID: 40641
	[Token(Token = "0x40077B9")]
	[FieldOffset(Offset = "0x98")]
	private PartyMonster ptmonster;

	// Token: 0x04009EC2 RID: 40642
	[Token(Token = "0x40077BA")]
	[FieldOffset(Offset = "0xA0")]
	private PartyHandCuffs pthandcuff;

	// Token: 0x04009EC3 RID: 40643
	[Token(Token = "0x40077BB")]
	[FieldOffset(Offset = "0xA8")]
	private HumanStatus pthumanStatus;

	// Token: 0x04009EC4 RID: 40644
	[Token(Token = "0x40077BC")]
	[FieldOffset(Offset = "0xB0")]
	private bool IsPlayerMale;

	// Token: 0x04009EC5 RID: 40645
	[Token(Token = "0x40077BD")]
	[FieldOffset(Offset = "0xB4")]
	private float hp;

	// Token: 0x04009EC6 RID: 40646
	[Token(Token = "0x40077BE")]
	[FieldOffset(Offset = "0xB8")]
	private float hpMax;

	// Token: 0x04009EC7 RID: 40647
	[Token(Token = "0x40077BF")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Image BorderImage;

	// Token: 0x04009EC8 RID: 40648
	[Token(Token = "0x40077C0")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Sprite NPCBorder;

	// Token: 0x04009EC9 RID: 40649
	[Token(Token = "0x40077C1")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Sprite HandCuffBorder;

	// Token: 0x04009ECA RID: 40650
	[Token(Token = "0x40077C2")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private HUDDualWorkSelectInput HUDDualWorkSelectInput;

	// Token: 0x0200099C RID: 2460
	[Token(Token = "0x20012A9")]
	public enum CharactorType
	{
		// Token: 0x04009ECC RID: 40652
		[Token(Token = "0x401B36C")]
		Player,
		// Token: 0x04009ECD RID: 40653
		[Token(Token = "0x401B36D")]
		PartnerA,
		// Token: 0x04009ECE RID: 40654
		[Token(Token = "0x401B36E")]
		PartnerB,
		// Token: 0x04009ECF RID: 40655
		[Token(Token = "0x401B36F")]
		PartnerC
	}
}
