using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200069F RID: 1695
[Token(Token = "0x20004C1")]
[Serializable]
public struct MonsterFootStepEventDataTable
{
	// Token: 0x06002943 RID: 10563 RVA: 0x000102A8 File Offset: 0x0000E4A8
	[Token(Token = "0x60022E3")]
	[Address(RVA = "0x1E60CB0", Offset = "0x1E60DB1", VA = "0x1E60CB0")]
	public static MonsterFootStepEventDataTable GetDataTable(MonsterFootStepEventDataID monsterDataID)
	{
		return default(MonsterFootStepEventDataTable);
	}

	// Token: 0x04007178 RID: 29048
	[Token(Token = "0x4006974")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public MonsterFootStepEventDataID MonsterFootStepEventDataID;

	// Token: 0x04007179 RID: 29049
	[Token(Token = "0x4006975")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public string[] LegTransformNames;

	// Token: 0x0400717A RID: 29050
	[Token(Token = "0x4006976")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public StepEventSetting[] WalkStepEvents;

	// Token: 0x0400717B RID: 29051
	[Token(Token = "0x4006977")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public StepEventSetting[] DashStepEvents;

	// Token: 0x0400717C RID: 29052
	[Token(Token = "0x4006978")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float CollapseNormalizeTime;

	// Token: 0x0400717D RID: 29053
	[Token(Token = "0x4006979")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float FootEffectScale;

	// Token: 0x0400717E RID: 29054
	[Token(Token = "0x400697A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float LandingEffectScale;

	// Token: 0x0400717F RID: 29055
	[Token(Token = "0x400697B")]
	[FieldOffset(Offset = "0x0")]
	private static MonsterFootStepEventDataTableArray _MonsterFootStepEventDataTableArray;
}
