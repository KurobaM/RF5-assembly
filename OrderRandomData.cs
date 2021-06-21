using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x0200046E RID: 1134
[Token(Token = "0x200036A")]
public class OrderRandomData
{
	// Token: 0x06001B93 RID: 7059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600189A")]
	[Address(RVA = "0x20D5FC0", Offset = "0x20D60C1", VA = "0x20D5FC0")]
	public OrderRandomData(PublicationPlace place, int offerMax = 1)
	{
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600189B")]
	[Address(RVA = "0x20D42F0", Offset = "0x20D43F1", VA = "0x20D42F0")]
	public void InitializeLottery()
	{
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600189C")]
	[Address(RVA = "0x20CD100", Offset = "0x20CD201", VA = "0x20CD100")]
	public void AddOrderData(OrderMasterData data)
	{
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600189D")]
	[Address(RVA = "0x20D6B90", Offset = "0x20D6C91", VA = "0x20D6B90")]
	public void ApplyLotteryData(OrderMasterData master)
	{
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600189E")]
	[Address(RVA = "0x20D6C20", Offset = "0x20D6D21", VA = "0x20D6C20")]
	public void ApplyLotteryData(OrderData data)
	{
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600189F")]
	[Address(RVA = "0x20CEC00", Offset = "0x20CED01", VA = "0x20CEC00")]
	public void LotteryOnDay(List<OrderData> accDatas, [Optional] List<OrderData> lotteryOrder)
	{
	}

	// Token: 0x06001B99 RID: 7065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018A0")]
	[Address(RVA = "0x20D74D0", Offset = "0x20D75D1", VA = "0x20D74D0")]
	private void LotteryBoard()
	{
	}

	// Token: 0x06001B9A RID: 7066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018A1")]
	[Address(RVA = "0x20D7200", Offset = "0x20D7301", VA = "0x20D7200")]
	private void LotteryTantei(List<OrderData> lotteryOrder)
	{
	}

	// Token: 0x06001B9B RID: 7067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018A2")]
	[Address(RVA = "0x20D6D80", Offset = "0x20D6E81", VA = "0x20D6D80")]
	private void LotteryNpc()
	{
	}

	// Token: 0x06001B9C RID: 7068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018A3")]
	[Address(RVA = "0x20D7560", Offset = "0x20D7661", VA = "0x20D7560")]
	public OrderData LotteryData()
	{
		return null;
	}

	// Token: 0x06001B9D RID: 7069 RVA: 0x0000C318 File Offset: 0x0000A518
	[Token(Token = "0x60018A4")]
	[Address(RVA = "0x20D81C0", Offset = "0x20D82C1", VA = "0x20D81C0")]
	public bool IsOrderRandamID(int npcId, int randomType)
	{
		return default(bool);
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018A5")]
	[Address(RVA = "0x20D7B80", Offset = "0x20D7C81", VA = "0x20D7B80")]
	public OrderData LotteryData(int npcId, int randomType)
	{
		return null;
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018A6")]
	[Address(RVA = "0x20CEA30", Offset = "0x20CEB31", VA = "0x20CEA30")]
	public OrderMasterData GetMasterData_Board(int orderId, int npcId = -1, int orderType = 0)
	{
		return null;
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018A7")]
	[Address(RVA = "0x20D06D0", Offset = "0x20D07D1", VA = "0x20D06D0")]
	public OrderMasterData GetMasterData_Npc(int orderId, int npcId = -1, int randomId = 0)
	{
		return null;
	}

	// Token: 0x06001BA1 RID: 7073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018A8")]
	[Address(RVA = "0x20D7570", Offset = "0x20D7671", VA = "0x20D7570")]
	private OrderMasterData GetMasterData(int orderId, int npcId = -1, int type = 0)
	{
		return null;
	}

	// Token: 0x06001BA2 RID: 7074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018A9")]
	[Address(RVA = "0x20D8280", Offset = "0x20D8381", VA = "0x20D8280")]
	public OrderData GetLotteryDatasByIndex(int index)
	{
		return null;
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018AA")]
	[Address(RVA = "0x20D8330", Offset = "0x20D8431", VA = "0x20D8330")]
	public OrderData GetLotteryDatasById(int id)
	{
		return null;
	}

	// Token: 0x0400606B RID: 24683
	[Token(Token = "0x4005C78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Dictionary<int, Dictionary<int, List<OrderMasterData>>> OrderRandomDatas;

	// Token: 0x0400606C RID: 24684
	[Token(Token = "0x4005C79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<OrderData> LotteryDatas;

	// Token: 0x0400606D RID: 24685
	[Token(Token = "0x4005C7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<int> keysList;

	// Token: 0x0400606E RID: 24686
	[Token(Token = "0x4005C7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<int> keysList2;

	// Token: 0x0400606F RID: 24687
	[Token(Token = "0x4005C7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int OfferMax;

	// Token: 0x04006070 RID: 24688
	[Token(Token = "0x4005C7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private PublicationPlace PublicationType;
}
