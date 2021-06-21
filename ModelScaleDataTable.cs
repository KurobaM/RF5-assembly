using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A14 RID: 2580
[Token(Token = "0x20006C3")]
public class ModelScaleDataTable : ScriptableObject
{
	// Token: 0x17000933 RID: 2355
	// (get) Token: 0x06004393 RID: 17299 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004394 RID: 17300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700075F")]
	public Dictionary<ActorID, float> DataTable
	{
		[Token(Token = "0x6003884")]
		[Address(RVA = "0x1D7FEE0", Offset = "0x1D7FFE1", VA = "0x1D7FEE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7740", Offset = "0x1A7841")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003885")]
		[Address(RVA = "0x1D7FEF0", Offset = "0x1D7FFF1", VA = "0x1D7FEF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7750", Offset = "0x1A7851")]
		private set
		{
		}
	}

	// Token: 0x06004395 RID: 17301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003886")]
	[Address(RVA = "0x1D7FF00", Offset = "0x1D80001", VA = "0x1D7FF00")]
	public void Setup()
	{
	}

	// Token: 0x06004396 RID: 17302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003887")]
	[Address(RVA = "0x1D80030", Offset = "0x1D80131", VA = "0x1D80030")]
	public void Clear()
	{
	}

	// Token: 0x06004397 RID: 17303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003888")]
	[Address(RVA = "0x1D800A0", Offset = "0x1D801A1", VA = "0x1D800A0")]
	public ModelScaleDataTable()
	{
	}

	// Token: 0x0400A278 RID: 41592
	[Token(Token = "0x4007ABB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<ModelScaleData> ModelScaleDataList;

	// Token: 0x0400A279 RID: 41593
	[Token(Token = "0x4007ABC")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x171860", Offset = "0x171961")]
	private Dictionary<ActorID, float> <DataTable>k__BackingField;
}
