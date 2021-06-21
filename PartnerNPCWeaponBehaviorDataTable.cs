using System;
using Il2CppDummyDll;

// Token: 0x02000824 RID: 2084
[Token(Token = "0x2000560")]
[Serializable]
public struct PartnerNPCWeaponBehaviorDataTable
{
	// Token: 0x060037AA RID: 14250 RVA: 0x00013290 File Offset: 0x00011490
	[Token(Token = "0x6002E5F")]
	[Address(RVA = "0x2136FD0", Offset = "0x21370D1", VA = "0x2136FD0")]
	public static PartnerNPCWeaponBehaviorDataTable GetDataTable(ItemCategory itemCategory)
	{
		return default(PartnerNPCWeaponBehaviorDataTable);
	}

	// Token: 0x04007AD0 RID: 31440
	[Token(Token = "0x4006F32")]
	[FieldOffset(Offset = "0x0")]
	public ItemCategory ItemCategory;

	// Token: 0x04007AD1 RID: 31441
	[Token(Token = "0x4006F33")]
	[FieldOffset(Offset = "0x4")]
	public float MinRange;

	// Token: 0x04007AD2 RID: 31442
	[Token(Token = "0x4006F34")]
	[FieldOffset(Offset = "0x8")]
	public float MaxRange;

	// Token: 0x04007AD3 RID: 31443
	[Token(Token = "0x4006F35")]
	[FieldOffset(Offset = "0xC")]
	public float IntervalTime;

	// Token: 0x04007AD4 RID: 31444
	[Token(Token = "0x4006F36")]
	[FieldOffset(Offset = "0x0")]
	private static PartnerNPCWeaponBehaviorDataTableArray _PartnerNPCWeaponBehaviorDataTableArray;
}
