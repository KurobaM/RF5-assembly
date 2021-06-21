using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024B RID: 587
[Token(Token = "0x20001D7")]
[Serializable]
public class EraseObject
{
	// Token: 0x06000E53 RID: 3667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0x22BC480", Offset = "0x22BC581", VA = "0x22BC480")]
	public EraseObject()
	{
	}

	// Token: 0x0400083B RID: 2107
	[Token(Token = "0x40006A2")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public bool IsErased;

	// Token: 0x0400083C RID: 2108
	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public HumanJointIDEnum JointID;
}
