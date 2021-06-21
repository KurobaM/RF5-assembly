using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A93 RID: 2707
[Token(Token = "0x2000717")]
public class UIRankupShineEffect : MonoBehaviour
{
	// Token: 0x0600466F RID: 18031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AF3")]
	[Address(RVA = "0x1EAEB10", Offset = "0x1EAEC11", VA = "0x1EAEB10")]
	public void CloneUse(Vector2 BasePos)
	{
	}

	// Token: 0x06004670 RID: 18032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AF4")]
	[Address(RVA = "0x1EAEC30", Offset = "0x1EAED31", VA = "0x1EAEC30")]
	private void SetCloneInit(Vector2 BasePos, UIRankupShineEffect baseObj)
	{
	}

	// Token: 0x06004671 RID: 18033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AF5")]
	[Address(RVA = "0x1EAEDE0", Offset = "0x1EAEEE1", VA = "0x1EAEDE0")]
	private void Update()
	{
	}

	// Token: 0x06004672 RID: 18034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AF6")]
	[Address(RVA = "0x1EAEF60", Offset = "0x1EAF061", VA = "0x1EAEF60")]
	public UIRankupShineEffect()
	{
	}

	// Token: 0x0400A570 RID: 42352
	[Token(Token = "0x4007CF7")]
	[FieldOffset(Offset = "0x18")]
	private Image Image;

	// Token: 0x0400A571 RID: 42353
	[Token(Token = "0x4007CF8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Color color;

	// Token: 0x0400A572 RID: 42354
	[Token(Token = "0x4007CF9")]
	[FieldOffset(Offset = "0x30")]
	private bool SetColor;

	// Token: 0x0400A573 RID: 42355
	[Token(Token = "0x4007CFA")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public float MovTimeMax;

	// Token: 0x0400A574 RID: 42356
	[Token(Token = "0x4007CFB")]
	[FieldOffset(Offset = "0x38")]
	private float MovTime;

	// Token: 0x0400A575 RID: 42357
	[Token(Token = "0x4007CFC")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public Vector2 AddRange;

	// Token: 0x0400A576 RID: 42358
	[Token(Token = "0x4007CFD")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public AnimationCurve scaleCurve;

	// Token: 0x0400A577 RID: 42359
	[Token(Token = "0x4007CFE")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x1731A0", Offset = "0x1732A1")]
	public float ScaleRandMin;

	// Token: 0x0400A578 RID: 42360
	[Token(Token = "0x4007CFF")]
	[FieldOffset(Offset = "0x54")]
	private float scaleMax;
}
