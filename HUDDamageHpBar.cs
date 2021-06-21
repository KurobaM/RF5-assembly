using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009A1 RID: 2465
[Token(Token = "0x2000676")]
public class HUDDamageHpBar : MonoBehaviour
{
	// Token: 0x0600407C RID: 16508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C5")]
	[Address(RVA = "0x20447E0", Offset = "0x20448E1", VA = "0x20447E0")]
	public void SetDamage(float Hp, float HpMax, float newHp, float newHpMax, float SizeX)
	{
	}

	// Token: 0x0600407D RID: 16509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C6")]
	[Address(RVA = "0x2048160", Offset = "0x2048261", VA = "0x2048160")]
	private void Update()
	{
	}

	// Token: 0x0600407E RID: 16510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035C7")]
	[Address(RVA = "0x20482B0", Offset = "0x20483B1", VA = "0x20482B0")]
	public HUDDamageHpBar()
	{
	}

	// Token: 0x04009F19 RID: 40729
	[Token(Token = "0x40077EA")]
	[FieldOffset(Offset = "0x18")]
	private Image Image;

	// Token: 0x04009F1A RID: 40730
	[Token(Token = "0x40077EB")]
	private const float StayTime = 0.25f;

	// Token: 0x04009F1B RID: 40731
	[Token(Token = "0x40077EC")]
	private const float DispTime = 0.5f;

	// Token: 0x04009F1C RID: 40732
	[Token(Token = "0x40077ED")]
	[FieldOffset(Offset = "0x20")]
	private float nowTime;

	// Token: 0x04009F1D RID: 40733
	[Token(Token = "0x40077EE")]
	[FieldOffset(Offset = "0x24")]
	private float Lx;

	// Token: 0x04009F1E RID: 40734
	[Token(Token = "0x40077EF")]
	[FieldOffset(Offset = "0x28")]
	private float Rx;

	// Token: 0x04009F1F RID: 40735
	[Token(Token = "0x40077F0")]
	[FieldOffset(Offset = "0x2C")]
	private float startX;

	// Token: 0x04009F20 RID: 40736
	[Token(Token = "0x40077F1")]
	[FieldOffset(Offset = "0x30")]
	private float endX;

	// Token: 0x04009F21 RID: 40737
	[Token(Token = "0x40077F2")]
	[FieldOffset(Offset = "0x34")]
	private float sizeX;

	// Token: 0x04009F22 RID: 40738
	[Token(Token = "0x40077F3")]
	[FieldOffset(Offset = "0x38")]
	private float XPos;
}
