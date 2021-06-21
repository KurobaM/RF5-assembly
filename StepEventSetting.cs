using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000106 RID: 262
[Token(Token = "0x20000CD")]
[Serializable]
public class StepEventSetting
{
	// Token: 0x060005A0 RID: 1440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x238B530", Offset = "0x238B631", VA = "0x238B530")]
	public StepEventSetting(float normalizedTime, int param)
	{
	}

	// Token: 0x040002FB RID: 763
	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15BCB0", Offset = "0x15BDB1")]
	public float m_NormalizedTime;

	// Token: 0x040002FC RID: 764
	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int m_Param;
}
