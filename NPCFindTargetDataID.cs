using System;
using Il2CppDummyDll;

// Token: 0x020003F7 RID: 1015
[Token(Token = "0x2000318")]
[Serializable]
public enum NPCFindTargetDataID
{
	// Token: 0x04002E1C RID: 11804
	[Token(Token = "0x4002AB7")]
	None,
	// Token: 0x04002E1D RID: 11805
	[Token(Token = "0x4002AB8")]
	HateTarget,
	// Token: 0x04002E1E RID: 11806
	[Token(Token = "0x4002AB9")]
	HateTarget_HP0,
	// Token: 0x04002E1F RID: 11807
	[Token(Token = "0x4002ABA")]
	Counterattack,
	// Token: 0x04002E20 RID: 11808
	[Token(Token = "0x4002ABB")]
	SelfHPHigh0,
	// Token: 0x04002E21 RID: 11809
	[Token(Token = "0x4002ABC")]
	SelfHPUnder40,
	// Token: 0x04002E22 RID: 11810
	[Token(Token = "0x4002ABD")]
	SelfHPUnder50,
	// Token: 0x04002E23 RID: 11811
	[Token(Token = "0x4002ABE")]
	SelfHPUnder60,
	// Token: 0x04002E24 RID: 11812
	[Token(Token = "0x4002ABF")]
	SelfHPUnder70,
	// Token: 0x04002E25 RID: 11813
	[Token(Token = "0x4002AC0")]
	SelfHPUnder80,
	// Token: 0x04002E26 RID: 11814
	[Token(Token = "0x4002AC1")]
	PartyHPHigh0,
	// Token: 0x04002E27 RID: 11815
	[Token(Token = "0x4002AC2")]
	PartyHPUnder20,
	// Token: 0x04002E28 RID: 11816
	[Token(Token = "0x4002AC3")]
	PartyHPUnder30,
	// Token: 0x04002E29 RID: 11817
	[Token(Token = "0x4002AC4")]
	PartyHPUnder40,
	// Token: 0x04002E2A RID: 11818
	[Token(Token = "0x4002AC5")]
	PartyHPUnder50,
	// Token: 0x04002E2B RID: 11819
	[Token(Token = "0x4002AC6")]
	PartyPoisonHeal,
	// Token: 0x04002E2C RID: 11820
	[Token(Token = "0x4002AC7")]
	PartySealHeal,
	// Token: 0x04002E2D RID: 11821
	[Token(Token = "0x4002AC8")]
	PartyParalysisHeal,
	// Token: 0x04002E2E RID: 11822
	[Token(Token = "0x4002AC9")]
	PartySleepHeal,
	// Token: 0x04002E2F RID: 11823
	[Token(Token = "0x4002ACA")]
	PartyTrieHeal,
	// Token: 0x04002E30 RID: 11824
	[Token(Token = "0x4002ACB")]
	PartySickHeal,
	// Token: 0x04002E31 RID: 11825
	[Token(Token = "0x4002ACC")]
	Target_Change,
	// Token: 0x04002E32 RID: 11826
	[Token(Token = "0x4002ACD")]
	Target_HPUnder30,
	// Token: 0x04002E33 RID: 11827
	[Token(Token = "0x4002ACE")]
	Target_HPUnder30_Self,
	// Token: 0x04002E34 RID: 11828
	[Token(Token = "0x4002ACF")]
	Target_act000,
	// Token: 0x04002E35 RID: 11829
	[Token(Token = "0x4002AD0")]
	Target_act000_HPUnder50,
	// Token: 0x04002E36 RID: 11830
	[Token(Token = "0x4002AD1")]
	Target_act005,
	// Token: 0x04002E37 RID: 11831
	[Token(Token = "0x4002AD2")]
	Target_act009_HPUnder50,
	// Token: 0x04002E38 RID: 11832
	[Token(Token = "0x4002AD3")]
	Target_act024,
	// Token: 0x04002E39 RID: 11833
	[Token(Token = "0x4002AD4")]
	Target_act024_HPUnder50,
	// Token: 0x04002E3A RID: 11834
	[Token(Token = "0x4002AD5")]
	Target_act025,
	// Token: 0x04002E3B RID: 11835
	[Token(Token = "0x4002AD6")]
	Target_act025_HPUnder50,
	// Token: 0x04002E3C RID: 11836
	[Token(Token = "0x4002AD7")]
	Target_act019_HPUnder50,
	// Token: 0x04002E3D RID: 11837
	[Token(Token = "0x4002AD8")]
	Target_act027,
	// Token: 0x04002E3E RID: 11838
	[Token(Token = "0x4002AD9")]
	Target_act028,
	// Token: 0x04002E3F RID: 11839
	[Token(Token = "0x4002ADA")]
	SelfLv30,
	// Token: 0x04002E40 RID: 11840
	[Token(Token = "0x4002ADB")]
	SelfLvUnder1000,
	// Token: 0x04002E41 RID: 11841
	[Token(Token = "0x4002ADC")]
	act000HPHigh0,
	// Token: 0x04002E42 RID: 11842
	[Token(Token = "0x4002ADD")]
	act000HPUnder40,
	// Token: 0x04002E43 RID: 11843
	[Token(Token = "0x4002ADE")]
	act000HPUnder50,
	// Token: 0x04002E44 RID: 11844
	[Token(Token = "0x4002ADF")]
	act001HPHigh0,
	// Token: 0x04002E45 RID: 11845
	[Token(Token = "0x4002AE0")]
	act001HPUnder50,
	// Token: 0x04002E46 RID: 11846
	[Token(Token = "0x4002AE1")]
	act002HPHigh0,
	// Token: 0x04002E47 RID: 11847
	[Token(Token = "0x4002AE2")]
	act002HPUnder40,
	// Token: 0x04002E48 RID: 11848
	[Token(Token = "0x4002AE3")]
	act008HPHigh0,
	// Token: 0x04002E49 RID: 11849
	[Token(Token = "0x4002AE4")]
	act008HPUnder40,
	// Token: 0x04002E4A RID: 11850
	[Token(Token = "0x4002AE5")]
	act020HPHigh0,
	// Token: 0x04002E4B RID: 11851
	[Token(Token = "0x4002AE6")]
	act020HPUnder50,
	// Token: 0x04002E4C RID: 11852
	[Token(Token = "0x4002AE7")]
	act024HPHigh0,
	// Token: 0x04002E4D RID: 11853
	[Token(Token = "0x4002AE8")]
	act024HPUnder40,
	// Token: 0x04002E4E RID: 11854
	[Token(Token = "0x4002AE9")]
	act000ParalysisHeal,
	// Token: 0x04002E4F RID: 11855
	[Token(Token = "0x4002AEA")]
	act000PoisonHeal,
	// Token: 0x04002E50 RID: 11856
	[Token(Token = "0x4002AEB")]
	act000SealHeal,
	// Token: 0x04002E51 RID: 11857
	[Token(Token = "0x4002AEC")]
	act002ParalysisHeal,
	// Token: 0x04002E52 RID: 11858
	[Token(Token = "0x4002AED")]
	act002PoisonHeal,
	// Token: 0x04002E53 RID: 11859
	[Token(Token = "0x4002AEE")]
	act002SealHeal,
	// Token: 0x04002E54 RID: 11860
	[Token(Token = "0x4002AEF")]
	act008ParalysisHeal,
	// Token: 0x04002E55 RID: 11861
	[Token(Token = "0x4002AF0")]
	act008PoisonHeal,
	// Token: 0x04002E56 RID: 11862
	[Token(Token = "0x4002AF1")]
	act008SealHeal,
	// Token: 0x04002E57 RID: 11863
	[Token(Token = "0x4002AF2")]
	act024ParalysisHeal,
	// Token: 0x04002E58 RID: 11864
	[Token(Token = "0x4002AF3")]
	act024PoisonHeal,
	// Token: 0x04002E59 RID: 11865
	[Token(Token = "0x4002AF4")]
	act024SealHeal,
	// Token: 0x04002E5A RID: 11866
	[Token(Token = "0x4002AF5")]
	SelfParalysisHeal,
	// Token: 0x04002E5B RID: 11867
	[Token(Token = "0x4002AF6")]
	SelfPoisonHeal,
	// Token: 0x04002E5C RID: 11868
	[Token(Token = "0x4002AF7")]
	SelfSealHeal,
	// Token: 0x04002E5D RID: 11869
	[Token(Token = "0x4002AF8")]
	EnemyLv100,
	// Token: 0x04002E5E RID: 11870
	[Token(Token = "0x4002AF9")]
	Max
}
