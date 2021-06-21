using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x02000400 RID: 1024
[Token(Token = "0x2000321")]
[Serializable]
public struct EffectDataTable
{
	// Token: 0x060017A7 RID: 6055 RVA: 0x0000A4B8 File Offset: 0x000086B8
	[Token(Token = "0x600150A")]
	[Address(RVA = "0x22AC420", Offset = "0x22AC521", VA = "0x22AC420")]
	public static EffectDataTable GetDataTable(EffectID id)
	{
		return default(EffectDataTable);
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600150B")]
	[Address(RVA = "0x22AC5A0", Offset = "0x22AC6A1", VA = "0x22AC5A0")]
	public static SerializeEffectDataTable[] GetDataTables()
	{
		return null;
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x0000A4D0 File Offset: 0x000086D0
	[Token(Token = "0x600150C")]
	[Address(RVA = "0x22AC6C0", Offset = "0x22AC7C1", VA = "0x22AC6C0")]
	public static bool HasDataTable(EffectID id)
	{
		return default(bool);
	}

	// Token: 0x04005BB1 RID: 23473
	[Token(Token = "0x400584C")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public Effect EffectAssetID;

	// Token: 0x04005BB2 RID: 23474
	[Token(Token = "0x400584D")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	public bool Loop;

	// Token: 0x04005BB3 RID: 23475
	[Token(Token = "0x400584E")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public HumanJointIDEnum WorldAttach;

	// Token: 0x04005BB4 RID: 23476
	[Token(Token = "0x400584F")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	public HumanJointIDEnum ChildAttach;

	// Token: 0x04005BB5 RID: 23477
	[Token(Token = "0x4005850")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public SoundID SE;

	// Token: 0x04005BB6 RID: 23478
	[Token(Token = "0x4005851")]
	[FieldOffset(Offset = "0x0")]
	private static EffectDataTableArray _EffectDataTableArray;
}
