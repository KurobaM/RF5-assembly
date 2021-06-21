using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A2F RID: 2607
[Token(Token = "0x20006D9")]
public class UIQuestSlotInPoliceBook : ButtonLinker
{
	// Token: 0x17000943 RID: 2371
	// (get) Token: 0x0600442C RID: 17452 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600442D RID: 17453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700076F")]
	public OrderData orderData
	{
		[Token(Token = "0x6003915")]
		[Address(RVA = "0x1EAD370", Offset = "0x1EAD471", VA = "0x1EAD370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A77D0", Offset = "0x1A78D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003916")]
		[Address(RVA = "0x1EAD380", Offset = "0x1EAD481", VA = "0x1EAD380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A77E0", Offset = "0x1A78E1")]
		private set
		{
		}
	}

	// Token: 0x17000944 RID: 2372
	// (get) Token: 0x0600442E RID: 17454 RVA: 0x00016B48 File Offset: 0x00014D48
	// (set) Token: 0x0600442F RID: 17455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000770")]
	public bool isWantedBlock
	{
		[Token(Token = "0x6003917")]
		[Address(RVA = "0x1EAD390", Offset = "0x1EAD491", VA = "0x1EAD390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A77F0", Offset = "0x1A78F1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003918")]
		[Address(RVA = "0x1EAD3A0", Offset = "0x1EAD4A1", VA = "0x1EAD3A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7800", Offset = "0x1A7901")]
		private set
		{
		}
	}

	// Token: 0x06004430 RID: 17456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003919")]
	[Address(RVA = "0x1EAD3B0", Offset = "0x1EAD4B1", VA = "0x1EAD3B0")]
	public void SetupWanted()
	{
	}

	// Token: 0x06004431 RID: 17457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600391A")]
	[Address(RVA = "0x1EAD490", Offset = "0x1EAD591", VA = "0x1EAD490")]
	public void Setup(UICampQuestMain _UICampQuestMain, OrderData _orderData)
	{
	}

	// Token: 0x06004432 RID: 17458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600391B")]
	[Address(RVA = "0x1EAD600", Offset = "0x1EAD701", VA = "0x1EAD600")]
	public void DispQuestData()
	{
	}

	// Token: 0x06004433 RID: 17459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600391C")]
	[Address(RVA = "0x1EAE590", Offset = "0x1EAE691", VA = "0x1EAE590")]
	public void EndFocusButton()
	{
	}

	// Token: 0x06004434 RID: 17460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600391D")]
	[Address(RVA = "0x1EAE620", Offset = "0x1EAE721", VA = "0x1EAE620", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004435 RID: 17461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600391E")]
	[Address(RVA = "0x1EAE660", Offset = "0x1EAE761", VA = "0x1EAE660", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06004436 RID: 17462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600391F")]
	[Address(RVA = "0x1EAE670", Offset = "0x1EAE771", VA = "0x1EAE670")]
	public UIQuestSlotInPoliceBook()
	{
	}

	// Token: 0x0400A319 RID: 41753
	[Token(Token = "0x4007B4C")]
	[FieldOffset(Offset = "0x60")]
	private UICampQuestMain UICampQuestMain;

	// Token: 0x0400A31A RID: 41754
	[Token(Token = "0x4007B4D")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x171FB0", Offset = "0x1720B1")]
	private OrderData <orderData>k__BackingField;

	// Token: 0x0400A31B RID: 41755
	[Token(Token = "0x4007B4E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int slotNo;

	// Token: 0x0400A31C RID: 41756
	[Token(Token = "0x4007B4F")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image QuestIcon;

	// Token: 0x0400A31D RID: 41757
	[Token(Token = "0x4007B50")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image TopicQuestIcon;

	// Token: 0x0400A31E RID: 41758
	[Token(Token = "0x4007B51")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Text TopicText;

	// Token: 0x0400A31F RID: 41759
	[Token(Token = "0x4007B52")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text NumberText;

	// Token: 0x0400A320 RID: 41760
	[Token(Token = "0x4007B53")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text FrebHeadText;

	// Token: 0x0400A321 RID: 41761
	[Token(Token = "0x4007B54")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Text FrebContentText;

	// Token: 0x0400A322 RID: 41762
	[Token(Token = "0x4007B55")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Text RewardHeadText;

	// Token: 0x0400A323 RID: 41763
	[Token(Token = "0x4007B56")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Text RewardContentText;

	// Token: 0x0400A324 RID: 41764
	[Token(Token = "0x4007B57")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Sprite OnSelectSprite;

	// Token: 0x0400A325 RID: 41765
	[Token(Token = "0x4007B58")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Sprite NotSelectSprite;

	// Token: 0x0400A326 RID: 41766
	[Token(Token = "0x4007B59")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Sprite[] IconSprite;

	// Token: 0x0400A327 RID: 41767
	[Token(Token = "0x4007B5A")]
	[FieldOffset(Offset = "0xD0")]
	private Color NoneSelectIconColor;

	// Token: 0x0400A328 RID: 41768
	[Token(Token = "0x4007B5B")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private UIQuestCancelButton CancelButton;

	// Token: 0x0400A329 RID: 41769
	[Token(Token = "0x4007B5C")]
	[FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x172090", Offset = "0x172191")]
	private bool <isWantedBlock>k__BackingField;
}
