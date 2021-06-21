using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000334 RID: 820
[Token(Token = "0x2000267")]
public class DLCDataTable : ScriptableObject
{
	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x06001619 RID: 5657 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600161A RID: 5658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000398")]
	public Dictionary<int, DLCPair> DataTables
	{
		[Token(Token = "0x600139B")]
		[Address(RVA = "0x1D9DEC0", Offset = "0x1D9DFC1", VA = "0x1D9DEC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D310", Offset = "0x19D411")]
		get
		{
			return null;
		}
		[Token(Token = "0x600139C")]
		[Address(RVA = "0x1D9DED0", Offset = "0x1D9DFD1", VA = "0x1D9DED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D320", Offset = "0x19D421")]
		private set
		{
		}
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139D")]
	[Address(RVA = "0x1D9D770", Offset = "0x1D9D871", VA = "0x1D9D770")]
	public void Setup()
	{
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139E")]
	[Address(RVA = "0x1D9DEE0", Offset = "0x1D9DFE1", VA = "0x1D9DEE0")]
	public void Clear()
	{
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139F")]
	[Address(RVA = "0x1D9DF50", Offset = "0x1D9E051", VA = "0x1D9DF50")]
	public DLCDataTable()
	{
	}

	// Token: 0x04000CBE RID: 3262
	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<DLCPair> DLCPairs;

	// Token: 0x04000CBF RID: 3263
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F8E0", Offset = "0x15F9E1")]
	private Dictionary<int, DLCPair> <DataTables>k__BackingField;
}
