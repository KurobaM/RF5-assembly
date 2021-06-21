using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
[Serializable]
public class TextSwitcherBehaviour : PlayableBehaviour
{
	// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x205B950", Offset = "0x205BA51", VA = "0x205B950")]
	public TextSwitcherBehaviour()
	{
	}

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x10")]
	public Color color;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x20")]
	public int fontSize;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x28")]
	public string text;
}
