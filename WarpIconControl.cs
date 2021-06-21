using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009F3 RID: 2547
[Token(Token = "0x20006AD")]
public class WarpIconControl : MonoBehaviour
{
	// Token: 0x060042CF RID: 17103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037E4")]
	[Address(RVA = "0x1E4DC50", Offset = "0x1E4DD51", VA = "0x1E4DC50")]
	public void onIcon(bool flg)
	{
	}

	// Token: 0x060042D0 RID: 17104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037E5")]
	[Address(RVA = "0x1E4DC90", Offset = "0x1E4DD91", VA = "0x1E4DC90")]
	public void setOffIconImage(Sprite spr)
	{
	}

	// Token: 0x060042D1 RID: 17105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037E6")]
	[Address(RVA = "0x1E4DD10", Offset = "0x1E4DE11", VA = "0x1E4DD10")]
	public void setOnIconImage(Sprite spr)
	{
	}

	// Token: 0x060042D2 RID: 17106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037E7")]
	[Address(RVA = "0x1E4DD60", Offset = "0x1E4DE61", VA = "0x1E4DD60")]
	public WarpIconControl()
	{
	}

	// Token: 0x0400A17F RID: 41343
	[Token(Token = "0x40079EF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform RectTrans;

	// Token: 0x0400A180 RID: 41344
	[Token(Token = "0x40079F0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image iconOff;

	// Token: 0x0400A181 RID: 41345
	[Token(Token = "0x40079F1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image iconOn;
}
