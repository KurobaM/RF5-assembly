using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000695 RID: 1685
[Token(Token = "0x20004B7")]
[Serializable]
public struct MonsterBehaviorDataTable
{
	// Token: 0x0600292F RID: 10543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022CF")]
	[Address(RVA = "0x2DD910", Offset = "0x2DDA11", VA = "0x2DD910")]
	public void OnAfterDeserialize()
	{
	}

	// Token: 0x06002930 RID: 10544 RVA: 0x00010248 File Offset: 0x0000E448
	[Token(Token = "0x60022D0")]
	[Address(RVA = "0x1D88350", Offset = "0x1D88451", VA = "0x1D88350")]
	public static MonsterBehaviorDataTable GetDataTable(MonsterBehaviorDataID monsterBehaviorDataID)
	{
		return default(MonsterBehaviorDataTable);
	}

	// Token: 0x06002931 RID: 10545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022D1")]
	[Address(RVA = "0x1D88520", Offset = "0x1D88621", VA = "0x1D88520")]
	public static void LoadData()
	{
	}

	// Token: 0x04007117 RID: 28951
	[Token(Token = "0x4006913")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public MonsterSearchRangeData SearchRangeData;

	// Token: 0x04007118 RID: 28952
	[Token(Token = "0x4006914")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public MonsterDamageInfoIdPairsData DamageInfoIdPairs;

	// Token: 0x04007119 RID: 28953
	[Token(Token = "0x4006915")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public MonsterActionData ActionData;

	// Token: 0x0400711A RID: 28954
	[Token(Token = "0x4006916")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x0400711B RID: 28955
	[Token(Token = "0x4006917")]
	[FieldOffset(Offset = "0x8")]
	private static MonsterBehaviorDataTableArray _MonsterBehaviorDataTableArray;
}
