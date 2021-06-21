using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000933 RID: 2355
[Token(Token = "0x2000628")]
public class AdvCharaJump : AdvCharaAnim
{
	// Token: 0x06003E5D RID: 15965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D1")]
	[Address(RVA = "0x1D5A960", Offset = "0x1D5AA61", VA = "0x1D5A960", Slot = "4")]
	public override void PlayAnim()
	{
	}

	// Token: 0x06003E5E RID: 15966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D2")]
	[Address(RVA = "0x1D5A9F0", Offset = "0x1D5AAF1", VA = "0x1D5A9F0", Slot = "5")]
	public override void EndAnim()
	{
	}

	// Token: 0x06003E5F RID: 15967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D3")]
	[Address(RVA = "0x1D5AA50", Offset = "0x1D5AB51", VA = "0x1D5AA50")]
	private void Update()
	{
	}

	// Token: 0x06003E60 RID: 15968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D4")]
	[Address(RVA = "0x1D5AB10", Offset = "0x1D5AC11", VA = "0x1D5AB10")]
	public AdvCharaJump()
	{
	}

	// Token: 0x04008010 RID: 32784
	[Token(Token = "0x4007366")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationCurve JumpCurve;

	// Token: 0x04008011 RID: 32785
	[Token(Token = "0x4007367")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float JumpRange;

	// Token: 0x04008012 RID: 32786
	[Token(Token = "0x4007368")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float TimeMax;

	// Token: 0x04008013 RID: 32787
	[Token(Token = "0x4007369")]
	[FieldOffset(Offset = "0x30")]
	private float JumpTime;

	// Token: 0x04008014 RID: 32788
	[Token(Token = "0x400736A")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 StartPos;

	// Token: 0x04008015 RID: 32789
	[Token(Token = "0x400736B")]
	[FieldOffset(Offset = "0x40")]
	private RectTransform RectTransform;
}
