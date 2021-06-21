using System;
using Il2CppDummyDll;

namespace Define
{
	// Token: 0x020011EF RID: 4591
	[Token(Token = "0x2000BC3")]
	public enum EffectID
	{
		// Token: 0x0401865A RID: 99930
		[Token(Token = "0x40150C3")]
		EFFECT_EMPTY,
		// Token: 0x0401865B RID: 99931
		[Token(Token = "0x40150C4")]
		Effect_StepDirt = 100,
		// Token: 0x0401865C RID: 99932
		[Token(Token = "0x40150C5")]
		Effect_StepGrass,
		// Token: 0x0401865D RID: 99933
		[Token(Token = "0x40150C6")]
		Effect_StepWater,
		// Token: 0x0401865E RID: 99934
		[Token(Token = "0x40150C7")]
		Effect_StepIce,
		// Token: 0x0401865F RID: 99935
		[Token(Token = "0x40150C8")]
		Effect_StepMud,
		// Token: 0x04018660 RID: 99936
		[Token(Token = "0x40150C9")]
		Effect_StepSP,
		// Token: 0x04018661 RID: 99937
		[Token(Token = "0x40150CA")]
		Effect_SlideDirt,
		// Token: 0x04018662 RID: 99938
		[Token(Token = "0x40150CB")]
		Effect_SlideGrass,
		// Token: 0x04018663 RID: 99939
		[Token(Token = "0x40150CC")]
		Effect_SlideWater,
		// Token: 0x04018664 RID: 99940
		[Token(Token = "0x40150CD")]
		Effect_SlideIce,
		// Token: 0x04018665 RID: 99941
		[Token(Token = "0x40150CE")]
		Effect_SlideMud,
		// Token: 0x04018666 RID: 99942
		[Token(Token = "0x40150CF")]
		Effect_JumpDirt,
		// Token: 0x04018667 RID: 99943
		[Token(Token = "0x40150D0")]
		Effect_JumpGrass,
		// Token: 0x04018668 RID: 99944
		[Token(Token = "0x40150D1")]
		Effect_JumpWater,
		// Token: 0x04018669 RID: 99945
		[Token(Token = "0x40150D2")]
		Effect_JumpIce,
		// Token: 0x0401866A RID: 99946
		[Token(Token = "0x40150D3")]
		Effect_JumpMud,
		// Token: 0x0401866B RID: 99947
		[Token(Token = "0x40150D4")]
		Effect_Dash_2,
		// Token: 0x0401866C RID: 99948
		[Token(Token = "0x40150D5")]
		Effect_DashAura,
		// Token: 0x0401866D RID: 99949
		[Token(Token = "0x40150D6")]
		Effect_DashStep,
		// Token: 0x0401866E RID: 99950
		[Token(Token = "0x40150D7")]
		Effect_Dodge,
		// Token: 0x0401866F RID: 99951
		[Token(Token = "0x40150D8")]
		Effect_SuperArmor,
		// Token: 0x04018670 RID: 99952
		[Token(Token = "0x40150D9")]
		Effect_SwimStart = 200,
		// Token: 0x04018671 RID: 99953
		[Token(Token = "0x40150DA")]
		Effect_Swim,
		// Token: 0x04018672 RID: 99954
		[Token(Token = "0x40150DB")]
		Effect_SwimEnd,
		// Token: 0x04018673 RID: 99955
		[Token(Token = "0x40150DC")]
		Effect_StatusCold = 300,
		// Token: 0x04018674 RID: 99956
		[Token(Token = "0x40150DD")]
		Effect_StatusConfusion,
		// Token: 0x04018675 RID: 99957
		[Token(Token = "0x40150DE")]
		Effect_StatusStan,
		// Token: 0x04018676 RID: 99958
		[Token(Token = "0x40150DF")]
		Effect_StatusSealed,
		// Token: 0x04018677 RID: 99959
		[Token(Token = "0x40150E0")]
		Effect_StatusParalysis,
		// Token: 0x04018678 RID: 99960
		[Token(Token = "0x40150E1")]
		Effect_StatusPoison,
		// Token: 0x04018679 RID: 99961
		[Token(Token = "0x40150E2")]
		Effect_StatusSleep,
		// Token: 0x0401867A RID: 99962
		[Token(Token = "0x40150E3")]
		Effect_StatusTired,
		// Token: 0x0401867B RID: 99963
		[Token(Token = "0x40150E4")]
		Effect_BattleLevelup = 400,
		// Token: 0x0401867C RID: 99964
		[Token(Token = "0x40150E5")]
		Effect_BattlePinch,
		// Token: 0x0401867D RID: 99965
		[Token(Token = "0x40150E6")]
		Effect_BattleHandcuffs_Ready,
		// Token: 0x0401867E RID: 99966
		[Token(Token = "0x40150E7")]
		Effect_BattleHandcuffs_Throw,
		// Token: 0x0401867F RID: 99967
		[Token(Token = "0x40150E8")]
		Effect_BattleHandcuffs_Hit,
		// Token: 0x04018680 RID: 99968
		[Token(Token = "0x40150E9")]
		Effect_BattleHandcuffs_Miss,
		// Token: 0x04018681 RID: 99969
		[Token(Token = "0x40150EA")]
		Effect_BattleCharge01,
		// Token: 0x04018682 RID: 99970
		[Token(Token = "0x40150EB")]
		Effect_BattleCharge02,
		// Token: 0x04018683 RID: 99971
		[Token(Token = "0x40150EC")]
		Effect_BattleCharge03,
		// Token: 0x04018684 RID: 99972
		[Token(Token = "0x40150ED")]
		Effect_BattleDestroy,
		// Token: 0x04018685 RID: 99973
		[Token(Token = "0x40150EE")]
		Effect_Battle_SPSkillStart,
		// Token: 0x04018686 RID: 99974
		[Token(Token = "0x40150EF")]
		Effect_BattleSword_Slash,
		// Token: 0x04018687 RID: 99975
		[Token(Token = "0x40150F0")]
		Effect_BattleSword_SPSkill_1,
		// Token: 0x04018688 RID: 99976
		[Token(Token = "0x40150F1")]
		Effect_BattleSword_SPSkill_2,
		// Token: 0x04018689 RID: 99977
		[Token(Token = "0x40150F2")]
		Effect_BattleSword_SPSkill_3,
		// Token: 0x0401868A RID: 99978
		[Token(Token = "0x40150F3")]
		Effect_BattleSword_AvoidanceAttack,
		// Token: 0x0401868B RID: 99979
		[Token(Token = "0x40150F4")]
		Effect_BattleGreatSword_Slash,
		// Token: 0x0401868C RID: 99980
		[Token(Token = "0x40150F5")]
		Effect_BattleGreatSword_SPSkill_1,
		// Token: 0x0401868D RID: 99981
		[Token(Token = "0x40150F6")]
		Effect_BattleGreatSword_SPSkill_2,
		// Token: 0x0401868E RID: 99982
		[Token(Token = "0x40150F7")]
		Effect_BattleGreatSword_SPSkill_3,
		// Token: 0x0401868F RID: 99983
		[Token(Token = "0x40150F8")]
		Effect_BattleGreatSword_AvoidanceAttack,
		// Token: 0x04018690 RID: 99984
		[Token(Token = "0x40150F9")]
		Effect_BattleTwinSword_Slash,
		// Token: 0x04018691 RID: 99985
		[Token(Token = "0x40150FA")]
		Effect_BattleTwinSword_SPSkill_1,
		// Token: 0x04018692 RID: 99986
		[Token(Token = "0x40150FB")]
		Effect_BattleTwinSword_SPSkill_2,
		// Token: 0x04018693 RID: 99987
		[Token(Token = "0x40150FC")]
		Effect_BattleTwinSword_SPSkill_3,
		// Token: 0x04018694 RID: 99988
		[Token(Token = "0x40150FD")]
		Effect_BattleTwinSword_SPSkill_4,
		// Token: 0x04018695 RID: 99989
		[Token(Token = "0x40150FE")]
		Effect_BattleTwinSword_SPSkill_5,
		// Token: 0x04018696 RID: 99990
		[Token(Token = "0x40150FF")]
		Effect_BattleTwinSword_AvoidanceAttack,
		// Token: 0x04018697 RID: 99991
		[Token(Token = "0x4015100")]
		Effect_BattleSpear_Slash,
		// Token: 0x04018698 RID: 99992
		[Token(Token = "0x4015101")]
		Effect_BattleSpear_SPSkill_1,
		// Token: 0x04018699 RID: 99993
		[Token(Token = "0x4015102")]
		Effect_BattleSpear_SPSkill_2,
		// Token: 0x0401869A RID: 99994
		[Token(Token = "0x4015103")]
		Effect_BattleSpear_SPSkill_3,
		// Token: 0x0401869B RID: 99995
		[Token(Token = "0x4015104")]
		Effect_BattleSpear_AvoidanceAttack,
		// Token: 0x0401869C RID: 99996
		[Token(Token = "0x4015105")]
		Effect_BattleHammar_Slash,
		// Token: 0x0401869D RID: 99997
		[Token(Token = "0x4015106")]
		Effect_BattleHammar_SPSkill_1,
		// Token: 0x0401869E RID: 99998
		[Token(Token = "0x4015107")]
		Effect_BattleHammar_SPSkill_2,
		// Token: 0x0401869F RID: 99999
		[Token(Token = "0x4015108")]
		Effect_BattleHammar_AvoidanceAttack,
		// Token: 0x040186A0 RID: 100000
		[Token(Token = "0x4015109")]
		Effect_BattleFist_Slash,
		// Token: 0x040186A1 RID: 100001
		[Token(Token = "0x401510A")]
		Effect_BattleFist_SPSkill_1,
		// Token: 0x040186A2 RID: 100002
		[Token(Token = "0x401510B")]
		Effect_BattleFist_SPSkill_2,
		// Token: 0x040186A3 RID: 100003
		[Token(Token = "0x401510C")]
		Effect_BattleFist_AvoidanceAttack_1,
		// Token: 0x040186A4 RID: 100004
		[Token(Token = "0x401510D")]
		Effect_BattleFist_AvoidanceAttack_2,
		// Token: 0x040186A5 RID: 100005
		[Token(Token = "0x401510E")]
		Effect_BattleFist_AuraFire,
		// Token: 0x040186A6 RID: 100006
		[Token(Token = "0x401510F")]
		Effect_BattleFist_AuraWater,
		// Token: 0x040186A7 RID: 100007
		[Token(Token = "0x4015110")]
		Effect_BattleFist_AuraWind,
		// Token: 0x040186A8 RID: 100008
		[Token(Token = "0x4015111")]
		Effect_BattleFist_AuraEarth,
		// Token: 0x040186A9 RID: 100009
		[Token(Token = "0x4015112")]
		Effect_BattleFist_AuraShine,
		// Token: 0x040186AA RID: 100010
		[Token(Token = "0x4015113")]
		Effect_BattleFist_AuraDark,
		// Token: 0x040186AB RID: 100011
		[Token(Token = "0x4015114")]
		Effect_BattleWand_Slash,
		// Token: 0x040186AC RID: 100012
		[Token(Token = "0x4015115")]
		Effect_BattleWand_MagicNormal,
		// Token: 0x040186AD RID: 100013
		[Token(Token = "0x4015116")]
		Effect_BattleWand_MagicNormalStart,
		// Token: 0x040186AE RID: 100014
		[Token(Token = "0x4015117")]
		Effect_BattleWand_MagicNormalShot,
		// Token: 0x040186AF RID: 100015
		[Token(Token = "0x4015118")]
		Effect_BattleWand_MagicNormalEnd,
		// Token: 0x040186B0 RID: 100016
		[Token(Token = "0x4015119")]
		Effect_BattleWand_MagicNormalVanish,
		// Token: 0x040186B1 RID: 100017
		[Token(Token = "0x401511A")]
		Effect_BattleWand_MagicFire,
		// Token: 0x040186B2 RID: 100018
		[Token(Token = "0x401511B")]
		Effect_BattleWand_MagicFireStart,
		// Token: 0x040186B3 RID: 100019
		[Token(Token = "0x401511C")]
		Effect_BattleWand_MagicFireShot,
		// Token: 0x040186B4 RID: 100020
		[Token(Token = "0x401511D")]
		Effect_BattleWand_MagicFireEnd,
		// Token: 0x040186B5 RID: 100021
		[Token(Token = "0x401511E")]
		Effect_BattleWand_MagicFireVanish,
		// Token: 0x040186B6 RID: 100022
		[Token(Token = "0x401511F")]
		Effect_BattleWand_MagicWater,
		// Token: 0x040186B7 RID: 100023
		[Token(Token = "0x4015120")]
		Effect_BattleWand_MagicWaterStart,
		// Token: 0x040186B8 RID: 100024
		[Token(Token = "0x4015121")]
		Effect_BattleWand_MagicWaterShot,
		// Token: 0x040186B9 RID: 100025
		[Token(Token = "0x4015122")]
		Effect_BattleWand_MagicWaterEnd,
		// Token: 0x040186BA RID: 100026
		[Token(Token = "0x4015123")]
		Effect_BattleWand_MagicWaterVanish,
		// Token: 0x040186BB RID: 100027
		[Token(Token = "0x4015124")]
		Effect_BattleWand_MagicWind,
		// Token: 0x040186BC RID: 100028
		[Token(Token = "0x4015125")]
		Effect_BattleWand_MagicWindStart,
		// Token: 0x040186BD RID: 100029
		[Token(Token = "0x4015126")]
		Effect_BattleWand_MagicWindShot,
		// Token: 0x040186BE RID: 100030
		[Token(Token = "0x4015127")]
		Effect_BattleWand_MagicWindEnd,
		// Token: 0x040186BF RID: 100031
		[Token(Token = "0x4015128")]
		Effect_BattleWand_MagicWindVanish,
		// Token: 0x040186C0 RID: 100032
		[Token(Token = "0x4015129")]
		Effect_BattleWand_MagicEarth,
		// Token: 0x040186C1 RID: 100033
		[Token(Token = "0x401512A")]
		Effect_BattleWand_MagicEarthStart,
		// Token: 0x040186C2 RID: 100034
		[Token(Token = "0x401512B")]
		Effect_BattleWand_MagicEarthShot,
		// Token: 0x040186C3 RID: 100035
		[Token(Token = "0x401512C")]
		Effect_BattleWand_MagicEarthEnd,
		// Token: 0x040186C4 RID: 100036
		[Token(Token = "0x401512D")]
		Effect_BattleWand_MagicEarthVanish,
		// Token: 0x040186C5 RID: 100037
		[Token(Token = "0x401512E")]
		Effect_BattleWand_MagicShine,
		// Token: 0x040186C6 RID: 100038
		[Token(Token = "0x401512F")]
		Effect_BattleWand_MagicShineStart,
		// Token: 0x040186C7 RID: 100039
		[Token(Token = "0x4015130")]
		Effect_BattleWand_MagicShineShot,
		// Token: 0x040186C8 RID: 100040
		[Token(Token = "0x4015131")]
		Effect_BattleWand_MagicShineEnd,
		// Token: 0x040186C9 RID: 100041
		[Token(Token = "0x4015132")]
		Effect_BattleWand_MagicShineVanish,
		// Token: 0x040186CA RID: 100042
		[Token(Token = "0x4015133")]
		Effect_BattleWand_MagicDark,
		// Token: 0x040186CB RID: 100043
		[Token(Token = "0x4015134")]
		Effect_BattleWand_MagicDarkStart,
		// Token: 0x040186CC RID: 100044
		[Token(Token = "0x4015135")]
		Effect_BattleWand_MagicDarkShot,
		// Token: 0x040186CD RID: 100045
		[Token(Token = "0x4015136")]
		Effect_BattleWand_MagicDarkEnd,
		// Token: 0x040186CE RID: 100046
		[Token(Token = "0x4015137")]
		Effect_BattleWand_MagicDarkVanish,
		// Token: 0x040186CF RID: 100047
		[Token(Token = "0x4015138")]
		Effect_BattleWand_MagicLove,
		// Token: 0x040186D0 RID: 100048
		[Token(Token = "0x4015139")]
		Effect_BattleWand_MagicLoveStart,
		// Token: 0x040186D1 RID: 100049
		[Token(Token = "0x401513A")]
		Effect_BattleWand_MagicLoveShot,
		// Token: 0x040186D2 RID: 100050
		[Token(Token = "0x401513B")]
		Effect_BattleWand_MagicLoveEnd,
		// Token: 0x040186D3 RID: 100051
		[Token(Token = "0x401513C")]
		Effect_BattleWand_MagicLoveVanish,
		// Token: 0x040186D4 RID: 100052
		[Token(Token = "0x401513D")]
		Effect_BattleWand_Imo,
		// Token: 0x040186D5 RID: 100053
		[Token(Token = "0x401513E")]
		Effect_BattleWand_ImoStart,
		// Token: 0x040186D6 RID: 100054
		[Token(Token = "0x401513F")]
		Effect_BattleWand_ImoShot,
		// Token: 0x040186D7 RID: 100055
		[Token(Token = "0x4015140")]
		Effect_BattleWand_ImoEnd,
		// Token: 0x040186D8 RID: 100056
		[Token(Token = "0x4015141")]
		Effect_BattleWand_ImoVanish,
		// Token: 0x040186D9 RID: 100057
		[Token(Token = "0x4015142")]
		Effect_BattleCure,
		// Token: 0x040186DA RID: 100058
		[Token(Token = "0x4015143")]
		Effect_BattleMedical,
		// Token: 0x040186DB RID: 100059
		[Token(Token = "0x4015144")]
		Effect_BattleLevelupTelop,
		// Token: 0x040186DC RID: 100060
		[Token(Token = "0x4015145")]
		Effect_BattleSkillupTelop,
		// Token: 0x040186DD RID: 100061
		[Token(Token = "0x4015146")]
		Effect_BattleSpear_Charge,
		// Token: 0x040186DE RID: 100062
		[Token(Token = "0x4015147")]
		Effect_BattleGroundImpact1,
		// Token: 0x040186DF RID: 100063
		[Token(Token = "0x4015148")]
		Effect_BattleGroundImpact2,
		// Token: 0x040186E0 RID: 100064
		[Token(Token = "0x4015149")]
		Effect_BattleGroundSlash,
		// Token: 0x040186E1 RID: 100065
		[Token(Token = "0x401514A")]
		Effect_BattleSpear_Arrow,
		// Token: 0x040186E2 RID: 100066
		[Token(Token = "0x401514B")]
		Effect_BattleSpear_ShieldBash,
		// Token: 0x040186E3 RID: 100067
		[Token(Token = "0x401514C")]
		Effect_BattleTwinSword_Charge,
		// Token: 0x040186E4 RID: 100068
		[Token(Token = "0x401514D")]
		Effect_BattleHammar_Charge,
		// Token: 0x040186E5 RID: 100069
		[Token(Token = "0x401514E")]
		Effect_BattleMagic_WindCutter,
		// Token: 0x040186E6 RID: 100070
		[Token(Token = "0x401514F")]
		Effect_BattleMagic_DarkBall,
		// Token: 0x040186E7 RID: 100071
		[Token(Token = "0x4015150")]
		Effect_BattleMagic_ShineBall,
		// Token: 0x040186E8 RID: 100072
		[Token(Token = "0x4015151")]
		Effect_BattleExplosion,
		// Token: 0x040186E9 RID: 100073
		[Token(Token = "0x4015152")]
		Effect_BattleMagic_Darkness,
		// Token: 0x040186EA RID: 100074
		[Token(Token = "0x4015153")]
		Effect_BattleIceSpike,
		// Token: 0x040186EB RID: 100075
		[Token(Token = "0x4015154")]
		Effect_BattleSpear_Slash_1,
		// Token: 0x040186EC RID: 100076
		[Token(Token = "0x4015155")]
		Effect_BattleCharge04,
		// Token: 0x040186ED RID: 100077
		[Token(Token = "0x4015156")]
		Effect_RA_RoundBreak01 = 800,
		// Token: 0x040186EE RID: 100078
		[Token(Token = "0x4015157")]
		Effect_RA_RoundBreak02,
		// Token: 0x040186EF RID: 100079
		[Token(Token = "0x4015158")]
		Effect_RA_RoundBreak03,
		// Token: 0x040186F0 RID: 100080
		[Token(Token = "0x4015159")]
		Effect_RA_RoundBreak04,
		// Token: 0x040186F1 RID: 100081
		[Token(Token = "0x401515A")]
		Effect_RA_MindThrust01,
		// Token: 0x040186F2 RID: 100082
		[Token(Token = "0x401515B")]
		Effect_RA_MindThrust02,
		// Token: 0x040186F3 RID: 100083
		[Token(Token = "0x401515C")]
		Effect_RA_MindThrust03,
		// Token: 0x040186F4 RID: 100084
		[Token(Token = "0x401515D")]
		Effect_RA_PowerWave01,
		// Token: 0x040186F5 RID: 100085
		[Token(Token = "0x401515E")]
		Effect_RA_PowerWave02,
		// Token: 0x040186F6 RID: 100086
		[Token(Token = "0x401515F")]
		Effect_RA_PowerWave03,
		// Token: 0x040186F7 RID: 100087
		[Token(Token = "0x4015160")]
		Effect_RA_DashSlash01,
		// Token: 0x040186F8 RID: 100088
		[Token(Token = "0x4015161")]
		Effect_RA_DashSlash02,
		// Token: 0x040186F9 RID: 100089
		[Token(Token = "0x4015162")]
		Effect_RA_DashSlash03,
		// Token: 0x040186FA RID: 100090
		[Token(Token = "0x4015163")]
		Effect_RA_DashSlash04,
		// Token: 0x040186FB RID: 100091
		[Token(Token = "0x4015164")]
		Effect_RA_DashSlash05,
		// Token: 0x040186FC RID: 100092
		[Token(Token = "0x4015165")]
		Effect_RA_DashSlash06,
		// Token: 0x040186FD RID: 100093
		[Token(Token = "0x4015166")]
		Effect_RA_DashSlash07,
		// Token: 0x040186FE RID: 100094
		[Token(Token = "0x4015167")]
		Effect_RA_RushAttack01,
		// Token: 0x040186FF RID: 100095
		[Token(Token = "0x4015168")]
		Effect_RA_RushAttack02,
		// Token: 0x04018700 RID: 100096
		[Token(Token = "0x4015169")]
		Effect_RA_RushAttack03,
		// Token: 0x04018701 RID: 100097
		[Token(Token = "0x401516A")]
		Effect_RA_RushAttack04,
		// Token: 0x04018702 RID: 100098
		[Token(Token = "0x401516B")]
		Effect_RA_RushAttack05,
		// Token: 0x04018703 RID: 100099
		[Token(Token = "0x401516C")]
		Effect_RA_RushAttack06,
		// Token: 0x04018704 RID: 100100
		[Token(Token = "0x401516D")]
		Effect_RA_RushAttack07,
		// Token: 0x04018705 RID: 100101
		[Token(Token = "0x401516E")]
		Effect_RA_NagareSandan01 = 825,
		// Token: 0x04018706 RID: 100102
		[Token(Token = "0x401516F")]
		Effect_RA_NagareSandan02,
		// Token: 0x04018707 RID: 100103
		[Token(Token = "0x4015170")]
		Effect_RA_NagareSandan03,
		// Token: 0x04018708 RID: 100104
		[Token(Token = "0x4015171")]
		Effect_RA_NagareSandan04,
		// Token: 0x04018709 RID: 100105
		[Token(Token = "0x4015172")]
		Effect_RA_NagareSandan05,
		// Token: 0x0401870A RID: 100106
		[Token(Token = "0x4015173")]
		Effect_RA_Koushin01,
		// Token: 0x0401870B RID: 100107
		[Token(Token = "0x4015174")]
		Effect_RA_Koushin02,
		// Token: 0x0401870C RID: 100108
		[Token(Token = "0x4015175")]
		Effect_RA_Koushin03,
		// Token: 0x0401870D RID: 100109
		[Token(Token = "0x4015176")]
		Effect_RA_Mushinken01,
		// Token: 0x0401870E RID: 100110
		[Token(Token = "0x4015177")]
		Effect_RA_Mushinken02,
		// Token: 0x0401870F RID: 100111
		[Token(Token = "0x4015178")]
		Effect_RA_Mushinken03,
		// Token: 0x04018710 RID: 100112
		[Token(Token = "0x4015179")]
		Effect_RA_Mushinken04,
		// Token: 0x04018711 RID: 100113
		[Token(Token = "0x401517A")]
		Effect_RA_Mushinken05,
		// Token: 0x04018712 RID: 100114
		[Token(Token = "0x401517B")]
		Effect_RA_Isshinittou01,
		// Token: 0x04018713 RID: 100115
		[Token(Token = "0x401517C")]
		Effect_RA_Isshinittou02,
		// Token: 0x04018714 RID: 100116
		[Token(Token = "0x401517D")]
		Effect_RA_Isshinittou03,
		// Token: 0x04018715 RID: 100117
		[Token(Token = "0x401517E")]
		Effect_RA_Senpuken01,
		// Token: 0x04018716 RID: 100118
		[Token(Token = "0x401517F")]
		Effect_RA_Senpuken02,
		// Token: 0x04018717 RID: 100119
		[Token(Token = "0x4015180")]
		Effect_RA_Senpuken03,
		// Token: 0x04018718 RID: 100120
		[Token(Token = "0x4015181")]
		Effect_RA_SkyHurricane01 = 845,
		// Token: 0x04018719 RID: 100121
		[Token(Token = "0x4015182")]
		Effect_RA_SkyHurricane02,
		// Token: 0x0401871A RID: 100122
		[Token(Token = "0x4015183")]
		Effect_RA_SkyHurricane03,
		// Token: 0x0401871B RID: 100123
		[Token(Token = "0x4015184")]
		Effect_RA_SkyHurricane04,
		// Token: 0x0401871C RID: 100124
		[Token(Token = "0x4015185")]
		Effect_RA_StruggleReaper01,
		// Token: 0x0401871D RID: 100125
		[Token(Token = "0x4015186")]
		Effect_RA_StruggleReaper02,
		// Token: 0x0401871E RID: 100126
		[Token(Token = "0x4015187")]
		Effect_RA_MillionStrike01,
		// Token: 0x0401871F RID: 100127
		[Token(Token = "0x4015188")]
		Effect_RA_MillionStrike02,
		// Token: 0x04018720 RID: 100128
		[Token(Token = "0x4015189")]
		Effect_RA_AxelDisaster01,
		// Token: 0x04018721 RID: 100129
		[Token(Token = "0x401518A")]
		Effect_RA_AxelDisaster02,
		// Token: 0x04018722 RID: 100130
		[Token(Token = "0x401518B")]
		Effect_RA_AxelDisaster03,
		// Token: 0x04018723 RID: 100131
		[Token(Token = "0x401518C")]
		Effect_RA_GigaSwing01 = 858,
		// Token: 0x04018724 RID: 100132
		[Token(Token = "0x401518D")]
		Effect_RA_GigaSwing02,
		// Token: 0x04018725 RID: 100133
		[Token(Token = "0x401518E")]
		Effect_RA_StarDustUpper01,
		// Token: 0x04018726 RID: 100134
		[Token(Token = "0x401518F")]
		Effect_RA_StarDustUpper02,
		// Token: 0x04018727 RID: 100135
		[Token(Token = "0x4015190")]
		Effect_RA_StarDustUpper03,
		// Token: 0x04018728 RID: 100136
		[Token(Token = "0x4015191")]
		Effect_RA_StarDustUpper04,
		// Token: 0x04018729 RID: 100137
		[Token(Token = "0x4015192")]
		Effect_RA_TornadoSwing01,
		// Token: 0x0401872A RID: 100138
		[Token(Token = "0x4015193")]
		Effect_RA_TornadoSwing02,
		// Token: 0x0401872B RID: 100139
		[Token(Token = "0x4015194")]
		Effect_RA_TornadoSwing03,
		// Token: 0x0401872C RID: 100140
		[Token(Token = "0x4015195")]
		Effect_RA_TornadoSwing04,
		// Token: 0x0401872D RID: 100141
		[Token(Token = "0x4015196")]
		Effect_RA_GrandImpact01,
		// Token: 0x0401872E RID: 100142
		[Token(Token = "0x4015197")]
		Effect_RA_GrandImpact02,
		// Token: 0x0401872F RID: 100143
		[Token(Token = "0x4015198")]
		Effect_RA_GrandImpact03,
		// Token: 0x04018730 RID: 100144
		[Token(Token = "0x4015199")]
		Effect_RA_Shunjin01 = 873,
		// Token: 0x04018731 RID: 100145
		[Token(Token = "0x401519A")]
		Effect_RA_Shunjin02,
		// Token: 0x04018732 RID: 100146
		[Token(Token = "0x401519B")]
		Effect_RA_Shunjin03,
		// Token: 0x04018733 RID: 100147
		[Token(Token = "0x401519C")]
		Effect_RA_Rasen01,
		// Token: 0x04018734 RID: 100148
		[Token(Token = "0x401519D")]
		Effect_RA_Rasen02,
		// Token: 0x04018735 RID: 100149
		[Token(Token = "0x401519E")]
		Effect_RA_Rasen03,
		// Token: 0x04018736 RID: 100150
		[Token(Token = "0x401519F")]
		Effect_RA_Rekku01,
		// Token: 0x04018737 RID: 100151
		[Token(Token = "0x40151A0")]
		Effect_RA_Rekku02,
		// Token: 0x04018738 RID: 100152
		[Token(Token = "0x40151A1")]
		Effect_RA_Rekku03,
		// Token: 0x04018739 RID: 100153
		[Token(Token = "0x40151A2")]
		Effect_RA_Unretsu01,
		// Token: 0x0401873A RID: 100154
		[Token(Token = "0x40151A3")]
		Effect_RA_Unretsu02,
		// Token: 0x0401873B RID: 100155
		[Token(Token = "0x40151A4")]
		Effect_RA_Unretsu03,
		// Token: 0x0401873C RID: 100156
		[Token(Token = "0x40151A5")]
		Effect_RA_Unretsu04,
		// Token: 0x0401873D RID: 100157
		[Token(Token = "0x40151A6")]
		Effect_RA_Unretsu05,
		// Token: 0x0401873E RID: 100158
		[Token(Token = "0x40151A7")]
		Effect_RA_Soutotsu01,
		// Token: 0x0401873F RID: 100159
		[Token(Token = "0x40151A8")]
		Effect_RA_Soutotsu02,
		// Token: 0x04018740 RID: 100160
		[Token(Token = "0x40151A9")]
		Effect_RA_Soutotsu03,
		// Token: 0x04018741 RID: 100161
		[Token(Token = "0x40151AA")]
		Effect_RA_UpperCut01 = 891,
		// Token: 0x04018742 RID: 100162
		[Token(Token = "0x40151AB")]
		Effect_RA_UpperCut02,
		// Token: 0x04018743 RID: 100163
		[Token(Token = "0x40151AC")]
		Effect_RA_UpperCut03,
		// Token: 0x04018744 RID: 100164
		[Token(Token = "0x40151AD")]
		Effect_RA_DoubleKick01,
		// Token: 0x04018745 RID: 100165
		[Token(Token = "0x40151AE")]
		Effect_RA_DoubleKick02,
		// Token: 0x04018746 RID: 100166
		[Token(Token = "0x40151AF")]
		Effect_RA_DoubleKick03,
		// Token: 0x04018747 RID: 100167
		[Token(Token = "0x40151B0")]
		Effect_RA_Nekodamashi01,
		// Token: 0x04018748 RID: 100168
		[Token(Token = "0x40151B1")]
		Effect_RA_Shukuchiho01,
		// Token: 0x04018749 RID: 100169
		[Token(Token = "0x40151B2")]
		Effect_RA_Shukuchiho02,
		// Token: 0x0401874A RID: 100170
		[Token(Token = "0x40151B3")]
		Effect_RA_Shukuchiho03,
		// Token: 0x0401874B RID: 100171
		[Token(Token = "0x40151B4")]
		Effect_RA_Shukuchiho04,
		// Token: 0x0401874C RID: 100172
		[Token(Token = "0x40151B5")]
		Effect_RA_Seikenduki01,
		// Token: 0x0401874D RID: 100173
		[Token(Token = "0x40151B6")]
		Effect_RA_Seikenduki02,
		// Token: 0x0401874E RID: 100174
		[Token(Token = "0x40151B7")]
		Effect_RA_Seikenduki03,
		// Token: 0x0401874F RID: 100175
		[Token(Token = "0x40151B8")]
		Effect_RA_Hyakuretsuken01,
		// Token: 0x04018750 RID: 100176
		[Token(Token = "0x40151B9")]
		Effect_RA_Hyakuretsuken02,
		// Token: 0x04018751 RID: 100177
		[Token(Token = "0x40151BA")]
		Effect_RA_Cyclone01,
		// Token: 0x04018752 RID: 100178
		[Token(Token = "0x40151BB")]
		Effect_RA_Cyclone02,
		// Token: 0x04018753 RID: 100179
		[Token(Token = "0x40151BC")]
		Effect_RA_CommonDust01 = 910,
		// Token: 0x04018754 RID: 100180
		[Token(Token = "0x40151BD")]
		Effect_RA_CommonDust02,
		// Token: 0x04018755 RID: 100181
		[Token(Token = "0x40151BE")]
		Effect_RA_CommonDust03,
		// Token: 0x04018756 RID: 100182
		[Token(Token = "0x40151BF")]
		Effect_RA_CommonDust04,
		// Token: 0x04018757 RID: 100183
		[Token(Token = "0x40151C0")]
		Effect_RA_CommonDust05,
		// Token: 0x04018758 RID: 100184
		[Token(Token = "0x40151C1")]
		Effect_RA_CommonBuffer01,
		// Token: 0x04018759 RID: 100185
		[Token(Token = "0x40151C2")]
		Effect_BattleRockSpike,
		// Token: 0x0401875A RID: 100186
		[Token(Token = "0x40151C3")]
		Effect_BattleGroundDig,
		// Token: 0x0401875B RID: 100187
		[Token(Token = "0x40151C4")]
		Effect_BattleGroundSpike,
		// Token: 0x0401875C RID: 100188
		[Token(Token = "0x40151C5")]
		Effect_PowerWave_HIT,
		// Token: 0x0401875D RID: 100189
		[Token(Token = "0x40151C6")]
		Effect_GroundImpact_water,
		// Token: 0x0401875E RID: 100190
		[Token(Token = "0x40151C7")]
		Effect_ProteThunder,
		// Token: 0x0401875F RID: 100191
		[Token(Token = "0x40151C8")]
		Effect_FireCannon_Shot,
		// Token: 0x04018760 RID: 100192
		[Token(Token = "0x40151C9")]
		Effect_FireCannon_HIT,
		// Token: 0x04018761 RID: 100193
		[Token(Token = "0x40151CA")]
		Effect_BattleWand_Algernon,
		// Token: 0x04018762 RID: 100194
		[Token(Token = "0x40151CB")]
		Effect_BattleWand_AlgernonEnd,
		// Token: 0x04018763 RID: 100195
		[Token(Token = "0x40151CC")]
		Effect_BattleWand_AlgernonShot,
		// Token: 0x04018764 RID: 100196
		[Token(Token = "0x40151CD")]
		Effect_BattleWand_AlgernonStart,
		// Token: 0x04018765 RID: 100197
		[Token(Token = "0x40151CE")]
		Effect_BattleWand_AlgernonVanish,
		// Token: 0x04018766 RID: 100198
		[Token(Token = "0x40151CF")]
		Effect_BattleSpear_Slash_2,
		// Token: 0x04018767 RID: 100199
		[Token(Token = "0x40151D0")]
		Effect_RA_Cure,
		// Token: 0x04018768 RID: 100200
		[Token(Token = "0x40151D1")]
		Effect_RA_CommonBuffer02,
		// Token: 0x04018769 RID: 100201
		[Token(Token = "0x40151D2")]
		Effect_MonsterGate_Nomal = 1500,
		// Token: 0x0401876A RID: 100202
		[Token(Token = "0x40151D3")]
		Effect_MonsterGate_NomalDisappear,
		// Token: 0x0401876B RID: 100203
		[Token(Token = "0x40151D4")]
		Effect_MonsterGate_Fire,
		// Token: 0x0401876C RID: 100204
		[Token(Token = "0x40151D5")]
		Effect_MonsterGate_FireDisappear,
		// Token: 0x0401876D RID: 100205
		[Token(Token = "0x40151D6")]
		Effect_MonsterGate_Water,
		// Token: 0x0401876E RID: 100206
		[Token(Token = "0x40151D7")]
		Effect_MonsterGate_WaterDisappear,
		// Token: 0x0401876F RID: 100207
		[Token(Token = "0x40151D8")]
		Effect_MonsterGate_Wind,
		// Token: 0x04018770 RID: 100208
		[Token(Token = "0x40151D9")]
		Effect_MonsterGate_WindDisappear,
		// Token: 0x04018771 RID: 100209
		[Token(Token = "0x40151DA")]
		Effect_MonsterGate_Earth,
		// Token: 0x04018772 RID: 100210
		[Token(Token = "0x40151DB")]
		Effect_MonsterGate_EarthDisappear,
		// Token: 0x04018773 RID: 100211
		[Token(Token = "0x40151DC")]
		Effect_MonsterGate_Shine,
		// Token: 0x04018774 RID: 100212
		[Token(Token = "0x40151DD")]
		Effect_MonsterGate_ShineDisappear,
		// Token: 0x04018775 RID: 100213
		[Token(Token = "0x40151DE")]
		Effect_MonsterGate_Dark,
		// Token: 0x04018776 RID: 100214
		[Token(Token = "0x40151DF")]
		Effect_MonsterGate_DarkDisappear,
		// Token: 0x04018777 RID: 100215
		[Token(Token = "0x40151E0")]
		Effect_MonsterGate_Love,
		// Token: 0x04018778 RID: 100216
		[Token(Token = "0x40151E1")]
		Effect_MonsterGate_LoveDisappear,
		// Token: 0x04018779 RID: 100217
		[Token(Token = "0x40151E2")]
		Effect_MonsterGate_Summoned,
		// Token: 0x0401877A RID: 100218
		[Token(Token = "0x40151E3")]
		Effect_MonsterGate_Damage,
		// Token: 0x0401877B RID: 100219
		[Token(Token = "0x40151E4")]
		Effect_Monster_MagicNormal,
		// Token: 0x0401877C RID: 100220
		[Token(Token = "0x40151E5")]
		Effect_Monster_MagicNormalStart,
		// Token: 0x0401877D RID: 100221
		[Token(Token = "0x40151E6")]
		Effect_Monster_MagicNormalShot,
		// Token: 0x0401877E RID: 100222
		[Token(Token = "0x40151E7")]
		Effect_Monster_MagicNormalEnd,
		// Token: 0x0401877F RID: 100223
		[Token(Token = "0x40151E8")]
		Effect_Monster_MagicNormalVanish,
		// Token: 0x04018780 RID: 100224
		[Token(Token = "0x40151E9")]
		Effect_Monster_MagicFire,
		// Token: 0x04018781 RID: 100225
		[Token(Token = "0x40151EA")]
		Effect_Monster_MagicFireStart,
		// Token: 0x04018782 RID: 100226
		[Token(Token = "0x40151EB")]
		Effect_Monster_MagicFireShot,
		// Token: 0x04018783 RID: 100227
		[Token(Token = "0x40151EC")]
		Effect_Monster_MagicFireEnd,
		// Token: 0x04018784 RID: 100228
		[Token(Token = "0x40151ED")]
		Effect_Monster_MagicFireVanish,
		// Token: 0x04018785 RID: 100229
		[Token(Token = "0x40151EE")]
		Effect_Monster_MagicWater,
		// Token: 0x04018786 RID: 100230
		[Token(Token = "0x40151EF")]
		Effect_Monster_MagicWaterStart,
		// Token: 0x04018787 RID: 100231
		[Token(Token = "0x40151F0")]
		Effect_Monster_MagicWaterShot,
		// Token: 0x04018788 RID: 100232
		[Token(Token = "0x40151F1")]
		Effect_Monster_MagicWaterEnd,
		// Token: 0x04018789 RID: 100233
		[Token(Token = "0x40151F2")]
		Effect_Monster_MagicWaterVanish,
		// Token: 0x0401878A RID: 100234
		[Token(Token = "0x40151F3")]
		Effect_Monster_MagicWind,
		// Token: 0x0401878B RID: 100235
		[Token(Token = "0x40151F4")]
		Effect_Monster_MagicWindStart,
		// Token: 0x0401878C RID: 100236
		[Token(Token = "0x40151F5")]
		Effect_Monster_MagicWindShot,
		// Token: 0x0401878D RID: 100237
		[Token(Token = "0x40151F6")]
		Effect_Monster_MagicWindEnd,
		// Token: 0x0401878E RID: 100238
		[Token(Token = "0x40151F7")]
		Effect_Monster_MagicWindVanish,
		// Token: 0x0401878F RID: 100239
		[Token(Token = "0x40151F8")]
		Effect_Monster_MagicEarth,
		// Token: 0x04018790 RID: 100240
		[Token(Token = "0x40151F9")]
		Effect_Monster_MagicEarthStart,
		// Token: 0x04018791 RID: 100241
		[Token(Token = "0x40151FA")]
		Effect_Monster_MagicEarthShot,
		// Token: 0x04018792 RID: 100242
		[Token(Token = "0x40151FB")]
		Effect_Monster_MagicEarthEnd,
		// Token: 0x04018793 RID: 100243
		[Token(Token = "0x40151FC")]
		Effect_Monster_MagicEarthVanish,
		// Token: 0x04018794 RID: 100244
		[Token(Token = "0x40151FD")]
		Effect_Monster_MagicShine,
		// Token: 0x04018795 RID: 100245
		[Token(Token = "0x40151FE")]
		Effect_Monster_MagicShineStart,
		// Token: 0x04018796 RID: 100246
		[Token(Token = "0x40151FF")]
		Effect_Monster_MagicShineShot,
		// Token: 0x04018797 RID: 100247
		[Token(Token = "0x4015200")]
		Effect_Monster_MagicShineEnd,
		// Token: 0x04018798 RID: 100248
		[Token(Token = "0x4015201")]
		Effect_Monster_MagicShineVanish,
		// Token: 0x04018799 RID: 100249
		[Token(Token = "0x4015202")]
		Effect_Monster_MagicDark,
		// Token: 0x0401879A RID: 100250
		[Token(Token = "0x4015203")]
		Effect_Monster_MagicDarkStart,
		// Token: 0x0401879B RID: 100251
		[Token(Token = "0x4015204")]
		Effect_Monster_MagicDarkShot,
		// Token: 0x0401879C RID: 100252
		[Token(Token = "0x4015205")]
		Effect_Monster_MagicDarkEnd,
		// Token: 0x0401879D RID: 100253
		[Token(Token = "0x4015206")]
		Effect_Monster_MagicDarkVanish,
		// Token: 0x0401879E RID: 100254
		[Token(Token = "0x4015207")]
		Effect_Monster_MagicLove,
		// Token: 0x0401879F RID: 100255
		[Token(Token = "0x4015208")]
		Effect_Monster_MagicLoveStart,
		// Token: 0x040187A0 RID: 100256
		[Token(Token = "0x4015209")]
		Effect_Monster_MagicLoveShot,
		// Token: 0x040187A1 RID: 100257
		[Token(Token = "0x401520A")]
		Effect_Monster_MagicLoveEnd,
		// Token: 0x040187A2 RID: 100258
		[Token(Token = "0x401520B")]
		Effect_Monster_MagicLoveVanish,
		// Token: 0x040187A3 RID: 100259
		[Token(Token = "0x401520C")]
		Effect_MonsterAttackrange,
		// Token: 0x040187A4 RID: 100260
		[Token(Token = "0x401520D")]
		Effect_MonsterDisappear,
		// Token: 0x040187A5 RID: 100261
		[Token(Token = "0x401520E")]
		Effect_MonsterMadAura_S,
		// Token: 0x040187A6 RID: 100262
		[Token(Token = "0x401520F")]
		Effect_MonsterMadAura_M,
		// Token: 0x040187A7 RID: 100263
		[Token(Token = "0x4015210")]
		Effect_MonsterMadAura_L,
		// Token: 0x040187A8 RID: 100264
		[Token(Token = "0x4015211")]
		Effect_Monster_ShockWave01Normal,
		// Token: 0x040187A9 RID: 100265
		[Token(Token = "0x4015212")]
		Effect_Monster_ShockWave02Normal,
		// Token: 0x040187AA RID: 100266
		[Token(Token = "0x4015213")]
		Effect_Monster_ShockWave03Normal,
		// Token: 0x040187AB RID: 100267
		[Token(Token = "0x4015214")]
		Effect_Monster_ShockWave04Normal,
		// Token: 0x040187AC RID: 100268
		[Token(Token = "0x4015215")]
		Effect_Monster_ShockWave05Normal,
		// Token: 0x040187AD RID: 100269
		[Token(Token = "0x4015216")]
		Effect_Monster_ShockWave06Normal,
		// Token: 0x040187AE RID: 100270
		[Token(Token = "0x4015217")]
		Effect_Monster_Dust01,
		// Token: 0x040187AF RID: 100271
		[Token(Token = "0x4015218")]
		Effect_Monster_Dust02,
		// Token: 0x040187B0 RID: 100272
		[Token(Token = "0x4015219")]
		Effect_Monster_Dust03,
		// Token: 0x040187B1 RID: 100273
		[Token(Token = "0x401521A")]
		Effect_Monster_Speed01Normal,
		// Token: 0x040187B2 RID: 100274
		[Token(Token = "0x401521B")]
		Effect_Monster_Speed02Normal,
		// Token: 0x040187B3 RID: 100275
		[Token(Token = "0x401521C")]
		Effect_Monster_Slash01Normal,
		// Token: 0x040187B4 RID: 100276
		[Token(Token = "0x401521D")]
		Effect_Monster_Slash02Normal,
		// Token: 0x040187B5 RID: 100277
		[Token(Token = "0x401521E")]
		Effect_Monster_Slash04Normal,
		// Token: 0x040187B6 RID: 100278
		[Token(Token = "0x401521F")]
		Effect_Monster_Mass01Normal,
		// Token: 0x040187B7 RID: 100279
		[Token(Token = "0x4015220")]
		Effect_Monster_Mass01NormalStart,
		// Token: 0x040187B8 RID: 100280
		[Token(Token = "0x4015221")]
		Effect_Monster_Mass01NormalShot,
		// Token: 0x040187B9 RID: 100281
		[Token(Token = "0x4015222")]
		Effect_Monster_Mass01NormalEnd,
		// Token: 0x040187BA RID: 100282
		[Token(Token = "0x4015223")]
		Effect_Monster_Mass01NormalVanish,
		// Token: 0x040187BB RID: 100283
		[Token(Token = "0x4015224")]
		Effect_Monster_Mass01Fire,
		// Token: 0x040187BC RID: 100284
		[Token(Token = "0x4015225")]
		Effect_Monster_Mass01FireStart,
		// Token: 0x040187BD RID: 100285
		[Token(Token = "0x4015226")]
		Effect_Monster_Mass01FireShot,
		// Token: 0x040187BE RID: 100286
		[Token(Token = "0x4015227")]
		Effect_Monster_Mass01FireEnd,
		// Token: 0x040187BF RID: 100287
		[Token(Token = "0x4015228")]
		Effect_Monster_Mass01FireVanish,
		// Token: 0x040187C0 RID: 100288
		[Token(Token = "0x4015229")]
		Effect_Monster_Mass01Ice,
		// Token: 0x040187C1 RID: 100289
		[Token(Token = "0x401522A")]
		Effect_Monster_Mass01IceStart,
		// Token: 0x040187C2 RID: 100290
		[Token(Token = "0x401522B")]
		Effect_Monster_Mass01IceShot,
		// Token: 0x040187C3 RID: 100291
		[Token(Token = "0x401522C")]
		Effect_Monster_Mass01IceEnd,
		// Token: 0x040187C4 RID: 100292
		[Token(Token = "0x401522D")]
		Effect_Monster_Mass01IceVanish,
		// Token: 0x040187C5 RID: 100293
		[Token(Token = "0x401522E")]
		Effect_Monster_Mass01Dark,
		// Token: 0x040187C6 RID: 100294
		[Token(Token = "0x401522F")]
		Effect_Monster_Mass01DarkStart,
		// Token: 0x040187C7 RID: 100295
		[Token(Token = "0x4015230")]
		Effect_Monster_Mass01DarkShot,
		// Token: 0x040187C8 RID: 100296
		[Token(Token = "0x4015231")]
		Effect_Monster_Mass01DarkEnd,
		// Token: 0x040187C9 RID: 100297
		[Token(Token = "0x4015232")]
		Effect_Monster_Mass01DarkVanish,
		// Token: 0x040187CA RID: 100298
		[Token(Token = "0x4015233")]
		Effect_Monster_DashStart,
		// Token: 0x040187CB RID: 100299
		[Token(Token = "0x4015234")]
		Effect_Monster_Keron01,
		// Token: 0x040187CC RID: 100300
		[Token(Token = "0x4015235")]
		Effect_Monster_BigMash01,
		// Token: 0x040187CD RID: 100301
		[Token(Token = "0x4015236")]
		Effect_Monster_Hornet01,
		// Token: 0x040187CE RID: 100302
		[Token(Token = "0x4015237")]
		Effect_Monster_Hornet01needle,
		// Token: 0x040187CF RID: 100303
		[Token(Token = "0x4015238")]
		Effect_Monster_Aura01Fire,
		// Token: 0x040187D0 RID: 100304
		[Token(Token = "0x4015239")]
		Effect_Monster_Flower01,
		// Token: 0x040187D1 RID: 100305
		[Token(Token = "0x401523A")]
		Effect_Monster_Goblin_Ork01,
		// Token: 0x040187D2 RID: 100306
		[Token(Token = "0x401523B")]
		Effect_Monster_Groundcrack01,
		// Token: 0x040187D3 RID: 100307
		[Token(Token = "0x401523C")]
		Effect_Monster_Scratch01,
		// Token: 0x040187D4 RID: 100308
		[Token(Token = "0x401523D")]
		Effect_Monster_Chirori01,
		// Token: 0x040187D5 RID: 100309
		[Token(Token = "0x401523E")]
		Effect_Monster_Impact01,
		// Token: 0x040187D6 RID: 100310
		[Token(Token = "0x401523F")]
		Effect_Monster_Impact02,
		// Token: 0x040187D7 RID: 100311
		[Token(Token = "0x4015240")]
		Effect_Monster_Spider01Ahead,
		// Token: 0x040187D8 RID: 100312
		[Token(Token = "0x4015241")]
		Effect_Monster_Spider01Ground,
		// Token: 0x040187D9 RID: 100313
		[Token(Token = "0x4015242")]
		Effect_Monster_Laserstart01Normal,
		// Token: 0x040187DA RID: 100314
		[Token(Token = "0x4015243")]
		Effect_Monster_Lasermain01Normal,
		// Token: 0x040187DB RID: 100315
		[Token(Token = "0x4015244")]
		Effect_Monster_Laserlast01Normal,
		// Token: 0x040187DC RID: 100316
		[Token(Token = "0x4015245")]
		Effect_Monster_Laserstart01Water,
		// Token: 0x040187DD RID: 100317
		[Token(Token = "0x4015246")]
		Effect_Monster_Lasermain01Water,
		// Token: 0x040187DE RID: 100318
		[Token(Token = "0x4015247")]
		Effect_Monster_Laserlast01Water,
		// Token: 0x040187DF RID: 100319
		[Token(Token = "0x4015248")]
		Effect_Monster_Spark01,
		// Token: 0x040187E0 RID: 100320
		[Token(Token = "0x4015249")]
		Effect_Monster_Salene01,
		// Token: 0x040187E1 RID: 100321
		[Token(Token = "0x401524A")]
		Effect_Monster_Magiccircle01Normal,
		// Token: 0x040187E2 RID: 100322
		[Token(Token = "0x401524B")]
		Effect_Monster_Buff01,
		// Token: 0x040187E3 RID: 100323
		[Token(Token = "0x401524C")]
		Effect_Monster_Steam01,
		// Token: 0x040187E4 RID: 100324
		[Token(Token = "0x401524D")]
		Effect_Monster_Absorb01 = 1629,
		// Token: 0x040187E5 RID: 100325
		[Token(Token = "0x401524E")]
		Effect_Monster_Absorb02,
		// Token: 0x040187E6 RID: 100326
		[Token(Token = "0x401524F")]
		Effect_Monster_Absorb03,
		// Token: 0x040187E7 RID: 100327
		[Token(Token = "0x4015250")]
		Effect_Monster_Shock01Normal,
		// Token: 0x040187E8 RID: 100328
		[Token(Token = "0x4015251")]
		Effect_Monster_Slash03Normal,
		// Token: 0x040187E9 RID: 100329
		[Token(Token = "0x4015252")]
		Effect_Monster_Stab01Normal,
		// Token: 0x040187EA RID: 100330
		[Token(Token = "0x4015253")]
		Effect_Monster_SlashWave01Normal,
		// Token: 0x040187EB RID: 100331
		[Token(Token = "0x4015254")]
		Effect_Monster_SlashWave02Normal,
		// Token: 0x040187EC RID: 100332
		[Token(Token = "0x4015255")]
		Effect_Monster_SlashWaveHit01Normal,
		// Token: 0x040187ED RID: 100333
		[Token(Token = "0x4015256")]
		Effect_Monster_SlashWaveHit02Normal,
		// Token: 0x040187EE RID: 100334
		[Token(Token = "0x4015257")]
		Effect_Monster_CommonShot01,
		// Token: 0x040187EF RID: 100335
		[Token(Token = "0x4015258")]
		Effect_DS_CommonDust01,
		// Token: 0x040187F0 RID: 100336
		[Token(Token = "0x4015259")]
		Effect_Monster_Dust02_1,
		// Token: 0x040187F1 RID: 100337
		[Token(Token = "0x401525A")]
		Effect_Monster_Dust02_2,
		// Token: 0x040187F2 RID: 100338
		[Token(Token = "0x401525B")]
		Effect_Monster_Dust02_3,
		// Token: 0x040187F3 RID: 100339
		[Token(Token = "0x401525C")]
		Effect_Monster_Dust02_4,
		// Token: 0x040187F4 RID: 100340
		[Token(Token = "0x401525D")]
		Effect_Monster_Dust02_5,
		// Token: 0x040187F5 RID: 100341
		[Token(Token = "0x401525E")]
		Effect_Monster_Dust02_6,
		// Token: 0x040187F6 RID: 100342
		[Token(Token = "0x401525F")]
		Effect_Monster_Dust02_7,
		// Token: 0x040187F7 RID: 100343
		[Token(Token = "0x4015260")]
		Effect_Monster_Dust02_8,
		// Token: 0x040187F8 RID: 100344
		[Token(Token = "0x4015261")]
		Effect_Monster_Dust02_9,
		// Token: 0x040187F9 RID: 100345
		[Token(Token = "0x4015262")]
		Effect_Monster_Dust02_10,
		// Token: 0x040187FA RID: 100346
		[Token(Token = "0x4015263")]
		Effect_Monster_Dust02_11,
		// Token: 0x040187FB RID: 100347
		[Token(Token = "0x4015264")]
		Effect_BattleMissTelop,
		// Token: 0x040187FC RID: 100348
		[Token(Token = "0x4015265")]
		Effect_BattleSuccessTelop,
		// Token: 0x040187FD RID: 100349
		[Token(Token = "0x4015266")]
		Effect_Monster_Laserstart01Normal_1,
		// Token: 0x040187FE RID: 100350
		[Token(Token = "0x4015267")]
		Effect_Monster_Lasermain01Normal_1,
		// Token: 0x040187FF RID: 100351
		[Token(Token = "0x4015268")]
		Effect_Monster_Laserlast01Normal_1,
		// Token: 0x04018800 RID: 100352
		[Token(Token = "0x4015269")]
		Effect_Monster_Laserstart01Normal_2,
		// Token: 0x04018801 RID: 100353
		[Token(Token = "0x401526A")]
		Effect_Monster_Lasermain01Normal_2,
		// Token: 0x04018802 RID: 100354
		[Token(Token = "0x401526B")]
		Effect_Monster_Laserlast01Normal_2,
		// Token: 0x04018803 RID: 100355
		[Token(Token = "0x401526C")]
		Effect_Monster_Laserstart01Normal_3,
		// Token: 0x04018804 RID: 100356
		[Token(Token = "0x401526D")]
		Effect_Monster_Lasermain01Normal_3,
		// Token: 0x04018805 RID: 100357
		[Token(Token = "0x401526E")]
		Effect_Monster_Laserlast01Normal_3,
		// Token: 0x04018806 RID: 100358
		[Token(Token = "0x401526F")]
		Effect_Monster_Laserstart01Normal_4,
		// Token: 0x04018807 RID: 100359
		[Token(Token = "0x4015270")]
		Effect_Monster_Lasermain01Normal_4,
		// Token: 0x04018808 RID: 100360
		[Token(Token = "0x4015271")]
		Effect_Monster_Laserlast01Normal_4,
		// Token: 0x04018809 RID: 100361
		[Token(Token = "0x4015272")]
		Effect_Slime_Attack_1 = 1802,
		// Token: 0x0401880A RID: 100362
		[Token(Token = "0x4015273")]
		Effect_Slime_Attack_2,
		// Token: 0x0401880B RID: 100363
		[Token(Token = "0x4015274")]
		Effect_Flower_Attack_2,
		// Token: 0x0401880C RID: 100364
		[Token(Token = "0x4015275")]
		Effect_Kopegi_Attack_1_1,
		// Token: 0x0401880D RID: 100365
		[Token(Token = "0x4015276")]
		Effect_Keron_Attack_1_1 = 1807,
		// Token: 0x0401880E RID: 100366
		[Token(Token = "0x4015277")]
		Effect_Dog_Attack_1 = 1809,
		// Token: 0x0401880F RID: 100367
		[Token(Token = "0x4015278")]
		Effect_Boss_Uroboros001_Wind,
		// Token: 0x04018810 RID: 100368
		[Token(Token = "0x4015279")]
		Effect_Boss_Uroboros001_Fire,
		// Token: 0x04018811 RID: 100369
		[Token(Token = "0x401527A")]
		Effect_Boss_Uroboros001_Ice,
		// Token: 0x04018812 RID: 100370
		[Token(Token = "0x401527B")]
		Effect_Monster_FairyFire01,
		// Token: 0x04018813 RID: 100371
		[Token(Token = "0x401527C")]
		Effect_Kopegi_Attack_1_2,
		// Token: 0x04018814 RID: 100372
		[Token(Token = "0x401527D")]
		Effect_Monster_ImpactComical,
		// Token: 0x04018815 RID: 100373
		[Token(Token = "0x401527E")]
		Effect_Monster_Hornet01Needle,
		// Token: 0x04018816 RID: 100374
		[Token(Token = "0x401527F")]
		Effect_Event_smoke003,
		// Token: 0x04018817 RID: 100375
		[Token(Token = "0x4015280")]
		Effect_Monster_HitodamaFire01,
		// Token: 0x04018818 RID: 100376
		[Token(Token = "0x4015281")]
		Effect_Monster_HitodamaFire02,
		// Token: 0x04018819 RID: 100377
		[Token(Token = "0x4015282")]
		Effect_Monster_MaboroshiFire01,
		// Token: 0x0401881A RID: 100378
		[Token(Token = "0x4015283")]
		Effect_Monster_MaboroshiFire02,
		// Token: 0x0401881B RID: 100379
		[Token(Token = "0x4015284")]
		Effect_Monster_SoylasFire01,
		// Token: 0x0401881C RID: 100380
		[Token(Token = "0x4015285")]
		Effect_Monster_SoylasFire02,
		// Token: 0x0401881D RID: 100381
		[Token(Token = "0x4015286")]
		Effect_Monster_SlashWave02Normal_2,
		// Token: 0x0401881E RID: 100382
		[Token(Token = "0x4015287")]
		Effect_Boss_Kyubi001 = 2000,
		// Token: 0x0401881F RID: 100383
		[Token(Token = "0x4015288")]
		Effect_Boss_Kyubi002,
		// Token: 0x04018820 RID: 100384
		[Token(Token = "0x4015289")]
		Effect_Boss_Kyubi003,
		// Token: 0x04018821 RID: 100385
		[Token(Token = "0x401528A")]
		Effect_Boss_Kyubi004,
		// Token: 0x04018822 RID: 100386
		[Token(Token = "0x401528B")]
		Effect_Boss_Kyubi005,
		// Token: 0x04018823 RID: 100387
		[Token(Token = "0x401528C")]
		Effect_Boss_Kyubi006,
		// Token: 0x04018824 RID: 100388
		[Token(Token = "0x401528D")]
		Effect_Boss_Kyubi007,
		// Token: 0x04018825 RID: 100389
		[Token(Token = "0x401528E")]
		Effect_Boss_Kyubi008,
		// Token: 0x04018826 RID: 100390
		[Token(Token = "0x401528F")]
		Effect_Boss_Kyubi009,
		// Token: 0x04018827 RID: 100391
		[Token(Token = "0x4015290")]
		Effect_Boss_Kyubi010,
		// Token: 0x04018828 RID: 100392
		[Token(Token = "0x4015291")]
		Effect_Boss_Common001,
		// Token: 0x04018829 RID: 100393
		[Token(Token = "0x4015292")]
		Effect_Boss_Common002,
		// Token: 0x0401882A RID: 100394
		[Token(Token = "0x4015293")]
		Effect_Boss_Common003,
		// Token: 0x0401882B RID: 100395
		[Token(Token = "0x4015294")]
		Effect_Boss_GansekiDragon001,
		// Token: 0x0401882C RID: 100396
		[Token(Token = "0x4015295")]
		Effect_Boss_GansekiDragon002,
		// Token: 0x0401882D RID: 100397
		[Token(Token = "0x4015296")]
		Effect_Boss_GansekiDragon003,
		// Token: 0x0401882E RID: 100398
		[Token(Token = "0x4015297")]
		Effect_Boss_Common004,
		// Token: 0x0401882F RID: 100399
		[Token(Token = "0x4015298")]
		Effect_Boss_Common005,
		// Token: 0x04018830 RID: 100400
		[Token(Token = "0x4015299")]
		Effect_Boss_Common006,
		// Token: 0x04018831 RID: 100401
		[Token(Token = "0x401529A")]
		Effect_Boss_Reviatan001,
		// Token: 0x04018832 RID: 100402
		[Token(Token = "0x401529B")]
		Effect_Boss_Reviatan002,
		// Token: 0x04018833 RID: 100403
		[Token(Token = "0x401529C")]
		Effect_Boss_Reviatan003,
		// Token: 0x04018834 RID: 100404
		[Token(Token = "0x401529D")]
		Effect_Boss_Reviatan004,
		// Token: 0x04018835 RID: 100405
		[Token(Token = "0x401529E")]
		Effect_Boss_Reviatan005,
		// Token: 0x04018836 RID: 100406
		[Token(Token = "0x401529F")]
		Effect_Boss_Reviatan006,
		// Token: 0x04018837 RID: 100407
		[Token(Token = "0x40152A0")]
		Effect_Boss_Reviatan007_1,
		// Token: 0x04018838 RID: 100408
		[Token(Token = "0x40152A1")]
		Effect_Boss_Reviatan007_2,
		// Token: 0x04018839 RID: 100409
		[Token(Token = "0x40152A2")]
		Effect_Boss_Reviatan008,
		// Token: 0x0401883A RID: 100410
		[Token(Token = "0x40152A3")]
		Effect_Boss_Reviatan009,
		// Token: 0x0401883B RID: 100411
		[Token(Token = "0x40152A4")]
		Effect_Boss_DragonSister001,
		// Token: 0x0401883C RID: 100412
		[Token(Token = "0x40152A5")]
		Effect_Boss_DragonSister002,
		// Token: 0x0401883D RID: 100413
		[Token(Token = "0x40152A6")]
		Effect_Boss_DragonSister003,
		// Token: 0x0401883E RID: 100414
		[Token(Token = "0x40152A7")]
		Effect_Boss_DragonSister004,
		// Token: 0x0401883F RID: 100415
		[Token(Token = "0x40152A8")]
		Effect_Boss_DragonSister005,
		// Token: 0x04018840 RID: 100416
		[Token(Token = "0x40152A9")]
		Effect_Boss_DragonSister006,
		// Token: 0x04018841 RID: 100417
		[Token(Token = "0x40152AA")]
		Effect_Boss_DragonSister007,
		// Token: 0x04018842 RID: 100418
		[Token(Token = "0x40152AB")]
		Effect_Boss_Common007,
		// Token: 0x04018843 RID: 100419
		[Token(Token = "0x40152AC")]
		Effect_Boss_DragonSister008,
		// Token: 0x04018844 RID: 100420
		[Token(Token = "0x40152AD")]
		Effect_Boss_DragonSister009,
		// Token: 0x04018845 RID: 100421
		[Token(Token = "0x40152AE")]
		Effect_Boss_DragonSister010,
		// Token: 0x04018846 RID: 100422
		[Token(Token = "0x40152AF")]
		Effect_Boss_DragonSister011,
		// Token: 0x04018847 RID: 100423
		[Token(Token = "0x40152B0")]
		Effect_Boss_DragonSister012,
		// Token: 0x04018848 RID: 100424
		[Token(Token = "0x40152B1")]
		Effect_Boss_DragonSister013,
		// Token: 0x04018849 RID: 100425
		[Token(Token = "0x40152B2")]
		Effect_Boss_DragonSister014,
		// Token: 0x0401884A RID: 100426
		[Token(Token = "0x40152B3")]
		Effect_Boss_DragonSister015,
		// Token: 0x0401884B RID: 100427
		[Token(Token = "0x40152B4")]
		Effect_Boss_Inosisi001,
		// Token: 0x0401884C RID: 100428
		[Token(Token = "0x40152B5")]
		Effect_Boss_Inosisi002,
		// Token: 0x0401884D RID: 100429
		[Token(Token = "0x40152B6")]
		Effect_Boss_Inosisi003,
		// Token: 0x0401884E RID: 100430
		[Token(Token = "0x40152B7")]
		Effect_Boss_Inosisi004,
		// Token: 0x0401884F RID: 100431
		[Token(Token = "0x40152B8")]
		Effect_Boss_Common008,
		// Token: 0x04018850 RID: 100432
		[Token(Token = "0x40152B9")]
		Effect_Boss_Common009,
		// Token: 0x04018851 RID: 100433
		[Token(Token = "0x40152BA")]
		Effect_Harinezumi_Attack_1_1,
		// Token: 0x04018852 RID: 100434
		[Token(Token = "0x40152BB")]
		Effect_Harinezumi_Attack_1_2,
		// Token: 0x04018853 RID: 100435
		[Token(Token = "0x40152BC")]
		Effect_Harinezumi_Attack_2,
		// Token: 0x04018854 RID: 100436
		[Token(Token = "0x40152BD")]
		Effect_Harinezumi_Attack_3,
		// Token: 0x04018855 RID: 100437
		[Token(Token = "0x40152BE")]
		Effect_Harinezumi_Attack_4,
		// Token: 0x04018856 RID: 100438
		[Token(Token = "0x40152BF")]
		Effect_Kamereon_Attack_1,
		// Token: 0x04018857 RID: 100439
		[Token(Token = "0x40152C0")]
		Effect_Kamereon_Attack_2,
		// Token: 0x04018858 RID: 100440
		[Token(Token = "0x40152C1")]
		Effect_Kamereon_Attack_3_1,
		// Token: 0x04018859 RID: 100441
		[Token(Token = "0x40152C2")]
		Effect_Kamereon_Attack_3_2,
		// Token: 0x0401885A RID: 100442
		[Token(Token = "0x40152C3")]
		Effect_Kamereon_Attack_4_1,
		// Token: 0x0401885B RID: 100443
		[Token(Token = "0x40152C4")]
		Effect_Kamereon_Attack_4_2,
		// Token: 0x0401885C RID: 100444
		[Token(Token = "0x40152C5")]
		Effect_Aries_Attack_1_1,
		// Token: 0x0401885D RID: 100445
		[Token(Token = "0x40152C6")]
		Effect_Aries_Attack_1_2,
		// Token: 0x0401885E RID: 100446
		[Token(Token = "0x40152C7")]
		Effect_Aries_Attack_1_3,
		// Token: 0x0401885F RID: 100447
		[Token(Token = "0x40152C8")]
		Effect_Aries_Attack_1_4,
		// Token: 0x04018860 RID: 100448
		[Token(Token = "0x40152C9")]
		Effect_Aries_Attack_1_5,
		// Token: 0x04018861 RID: 100449
		[Token(Token = "0x40152CA")]
		Effect_Aries_Attack_2_1,
		// Token: 0x04018862 RID: 100450
		[Token(Token = "0x40152CB")]
		Effect_Aries_Attack_2_2,
		// Token: 0x04018863 RID: 100451
		[Token(Token = "0x40152CC")]
		Effect_Aries_Attack_2_3,
		// Token: 0x04018864 RID: 100452
		[Token(Token = "0x40152CD")]
		Effect_Aries_Attack_2_4,
		// Token: 0x04018865 RID: 100453
		[Token(Token = "0x40152CE")]
		Effect_Aries_Attack_3,
		// Token: 0x04018866 RID: 100454
		[Token(Token = "0x40152CF")]
		Effect_Aries_Attack_4,
		// Token: 0x04018867 RID: 100455
		[Token(Token = "0x40152D0")]
		Effect_Aries_Attack_5_1,
		// Token: 0x04018868 RID: 100456
		[Token(Token = "0x40152D1")]
		Effect_Aries_Anger,
		// Token: 0x04018869 RID: 100457
		[Token(Token = "0x40152D2")]
		Effect_SkullDragon_Attack_1,
		// Token: 0x0401886A RID: 100458
		[Token(Token = "0x40152D3")]
		Effect_SkullDragon_Attack_2,
		// Token: 0x0401886B RID: 100459
		[Token(Token = "0x40152D4")]
		Effect_SkullDragon_Attack_3_1,
		// Token: 0x0401886C RID: 100460
		[Token(Token = "0x40152D5")]
		Effect_SkullDragon_Attack_3_2,
		// Token: 0x0401886D RID: 100461
		[Token(Token = "0x40152D6")]
		Effect_SkullDragon_Attack_3_3,
		// Token: 0x0401886E RID: 100462
		[Token(Token = "0x40152D7")]
		Effect_SkullDragon_Attack_4,
		// Token: 0x0401886F RID: 100463
		[Token(Token = "0x40152D8")]
		Effect_SkullDragon_Attack_5_1,
		// Token: 0x04018870 RID: 100464
		[Token(Token = "0x40152D9")]
		Effect_SkullDragon_Attack_5_2,
		// Token: 0x04018871 RID: 100465
		[Token(Token = "0x40152DA")]
		Effect_SkullDragon_Attack_5_3,
		// Token: 0x04018872 RID: 100466
		[Token(Token = "0x40152DB")]
		Effect_Sasquatch_Attack_1,
		// Token: 0x04018873 RID: 100467
		[Token(Token = "0x40152DC")]
		Effect_Sasquatch_Attack_2_1,
		// Token: 0x04018874 RID: 100468
		[Token(Token = "0x40152DD")]
		Effect_Sasquatch_Attack_2_2,
		// Token: 0x04018875 RID: 100469
		[Token(Token = "0x40152DE")]
		Effect_Sasquatch_Attack_2_3,
		// Token: 0x04018876 RID: 100470
		[Token(Token = "0x40152DF")]
		Effect_Sasquatch_Attack_2_4,
		// Token: 0x04018877 RID: 100471
		[Token(Token = "0x40152E0")]
		Effect_Sasquatch_Attack_4,
		// Token: 0x04018878 RID: 100472
		[Token(Token = "0x40152E1")]
		Effect_Charge_01,
		// Token: 0x04018879 RID: 100473
		[Token(Token = "0x40152E2")]
		Effect_Kraken_Attack_2_1,
		// Token: 0x0401887A RID: 100474
		[Token(Token = "0x40152E3")]
		Effect_Kraken_Attack_2_3,
		// Token: 0x0401887B RID: 100475
		[Token(Token = "0x40152E4")]
		Effect_Kraken_Attack_2_4,
		// Token: 0x0401887C RID: 100476
		[Token(Token = "0x40152E5")]
		Effect_Kraken_Attack_5_2,
		// Token: 0x0401887D RID: 100477
		[Token(Token = "0x40152E6")]
		Effect_Kraken_Attack_Bomb,
		// Token: 0x0401887E RID: 100478
		[Token(Token = "0x40152E7")]
		Effect_Boss_Common010,
		// Token: 0x0401887F RID: 100479
		[Token(Token = "0x40152E8")]
		Effect_Basilisk_Attack_4_2,
		// Token: 0x04018880 RID: 100480
		[Token(Token = "0x40152E9")]
		Effect_Basilisk_Flame,
		// Token: 0x04018881 RID: 100481
		[Token(Token = "0x40152EA")]
		Effect_Boss_Common012,
		// Token: 0x04018882 RID: 100482
		[Token(Token = "0x40152EB")]
		Effect_Boss_Common013,
		// Token: 0x04018883 RID: 100483
		[Token(Token = "0x40152EC")]
		Effect_Boss_Uroboros001,
		// Token: 0x04018884 RID: 100484
		[Token(Token = "0x40152ED")]
		Effect_Boss_Uroboros002,
		// Token: 0x04018885 RID: 100485
		[Token(Token = "0x40152EE")]
		Effect_Boss_Uroboros003,
		// Token: 0x04018886 RID: 100486
		[Token(Token = "0x40152EF")]
		Effect_Boss_Uroboros004,
		// Token: 0x04018887 RID: 100487
		[Token(Token = "0x40152F0")]
		Effect_Boss_Uroboros005,
		// Token: 0x04018888 RID: 100488
		[Token(Token = "0x40152F1")]
		Effect_Boss_Uroboros006,
		// Token: 0x04018889 RID: 100489
		[Token(Token = "0x40152F2")]
		Effect_Boss_Uroboros007,
		// Token: 0x0401888A RID: 100490
		[Token(Token = "0x40152F3")]
		Effect_Kurage_Attack_1,
		// Token: 0x0401888B RID: 100491
		[Token(Token = "0x40152F4")]
		Effect_Kurage_Attack_2_1,
		// Token: 0x0401888C RID: 100492
		[Token(Token = "0x40152F5")]
		Effect_Kurage_Attack_2_2,
		// Token: 0x0401888D RID: 100493
		[Token(Token = "0x40152F6")]
		Effect_Kurage_Attack_4_1,
		// Token: 0x0401888E RID: 100494
		[Token(Token = "0x40152F7")]
		Effect_Kurage_Attack_4_2,
		// Token: 0x0401888F RID: 100495
		[Token(Token = "0x40152F8")]
		Effect_Kurage_Attack_4_3,
		// Token: 0x04018890 RID: 100496
		[Token(Token = "0x40152F9")]
		Effect_Kurage_charging_1,
		// Token: 0x04018891 RID: 100497
		[Token(Token = "0x40152FA")]
		Effect_Kurage_charging_2,
		// Token: 0x04018892 RID: 100498
		[Token(Token = "0x40152FB")]
		Effect_Kurage_charging_3,
		// Token: 0x04018893 RID: 100499
		[Token(Token = "0x40152FC")]
		Effect_Kurage_Electrical,
		// Token: 0x04018894 RID: 100500
		[Token(Token = "0x40152FD")]
		Effect_Mummy_Attack_1_1,
		// Token: 0x04018895 RID: 100501
		[Token(Token = "0x40152FE")]
		Effect_Mummy_Attack_1_2,
		// Token: 0x04018896 RID: 100502
		[Token(Token = "0x40152FF")]
		Effect_Mummy_Attack_4_1,
		// Token: 0x04018897 RID: 100503
		[Token(Token = "0x4015300")]
		Effect_Mummy_Attack_4_2,
		// Token: 0x04018898 RID: 100504
		[Token(Token = "0x4015301")]
		Effect_Mummy_Attack_4_3,
		// Token: 0x04018899 RID: 100505
		[Token(Token = "0x4015302")]
		Effect_WoodGolem_Attack_4_1,
		// Token: 0x0401889A RID: 100506
		[Token(Token = "0x4015303")]
		Effect_WoodGolem_Attack_4_2,
		// Token: 0x0401889B RID: 100507
		[Token(Token = "0x4015304")]
		Effect_WoodGolem_Attack_4_2_2,
		// Token: 0x0401889C RID: 100508
		[Token(Token = "0x4015305")]
		Effect_Boss_LastBoss001,
		// Token: 0x0401889D RID: 100509
		[Token(Token = "0x4015306")]
		Effect_Boss_LastBoss002,
		// Token: 0x0401889E RID: 100510
		[Token(Token = "0x4015307")]
		Effect_Boss_LastBoss003,
		// Token: 0x0401889F RID: 100511
		[Token(Token = "0x4015308")]
		Effect_Boss_LastBoss004,
		// Token: 0x040188A0 RID: 100512
		[Token(Token = "0x4015309")]
		Effect_Boss_LastBoss005,
		// Token: 0x040188A1 RID: 100513
		[Token(Token = "0x401530A")]
		Effect_Boss_LastBoss006,
		// Token: 0x040188A2 RID: 100514
		[Token(Token = "0x401530B")]
		Effect_Boss_LastBoss007,
		// Token: 0x040188A3 RID: 100515
		[Token(Token = "0x401530C")]
		Effect_Boss_LastBoss008,
		// Token: 0x040188A4 RID: 100516
		[Token(Token = "0x401530D")]
		Effect_Boss_LastBoss009,
		// Token: 0x040188A5 RID: 100517
		[Token(Token = "0x401530E")]
		Effect_Boss_LastBoss010,
		// Token: 0x040188A6 RID: 100518
		[Token(Token = "0x401530F")]
		Effect_Boss_LastBoss011,
		// Token: 0x040188A7 RID: 100519
		[Token(Token = "0x4015310")]
		Effect_Boss_LastBoss012,
		// Token: 0x040188A8 RID: 100520
		[Token(Token = "0x4015311")]
		Effect_Boss_LastBoss014,
		// Token: 0x040188A9 RID: 100521
		[Token(Token = "0x4015312")]
		Effect_Boss_LastBoss015,
		// Token: 0x040188AA RID: 100522
		[Token(Token = "0x4015313")]
		Effect_Boss_LastBoss016,
		// Token: 0x040188AB RID: 100523
		[Token(Token = "0x4015314")]
		Effect_Boss_LastBoss017,
		// Token: 0x040188AC RID: 100524
		[Token(Token = "0x4015315")]
		Effect_Boss_LastBoss018,
		// Token: 0x040188AD RID: 100525
		[Token(Token = "0x4015316")]
		Effect_Boss_LastBoss019,
		// Token: 0x040188AE RID: 100526
		[Token(Token = "0x4015317")]
		Effect_Boss_LastBoss020,
		// Token: 0x040188AF RID: 100527
		[Token(Token = "0x4015318")]
		Effect_Boss_LastBoss021,
		// Token: 0x040188B0 RID: 100528
		[Token(Token = "0x4015319")]
		Effect_Boss_LastBoss022,
		// Token: 0x040188B1 RID: 100529
		[Token(Token = "0x401531A")]
		Effect_Boss_LastBoss023,
		// Token: 0x040188B2 RID: 100530
		[Token(Token = "0x401531B")]
		Effect_Boss_LastBoss024,
		// Token: 0x040188B3 RID: 100531
		[Token(Token = "0x401531C")]
		Effect_Boss_LastBoss025,
		// Token: 0x040188B4 RID: 100532
		[Token(Token = "0x401531D")]
		Effect_Boss_LastBoss026,
		// Token: 0x040188B5 RID: 100533
		[Token(Token = "0x401531E")]
		Effect_Boss_LastBoss028,
		// Token: 0x040188B6 RID: 100534
		[Token(Token = "0x401531F")]
		Effect_GroundImpact_Grass,
		// Token: 0x040188B7 RID: 100535
		[Token(Token = "0x4015320")]
		Effect_Hasibirokou_Attack_4,
		// Token: 0x040188B8 RID: 100536
		[Token(Token = "0x4015321")]
		Effect_Boss_Common011,
		// Token: 0x040188B9 RID: 100537
		[Token(Token = "0x4015322")]
		Effect_Aries_2_Attack_1_4,
		// Token: 0x040188BA RID: 100538
		[Token(Token = "0x4015323")]
		Effect_Aries_2_Attack_1_5,
		// Token: 0x040188BB RID: 100539
		[Token(Token = "0x4015324")]
		Effect_Deadtree_Apple,
		// Token: 0x040188BC RID: 100540
		[Token(Token = "0x4015325")]
		Effect_Deadtree_Chestnut,
		// Token: 0x040188BD RID: 100541
		[Token(Token = "0x4015326")]
		Effect_Boss_Arachne002 = 2160,
		// Token: 0x040188BE RID: 100542
		[Token(Token = "0x4015327")]
		Effect_Boss_Arachne003,
		// Token: 0x040188BF RID: 100543
		[Token(Token = "0x4015328")]
		Effect_Boss_Arachne004,
		// Token: 0x040188C0 RID: 100544
		[Token(Token = "0x4015329")]
		Effect_Boss_Arachne005,
		// Token: 0x040188C1 RID: 100545
		[Token(Token = "0x401532A")]
		Effect_Boss_Arachne006,
		// Token: 0x040188C2 RID: 100546
		[Token(Token = "0x401532B")]
		Effect_Boss_Arachne007,
		// Token: 0x040188C3 RID: 100547
		[Token(Token = "0x401532C")]
		Effect_Boss_Arachne008,
		// Token: 0x040188C4 RID: 100548
		[Token(Token = "0x401532D")]
		Effect_Boss_Arachne009,
		// Token: 0x040188C5 RID: 100549
		[Token(Token = "0x401532E")]
		Effect_Boss_Arachne010,
		// Token: 0x040188C6 RID: 100550
		[Token(Token = "0x401532F")]
		Effect_Boss_Arachne011,
		// Token: 0x040188C7 RID: 100551
		[Token(Token = "0x4015330")]
		Effect_Boss_Gandage001 = 2200,
		// Token: 0x040188C8 RID: 100552
		[Token(Token = "0x4015331")]
		Effect_Boss_Gandage002,
		// Token: 0x040188C9 RID: 100553
		[Token(Token = "0x4015332")]
		Effect_Boss_Gandage009,
		// Token: 0x040188CA RID: 100554
		[Token(Token = "0x4015333")]
		Effect_Boss_Gandage011,
		// Token: 0x040188CB RID: 100555
		[Token(Token = "0x4015334")]
		Effect_Boss_Gandage012,
		// Token: 0x040188CC RID: 100556
		[Token(Token = "0x4015335")]
		Effect_Boss_Gandage013,
		// Token: 0x040188CD RID: 100557
		[Token(Token = "0x4015336")]
		Effect_Boss_Gandage014,
		// Token: 0x040188CE RID: 100558
		[Token(Token = "0x4015337")]
		Effect_Boss_Gandage017,
		// Token: 0x040188CF RID: 100559
		[Token(Token = "0x4015338")]
		Effect_Event_Hit_Dark,
		// Token: 0x040188D0 RID: 100560
		[Token(Token = "0x4015339")]
		Effect_Boss_Audmura001,
		// Token: 0x040188D1 RID: 100561
		[Token(Token = "0x401533A")]
		Effect_Boss_Audmura002,
		// Token: 0x040188D2 RID: 100562
		[Token(Token = "0x401533B")]
		Effect_Boss_Audmura003,
		// Token: 0x040188D3 RID: 100563
		[Token(Token = "0x401533C")]
		Effect_Boss_Audmura004,
		// Token: 0x040188D4 RID: 100564
		[Token(Token = "0x401533D")]
		Effect_Boss_Audmura007,
		// Token: 0x040188D5 RID: 100565
		[Token(Token = "0x401533E")]
		Effect_Boss_Audmura003_02,
		// Token: 0x040188D6 RID: 100566
		[Token(Token = "0x401533F")]
		Effect_Boss_Audmura004_02,
		// Token: 0x040188D7 RID: 100567
		[Token(Token = "0x4015340")]
		Effect_Boss_Audmura001_02,
		// Token: 0x040188D8 RID: 100568
		[Token(Token = "0x4015341")]
		Effect_Boss_Audmura002_02,
		// Token: 0x040188D9 RID: 100569
		[Token(Token = "0x4015342")]
		Effect_DS_Hammar03,
		// Token: 0x040188DA RID: 100570
		[Token(Token = "0x4015343")]
		Effect_Event_Wave,
		// Token: 0x040188DB RID: 100571
		[Token(Token = "0x4015344")]
		Effect_DS_Fist06,
		// Token: 0x040188DC RID: 100572
		[Token(Token = "0x4015345")]
		Effect_Wand_Water,
		// Token: 0x040188DD RID: 100573
		[Token(Token = "0x4015346")]
		Effect_Monster_ShockWave05Normal_1,
		// Token: 0x040188DE RID: 100574
		[Token(Token = "0x4015347")]
		Effect_DS_Fist05,
		// Token: 0x040188DF RID: 100575
		[Token(Token = "0x4015348")]
		Effect_Baffamo_Attack_2,
		// Token: 0x040188E0 RID: 100576
		[Token(Token = "0x4015349")]
		Effect_Boss_DragonSister016,
		// Token: 0x040188E1 RID: 100577
		[Token(Token = "0x401534A")]
		Effect_Event_Magiccircle_s231,
		// Token: 0x040188E2 RID: 100578
		[Token(Token = "0x401534B")]
		Effect_Event_BlackAura10,
		// Token: 0x040188E3 RID: 100579
		[Token(Token = "0x401534C")]
		Effect_Monster_SlashWave01Normal_1,
		// Token: 0x040188E4 RID: 100580
		[Token(Token = "0x401534D")]
		Effect_Event_PillarOfLight,
		// Token: 0x040188E5 RID: 100581
		[Token(Token = "0x401534E")]
		Effect_Monster_Appear = 2500,
		// Token: 0x040188E6 RID: 100582
		[Token(Token = "0x401534F")]
		efe_0024,
		// Token: 0x040188E7 RID: 100583
		[Token(Token = "0x4015350")]
		Effect_Hit_Normal = 3000,
		// Token: 0x040188E8 RID: 100584
		[Token(Token = "0x4015351")]
		Effect_Hit_Fire,
		// Token: 0x040188E9 RID: 100585
		[Token(Token = "0x4015352")]
		Effect_Hit_Water,
		// Token: 0x040188EA RID: 100586
		[Token(Token = "0x4015353")]
		Effect_Hit_Wind,
		// Token: 0x040188EB RID: 100587
		[Token(Token = "0x4015354")]
		Effect_Hit_Earth,
		// Token: 0x040188EC RID: 100588
		[Token(Token = "0x4015355")]
		Effect_Hit_Shine,
		// Token: 0x040188ED RID: 100589
		[Token(Token = "0x4015356")]
		Effect_Hit_Dark,
		// Token: 0x040188EE RID: 100590
		[Token(Token = "0x4015357")]
		Effect_Hit_Love,
		// Token: 0x040188EF RID: 100591
		[Token(Token = "0x4015358")]
		Effect_HitCritical,
		// Token: 0x040188F0 RID: 100592
		[Token(Token = "0x4015359")]
		Effect_HitDamagePlayer,
		// Token: 0x040188F1 RID: 100593
		[Token(Token = "0x401535A")]
		Effect_HitHeavyDamagePlayer,
		// Token: 0x040188F2 RID: 100594
		[Token(Token = "0x401535B")]
		Effect_HitDamageMonster,
		// Token: 0x040188F3 RID: 100595
		[Token(Token = "0x401535C")]
		Effect_HitHeavyDamageMonster,
		// Token: 0x040188F4 RID: 100596
		[Token(Token = "0x401535D")]
		Effect_FoodSmoke01 = 4000,
		// Token: 0x040188F5 RID: 100597
		[Token(Token = "0x401535E")]
		Effect_Dozing,
		// Token: 0x040188F6 RID: 100598
		[Token(Token = "0x401535F")]
		Effect_LifeDust,
		// Token: 0x040188F7 RID: 100599
		[Token(Token = "0x4015360")]
		Effect_FoodSmoke02,
		// Token: 0x040188F8 RID: 100600
		[Token(Token = "0x4015361")]
		Effect_FoodFragment,
		// Token: 0x040188F9 RID: 100601
		[Token(Token = "0x4015362")]
		Effect_FarmworkHammerSpark01,
		// Token: 0x040188FA RID: 100602
		[Token(Token = "0x4015363")]
		Effect_FoodSmoke03,
		// Token: 0x040188FB RID: 100603
		[Token(Token = "0x4015364")]
		Effect_Fes_SnowBallCrumble,
		// Token: 0x040188FC RID: 100604
		[Token(Token = "0x4015365")]
		Effect_Rune,
		// Token: 0x040188FD RID: 100605
		[Token(Token = "0x4015366")]
		Effect_RuneVanish,
		// Token: 0x040188FE RID: 100606
		[Token(Token = "0x4015367")]
		Effect_FarmworkSowseeds = 5000,
		// Token: 0x040188FF RID: 100607
		[Token(Token = "0x4015368")]
		Effect_FarmworkGrowth,
		// Token: 0x04018900 RID: 100608
		[Token(Token = "0x4015369")]
		Effect_FarmworkHarvest,
		// Token: 0x04018901 RID: 100609
		[Token(Token = "0x401536A")]
		Effect_FarmworkWatering,
		// Token: 0x04018902 RID: 100610
		[Token(Token = "0x401536B")]
		Effect_FarmDropWater,
		// Token: 0x04018903 RID: 100611
		[Token(Token = "0x401536C")]
		Effect_FarmworkWoodFragment,
		// Token: 0x04018904 RID: 100612
		[Token(Token = "0x401536D")]
		Effect_FarmworkCutGrass01,
		// Token: 0x04018905 RID: 100613
		[Token(Token = "0x401536E")]
		Effect_FarmworkCutGrass02,
		// Token: 0x04018906 RID: 100614
		[Token(Token = "0x401536F")]
		Effect_FarmworkSmoke,
		// Token: 0x04018907 RID: 100615
		[Token(Token = "0x4015370")]
		Effect_FarmworkHammerSpark02,
		// Token: 0x04018908 RID: 100616
		[Token(Token = "0x4015371")]
		Effect_CookingHumming,
		// Token: 0x04018909 RID: 100617
		[Token(Token = "0x4015372")]
		Effect_RuneyTree,
		// Token: 0x0401890A RID: 100618
		[Token(Token = "0x4015373")]
		Effect_RuneyGrass,
		// Token: 0x0401890B RID: 100619
		[Token(Token = "0x4015374")]
		Effect_RuneyRock,
		// Token: 0x0401890C RID: 100620
		[Token(Token = "0x4015375")]
		Effect_RuneyAqua,
		// Token: 0x0401890D RID: 100621
		[Token(Token = "0x4015376")]
		Effect_RuneyTreeVanish,
		// Token: 0x0401890E RID: 100622
		[Token(Token = "0x4015377")]
		Effect_RuneyGrassVanish,
		// Token: 0x0401890F RID: 100623
		[Token(Token = "0x4015378")]
		Effect_RuneyRockVanish,
		// Token: 0x04018910 RID: 100624
		[Token(Token = "0x4015379")]
		Effect_RuneyAquaVanish,
		// Token: 0x04018911 RID: 100625
		[Token(Token = "0x401537A")]
		Effect_FarmworkFertilizer,
		// Token: 0x04018912 RID: 100626
		[Token(Token = "0x401537B")]
		Effect_FishingThrow = 5500,
		// Token: 0x04018913 RID: 100627
		[Token(Token = "0x401537C")]
		Effect_FishingReturn,
		// Token: 0x04018914 RID: 100628
		[Token(Token = "0x401537D")]
		Effect_FishingWave,
		// Token: 0x04018915 RID: 100629
		[Token(Token = "0x401537E")]
		Effect_FishingSplash,
		// Token: 0x04018916 RID: 100630
		[Token(Token = "0x401537F")]
		Effect_FishingSurprise,
		// Token: 0x04018917 RID: 100631
		[Token(Token = "0x4015380")]
		Effect_FishingWait,
		// Token: 0x04018918 RID: 100632
		[Token(Token = "0x4015381")]
		Effect_FishingEscape,
		// Token: 0x04018919 RID: 100633
		[Token(Token = "0x4015382")]
		Effect_FishingGet,
		// Token: 0x0401891A RID: 100634
		[Token(Token = "0x4015383")]
		Effect_FishingGetFirst,
		// Token: 0x0401891B RID: 100635
		[Token(Token = "0x4015384")]
		Effect_FishingSplashHard,
		// Token: 0x0401891C RID: 100636
		[Token(Token = "0x4015385")]
		Effect_FishingSplash_s,
		// Token: 0x0401891D RID: 100637
		[Token(Token = "0x4015386")]
		Effect_EmotionJoy = 6000,
		// Token: 0x0401891E RID: 100638
		[Token(Token = "0x4015387")]
		Effect_EmotionLaugh,
		// Token: 0x0401891F RID: 100639
		[Token(Token = "0x4015388")]
		Effect_EmotionBlush,
		// Token: 0x04018920 RID: 100640
		[Token(Token = "0x4015389")]
		Effect_EmotionSurprise,
		// Token: 0x04018921 RID: 100641
		[Token(Token = "0x401538A")]
		Effect_EmotionCry,
		// Token: 0x04018922 RID: 100642
		[Token(Token = "0x401538B")]
		Effect_EmotionBad,
		// Token: 0x04018923 RID: 100643
		[Token(Token = "0x401538C")]
		Effect_EmotionAngry,
		// Token: 0x04018924 RID: 100644
		[Token(Token = "0x401538D")]
		Effect_EmotionSad,
		// Token: 0x04018925 RID: 100645
		[Token(Token = "0x401538E")]
		Effect_EmotionShock,
		// Token: 0x04018926 RID: 100646
		[Token(Token = "0x401538F")]
		Effect_EmotionTroubled,
		// Token: 0x04018927 RID: 100647
		[Token(Token = "0x4015390")]
		Effect_EmotionThink,
		// Token: 0x04018928 RID: 100648
		[Token(Token = "0x4015391")]
		Effect_EmotionScared,
		// Token: 0x04018929 RID: 100649
		[Token(Token = "0x4015392")]
		Effect_EmotionInspiration,
		// Token: 0x0401892A RID: 100650
		[Token(Token = "0x4015393")]
		Effect_EmotionYawn,
		// Token: 0x0401892B RID: 100651
		[Token(Token = "0x4015394")]
		Effect_EmotionSurpriseThink,
		// Token: 0x0401892C RID: 100652
		[Token(Token = "0x4015395")]
		Effect_EmotionNotepink,
		// Token: 0x0401892D RID: 100653
		[Token(Token = "0x4015396")]
		Effect_EmotionHeart,
		// Token: 0x0401892E RID: 100654
		[Token(Token = "0x4015397")]
		Effect_EmotionExclamationQuestion02,
		// Token: 0x0401892F RID: 100655
		[Token(Token = "0x4015398")]
		Effect_EmotionNotice,
		// Token: 0x04018930 RID: 100656
		[Token(Token = "0x4015399")]
		Effect_EmotionAnger2,
		// Token: 0x04018931 RID: 100657
		[Token(Token = "0x401539A")]
		Effect_EmotionFrustrated,
		// Token: 0x04018932 RID: 100658
		[Token(Token = "0x401539B")]
		Effect_EmotionSleep,
		// Token: 0x04018933 RID: 100659
		[Token(Token = "0x401539C")]
		Effect_EmotionNote,
		// Token: 0x04018934 RID: 100660
		[Token(Token = "0x401539D")]
		Effect_WeatherRain = 7000,
		// Token: 0x04018935 RID: 100661
		[Token(Token = "0x401539E")]
		Effect_WeatherWind,
		// Token: 0x04018936 RID: 100662
		[Token(Token = "0x401539F")]
		Effect_WeatherTyphoon,
		// Token: 0x04018937 RID: 100663
		[Token(Token = "0x40153A0")]
		Effect_WeatherSnow,
		// Token: 0x04018938 RID: 100664
		[Token(Token = "0x40153A1")]
		Effect_WeatherBlizzard,
		// Token: 0x04018939 RID: 100665
		[Token(Token = "0x40153A2")]
		Effect_WeatherCherrytree,
		// Token: 0x0401893A RID: 100666
		[Token(Token = "0x40153A3")]
		Effect_WeatherLeaf,
		// Token: 0x0401893B RID: 100667
		[Token(Token = "0x40153A4")]
		Effect_Weather,
		// Token: 0x0401893C RID: 100668
		[Token(Token = "0x40153A5")]
		Effect_WarpPoint,
		// Token: 0x0401893D RID: 100669
		[Token(Token = "0x40153A6")]
		Effect_WarpLeave,
		// Token: 0x0401893E RID: 100670
		[Token(Token = "0x40153A7")]
		Effect_WarpArrival,
		// Token: 0x0401893F RID: 100671
		[Token(Token = "0x40153A8")]
		Effect_NaturalforcesRockbreak,
		// Token: 0x04018940 RID: 100672
		[Token(Token = "0x40153A9")]
		Effect_NaturalforcesEruption,
		// Token: 0x04018941 RID: 100673
		[Token(Token = "0x40153AA")]
		Effect_MapFireplace,
		// Token: 0x04018942 RID: 100674
		[Token(Token = "0x40153AB")]
		Effect_MapStove,
		// Token: 0x04018943 RID: 100675
		[Token(Token = "0x40153AC")]
		Effect_FoodSmoke04,
		// Token: 0x04018944 RID: 100676
		[Token(Token = "0x40153AD")]
		Effect_Lighting01,
		// Token: 0x04018945 RID: 100677
		[Token(Token = "0x40153AE")]
		Effect_ShineMorning,
		// Token: 0x04018946 RID: 100678
		[Token(Token = "0x40153AF")]
		Effect_ShineDaytime,
		// Token: 0x04018947 RID: 100679
		[Token(Token = "0x40153B0")]
		Effect_ShineEvening,
		// Token: 0x04018948 RID: 100680
		[Token(Token = "0x40153B1")]
		Effect_LightingCandle,
		// Token: 0x04018949 RID: 100681
		[Token(Token = "0x40153B2")]
		Effect_TreasureboxSmoke,
		// Token: 0x0401894A RID: 100682
		[Token(Token = "0x40153B3")]
		Effect_ShineWoods,
		// Token: 0x0401894B RID: 100683
		[Token(Token = "0x40153B4")]
		Effect_ItemGet,
		// Token: 0x0401894C RID: 100684
		[Token(Token = "0x40153B5")]
		Effect_WallNomal,
		// Token: 0x0401894D RID: 100685
		[Token(Token = "0x40153B6")]
		Effect_WallFire,
		// Token: 0x0401894E RID: 100686
		[Token(Token = "0x40153B7")]
		Effect_WallWater,
		// Token: 0x0401894F RID: 100687
		[Token(Token = "0x40153B8")]
		Effect_WallWind,
		// Token: 0x04018950 RID: 100688
		[Token(Token = "0x40153B9")]
		Effect_WallEarth,
		// Token: 0x04018951 RID: 100689
		[Token(Token = "0x40153BA")]
		Effect_WallShine,
		// Token: 0x04018952 RID: 100690
		[Token(Token = "0x40153BB")]
		Effect_WallDark,
		// Token: 0x04018953 RID: 100691
		[Token(Token = "0x40153BC")]
		Effect_WallLove,
		// Token: 0x04018954 RID: 100692
		[Token(Token = "0x40153BD")]
		Effect_DN_DiamondDust,
		// Token: 0x04018955 RID: 100693
		[Token(Token = "0x40153BE")]
		Effect_DN_PurpleGas,
		// Token: 0x04018956 RID: 100694
		[Token(Token = "0x40153BF")]
		Effect_DN_TreasureLight,
		// Token: 0x04018957 RID: 100695
		[Token(Token = "0x40153C0")]
		Effect_DN_Dust,
		// Token: 0x04018958 RID: 100696
		[Token(Token = "0x40153C1")]
		Effect_DN_DirtDust,
		// Token: 0x04018959 RID: 100697
		[Token(Token = "0x40153C2")]
		Effect_Map_Tree01,
		// Token: 0x0401895A RID: 100698
		[Token(Token = "0x40153C3")]
		Effect_Map_Tree02,
		// Token: 0x0401895B RID: 100699
		[Token(Token = "0x40153C4")]
		Effect_Map_Tree03,
		// Token: 0x0401895C RID: 100700
		[Token(Token = "0x40153C5")]
		Effect_Map_BlewAwayPlant01,
		// Token: 0x0401895D RID: 100701
		[Token(Token = "0x40153C6")]
		Effect_Map_BlewAwayPlant02,
		// Token: 0x0401895E RID: 100702
		[Token(Token = "0x40153C7")]
		Effect_Map_BlewAwaySnow,
		// Token: 0x0401895F RID: 100703
		[Token(Token = "0x40153C8")]
		Effect_Map_ChimneySmoke,
		// Token: 0x04018960 RID: 100704
		[Token(Token = "0x40153C9")]
		Effect_Map_HotspringSteam,
		// Token: 0x04018961 RID: 100705
		[Token(Token = "0x40153CA")]
		Effect_Map_Confetti,
		// Token: 0x04018962 RID: 100706
		[Token(Token = "0x40153CB")]
		Effect_Map_BlewAwaySand,
		// Token: 0x04018963 RID: 100707
		[Token(Token = "0x40153CC")]
		Effect_Map_FallSand,
		// Token: 0x04018964 RID: 100708
		[Token(Token = "0x40153CD")]
		Effect_Map_MountainSmoke,
		// Token: 0x04018965 RID: 100709
		[Token(Token = "0x40153CE")]
		Effect_Map_MountainMagma,
		// Token: 0x04018966 RID: 100710
		[Token(Token = "0x40153CF")]
		Effect_Map_WaterfallSplash,
		// Token: 0x04018967 RID: 100711
		[Token(Token = "0x40153D0")]
		Effect_Map_GimmickRock01,
		// Token: 0x04018968 RID: 100712
		[Token(Token = "0x40153D1")]
		Effect_Map_GimmickRock02,
		// Token: 0x04018969 RID: 100713
		[Token(Token = "0x40153D2")]
		Effect_Map_GimmickCloudWall,
		// Token: 0x0401896A RID: 100714
		[Token(Token = "0x40153D3")]
		Effect_Map_GimmickIceBamboo,
		// Token: 0x0401896B RID: 100715
		[Token(Token = "0x40153D4")]
		Effect_Map_GimmickFire,
		// Token: 0x0401896C RID: 100716
		[Token(Token = "0x40153D5")]
		Effect_Map_LeverDoor,
		// Token: 0x0401896D RID: 100717
		[Token(Token = "0x40153D6")]
		Effect_Map_GimmickShadow,
		// Token: 0x0401896E RID: 100718
		[Token(Token = "0x40153D7")]
		Effect_Map_ObjBreak01,
		// Token: 0x0401896F RID: 100719
		[Token(Token = "0x40153D8")]
		Effect_Map_ObjBreak02,
		// Token: 0x04018970 RID: 100720
		[Token(Token = "0x40153D9")]
		Effect_Map_ObjBreak03,
		// Token: 0x04018971 RID: 100721
		[Token(Token = "0x40153DA")]
		Effect_Map_GimmickThunder01 = 7062,
		// Token: 0x04018972 RID: 100722
		[Token(Token = "0x40153DB")]
		Effect_Map_GimmickThunder02,
		// Token: 0x04018973 RID: 100723
		[Token(Token = "0x40153DC")]
		Effect_Map_GimmickThunder03,
		// Token: 0x04018974 RID: 100724
		[Token(Token = "0x40153DD")]
		Effect_Event_RuneSphere = 8000,
		// Token: 0x04018975 RID: 100725
		[Token(Token = "0x40153DE")]
		Effect_Event_ConcentrationLine,
		// Token: 0x04018976 RID: 100726
		[Token(Token = "0x40153DF")]
		Effect_Event_ReturnlSmoke = 8003,
		// Token: 0x04018977 RID: 100727
		[Token(Token = "0x40153E0")]
		Effect_Event_DragonRoar,
		// Token: 0x04018978 RID: 100728
		[Token(Token = "0x40153E1")]
		Effect_Event_FlyingWind,
		// Token: 0x04018979 RID: 100729
		[Token(Token = "0x40153E2")]
		Effect_Event_FlapWave,
		// Token: 0x0401897A RID: 100730
		[Token(Token = "0x40153E3")]
		Effect_Event_LandingSmoke,
		// Token: 0x0401897B RID: 100731
		[Token(Token = "0x40153E4")]
		Effect_Event_SoulSphereLight02,
		// Token: 0x0401897C RID: 100732
		[Token(Token = "0x40153E5")]
		Effect_Event_SoulSphereLight01,
		// Token: 0x0401897D RID: 100733
		[Token(Token = "0x40153E6")]
		Effect_Event_ImpactComical,
		// Token: 0x0401897E RID: 100734
		[Token(Token = "0x40153E7")]
		Effect_Event_ImpactComicalSmoke,
		// Token: 0x0401897F RID: 100735
		[Token(Token = "0x40153E8")]
		Effect_Event_Shadow = 8013,
		// Token: 0x04018980 RID: 100736
		[Token(Token = "0x40153E9")]
		Effect_Event_ScrollCloud,
		// Token: 0x04018981 RID: 100737
		[Token(Token = "0x40153EA")]
		Effect_Event_Smoke001,
		// Token: 0x04018982 RID: 100738
		[Token(Token = "0x40153EB")]
		Effect_Event_BossSmoke001,
		// Token: 0x04018983 RID: 100739
		[Token(Token = "0x40153EC")]
		Effect_Event_BossSmoke002,
		// Token: 0x04018984 RID: 100740
		[Token(Token = "0x40153ED")]
		Effect_Event_BossSmoke003,
		// Token: 0x04018985 RID: 100741
		[Token(Token = "0x40153EE")]
		Effect_Event_BossSmoke004,
		// Token: 0x04018986 RID: 100742
		[Token(Token = "0x40153EF")]
		Effect_Event_BossSmoke005,
		// Token: 0x04018987 RID: 100743
		[Token(Token = "0x40153F0")]
		Effect_Event_BossSmoke006,
		// Token: 0x04018988 RID: 100744
		[Token(Token = "0x40153F1")]
		Effect_Event_Smoke002,
		// Token: 0x04018989 RID: 100745
		[Token(Token = "0x40153F2")]
		Effect_Event_Smoke003,
		// Token: 0x0401898A RID: 100746
		[Token(Token = "0x40153F3")]
		Effect_Event_Handcuffs,
		// Token: 0x0401898B RID: 100747
		[Token(Token = "0x40153F4")]
		Effect_Event_AbsorbDarkAura01,
		// Token: 0x0401898C RID: 100748
		[Token(Token = "0x40153F5")]
		Effect_Event_AbsorbDarkAura02,
		// Token: 0x0401898D RID: 100749
		[Token(Token = "0x40153F6")]
		Effect_Event_Explosion,
		// Token: 0x0401898E RID: 100750
		[Token(Token = "0x40153F7")]
		Effect_Screen_Sakura01 = 9000,
		// Token: 0x0401898F RID: 100751
		[Token(Token = "0x40153F8")]
		Effect_InsectHip01 = 9100,
		// Token: 0x04018990 RID: 100752
		[Token(Token = "0x40153F9")]
		Effect_Hotal
	}
}
