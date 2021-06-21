using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004EF RID: 1263
[Token(Token = "0x200039A")]
public class BaffamoFestivalDataTable : ScriptableObject
{
	// Token: 0x170004FE RID: 1278
	// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001EFB RID: 7931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700041E")]
	public Dictionary<BaffamoID, BaffamoFestivalData> DataTable
	{
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x22A1190", Offset = "0x22A1291", VA = "0x22A1190")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F950", Offset = "0x19FA51")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x22A11A0", Offset = "0x22A12A1", VA = "0x22A11A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F960", Offset = "0x19FA61")]
		private set
		{
		}
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A84")]
	[Address(RVA = "0x229C730", Offset = "0x229C831", VA = "0x229C730")]
	public void Setup()
	{
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A85")]
	[Address(RVA = "0x229D800", Offset = "0x229D901", VA = "0x229D800")]
	public void Clear()
	{
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A86")]
	[Address(RVA = "0x22A11B0", Offset = "0x22A12B1", VA = "0x22A11B0")]
	public BaffamoFestivalDataTable()
	{
	}

	// Token: 0x040065D9 RID: 26073
	[Token(Token = "0x4006052")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<BaffamoFestivalData> BaffamoFestivalDataList;

	// Token: 0x040065DA RID: 26074
	[Token(Token = "0x4006053")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1655C0", Offset = "0x1656C1")]
	private Dictionary<BaffamoID, BaffamoFestivalData> <DataTable>k__BackingField;
}
