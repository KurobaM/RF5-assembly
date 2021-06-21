using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009B7 RID: 2487
[Token(Token = "0x2000682")]
public class HUDNowAreaPosition : MonoBehaviour
{
	// Token: 0x060040FD RID: 16637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003630")]
	[Address(RVA = "0x2058250", Offset = "0x2058351", VA = "0x2058250")]
	private void Awake()
	{
	}

	// Token: 0x060040FE RID: 16638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003631")]
	[Address(RVA = "0x20582D0", Offset = "0x20583D1", VA = "0x20582D0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060040FF RID: 16639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003632")]
	[Address(RVA = "0x2058450", Offset = "0x2058551", VA = "0x2058450")]
	public HUDNowAreaPosition()
	{
	}

	// Token: 0x04009FBC RID: 40892
	[Token(Token = "0x400786F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private FocusObjectName FocusObjectName;

	// Token: 0x04009FBD RID: 40893
	[Token(Token = "0x4007870")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector2 AddPosByFocusObjectName;

	// Token: 0x04009FBE RID: 40894
	[Token(Token = "0x4007871")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform rect;

	// Token: 0x04009FBF RID: 40895
	[Token(Token = "0x4007872")]
	[FieldOffset(Offset = "0x30")]
	private bool focusing;

	// Token: 0x04009FC0 RID: 40896
	[Token(Token = "0x4007873")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text Text;

	// Token: 0x04009FC1 RID: 40897
	[Token(Token = "0x4007874")]
	[FieldOffset(Offset = "0x40")]
	private string myText;
}
