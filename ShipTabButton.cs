using System;
using Il2CppDummyDll;
using RF5SHIPPING;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000AA8 RID: 2728
[Token(Token = "0x2000728")]
public class ShipTabButton : MonoBehaviour
{
	// Token: 0x1700097C RID: 2428
	// (get) Token: 0x060046F9 RID: 18169 RVA: 0x00017388 File Offset: 0x00015588
	[Token(Token = "0x1700079E")]
	public ShippingCategory ShippingCategory
	{
		[Token(Token = "0x6003B7B")]
		[Address(RVA = "0x1E37810", Offset = "0x1E37911", VA = "0x1E37810")]
		get
		{
			return ShippingCategory.Crop;
		}
	}

	// Token: 0x060046FA RID: 18170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B7C")]
	[Address(RVA = "0x1E37820", Offset = "0x1E37921", VA = "0x1E37820")]
	private void DoWork()
	{
	}

	// Token: 0x060046FB RID: 18171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B7D")]
	[Address(RVA = "0x1E37840", Offset = "0x1E37941", VA = "0x1E37840")]
	public void DoOpen()
	{
	}

	// Token: 0x060046FC RID: 18172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B7E")]
	[Address(RVA = "0x1E37910", Offset = "0x1E37A11", VA = "0x1E37910")]
	public void DoClose()
	{
	}

	// Token: 0x060046FD RID: 18173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B7F")]
	[Address(RVA = "0x1E379E0", Offset = "0x1E37AE1", VA = "0x1E379E0")]
	private void Start()
	{
	}

	// Token: 0x060046FE RID: 18174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B80")]
	[Address(RVA = "0x1E37BB0", Offset = "0x1E37CB1", VA = "0x1E37BB0")]
	public ShipTabButton()
	{
	}

	// Token: 0x060046FF RID: 18175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B81")]
	[Address(RVA = "0x1E37BC0", Offset = "0x1E37CC1", VA = "0x1E37BC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7F70", Offset = "0x1A8071")]
	private void <Start>b__10_0(BaseEventData x)
	{
	}

	// Token: 0x0400A5FB RID: 42491
	[Token(Token = "0x4007D6C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ShippingCategory _ShippingCategory;

	// Token: 0x0400A5FC RID: 42492
	[Token(Token = "0x4007D6D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UIShipmentRecordMain UIShipmentRecordMain;

	// Token: 0x0400A5FD RID: 42493
	[Token(Token = "0x4007D6E")]
	[FieldOffset(Offset = "0x28")]
	private Image Image;

	// Token: 0x0400A5FE RID: 42494
	[Token(Token = "0x4007D6F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite OnSprite;

	// Token: 0x0400A5FF RID: 42495
	[Token(Token = "0x4007D70")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite OffSprite;
}
