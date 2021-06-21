using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AC2 RID: 2754
[Token(Token = "0x200073B")]
public class UIShopMoneyEffect : MonoBehaviour
{
	// Token: 0x060047A1 RID: 18337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C0F")]
	[Address(RVA = "0x211BDF0", Offset = "0x211BEF1", VA = "0x211BDF0")]
	public void CloneUse(Vector2 BasePos)
	{
	}

	// Token: 0x060047A2 RID: 18338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C10")]
	[Address(RVA = "0x211BF10", Offset = "0x211C011", VA = "0x211BF10")]
	private void SetCloneInit(Vector2 BasePos, UIShopMoneyEffect baseObj)
	{
	}

	// Token: 0x060047A3 RID: 18339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C11")]
	[Address(RVA = "0x211C0C0", Offset = "0x211C1C1", VA = "0x211C0C0")]
	private void Update()
	{
	}

	// Token: 0x060047A4 RID: 18340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C12")]
	[Address(RVA = "0x211C240", Offset = "0x211C341", VA = "0x211C240")]
	public UIShopMoneyEffect()
	{
	}

	// Token: 0x0400A6F7 RID: 42743
	[Token(Token = "0x4007E4B")]
	[FieldOffset(Offset = "0x18")]
	private Image Image;

	// Token: 0x0400A6F8 RID: 42744
	[Token(Token = "0x4007E4C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Color color;

	// Token: 0x0400A6F9 RID: 42745
	[Token(Token = "0x4007E4D")]
	[FieldOffset(Offset = "0x30")]
	private bool SetColor;

	// Token: 0x0400A6FA RID: 42746
	[Token(Token = "0x4007E4E")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public float MovTimeMax;

	// Token: 0x0400A6FB RID: 42747
	[Token(Token = "0x4007E4F")]
	[FieldOffset(Offset = "0x38")]
	private float MovTime;

	// Token: 0x0400A6FC RID: 42748
	[Token(Token = "0x4007E50")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public Vector2 AddRange;

	// Token: 0x0400A6FD RID: 42749
	[Token(Token = "0x4007E51")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public AnimationCurve scaleCurve;

	// Token: 0x0400A6FE RID: 42750
	[Token(Token = "0x4007E52")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x173C90", Offset = "0x173D91")]
	public float ScaleRandMin;

	// Token: 0x0400A6FF RID: 42751
	[Token(Token = "0x4007E53")]
	[FieldOffset(Offset = "0x54")]
	private float scaleMax;
}
