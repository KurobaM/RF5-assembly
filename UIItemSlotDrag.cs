using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020009E0 RID: 2528
[Token(Token = "0x200069F")]
public class UIItemSlotDrag : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
	// Token: 0x06004247 RID: 16967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003768")]
	[Address(RVA = "0x201AE20", Offset = "0x201AF21", VA = "0x201AE20", Slot = "4")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06004248 RID: 16968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003769")]
	[Address(RVA = "0x201AF30", Offset = "0x201B031", VA = "0x201AF30", Slot = "5")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06004249 RID: 16969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600376A")]
	[Address(RVA = "0x201B0C0", Offset = "0x201B1C1", VA = "0x201B0C0", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x0600424A RID: 16970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600376B")]
	[Address(RVA = "0x201B1A0", Offset = "0x201B2A1", VA = "0x201B1A0")]
	private void Start()
	{
	}

	// Token: 0x0600424B RID: 16971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600376C")]
	[Address(RVA = "0x201B200", Offset = "0x201B301", VA = "0x201B200", Slot = "8")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x0600424C RID: 16972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600376D")]
	[Address(RVA = "0x201B420", Offset = "0x201B521", VA = "0x201B420", Slot = "9")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x0600424D RID: 16973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600376E")]
	[Address(RVA = "0x201B4E0", Offset = "0x201B5E1", VA = "0x201B4E0", Slot = "7")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x0600424E RID: 16974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600376F")]
	[Address(RVA = "0x201B6E0", Offset = "0x201B7E1", VA = "0x201B6E0", Slot = "10")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x0600424F RID: 16975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003770")]
	[Address(RVA = "0x201B7A0", Offset = "0x201B8A1", VA = "0x201B7A0")]
	private void OnDisable()
	{
	}

	// Token: 0x06004250 RID: 16976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003771")]
	[Address(RVA = "0x201B930", Offset = "0x201BA31", VA = "0x201B930")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004251 RID: 16977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003772")]
	[Address(RVA = "0x201BA10", Offset = "0x201BB11", VA = "0x201BA10")]
	public UIItemSlotDrag()
	{
	}

	// Token: 0x0400A101 RID: 41217
	[Token(Token = "0x4007981")]
	[FieldOffset(Offset = "0x0")]
	private static UIItemSlot DragingSlot;

	// Token: 0x0400A102 RID: 41218
	[Token(Token = "0x4007982")]
	[FieldOffset(Offset = "0x18")]
	private UIItemSlot UIItemSlot;

	// Token: 0x0400A103 RID: 41219
	[Token(Token = "0x4007983")]
	[FieldOffset(Offset = "0x20")]
	private Image ItemImg;

	// Token: 0x0400A104 RID: 41220
	[Token(Token = "0x4007984")]
	[FieldOffset(Offset = "0x8")]
	private static UIItemSlot DragToTargetSlot;
}
