using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000424 RID: 1060
[Token(Token = "0x2000330")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145BC0", Offset = "0x145CC1")]
[Serializable]
public class BirthTalk : ScriptableObject
{
	// Token: 0x060019C7 RID: 6599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016ED")]
	[Address(RVA = "0x2452160", Offset = "0x2452261", VA = "0x2452160")]
	public BirthTalk()
	{
	}

	// Token: 0x04005CC9 RID: 23753
	[Token(Token = "0x4005910")]
	[FieldOffset(Offset = "0x18")]
	public List<BirthTalkData> datas;
}
