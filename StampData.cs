using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200088A RID: 2186
[Token(Token = "0x20005A5")]
[Serializable]
public class StampData
{
	// Token: 0x060039AC RID: 14764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600301F")]
	[Address(RVA = "0x23885C0", Offset = "0x23886C1", VA = "0x23885C0")]
	public StampData()
	{
	}

	// Token: 0x04007CE8 RID: 31976
	[Token(Token = "0x40070E6")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public StampEnum StampEnum;

	// Token: 0x04007CE9 RID: 31977
	[Token(Token = "0x40070E7")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public StampType StampType;

	// Token: 0x04007CEA RID: 31978
	[Token(Token = "0x40070E8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<string> SpriteName;
}
