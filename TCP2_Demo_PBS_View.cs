using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B57 RID: 2903
[Token(Token = "0x2000790")]
public class TCP2_Demo_PBS_View : MonoBehaviour
{
	// Token: 0x06004AB1 RID: 19121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E90")]
	[Address(RVA = "0x1FBBE20", Offset = "0x1FBBF21", VA = "0x1FBBE20")]
	private void Awake()
	{
	}

	// Token: 0x06004AB2 RID: 19122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E91")]
	[Address(RVA = "0x1FBBEB0", Offset = "0x1FBBFB1", VA = "0x1FBBEB0")]
	private void OnEnable()
	{
	}

	// Token: 0x06004AB3 RID: 19123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E92")]
	[Address(RVA = "0x1FBBEE0", Offset = "0x1FBBFE1", VA = "0x1FBBEE0")]
	private void Update()
	{
	}

	// Token: 0x06004AB4 RID: 19124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E93")]
	[Address(RVA = "0x1FBC6E0", Offset = "0x1FBC7E1", VA = "0x1FBC6E0")]
	public void ResetView()
	{
	}

	// Token: 0x06004AB5 RID: 19125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E94")]
	[Address(RVA = "0x1FBC7F0", Offset = "0x1FBC8F1", VA = "0x1FBC7F0")]
	public TCP2_Demo_PBS_View()
	{
	}

	// Token: 0x0400AB16 RID: 43798
	[Token(Token = "0x400810F")]
	[FieldOffset(Offset = "0x18")]
	public Transform Pivot;

	// Token: 0x0400AB17 RID: 43799
	[Token(Token = "0x4008110")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174BE0", Offset = "0x174CE1")]
	public float OrbitStrg;

	// Token: 0x0400AB18 RID: 43800
	[Token(Token = "0x4008111")]
	[FieldOffset(Offset = "0x24")]
	public float OrbitClamp;

	// Token: 0x0400AB19 RID: 43801
	[Token(Token = "0x4008112")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174C20", Offset = "0x174D21")]
	public float PanStrg;

	// Token: 0x0400AB1A RID: 43802
	[Token(Token = "0x4008113")]
	[FieldOffset(Offset = "0x2C")]
	public float PanClamp;

	// Token: 0x0400AB1B RID: 43803
	[Token(Token = "0x4008114")]
	[FieldOffset(Offset = "0x30")]
	public float yMin;

	// Token: 0x0400AB1C RID: 43804
	[Token(Token = "0x4008115")]
	[FieldOffset(Offset = "0x34")]
	public float yMax;

	// Token: 0x0400AB1D RID: 43805
	[Token(Token = "0x4008116")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174C60", Offset = "0x174D61")]
	public float ZoomStrg;

	// Token: 0x0400AB1E RID: 43806
	[Token(Token = "0x4008117")]
	[FieldOffset(Offset = "0x3C")]
	public float ZoomClamp;

	// Token: 0x0400AB1F RID: 43807
	[Token(Token = "0x4008118")]
	[FieldOffset(Offset = "0x40")]
	public float ZoomDistMin;

	// Token: 0x0400AB20 RID: 43808
	[Token(Token = "0x4008119")]
	[FieldOffset(Offset = "0x44")]
	public float ZoomDistMax;

	// Token: 0x0400AB21 RID: 43809
	[Token(Token = "0x400811A")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174CA0", Offset = "0x174DA1")]
	public float Decceleration;

	// Token: 0x0400AB22 RID: 43810
	[Token(Token = "0x400811B")]
	[FieldOffset(Offset = "0x4C")]
	public Rect ignoreMouseRect;

	// Token: 0x0400AB23 RID: 43811
	[Token(Token = "0x400811C")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 mouseDelta;

	// Token: 0x0400AB24 RID: 43812
	[Token(Token = "0x400811D")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 orbitAcceleration;

	// Token: 0x0400AB25 RID: 43813
	[Token(Token = "0x400811E")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 panAcceleration;

	// Token: 0x0400AB26 RID: 43814
	[Token(Token = "0x400811F")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 moveAcceleration;

	// Token: 0x0400AB27 RID: 43815
	[Token(Token = "0x4008120")]
	[FieldOffset(Offset = "0x8C")]
	private float zoomAcceleration;

	// Token: 0x0400AB28 RID: 43816
	[Token(Token = "0x4008121")]
	private const float XMax = 60f;

	// Token: 0x0400AB29 RID: 43817
	[Token(Token = "0x4008122")]
	private const float XMin = 300f;

	// Token: 0x0400AB2A RID: 43818
	[Token(Token = "0x4008123")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 mResetCamPos;

	// Token: 0x0400AB2B RID: 43819
	[Token(Token = "0x4008124")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 mResetPivotPos;

	// Token: 0x0400AB2C RID: 43820
	[Token(Token = "0x4008125")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 mResetCamRot;

	// Token: 0x0400AB2D RID: 43821
	[Token(Token = "0x4008126")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 mResetPivotRot;

	// Token: 0x0400AB2E RID: 43822
	[Token(Token = "0x4008127")]
	[FieldOffset(Offset = "0xC0")]
	private bool leftMouseHeld;

	// Token: 0x0400AB2F RID: 43823
	[Token(Token = "0x4008128")]
	[FieldOffset(Offset = "0xC1")]
	private bool rightMouseHeld;

	// Token: 0x0400AB30 RID: 43824
	[Token(Token = "0x4008129")]
	[FieldOffset(Offset = "0xC2")]
	private bool middleMouseHeld;
}
