using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
[Serializable]
public class NavMeshAgentControlBehaviour : PlayableBehaviour
{
	// Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1E22B10", Offset = "0x1E22C11", VA = "0x1E22B10", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1E22B20", Offset = "0x1E22C21", VA = "0x1E22B20")]
	public NavMeshAgentControlBehaviour()
	{
	}

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x10")]
	public Transform destination;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x18")]
	public bool destinationSet;
}
