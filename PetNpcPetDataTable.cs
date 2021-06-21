using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000531 RID: 1329
[Token(Token = "0x20003C4")]
public class PetNpcPetDataTable : ScriptableObject
{
	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x06002032 RID: 8242 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002033 RID: 8243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700043B")]
	public Dictionary<ActorID, List<MonsterDataID>> DataTable
	{
		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x2141FB0", Offset = "0x21420B1", VA = "0x2141FB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0210", Offset = "0x1A0311")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x2141FC0", Offset = "0x21420C1", VA = "0x2141FC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0220", Offset = "0x1A0321")]
		private set
		{
		}
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B61")]
	[Address(RVA = "0x213EBB0", Offset = "0x213ECB1", VA = "0x213EBB0")]
	public void Setup(Gender _baby_gender)
	{
	}

	// Token: 0x06002035 RID: 8245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B62")]
	[Address(RVA = "0x2141FD0", Offset = "0x21420D1", VA = "0x2141FD0")]
	public void Clear()
	{
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B63")]
	[Address(RVA = "0x2142040", Offset = "0x2142141", VA = "0x2142040")]
	public void RemoveKey(ActorID _actor)
	{
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B64")]
	[Address(RVA = "0x21420E0", Offset = "0x21421E1", VA = "0x21420E0")]
	public PetNpcPetDataTable()
	{
	}

	// Token: 0x0400671D RID: 26397
	[Token(Token = "0x400612A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<PetNpcPetData> DataList;

	// Token: 0x0400671E RID: 26398
	[Token(Token = "0x400612B")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165BE0", Offset = "0x165CE1")]
	private Dictionary<ActorID, List<MonsterDataID>> <DataTable>k__BackingField;
}
