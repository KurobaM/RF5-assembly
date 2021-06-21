using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A60 RID: 2656
[Token(Token = "0x20006FB")]
public class OrderCursorEvent : CursorEvent
{
	// Token: 0x0600455F RID: 17759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A15")]
	[Address(RVA = "0x20C8270", Offset = "0x20C8371", VA = "0x20C8270", Slot = "5")]
	protected override void OnEnable()
	{
	}

	// Token: 0x06004560 RID: 17760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A16")]
	[Address(RVA = "0x20C8370", Offset = "0x20C8471", VA = "0x20C8370")]
	public void UpdateOrderData(OrderData _data)
	{
	}

	// Token: 0x06004561 RID: 17761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A17")]
	[Address(RVA = "0x20C90A0", Offset = "0x20C91A1", VA = "0x20C90A0")]
	public OrderCursorEvent()
	{
	}

	// Token: 0x0400A439 RID: 42041
	[Token(Token = "0x4007C2E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text TopicText;

	// Token: 0x0400A43A RID: 42042
	[Token(Token = "0x4007C2F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image TopicIcon;

	// Token: 0x0400A43B RID: 42043
	[Token(Token = "0x4007C30")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text NPCNameText;

	// Token: 0x0400A43C RID: 42044
	[Token(Token = "0x4007C31")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text ContentHeadText;

	// Token: 0x0400A43D RID: 42045
	[Token(Token = "0x4007C32")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text ContentText;

	// Token: 0x0400A43E RID: 42046
	[Token(Token = "0x4007C33")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text RewardHeadText;

	// Token: 0x0400A43F RID: 42047
	[Token(Token = "0x4007C34")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text RewardItemText;

	// Token: 0x0400A440 RID: 42048
	[Token(Token = "0x4007C35")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Sprite[] IconSprite;

	// Token: 0x0400A441 RID: 42049
	[Token(Token = "0x4007C36")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UIFaceIconLoader UIFaceIconLoader;
}
