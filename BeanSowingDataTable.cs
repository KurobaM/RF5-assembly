using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004F7 RID: 1271
[Token(Token = "0x20003A2")]
public class BeanSowingDataTable : ScriptableObject
{
	// Token: 0x17000500 RID: 1280
	// (get) Token: 0x06001F16 RID: 7958 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001F17 RID: 7959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000420")]
	public Dictionary<BeanID, BeanData> DataTable
	{
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x2208EA0", Offset = "0x2208FA1", VA = "0x2208EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F990", Offset = "0x19FA91")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x2208EB0", Offset = "0x2208FB1", VA = "0x2208EB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F9A0", Offset = "0x19FAA1")]
		private set
		{
		}
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x2208EC0", Offset = "0x2208FC1", VA = "0x2208EC0")]
	public void Setup()
	{
	}

	// Token: 0x06001F19 RID: 7961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x2208FE0", Offset = "0x22090E1", VA = "0x2208FE0")]
	public void Clear()
	{
	}

	// Token: 0x06001F1A RID: 7962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0x2209050", Offset = "0x2209151", VA = "0x2209050")]
	public BeanSowingDataTable()
	{
	}

	// Token: 0x040065F7 RID: 26103
	[Token(Token = "0x4006070")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<BeanData> BeanDataList;

	// Token: 0x040065F8 RID: 26104
	[Token(Token = "0x4006071")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1656B0", Offset = "0x1657B1")]
	private Dictionary<BeanID, BeanData> <DataTable>k__BackingField;
}
