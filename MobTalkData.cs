using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200039E RID: 926
[Token(Token = "0x20002C6")]
[Serializable]
public class MobTalkData
{
	// Token: 0x06001724 RID: 5924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001490")]
	[Address(RVA = "0x1D7B060", Offset = "0x1D7B161", VA = "0x1D7B060")]
	public MobTalkData()
	{
	}

	// Token: 0x04001042 RID: 4162
	[Token(Token = "0x4000CF6")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int NameTextID;

	// Token: 0x04001043 RID: 4163
	[Token(Token = "0x4000CF7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string[] ScriptNames;
}
