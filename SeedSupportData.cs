using System;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x020003BF RID: 959
[Token(Token = "0x20002E2")]
[Serializable]
public class SeedSupportData
{
	// Token: 0x0600176F RID: 5999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D3")]
	[Address(RVA = "0x1E30260", Offset = "0x1E30361", VA = "0x1E30260")]
	public SeedSupportData()
	{
	}

	// Token: 0x04001094 RID: 4244
	[Token(Token = "0x4000D38")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public TimeLine Timline;

	// Token: 0x04001095 RID: 4245
	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public MagicParamID ParamID;
}
