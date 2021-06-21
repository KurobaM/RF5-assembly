using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008AD RID: 2221
[Token(Token = "0x20005C3")]
public class FarmSymbolObject : MonoBehaviour
{
	// Token: 0x06003AFD RID: 15101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316B")]
	[Address(RVA = "0x21B10E0", Offset = "0x21B11E1", VA = "0x21B10E0")]
	private void Start()
	{
	}

	// Token: 0x06003AFE RID: 15102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316C")]
	[Address(RVA = "0x21B1120", Offset = "0x21B1221", VA = "0x21B1120")]
	private void Update()
	{
	}

	// Token: 0x06003AFF RID: 15103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316D")]
	[Address(RVA = "0x21B1380", Offset = "0x21B1481", VA = "0x21B1380")]
	private void UpdateAnimation()
	{
	}

	// Token: 0x06003B00 RID: 15104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316E")]
	[Address(RVA = "0x21B15C0", Offset = "0x21B16C1", VA = "0x21B15C0")]
	public FarmSymbolObject()
	{
	}

	// Token: 0x04007DAD RID: 32173
	[Token(Token = "0x400719F")]
	[FieldOffset(Offset = "0x18")]
	private bool isFocusing;

	// Token: 0x04007DAE RID: 32174
	[Token(Token = "0x40071A0")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 startPos;

	// Token: 0x04007DAF RID: 32175
	[Token(Token = "0x40071A1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject focusSymbolModel;

	// Token: 0x04007DB0 RID: 32176
	[Token(Token = "0x40071A2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject normalSymbolModel;

	// Token: 0x04007DB1 RID: 32177
	[Token(Token = "0x40071A3")]
	[FieldOffset(Offset = "0x38")]
	private float curveRate;

	// Token: 0x04007DB2 RID: 32178
	[Token(Token = "0x40071A4")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve animCurve;

	// Token: 0x04007DB3 RID: 32179
	[Token(Token = "0x40071A5")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float curveSpeed;

	// Token: 0x04007DB4 RID: 32180
	[Token(Token = "0x40071A6")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float animHeight;

	// Token: 0x04007DB5 RID: 32181
	[Token(Token = "0x40071A7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float rotateSpeed;

	// Token: 0x04007DB6 RID: 32182
	[Token(Token = "0x40071A8")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float startAnimSpeed;

	// Token: 0x04007DB7 RID: 32183
	[Token(Token = "0x40071A9")]
	[FieldOffset(Offset = "0x58")]
	private FarmSymbolObject.AnimState state;

	// Token: 0x04007DB8 RID: 32184
	[Token(Token = "0x40071AA")]
	[FieldOffset(Offset = "0x5C")]
	private float rate;

	// Token: 0x04007DB9 RID: 32185
	[Token(Token = "0x40071AB")]
	[FieldOffset(Offset = "0x60")]
	private float scale;

	// Token: 0x020008AE RID: 2222
	[Token(Token = "0x200126D")]
	private enum AnimState
	{
		// Token: 0x04007DBB RID: 32187
		[Token(Token = "0x4019874")]
		Init,
		// Token: 0x04007DBC RID: 32188
		[Token(Token = "0x4019875")]
		ScaleUp,
		// Token: 0x04007DBD RID: 32189
		[Token(Token = "0x4019876")]
		ScaleDown,
		// Token: 0x04007DBE RID: 32190
		[Token(Token = "0x4019877")]
		Loop
	}
}
