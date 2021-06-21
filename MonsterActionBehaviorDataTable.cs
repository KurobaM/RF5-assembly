using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003A4 RID: 932
[Token(Token = "0x20002CC")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145B50", Offset = "0x145C51")]
public class MonsterActionBehaviorDataTable : ActionBehaviorDataTable
{
	// Token: 0x0600172C RID: 5932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001498")]
	[Address(RVA = "0x1D830B0", Offset = "0x1D831B1", VA = "0x1D830B0", Slot = "6")]
	public override void OnAfterDeserialize()
	{
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001499")]
	[Address(RVA = "0x1D83270", Offset = "0x1D83371", VA = "0x1D83270", Slot = "7")]
	public override void OnBeforeSerialize()
	{
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600149A")]
	[Address(RVA = "0x1D81650", Offset = "0x1D81751", VA = "0x1D81650")]
	public List<ActionBehaviorCommandInformation> CreateActionBehaviorCommandInformationList(MonsterActionBehaviorDataID monsterActionBehaviorDataID)
	{
		return null;
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149B")]
	private static void ListToDictionary<T>(List<T> originalList, out Dictionary<int, T> createDic)
	{
	}

	// Token: 0x06001730 RID: 5936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149C")]
	[Address(RVA = "0x1D83280", Offset = "0x1D83381", VA = "0x1D83280")]
	public MonsterActionBehaviorDataTable()
	{
	}

	// Token: 0x04001046 RID: 4166
	[Token(Token = "0x4000CFA")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public List<MonsterActionBehaviorDataTable.MonsterActionBehaviorCodeData> DataList;

	// Token: 0x04001047 RID: 4167
	[Token(Token = "0x4000CFB")]
	[FieldOffset(Offset = "0x80")]
	public Dictionary<int, MonsterActionBehaviorDataTable.MonsterActionBehaviorCodeData> DataDic;

	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x2001061")]
	[Serializable]
	public class MonsterActionBehaviorCodeData
	{
		// Token: 0x06001731 RID: 5937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7F")]
		[Address(RVA = "0x1D83290", Offset = "0x1D83391", VA = "0x1D83290")]
		public MonsterActionBehaviorCodeData()
		{
		}

		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4018FBF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public MonsterActionBehaviorDataID DataID;

		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4018FC0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<ActionBehaviorCommandData> CommandDataList;
	}
}
