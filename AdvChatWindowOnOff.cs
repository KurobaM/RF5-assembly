using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000915 RID: 2325
[Token(Token = "0x2000619")]
public class AdvChatWindowOnOff : MonoBehaviour
{
	// Token: 0x06003CF5 RID: 15605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003346")]
	[Address(RVA = "0x1D5B140", Offset = "0x1D5B241", VA = "0x1D5B140")]
	public void DoOpen()
	{
	}

	// Token: 0x06003CF6 RID: 15606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003347")]
	[Address(RVA = "0x1D5B250", Offset = "0x1D5B351", VA = "0x1D5B250")]
	public void DoClose()
	{
	}

	// Token: 0x06003CF7 RID: 15607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003348")]
	[Address(RVA = "0x1D5B2B0", Offset = "0x1D5B3B1", VA = "0x1D5B2B0")]
	private void Update()
	{
	}

	// Token: 0x06003CF8 RID: 15608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003349")]
	[Address(RVA = "0x1D5B4E0", Offset = "0x1D5B5E1", VA = "0x1D5B4E0")]
	public AdvChatWindowOnOff()
	{
	}

	// Token: 0x04007F59 RID: 32601
	[Token(Token = "0x40072EC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float MoveTime;

	// Token: 0x04007F5A RID: 32602
	[Token(Token = "0x40072ED")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector2 StartPos;

	// Token: 0x04007F5B RID: 32603
	[Token(Token = "0x40072EE")]
	[FieldOffset(Offset = "0x24")]
	private bool isOpen;

	// Token: 0x04007F5C RID: 32604
	[Token(Token = "0x40072EF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform MoveRect;

	// Token: 0x04007F5D RID: 32605
	[Token(Token = "0x40072F0")]
	[FieldOffset(Offset = "0x30")]
	private float nTime;

	// Token: 0x04007F5E RID: 32606
	[Token(Token = "0x40072F1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private CanvasGroup canvasGroup;

	// Token: 0x04007F5F RID: 32607
	[Token(Token = "0x40072F2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve slideCurve;

	// Token: 0x04007F60 RID: 32608
	[Token(Token = "0x40072F3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AnimationCurve fadeCurve;

	// Token: 0x04007F61 RID: 32609
	[Token(Token = "0x40072F4")]
	[FieldOffset(Offset = "0x50")]
	private float curveSpeed;

	// Token: 0x04007F62 RID: 32610
	[Token(Token = "0x40072F5")]
	[FieldOffset(Offset = "0x54")]
	private float curveRate;
}
