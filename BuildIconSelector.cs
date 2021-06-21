using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009EA RID: 2538
[Token(Token = "0x20006A6")]
public class BuildIconSelector : MonoBehaviour
{
	// Token: 0x06004284 RID: 17028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600379F")]
	[Address(RVA = "0x218BDE0", Offset = "0x218BEE1", VA = "0x218BDE0")]
	private void Start()
	{
	}

	// Token: 0x06004285 RID: 17029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037A0")]
	[Address(RVA = "0x218BEC0", Offset = "0x218BFC1", VA = "0x218BEC0")]
	private void Update()
	{
	}

	// Token: 0x06004286 RID: 17030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037A1")]
	[Address(RVA = "0x218BED0", Offset = "0x218BFD1", VA = "0x218BED0")]
	public void updateCursor()
	{
	}

	// Token: 0x06004287 RID: 17031 RVA: 0x000165A8 File Offset: 0x000147A8
	[Token(Token = "0x60037A2")]
	[Address(RVA = "0x218C890", Offset = "0x218C991", VA = "0x218C890")]
	public TouchState getTouchState()
	{
		return TouchState.FREE;
	}

	// Token: 0x06004288 RID: 17032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037A3")]
	[Address(RVA = "0x218C8A0", Offset = "0x218C9A1", VA = "0x218C8A0")]
	public void setCursorPos(Vector2 pos)
	{
	}

	// Token: 0x06004289 RID: 17033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037A4")]
	[Address(RVA = "0x218C950", Offset = "0x218CA51", VA = "0x218C950")]
	public BuildIconSelector()
	{
	}

	// Token: 0x0400A123 RID: 41251
	[Token(Token = "0x400799D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float MoveSpeed;

	// Token: 0x0400A124 RID: 41252
	[Token(Token = "0x400799E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MapControl mapCntl;

	// Token: 0x0400A125 RID: 41253
	[Token(Token = "0x400799F")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform rect;

	// Token: 0x0400A126 RID: 41254
	[Token(Token = "0x40079A0")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 oldTouchPos;

	// Token: 0x0400A127 RID: 41255
	[Token(Token = "0x40079A1")]
	[FieldOffset(Offset = "0x38")]
	private float oldTouchTime;

	// Token: 0x0400A128 RID: 41256
	[Token(Token = "0x40079A2")]
	[FieldOffset(Offset = "0x3C")]
	private TouchState touchState;

	// Token: 0x0400A129 RID: 41257
	[Token(Token = "0x40079A3")]
	[FieldOffset(Offset = "0x40")]
	public bool IsActiveInput;

	// Token: 0x0400A12A RID: 41258
	[Token(Token = "0x40079A4")]
	[FieldOffset(Offset = "0x41")]
	public bool IsActiveInputKey;

	// Token: 0x0400A12B RID: 41259
	[Token(Token = "0x40079A5")]
	[FieldOffset(Offset = "0x42")]
	public bool IsActiveInputTouch;

	// Token: 0x0400A12C RID: 41260
	[Token(Token = "0x40079A6")]
	[FieldOffset(Offset = "0x44")]
	private float imageSize;

	// Token: 0x0400A12D RID: 41261
	[Token(Token = "0x40079A7")]
	[FieldOffset(Offset = "0x48")]
	private Rect worldRect;

	// Token: 0x0400A12E RID: 41262
	[Token(Token = "0x40079A8")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 moveSize;
}
