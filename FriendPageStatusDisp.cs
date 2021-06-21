using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A0B RID: 2571
[Token(Token = "0x20006BE")]
public class FriendPageStatusDisp : MonoBehaviour
{
	// Token: 0x17000932 RID: 2354
	// (get) Token: 0x0600435B RID: 17243 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600435C RID: 17244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700075E")]
	public GenerateFriendlistButton GenerateFriendlistButton
	{
		[Token(Token = "0x600385C")]
		[Address(RVA = "0x23CEE40", Offset = "0x23CEF41", VA = "0x23CEE40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7700", Offset = "0x1A7801")]
		get
		{
			return null;
		}
		[Token(Token = "0x600385D")]
		[Address(RVA = "0x23CEE50", Offset = "0x23CEF51", VA = "0x23CEE50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7710", Offset = "0x1A7811")]
		set
		{
		}
	}

	// Token: 0x0600435D RID: 17245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600385E")]
	[Address(RVA = "0x23CEE60", Offset = "0x23CEF61", VA = "0x23CEE60")]
	public void SetStatusNPC(int pageId, GenerateFriendlistButton _generateFriendlistButton)
	{
	}

	// Token: 0x0600435E RID: 17246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600385F")]
	[Address(RVA = "0x23CF370", Offset = "0x23CF471", VA = "0x23CF370")]
	public void SetStatusMonster(int pageId, GenerateFriendlistButton _generateFriendlistButton)
	{
	}

	// Token: 0x0600435F RID: 17247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003860")]
	[Address(RVA = "0x23CF790", Offset = "0x23CF891", VA = "0x23CF790")]
	private void OnEnable()
	{
	}

	// Token: 0x06004360 RID: 17248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003861")]
	[Address(RVA = "0x23CFA80", Offset = "0x23CFB81", VA = "0x23CFA80")]
	private void Update()
	{
	}

	// Token: 0x06004361 RID: 17249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003862")]
	[Address(RVA = "0x23D0190", Offset = "0x23D0291", VA = "0x23D0190")]
	private void OnDisable()
	{
	}

	// Token: 0x06004362 RID: 17250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003863")]
	[Address(RVA = "0x23D0250", Offset = "0x23D0351", VA = "0x23D0250")]
	private void PageSwitch(int val)
	{
	}

	// Token: 0x06004363 RID: 17251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003864")]
	[Address(RVA = "0x23CF990", Offset = "0x23CFA91", VA = "0x23CF990")]
	private void SetTouchAction(int _index)
	{
	}

	// Token: 0x06004364 RID: 17252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003865")]
	[Address(RVA = "0x23D0400", Offset = "0x23D0501", VA = "0x23D0400")]
	private void OnTouch(int _index)
	{
	}

	// Token: 0x06004365 RID: 17253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003866")]
	[Address(RVA = "0x23D0090", Offset = "0x23D0191", VA = "0x23D0090")]
	public void OnTouchCharaModel()
	{
	}

	// Token: 0x06004366 RID: 17254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003867")]
	[Address(RVA = "0x23D0570", Offset = "0x23D0671", VA = "0x23D0570")]
	public FriendPageStatusDisp()
	{
	}

	// Token: 0x06004367 RID: 17255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003868")]
	[Address(RVA = "0x23D0590", Offset = "0x23D0691", VA = "0x23D0590")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7720", Offset = "0x1A7821")]
	private void <OnEnable>b__23_0()
	{
	}

	// Token: 0x06004368 RID: 17256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003869")]
	[Address(RVA = "0x23D05A0", Offset = "0x23D06A1", VA = "0x23D05A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7730", Offset = "0x1A7831")]
	private void <OnEnable>b__23_1()
	{
	}

	// Token: 0x0400A232 RID: 41522
	[Token(Token = "0x4007A8B")]
	[FieldOffset(Offset = "0x18")]
	private GenerateFriendlistButton.FriendType FriendType;

	// Token: 0x0400A233 RID: 41523
	[Token(Token = "0x4007A8C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FriendsMenuStatusDisp FriendsMenuStatusDisp;

	// Token: 0x0400A234 RID: 41524
	[Token(Token = "0x4007A8D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private HumanStatusA HumanStatusA;

	// Token: 0x0400A235 RID: 41525
	[Token(Token = "0x4007A8E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private HumanStatusB HumanStatusB;

	// Token: 0x0400A236 RID: 41526
	[Token(Token = "0x4007A8F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UIOnOffAnimate[] TurnOnAnimateNpc;

	// Token: 0x0400A237 RID: 41527
	[Token(Token = "0x4007A90")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UIOnOffAnimate[] TurnOnAnimateMonster;

	// Token: 0x0400A238 RID: 41528
	[Token(Token = "0x4007A91")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private FriendEquipSlot[] equipSlot;

	// Token: 0x0400A239 RID: 41529
	[Token(Token = "0x4007A92")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private NonFocusButton JL_Button;

	// Token: 0x0400A23A RID: 41530
	[Token(Token = "0x4007A93")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private NonFocusButton JR_Button;

	// Token: 0x0400A23B RID: 41531
	[Token(Token = "0x4007A94")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UIEMItemDetail itemDetail;

	// Token: 0x0400A23C RID: 41532
	[Token(Token = "0x4007A95")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private TextMaskScrolling textScroll;

	// Token: 0x0400A23D RID: 41533
	[Token(Token = "0x4007A96")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private CampBadStatusController CampBadStatusController;

	// Token: 0x0400A23E RID: 41534
	[Token(Token = "0x4007A97")]
	[FieldOffset(Offset = "0x78")]
	private int nowFocusing;

	// Token: 0x0400A23F RID: 41535
	[Token(Token = "0x4007A98")]
	[FieldOffset(Offset = "0x7C")]
	private bool isSlotFocusing;

	// Token: 0x0400A240 RID: 41536
	[Token(Token = "0x4007A99")]
	[FieldOffset(Offset = "0x80")]
	private int pageID;

	// Token: 0x0400A241 RID: 41537
	[Token(Token = "0x4007A9A")]
	[FieldOffset(Offset = "0x84")]
	private ActorID actorId;

	// Token: 0x0400A242 RID: 41538
	[Token(Token = "0x4007A9B")]
	[FieldOffset(Offset = "0x88")]
	private MonsterDataID monsterDataID;

	// Token: 0x0400A243 RID: 41539
	[Token(Token = "0x4007A9C")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1716E0", Offset = "0x1717E1")]
	private GenerateFriendlistButton <GenerateFriendlistButton>k__BackingField;

	// Token: 0x02000A0C RID: 2572
	[Token(Token = "0x20012CF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159010", Offset = "0x159111")]
	private sealed class <>c__DisplayClass27_0
	{
		// Token: 0x06004369 RID: 17257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E3")]
		[Address(RVA = "0x23D03F0", Offset = "0x23D04F1", VA = "0x23D03F0")]
		public <>c__DisplayClass27_0()
		{
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E4")]
		[Address(RVA = "0x23D05B0", Offset = "0x23D06B1", VA = "0x23D05B0")]
		internal void <SetTouchAction>b__0()
		{
		}

		// Token: 0x0400A244 RID: 41540
		[Token(Token = "0x401B40A")]
		[FieldOffset(Offset = "0x10")]
		public FriendPageStatusDisp <>4__this;

		// Token: 0x0400A245 RID: 41541
		[Token(Token = "0x401B40B")]
		[FieldOffset(Offset = "0x18")]
		public int _index;
	}
}
