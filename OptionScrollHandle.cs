using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000A9A RID: 2714
[Token(Token = "0x200071D")]
public class OptionScrollHandle : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	// Token: 0x06004695 RID: 18069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B19")]
	[Address(RVA = "0x20C71C0", Offset = "0x20C72C1", VA = "0x20C71C0")]
	private void Awake()
	{
	}

	// Token: 0x06004696 RID: 18070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B1A")]
	[Address(RVA = "0x20C7230", Offset = "0x20C7331", VA = "0x20C7230")]
	private void Update()
	{
	}

	// Token: 0x06004697 RID: 18071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B1B")]
	[Address(RVA = "0x20C7410", Offset = "0x20C7511", VA = "0x20C7410", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x06004698 RID: 18072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B1C")]
	[Address(RVA = "0x20C7490", Offset = "0x20C7591", VA = "0x20C7490", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x06004699 RID: 18073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B1D")]
	[Address(RVA = "0x20C7510", Offset = "0x20C7611", VA = "0x20C7510")]
	public OptionScrollHandle()
	{
	}

	// Token: 0x0400A58E RID: 42382
	[Token(Token = "0x4007D12")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CursorLinker cursorLinker;

	// Token: 0x0400A58F RID: 42383
	[Token(Token = "0x4007D13")]
	[FieldOffset(Offset = "0x20")]
	private RectTransform handleRect;

	// Token: 0x0400A590 RID: 42384
	[Token(Token = "0x4007D14")]
	[FieldOffset(Offset = "0x28")]
	private float scale;

	// Token: 0x0400A591 RID: 42385
	[Token(Token = "0x4007D15")]
	[FieldOffset(Offset = "0x2C")]
	private readonly float SPEED;

	// Token: 0x0400A592 RID: 42386
	[Token(Token = "0x4007D16")]
	[FieldOffset(Offset = "0x30")]
	private int dir;

	// Token: 0x0400A593 RID: 42387
	[Token(Token = "0x4007D17")]
	[FieldOffset(Offset = "0x34")]
	private bool isDragging;

	// Token: 0x0400A594 RID: 42388
	[Token(Token = "0x4007D18")]
	[FieldOffset(Offset = "0x38")]
	private readonly Key KEY;

	// Token: 0x0400A595 RID: 42389
	[Token(Token = "0x4007D19")]
	[FieldOffset(Offset = "0x3C")]
	private OptionScrollHandle.State state;

	// Token: 0x02000A9B RID: 2715
	[Token(Token = "0x20012FF")]
	private enum State
	{
		// Token: 0x0400A597 RID: 42391
		[Token(Token = "0x401B4E0")]
		Wait,
		// Token: 0x0400A598 RID: 42392
		[Token(Token = "0x401B4E1")]
		Move
	}
}
