using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200046A RID: 1130
[Token(Token = "0x2000367")]
[Serializable]
public class OrderManager : SingletonMonoBehaviour<OrderManager>
{
	// Token: 0x06001B40 RID: 6976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600184A")]
	[Address(RVA = "0x20CC6E0", Offset = "0x20CC7E1", VA = "0x20CC6E0")]
	public void SetPublicationPlace(PublicationPlace place)
	{
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x0000C000 File Offset: 0x0000A200
	[Token(Token = "0x600184B")]
	[Address(RVA = "0x20CC6F0", Offset = "0x20CC7F1", VA = "0x20CC6F0")]
	public PublicationPlace GetPublicationPlace()
	{
		return PublicationPlace.PoliceBoard;
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x0000C018 File Offset: 0x0000A218
	[Token(Token = "0x600184C")]
	[Address(RVA = "0x20CC700", Offset = "0x20CC801", VA = "0x20CC700")]
	public int AcceptOrderNum()
	{
		return 0;
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x0000C030 File Offset: 0x0000A230
	[Token(Token = "0x600184D")]
	[Address(RVA = "0x20CC810", Offset = "0x20CC911", VA = "0x20CC810")]
	public bool CheckAcceptOrderNum()
	{
		return default(bool);
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600184E")]
	[Address(RVA = "0x20CC830", Offset = "0x20CC931", VA = "0x20CC830", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001B45 RID: 6981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600184F")]
	[Address(RVA = "0x20CC890", Offset = "0x20CC991", VA = "0x20CC890")]
	private void Start()
	{
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001850")]
	[Address(RVA = "0x20CE150", Offset = "0x20CE251", VA = "0x20CE150")]
	protected void OnDestroy()
	{
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001851")]
	[Address(RVA = "0x20CE250", Offset = "0x20CE351", VA = "0x20CE250")]
	public List<OrderData> CreatePublishedOrderList(PublicationPlace place)
	{
		return null;
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x0000C048 File Offset: 0x0000A248
	[Token(Token = "0x6001852")]
	[Address(RVA = "0x20CE500", Offset = "0x20CE601", VA = "0x20CE500")]
	public int CreatePublishedPoliceOrderList()
	{
		return 0;
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x0000C060 File Offset: 0x0000A260
	[Token(Token = "0x6001853")]
	[Address(RVA = "0x20CE730", Offset = "0x20CE831", VA = "0x20CE730")]
	public int CreatePublishedDetectiveOrderList()
	{
		return 0;
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001854")]
	[Address(RVA = "0x20CE2E0", Offset = "0x20CE3E1", VA = "0x20CE2E0")]
	public void LotteryOnDay(int diff)
	{
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001855")]
	[Address(RVA = "0x20CEF00", Offset = "0x20CF001", VA = "0x20CEF00")]
	public OrderMasterData GetMasterData(int orderId, int npcid = -1)
	{
		return null;
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x0000C078 File Offset: 0x0000A278
	[Token(Token = "0x6001856")]
	[Address(RVA = "0x20CB2A0", Offset = "0x20CB3A1", VA = "0x20CB2A0")]
	public int GetNowDateForCompleteDate()
	{
		return 0;
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x0000C090 File Offset: 0x0000A290
	[Token(Token = "0x6001857")]
	[Address(RVA = "0x20CF210", Offset = "0x20CF311", VA = "0x20CF210")]
	public bool CheckTimeOverDiff(int date, int diffDay)
	{
		return default(bool);
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
	[Token(Token = "0x6001858")]
	[Address(RVA = "0x20CEB80", Offset = "0x20CEC81", VA = "0x20CEB80")]
	public bool IsRepeatOccured(OrderData orderData, [Optional] OrderMasterData orderMasterData)
	{
		return default(bool);
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
	[Token(Token = "0x6001859")]
	[Address(RVA = "0x20CF310", Offset = "0x20CF411", VA = "0x20CF310")]
	public int GetCompleteNum()
	{
		return 0;
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
	[Token(Token = "0x600185A")]
	[Address(RVA = "0x20CF420", Offset = "0x20CF521", VA = "0x20CF420")]
	public bool IsOrderGotReward(int orderId, int npcId = -1)
	{
		return default(bool);
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
	[Token(Token = "0x600185B")]
	[Address(RVA = "0x20CF5C0", Offset = "0x20CF6C1", VA = "0x20CF5C0")]
	private bool IsOrderOccured(OrderMasterData orderData, int npcId)
	{
		return default(bool);
	}

	// Token: 0x06001B52 RID: 6994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600185C")]
	[Address(RVA = "0x20CFB90", Offset = "0x20CFC91", VA = "0x20CFB90")]
	public OrderMasterData GetOccuredOrder(int eventId, int npcId)
	{
		return null;
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600185D")]
	[Address(RVA = "0x20D0080", Offset = "0x20D0181", VA = "0x20D0080")]
	public OrderMasterData GetOccuredNpcRadnomOrder(int eventId, int npcId)
	{
		return null;
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x0000C108 File Offset: 0x0000A308
	[Token(Token = "0x600185E")]
	[Address(RVA = "0x20CE960", Offset = "0x20CEA61", VA = "0x20CE960")]
	public bool IsOccuredOrderBoard(OrderData orderData)
	{
		return default(bool);
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x0000C120 File Offset: 0x0000A320
	[Token(Token = "0x600185F")]
	[Address(RVA = "0x20CEA40", Offset = "0x20CEB41", VA = "0x20CEA40")]
	public bool IsOccuredOrderBoard(OrderMasterData retOrderData)
	{
		return default(bool);
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001860")]
	[Address(RVA = "0x20D0830", Offset = "0x20D0931", VA = "0x20D0830")]
	public OrderData AddOrder(int questIdx)
	{
		return null;
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001861")]
	[Address(RVA = "0x20CFF30", Offset = "0x20D0031", VA = "0x20CFF30")]
	public OrderData GetOrderData(int eventId, int npcId, int orderId)
	{
		return null;
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001862")]
	[Address(RVA = "0x20D0A20", Offset = "0x20D0B21", VA = "0x20D0A20")]
	public OrderData GetAcceptingOrderData(int npcId)
	{
		return null;
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001863")]
	[Address(RVA = "0x20D0B50", Offset = "0x20D0C51", VA = "0x20D0B50")]
	public OrderData GetAcceptOrderData(int orderId)
	{
		return null;
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x0000C138 File Offset: 0x0000A338
	[Token(Token = "0x6001864")]
	[Address(RVA = "0x20D0C70", Offset = "0x20D0D71", VA = "0x20D0C70")]
	public int GetOrderTargetCurrentAmount(int npcId, int orderId)
	{
		return 0;
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001865")]
	[Address(RVA = "0x20D0DA0", Offset = "0x20D0EA1", VA = "0x20D0DA0")]
	public void CompletedAllOrder(int orderId)
	{
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x0000C150 File Offset: 0x0000A350
	[Token(Token = "0x6001866")]
	[Address(RVA = "0x20D0EC0", Offset = "0x20D0FC1", VA = "0x20D0EC0")]
	public bool IsSPOrderAccept(int npcId)
	{
		return default(bool);
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x0000C168 File Offset: 0x0000A368
	[Token(Token = "0x6001867")]
	[Address(RVA = "0x20D1000", Offset = "0x20D1101", VA = "0x20D1000")]
	public bool ProceedWithOrder(OrderType orderType, int npcId, int targetId, GameObject gameObject, ItemData item)
	{
		return default(bool);
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x0000C180 File Offset: 0x0000A380
	[Token(Token = "0x6001868")]
	[Address(RVA = "0x20D09A0", Offset = "0x20D0AA1", VA = "0x20D09A0")]
	public bool IsExistOrderData(OrderData orderData)
	{
		return default(bool);
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x0000C198 File Offset: 0x0000A398
	[Token(Token = "0x6001869")]
	[Address(RVA = "0x20D1B50", Offset = "0x20D1C51", VA = "0x20D1B50")]
	public bool IsExistOrderData(OrderMasterData orderData)
	{
		return default(bool);
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
	[Token(Token = "0x600186A")]
	[Address(RVA = "0x20D19D0", Offset = "0x20D1AD1", VA = "0x20D19D0")]
	public bool IsExistOrderData(int currentEventId, int orderNpcId, int orderId, int orderCompleteType, int orderTargetType, int orderTargetId)
	{
		return default(bool);
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
	[Token(Token = "0x600186B")]
	[Address(RVA = "0x20D1B80", Offset = "0x20D1C81", VA = "0x20D1B80")]
	public bool CheckExistMonsterGetOrderData(int MonsterId)
	{
		return default(bool);
	}

	// Token: 0x06001B62 RID: 7010 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
	[Token(Token = "0x600186C")]
	[Address(RVA = "0x20D1D70", Offset = "0x20D1E71", VA = "0x20D1D70")]
	private int GetCurrentValue_OrderTargetCurrentAmount(OrderData orderData)
	{
		return 0;
	}

	// Token: 0x06001B63 RID: 7011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600186D")]
	[Address(RVA = "0x20D2290", Offset = "0x20D2391", VA = "0x20D2290")]
	public OrderData AddOrderData(OrderMasterData masterData, string completedEventStep)
	{
		return null;
	}

	// Token: 0x06001B64 RID: 7012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600186E")]
	[Address(RVA = "0x20D09D0", Offset = "0x20D0AD1", VA = "0x20D09D0")]
	public OrderData AddOrderData(OrderData data, string completedEventStep)
	{
		return null;
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600186F")]
	[Address(RVA = "0x20D2330", Offset = "0x20D2431", VA = "0x20D2330")]
	private OrderData AddAcceptOrderData(OrderData data)
	{
		return null;
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001870")]
	[Address(RVA = "0x20D2A40", Offset = "0x20D2B41", VA = "0x20D2A40")]
	public void RegistBoardOrderData(int id, int orderId)
	{
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
	[Token(Token = "0x6001871")]
	[Address(RVA = "0x20D2CB0", Offset = "0x20D2DB1", VA = "0x20D2CB0")]
	public bool RegistOrderData(int npcId, int orderId, string CompletedEventStep)
	{
		return default(bool);
	}

	// Token: 0x06001B68 RID: 7016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001872")]
	[Address(RVA = "0x20D2F40", Offset = "0x20D3041", VA = "0x20D2F40")]
	public void RegistRandomOrderData(int npcId, string CompletedEventStep)
	{
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001873")]
	[Address(RVA = "0x20D3080", Offset = "0x20D3181", VA = "0x20D3080")]
	public void ForceQuestReward(int orderId)
	{
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001874")]
	[Address(RVA = "0x20C79C0", Offset = "0x20C7AC1", VA = "0x20C79C0")]
	public void GetQuestReward(int npcId, int orderId)
	{
	}

	// Token: 0x06001B6B RID: 7019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001875")]
	[Address(RVA = "0x20D3310", Offset = "0x20D3411", VA = "0x20D3310")]
	private void ReceiveReward(OrderData orderData, int orderId)
	{
	}

	// Token: 0x06001B6C RID: 7020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001876")]
	[Address(RVA = "0x20D06E0", Offset = "0x20D07E1", VA = "0x20D06E0")]
	public OrderMasterData GetOrderMasterData(int npcId, int orderId)
	{
		return null;
	}

	// Token: 0x06001B6D RID: 7021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001877")]
	[Address(RVA = "0x20D3290", Offset = "0x20D3391", VA = "0x20D3290")]
	public OrderMasterData GetRandomOrderMasterData(int npcId, int orderId, OrderData data)
	{
		return null;
	}

	// Token: 0x06001B6E RID: 7022 RVA: 0x0000C210 File Offset: 0x0000A410
	[Token(Token = "0x6001878")]
	[Address(RVA = "0x20C7870", Offset = "0x20C7971", VA = "0x20C7870")]
	public int GetOrderIdCanReward(int npcId)
	{
		return 0;
	}

	// Token: 0x06001B6F RID: 7023 RVA: 0x0000C228 File Offset: 0x0000A428
	[Token(Token = "0x6001879")]
	[Address(RVA = "0x20D39A0", Offset = "0x20D3AA1", VA = "0x20D39A0")]
	public bool CheckCanOrderFailure(int orderId)
	{
		return default(bool);
	}

	// Token: 0x06001B70 RID: 7024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187A")]
	[Address(RVA = "0x20D3B00", Offset = "0x20D3C01", VA = "0x20D3B00")]
	public void OrderFailureByOrderId(int orderId)
	{
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187B")]
	[Address(RVA = "0x20D3D30", Offset = "0x20D3E31", VA = "0x20D3D30")]
	public void OrderFailureByIndex(int index)
	{
	}

	// Token: 0x06001B72 RID: 7026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187C")]
	[Address(RVA = "0x20D3DC0", Offset = "0x20D3EC1", VA = "0x20D3DC0")]
	public void SPOrderFailure(int npcId)
	{
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187D")]
	[Address(RVA = "0x20D4140", Offset = "0x20D4241", VA = "0x20D4140")]
	public void OrderDataInitialize()
	{
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187E")]
	[Address(RVA = "0x20CD2E0", Offset = "0x20CD3E1", VA = "0x20CD2E0")]
	public void ApplyOrderSaveData()
	{
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600187F")]
	[Address(RVA = "0x20D4350", Offset = "0x20D4451", VA = "0x20D4350")]
	private OrderData GetApplyRandomOrderData(int orderId)
	{
		return null;
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001880")]
	[Address(RVA = "0x20D46C0", Offset = "0x20D47C1", VA = "0x20D46C0")]
	public void SaveOrderSaveData()
	{
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001881")]
	[Address(RVA = "0x20D5320", Offset = "0x20D5421", VA = "0x20D5320")]
	public string GetOrderTargetName(int npcId, int orderId)
	{
		return null;
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001882")]
	[Address(RVA = "0x20D53B0", Offset = "0x20D54B1", VA = "0x20D53B0")]
	private string GetOrderTargetNameBase(OrderType type, int targetId)
	{
		return null;
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001883")]
	[Address(RVA = "0x20D5580", Offset = "0x20D5681", VA = "0x20D5580")]
	public string GetOrderTargetNameForOverWrite()
	{
		return null;
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x0000C240 File Offset: 0x0000A440
	[Token(Token = "0x6001884")]
	[Address(RVA = "0x20D56D0", Offset = "0x20D57D1", VA = "0x20D56D0")]
	public int GetOrderTargetIdForOverWrite()
	{
		return 0;
	}

	// Token: 0x06001B7B RID: 7035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001885")]
	[Address(RVA = "0x20D5800", Offset = "0x20D5901", VA = "0x20D5800")]
	private string GetOrderRewardNameBase(int rewardType, int rewardId)
	{
		return null;
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001886")]
	[Address(RVA = "0x20D5B00", Offset = "0x20D5C01", VA = "0x20D5B00")]
	public string GetOrderRequestNpcName()
	{
		return null;
	}

	// Token: 0x06001B7D RID: 7037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001887")]
	[Address(RVA = "0x20D5BA0", Offset = "0x20D5CA1", VA = "0x20D5BA0")]
	public string GetOrderRewardNameForOverWrite(int idx = 0)
	{
		return null;
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x0000C258 File Offset: 0x0000A458
	[Token(Token = "0x6001888")]
	[Address(RVA = "0x20D5CD0", Offset = "0x20D5DD1", VA = "0x20D5CD0")]
	public int GetOrderRewardNumForOverWrite(int idx = 0)
	{
		return 0;
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001889")]
	[Address(RVA = "0x20D5DC0", Offset = "0x20D5EC1", VA = "0x20D5DC0")]
	public string Debug_AcceptOrderDatasView()
	{
		return null;
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600188A")]
	[Address(RVA = "0x20D5E10", Offset = "0x20D5F11", VA = "0x20D5E10")]
	public void DEBUG_Lottery()
	{
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600188B")]
	[Address(RVA = "0x20D5E20", Offset = "0x20D5F21", VA = "0x20D5E20")]
	public void DEBUG_RegistOrderData(int orderId)
	{
	}

	// Token: 0x06001B82 RID: 7042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600188C")]
	[Address(RVA = "0x20D5E30", Offset = "0x20D5F31", VA = "0x20D5E30")]
	public void DEBUG_ReleaseOrder(int orderId)
	{
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600188D")]
	[Address(RVA = "0x20D5E40", Offset = "0x20D5F41", VA = "0x20D5E40")]
	public void DEBUG_ClearOrder()
	{
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x0000C270 File Offset: 0x0000A470
	[Token(Token = "0x600188E")]
	[Address(RVA = "0x20D5E50", Offset = "0x20D5F51", VA = "0x20D5E50")]
	public int DEBUG_GetOrderIdByIndex(int index)
	{
		return 0;
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x0000C288 File Offset: 0x0000A488
	[Token(Token = "0x600188F")]
	[Address(RVA = "0x20D5E60", Offset = "0x20D5F61", VA = "0x20D5E60")]
	public int DEBUG_OrderNum()
	{
		return 0;
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
	[Token(Token = "0x6001890")]
	[Address(RVA = "0x20D5E70", Offset = "0x20D5F71", VA = "0x20D5E70")]
	public int DEBUG_GetPublishedBoardOrderIdByIndex(int index)
	{
		return 0;
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
	[Token(Token = "0x6001891")]
	[Address(RVA = "0x20D5E80", Offset = "0x20D5F81", VA = "0x20D5E80")]
	public int DEBUG_PublishedBoardOrderNum()
	{
		return 0;
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
	[Token(Token = "0x6001892")]
	[Address(RVA = "0x20D5E90", Offset = "0x20D5F91", VA = "0x20D5E90")]
	public int DEBUG_NPCRandomOrderIdByIndex(int index)
	{
		return 0;
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
	[Token(Token = "0x6001893")]
	[Address(RVA = "0x20D5EA0", Offset = "0x20D5FA1", VA = "0x20D5EA0")]
	public int DEBUG_NPCRandomOrderNum()
	{
		return 0;
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001894")]
	[Address(RVA = "0x20D5EB0", Offset = "0x20D5FB1", VA = "0x20D5EB0")]
	public void DEBUG_AcceptOrdersComplete()
	{
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001895")]
	[Address(RVA = "0x20D5EC0", Offset = "0x20D5FC1", VA = "0x20D5EC0")]
	public List<int> DEBUG_NpcRandomOrderIDList()
	{
		return null;
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001896")]
	[Address(RVA = "0x20D5ED0", Offset = "0x20D5FD1", VA = "0x20D5ED0")]
	public void DEBUG_NPCRegistRandomOrderId(int id)
	{
	}

	// Token: 0x06001B8D RID: 7053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001897")]
	[Address(RVA = "0x20D5EE0", Offset = "0x20D5FE1", VA = "0x20D5EE0")]
	public OrderManager()
	{
	}

	// Token: 0x04006032 RID: 24626
	[Token(Token = "0x4005C41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PublicationPlace AccessPlace;

	// Token: 0x04006033 RID: 24627
	[Token(Token = "0x4005C42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private bool Is1stLottery;

	// Token: 0x04006034 RID: 24628
	[Token(Token = "0x4005C43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int OperationOrderID;

	// Token: 0x04006035 RID: 24629
	[Token(Token = "0x4005C44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<OrderData> AcceptOrderDatas;

	// Token: 0x04006036 RID: 24630
	[Token(Token = "0x4005C45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<OrderData> AcceptOrderDatasHUDBlock;

	// Token: 0x04006037 RID: 24631
	[Token(Token = "0x4005C46")]
	public const int AcceptOrderMax = 6;

	// Token: 0x04006038 RID: 24632
	[Token(Token = "0x4005C47")]
	public const int DuringOrderBoardId = 0;

	// Token: 0x04006039 RID: 24633
	[Token(Token = "0x4005C48")]
	public const int DuringOrderDetectiveId = 1;

	// Token: 0x0400603A RID: 24634
	[Token(Token = "0x4005C49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<OrderData> DuringOrderList;

	// Token: 0x0400603B RID: 24635
	[Token(Token = "0x4005C4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<OrderData> DuringDetectiveList;

	// Token: 0x0400603C RID: 24636
	[Token(Token = "0x4005C4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<OrderData> PublishedBoardOrderList;

	// Token: 0x0400603D RID: 24637
	[Token(Token = "0x4005C4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<OrderData> PublishedDetectiveOrderList;

	// Token: 0x0400603E RID: 24638
	[Token(Token = "0x4005C4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<OrderMasterData>[] NpcOrderDatas;

	// Token: 0x0400603F RID: 24639
	[Token(Token = "0x4005C4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public OrderRandomData OrderBoardRandomDatas;

	// Token: 0x04006040 RID: 24640
	[Token(Token = "0x4005C4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public OrderRandomData OrderDetectiveRandomDatas;

	// Token: 0x04006041 RID: 24641
	[Token(Token = "0x4005C50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public OrderRandomData OrderNpcRandomDatas;

	// Token: 0x04006042 RID: 24642
	[Token(Token = "0x4005C51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public OrderData LastClearOderData;

	// Token: 0x0200046B RID: 1131
	[Token(Token = "0x200108C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157770", Offset = "0x157871")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001B8F RID: 7055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE2")]
		[Address(RVA = "0x20D6160", Offset = "0x20D6261", VA = "0x20D6160")]
		public <>c()
		{
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x6006DE3")]
		[Address(RVA = "0x20D6170", Offset = "0x20D6271", VA = "0x20D6170")]
		internal int <SPOrderFailure>b__67_0(int value1, int value2)
		{
			return 0;
		}

		// Token: 0x04006043 RID: 24643
		[Token(Token = "0x4019064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly OrderManager.<>c <>9;

		// Token: 0x04006044 RID: 24644
		[Token(Token = "0x4019065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<int> <>9__67_0;
	}
}
