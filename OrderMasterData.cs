using System;
using Define;
using Il2CppDummyDll;

// Token: 0x0200046C RID: 1132
[Token(Token = "0x2000368")]
[Serializable]
public class OrderMasterData
{
	// Token: 0x06001B91 RID: 7057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001898")]
	[Address(RVA = "0x20D6180", Offset = "0x20D6281", VA = "0x20D6180")]
	public OrderMasterData()
	{
	}

	// Token: 0x04006045 RID: 24645
	[Token(Token = "0x4005C52")]
	[FieldOffset(Offset = "0x10")]
	public int OrderId;

	// Token: 0x04006046 RID: 24646
	[Token(Token = "0x4005C53")]
	[FieldOffset(Offset = "0x14")]
	public OrderCategory OrderCategory;

	// Token: 0x04006047 RID: 24647
	[Token(Token = "0x4005C54")]
	[FieldOffset(Offset = "0x18")]
	public int EventId;

	// Token: 0x04006048 RID: 24648
	[Token(Token = "0x4005C55")]
	[FieldOffset(Offset = "0x1C")]
	public int OrderNpcId;

	// Token: 0x04006049 RID: 24649
	[Token(Token = "0x4005C56")]
	[FieldOffset(Offset = "0x20")]
	public int OrderRequestNpcId;

	// Token: 0x0400604A RID: 24650
	[Token(Token = "0x4005C57")]
	[FieldOffset(Offset = "0x24")]
	public int RandomId;

	// Token: 0x0400604B RID: 24651
	[Token(Token = "0x4005C58")]
	[FieldOffset(Offset = "0x28")]
	public int OrderNeedRank;

	// Token: 0x0400604C RID: 24652
	[Token(Token = "0x4005C59")]
	[FieldOffset(Offset = "0x30")]
	public int[] OrderNeedCompOrders;

	// Token: 0x0400604D RID: 24653
	[Token(Token = "0x4005C5A")]
	[FieldOffset(Offset = "0x38")]
	public OrderType OrderType;

	// Token: 0x0400604E RID: 24654
	[Token(Token = "0x4005C5B")]
	[FieldOffset(Offset = "0x3C")]
	public OrderCompleteType OrderCompleteType;

	// Token: 0x0400604F RID: 24655
	[Token(Token = "0x4005C5C")]
	[FieldOffset(Offset = "0x40")]
	public int OrderWithNpcId;

	// Token: 0x04006050 RID: 24656
	[Token(Token = "0x4005C5D")]
	[FieldOffset(Offset = "0x44")]
	public int OrderEquipWeapon;

	// Token: 0x04006051 RID: 24657
	[Token(Token = "0x4005C5E")]
	[FieldOffset(Offset = "0x48")]
	public int OrderTargetSpecialType;

	// Token: 0x04006052 RID: 24658
	[Token(Token = "0x4005C5F")]
	[FieldOffset(Offset = "0x4C")]
	public int OrderTargetType;

	// Token: 0x04006053 RID: 24659
	[Token(Token = "0x4005C60")]
	[FieldOffset(Offset = "0x50")]
	public int OrderTargetId;

	// Token: 0x04006054 RID: 24660
	[Token(Token = "0x4005C61")]
	[FieldOffset(Offset = "0x54")]
	public int OrderTargetLv;

	// Token: 0x04006055 RID: 24661
	[Token(Token = "0x4005C62")]
	[FieldOffset(Offset = "0x58")]
	public int OrderTargetCompleteAmount;

	// Token: 0x04006056 RID: 24662
	[Token(Token = "0x4005C63")]
	[FieldOffset(Offset = "0x5C")]
	public int OrderDeliverTarget;

	// Token: 0x04006057 RID: 24663
	[Token(Token = "0x4005C64")]
	[FieldOffset(Offset = "0x60")]
	public int[] OrderOccuredType;

	// Token: 0x04006058 RID: 24664
	[Token(Token = "0x4005C65")]
	[FieldOffset(Offset = "0x68")]
	public int[] OrderOccuredTypeValue;

	// Token: 0x04006059 RID: 24665
	[Token(Token = "0x4005C66")]
	[FieldOffset(Offset = "0x70")]
	public int RepeatType;

	// Token: 0x0400605A RID: 24666
	[Token(Token = "0x4005C67")]
	[FieldOffset(Offset = "0x78")]
	public int[] RewardType;

	// Token: 0x0400605B RID: 24667
	[Token(Token = "0x4005C68")]
	[FieldOffset(Offset = "0x80")]
	public int[] RewardId;

	// Token: 0x0400605C RID: 24668
	[Token(Token = "0x4005C69")]
	[FieldOffset(Offset = "0x88")]
	public int[] RewardAmount;

	// Token: 0x0400605D RID: 24669
	[Token(Token = "0x4005C6A")]
	[FieldOffset(Offset = "0x90")]
	public int[] RewardItemLevel;

	// Token: 0x0400605E RID: 24670
	[Token(Token = "0x4005C6B")]
	[FieldOffset(Offset = "0x98")]
	public int[] RewardPosition;

	// Token: 0x0400605F RID: 24671
	[Token(Token = "0x4005C6C")]
	[FieldOffset(Offset = "0xA0")]
	public int[] HandoutType;

	// Token: 0x04006060 RID: 24672
	[Token(Token = "0x4005C6D")]
	[FieldOffset(Offset = "0xA8")]
	public int[] HandoutId;

	// Token: 0x04006061 RID: 24673
	[Token(Token = "0x4005C6E")]
	[FieldOffset(Offset = "0xB0")]
	public int[] HandoutAmount;

	// Token: 0x04006062 RID: 24674
	[Token(Token = "0x4005C6F")]
	[FieldOffset(Offset = "0xB8")]
	public string OrderEventStartPoint;

	// Token: 0x04006063 RID: 24675
	[Token(Token = "0x4005C70")]
	[FieldOffset(Offset = "0xC0")]
	public string OrderAcceptScriptID;

	// Token: 0x04006064 RID: 24676
	[Token(Token = "0x4005C71")]
	[FieldOffset(Offset = "0xC8")]
	public string OrderClearScriptID;

	// Token: 0x04006065 RID: 24677
	[Token(Token = "0x4005C72")]
	[FieldOffset(Offset = "0xD0")]
	public GameFlagData OrderAcceptFlag;

	// Token: 0x04006066 RID: 24678
	[Token(Token = "0x4005C73")]
	[FieldOffset(Offset = "0xD4")]
	public GameFlagData OrderClearFlag;

	// Token: 0x04006067 RID: 24679
	[Token(Token = "0x4005C74")]
	[FieldOffset(Offset = "0xD8")]
	public bool RewardUnnecessary;
}
