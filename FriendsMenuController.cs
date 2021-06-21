using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A15 RID: 2581
[Token(Token = "0x20006C4")]
public class FriendsMenuController : MonoBehaviour
{
	// Token: 0x06004398 RID: 17304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003889")]
	[Address(RVA = "0x23D1060", Offset = "0x23D1161", VA = "0x23D1060")]
	private void SetPartnerToObject()
	{
	}

	// Token: 0x06004399 RID: 17305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600388A")]
	[Address(RVA = "0x23D17B0", Offset = "0x23D18B1", VA = "0x23D17B0")]
	private void OpenFriendPage()
	{
	}

	// Token: 0x0600439A RID: 17306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600388B")]
	[Address(RVA = "0x23D17F0", Offset = "0x23D18F1", VA = "0x23D17F0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600439B RID: 17307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600388C")]
	[Address(RVA = "0x23D1D40", Offset = "0x23D1E41", VA = "0x23D1D40")]
	private void PageChange(int val)
	{
	}

	// Token: 0x0600439C RID: 17308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600388D")]
	[Address(RVA = "0x23D1E80", Offset = "0x23D1F81", VA = "0x23D1E80")]
	private void Update()
	{
	}

	// Token: 0x0600439D RID: 17309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600388E")]
	[Address(RVA = "0x23D27F0", Offset = "0x23D28F1", VA = "0x23D27F0")]
	public void CloseEquipMenu()
	{
	}

	// Token: 0x0600439E RID: 17310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600388F")]
	[Address(RVA = "0x23D2830", Offset = "0x23D2931", VA = "0x23D2830")]
	private void OnDisable()
	{
	}

	// Token: 0x0600439F RID: 17311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003890")]
	[Address(RVA = "0x23D1C50", Offset = "0x23D1D51", VA = "0x23D1C50")]
	private void SetTouchAction(int _index)
	{
	}

	// Token: 0x060043A0 RID: 17312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003891")]
	[Address(RVA = "0x23D28E0", Offset = "0x23D29E1", VA = "0x23D28E0")]
	private void OnTouch(int _index)
	{
	}

	// Token: 0x060043A1 RID: 17313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003892")]
	[Address(RVA = "0x23D26F0", Offset = "0x23D27F1", VA = "0x23D26F0")]
	public void OnTouchCharaModel()
	{
	}

	// Token: 0x060043A2 RID: 17314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003893")]
	[Address(RVA = "0x23D2A50", Offset = "0x23D2B51", VA = "0x23D2A50")]
	public FriendsMenuController()
	{
	}

	// Token: 0x060043A3 RID: 17315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003894")]
	[Address(RVA = "0x23D2A60", Offset = "0x23D2B61", VA = "0x23D2A60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7760", Offset = "0x1A7861")]
	private void <OnEnable>b__21_1()
	{
	}

	// Token: 0x060043A4 RID: 17316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003895")]
	[Address(RVA = "0x23D2A70", Offset = "0x23D2B71", VA = "0x23D2A70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7770", Offset = "0x1A7871")]
	private void <OnEnable>b__21_2()
	{
	}

