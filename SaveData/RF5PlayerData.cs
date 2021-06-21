using System;
using BinaryStream;
using Define;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000ED9 RID: 3801
	[Token(Token = "0x20009BA")]
	public class RF5PlayerData : SaveDataValueBase
	{
		// Token: 0x0600635C RID: 25436 RVA: 0x000214F8 File Offset: 0x0001F6F8
		[Token(Token = "0x600526D")]
		[Address(RVA = "0x1F05480", Offset = "0x1F05581", VA = "0x1F05480")]
		public int GetPlayerBirthSeason()
		{
			return 0;
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x00021510 File Offset: 0x0001F710
		[Token(Token = "0x600526E")]
		[Address(RVA = "0x1F054A0", Offset = "0x1F055A1", VA = "0x1F054A0")]
		public int GetPlayerBirthDay()
		{
			return 0;
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600526F")]
		[Address(RVA = "0x1F054D0", Offset = "0x1F055D1", VA = "0x1F054D0")]
		public void SetPlayerBirthDay(int day, int season)
		{
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005270")]
		[Address(RVA = "0x1F054E0", Offset = "0x1F055E1", VA = "0x1F054E0")]
		public RF5PlayerData()
		{
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005271")]
		[Address(RVA = "0x1F05510", Offset = "0x1F05611", VA = "0x1F05510", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005272")]
		[Address(RVA = "0x1F05660", Offset = "0x1F05761", VA = "0x1F05660", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005273")]
		[Address(RVA = "0x1F05670", Offset = "0x1F05771", VA = "0x1F05670", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005274")]
		[Address(RVA = "0x1F05680", Offset = "0x1F05781", VA = "0x1F05680", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005275")]
		[Address(RVA = "0x1F05880", Offset = "0x1F05981", VA = "0x1F05880")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C336 RID: 49974
		[Token(Token = "0x4009245")]
		[FieldOffset(Offset = "0x10")]
		public int PlayerGold;

		// Token: 0x0400C337 RID: 49975
		[Token(Token = "0x4009246")]
		[FieldOffset(Offset = "0x18")]
		public string PlayerName;

		// Token: 0x0400C338 RID: 49976
		[Token(Token = "0x4009247")]
		[FieldOffset(Offset = "0x20")]
		public bool IsPlayerMale;

		// Token: 0x0400C339 RID: 49977
		[Token(Token = "0x4009248")]
		[FieldOffset(Offset = "0x21")]
		public bool IsPlayerModelMale;

		// Token: 0x0400C33A RID: 49978
		[Token(Token = "0x4009249")]
		[FieldOffset(Offset = "0x24")]
		public VariationNo VariationNo;

		// Token: 0x0400C33B RID: 49979
		[Token(Token = "0x400924A")]
		[FieldOffset(Offset = "0x28")]
		public int PlayerBirthDay;

		// Token: 0x0400C33C RID: 49980
		[Token(Token = "0x400924B")]
		[FieldOffset(Offset = "0x2C")]
		public NPCID MarriedNPCID;

		// Token: 0x0400C33D RID: 49981
		[Token(Token = "0x400924C")]
		[FieldOffset(Offset = "0x30")]
		public int SeedPoint;

		// Token: 0x0400C33E RID: 49982
		[Token(Token = "0x400924D")]
		[FieldOffset(Offset = "0x34")]
		public PoliceRank PoliceRank;

		// Token: 0x0400C33F RID: 49983
		[Token(Token = "0x400924E")]
		[FieldOffset(Offset = "0x38")]
		public int Stone;

		// Token: 0x0400C340 RID: 49984
		[Token(Token = "0x400924F")]
		[FieldOffset(Offset = "0x3C")]
		public int Lumber;

		// Token: 0x0400C341 RID: 49985
		[Token(Token = "0x4009250")]
		[FieldOffset(Offset = "0x40")]
		public int Compost;

		// Token: 0x0400C342 RID: 49986
		[Token(Token = "0x4009251")]
		[FieldOffset(Offset = "0x44")]
		public int Esa;

		// Token: 0x0400C343 RID: 49987
		[Token(Token = "0x4009252")]
		[FieldOffset(Offset = "0x48")]
		public int DailyRecipePan_Bakery;

		// Token: 0x0400C344 RID: 49988
		[Token(Token = "0x4009253")]
		[FieldOffset(Offset = "0x4C")]
		public int DailyRecipePan_Restaurant;

		// Token: 0x0400C345 RID: 49989
		[Token(Token = "0x4009254")]
		[FieldOffset(Offset = "0x50")]
		public int BathroomBlocked;

		// Token: 0x0400C346 RID: 49990
		[Token(Token = "0x4009255")]
		[FieldOffset(Offset = "0x58")]
		public SkillData[] SkillDatas;

		// Token: 0x0400C347 RID: 49991
		[Token(Token = "0x4009256")]
		[FieldOffset(Offset = "0x60")]
		public ActorID DualSmithActor;

		// Token: 0x0400C348 RID: 49992
		[Token(Token = "0x4009257")]
		[FieldOffset(Offset = "0x64")]
		public ActorID DualCookActor;

		// Token: 0x0400C349 RID: 49993
		[Token(Token = "0x4009258")]
		[FieldOffset(Offset = "0x68")]
		public ActorID DualFishingActor;
	}
}
