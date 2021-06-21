using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x0200033F RID: 831
[Token(Token = "0x200026F")]
public class BattleConst : ScriptableObject
{
	// Token: 0x0600163E RID: 5694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B1")]
	[Address(RVA = "0x2207A40", Offset = "0x2207B41", VA = "0x2207A40")]
	public BattleConst.ShieldEffect GetShieldEffectByItemCategory(ItemCategory itemCategory)
	{
		return null;
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x00009E70 File Offset: 0x00008070
	[Token(Token = "0x60013B2")]
	[Address(RVA = "0x2207AD0", Offset = "0x2207BD1", VA = "0x2207AD0")]
	public int GetCanCatchWantedMonsterHPByStarLevel(int starLevel)
	{
		return 0;
	}

	// Token: 0x17000404 RID: 1028
	// (get) Token: 0x06001640 RID: 5696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700039A")]
	public static BattleConst Instance
	{
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x2207B30", Offset = "0x2207C31", VA = "0x2207B30")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x2207C40", Offset = "0x2207D41", VA = "0x2207C40")]
	public BattleConst()
	{
	}

	// Token: 0x04000CD8 RID: 3288
	[Token(Token = "0x40009BD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float Hard_CriticalRate;

	// Token: 0x04000CD9 RID: 3289
	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float Easy_DamageRate;

	// Token: 0x04000CDA RID: 3290
	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float DamageRandomFactor;

	// Token: 0x04000CDB RID: 3291
	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float AttributeDamageRate;

	// Token: 0x04000CDC RID: 3292
	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float AttributeDefenseRate;

	// Token: 0x04000CDD RID: 3293
	[Token(Token = "0x40009C2")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float PartyDamageRate;

	// Token: 0x04000CDE RID: 3294
	[Token(Token = "0x40009C3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float SuperArmerDefenseRate;

	// Token: 0x04000CDF RID: 3295
	[Token(Token = "0x40009C4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public BattleConst.ShieldEffect ShieldEffect_Sword;

	// Token: 0x04000CE0 RID: 3296
	[Token(Token = "0x40009C5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public BattleConst.ShieldEffect ShieldEffect_DHSword;

	// Token: 0x04000CE1 RID: 3297
	[Token(Token = "0x40009C6")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public BattleConst.ShieldEffect ShieldEffect_Spear;

	// Token: 0x04000CE2 RID: 3298
	[Token(Token = "0x40009C7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public BattleConst.ShieldEffect ShieldEffect_Axe;

	// Token: 0x04000CE3 RID: 3299
	[Token(Token = "0x40009C8")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public BattleConst.ShieldEffect ShieldEffect_Hammer;

	// Token: 0x04000CE4 RID: 3300
	[Token(Token = "0x40009C9")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public BattleConst.ShieldEffect ShieldEffect_TwinSword;

	// Token: 0x04000CE5 RID: 3301
	[Token(Token = "0x40009CA")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public BattleConst.ShieldEffect ShieldEffect_Fist;

	// Token: 0x04000CE6 RID: 3302
	[Token(Token = "0x40009CB")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public BattleConst.ShieldEffect ShieldEffect_Wand;

	// Token: 0x04000CE7 RID: 3303
	[Token(Token = "0x40009CC")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public BattleConst.ShieldEffect ShieldEffect_Farm_Tool;

	// Token: 0x04000CE8 RID: 3304
	[Token(Token = "0x40009CD")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public float BaseKnockback_Length;

	// Token: 0x04000CE9 RID: 3305
	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public float BaseKnockback_Time;

	// Token: 0x04000CEA RID: 3306
	[Token(Token = "0x40009CF")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public float BaseKnockback_Time_ForPlayer;

	// Token: 0x04000CEB RID: 3307
	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	public float KnockbackMax;

	// Token: 0x04000CEC RID: 3308
	[Token(Token = "0x40009D1")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public float CauserKnockbackPower;

	// Token: 0x04000CED RID: 3309
	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	public float BlowCountMax;

	// Token: 0x04000CEE RID: 3310
	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	public float BaseBlowPower;

	// Token: 0x04000CEF RID: 3311
	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	public float BlowHealSec;

	// Token: 0x04000CF0 RID: 3312
	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	public float BlowHealCoolTime;

	// Token: 0x04000CF1 RID: 3313
	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	public float HitBackPower;

	// Token: 0x04000CF2 RID: 3314
	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	public float KnockBackRateMax;

	// Token: 0x04000CF3 RID: 3315
	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	public float CauserKnockBackRateMax;

	// Token: 0x04000CF4 RID: 3316
	[Token(Token = "0x40009D9")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	public int BlowPower_Sword;

	// Token: 0x04000CF5 RID: 3317
	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	public int BlowPower_DHSword;

	// Token: 0x04000CF6 RID: 3318
	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	public int BlowPower_Axe;

	// Token: 0x04000CF7 RID: 3319
	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	public int BlowPower_Hammer;

	// Token: 0x04000CF8 RID: 3320
	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	public int BlowPower_Wand;

	// Token: 0x04000CF9 RID: 3321
	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0xC4")]
	[SerializeField]
	public int BlowPower_Fist;

	// Token: 0x04000CFA RID: 3322
	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	public int BlowPower_TwinSword;

	// Token: 0x04000CFB RID: 3323
	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	public int BlowPower_Spear;

	// Token: 0x04000CFC RID: 3324
	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public int BlowPower_Farm_Tool;

	// Token: 0x04000CFD RID: 3325
	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	public float HandCuffs_Distance;

	// Token: 0x04000CFE RID: 3326
	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public float HandCuffs_FullChargeTime;

	// Token: 0x04000CFF RID: 3327
	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	public float HandCuffs_CT_Normal;

	// Token: 0x04000D00 RID: 3328
	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public float HandCuffs_CT_Charge;

	// Token: 0x04000D01 RID: 3329
	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	public float HandCuffs_CT_SkillLevelBias;

	// Token: 0x04000D02 RID: 3330
	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	public float HandCuffs_CT_Normal_MinTime;

	// Token: 0x04000D03 RID: 3331
	[Token(Token = "0x40009E8")]
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	public float HandCuffs_LP;

	// Token: 0x04000D04 RID: 3332
	[Token(Token = "0x40009E9")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public float HandCuffs_LP_Max;

	// Token: 0x04000D05 RID: 3333
	[Token(Token = "0x40009EA")]
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	public float HandCuffs_LP_SkillLevelBias;

	// Token: 0x04000D06 RID: 3334
	[Token(Token = "0x40009EB")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	public float HandCuffs_LT;

	// Token: 0x04000D07 RID: 3335
	[Token(Token = "0x40009EC")]
	[FieldOffset(Offset = "0xFC")]
	[SerializeField]
	public float HandCuffs_LT_SkillLevelBias;

	// Token: 0x04000D08 RID: 3336
	[Token(Token = "0x40009ED")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public float HandCuffs_CP_Lv_Upper;

	// Token: 0x04000D09 RID: 3337
	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	public float HandCuffs_CP_SkillLevelBias;

	// Token: 0x04000D0A RID: 3338
	[Token(Token = "0x40009EF")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	public float HandCuffs_HealSpeed;

	// Token: 0x04000D0B RID: 3339
	[Token(Token = "0x40009F0")]
	[FieldOffset(Offset = "0x10C")]
	[SerializeField]
	public float HandCuffs_CP_EnemyHP;

	// Token: 0x04000D0C RID: 3340
	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	public float HandCuffs_ItemCP_Radius;

	// Token: 0x04000D0D RID: 3341
	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	public float OutSidePartyMonsterExpRate;

	// Token: 0x04000D0E RID: 3342
	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	public int PoliceBatch_RookieHP;

	// Token: 0x04000D0F RID: 3343
	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	public float AvoidInvincibleDuration;

	// Token: 0x04000D10 RID: 3344
	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	public int ChargeAttack_Unlock_Level;

	// Token: 0x04000D11 RID: 3345
	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	public int EnemyTargetDamageAction_DecreaseAttackSelectPercent;

	// Token: 0x04000D12 RID: 3346
	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	public int WantedStarLevelOne_CC_MonsterHP;

	// Token: 0x04000D13 RID: 3347
	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x12C")]
	[SerializeField]
	public int WantedStarLevelTwo_CC_MonsterHP;

	// Token: 0x04000D14 RID: 3348
	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	public int WantedStarLevelThree_CC_MonsterHP;

	// Token: 0x04000D15 RID: 3349
	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x134")]
	[SerializeField]
	public int WantedStarLevelFour_CC_MonsterHP;

	// Token: 0x04000D16 RID: 3350
	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	public int WantedStarLevelFive_CC_MonsterHP;

	// Token: 0x04000D17 RID: 3351
	[Token(Token = "0x40009FC")]
	[FieldOffset(Offset = "0x13C")]
	[SerializeField]
	public int AutoRPHeal_Amount;

	// Token: 0x04000D18 RID: 3352
	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	public float AutoRPHeal_Interval;

	// Token: 0x04000D19 RID: 3353
	[Token(Token = "0x40009FE")]
	[FieldOffset(Offset = "0x144")]
	public float AutoRPHeal_StartTime;

	// Token: 0x04000D1A RID: 3354
	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	public float DeadWaitTime;

	// Token: 0x04000D1B RID: 3355
	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x14C")]
	public float InvincibleTime_Getup;

	// Token: 0x04000D1C RID: 3356
	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	public int FocusEnemyNameColorRed_LevelDiff;

	// Token: 0x04000D1D RID: 3357
	[Token(Token = "0x4000A02")]
	[FieldOffset(Offset = "0x154")]
	[SerializeField]
	public int FocusEnemyNameColorOrange_LevelDiff;

	// Token: 0x04000D1E RID: 3358
	[Token(Token = "0x4000A03")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	public int WaterPotAmount_01;

	// Token: 0x04000D1F RID: 3359
	[Token(Token = "0x4000A04")]
	[FieldOffset(Offset = "0x15C")]
	[SerializeField]
	public int WaterPotAmount_02;

	// Token: 0x04000D20 RID: 3360
	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	public int WaterPotAmount_03;

	// Token: 0x04000D21 RID: 3361
	[Token(Token = "0x4000A06")]
	[FieldOffset(Offset = "0x164")]
	[SerializeField]
	public int WaterPotAmount_04;

	// Token: 0x04000D22 RID: 3362
	[Token(Token = "0x4000A07")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	public int WaterPotAmount_05;

	// Token: 0x04000D23 RID: 3363
	[Token(Token = "0x4000A08")]
	[FieldOffset(Offset = "0x16C")]
	[SerializeField]
	public float YKillHeight;

	// Token: 0x04000D24 RID: 3364
	[Token(Token = "0x4000A09")]
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	public float DualSkill_ApplyDamage;

	// Token: 0x04000D25 RID: 3365
	[Token(Token = "0x4000A0A")]
	[FieldOffset(Offset = "0x174")]
	[SerializeField]
	public float DualSkill_TakeDamage;

	// Token: 0x04000D26 RID: 3366
	[Token(Token = "0x4000A0B")]
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	public float DualSkill_TakeHeal;

	// Token: 0x04000D27 RID: 3367
	[Token(Token = "0x4000A0C")]
	[FieldOffset(Offset = "0x17C")]
	[SerializeField]
	public float DualSkill_UseRA;

	// Token: 0x04000D28 RID: 3368
	[Token(Token = "0x4000A0D")]
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	public float DualSkill_UseMagic;

	// Token: 0x04000D29 RID: 3369
	[Token(Token = "0x4000A0E")]
	[FieldOffset(Offset = "0x184")]
	[SerializeField]
	public float DualSkill_DestroyEnemy;

	// Token: 0x04000D2A RID: 3370
	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	public float DualSkill_PlayerRate;

	// Token: 0x04000D2B RID: 3371
	[Token(Token = "0x4000A10")]
	[FieldOffset(Offset = "0x18C")]
	[SerializeField]
	public float DualSkill_BadgeRate;

	// Token: 0x04000D2C RID: 3372
	[Token(Token = "0x4000A11")]
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	public float DualSkill_Attack;

	// Token: 0x04000D2D RID: 3373
	[Token(Token = "0x4000A12")]
	[FieldOffset(Offset = "0x194")]
	[SerializeField]
	public float TrowDamage_Base;

	// Token: 0x04000D2E RID: 3374
	[Token(Token = "0x4000A13")]
	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	public float TrowDamageRate_Lv200;

	// Token: 0x04000D2F RID: 3375
	[Token(Token = "0x4000A14")]
	[FieldOffset(Offset = "0x19C")]
	[SerializeField]
	public float TrowDamageRate_Lv100;

	// Token: 0x04000D30 RID: 3376
	[Token(Token = "0x4000A15")]
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	public float TrowDamageRate_Lv80;

	// Token: 0x04000D31 RID: 3377
	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0x1A4")]
	[SerializeField]
	public float TrowDamageRate_Lv60;

	// Token: 0x04000D32 RID: 3378
	[Token(Token = "0x4000A17")]
	[FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	public float TrowDamageRate_Lv40;

	// Token: 0x04000D33 RID: 3379
	[Token(Token = "0x4000A18")]
	[FieldOffset(Offset = "0x1AC")]
	[SerializeField]
	public float TrowDamageRate_Lv20;

	// Token: 0x04000D34 RID: 3380
	[Token(Token = "0x4000A19")]
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	public float LockonRange_Player;

	// Token: 0x04000D35 RID: 3381
	[Token(Token = "0x4000A1A")]
	[FieldOffset(Offset = "0x1B4")]
	[SerializeField]
	public float LockonAngle_Player;

	// Token: 0x04000D36 RID: 3382
	[Token(Token = "0x4000A1B")]
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	public float LockonRange_Other;

	// Token: 0x04000D37 RID: 3383
	[Token(Token = "0x4000A1C")]
	[FieldOffset(Offset = "0x1BC")]
	[SerializeField]
	public float LockonAngle_Other;

	// Token: 0x04000D38 RID: 3384
	[Token(Token = "0x4000A1D")]
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	public float AutoLockonRange;

	// Token: 0x04000D39 RID: 3385
	[Token(Token = "0x4000A1E")]
	[FieldOffset(Offset = "0x1C4")]
	[SerializeField]
	public float AutoLockonAngle;

	// Token: 0x04000D3A RID: 3386
	[Token(Token = "0x4000A1F")]
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	public float FootSteps_Human_SoundDistanceMax;

	// Token: 0x04000D3B RID: 3387
	[Token(Token = "0x4000A20")]
	[FieldOffset(Offset = "0x1CC")]
	[SerializeField]
	public float FootSteps_Human_SoundDistanceMin;

	// Token: 0x04000D3C RID: 3388
	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	public float FootSteps_Human_EffectDistance;

	// Token: 0x04000D3D RID: 3389
	[Token(Token = "0x4000A22")]
	[FieldOffset(Offset = "0x1D4")]
	[SerializeField]
	public float FootSteps_Small_SoundDistanceMax;

	// Token: 0x04000D3E RID: 3390
	[Token(Token = "0x4000A23")]
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	public float FootSteps_Small_SoundDistanceMin;

	// Token: 0x04000D3F RID: 3391
	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0x1DC")]
	[SerializeField]
	public float FootSteps_Small_EffectDistance;

	// Token: 0x04000D40 RID: 3392
	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	public float FootSteps_Medium_SoundDistanceMax;

	// Token: 0x04000D41 RID: 3393
	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0x1E4")]
	[SerializeField]
	public float FootSteps_Medium_SoundDistanceMin;

	// Token: 0x04000D42 RID: 3394
	[Token(Token = "0x4000A27")]
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	public float FootSteps_Medium_EffectDistance;

	// Token: 0x04000D43 RID: 3395
	[Token(Token = "0x4000A28")]
	[FieldOffset(Offset = "0x1EC")]
	[SerializeField]
	public float FootSteps_Large_SoundDistanceMax;

	// Token: 0x04000D44 RID: 3396
	[Token(Token = "0x4000A29")]
	[FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	public float FootSteps_Large_SoundDistanceMin;

	// Token: 0x04000D45 RID: 3397
	[Token(Token = "0x4000A2A")]
	[FieldOffset(Offset = "0x1F4")]
	[SerializeField]
	public float FootSteps_Large_EffectDistance;

	// Token: 0x04000D46 RID: 3398
	[Token(Token = "0x4000A2B")]
	[FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	public float FootSteps_SoundPlayMax;

	// Token: 0x04000D47 RID: 3399
	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0x1FC")]
	[SerializeField]
	public float FootSteps_SoundPlayObservePeriod;

	// Token: 0x04000D48 RID: 3400
	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0x200")]
	[SerializeField]
	public float FootSteps_SoundVolumeMax;

	// Token: 0x04000D49 RID: 3401
	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0x204")]
	[SerializeField]
	public float FootSteps_SoundVolumeMin;

	// Token: 0x04000D4A RID: 3402
	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0x208")]
	[SerializeField]
	public float FootSteps_SoundPitchRange;

	// Token: 0x04000D4B RID: 3403
	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x20C")]
	[SerializeField]
	public float GrappleBuster_ImpactSize_S;

	// Token: 0x04000D4C RID: 3404
	[Token(Token = "0x4000A31")]
	[FieldOffset(Offset = "0x210")]
	[SerializeField]
	public float GrappleBuster_ImpactSize_M;

	// Token: 0x04000D4D RID: 3405
	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x214")]
	[SerializeField]
	public float GrappleBuster_ImpactSize_L;

	// Token: 0x04000D4E RID: 3406
	[Token(Token = "0x4000A33")]
	[FieldOffset(Offset = "0x218")]
	[SerializeField]
	public int WalkSkillCount;

	// Token: 0x04000D4F RID: 3407
	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x21C")]
	[SerializeField]
	public float PoisonInterval;

	// Token: 0x04000D50 RID: 3408
	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x220")]
	[SerializeField]
	public float SickInterval;

	// Token: 0x04000D51 RID: 3409
	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x224")]
	[SerializeField]
	public float SickDamage;

	// Token: 0x04000D52 RID: 3410
	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x228")]
	[SerializeField]
	public float StunTime;

	// Token: 0x04000D53 RID: 3411
	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0x22C")]
	[SerializeField]
	public float SleepTime;

	// Token: 0x04000D54 RID: 3412
	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x230")]
	[SerializeField]
	public float Influence_AttakSkill;

	// Token: 0x04000D55 RID: 3413
	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x234")]
	[SerializeField]
	public float Influence_AttributeSkill;

	// Token: 0x04000D56 RID: 3414
	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x238")]
	[SerializeField]
	public float Influence_LeaderSkill;

	// Token: 0x04000D57 RID: 3415
	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0x23C")]
	[SerializeField]
	public float Influence_MonsterSkill;

	// Token: 0x04000D58 RID: 3416
	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0x240")]
	[SerializeField]
	public float SeedSupport_CoolTime;

	// Token: 0x04000D59 RID: 3417
	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0x244")]
	[SerializeField]
	public float SeedSupport_Countdown;

	// Token: 0x04000D5A RID: 3418
	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0x248")]
	[SerializeField]
	public float EquipSubAttribute_Sneaking_Param;

	// Token: 0x04000D5B RID: 3419
	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0x24C")]
	[SerializeField]
	public float EquipSubAttribute_DashUp_Param;

	// Token: 0x04000D5C RID: 3420
	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x250")]
	[SerializeField]
	public float EquipSubAttribute_MaxDash_Param;

	// Token: 0x04000D5D RID: 3421
	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x254")]
	[SerializeField]
	public float EquipSubAttribute_SpeedDown_Param;

	// Token: 0x04000D5E RID: 3422
	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0x258")]
	[SerializeField]
	public float EquipSubAttribute_Rolling_Param;

	// Token: 0x04000D5F RID: 3423
	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x25C")]
	[SerializeField]
	public float EquipSubAttribute_Annette_Param1;

	// Token: 0x04000D60 RID: 3424
	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x260")]
	[SerializeField]
	public float EquipSubAttribute_Annette_Param2;

	// Token: 0x04000D61 RID: 3425
	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x264")]
	[SerializeField]
	public SoundID EquipSubAttribute_SeChange1_SoundID;

	// Token: 0x04000D62 RID: 3426
	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0x268")]
	[SerializeField]
	public SoundID EquipSubAttribute_SeChange2_SoundID;

	// Token: 0x04000D63 RID: 3427
	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x26C")]
	[SerializeField]
	public float EquipSubAttribute_KnockbackDef_Param;

	// Token: 0x04000D64 RID: 3428
	[Token(Token = "0x4000A49")]
	[FieldOffset(Offset = "0x270")]
	[SerializeField]
	public float EquipSubAttribute_HatakePlow_SpeedParam;

	// Token: 0x04000D65 RID: 3429
	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x274")]
	[SerializeField]
	public float EquipSubAttribute_BfrAtc_Param;

	// Token: 0x04000D66 RID: 3430
	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	public float EquipSubAttribute_GstAtc_Param;

	// Token: 0x04000D67 RID: 3431
	[Token(Token = "0x4000A4C")]
	[FieldOffset(Offset = "0x27C")]
	[SerializeField]
	public float EquipSubAttribute_AtkLength_Param1;

	// Token: 0x04000D68 RID: 3432
	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0x280")]
	[SerializeField]
	public float EquipSubAttribute_AtkLength_PosMin;

	// Token: 0x04000D69 RID: 3433
	[Token(Token = "0x4000A4E")]
	[FieldOffset(Offset = "0x284")]
	[SerializeField]
	public float EquipSubAttribute_AtkLength_PosMax;

	// Token: 0x04000D6A RID: 3434
	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0x288")]
	[SerializeField]
	public float EquipSubAttribute_AtkLength_ScaleMin;

	// Token: 0x04000D6B RID: 3435
	[Token(Token = "0x4000A50")]
	[FieldOffset(Offset = "0x28C")]
	[SerializeField]
	public float EquipSubAttribute_AtkLength_ScaleMax;

	// Token: 0x04000D6C RID: 3436
	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x290")]
	[SerializeField]
	public float EquipSubAttribute_RpHerf_Param;

	// Token: 0x04000D6D RID: 3437
	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0x294")]
	[SerializeField]
	public float EquipSubAttribute_RpZero_Param;

	// Token: 0x04000D6E RID: 3438
	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x298")]
	[SerializeField]
	public float EquipSubAttribute_SkillExp_Param;

	// Token: 0x04000D6F RID: 3439
	[Token(Token = "0x4000A54")]
	[FieldOffset(Offset = "0x29C")]
	[SerializeField]
	public float EquipSubAttribute_General_Param1;

	// Token: 0x04000D70 RID: 3440
	[Token(Token = "0x4000A55")]
	[FieldOffset(Offset = "0x2A0")]
	[SerializeField]
	public float EquipSubAttribute_General_Param2;

	// Token: 0x04000D71 RID: 3441
	[Token(Token = "0x4000A56")]
	[FieldOffset(Offset = "0x2A4")]
	[SerializeField]
	public int EquipSubAttribute_LuckyDrop1_Param1;

	// Token: 0x04000D72 RID: 3442
	[Token(Token = "0x4000A57")]
	[FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	public int EquipSubAttribute_LuckyDrop1_Param2;

	// Token: 0x04000D73 RID: 3443
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x2AC")]
	[SerializeField]
	public int EquipSubAttribute_LuckyDrop2_Param1;

	// Token: 0x04000D74 RID: 3444
	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	public int EquipSubAttribute_LuckyDrop2_Param2;

	// Token: 0x04000D75 RID: 3445
	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0x2B4")]
	[SerializeField]
	public int EquipSubAttribute_RareDrop_Param1;

	// Token: 0x04000D76 RID: 3446
	[Token(Token = "0x4000A5B")]
	[FieldOffset(Offset = "0x2B8")]
	[SerializeField]
	public int EquipSubAttribute_RareDrop_Param2;

	// Token: 0x04000D77 RID: 3447
	[Token(Token = "0x4000A5C")]
	[FieldOffset(Offset = "0x2BC")]
	[SerializeField]
	public float EquipSubAttribute_UpRecovery_Param1;

	// Token: 0x04000D78 RID: 3448
	[Token(Token = "0x4000A5D")]
	[FieldOffset(Offset = "0x2C0")]
	[SerializeField]
	public float EquipSubAttribute_UpRecovery_Param2;

	// Token: 0x04000D79 RID: 3449
	[Token(Token = "0x4000A5E")]
	[FieldOffset(Offset = "0x2C4")]
	[SerializeField]
	public float EquipSubAttribute_AccPoison;

	// Token: 0x04000D7A RID: 3450
	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x2C8")]
	[SerializeField]
	public float EquipSubAttribute_AccParalysis;

	// Token: 0x04000D7B RID: 3451
	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x2CC")]
	[SerializeField]
	public float EquipSubAttribute_AccSeal;

	// Token: 0x04000D7C RID: 3452
	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	public float EquipSubAttribute_DefMu;

	// Token: 0x04000D7D RID: 3453
	[Token(Token = "0x4000A62")]
	[FieldOffset(Offset = "0x2D4")]
	[SerializeField]
	public Pad.VibrationType Vibration_OnDamage;

	// Token: 0x04000D7E RID: 3454
	[Token(Token = "0x4000A63")]
	[FieldOffset(Offset = "0x2D8")]
	[SerializeField]
	public Pad.VibrationType Vibration_OnDamageBlow;

	// Token: 0x04000D7F RID: 3455
	[Token(Token = "0x4000A64")]
	[FieldOffset(Offset = "0x2DC")]
	[SerializeField]
	public Pad.VibrationType Vibration_OnCharged;

	// Token: 0x04000D80 RID: 3456
	[Token(Token = "0x4000A65")]
	[FieldOffset(Offset = "0x2E0")]
	[SerializeField]
	public Pad.VibrationType Vibration_OnHitCritical;

	// Token: 0x04000D81 RID: 3457
	[Token(Token = "0x4000A66")]
	[FieldOffset(Offset = "0x2E4")]
	[SerializeField]
	public Pad.VibrationType Vibration_OnHitRA;

	// Token: 0x04000D82 RID: 3458
	[Token(Token = "0x4000A67")]
	[FieldOffset(Offset = "0x2E8")]
	[SerializeField]
	public Pad.VibrationType Vibration_OnHitDualSkill;

	// Token: 0x04000D83 RID: 3459
	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x2EC")]
	[SerializeField]
	public float BaseChargeSec;

	// Token: 0x04000D84 RID: 3460
	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0x2F0")]
	[SerializeField]
	public float FarmCamera_Angle;

	// Token: 0x04000D85 RID: 3461
	[Token(Token = "0x4000A6A")]
	[FieldOffset(Offset = "0x2F4")]
	[SerializeField]
	public float FarmCamera_Distance;

	// Token: 0x04000D86 RID: 3462
	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x2F8")]
	[SerializeField]
	public float FarmCamera_FOV;

	// Token: 0x04000D87 RID: 3463
	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x2FC")]
	[SerializeField]
	public float FarmCamera_RestartTime;

	// Token: 0x04000D88 RID: 3464
	[Token(Token = "0x4000A6D")]
	[FieldOffset(Offset = "0x300")]
	[SerializeField]
	public float FarmCamera_StopTime;

	// Token: 0x04000D89 RID: 3465
	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x304")]
	[SerializeField]
	public float CharacterForward_DotValue;

	// Token: 0x04000D8A RID: 3466
	[Token(Token = "0x4000A6F")]
	[FieldOffset(Offset = "0x308")]
	[SerializeField]
	public float BackAttack_DamageRate;

	// Token: 0x04000D8B RID: 3467
	[Token(Token = "0x4000A70")]
	[FieldOffset(Offset = "0x30C")]
	[SerializeField]
	public float BackAttack_UpCritical;

	// Token: 0x04000D8C RID: 3468
	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x310")]
	[SerializeField]
	public float SurpriseAttack_Critical;

	// Token: 0x04000D8D RID: 3469
	[Token(Token = "0x4000A72")]
	[FieldOffset(Offset = "0x314")]
	[SerializeField]
	public int GateMonster_DecreaseApeearCount_Easy;

	// Token: 0x04000D8E RID: 3470
	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x318")]
	[SerializeField]
	public float ToolCharge_StartTime;

	// Token: 0x04000D8F RID: 3471
	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0x31C")]
	[SerializeField]
	public float AvoidCoolTime;

	// Token: 0x04000D90 RID: 3472
	[Token(Token = "0x4000A75")]
	[FieldOffset(Offset = "0x320")]
	[SerializeField]
	public int MaxLevel;

	// Token: 0x04000D91 RID: 3473
	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0x324")]
	[SerializeField]
	public int HPDrainMin;

	// Token: 0x04000D92 RID: 3474
	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0x328")]
	[SerializeField]
	public int HPDrainMax;

	// Token: 0x04000D93 RID: 3475
	[Token(Token = "0x4000A78")]
	[FieldOffset(Offset = "0x32C")]
	[SerializeField]
	public int DamageMin;

	// Token: 0x04000D94 RID: 3476
	[Token(Token = "0x4000A79")]
	[FieldOffset(Offset = "0x330")]
	[SerializeField]
	public int DamageMax;

	// Token: 0x04000D95 RID: 3477
	[Token(Token = "0x4000A7A")]
	[FieldOffset(Offset = "0x334")]
	[SerializeField]
	public int CriticalRateMax;

	// Token: 0x04000D96 RID: 3478
	[Token(Token = "0x4000A7B")]
	[FieldOffset(Offset = "0x338")]
	[SerializeField]
	public int Param_Max_HP;

	// Token: 0x04000D97 RID: 3479
	[Token(Token = "0x4000A7C")]
	[FieldOffset(Offset = "0x33C")]
	[SerializeField]
	public int Param_Max_RP;

	// Token: 0x04000D98 RID: 3480
	[Token(Token = "0x4000A7D")]
	[FieldOffset(Offset = "0x340")]
	[SerializeField]
	public int Param_Min;

	// Token: 0x04000D99 RID: 3481
	[Token(Token = "0x4000A7E")]
	[FieldOffset(Offset = "0x344")]
	[SerializeField]
	public int Param_Max;

	// Token: 0x04000D9A RID: 3482
	[Token(Token = "0x4000A7F")]
	[FieldOffset(Offset = "0x348")]
	[SerializeField]
	public float Param_Percent_Min;

	// Token: 0x04000D9B RID: 3483
	[Token(Token = "0x4000A80")]
	[FieldOffset(Offset = "0x34C")]
	[SerializeField]
	public float Param_Percent_Max;

	// Token: 0x04000D9C RID: 3484
	[Token(Token = "0x4000A81")]
	[FieldOffset(Offset = "0x350")]
	[SerializeField]
	public float Param_Attribute_Percent_Min;

	// Token: 0x04000D9D RID: 3485
	[Token(Token = "0x4000A82")]
	[FieldOffset(Offset = "0x354")]
	[SerializeField]
	public float Param_Attribute_Percent_Max;

	// Token: 0x04000D9E RID: 3486
	[Token(Token = "0x4000A83")]
	[FieldOffset(Offset = "0x358")]
	[SerializeField]
	public float Param_ChargeSpeed_Percent_Min;

	// Token: 0x04000D9F RID: 3487
	[Token(Token = "0x4000A84")]
	[FieldOffset(Offset = "0x35C")]
	[SerializeField]
	public float Param_ChargeSpeed_Percent_Max;

	// Token: 0x04000DA0 RID: 3488
	[Token(Token = "0x4000A85")]
	[FieldOffset(Offset = "0x360")]
	[SerializeField]
	public float Param_Percent_Over_Max;

	// Token: 0x04000DA1 RID: 3489
	[Token(Token = "0x4000A86")]
	[FieldOffset(Offset = "0x364")]
	[SerializeField]
	public int ZakoExp_Max;

	// Token: 0x04000DA2 RID: 3490
	[Token(Token = "0x4000A87")]
	[FieldOffset(Offset = "0x368")]
	[SerializeField]
	public int ZakoExp_Boss;

	// Token: 0x04000DA3 RID: 3491
	[Token(Token = "0x4000A88")]
	[FieldOffset(Offset = "0x36C")]
	[SerializeField]
	public int Exp_Max;

	// Token: 0x04000DA4 RID: 3492
	[Token(Token = "0x4000A89")]
	[FieldOffset(Offset = "0x370")]
	[SerializeField]
	public int Skill_Exp_Max;

	// Token: 0x04000DA5 RID: 3493
	[Token(Token = "0x4000A8A")]
	[FieldOffset(Offset = "0x374")]
	[SerializeField]
	public int MaxDefeatBonus;

	// Token: 0x04000DA6 RID: 3494
	[Token(Token = "0x4000A8B")]
	[FieldOffset(Offset = "0x378")]
	[SerializeField]
	public int MaxDefeatBonusALL;

	// Token: 0x04000DA7 RID: 3495
	[Token(Token = "0x4000A8C")]
	[FieldOffset(Offset = "0x37C")]
	[SerializeField]
	public int SkillLevel_AvoidAttack;

	// Token: 0x04000DA8 RID: 3496
	[Token(Token = "0x4000A8D")]
	[FieldOffset(Offset = "0x380")]
	[SerializeField]
	public int SkillLevel_ChargeAttack;

	// Token: 0x04000DA9 RID: 3497
	[Token(Token = "0x4000A8E")]
	[FieldOffset(Offset = "0x384")]
	[SerializeField]
	public int SkillLevel_SP;

	// Token: 0x04000DAA RID: 3498
	[Token(Token = "0x4000A8F")]
	[FieldOffset(Offset = "0x388")]
	[SerializeField]
	public int SkillLevel_Max_Party_Def;

	// Token: 0x04000DAB RID: 3499
	[Token(Token = "0x4000A90")]
	[FieldOffset(Offset = "0x38C")]
	[SerializeField]
	public float HealRate_Shinanasa;

	// Token: 0x04000DAC RID: 3500
	[Token(Token = "0x4000A91")]
	[FieldOffset(Offset = "0x0")]
	private static BattleConst _Instance;

	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2001059")]
	[Serializable]
	public class ShieldEffect
	{
		// Token: 0x06001642 RID: 5698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D78")]
		[Address(RVA = "0x2207C50", Offset = "0x2207D51", VA = "0x2207C50")]
		public ShieldEffect(float baseParam1, float attrDef1, float baseParam2, float attrDef2)
		{
		}

		// Token: 0x04000DAD RID: 3501
		[Token(Token = "0x4018F8E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public float BaseParam1;

		// Token: 0x04000DAE RID: 3502
		[Token(Token = "0x4018F8F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public float AttrDef1;

		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4018F90")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public float BaseParam2;

		// Token: 0x04000DB0 RID: 3504
		[Token(Token = "0x4018F91")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public float AttrDef2;
	}
}
