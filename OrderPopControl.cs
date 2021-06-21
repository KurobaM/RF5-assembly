using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009CB RID: 2507
[Token(Token = "0x2000691")]
public class OrderPopControl : MonoBehaviour
{
	// Token: 0x060041A3 RID: 16803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036CE")]
	[Address(RVA = "0x20CBC30", Offset = "0x20CBD31", VA = "0x20CBC30")]
	public void AddStock(OrderPopControl.StockType _type, OrderHUDBlock _orderHUDBlock, OrderData _data)
	{
	}

	// Token: 0x060041A4 RID: 16804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036CF")]
	[Address(RVA = "0x20D6200", Offset = "0x20D6301", VA = "0x20D6200")]
	private void ReleaseStock()
	{
	}

	// Token: 0x060041A5 RID: 16805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036D0")]
	[Address(RVA = "0x20D65E0", Offset = "0x20D66E1", VA = "0x20D65E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060041A6 RID: 16806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036D1")]
	[Address(RVA = "0x20D6790", Offset = "0x20D6891", VA = "0x20D6790")]
	private void Awake()
	{
	}

	// Token: 0x060041A7 RID: 16807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60036D2")]
	[Address(RVA = "0x20D6830", Offset = "0x20D6931", VA = "0x20D6830")]
	public OrderHUDBlock AddOrderBlock(OrderData data)
	{
		return null;
	}

	// Token: 0x060041A8 RID: 16808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036D3")]
	[Address(RVA = "0x20CBD70", Offset = "0x20CBE71", VA = "0x20CBD70")]
	public void RemoveBlock(OrderHUDBlock orderHUD)
	{
	}

	// Token: 0x060041A9 RID: 16809 RVA: 0x00016218 File Offset: 0x00014418
	[Token(Token = "0x60036D4")]
	[Address(RVA = "0x20CC0F0", Offset = "0x20CC1F1", VA = "0x20CC0F0")]
	public int GetNoneUseBlockId()
	{
		return 0;
	}

	// Token: 0x060041AA RID: 16810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036D5")]
	[Address(RVA = "0x20D6A60", Offset = "0x20D6B61", VA = "0x20D6A60")]
	public OrderPopControl()
	{
	}

	// Token: 0x0400A089 RID: 41097
	[Token(Token = "0x4007926")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OrderHUDBlock OrderHUDBlockPrefab;

	// Token: 0x0400A08A RID: 41098
	[Token(Token = "0x4007927")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject PopupParent;

	// Token: 0x0400A08B RID: 41099
	[Token(Token = "0x4007928")]
	[FieldOffset(Offset = "0x28")]
	private List<OrderHUDBlock> OrderHUDBlockList;

	// Token: 0x0400A08C RID: 41100
	[Token(Token = "0x4007929")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite[] OrderIconSprites;

	// Token: 0x0400A08D RID: 41101
	[Token(Token = "0x400792A")]
	[FieldOffset(Offset = "0x38")]
	private bool hasStock;

	// Token: 0x0400A08E RID: 41102
	[Token(Token = "0x400792B")]
	[FieldOffset(Offset = "0x39")]
	private bool parentActiving;

	// Token: 0x0400A08F RID: 41103
	[Token(Token = "0x400792C")]
	[FieldOffset(Offset = "0x40")]
	private List<OrderPopControl.StockDoOrder> stockDoOrders;

	// Token: 0x020009CC RID: 2508
	[Token(Token = "0x20012BC")]
	public enum StockType
	{
		// Token: 0x0400A091 RID: 41105
		[Token(Token = "0x401B3C7")]
		Start,
		// Token: 0x0400A092 RID: 41106
		[Token(Token = "0x401B3C8")]
		Finish,
		// Token: 0x0400A093 RID: 41107
		[Token(Token = "0x401B3C9")]
		End,
		// Token: 0x0400A094 RID: 41108
		[Token(Token = "0x401B3CA")]
		Fail
	}

	// Token: 0x020009CD RID: 2509
	[Token(Token = "0x20012BD")]
	private class StockDoOrder
	{
		// Token: 0x060041AB RID: 16811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B9")]
		[Address(RVA = "0x20D61A0", Offset = "0x20D62A1", VA = "0x20D61A0")]
		public StockDoOrder(OrderPopControl.StockType _type, OrderHUDBlock _orderHUDBlock, OrderData _data)
		{
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x00016230 File Offset: 0x00014430
		[Token(Token = "0x60075BA")]
		[Address(RVA = "0x20D63D0", Offset = "0x20D64D1", VA = "0x20D63D0")]
		public bool Release(OrderPopControl OrderPopControl)
		{
			return default(bool);
		}

		// Token: 0x0400A095 RID: 41109
		[Token(Token = "0x401B3CB")]
		[FieldOffset(Offset = "0x10")]
		private OrderPopControl.StockType type;

		// Token: 0x0400A096 RID: 41110
		[Token(Token = "0x401B3CC")]
		[FieldOffset(Offset = "0x18")]
		private OrderHUDBlock block;

		// Token: 0x0400A097 RID: 41111
		[Token(Token = "0x401B3CD")]
		[FieldOffset(Offset = "0x20")]
		private OrderData data;
	}

	// Token: 0x020009CE RID: 2510
	[Token(Token = "0x20012BE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158F50", Offset = "0x159051")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060041AE RID: 16814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075BC")]
		[Address(RVA = "0x20D6B70", Offset = "0x20D6C71", VA = "0x20D6B70")]
		public <>c()
		{
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x00016248 File Offset: 0x00014448
		[Token(Token = "0x60075BD")]
		[Address(RVA = "0x20D6B80", Offset = "0x20D6C81", VA = "0x20D6B80")]
		internal bool <ReleaseStock>b__10_0(OrderPopControl.StockDoOrder val)
		{
			return default(bool);
		}

		// Token: 0x0400A098 RID: 41112
		[Token(Token = "0x401B3CE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly OrderPopControl.<>c <>9;

		// Token: 0x0400A099 RID: 41113
		[Token(Token = "0x401B3CF")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<OrderPopControl.StockDoOrder> <>9__10_0;
	}
}
