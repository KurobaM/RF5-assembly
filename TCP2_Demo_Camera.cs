using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B4C RID: 2892
[Token(Token = "0x200078B")]
public class TCP2_Demo_Camera : MonoBehaviour
{
	// Token: 0x06004A6E RID: 19054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E53")]
	[Address(RVA = "0x1FB8F30", Offset = "0x1FB9031", VA = "0x1FB8F30")]
	private void Awake()
	{
	}

	// Token: 0x06004A6F RID: 19055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E54")]
	[Address(RVA = "0x1FB8FC0", Offset = "0x1FB90C1", VA = "0x1FB8FC0")]
	private void OnEnable()
	{
	}

	// Token: 0x06004A70 RID: 19056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E55")]
	[Address(RVA = "0x1FB8FF0", Offset = "0x1FB90F1", VA = "0x1FB8FF0")]
	private void Update()
	{
	}

	// Token: 0x06004A71 RID: 19057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E56")]
	[Address(RVA = "0x1FB9860", Offset = "0x1FB9961", VA = "0x1FB9860")]
	public void ResetView()
	{
	}

	// Token: 0x06004A72 RID: 19058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E57")]
	[Address(RVA = "0x1FB9970", Offset = "0x1FB9A71", VA = "0x1FB9970")]
	public TCP2_Demo_Camera()
	{
	}

	// Token: 0x0400AA9D RID: 43677
	[Token(Token = "0x40080A6")]
	[FieldOffset(Offset = "0x18")]
	public Transform Pivot;

	// Token: 0x0400AA9E RID: 43678
	[Token(Token = "0x40080A7")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174A40", Offset = "0x174B41")]
	public float OrbitStrg;

	// Token: 0x0400AA9F RID: 43679
	[Token(Token = "0x40080A8")]
	[FieldOffset(Offset = "0x24")]
	public float OrbitClamp;

	// Token: 0x0400AAA0 RID: 43680
	[Token(Token = "0x40080A9")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174A80", Offset = "0x174B81")]
	public float PanStrgMin;

	// Token: 0x0400AAA1 RID: 43681
	[Token(Token = "0x40080AA")]
	[FieldOffset(Offset = "0x2C")]
	public float PanStrgMax;

	// Token: 0x0400AAA2 RID: 43682
	[Token(Token = "0x40080AB")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174AC0", Offset = "0x174BC1")]
	public float ZoomStrg;

	// Token: 0x0400AAA3 RID: 43683
	[Token(Token = "0x40080AC")]
	[FieldOffset(Offset = "0x34")]
	public float ZoomClamp;

	// Token: 0x0400AAA4 RID: 43684
	[Token(Token = "0x40080AD")]
	[FieldOffset(Offset = "0x38")]
	public float ZoomDistMin;

	// Token: 0x0400AAA5 RID: 43685
	[Token(Token = "0x40080AE")]
	[FieldOffset(Offset = "0x3C")]
	public float ZoomDistMax;

	// Token: 0x0400AAA6 RID: 43686
	[Token(Token = "0x40080AF")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x174B00", Offset = "0x174C01")]
	public float Decceleration;

	// Token: 0x0400AAA7 RID: 43687
	[Token(Token = "0x40080B0")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform ignoreMouseRect;

	// Token: 0x0400AAA8 RID: 43688
	[Token(Token = "0x40080B1")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 mouseDelta;

	// Token: 0x0400AAA9 RID: 43689
	[Token(Token = "0x40080B2")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 orbitAcceleration;

	// Token: 0x0400AAAA RID: 43690
	[Token(Token = "0x40080B3")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 panAcceleration;

	// Token: 0x0400AAAB RID: 43691
	[Token(Token = "0x40080B4")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 moveAcceleration;

	// Token: 0x0400AAAC RID: 43692
	[Token(Token = "0x40080B5")]
	[FieldOffset(Offset = "0x80")]
	private float zoomAcceleration;

	// Token: 0x0400AAAD RID: 43693
	[Token(Token = "0x40080B6")]
	[FieldOffset(Offset = "0x84")]
	private float zoomDistance;

	// Token: 0x0400AAAE RID: 43694
	[Token(Token = "0x40080B7")]
	private const float XMax = 60f;

	// Token: 0x0400AAAF RID: 43695
	[Token(Token = "0x40080B8")]
	private const float XMin = 300f;

	// Token: 0x0400AAB0 RID: 43696
	[Token(Token = "0x40080B9")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 mResetCamPos;

	// Token: 0x0400AAB1 RID: 43697
	[Token(Token = "0x40080BA")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 mResetPivotPos;

	// Token: 0x0400AAB2 RID: 43698
	[Token(Token = "0x40080BB")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 mResetCamRot;

	// Token: 0x0400AAB3 RID: 43699
	[Token(Token = "0x40080BC")]
	[FieldOffset(Offset = "0xAC")]
	private Vector3 mResetPivotRot;

	// Token: 0x0400AAB4 RID: 43700
	[Token(Token = "0x40080BD")]
	[FieldOffset(Offset = "0xB8")]
	private bool leftMouseHeld;

	// Token: 0x0400AAB5 RID: 43701
	[Token(Token = "0x40080BE")]
	[FieldOffset(Offset = "0xB9")]
	private bool rightMouseHeld;

	// Token: 0x0400AAB6 RID: 43702
	[Token(Token = "0x40080BF")]
	[FieldOffset(Offset = "0xBA")]
	private bool middleMouseHeld;
}
