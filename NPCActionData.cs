using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000042 RID: 66
[Token(Token = "0x2000040")]
[Serializable]
public struct NPCActionData
{
	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x0")]
	public ActorID ParentActorID;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x4")]
	public bool InequalityEquipWeaponOrWand;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x8")]
	public ItemCategory CanActionEquipWeapon;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0xC")]
	public NPCRelationshipWithPlayerType CanActionNPCRelationshipType;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x10")]
	public int CanActionLevel;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x14")]
	public bool CanNotActionSeal;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x18")]
	public NPCFindTargetDataID CanActionFindTargetDataID;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x1C")]
	public NPCActionBehaviorDataID ComboBehaviorDataID;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x20")]
	public int Order;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x24")]
	public int CoolCount;

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x28")]
	public int Rate;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x2C")]
	public float WaitTime;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x30")]
	public NPCFindTargetDataID FindTargetDataID;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x34")]
	public NPCActionBehaviorDataID ActionBehaviorDataID;
}
