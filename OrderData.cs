using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000466 RID: 1126
[Token(Token = "0x2000363")]
[Serializable]
public class OrderData
{
	// Token: 0x17000475 RID: 1141
	// (get) Token: 0x06001B1E RID: 6942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000403")]
	public string OrderTitle
	{
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x20C8030", Offset = "0x20C8131", VA = "0x20C8030")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000476 RID: 1142
	// (get) Token: 0x06001B1F RID: 6943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000404")]
	public string OrderExplain
	{
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x20C8CE0", Offset = "0x20C8DE1", VA = "0x20C8CE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000477 RID: 1143
	// (get) Token: 0x06001B20 RID: 6944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000405")]
	public string OrderHudText
	{
		[Token(Token = "0x600182A")]
		[Address(RVA = "0x20C9110", Offset = "0x20C9211", VA = "0x20C9110")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000478 RID: 1144
	// (get) Token: 0x06001B21 RID: 6945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000406")]
	public string OrderRewardText
	{
		[Token(Token = "0x600182B")]
		[Address(RVA = "0x20C8EC0", Offset = "0x20C8FC1", VA = "0x20C8EC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600182C")]
	[Address(RVA = "0x20C92F0", Offset = "0x20C93F1", VA = "0x20C92F0")]
	public OrderData()
	{
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600182D")]
	[Address(RVA = "0x20C9460", Offset = "0x20C9561", VA = "0x20C9460")]
	public OrderData(OrderMasterData masterData)
	{
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x0000BDD8 File Offset: 0x00009FD8
	[Token(Token = "0x600182E")]
	[Address(RVA = "0x20C97F0", Offset = "0x20C98F1", VA = "0x20C97F0")]
	public bool IsExistOrderData(OrderType orderType, int orderDeliverTarget, int orderTargetType, int orderTargetId, int orderTargetLevel, Place orderTargetPlace, int value1 = 0, int value2 = 0, int value3 = 0)
	{
		return default(bool);
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x0000BDF0 File Offset: 0x00009FF0
	[Token(Token = "0x600182F")]
	[Address(RVA = "0x20C9B00", Offset = "0x20C9C01", VA = "0x20C9B00")]
	public bool CheckItemType(int targetItemID, int targetType)
	{
		return default(bool);
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x0000BE08 File Offset: 0x0000A008
	[Token(Token = "0x6001830")]
	[Address(RVA = "0x20C9F60", Offset = "0x20CA061", VA = "0x20C9F60")]
	private bool CheckGoldenItem(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x0000BE20 File Offset: 0x0000A020
	[Token(Token = "0x6001831")]
	[Address(RVA = "0x20C9F90", Offset = "0x20CA091", VA = "0x20C9F90")]
	private bool CheckBigFlowerItem(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x0000BE38 File Offset: 0x0000A038
	[Token(Token = "0x6001832")]
	[Address(RVA = "0x20C9FC0", Offset = "0x20CA0C1", VA = "0x20C9FC0")]
	private bool CheckFlowerItem(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x0000BE50 File Offset: 0x0000A050
	[Token(Token = "0x6001833")]
	[Address(RVA = "0x20C9FF0", Offset = "0x20CA0F1", VA = "0x20C9FF0")]
	private bool CheckVegetableItem(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x0000BE68 File Offset: 0x0000A068
	[Token(Token = "0x6001834")]
	[Address(RVA = "0x20CA020", Offset = "0x20CA121", VA = "0x20CA020")]
	private bool CheckHavestNonGoldenVegetable(out int count)
	{
		return default(bool);
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x0000BE80 File Offset: 0x0000A080
	[Token(Token = "0x6001835")]
	[Address(RVA = "0x20CA180", Offset = "0x20CA281", VA = "0x20CA180")]
	private bool CheckHarvestAll(out int count)
	{
		return default(bool);
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x0000BE98 File Offset: 0x0000A098
	[Token(Token = "0x6001836")]
	[Address(RVA = "0x20CA2E0", Offset = "0x20CA3E1", VA = "0x20CA2E0")]
	private bool CheckHarvestOtherThanGongohana(out int count)
	{
		return default(bool);
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
	[Token(Token = "0x6001837")]
	[Address(RVA = "0x20C9F10", Offset = "0x20CA011", VA = "0x20C9F10")]
	private bool CheckCuisineItem(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
	[Token(Token = "0x6001838")]
	[Address(RVA = "0x20C9EC0", Offset = "0x20C9FC1", VA = "0x20C9EC0")]
	private bool CheckWeaponItem(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
	[Token(Token = "0x6001839")]
	[Address(RVA = "0x20C9E60", Offset = "0x20C9F61", VA = "0x20C9E60")]
	private bool CheckFarmToolsItem(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
	[Token(Token = "0x600183A")]
	[Address(RVA = "0x20C9E00", Offset = "0x20C9F01", VA = "0x20C9E00")]
	private bool CheckArmorItem(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x0000BF10 File Offset: 0x0000A110
	[Token(Token = "0x600183B")]
	[Address(RVA = "0x20C9DD0", Offset = "0x20C9ED1", VA = "0x20C9DD0")]
	private bool CheckMedicineItem(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x0000BF28 File Offset: 0x0000A128
	[Token(Token = "0x600183C")]
	[Address(RVA = "0x20CA450", Offset = "0x20CA551", VA = "0x20CA450")]
	private bool CheckHarvestItemID(ItemID id)
	{
		return default(bool);
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x0000BF40 File Offset: 0x0000A140
	[Token(Token = "0x600183D")]
	[Address(RVA = "0x20CA4E0", Offset = "0x20CA5E1", VA = "0x20CA4E0")]
	public bool CheckItemSpecialTypeComplete(out int c)
	{
		return default(bool);
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x0000BF58 File Offset: 0x0000A158
	[Token(Token = "0x600183E")]
	[Address(RVA = "0x20C9DB0", Offset = "0x20C9EB1", VA = "0x20C9DB0")]
	public bool CheckDeliveryDestination(int deliverTarget, int orderDeliverTarget, Place orderTargetPlace)
	{
		return default(bool);
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600183F")]
	[Address(RVA = "0x20CA520", Offset = "0x20CA621", VA = "0x20CA520")]
	public void AddOrderTargetCurrentAmount(int _targetAmount = 0)
	{
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x0000BF70 File Offset: 0x0000A170
	[Token(Token = "0x6001840")]
	[Address(RVA = "0x20CAA40", Offset = "0x20CAB41", VA = "0x20CAA40")]
	public bool IsNpcOrder()
	{
		return default(bool);
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x0000BF88 File Offset: 0x0000A188
	[Token(Token = "0x6001841")]
	[Address(RVA = "0x20CAA50", Offset = "0x20CAB51", VA = "0x20CAA50")]
	public bool CheckBoxReward()
	{
		return default(bool);
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001842")]
	[Address(RVA = "0x20CAB50", Offset = "0x20CAC51", VA = "0x20CAB50")]
	public void GetReward()
	{
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
	[Token(Token = "0x6001843")]
	[Address(RVA = "0x20CB180", Offset = "0x20CB281", VA = "0x20CB180")]
	public bool IsGotReward()
	{
		return default(bool);
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
	[Token(Token = "0x6001844")]
	[Address(RVA = "0x20CB190", Offset = "0x20CB291", VA = "0x20CB190")]
	public bool IsComplete()
	{
		return default(bool);
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
	[Token(Token = "0x6001845")]
	[Address(RVA = "0x20CB1C0", Offset = "0x20CB2C1", VA = "0x20CB1C0")]
	public bool IsCompleteOnce()
	{
		return default(bool);
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
	[Token(Token = "0x6001846")]
	[Address(RVA = "0x20CB1D0", Offset = "0x20CB2D1", VA = "0x20CB1D0")]
	public bool IsRandomOrder()
	{
		return default(bool);
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001847")]
	[Address(RVA = "0x20CB1E0", Offset = "0x20CB2E1", VA = "0x20CB1E0")]
	public void SetCompleteDate()
	{
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001848")]
	[Address(RVA = "0x20CB310", Offset = "0x20CB411", VA = "0x20CB310")]
	public void RunOrderAcceptScript()
	{
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001849")]
	[Address(RVA = "0x20CB100", Offset = "0x20CB201", VA = "0x20CB100")]
	private void RunOrderClearScript()
	{
	}

	// Token: 0x04005E41 RID: 24129
	[Token(Token = "0x4005A50")]
	[FieldOffset(Offset = "0x10")]
	public int OrderId;

	// Token: 0x04005E42 RID: 24130
	[Token(Token = "0x4005A51")]
	[FieldOffset(Offset = "0x14")]
	public OrderCategory OrderCategory;

	// Token: 0x04005E43 RID: 24131
	[Token(Token = "0x4005A52")]
	[FieldOffset(Offset = "0x18")]
	public int EventId;

	// Token: 0x04005E44 RID: 24132
	[Token(Token = "0x4005A53")]
	[FieldOffset(Offset = "0x1C")]
	public int OrderNpcId;

	// Token: 0x04005E45 RID: 24133
	[Token(Token = "0x4005A54")]
	[FieldOffset(Offset = "0x20")]
	public int OrderRequestNpcId;

	// Token: 0x04005E46 RID: 24134
	[Token(Token = "0x4005A55")]
	[FieldOffset(Offset = "0x24")]
	public int RandomId;

	// Token: 0x04005E47 RID: 24135
	[Token(Token = "0x4005A56")]
	[FieldOffset(Offset = "0x28")]
	public int OrderNeedRank;

	// Token: 0x04005E48 RID: 24136
	[Token(Token = "0x4005A57")]
	[FieldOffset(Offset = "0x30")]
	public int[] OrderNeedCompOrders;

	// Token: 0x04005E49 RID: 24137
	[Token(Token = "0x4005A58")]
	[FieldOffset(Offset = "0x38")]
	public OrderType OrderType;

	// Token: 0x04005E4A RID: 24138
	[Token(Token = "0x4005A59")]
	[FieldOffset(Offset = "0x3C")]
	public OrderCompleteType OrderCompleteType;

	// Token: 0x04005E4B RID: 24139
	[Token(Token = "0x4005A5A")]
	[FieldOffset(Offset = "0x40")]
	public int OrderWithNpcId;

	// Token: 0x04005E4C RID: 24140
	[Token(Token = "0x4005A5B")]
	[FieldOffset(Offset = "0x44")]
	public int OrderEquipWeapon;

	// Token: 0x04005E4D RID: 24141
	[Token(Token = "0x4005A5C")]
	[FieldOffset(Offset = "0x48")]
	public int OrderTargetSpecialType;

	// Token: 0x04005E4E RID: 24142
	[Token(Token = "0x4005A5D")]
	[FieldOffset(Offset = "0x4C")]
	public int OrderTargetType;

	// Token: 0x04005E4F RID: 24143
	[Token(Token = "0x4005A5E")]
	[FieldOffset(Offset = "0x50")]
	public int OrderTargetId;

	// Token: 0x04005E50 RID: 24144
	[Token(Token = "0x4005A5F")]
	[FieldOffset(Offset = "0x54")]
	public int OrderTargetLv;

	// Token: 0x04005E51 RID: 24145
	[Token(Token = "0x4005A60")]
	[FieldOffset(Offset = "0x58")]
	public int OrderTargetCompleteAmount;

	// Token: 0x04005E52 RID: 24146
	[Token(Token = "0x4005A61")]
	[FieldOffset(Offset = "0x5C")]
	public int OrderDeliverTarget;

	// Token: 0x04005E53 RID: 24147
	[Token(Token = "0x4005A62")]
	[FieldOffset(Offset = "0x60")]
	public int[] OrderOccuredType;

	// Token: 0x04005E54 RID: 24148
	[Token(Token = "0x4005A63")]
	[FieldOffset(Offset = "0x68")]
	public int[] OrderOccuredTypeValue;

	// Token: 0x04005E55 RID: 24149
	[Token(Token = "0x4005A64")]
	[FieldOffset(Offset = "0x70")]
	public int RepeatType;

	// Token: 0x04005E56 RID: 24150
	[Token(Token = "0x4005A65")]
	[FieldOffset(Offset = "0x78")]
	public int[] RewardType;

	// Token: 0x04005E57 RID: 24151
	[Token(Token = "0x4005A66")]
	[FieldOffset(Offset = "0x80")]
	public int[] RewardId;

	// Token: 0x04005E58 RID: 24152
	[Token(Token = "0x4005A67")]
	[FieldOffset(Offset = "0x88")]
	public int[] RewardAmount;

	// Token: 0x04005E59 RID: 24153
	[Token(Token = "0x4005A68")]
	[FieldOffset(Offset = "0x90")]
	public int[] RewardItemLevel;

	// Token: 0x04005E5A RID: 24154
	[Token(Token = "0x4005A69")]
	[FieldOffset(Offset = "0x98")]
	public int[] RewardPosition;

	// Token: 0x04005E5B RID: 24155
	[Token(Token = "0x4005A6A")]
	[FieldOffset(Offset = "0xA0")]
	public int[] HandoutType;

	// Token: 0x04005E5C RID: 24156
	[Token(Token = "0x4005A6B")]
	[FieldOffset(Offset = "0xA8")]
	public int[] HandoutId;

	// Token: 0x04005E5D RID: 24157
	[Token(Token = "0x4005A6C")]
	[FieldOffset(Offset = "0xB0")]
	public int[] HandoutAmount;

	// Token: 0x04005E5E RID: 24158
	[Token(Token = "0x4005A6D")]
	[FieldOffset(Offset = "0xB8")]
	public string OrderEventStartPoint;

	// Token: 0x04005E5F RID: 24159
	[Token(Token = "0x4005A6E")]
	[FieldOffset(Offset = "0xC0")]
	public string OrderAcceptScriptID;

	// Token: 0x04005E60 RID: 24160
	[Token(Token = "0x4005A6F")]
	[FieldOffset(Offset = "0xC8")]
	public string OrderClearScriptID;

	// Token: 0x04005E61 RID: 24161
	[Token(Token = "0x4005A70")]
	[FieldOffset(Offset = "0xD0")]
	public GameFlagData OrderAcceptFlag;

	// Token: 0x04005E62 RID: 24162
	[Token(Token = "0x4005A71")]
	[FieldOffset(Offset = "0xD4")]
	public GameFlagData OrderClearFlag;

	// Token: 0x04005E63 RID: 24163
	[Token(Token = "0x4005A72")]
	[FieldOffset(Offset = "0xD8")]
	public bool RewardUnnecessary;

	// Token: 0x04005E64 RID: 24164
	[Token(Token = "0x4005A73")]
	[FieldOffset(Offset = "0xDC")]
	public int OrderTargetCurrentAmount;

	// Token: 0x04005E65 RID: 24165
	[Token(Token = "0x4005A74")]
	[FieldOffset(Offset = "0xE0")]
	public int CompleteDate;

	// Token: 0x04005E66 RID: 24166
	[Token(Token = "0x4005A75")]
	[FieldOffset(Offset = "0xE4")]
	public bool RecievedOrder;

	// Token: 0x04005E67 RID: 24167
	[Token(Token = "0x4005A76")]
	[FieldOffset(Offset = "0xE5")]
	public bool Completed;

	// Token: 0x04005E68 RID: 24168
	[Token(Token = "0x4005A77")]
	[FieldOffset(Offset = "0xE6")]
	public bool GotReward;

	// Token: 0x04005E69 RID: 24169
	[Token(Token = "0x4005A78")]
	[FieldOffset(Offset = "0xE7")]
	public bool FirstCompleted;

	// Token: 0x04005E6A RID: 24170
	[Token(Token = "0x4005A79")]
	[FieldOffset(Offset = "0xE8")]
	public string CompletedEventStep;

	// Token: 0x04005E6B RID: 24171
	[Token(Token = "0x4005A7A")]
	[FieldOffset(Offset = "0xF0")]
	public OrderHUDBlock OrderHudBlock;
}
