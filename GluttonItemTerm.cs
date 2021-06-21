using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000518 RID: 1304
[Token(Token = "0x20003B7")]
[Serializable]
public class GluttonItemTerm
{
	// Token: 0x06001FAB RID: 8107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AFD")]
	[Address(RVA = "0x1FEF680", Offset = "0x1FEF781", VA = "0x1FEF680")]
	public GluttonItemTerm()
	{
	}

	// Token: 0x0400668C RID: 26252
	[Token(Token = "0x40060CF")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float SpawnTime;

	// Token: 0x0400668D RID: 26253
	[Token(Token = "0x40060D0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<GluttonItem> GluttonItemList;
}
