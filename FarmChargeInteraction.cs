using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008FC RID: 2300
[Token(Token = "0x2000606")]
public class FarmChargeInteraction : SingletonMonoBehaviour<FarmChargeInteraction>
{
	// Token: 0x06003C5D RID: 15453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60032B3")]
	[Address(RVA = "0x21A6930", Offset = "0x21A6A31", VA = "0x21A6930")]
	public List<ToolInteractionInterface> GetFocusInteractions()
	{
		return null;
	}

	// Token: 0x06003C5E RID: 15454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032B4")]
	[Address(RVA = "0x21A6940", Offset = "0x21A6A41", VA = "0x21A6940")]
	public void UpdateRotation()
	{
	}

	// Token: 0x06003C5F RID: 15455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032B5")]
	[Address(RVA = "0x21A6950", Offset = "0x21A6A51", VA = "0x21A6950")]
	public void OnMultiFocus(FarmRange farmRange, FarmAction action)
	{
	}

	// Token: 0x06003C60 RID: 15456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032B6")]
	[Address(RVA = "0x21A7AA0", Offset = "0x21A7BA1", VA = "0x21A7AA0")]
	public void OffMultiFocus()
	{
	}

	// Token: 0x06003C61 RID: 15457 RVA: 0x00015138 File Offset: 0x00013338
	[Token(Token = "0x60032B7")]
	[Address(RVA = "0x21A7CA0", Offset = "0x21A7DA1", VA = "0x21A7CA0")]
	public static bool IsSupportFarmInteractionType(ItemCategory itemCategory, ToolInteractionInterface target, HumanController human)
	{
		return default(bool);
	}

	// Token: 0x06003C62 RID: 15458 RVA: 0x00015150 File Offset: 0x00013350
	[Token(Token = "0x60032B8")]
	[Address(RVA = "0x21A71D0", Offset = "0x21A72D1", VA = "0x21A71D0")]
	public static bool IsSupportFarmInteractionType(FarmAction action, ToolInteractionInterface target, HumanController human, bool isMulti = false)
	{
		return default(bool);
	}

	// Token: 0x06003C63 RID: 15459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032B9")]
	[Address(RVA = "0x21A7D50", Offset = "0x21A7E51", VA = "0x21A7D50")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x06003C64 RID: 15460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032BA")]
	[Address(RVA = "0x21A7DD0", Offset = "0x21A7ED1", VA = "0x21A7DD0")]
	public FarmChargeInteraction()
	{
	}

	// Token: 0x04007ECE RID: 32462
	[Token(Token = "0x4007279")]
	[FieldOffset(Offset = "0x18")]
	private readonly Vector3[] DefineBoxSize;

	// Token: 0x04007ECF RID: 32463
	[Token(Token = "0x400727A")]
	[FieldOffset(Offset = "0x20")]
	private List<ToolInteractionInterface> FocusInteractionList;

	// Token: 0x04007ED0 RID: 32464
	[Token(Token = "0x400727B")]
	[FieldOffset(Offset = "0x28")]
	private FarmRange CurrentFarmRange;

	// Token: 0x04007ED1 RID: 32465
	[Token(Token = "0x400727C")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 BoxSize;

	// Token: 0x04007ED2 RID: 32466
	[Token(Token = "0x400727D")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 BoxPosition;

	// Token: 0x04007ED3 RID: 32467
	[Token(Token = "0x400727E")]
	[FieldOffset(Offset = "0x44")]
	private FarmAction CurrentFarmAction;
}
