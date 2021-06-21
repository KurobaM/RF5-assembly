using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A1D RID: 2589
[Token(Token = "0x20006CA")]
public class HumanStatusA : MonoBehaviour
{
	// Token: 0x060043DB RID: 17371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038C7")]
	[Address(RVA = "0x22298A0", Offset = "0x22299A1", VA = "0x22298A0")]
	public void SetParameter(ActorID actor_id, HumanStatus humanStatus)
	{
	}

	// Token: 0x060043DC RID: 17372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038C8")]
	[Address(RVA = "0x2229C20", Offset = "0x2229D21", VA = "0x2229C20")]
	public void SetParameter(FriendMonsterStatus monsterStatusController)
	{
	}

	// Token: 0x060043DD RID: 17373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038C9")]
	[Address(RVA = "0x222A000", Offset = "0x222A101", VA = "0x222A000")]
	public void SetParameter(HandCuffsStatus monsterStatusController, MonsterDataTable monsterDataTable)
	{
	}

	// Token: 0x060043DE RID: 17374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038CA")]
	[Address(RVA = "0x222A3D0", Offset = "0x222A4D1", VA = "0x222A3D0")]
	public HumanStatusA()
	{
	}

	// Token: 0x0400A2B5 RID: 41653
	[Token(Token = "0x4007AF4")]
	[FieldOffset(Offset = "0x18")]
	public HumanStatusA.HumanType type;

	// Token: 0x0400A2B6 RID: 41654
	[Token(Token = "0x4007AF5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text LvText;

	// Token: 0x0400A2B7 RID: 41655
	[Token(Token = "0x4007AF6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image ExpGauge;

	// Token: 0x0400A2B8 RID: 41656
	[Token(Token = "0x4007AF7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text HpText;

	// Token: 0x0400A2B9 RID: 41657
	[Token(Token = "0x4007AF8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image HpGauge;

	// Token: 0x0400A2BA RID: 41658
	[Token(Token = "0x4007AF9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text RpText;

	// Token: 0x0400A2BB RID: 41659
	[Token(Token = "0x4007AFA")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image RpGauge;

	// Token: 0x0400A2BC RID: 41660
	[Token(Token = "0x4007AFB")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image RideIcon1;

	// Token: 0x0400A2BD RID: 41661
	[Token(Token = "0x4007AFC")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image RideIcon2;

	// Token: 0x0400A2BE RID: 41662
	[Token(Token = "0x4007AFD")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Sprite Ride1SpriteOK;

	// Token: 0x0400A2BF RID: 41663
	[Token(Token = "0x4007AFE")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Sprite Ride2SpriteOK;

	// Token: 0x0400A2C0 RID: 41664
	[Token(Token = "0x4007AFF")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Sprite Ride1SpriteNG;

	// Token: 0x0400A2C1 RID: 41665
	[Token(Token = "0x4007B00")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Sprite Ride2SpriteNG;

	// Token: 0x02000A1E RID: 2590
	[Token(Token = "0x20012D5")]
	public enum HumanType
	{
		// Token: 0x0400A2C3 RID: 41667
		[Token(Token = "0x401B425")]
		Player,
		// Token: 0x0400A2C4 RID: 41668
		[Token(Token = "0x401B426")]
		PartnerA,
		// Token: 0x0400A2C5 RID: 41669
		[Token(Token = "0x401B427")]
		PartnerB,
		// Token: 0x0400A2C6 RID: 41670
		[Token(Token = "0x401B428")]
		PartnerC
	}
}
