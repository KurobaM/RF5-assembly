using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003A9 RID: 937
[Token(Token = "0x20002D0")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145B60", Offset = "0x145C61")]
public class NPCActionBehaviorDataTable : ActionBehaviorDataTable
{
	// Token: 0x06001736 RID: 5942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A1")]
	[Address(RVA = "0x1E22020", Offset = "0x1E22121", VA = "0x1E22020", Slot = "6")]
	public override void OnAfterDeserialize()
	{
	}

	// Token: 0x06001737 RID: 5943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A2")]
	[Address(RVA = "0x1E221E0", Offset = "0x1E222E1", VA = "0x1E221E0", Slot = "7")]
	public override void OnBeforeSerialize()
	{
	}

	// Token: 0x06001738 RID: 5944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014A3")]
	[Address(RVA = "0x1E1EC30", Offset = "0x1E1ED31", VA = "0x1E1EC30")]
	public List<ActionBehaviorCommandInformation> CreateActionBehaviorCommandInformationList(NPCActionBehaviorDataID npcActionBehaviorDataID)
	{
		return null;
	}

	// Token: 0x06001739 RID: 5945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A4")]
	[Address(RVA = "0x1E221F0", Offset = "0x1E222F1", VA = "0x1E221F0")]
	public NPCActionBehaviorDataTable()
	{
	}

	// Token: 0x04001052 RID: 4178
	[Token(Token = "0x4000D04")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public List<NPCActionBehaviorDataTable.NPCActionBehaviorCodeData> DataList;

	// Token: 0x04001053 RID: 4179
	[Token(Token = "0x4000D05")]
	[FieldOffset(Offset = "0x80")]
	public Dictionary<int, NPCActionBehaviorDataTable.NPCActionBehaviorCodeData> DataDic;

	// Token: 0x020003AA RID: 938
	[Token(Token = "0x2001062")]
	[Serializable]
	public class NPCActionBehaviorCodeData
	{
		// Token: 0x0600173A RID: 5946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D80")]
		[Address(RVA = "0x1E22200", Offset = "0x1E22301", VA = "0x1E22200")]
		public NPCActionBehaviorCodeData()
		{
		}

		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4018FC1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public NPCActionBehaviorDataID DataID;

		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4018FC2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<ActionBehaviorCommandData> CommandDataList;
	}
}
