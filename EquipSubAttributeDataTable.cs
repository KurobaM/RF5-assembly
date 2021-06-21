using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036D RID: 877
[Token(Token = "0x200029A")]
[Serializable]
public class EquipSubAttributeDataTable
{
	// Token: 0x060016B4 RID: 5812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001425")]
	[Address(RVA = "0x22B8580", Offset = "0x22B8681", VA = "0x22B8580")]
	public static EquipSubAttributeDataTable GetDataTable(EquipSubAttribute id)
	{
		return null;
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001426")]
	[Address(RVA = "0x22BC470", Offset = "0x22BC571", VA = "0x22BC470")]
	public EquipSubAttributeDataTable()
	{
	}

	// Token: 0x04000EF7 RID: 3831
	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public bool IsEquipOn;

	// Token: 0x04000EF8 RID: 3832
	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0x11")]
	[SerializeField]
	public bool IsArrangeOn;

	// Token: 0x04000EF9 RID: 3833
	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0x12")]
	[SerializeField]
	public bool IsStrengtheningOn;

	// Token: 0x04000EFA RID: 3834
	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public EquipSubAttributeDataTable.AttributeGenre Genre;

	// Token: 0x04000EFB RID: 3835
	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x0")]
	private static EquipSubAttributeDataTableArray _EquipSubAttributeDataTableArray;

	// Token: 0x0200036E RID: 878
	[Token(Token = "0x200105C")]
	public enum AttributeGenre
	{
		// Token: 0x04000EFD RID: 3837
		[Token(Token = "0x4018FA2")]
		Weapon,
		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4018FA3")]
		Shield,
		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4018FA4")]
		Accessory,
		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4018FA5")]
		Hat,
		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4018FA6")]
		Shose,
		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4018FA7")]
		BodyArmor,
		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4018FA8")]
		Armor,
		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4018FA9")]
		Strenghening,
		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4018FAA")]
		ALL
	}
}
