using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000817 RID: 2071
[Token(Token = "0x2000555")]
[Serializable]
public class NpcStatusData
{
	// Token: 0x06003746 RID: 14150 RVA: 0x00013158 File Offset: 0x00011358
	[Token(Token = "0x6002DFF")]
	[Address(RVA = "0x1F55210", Offset = "0x1F55311", VA = "0x1F55210")]
	public Gender GetGender()
	{
		return Gender.None;
	}

	// Token: 0x06003747 RID: 14151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E00")]
	[Address(RVA = "0x1F55290", Offset = "0x1F55391", VA = "0x1F55290")]
	public void ExpandItemType()
	{
	}

	// Token: 0x06003748 RID: 14152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E01")]
	[Address(RVA = "0x1F552D0", Offset = "0x1F553D1", VA = "0x1F552D0")]
	private void ExpandItemType(ref int[] itemIds)
	{
	}

	// Token: 0x06003749 RID: 14153 RVA: 0x00013170 File Offset: 0x00011370
	[Token(Token = "0x6002E02")]
	[Address(RVA = "0x1F547E0", Offset = "0x1F548E1", VA = "0x1F547E0")]
	public SoundID GetBathVoice()
	{
		return SoundID.Sound_EMPTY;
	}

	// Token: 0x0600374A RID: 14154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E03")]
	[Address(RVA = "0x1F55500", Offset = "0x1F55601", VA = "0x1F55500")]
	public NpcStatusData()
	{
	}

	// Token: 0x04007A66 RID: 31334
	[Token(Token = "0x4006ECF")]
	[FieldOffset(Offset = "0x10")]
	public ActorID ActorId;

	// Token: 0x04007A67 RID: 31335
	[Token(Token = "0x4006ED0")]
	[FieldOffset(Offset = "0x18")]
	public string FocusName;

	// Token: 0x04007A68 RID: 31336
	[Token(Token = "0x4006ED1")]
	[FieldOffset(Offset = "0x20")]
	public Gender Gender;

	// Token: 0x04007A69 RID: 31337
	[Token(Token = "0x4006ED2")]
	[FieldOffset(Offset = "0x24")]
	public int Age;

	// Token: 0x04007A6A RID: 31338
	[Token(Token = "0x4006ED3")]
	[FieldOffset(Offset = "0x28")]
	public Place Home;

	// Token: 0x04007A6B RID: 31339
	[Token(Token = "0x4006ED4")]
	[FieldOffset(Offset = "0x2C")]
	public Place Job;

	// Token: 0x04007A6C RID: 31340
	[Token(Token = "0x4006ED5")]
	[FieldOffset(Offset = "0x30")]
	public string BedPatrolPointName;

	// Token: 0x04007A6D RID: 31341
	[Token(Token = "0x4006ED6")]
	[FieldOffset(Offset = "0x38")]
	public PersonalityType[] Personality;

	// Token: 0x04007A6E RID: 31342
	[Token(Token = "0x4006ED7")]
	[FieldOffset(Offset = "0x40")]
	public int[] FavoriteNpcId;

	// Token: 0x04007A6F RID: 31343
	[Token(Token = "0x4006ED8")]
	[FieldOffset(Offset = "0x48")]
	public Season FavoriteSeason;

	// Token: 0x04007A70 RID: 31344
	[Token(Token = "0x4006ED9")]
	[FieldOffset(Offset = "0x50")]
	public int[] FavoriteItem;

	// Token: 0x04007A71 RID: 31345
	[Token(Token = "0x4006EDA")]
	[FieldOffset(Offset = "0x58")]
	public int[] VeryFavoriteItem;

	// Token: 0x04007A72 RID: 31346
	[Token(Token = "0x4006EDB")]
	[FieldOffset(Offset = "0x60")]
	public int[] NotFavoriteItem;

	// Token: 0x04007A73 RID: 31347
	[Token(Token = "0x4006EDC")]
	[FieldOffset(Offset = "0x68")]
	public int[] NotFavoriteBadlyItem;

	// Token: 0x04007A74 RID: 31348
	[Token(Token = "0x4006EDD")]
	[FieldOffset(Offset = "0x70")]
	public string[] NickNameToPlayerTable;

	// Token: 0x04007A75 RID: 31349
	[Token(Token = "0x4006EDE")]
	[FieldOffset(Offset = "0x78")]
	public string[] NickNameFromPlayerTable;

	// Token: 0x04007A76 RID: 31350
	[Token(Token = "0x4006EDF")]
	[FieldOffset(Offset = "0x80")]
	public int LatenessTime;

	// Token: 0x04007A77 RID: 31351
	[Token(Token = "0x4006EE0")]
	[FieldOffset(Offset = "0x84")]
	public bool ScaredThunder;

	// Token: 0x04007A78 RID: 31352
	[Token(Token = "0x4006EE1")]
	[FieldOffset(Offset = "0x88")]
	public float WalkIndividualSpeed;

	// Token: 0x04007A79 RID: 31353
	[Token(Token = "0x4006EE2")]
	[FieldOffset(Offset = "0x90")]
	public string PartnerPersonality;

	// Token: 0x04007A7A RID: 31354
	[Token(Token = "0x4006EE3")]
	[FieldOffset(Offset = "0x98")]
	public string PartnerInitialWeapon;

