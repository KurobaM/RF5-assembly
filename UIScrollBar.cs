using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000953 RID: 2387
[Token(Token = "0x2000641")]
public class UIScrollBar : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	// Token: 0x06003F47 RID: 16199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600349E")]
	[Address(RVA = "0x1EB5DB0", Offset = "0x1EB5EB1", VA = "0x1EB5DB0")]
	private void Awake()
	{
	}

	// Token: 0x06003F48 RID: 16200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600349F")]
	[Address(RVA = "0x1EB5E60", Offset = "0x1EB5F61", VA = "0x1EB5E60", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06003F49 RID: 16201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034A0")]
	[Address(RVA = "0x1EB5E90", Offset = "0x1EB5F91", VA = "0x1EB5E90", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x06003F4A RID: 16202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034A1")]
	[Address(RVA = "0x1EB5EC0", Offset = "0x1EB5FC1", VA = "0x1EB5EC0")]
	public UIScrollBar()
	{
	}

	// Token: 0x040080CD RID: 32973
	[Token(Token = "0x40073FE")]
	[FieldOffset(Offset = "0x18")]
	private Scrollbar scrollbar;

	// Token: 0x040080CE RID: 32974
	[Token(Token = "0x40073FF")]
	[FieldOffset(Offset = "0x20")]
	private Image handleImage;

	// Token: 0x040080CF RID: 32975
	[Token(Token = "0x4007400")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite handleSprite;

	// Token: 0x040080D0 RID: 32976
	[Token(Token = "0x4007401")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite clickedSprite;
}
