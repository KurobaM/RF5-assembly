using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200042D RID: 1069
[Token(Token = "0x2000339")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145C60", Offset = "0x145D61")]
[Serializable]
public class SubEventStep
{
	// Token: 0x060019E0 RID: 6624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001706")]
	[Address(RVA = "0x1FAB480", Offset = "0x1FAB581", VA = "0x1FAB480")]
	public SubEventStep()
	{
	}

	// Token: 0x04005CFC RID: 23804
	[Token(Token = "0x4005943")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163690", Offset = "0x163791")]
	[SerializeField]
	public int TargetEventStep;

	// Token: 0x04005CFD RID: 23805
	[Token(Token = "0x4005944")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1636E0", Offset = "0x1637E1")]
	[SerializeField]
	public int KeepEventStep;

	// Token: 0x04005CFE RID: 23806
	[Token(Token = "0x4005945")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163730", Offset = "0x163831")]
	[SerializeField]
	public List<int> MainEventSteps;
}
