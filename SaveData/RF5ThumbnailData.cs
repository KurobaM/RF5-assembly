using System;
using BinaryStream;
using Define;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EF6 RID: 3830
	[Token(Token = "0x20009CE")]
	public class RF5ThumbnailData : SaveDataValueBase
	{
		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x0600646F RID: 25711 RVA: 0x00021A38 File Offset: 0x0001FC38
		// (set) Token: 0x06006470 RID: 25712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A45")]
		public bool IsSaved
		{
			[Token(Token = "0x600537B")]
			[Address(RVA = "0x1F09FB0", Offset = "0x1F0A0B1", VA = "0x1F09FB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600537C")]
			[Address(RVA = "0x1F09FC0", Offset = "0x1F0A0C1", VA = "0x1F09FC0")]
			set
			{
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06006471 RID: 25713 RVA: 0x00021A50 File Offset: 0x0001FC50
		// (set) Token: 0x06006472 RID: 25714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A46")]
		public SaveState SaveState
		{
			[Token(Token = "0x600537D")]
			[Address(RVA = "0x1F09FE0", Offset = "0x1F0A0E1", VA = "0x1F09FE0")]
			get
			{
				return SaveState.EMPTY;
			}
			[Token(Token = "0x600537E")]
			[Address(RVA = "0x1F09FF0", Offset = "0x1F0A0F1", VA = "0x1F09FF0")]
			set
			{
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06006473 RID: 25715 RVA: 0x00021A68 File Offset: 0x0001FC68
		// (set) Token: 0x06006474 RID: 25716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A47")]
		public Difficulty Difficulty
		{
			[Token(Token = "0x600537F")]
			[Address(RVA = "0x1F0A000", Offset = "0x1F0A101", VA = "0x1F0A000")]
			get
			{
				return Difficulty.Easy;
			}
			[Token(Token = "0x6005380")]
			[Address(RVA = "0x1F0A010", Offset = "0x1F0A111", VA = "0x1F0A010")]
			set
			{
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06006475 RID: 25717 RVA: 0x00021A80 File Offset: 0x0001FC80
		// (set) Token: 0x06006476 RID: 25718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A48")]
		public bool IsPlayerMale
		{
			[Token(Token = "0x6005381")]
			[Address(RVA = "0x1F0A020", Offset = "0x1F0A121", VA = "0x1F0A020")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005382")]
			[Address(RVA = "0x1F0A030", Offset = "0x1F0A131", VA = "0x1F0A030")]
			set
			{
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06006477 RID: 25719 RVA: 0x00021A98 File Offset: 0x0001FC98
		// (set) Token: 0x06006478 RID: 25720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A49")]
		public NPCID MarriedNPCID
		{
			[Token(Token = "0x6005383")]
			[Address(RVA = "0x1F0A050", Offset = "0x1F0A151", VA = "0x1F0A050")]
			get
			{
				return NPCID.Ares;
			}
			[Token(Token = "0x6005384")]
			[Address(RVA = "0x1F0A060", Offset = "0x1F0A161", VA = "0x1F0A060")]
			set
			{
			}
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005385")]
		[Address(RVA = "0x1F09740", Offset = "0x1F09841", VA = "0x1F09740")]
		public RF5ThumbnailData()
		{
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005386")]
		[Address(RVA = "0x1F0A070", Offset = "0x1F0A171", VA = "0x1F0A070", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005387")]
		[Address(RVA = "0x1F0A0A0", Offset = "0x1F0A1A1", VA = "0x1F0A0A0", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005388")]
		[Address(RVA = "0x1F0A0B0", Offset = "0x1F0A1B1", VA = "0x1F0A0B0", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005389")]
		[Address(RVA = "0x1F09960", Offset = "0x1F09A61", VA = "0x1F09960")]
		public void Update(RF5SaveData saveData)
		{
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600538A")]
		[Address(RVA = "0x1F0A0C0", Offset = "0x1F0A1C1", VA = "0x1F0A0C0", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600538B")]
		[Address(RVA = "0x1F09E60", Offset = "0x1F09F61", VA = "0x1F09E60")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C44F RID: 50255
		[Token(Token = "0x40092E4")]
		[FieldOffset(Offset = "0x10")]
		private byte SavedValue;

		// Token: 0x0400C450 RID: 50256
		[Token(Token = "0x40092E5")]
		[FieldOffset(Offset = "0x11")]
		private byte DifficultyValue;

		// Token: 0x0400C451 RID: 50257
		[Token(Token = "0x40092E6")]
		[FieldOffset(Offset = "0x12")]
		private byte IsPlayerMaleValue;

		// Token: 0x0400C452 RID: 50258
		[Token(Token = "0x40092E7")]
		[FieldOffset(Offset = "0x13")]
		private byte MarriedNPCIDValue;

		// Token: 0x0400C453 RID: 50259
		[Token(Token = "0x40092E8")]
		[FieldOffset(Offset = "0x14")]
		public int InGameTimeElapsedTime;

		// Token: 0x0400C454 RID: 50260
		[Token(Token = "0x40092E9")]
		[FieldOffset(Offset = "0x18")]
		public int PlayerLevel;

		// Token: 0x0400C455 RID: 50261
		[Token(Token = "0x40092EA")]
		[FieldOffset(Offset = "0x1C")]
		public FieldPlaceId FieldPlaceId;

		// Token: 0x0400C456 RID: 50262
		[Token(Token = "0x40092EB")]
		[FieldOffset(Offset = "0x20")]
		public int NextMissionId;

		// Token: 0x0400C457 RID: 50263
		[Token(Token = "0x40092EC")]
		[FieldOffset(Offset = "0x28")]
		public string PlayerName;
	}
}
