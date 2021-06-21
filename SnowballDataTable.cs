using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000539 RID: 1337
[Token(Token = "0x20003CA")]
public class SnowballDataTable : ScriptableObject
{
	// Token: 0x17000540 RID: 1344
	// (get) Token: 0x06002060 RID: 8288 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002061 RID: 8289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000441")]
	public Dictionary<SnowmanObjectID, SnowballData> SnowBallData
	{
		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x2252C90", Offset = "0x2252D91", VA = "0x2252C90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A03B0", Offset = "0x1A04B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x2252CA0", Offset = "0x2252DA1", VA = "0x2252CA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A03C0", Offset = "0x1A04C1")]
		private set
		{
		}
	}

	// Token: 0x17000541 RID: 1345
	// (get) Token: 0x06002062 RID: 8290 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002063 RID: 8291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000442")]
	public Dictionary<SnowmanObjectID, MocomocoData> MocomocoData
	{
		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x2252CB0", Offset = "0x2252DB1", VA = "0x2252CB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A03D0", Offset = "0x1A04D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x2252CC0", Offset = "0x2252DC1", VA = "0x2252CC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A03E0", Offset = "0x1A04E1")]
		private set
		{
		}
	}

	// Token: 0x06002064 RID: 8292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B85")]
	[Address(RVA = "0x2252CD0", Offset = "0x2252DD1", VA = "0x2252CD0")]
	public void Setup()
	{
	}

	// Token: 0x06002065 RID: 8293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B86")]
	[Address(RVA = "0x2252EC0", Offset = "0x2252FC1", VA = "0x2252EC0")]
	public void Clear()
	{
	}

	// Token: 0x06002066 RID: 8294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B87")]
	[Address(RVA = "0x2252F30", Offset = "0x2253031", VA = "0x2252F30")]
	public SnowballDataTable()
	{
	}

	// Token: 0x0400674A RID: 26442
	[Token(Token = "0x400614F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<SnowballData> SnowballDataList;

	// Token: 0x0400674B RID: 26443
	[Token(Token = "0x4006150")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<MocomocoData> MocomocoDataList;

	// Token: 0x0400674C RID: 26444
	[Token(Token = "0x4006151")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165D60", Offset = "0x165E61")]
	private Dictionary<SnowmanObjectID, SnowballData> <SnowBallData>k__BackingField;

	// Token: 0x0400674D RID: 26445
	[Token(Token = "0x4006152")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165D70", Offset = "0x165E71")]
	private Dictionary<SnowmanObjectID, MocomocoData> <MocomocoData>k__BackingField;
}
