using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000934 RID: 2356
[Token(Token = "0x2000629")]
public class AdvCharaMoveAnim : AdvCharaAnim
{
	// Token: 0x06003E61 RID: 15969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D5")]
	[Address(RVA = "0x1D5AB20", Offset = "0x1D5AC21", VA = "0x1D5AB20", Slot = "4")]
	public override void PlayAnim()
	{
	}

	// Token: 0x06003E62 RID: 15970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D6")]
	[Address(RVA = "0x1D5AC00", Offset = "0x1D5AD01", VA = "0x1D5AC00", Slot = "5")]
	public override void EndAnim()
	{
	}

	// Token: 0x06003E63 RID: 15971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D7")]
	[Address(RVA = "0x1D5AC70", Offset = "0x1D5AD71", VA = "0x1D5AC70")]
	private void Update()
	{
	}

	// Token: 0x06003E64 RID: 15972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D8")]
	[Address(RVA = "0x1D5AD70", Offset = "0x1D5AE71", VA = "0x1D5AD70")]
	public AdvCharaMoveAnim()
	{
	}

	// Token: 0x04008016 RID: 32790
	[Token(Token = "0x400736C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AnimationCurve PlayCurve;

	// Token: 0x04008017 RID: 32791
	[Token(Token = "0x400736D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float MoveRangeX;

	// Token: 0x04008018 RID: 32792
	[Token(Token = "0x400736E")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float MoveRangeY;

	// Token: 0x04008019 RID: 32793
	[Token(Token = "0x400736F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float TimeMax;

	// Token: 0x0400801A RID: 32794
	[Token(Token = "0x4007370")]
	[FieldOffset(Offset = "0x34")]
	private float playTime;

	// Token: 0x0400801B RID: 32795
	[Token(Token = "0x4007371")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool ResetPosOnEnd;

	// Token: 0x0400801C RID: 32796
	[Token(Token = "0x4007372")]
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	private bool ResetPosOnStart;

	// Token: 0x0400801D RID: 32797
	[Token(Token = "0x4007373")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 StartPos;

	// Token: 0x0400801E RID: 32798
	[Token(Token = "0x4007374")]
	[FieldOffset(Offset = "0x48")]
	private RectTransform RectTransform;
}
