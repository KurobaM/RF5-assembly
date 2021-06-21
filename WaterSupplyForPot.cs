using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000600 RID: 1536
[Token(Token = "0x2000451")]
public class WaterSupplyForPot : MonoBehaviour, PotInteractionInterface, ToolInteractionInterface, FocusInterface
{
	// Token: 0x060025FC RID: 9724 RVA: 0x0000F090 File Offset: 0x0000D290
	[Token(Token = "0x6002004")]
	[Address(RVA = "0x1E508E0", Offset = "0x1E509E1", VA = "0x1E508E0", Slot = "4")]
	public bool UsePot(HumanController humanController, EquipItemData equipItemData)
	{
		return default(bool);
	}

	// Token: 0x060025FD RID: 9725 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
	[Token(Token = "0x6002005")]
	[Address(RVA = "0x1E508F0", Offset = "0x1E509F1", VA = "0x1E508F0", Slot = "5")]
	public bool CanUsePot(HumanController humanController, EquipItemData equipItemData, bool isRange)
	{
		return default(bool);
	}

	// Token: 0x060025FE RID: 9726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002006")]
	[Address(RVA = "0x1E50900", Offset = "0x1E50A01", VA = "0x1E50900", Slot = "6")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x1700061C RID: 1564
	// (get) Token: 0x060025FF RID: 9727 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
	[Token(Token = "0x170004DA")]
	public bool Focusable
	{
		[Token(Token = "0x6002007")]
		[Address(RVA = "0x1E50950", Offset = "0x1E50A51", VA = "0x1E50950", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700061D RID: 1565
	// (get) Token: 0x06002600 RID: 9728 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
	[Token(Token = "0x170004DB")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x1E50960", Offset = "0x1E50A61", VA = "0x1E50960", Slot = "10")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x1700061E RID: 1566
	// (get) Token: 0x06002601 RID: 9729 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
	[Token(Token = "0x170004DC")]
	public int FocusPriority
	{
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x1E50970", Offset = "0x1E50A71", VA = "0x1E50970", Slot = "11")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700061F RID: 1567
	// (get) Token: 0x06002602 RID: 9730 RVA: 0x0000F108 File Offset: 0x0000D308
	[Token(Token = "0x170004DD")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x1E50980", Offset = "0x1E50A81", VA = "0x1E50980", Slot = "12")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x06002603 RID: 9731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600200B")]
	[Address(RVA = "0x1E50990", Offset = "0x1E50A91", VA = "0x1E50990", Slot = "8")]
	public void OnFocus()
	{
	}

	// Token: 0x06002604 RID: 9732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600200C")]
	[Address(RVA = "0x1E509A0", Offset = "0x1E50AA1", VA = "0x1E509A0", Slot = "9")]
	public void OffFocus()
	{
	}

	// Token: 0x06002605 RID: 9733 RVA: 0x0000F120 File Offset: 0x0000D320
	[Token(Token = "0x600200D")]
	[Address(RVA = "0x1E509B0", Offset = "0x1E50AB1", VA = "0x1E509B0", Slot = "13")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x06002606 RID: 9734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600200E")]
	[Address(RVA = "0x1E509C0", Offset = "0x1E50AC1", VA = "0x1E509C0")]
	public WaterSupplyForPot()
	{
	}

	// Token: 0x06002607 RID: 9735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600200F")]
	[Address(RVA = "0x1E509D0", Offset = "0x1E50AD1", VA = "0x1E509D0", Slot = "14")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06002608 RID: 9736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002010")]
	[Address(RVA = "0x1E509E0", Offset = "0x1E50AE1", VA = "0x1E509E0", Slot = "15")]
	private Transform get_transform()
	{
		return null;
	}
}
