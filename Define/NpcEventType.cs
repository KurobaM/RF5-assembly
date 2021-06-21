using System;
using Il2CppDummyDll;

namespace Define
{
	// Token: 0x020011FE RID: 4606
	[Token(Token = "0x2000BD2")]
	public enum NpcEventType
	{
		// Token: 0x04018A95 RID: 101013
		[Token(Token = "0x40154FE")]
		None,
		// Token: 0x04018A96 RID: 101014
		[Token(Token = "0x40154FF")]
		Scenario,
		// Token: 0x04018A97 RID: 101015
		[Token(Token = "0x4015500")]
		Daily,
		// Token: 0x04018A98 RID: 101016
		[Token(Token = "0x4015501")]
		Greeting,
		// Token: 0x04018A99 RID: 101017
		[Token(Token = "0x4015502")]
		Event,
		// Token: 0x04018A9A RID: 101018
		[Token(Token = "0x4015503")]
		EventMultiBoys,
		// Token: 0x04018A9B RID: 101019
		[Token(Token = "0x4015504")]
		EventMultiGirls,
		// Token: 0x04018A9C RID: 101020
		[Token(Token = "0x4015505")]
		Order,
		// Token: 0x04018A9D RID: 101021
		[Token(Token = "0x4015506")]
		SubEvent,
		// Token: 0x04018A9E RID: 101022
		[Token(Token = "0x4015507")]
		Debug_SubEvent,
		// Token: 0x04018A9F RID: 101023
		[Token(Token = "0x4015508")]
		Shop,
		// Token: 0x04018AA0 RID: 101024
		[Token(Token = "0x4015509")]
		ByTheWay,
		// Token: 0x04018AA1 RID: 101025
		[Token(Token = "0x401550A")]
		Sick,
		// Token: 0x04018AA2 RID: 101026
		[Token(Token = "0x401550B")]
		Partner,
		// Token: 0x04018AA3 RID: 101027
		[Token(Token = "0x401550C")]
		Milestone,
		// Token: 0x04018AA4 RID: 101028
		[Token(Token = "0x401550D")]
		BirthDay,
		// Token: 0x04018AA5 RID: 101029
		[Token(Token = "0x401550E")]
		SpousesTalk,
		// Token: 0x04018AA6 RID: 101030
		[Token(Token = "0x401550F")]
		SeasonChange,
		// Token: 0x04018AA7 RID: 101031
		[Token(Token = "0x4015510")]
		Object,
		// Token: 0x04018AA8 RID: 101032
		[Token(Token = "0x4015511")]
		Present,
		// Token: 0x04018AA9 RID: 101033
		[Token(Token = "0x4015512")]
		FlagTalk,
		// Token: 0x04018AAA RID: 101034
		[Token(Token = "0x4015513")]
		Hint,
		// Token: 0x04018AAB RID: 101035
		[Token(Token = "0x4015514")]
		BabyBirth,
		// Token: 0x04018AAC RID: 101036
		[Token(Token = "0x4015515")]
		License,
		// Token: 0x04018AAD RID: 101037
		[Token(Token = "0x4015516")]
		Traveler,
		// Token: 0x04018AAE RID: 101038
		[Token(Token = "0x4015517")]
		ScenarioSupport,
		// Token: 0x04018AAF RID: 101039
		[Token(Token = "0x4015518")]
		PartyTalk,
		// Token: 0x04018AB0 RID: 101040
		[Token(Token = "0x4015519")]
		ABSL,
		// Token: 0x04018AB1 RID: 101041
		[Token(Token = "0x401551A")]
		SlipDownTalk,
		// Token: 0x04018AB2 RID: 101042
		[Token(Token = "0x401551B")]
		LogTimeTalk,
		// Token: 0x04018AB3 RID: 101043
		[Token(Token = "0x401551C")]
		Disagreement,
		// Token: 0x04018AB4 RID: 101044
		[Token(Token = "0x401551D")]
		Compliment,
		// Token: 0x04018AB5 RID: 101045
		[Token(Token = "0x401551E")]
		Tease,
		// Token: 0x04018AB6 RID: 101046
		[Token(Token = "0x401551F")]
		Exclamation,
		// Token: 0x04018AB7 RID: 101047
		[Token(Token = "0x4015520")]
		Invite,
		// Token: 0x04018AB8 RID: 101048
		[Token(Token = "0x4015521")]
		Furniture,
		// Token: 0x04018AB9 RID: 101049
		[Token(Token = "0x4015522")]
		Fishing,
		// Token: 0x04018ABA RID: 101050
		[Token(Token = "0x4015523")]
		Tutorial,
		// Token: 0x04018ABB RID: 101051
		[Token(Token = "0x4015524")]
		MonsterDoctor,
		// Token: 0x04018ABC RID: 101052
		[Token(Token = "0x4015525")]
		MobRename,
		// Token: 0x04018ABD RID: 101053
		[Token(Token = "0x4015526")]
		GoodNight,
		// Token: 0x04018ABE RID: 101054
		[Token(Token = "0x4015527")]
		Date,
		// Token: 0x04018ABF RID: 101055
		[Token(Token = "0x4015528")]
		DateWait,
		// Token: 0x04018AC0 RID: 101056
		[Token(Token = "0x4015529")]
		DateRB,
		// Token: 0x04018AC1 RID: 101057
		[Token(Token = "0x401552A")]
		DateRT,
		// Token: 0x04018AC2 RID: 101058
		[Token(Token = "0x401552B")]
		LovEvent,
		// Token: 0x04018AC3 RID: 101059
		[Token(Token = "0x401552C")]
		Dualwork,
		// Token: 0x04018AC4 RID: 101060
		[Token(Token = "0x401552D")]
		RecipePan,
		// Token: 0x04018AC5 RID: 101061
		[Token(Token = "0x401552E")]
		FarmDragon,
		// Token: 0x04018AC6 RID: 101062
		[Token(Token = "0x401552F")]
		kedaruge,
		// Token: 0x04018AC7 RID: 101063
		[Token(Token = "0x4015530")]
		Making,
		// Token: 0x04018AC8 RID: 101064
		[Token(Token = "0x4015531")]
		Makings
	}
}
