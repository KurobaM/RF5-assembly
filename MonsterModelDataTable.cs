using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006A1 RID: 1697
[Token(Token = "0x20004C3")]
public class MonsterModelDataTable : ScriptableObject
{
	// Token: 0x1700068B RID: 1675
	// (get) Token: 0x06002949 RID: 10569 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600294A RID: 10570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000539")]
	public Dictionary<MonsterModelDataID, MonsterModelData> DataTables
	{
		[Token(Token = "0x60022E9")]
		[Address(RVA = "0x1E6E050", Offset = "0x1E6E151", VA = "0x1E6E050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A22C0", Offset = "0x1A23C1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022EA")]
		[Address(RVA = "0x1E6E060", Offset = "0x1E6E161", VA = "0x1E6E060")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A22D0", Offset = "0x1A23D1")]
		private set
		{
		}
	}

	// Token: 0x0600294B RID: 10571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022EB")]
	[Address(RVA = "0x1E69A80", Offset = "0x1E69B81", VA = "0x1E69A80")]
	public void Setup()
	{
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022EC")]
	[Address(RVA = "0x1E6E070", Offset = "0x1E6E171", VA = "0x1E6E070")]
	public void Clear()
	{
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022ED")]
	[Address(RVA = "0x1E6B6A0", Offset = "0x1E6B7A1", VA = "0x1E6B6A0")]
	public MonsterModelData GetModelData(MonsterModelDataID id)
	{
		return null;
	}

	// Token: 0x0600294E RID: 10574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022EE")]
	[Address(RVA = "0x1E6E0D0", Offset = "0x1E6E1D1", VA = "0x1E6E0D0")]
	public MonsterModelDataTable()
	{
	}

	// Token: 0x0400718B RID: 29067
	[Token(Token = "0x4006987")]
	[FieldOffset(Offset = "0x18")]
	public List<MonsterModelData> MonsterModelDatas;

	// Token: 0x0400718C RID: 29068
	[Token(Token = "0x4006988")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1693C0", Offset = "0x1694C1")]
	private Dictionary<MonsterModelDataID, MonsterModelData> <DataTables>k__BackingField;
}
