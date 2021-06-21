using System;
using System.Collections.Generic;
using BinaryStream;
using Il2CppDummyDll;
using RF5SHIPPING;

namespace SaveData
{
	// Token: 0x02000EDE RID: 3806
	[Token(Token = "0x20009BD")]
	public class RF5ShippingData : SaveDataValueBase
	{
		// Token: 0x06006378 RID: 25464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005289")]
		[Address(RVA = "0x1F06220", Offset = "0x1F06321", VA = "0x1F06220")]
		public RF5ShippingData()
		{
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528A")]
		[Address(RVA = "0x1F07D00", Offset = "0x1F07E01", VA = "0x1F07D00", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528B")]
		[Address(RVA = "0x1F07E90", Offset = "0x1F07F91", VA = "0x1F07E90", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528C")]
		[Address(RVA = "0x1F07EA0", Offset = "0x1F07FA1", VA = "0x1F07EA0", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528D")]
		[Address(RVA = "0x1F07EB0", Offset = "0x1F07FB1", VA = "0x1F07EB0", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528E")]
		[Address(RVA = "0x1F071B0", Offset = "0x1F072B1", VA = "0x1F071B0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528F")]
		private static T Reader0000_internal<T>(BinaryReader reader)
		{
			return null;
		}

		// Token: 0x0400C37D RID: 50045
		[Token(Token = "0x4009272")]
		[FieldOffset(Offset = "0x10")]
		public int completedPercent;

		// Token: 0x0400C37E RID: 50046
		[Token(Token = "0x4009273")]
		[FieldOffset(Offset = "0x18")]
		public long totalIncome;

		// Token: 0x0400C37F RID: 50047
		[Token(Token = "0x4009274")]
		[FieldOffset(Offset = "0x20")]
		public List<ShipmentItemRecords>[] ItemRecordList;

		// Token: 0x0400C380 RID: 50048
		[Token(Token = "0x4009275")]
		[FieldOffset(Offset = "0x28")]
		public List<FishShipmentRecords> FishRecordList;

		// Token: 0x0400C381 RID: 50049
		[Token(Token = "0x4009276")]
		[FieldOffset(Offset = "0x30")]
		public List<SeedLevelRecords> SeedLevelRecordList;

		// Token: 0x0400C382 RID: 50050
		[Token(Token = "0x4009277")]
		[FieldOffset(Offset = "0x38")]
		private readonly int[] CategoryMaxTable;

		// Token: 0x0400C383 RID: 50051
		[Token(Token = "0x4009278")]
		private const int FishShipmentMax = 45;

		// Token: 0x0400C384 RID: 50052
		[Token(Token = "0x4009279")]
		private const int SeedLevelMax = 50;
	}
}
