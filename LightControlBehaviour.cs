using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
[Serializable]
public class LightControlBehaviour : PlayableBehaviour
{
	// Token: 0x06000007 RID: 7 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x230FE20", Offset = "0x230FF21", VA = "0x230FE20")]
	public LightControlBehaviour()
	{
	}

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x10")]
	public Color color;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x20")]
	public float intensity;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x24")]
	public float bounceIntensity;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x28")]
	public float range;
}
