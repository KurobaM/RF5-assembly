using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003AB RID: 939
[Token(Token = "0x20002D1")]
[Serializable]
public class NPCBehaviorDataTable
{
	// Token: 0x0600173B RID: 5947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014A5")]
	[Address(RVA = "0x1E1FE10", Offset = "0x1E1FF11", VA = "0x1E1FE10")]
	public static NPCBehaviorDataTable GetDataTable(ActorID actorID)
	{
		return null;
	}

	// Token: 0x0600173C RID: 5948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A6")]
	[Address(RVA = "0x1E22210", Offset = "0x1E22311", VA = "0x1E22210")]
	public NPCBehaviorDataTable()
	{
	}

	// Token: 0x04001056 RID: 4182
	[Token(Token = "0x4000D06")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ActorID ActorID;

	// Token: 0x04001057 RID: 4183
	[Token(Token = "0x4000D07")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float BehaviorCoolTime;

	// Token: 0x04001058 RID: 4184
	[Token(Token = "0x4000D08")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<NPCActionData> ActionDataList;

	// Token: 0x04001059 RID: 4185
	[Token(Token = "0x4000D09")]
	[FieldOffset(Offset = "0x0")]
	private static NPCBehaviorDataTableArray _MonsterBehaviorDataTableArray;
}
