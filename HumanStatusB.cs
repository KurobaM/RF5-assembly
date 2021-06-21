using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A1F RID: 2591
[Token(Token = "0x20006CB")]
public class HumanStatusB : MonoBehaviour
{
	// Token: 0x060043DF RID: 17375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038CB")]
	[Address(RVA = "0x222A3E0", Offset = "0x222A4E1", VA = "0x222A3E0")]
	public void SetParameter(ActorID actor_id, HumanStatus status)
	{
	}

	// Token: 0x060043E0 RID: 17376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038CC")]
	[Address(RVA = "0x222A820", Offset = "0x222A921", VA = "0x222A820")]
	public void SetParameter(MonsterID monsterId, CharacterStatusBase statusController)
	{
	}

	// Token: 0x060043E1 RID: 17377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038CD")]
	[Address(RVA = "0x222AC60", Offset = "0x222AD61", VA = "0x222AC60")]
	public HumanStatusB()
	{
	}

	// Token: 0x0400A2C7 RID: 41671
	[Token(Token = "0x4007B01")]
	[FieldOffset(Offset = "0x18")]
	public HumanStatusB.HumanType type;

	// Token: 0x0400A2C8 RID: 41672
	[Token(Token = "0x4007B02")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text ATKText;

	// Token: 0x0400A2C9 RID: 41673
	[Token(Token = "0x4007B03")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text DEFText;

	// Token: 0x0400A2CA RID: 41674
	[Token(Token = "0x4007B04")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text MATKText;

	// Token: 0x0400A2CB RID: 41675
	[Token(Token = "0x4007B05")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text MDEFText;

	// Token: 0x0400A2CC RID: 41676
	[Token(Token = "0x4007B06")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text STRText;

	// Token: 0x0400A2CD RID: 41677
	[Token(Token = "0x4007B07")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text VITText;

	// Token: 0x0400A2CE RID: 41678
	[Token(Token = "0x4007B08")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text INTText;

	// Token: 0x0400A2CF RID: 41679
	[Token(Token = "0x4007B09")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text FireResistText;

	// Token: 0x0400A2D0 RID: 41680
	[Token(Token = "0x4007B0A")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text WaterResistText;

	// Token: 0x0400A2D1 RID: 41681
	[Token(Token = "0x4007B0B")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text EarthResistText;

	// Token: 0x0400A2D2 RID: 41682
	[Token(Token = "0x4007B0C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text WindResistText;

	// Token: 0x0400A2D3 RID: 41683
	[Token(Token = "0x4007B0D")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Text LightResistText;

	// Token: 0x0400A2D4 RID: 41684
	[Token(Token = "0x4007B0E")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text DarkResistText;

	// Token: 0x0400A2D5 RID: 41685
	[Token(Token = "0x4007B0F")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Text LoveResistText;

	// Token: 0x02000A20 RID: 2592
	[Token(Token = "0x20012D6")]
	public enum HumanType
	{
		// Token: 0x0400A2D7 RID: 41687
		[Token(Token = "0x401B42A")]
		Player,
		// Token: 0x0400A2D8 RID: 41688
		[Token(Token = "0x401B42B")]
		PartnerA,
		// Token: 0x0400A2D9 RID: 41689
		[Token(Token = "0x401B42C")]
		PartnerB,
		// Token: 0x0400A2DA RID: 41690
		[Token(Token = "0x401B42D")]
		PartnerC
	}
}
