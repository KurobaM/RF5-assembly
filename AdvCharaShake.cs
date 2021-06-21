using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000935 RID: 2357
[Token(Token = "0x200062A")]
public class AdvCharaShake : AdvCharaAnim
{
	// Token: 0x06003E65 RID: 15973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033D9")]
	[Address(RVA = "0x1D5AD80", Offset = "0x1D5AE81", VA = "0x1D5AD80", Slot = "4")]
	public override void PlayAnim()
	{
	}

	// Token: 0x06003E66 RID: 15974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033DA")]
	[Address(RVA = "0x1D5AEE0", Offset = "0x1D5AFE1", VA = "0x1D5AEE0", Slot = "5")]
	public override void EndAnim()
	{
	}

	// Token: 0x06003E67 RID: 15975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033DB")]
	[Address(RVA = "0x1D5AF60", Offset = "0x1D5B061", VA = "0x1D5AF60")]
	private void Update()
	{
	}

	// Token: 0x06003E68 RID: 15976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033DC")]
	[Address(RVA = "0x1D5B130", Offset = "0x1D5B231", VA = "0x1D5B130")]
	public AdvCharaShake()
	{
	}

	// Token: 0x0400801F RID: 32799
	[Token(Token = "0x4007375")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector2 MoveRange;

	// Token: 0x04008020 RID: 32800
	[Token(Token = "0x4007376")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 NowPos;

	// Token: 0x04008021 RID: 32801
	[Token(Token = "0x4007377")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 NextPos;

	// Token: 0x04008022 RID: 32802
	[Token(Token = "0x4007378")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float TimeMax;

	// Token: 0x04008023 RID: 32803
	[Token(Token = "0x4007379")]
	[FieldOffset(Offset = "0x38")]
	private float playTime;

	// Token: 0x04008024 RID: 32804
	[Token(Token = "0x400737A")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int ShakeCountMax;

	// Token: 0x04008025 RID: 32805
	[Token(Token = "0x400737B")]
	[FieldOffset(Offset = "0x40")]
	private int ShakeCount;

	// Token: 0x04008026 RID: 32806
	[Token(Token = "0x400737C")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool ResetPosOnEnd;

	// Token: 0x04008027 RID: 32807
	[Token(Token = "0x400737D")]
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	private bool ResetPosOnStart;

	// Token: 0x04008028 RID: 32808
	[Token(Token = "0x400737E")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 StartPos;

	// Token: 0x04008029 RID: 32809
	[Token(Token = "0x400737F")]
	[FieldOffset(Offset = "0x50")]
	private RectTransform RectTransform;
}
