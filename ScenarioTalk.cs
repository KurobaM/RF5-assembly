using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000476 RID: 1142
[Token(Token = "0x200036F")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145E20", Offset = "0x145F21")]
[Serializable]
public class ScenarioTalk : ScriptableObject
{
	// Token: 0x06001BC9 RID: 7113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C8")]
	[Address(RVA = "0x21D4310", Offset = "0x21D4411", VA = "0x21D4310")]
	public ScenarioTalk()
	{
	}

	// Token: 0x04006093 RID: 24723
	[Token(Token = "0x4005C8D")]
	[FieldOffset(Offset = "0x18")]
	public List<ScenarioTalkData> datas;
}
