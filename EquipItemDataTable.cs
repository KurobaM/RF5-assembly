using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036C RID: 876
[Token(Token = "0x2000299")]
[Serializable]
public class EquipItemDataTable
{
	// Token: 0x060016B0 RID: 5808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001421")]
	[Address(RVA = "0x22B83F0", Offset = "0x22B84F1", VA = "0x22B83F0")]
	public static EquipItemDataTable GetDataTable(ItemID itemID)
	{
		return null;
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001422")]
	[Address(RVA = "0x22B9000", Offset = "0x22B9101", VA = "0x22B9000")]
	public static SerializeEquipItemDataTable[] GetDataTables()
	{
		return null;
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x0000A0C8 File Offset: 0x000082C8
	[Token(Token = "0x6001423")]
	[Address(RVA = "0x22B9120", Offset = "0x22B9221", VA = "0x22B9120")]
	public static bool HasDataTable(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001424")]
	[Address(RVA = "0x22B8FF0", Offset = "0x22B90F1", VA = "0x22B8FF0")]
	public EquipItemDataTable()
	{
	}

	// Token: 0x04000EE3 RID: 3811
	[Token(Token = "0x4000BB5")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public bool Attribute_Fire;

	// Token: 0x04000EE4 RID: 3812
	[Token(Token = "0x4000BB6")]
	[FieldOffset(Offset = "0x11")]
	[SerializeField]
	public bool Attribute_Water;

	// Token: 0x04000EE5 RID: 3813
	[Token(Token = "0x4000BB7")]
	[FieldOffset(Offset = "0x12")]
	[SerializeField]
	public bool Attribute_Earth;

	// Token: 0x04000EE6 RID: 3814
	[Token(Token = "0x4000BB8")]
	[FieldOffset(Offset = "0x13")]
	[SerializeField]
	public bool Attribute_Wind;

	// Token: 0x04000EE7 RID: 3815
	[Token(Token = "0x4000BB9")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public bool Attribute_Shine;

	// Token: 0x04000EE8 RID: 3816
	[Token(Token = "0x4000BBA")]
	[FieldOffset(Offset = "0x15")]
	[SerializeField]
	public bool Attribute_Dark;

	// Token: 0x04000EE9 RID: 3817
	[Token(Token = "0x4000BBB")]
	[FieldOffset(Offset = "0x16")]
	[SerializeField]
	public bool Attribute_Love;

	// Token: 0x04000EEA RID: 3818
	[Token(Token = "0x4000BBC")]
	[FieldOffset(Offset = "0x18")]
	public Parameter Parameter;

	// Token: 0x04000EEB RID: 3819
	[Token(Token = "0x4000BBD")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	public bool IsVisualEquip;

	// Token: 0x04000EEC RID: 3820
	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public HumanMotionType MotionType;

	// Token: 0x04000EED RID: 3821
	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public EquipAttach[] AttachData;

	// Token: 0x04000EEE RID: 3822
	[Token(Token = "0x4000BC0")]
	[FieldOffset(Offset = "0xE8")]
	public HumanActionID[] AS_ChargeArray;

	// Token: 0x04000EEF RID: 3823
	[Token(Token = "0x4000BC1")]
	[FieldOffset(Offset = "0xF0")]
	public FarmAction ChargeFarmAction;

	// Token: 0x04000EF0 RID: 3824
	[Token(Token = "0x4000BC2")]
	[FieldOffset(Offset = "0xF8")]
	public FarmRange[] FarmRangeArray;

	// Token: 0x04000EF1 RID: 3825
	[Token(Token = "0x4000BC3")]
	[FieldOffset(Offset = "0x100")]
	public HumanActionID[] AS_ItemLevel;

	// Token: 0x04000EF2 RID: 3826
	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0x108")]
	public HumanActionID AS_Avoid;

	// Token: 0x04000EF3 RID: 3827
	[Token(Token = "0x4000BC5")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	public MagicID[] MagicIDs;

	// Token: 0x04000EF4 RID: 3828
	[Token(Token = "0x4000BC6")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	public EquipItemFlag EquipItemFlag;

	// Token: 0x04000EF5 RID: 3829
	[Token(Token = "0x4000BC7")]
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	public HitSoundID HitSoundID;

	// Token: 0x04000EF6 RID: 3830
	[Token(Token = "0x4000BC8")]
	[FieldOffset(Offset = "0x0")]
	private static EquipItemDataTableArray _EquipItemParamDataTableArray;
}
