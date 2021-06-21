using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200054C RID: 1356
[Token(Token = "0x20003D6")]
public class AdjustAreaFog : MonoBehaviour
{
	// Token: 0x060020E4 RID: 8420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0x1D56FB0", Offset = "0x1D570B1", VA = "0x1D56FB0")]
	private void Awake()
	{
	}

	// Token: 0x060020E5 RID: 8421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BEA")]
	[Address(RVA = "0x1D57150", Offset = "0x1D57251", VA = "0x1D57150")]
	public void OnAreaEnter()
	{
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BEB")]
	[Address(RVA = "0x1D57200", Offset = "0x1D57301", VA = "0x1D57200")]
	public void OnAreaStay()
	{
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BEC")]
	[Address(RVA = "0x1D572A0", Offset = "0x1D573A1", VA = "0x1D572A0")]
	public void OnAreaExit()
	{
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BED")]
	[Address(RVA = "0x1D57320", Offset = "0x1D57421", VA = "0x1D57320")]
	public void OnAdjustEnter()
	{
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BEE")]
	[Address(RVA = "0x1D573D0", Offset = "0x1D574D1", VA = "0x1D573D0")]
	public void OnAdjustStay(float ratio)
	{
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BEF")]
	[Address(RVA = "0x1D57470", Offset = "0x1D57571", VA = "0x1D57470")]
	public void OnAdjustExit()
	{
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BF0")]
	[Address(RVA = "0x1D574F0", Offset = "0x1D575F1", VA = "0x1D574F0")]
	public AdjustAreaFog()
	{
	}

	// Token: 0x040067B9 RID: 26553
	[Token(Token = "0x40061A1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Color FogColor;

	// Token: 0x040067BA RID: 26554
	[Token(Token = "0x40061A2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float FogRate;

	// Token: 0x040067BB RID: 26555
	[Token(Token = "0x40061A3")]
	[FieldOffset(Offset = "0x2C")]
	private float AdjustRatio;

	// Token: 0x040067BC RID: 26556
	[Token(Token = "0x40061A4")]
	[FieldOffset(Offset = "0x30")]
	private bool IsAdjust;

	// Token: 0x040067BD RID: 26557
	[Token(Token = "0x40061A5")]
	[FieldOffset(Offset = "0x31")]
	private bool InArea;

	// Token: 0x040067BE RID: 26558
	[Token(Token = "0x40061A6")]
	[FieldOffset(Offset = "0x38")]
	private AreaFogAreaTrigger AreaFogAreaTrigger;

	// Token: 0x040067BF RID: 26559
	[Token(Token = "0x40061A7")]
	[FieldOffset(Offset = "0x40")]
	private AreaFogAdjustTrigger AreaFogAdjustTrigger;
}