	// Token: 0x0400A27A RID: 41594
	[Token(Token = "0x4007ABD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject NoPartnerObject;

	// Token: 0x0400A27B RID: 41595
	[Token(Token = "0x4007ABE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject Partner1StatusObject;

	// Token: 0x0400A27C RID: 41596
	[Token(Token = "0x4007ABF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private HumanStatusA humanStatusA;

	// Token: 0x0400A27D RID: 41597
	[Token(Token = "0x4007AC0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private HumanStatusB humanStatusB;

	// Token: 0x0400A27E RID: 41598
	[Token(Token = "0x4007AC1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private FriendsMenuStatusDisp FriendsMenuStatusDisp;

	// Token: 0x0400A27F RID: 41599
	[Token(Token = "0x4007AC2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UIOnOffAnimate[] StatusAnimateList;

	// Token: 0x0400A280 RID: 41600
	[Token(Token = "0x4007AC3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UIOnOffAnimate[] MonsterStatusAnimateList;

	// Token: 0x0400A281 RID: 41601
	[Token(Token = "0x4007AC4")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private FriendEquipSlot[] equipSlot;

	// Token: 0x0400A282 RID: 41602
	[Token(Token = "0x4007AC5")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private NonFocusButton JL_Button;

	// Token: 0x0400A283 RID: 41603
	[Token(Token = "0x4007AC6")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private NonFocusButton JR_Button;

	// Token: 0x0400A284 RID: 41604
	[Token(Token = "0x4007AC7")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UIEMItemDetail itemDetail;

	// Token: 0x0400A285 RID: 41605
	[Token(Token = "0x4007AC8")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private TextMaskScrolling textScroll;

	// Token: 0x0400A286 RID: 41606
	[Token(Token = "0x4007AC9")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private CampBadStatusController CampBadStatusController;

	// Token: 0x0400A287 RID: 41607
	[Token(Token = "0x4007ACA")]
	[FieldOffset(Offset = "0x80")]
	private int nowFocusing;

	// Token: 0x0400A288 RID: 41608
	[Token(Token = "0x4007ACB")]
	[FieldOffset(Offset = "0x84")]
	private bool isSlotFocusing;

	// Token: 0x0400A289 RID: 41609
	[Token(Token = "0x4007ACC")]
	[FieldOffset(Offset = "0x85")]
	private bool noPartner;

	// Token: 0x0400A28A RID: 41610
	[Token(Token = "0x4007ACD")]
	[FieldOffset(Offset = "0x88")]
	private int OnFriendsPage;

	// Token: 0x0400A28B RID: 41611
	[Token(Token = "0x4007ACE")]
	[FieldOffset(Offset = "0x8C")]
	private int FriendPageMax;

	// Token: 0x0400A28C RID: 41612
	[Token(Token = "0x4007ACF")]
	[FieldOffset(Offset = "0x90")]
	private List<PartyBase> partyBases;

	// Token: 0x02000A16 RID: 2582
	[Token(Token = "0x20012D3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159030", Offset = "0x159131")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060043A6 RID: 17318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075F4")]
		[Address(RVA = "0x23D2AF0", Offset = "0x23D2BF1", VA = "0x23D2AF0")]
		public <>c()
		{
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x000169C8 File Offset: 0x00014BC8
		[Token(Token = "0x60075F5")]
		[Address(RVA = "0x23D2B00", Offset = "0x23D2C01", VA = "0x23D2B00")]
		internal bool <OnEnable>b__21_0(PartyBase a)
		{
			return default(bool);
		}

		// Token: 0x0400A28D RID: 41613
		[Token(Token = "0x401B420")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FriendsMenuController.<>c <>9;

		// Token: 0x0400A28E RID: 41614
		[Token(Token = "0x401B421")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<PartyBase> <>9__21_0;
	}

	// Token: 0x02000A17 RID: 2583
	[Token(Token = "0x20012D4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159040", Offset = "0x159141")]
	private sealed class <>c__DisplayClass26_0
	{
		// Token: 0x060043A8 RID: 17320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075F6")]
		[Address(RVA = "0x23D28D0", Offset = "0x23D29D1", VA = "0x23D28D0")]
		public <>c__DisplayClass26_0()
		{
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075F7")]
		[Address(RVA = "0x23D2B30", Offset = "0x23D2C31", VA = "0x23D2B30")]
		internal void <SetTouchAction>b__0()
		{
		}

		// Token: 0x0400A28F RID: 41615
		[Token(Token = "0x401B422")]
		[FieldOffset(Offset = "0x10")]
		public FriendsMenuController <>4__this;

		// Token: 0x0400A290 RID: 41616
		[Token(Token = "0x401B423")]
		[FieldOffset(Offset = "0x18")]
		public int _index;
	}
}
