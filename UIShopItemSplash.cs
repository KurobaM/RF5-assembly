using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AC0 RID: 2752
[Token(Token = "0x2000739")]
public class UIShopItemSplash : MonoBehaviour
{
	// Token: 0x0600479C RID: 18332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003C0A")]
	[Address(RVA = "0x211B980", Offset = "0x211BA81", VA = "0x211B980")]
	public UIShopItemSplash CloneUse(Image baseItem)
	{
		return null;
	}

	// Token: 0x0600479D RID: 18333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C0B")]
	[Address(RVA = "0x211BA90", Offset = "0x211BB91", VA = "0x211BA90")]
	public void SetCloneInit(Image baseItem, UIShopItemSplash originalObj)
	{
	}

	// Token: 0x0600479E RID: 18334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C0C")]
	[Address(RVA = "0x211BC60", Offset = "0x211BD61", VA = "0x211BC60")]
	private void Update()
	{
	}

	// Token: 0x0600479F RID: 18335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C0D")]
	[Address(RVA = "0x211BDD0", Offset = "0x211BED1", VA = "0x211BDD0")]
	public UIShopItemSplash()
	{
	}

	// Token: 0x0400A6F0 RID: 42736
	[Token(Token = "0x4007E44")]
	[FieldOffset(Offset = "0x18")]
	private Image Image;

	// Token: 0x0400A6F1 RID: 42737
	[Token(Token = "0x4007E45")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 RandForce;

	// Token: 0x0400A6F2 RID: 42738
	[Token(Token = "0x4007E46")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 Force;

	// Token: 0x0400A6F3 RID: 42739
	[Token(Token = "0x4007E47")]
	[FieldOffset(Offset = "0x30")]
	public float lifeTimeMax;

	// Token: 0x0400A6F4 RID: 42740
	[Token(Token = "0x4007E48")]
	[FieldOffset(Offset = "0x34")]
	private float lifeTime;

	// Token: 0x0400A6F5 RID: 42741
	[Token(Token = "0x4007E49")]
	[FieldOffset(Offset = "0x38")]
	public float Gravity;
}
