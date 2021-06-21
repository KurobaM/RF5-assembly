using System;
using System.Collections.Generic;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003B3 RID: 947
[Token(Token = "0x20002D9")]
[Serializable]
public class PersonalMotionDataTable
{
	// Token: 0x0600174F RID: 5967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B9")]
	[Address(RVA = "0x213D9F0", Offset = "0x213DAF1", VA = "0x213D9F0")]
	public static PersonalMotionDataTable GetDataTable(CharID charID)
	{
		return null;
	}

	// Token: 0x06001750 RID: 5968 RVA: 0x0000A2D8 File Offset: 0x000084D8
	[Token(Token = "0x60014BA")]
	[Address(RVA = "0x213DB70", Offset = "0x213DC71", VA = "0x213DB70")]
	public static bool HasDataTable(CharID charID)
	{
		return default(bool);
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014BB")]
	[Address(RVA = "0x213DCB0", Offset = "0x213DDB1", VA = "0x213DCB0")]
	public PersonalMotionDataTable()
	{
	}

	// Token: 0x0400106F RID: 4207
	[Token(Token = "0x4000D1F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float StartTime;

	// Token: 0x04001070 RID: 4208
	[Token(Token = "0x4000D20")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int VoiceFrequency;

	// Token: 0x04001071 RID: 4209
	[Token(Token = "0x4000D21")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float EndTransition;

	// Token: 0x04001072 RID: 4210
	[Token(Token = "0x4000D22")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<PesronalMotionPlayData> PlayDatas;

	// Token: 0x04001073 RID: 4211
	[Token(Token = "0x4000D23")]
	[FieldOffset(Offset = "0x0")]
	private static PersonalMotionDataTableArray _PersonalMotionDataTableArray;
}
