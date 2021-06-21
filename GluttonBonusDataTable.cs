using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000512 RID: 1298
[Token(Token = "0x20003B2")]
public class GluttonBonusDataTable : ScriptableObject
{
	// Token: 0x17000519 RID: 1305
	// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001F95 RID: 8085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700042B")]
	public List<float> DataTable
	{
		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0x1FEEE90", Offset = "0x1FEEF91", VA = "0x1FEEE90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FDD0", Offset = "0x19FED1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x1FEEEA0", Offset = "0x1FEEFA1", VA = "0x1FEEEA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FDE0", Offset = "0x19FEE1")]
		private set
		{
		}
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AEE")]
	[Address(RVA = "0x1FEEEB0", Offset = "0x1FEEFB1", VA = "0x1FEEEB0")]
	public void Setup()
	{
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AEF")]
	[Address(RVA = "0x1FEEF30", Offset = "0x1FEF031", VA = "0x1FEEF30")]
	public void Clear()
	{
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x1FEEFA0", Offset = "0x1FEF0A1", VA = "0x1FEEFA0")]
	public GluttonBonusDataTable()
	{
	}

	// Token: 0x0400667C RID: 26236
	[Token(Token = "0x40060C3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<float> GluttonBonusList;

	// Token: 0x0400667D RID: 26237
	[Token(Token = "0x40060C4")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165920", Offset = "0x165A21")]
	private List<float> <DataTable>k__BackingField;
}