	// Token: 0x04007A7B RID: 31355
	[Token(Token = "0x4006EE4")]
	[FieldOffset(Offset = "0xA0")]
	public string PartnerSpecialSkill;

	// Token: 0x04007A7C RID: 31356
	[Token(Token = "0x4006EE5")]
	[FieldOffset(Offset = "0xA8")]
	public string[] PartnerFavoriteWeapon;

	// Token: 0x04007A7D RID: 31357
	[Token(Token = "0x4006EE6")]
	[FieldOffset(Offset = "0xB0")]
	public SoundID GreetingVoice;

	// Token: 0x04007A7E RID: 31358
	[Token(Token = "0x4006EE7")]
	[FieldOffset(Offset = "0xB4")]
	public SoundID SleepingVoice;

	// Token: 0x04007A7F RID: 31359
	[Token(Token = "0x4006EE8")]
	[FieldOffset(Offset = "0xB8")]
	public ItemID BirthdayPresent;

	// Token: 0x04007A80 RID: 31360
	[Token(Token = "0x4006EE9")]
	[FieldOffset(Offset = "0xC0")]
	public string ReturnGoodsType;

	// Token: 0x04007A81 RID: 31361
	[Token(Token = "0x4006EEA")]
	[FieldOffset(Offset = "0xC8")]
	public ItemID[] EveryDayPresentAfterMarriage;

	// Token: 0x04007A82 RID: 31362
	[Token(Token = "0x4006EEB")]
	[FieldOffset(Offset = "0xD0")]
	public ItemID PresentBath;

	// Token: 0x04007A83 RID: 31363
	[Token(Token = "0x4006EEC")]
	[FieldOffset(Offset = "0xD4")]
	public bool MarriageCandidate;

	// Token: 0x04007A84 RID: 31364
	[Token(Token = "0x4006EED")]
	[FieldOffset(Offset = "0xD8")]
	public SoundID OmedetouVoice;

	// Token: 0x04007A85 RID: 31365
	[Token(Token = "0x4006EEE")]
	[FieldOffset(Offset = "0xE0")]
	public Place[] FavoritePlace;

	// Token: 0x04007A86 RID: 31366
	[Token(Token = "0x4006EEF")]
	[FieldOffset(Offset = "0xE8")]
	public Place[] HolidayFavoritePlace;

	// Token: 0x04007A87 RID: 31367
	[Token(Token = "0x4006EF0")]
	[FieldOffset(Offset = "0xF0")]
	public SkillID[] ExRandomSkillID;

	// Token: 0x04007A88 RID: 31368
	[Token(Token = "0x4006EF1")]
	[FieldOffset(Offset = "0xF8")]
	public SkillID ExSkillID_A;

	// Token: 0x04007A89 RID: 31369
	[Token(Token = "0x4006EF2")]
	[FieldOffset(Offset = "0xFC")]
	public SkillID ExSkillID_B;

	// Token: 0x04007A8A RID: 31370
	[Token(Token = "0x4006EF3")]
	[FieldOffset(Offset = "0x100")]
	public ItemID ExRecipeID;

	// Token: 0x04007A8B RID: 31371
	[Token(Token = "0x4006EF4")]
	[FieldOffset(Offset = "0x108")]
	public ItemID[] FesFlowerItem;

	// Token: 0x04007A8C RID: 31372
	[Token(Token = "0x4006EF5")]
	[FieldOffset(Offset = "0x110")]
	public SkillID[] HomeSkillID_A;

	// Token: 0x04007A8D RID: 31373
	[Token(Token = "0x4006EF6")]
	[FieldOffset(Offset = "0x118")]
	public SkillID HomeSkillID_B;

	// Token: 0x04007A8E RID: 31374
	[Token(Token = "0x4006EF7")]
	[FieldOffset(Offset = "0x11C")]
	public SkillID HomeSkillID_C;

	// Token: 0x04007A8F RID: 31375
	[Token(Token = "0x4006EF8")]
	[FieldOffset(Offset = "0x120")]
	public SkillID HomeSkillID_D;

	// Token: 0x04007A90 RID: 31376
	[Token(Token = "0x4006EF9")]
	[FieldOffset(Offset = "0x124")]
	public SkillID HomeSkillID_E;

	// Token: 0x04007A91 RID: 31377
	[Token(Token = "0x4006EFA")]
	[FieldOffset(Offset = "0x128")]
	public SkillID HomeSkillID_F;

	// Token: 0x04007A92 RID: 31378
	[Token(Token = "0x4006EFB")]
	[FieldOffset(Offset = "0x12C")]
	public float OffsetSittingPosY;

	// Token: 0x04007A93 RID: 31379
	[Token(Token = "0x4006EFC")]
	[FieldOffset(Offset = "0x130")]
	public float OffsetSleepingPosY;

	// Token: 0x04007A94 RID: 31380
	[Token(Token = "0x4006EFD")]
	[FieldOffset(Offset = "0x134")]
	public SoundID ChillingVoice;

	// Token: 0x04007A95 RID: 31381
	[Token(Token = "0x4006EFE")]
	[FieldOffset(Offset = "0x138")]
	public SoundID ChillingVoice_Anxiety;

	// Token: 0x04007A96 RID: 31382
	[Token(Token = "0x4006EFF")]
	[FieldOffset(Offset = "0x140")]
	public SoundID[] BathVoice;
}
