using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003F RID: 63
[Token(Token = "0x200003E")]
[Serializable]
public class ActionBehaviorCommandData
{
	// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1FD49A0", Offset = "0x1FD4AA1", VA = "0x1FD49A0")]
	public ActionBehaviorCommandInformation CreateActionBehaviorCommandInformation(ActionBehaviorDataTable dataTable)
	{
		return null;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1FD4D30", Offset = "0x1FD4E31", VA = "0x1FD4D30")]
	public ActionBehaviorCommandData()
	{
	}

	// Token: 0x04000099 RID: 153
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ActionBehaviorCommandType CommandType;

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<ActionBehaviorCommandData.Argument> ArgumentList;

	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000F8B")]
	[Serializable]
	public class Argument
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AEB")]
		[Address(RVA = "0x1FD4D40", Offset = "0x1FD4E41", VA = "0x1FD4D40")]
		public Argument()
		{
		}

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x4018C7D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public VariableType Type;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x4018C7E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public int Index;
	}
}
