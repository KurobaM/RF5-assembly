using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x02000612 RID: 1554
[Token(Token = "0x200045F")]
public class PadBindDataTable : ScriptableObject
{
	// Token: 0x1700062E RID: 1582
	// (get) Token: 0x0600266D RID: 9837 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600266E RID: 9838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004EC")]
	public Dictionary<string, PadBindData> DataTables
	{
		[Token(Token = "0x600206D")]
		[Address(RVA = "0x2319440", Offset = "0x2319541", VA = "0x2319440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1B00", Offset = "0x1A1C01")]
		get
		{
			return null;
		}
		[Token(Token = "0x600206E")]
		[Address(RVA = "0x2319450", Offset = "0x2319551", VA = "0x2319450")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1B10", Offset = "0x1A1C11")]
		private set
		{
		}
	}

	// Token: 0x0600266F RID: 9839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600206F")]
	[Address(RVA = "0x2319460", Offset = "0x2319561", VA = "0x2319460")]
	public void Setup()
	{
	}

	// Token: 0x06002670 RID: 9840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002070")]
	[Address(RVA = "0x2319640", Offset = "0x2319741", VA = "0x2319640")]
	public void Clear()
	{
	}

	// Token: 0x06002671 RID: 9841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002071")]
	[Address(RVA = "0x23196B0", Offset = "0x23197B1", VA = "0x23196B0")]
	public PadBindDataTable()
	{
	}

	// Token: 0x04006D9B RID: 28059
	[Token(Token = "0x4006698")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<PadBindData> PadBindDatas;

	// Token: 0x04006D9C RID: 28060
	[Token(Token = "0x4006699")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168310", Offset = "0x168411")]
	private Dictionary<string, PadBindData> <DataTables>k__BackingField;
}
