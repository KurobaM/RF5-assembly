using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EDC RID: 3804
	[Token(Token = "0x20009BC")]
	public class RF5SaveData : SaveDataValueBase
	{
		// Token: 0x0600636D RID: 25453 RVA: 0x00021540 File Offset: 0x0001F740
		[Token(Token = "0x600527E")]
		[Address(RVA = "0x1F05D20", Offset = "0x1F05E21", VA = "0x1F05D20")]
		public bool GetSaveFlag(RF5SaveData.FLAG id)
		{
			return default(bool);
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600527F")]
		[Address(RVA = "0x1F05D40", Offset = "0x1F05E41", VA = "0x1F05D40")]
		public void SetSaveFlag(RF5SaveData.FLAG id, bool value)
		{
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005280")]
		[Address(RVA = "0x1F05D60", Offset = "0x1F05E61", VA = "0x1F05D60")]
		public void InitializeForNewGame()
		{
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005281")]
		[Address(RVA = "0x1EFB510", Offset = "0x1EFB611", VA = "0x1EFB510")]
		public RF5SaveData()
		{
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005282")]
		[Address(RVA = "0x1F062C0", Offset = "0x1F063C1", VA = "0x1F062C0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005283")]
		[Address(RVA = "0x1F06490", Offset = "0x1F06591", VA = "0x1F06490", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005284")]
		[Address(RVA = "0x1F06640", Offset = "0x1F06741", VA = "0x1F06640", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005285")]
		[Address(RVA = "0x1F067F0", Offset = "0x1F068F1", VA = "0x1F067F0", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005286")]
		[Address(RVA = "0x1EFBD60", Offset = "0x1EFBE61", VA = "0x1EFBD60")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005287")]
		[Address(RVA = "0x1EFC000", Offset = "0x1EFC101", VA = "0x1EFC000")]
		public void Reader0001(BinaryReader reader)
		{
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005288")]
		[Address(RVA = "0x1EFC2A0", Offset = "0x1EFC3A1", VA = "0x1EFC2A0")]
		public void Reader0002(BinaryReader reader)
		{
		}

		// Token: 0x0400C359 RID: 50009
		[Token(Token = "0x400925C")]
		[FieldOffset(Offset = "0x10")]
		public int SlotNo;

		// Token: 0x0400C35A RID: 50010
		[Token(Token = "0x400925D")]
		[FieldOffset(Offset = "0x18")]
		public RF5WorldData WorldData;

		// Token: 0x0400C35B RID: 50011
		[Token(Token = "0x400925E")]
		[FieldOffset(Offset = "0x20")]
		public RF5PlayerData PlayerData;

		// Token: 0x0400C35C RID: 50012
		[Token(Token = "0x400925F")]
		[FieldOffset(Offset = "0x28")]
		public RF5EventData EventData;

		// Token: 0x0400C35D RID: 50013
		[Token(Token = "0x4009260")]
		[FieldOffset(Offset = "0x30")]
		public RF5NpcData NpcData;

		// Token: 0x0400C35E RID: 50014
		[Token(Token = "0x4009261")]
		[FieldOffset(Offset = "0x38")]
		public RF5FishingData FishingData;

		// Token: 0x0400C35F RID: 50015
		[Token(Token = "0x4009262")]
		[FieldOffset(Offset = "0x40")]
		public RF5StampData StampData;

		// Token: 0x0400C360 RID: 50016
		[Token(Token = "0x4009263")]
		[FieldOffset(Offset = "0x48")]
		public RF5FurnitureData FurnitureData;

		// Token: 0x0400C361 RID: 50017
		[Token(Token = "0x4009264")]
		[FieldOffset(Offset = "0x50")]
		public RF5BattleData BattleData;

		// Token: 0x0400C362 RID: 50018
		[Token(Token = "0x4009265")]
		[FieldOffset(Offset = "0x58")]
		public RF5ItemData ItemData;

		// Token: 0x0400C363 RID: 50019
		[Token(Token = "0x4009266")]
		[FieldOffset(Offset = "0x60")]
		public RF5FarmSupportMonsterData SupportMonsterData;

		// Token: 0x0400C364 RID: 50020
		[Token(Token = "0x4009267")]
		[FieldOffset(Offset = "0x68")]
		public RF5FarmData FarmData;

		// Token: 0x0400C365 RID: 50021
		[Token(Token = "0x4009268")]
		[FieldOffset(Offset = "0x70")]
		public RF5StatusData StatusData;

		// Token: 0x0400C366 RID: 50022
		[Token(Token = "0x4009269")]
		[FieldOffset(Offset = "0x78")]
		public RF5OrderData OrderData;

		// Token: 0x0400C367 RID: 50023
		[Token(Token = "0x400926A")]
		[FieldOffset(Offset = "0x80")]
		public SaveFlagStorage SaveFlag;

		// Token: 0x0400C368 RID: 50024
		[Token(Token = "0x400926B")]
		[FieldOffset(Offset = "0x88")]
		public RF5MakingData MakingData;

		// Token: 0x0400C369 RID: 50025
		[Token(Token = "0x400926C")]
		[FieldOffset(Offset = "0x90")]
		public RF5PoliceBatchData PoliceBatchData;

		// Token: 0x0400C36A RID: 50026
		[Token(Token = "0x400926D")]
		[FieldOffset(Offset = "0x98")]
		public RF5ItemFlagData ItemFlagData;

		// Token: 0x0400C36B RID: 50027
		[Token(Token = "0x400926E")]
		[FieldOffset(Offset = "0xA0")]
		public RF5BuildData BuildData;

		// Token: 0x0400C36C RID: 50028
		[Token(Token = "0x400926F")]
		[FieldOffset(Offset = "0xA8")]
		public RF5ShippingData ShippingData;

		// Token: 0x0400C36D RID: 50029
		[Token(Token = "0x4009270")]
		[FieldOffset(Offset = "0xB0")]
		public RF5LpocketData LpocketData;

		// Token: 0x0400C36E RID: 50030
		[Token(Token = "0x4009271")]
		[FieldOffset(Offset = "0xB8")]
		public RF5NameData NameData;

		// Token: 0x02000EDD RID: 3805
		[Token(Token = "0x200148C")]
		public enum FLAG
		{
			// Token: 0x0400C370 RID: 50032
			[Token(Token = "0x401BD0A")]
			IsGameCleared,
			// Token: 0x0400C371 RID: 50033
			[Token(Token = "0x401BD0B")]
			Festival_Beans,
			// Token: 0x0400C372 RID: 50034
			[Token(Token = "0x401BD0C")]
			Festival_Buffamo,
			// Token: 0x0400C373 RID: 50035
			[Token(Token = "0x401BD0D")]
			Festival_Pet,
			// Token: 0x0400C374 RID: 50036
			[Token(Token = "0x401BD0E")]
			Festival_Snow,
			// Token: 0x0400C375 RID: 50037
			[Token(Token = "0x401BD0F")]
			Festival_Glutton,
			// Token: 0x0400C376 RID: 50038
			[Token(Token = "0x401BD10")]
			PLAYER_LUNCH,
			// Token: 0x0400C377 RID: 50039
			[Token(Token = "0x401BD11")]
			Done_DualWork_BlackSmith,
			// Token: 0x0400C378 RID: 50040
			[Token(Token = "0x401BD12")]
			Done_DualWork_Cook,
			// Token: 0x0400C379 RID: 50041
			[Token(Token = "0x401BD13")]
			Done_DualWork_Fishing,
			// Token: 0x0400C37A RID: 50042
			[Token(Token = "0x401BD14")]
			IsKilledKillerGriffonToDay,
			// Token: 0x0400C37B RID: 50043
			[Token(Token = "0x401BD15")]
			Recive_Wardrobe,
			// Token: 0x0400C37C RID: 50044
			[Token(Token = "0x401BD16")]
			Length
		}
	}
}
