using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200050A RID: 1290
[Token(Token = "0x20003AD")]
public class FestivalCountDown : MonoBehaviour
{
	// Token: 0x06001F6C RID: 8044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD6")]
	[Address(RVA = "0x1F80A20", Offset = "0x1F80B21", VA = "0x1F80A20")]
	private void Start()
	{
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD7")]
	[Address(RVA = "0x1F80A90", Offset = "0x1F80B91", VA = "0x1F80A90")]
	public void SetNumSprite(int _num)
	{
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD8")]
	[Address(RVA = "0x1F80AF0", Offset = "0x1F80BF1", VA = "0x1F80AF0")]
	public void SetImageActive(bool _flag)
	{
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD9")]
	[Address(RVA = "0x1F80B00", Offset = "0x1F80C01", VA = "0x1F80B00")]
	public FestivalCountDown()
	{
	}

	// Token: 0x0400665E RID: 26206
	[Token(Token = "0x40060AF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Sprite[] numSprites;

	// Token: 0x0400665F RID: 26207
	[Token(Token = "0x40060B0")]
	[FieldOffset(Offset = "0x20")]
	private Image image;
}
