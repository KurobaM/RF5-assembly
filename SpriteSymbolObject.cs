using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008AF RID: 2223
[Token(Token = "0x20005C4")]
public class SpriteSymbolObject : MonoBehaviour
{
	// Token: 0x06003B01 RID: 15105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316F")]
	[Address(RVA = "0x23882D0", Offset = "0x23883D1", VA = "0x23882D0")]
	public void SetIcon(Sprite _border, Sprite _icon)
	{
	}

	// Token: 0x06003B02 RID: 15106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003170")]
	[Address(RVA = "0x2388320", Offset = "0x2388421", VA = "0x2388320")]
	private void LateUpdate()
	{
	}

	// Token: 0x06003B03 RID: 15107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003171")]
	[Address(RVA = "0x23885A0", Offset = "0x23886A1", VA = "0x23885A0")]
	public SpriteSymbolObject()
	{
	}

	// Token: 0x04007DBF RID: 32191
	[Token(Token = "0x40071AC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SpriteRenderer border;

	// Token: 0x04007DC0 RID: 32192
	[Token(Token = "0x40071AD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SpriteRenderer icon;

	// Token: 0x04007DC1 RID: 32193
	[Token(Token = "0x40071AE")]
	[FieldOffset(Offset = "0x28")]
	private float distance;

	// Token: 0x04007DC2 RID: 32194
	[Token(Token = "0x40071AF")]
	private const float FADE_START_DISTANCE = 5f;

	// Token: 0x04007DC3 RID: 32195
	[Token(Token = "0x40071B0")]
	private const float FADE_END_DISTANCE = 3.5f;
}
