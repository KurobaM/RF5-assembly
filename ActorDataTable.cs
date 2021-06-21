using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200033A RID: 826
[Token(Token = "0x200026B")]
public class ActorDataTable : ScriptableObject
{
	// Token: 0x17000403 RID: 1027
	// (get) Token: 0x06001630 RID: 5680 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001631 RID: 5681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000399")]
	public Dictionary<ActorID, ActorData> DataTables
	{
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x1D4AB50", Offset = "0x1D4AC51", VA = "0x1D4AB50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D410", Offset = "0x19D511")]
		get
		{
			return null;
		}
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x1D4AB60", Offset = "0x1D4AC61", VA = "0x1D4AB60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D420", Offset = "0x19D521")]
		private set
		{
		}
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A8")]
	[Address(RVA = "0x1D4AB70", Offset = "0x1D4AC71", VA = "0x1D4AB70")]
	public void Setup()
	{
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A9")]
	[Address(RVA = "0x1D4AD30", Offset = "0x1D4AE31", VA = "0x1D4AD30")]
	public void Clear()
	{
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AA")]
	[Address(RVA = "0x1D4ADA0", Offset = "0x1D4AEA1", VA = "0x1D4ADA0")]
	public ActorDataTable()
	{
	}

	// Token: 0x04000CC9 RID: 3273
	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<ActorData> ActorDatas;

	// Token: 0x04000CCA RID: 3274
	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F930", Offset = "0x15FA31")]
	private Dictionary<ActorID, ActorData> <DataTables>k__BackingField;
}
