using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000A61 RID: 2657
[Token(Token = "0x20006FC")]
public class UIOrderBoardMenu : UIScrollBoxBase
{
	// Token: 0x06004562 RID: 17762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A18")]
	[Address(RVA = "0x1EAA940", Offset = "0x1EAAA41", VA = "0x1EAA940")]
	private void SetupOrderDataList()
	{
	}

	// Token: 0x06004563 RID: 17763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A19")]
	[Address(RVA = "0x1EAAB00", Offset = "0x1EAAC01", VA = "0x1EAAB00")]
	private void CheckRemoveAcceptedOrderList()
	{
	}

	// Token: 0x06004564 RID: 17764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A1A")]
	[Address(RVA = "0x1EAAC30", Offset = "0x1EAAD31", VA = "0x1EAAC30", Slot = "8")]
	protected override void Start()
	{
	}

	// Token: 0x06004565 RID: 17765 RVA: 0x00017028 File Offset: 0x00015228
	[Token(Token = "0x6003A1B")]
	[Address(RVA = "0x1EAAE00", Offset = "0x1EAAF01", VA = "0x1EAAE00")]
	public bool OpenCategory()
	{
		return default(bool);
	}

	// Token: 0x06004566 RID: 17766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A1C")]
	[Address(RVA = "0x1EAB870", Offset = "0x1EAB971", VA = "0x1EAB870", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x06004567 RID: 17767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A1D")]
	[Address(RVA = "0x1EABC90", Offset = "0x1EABD91", VA = "0x1EABC90")]
	public void NGSelected(bool choice)
	{
	}

	// Token: 0x06004568 RID: 17768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A1E")]
	[Address(RVA = "0x1EABCA0", Offset = "0x1EABDA1", VA = "0x1EABCA0")]
	public void OnSelected(bool choice)
	{
	}

	// Token: 0x06004569 RID: 17769 RVA: 0x00017040 File Offset: 0x00015240
	[Token(Token = "0x6003A1F")]
	[Address(RVA = "0x1EABED0", Offset = "0x1EABFD1", VA = "0x1EABED0")]
	private static int GetAcceptableOrderNum()
	{
		return 0;
	}

	// Token: 0x0600456A RID: 17770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A20")]
	[Address(RVA = "0x1EAC030", Offset = "0x1EAC131", VA = "0x1EAC030")]
	public static void OpenBoard()
	{
	}

	// Token: 0x0600456B RID: 17771 RVA: 0x00017058 File Offset: 0x00015258
	[Token(Token = "0x6003A21")]
	[Address(RVA = "0x1EAC280", Offset = "0x1EAC381", VA = "0x1EAC280")]
	public static bool CheckNewOrder()
	{
		return default(bool);
	}

	// Token: 0x0600456C RID: 17772 RVA: 0x00017070 File Offset: 0x00015270
	[Token(Token = "0x6003A22")]
	[Address(RVA = "0x1EAC2A0", Offset = "0x1EAC3A1", VA = "0x1EAC2A0", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x0600456D RID: 17773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A23")]
	[Address(RVA = "0x1EAC2F0", Offset = "0x1EAC3F1", VA = "0x1EAC2F0", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x0600456E RID: 17774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A24")]
	[Address(RVA = "0x1EAC430", Offset = "0x1EAC531", VA = "0x1EAC430", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x0600456F RID: 17775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A25")]
	[Address(RVA = "0x1EAC4D0", Offset = "0x1EAC5D1", VA = "0x1EAC4D0")]
	public UIOrderBoardMenu()
	{
	}

	// Token: 0x0400A442 RID: 42050
	[Token(Token = "0x4007C37")]
	[FieldOffset(Offset = "0x68")]
	private bool isOpening;

	// Token: 0x0400A443 RID: 42051
	[Token(Token = "0x4007C38")]
	[FieldOffset(Offset = "0x70")]
	private List<UIOrderBoardMenu.OrderList> orderLists;

	// Token: 0x0400A444 RID: 42052
	[Token(Token = "0x4007C39")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Sprite[] IconSprite;

	// Token: 0x0400A445 RID: 42053
	[Token(Token = "0x4007C3A")]
	[FieldOffset(Offset = "0x80")]
	private bool isOpeningPopup;

	// Token: 0x0400A446 RID: 42054
	[Token(Token = "0x4007C3B")]
	[FieldOffset(Offset = "0x88")]
	private OrderCursorEvent cursorEvent;

	// Token: 0x0400A447 RID: 42055
	[Token(Token = "0x4007C3C")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text HeadText;

	// Token: 0x02000A62 RID: 2658
	[Token(Token = "0x20012E7")]
	public class OrderList
	{
		// Token: 0x06004570 RID: 17776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600762E")]
		[Address(RVA = "0x1EAAAB0", Offset = "0x1EAABB1", VA = "0x1EAAAB0")]
		public OrderList(OrderData data, int idx)
		{
		}

		// Token: 0x0400A448 RID: 42056
		[Token(Token = "0x401B46E")]
		[FieldOffset(Offset = "0x10")]
		public OrderData OrderData;

		// Token: 0x0400A449 RID: 42057
		[Token(Token = "0x401B46F")]
		[FieldOffset(Offset = "0x18")]
		public int orderidx;
	}

	// Token: 0x02000A63 RID: 2659
	[Token(Token = "0x20012E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1590F0", Offset = "0x1591F1")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x06004571 RID: 17777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600762F")]
		[Address(RVA = "0x1EAC6E0", Offset = "0x1EAC7E1", VA = "0x1EAC6E0")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00017088 File Offset: 0x00015288
		[Token(Token = "0x6007630")]
		[Address(RVA = "0x1EAC890", Offset = "0x1EAC991", VA = "0x1EAC890")]
		internal bool <CheckRemoveAcceptedOrderList>b__1(OrderData a)
		{
			return default(bool);
		}

		// Token: 0x0400A44A RID: 42058
		[Token(Token = "0x401B470")]
		[FieldOffset(Offset = "0x10")]
		public UIOrderBoardMenu.OrderList order;
	}

	// Token: 0x02000A64 RID: 2660
	[Token(Token = "0x20012E9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159100", Offset = "0x159201")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004574 RID: 17780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007632")]
		[Address(RVA = "0x1EAC5E0", Offset = "0x1EAC6E1", VA = "0x1EAC5E0")]
		public <>c()
		{
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x000170A0 File Offset: 0x000152A0
		[Token(Token = "0x6007633")]
		[Address(RVA = "0x1EAC5F0", Offset = "0x1EAC6F1", VA = "0x1EAC5F0")]
		internal bool <CheckRemoveAcceptedOrderList>b__7_0(UIOrderBoardMenu.OrderList order)
		{
			return default(bool);
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x000170B8 File Offset: 0x000152B8
		[Token(Token = "0x6007634")]
		[Address(RVA = "0x1EAC6F0", Offset = "0x1EAC7F1", VA = "0x1EAC6F0")]
		internal bool <GetAcceptableOrderNum>b__14_0(OrderData order)
		{
			return default(bool);
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007635")]
		[Address(RVA = "0x1EAC7F0", Offset = "0x1EAC8F1", VA = "0x1EAC7F0")]
		internal void <OpenBoard>b__15_0(bool select)
		{
		}

		// Token: 0x0400A44B RID: 42059
		[Token(Token = "0x401B471")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIOrderBoardMenu.<>c <>9;

		// Token: 0x0400A44C RID: 42060
		[Token(Token = "0x401B472")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<UIOrderBoardMenu.OrderList> <>9__7_0;

		// Token: 0x0400A44D RID: 42061
		[Token(Token = "0x401B473")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<OrderData> <>9__14_0;

		// Token: 0x0400A44E RID: 42062
		[Token(Token = "0x401B474")]
		[FieldOffset(Offset = "0x18")]
		public static UnityAction<bool> <>9__15_0;
	}

	// Token: 0x02000A65 RID: 2661
	[Token(Token = "0x20012EA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159110", Offset = "0x159211")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x06004578 RID: 17784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007636")]
		[Address(RVA = "0x1EAC7E0", Offset = "0x1EAC8E1", VA = "0x1EAC7E0")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x000170D0 File Offset: 0x000152D0
		[Token(Token = "0x6007637")]
		[Address(RVA = "0x1EAC860", Offset = "0x1EAC961", VA = "0x1EAC860")]
		internal bool <GetAcceptableOrderNum>b__1(OrderData a)
		{
			return default(bool);
		}

		// Token: 0x0400A44F RID: 42063
		[Token(Token = "0x401B475")]
		[FieldOffset(Offset = "0x10")]
		public OrderData order;
	}
}
