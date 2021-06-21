using System;
using Common;
using Define;
using Il2CppDummyDll;

// Token: 0x020003AD RID: 941
[Token(Token = "0x20002D3")]
[Serializable]
public class NPCFindTargetDataTable
{
	// Token: 0x06001740 RID: 5952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014AA")]
	[Address(RVA = "0x1E1F4B0", Offset = "0x1E1F5B1", VA = "0x1E1F4B0")]
	public static NPCFindTargetDataTable GetDataTable(NPCFindTargetDataID dataID)
	{
		return null;
	}

	// Token: 0x06001741 RID: 5953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AB")]
	[Address(RVA = "0x1E22350", Offset = "0x1E22451", VA = "0x1E22350")]
	public NPCFindTargetDataTable()
	{
	}

	// Token: 0x0400105C RID: 4188
	[Token(Token = "0x4000D0C")]
	[FieldOffset(Offset = "0x10")]
	public NPCFindTargetDataID DataID;

	// Token: 0x0400105D RID: 4189
	[Token(Token = "0x4000D0D")]
	[FieldOffset(Offset = "0x14")]
	public NPCActionTargetType ActionTargetType;

	// Token: 0x0400105E RID: 4190
	[Token(Token = "0x4000D0E")]
	[FieldOffset(Offset = "0x18")]
	public ActorID ActorID;

	// Token: 0x0400105F RID: 4191
	[Token(Token = "0x4000D0F")]
	[FieldOffset(Offset = "0x1C")]
	public NPCTargetParameter TargetParameter;

	// Token: 0x04001060 RID: 4192
	[Token(Token = "0x4000D10")]
	[FieldOffset(Offset = "0x20")]
	public ComparisonOperatorsType ComparisonOperatorsType;

	// Token: 0x04001061 RID: 4193
	[Token(Token = "0x4000D11")]
	[FieldOffset(Offset = "0x24")]
	public float ComparisonValue;

	// Token: 0x04001062 RID: 4194
	[Token(Token = "0x4000D12")]
	[FieldOffset(Offset = "0x0")]
	private static NPCFindTargetDataTableArray _MonsterBehaviorDataTableArray;
}
