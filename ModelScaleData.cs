using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A13 RID: 2579
[Token(Token = "0x20006C2")]
[Serializable]
public class ModelScaleData
{
	// Token: 0x06004392 RID: 17298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003883")]
	[Address(RVA = "0x1D7FED0", Offset = "0x1D7FFD1", VA = "0x1D7FED0")]
	public ModelScaleData()
	{
	}

	// Token: 0x0400A276 RID: 41590
	[Token(Token = "0x4007AB9")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ActorID ActorID;

	// Token: 0x0400A277 RID: 41591
	[Token(Token = "0x4007ABA")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float Scale;
}
