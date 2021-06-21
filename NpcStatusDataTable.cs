using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003B0 RID: 944
[Token(Token = "0x20002D6")]
public class NpcStatusDataTable : ScriptableObject
{
	// Token: 0x1700041A RID: 1050
	// (get) Token: 0x06001747 RID: 5959 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001748 RID: 5960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003B0")]
	public Dictionary<ActorID, NpcStatusData> DataTables
	{
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x1F55510", Offset = "0x1F55611", VA = "0x1F55510")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D4D0", Offset = "0x19D5D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x1F55520", Offset = "0x1F55621", VA = "0x1F55520")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D4E0", Offset = "0x19D5E1")]
		private set
		{
		}
	}

	// Token: 0x06001749 RID: 5961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x1F55530", Offset = "0x1F55631", VA = "0x1F55530")]
	public NpcStatusData Get(ActorID actorID)
	{
		return null;
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x1F555D0", Offset = "0x1F556D1", VA = "0x1F555D0")]
	public void Setup()
	{
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B5")]
	[Address(RVA = "0x1F557C0", Offset = "0x1F558C1", VA = "0x1F557C0")]
	public void Clear()
	{
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B6")]
	[Address(RVA = "0x1F55830", Offset = "0x1F55931", VA = "0x1F55830")]
	public NpcStatusDataTable()
	{
	}

	// Token: 0x04001067 RID: 4199
	[Token(Token = "0x4000D17")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<NpcStatusData> NpcStatusDatas;

	// Token: 0x04001068 RID: 4200
	[Token(Token = "0x4000D18")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162120", Offset = "0x162221")]
	private Dictionary<ActorID, NpcStatusData> <DataTables>k__BackingField;
}
