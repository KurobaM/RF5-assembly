using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000041 RID: 65
[Token(Token = "0x200003F")]
public class ActionBehaviorDataTable : ScriptableObject, ISerializationCallbackReceiver
{
	// Token: 0x060000B6 RID: 182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1FD5080", Offset = "0x1FD5181", VA = "0x1FD5080", Slot = "6")]
	public virtual void OnAfterDeserialize()
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1FD5150", Offset = "0x1FD5251", VA = "0x1FD5150", Slot = "7")]
	public virtual void OnBeforeSerialize()
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1FD5160", Offset = "0x1FD5261", VA = "0x1FD5160")]
	public List<ActionBehaviorCommandInformation> CreateActionBehaviorCommandInformation(List<ActionBehaviorCommandData> commandDataList)
	{
		return null;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B8")]
	private static void ListToDictionary<T>(List<T> originalList, out Dictionary<int, T> createDic)
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1FD5310", Offset = "0x1FD5411", VA = "0x1FD5310")]
	public ActionBehaviorDataTable()
	{
	}

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<bool> CommandParameterList_Bool;

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<int, bool> CommandParameterDic_Bool;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public List<int> CommandParameterList_Int;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<int, int> CommandParameterDic_Int;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public List<float> CommandParameterList_Float;

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x40")]
	public Dictionary<int, float> CommandParameterDic_Float;

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public List<string> CommandParameterList_String;

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x50")]
	public Dictionary<int, string> CommandParameterDic_String;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public List<Vector2> CommandParameterList_Vector2;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x60")]
	public Dictionary<int, Vector2> CommandParameterDic_Vector2;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public List<Vector3> CommandParameterList_Vector3;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x70")]
	public Dictionary<int, Vector3> CommandParameterDic_Vector3;
}
