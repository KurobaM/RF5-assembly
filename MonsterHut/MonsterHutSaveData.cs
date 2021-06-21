using System;
using Farm;
using Il2CppDummyDll;

namespace MonsterHut
{
	// Token: 0x02000F04 RID: 3844
	[Token(Token = "0x20009D5")]
	[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x149770", Offset = "0x149871")]
	public struct MonsterHutSaveData
	{
		// Token: 0x060064D3 RID: 25811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CA")]
		[Address(RVA = "0x2DE7D0", Offset = "0x2DE8D1", VA = "0x2DE7D0")]
		public MonsterHutSaveData(MonsterHutController mhc)
		{
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CB")]
		[Address(RVA = "0x2DE7E0", Offset = "0x2DE8E1", VA = "0x2DE7E0")]
		public MonsterHutSaveData(FarmManager.FARM_ID farmId, int monsterHutPlaceId, int areaReleaseState)
		{
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CC")]
		[Address(RVA = "0x2DE7F0", Offset = "0x2DE8F1", VA = "0x2DE7F0")]
		[Attribute(Name = "SerializationConstructorAttribute", RVA = "0x1ACCC0", Offset = "0x1ACDC1")]
		public MonsterHutSaveData(FarmManager.FARM_ID farmId, bool monsterHutReleaseState, int monsterHutPlaceId, int areaReleaseState, FriendMonsterIDAndHouseID[] monsterIds, ItemID[] yieldItems, int[] yieldLevels)
		{
		}

		// Token: 0x0400C47C RID: 50300
		[Token(Token = "0x4009305")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17F4A0", Offset = "0x17F5A1")]
		public FarmManager.FARM_ID FarmId;

		// Token: 0x0400C47D RID: 50301
		[Token(Token = "0x4009306")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17F4C0", Offset = "0x17F5C1")]
		public bool MonsterHutReleaseState;

		// Token: 0x0400C47E RID: 50302
		[Token(Token = "0x4009307")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17F4E0", Offset = "0x17F5E1")]
		public int MonsterHutPlaceId;

		// Token: 0x0400C47F RID: 50303
		[Token(Token = "0x4009308")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17F500", Offset = "0x17F601")]
		public int AreaReleaseState;

		// Token: 0x0400C480 RID: 50304
		[Token(Token = "0x4009309")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17F520", Offset = "0x17F621")]
		public FriendMonsterIDAndHouseID[] MonsterIds;

		// Token: 0x0400C481 RID: 50305
		[Token(Token = "0x400930A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17F540", Offset = "0x17F641")]
		public ItemID[] YieldItems;

		// Token: 0x0400C482 RID: 50306
		[Token(Token = "0x400930B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17F560", Offset = "0x17F661")]
		public int[] YieldLevels;
	}
}
