using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003AF RID: 943
[Token(Token = "0x20002D5")]
[Serializable]
public class NPCSkillLevelDataTable
{
	// Token: 0x06001745 RID: 5957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014AF")]
	[Address(RVA = "0x1E22810", Offset = "0x1E22911", VA = "0x1E22810")]
	public static NPCSkillLevelDataTable GetDataTable(ActorID id)
	{
		return null;
	}

	// Token: 0x06001746 RID: 5958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B0")]
	[Address(RVA = "0x1E22950", Offset = "0x1E22A51", VA = "0x1E22950")]
	public NPCSkillLevelDataTable()
	{
	}

	// Token: 0x04001065 RID: 4197
	[Token(Token = "0x4000D15")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int[] SkillLevels;

	// Token: 0x04001066 RID: 4198
	[Token(Token = "0x4000D16")]
	[FieldOffset(Offset = "0x0")]
	private static NPCSkillLevelDataTableArray _NPCSkillLevelDataTableArray;
}
