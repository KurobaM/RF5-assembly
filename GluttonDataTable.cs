using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000514 RID: 1300
[Token(Token = "0x20003B4")]
public class GluttonDataTable : ScriptableObject
{
	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001F9B RID: 8091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700042C")]
	public List<GluttonFoodData> DataTable
	{
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x1FEEFB0", Offset = "0x1FEF0B1", VA = "0x1FEEFB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FDF0", Offset = "0x19FEF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x1FEEFC0", Offset = "0x1FEF0C1", VA = "0x1FEEFC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FE00", Offset = "0x19FF01")]
		private set
		{
		}
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF4")]
	[Address(RVA = "0x1FEEFD0", Offset = "0x1FEF0D1", VA = "0x1FEEFD0")]
	public void Setup()
	{
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF5")]
	[Address(RVA = "0x1FEF050", Offset = "0x1FEF151", VA = "0x1FEF050")]
	public void Clear()
	{
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0x1FEF0C0", Offset = "0x1FEF1C1", VA = "0x1FEF0C0")]
	public GluttonDataTable()
	{
	}

	// Token: 0x04006683 RID: 26243
	[Token(Token = "0x40060CA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<GluttonFoodData> GluttonDataList;

	// Token: 0x04006684 RID: 26244
	[Token(Token = "0x40060CB")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165990", Offset = "0x165A91")]
	private List<GluttonFoodData> <DataTable>k__BackingField;
}
