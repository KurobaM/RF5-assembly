using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000458 RID: 1112
[Token(Token = "0x2000355")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145D70", Offset = "0x145E71")]
[Serializable]
public class MainEventFlagProgress : ScriptableObject
{
	// Token: 0x06001AE8 RID: 6888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F2")]
	[Address(RVA = "0x1F16840", Offset = "0x1F16941", VA = "0x1F16840")]
	public MainEventFlagProgress()
	{
	}

	// Token: 0x04005DE7 RID: 24039
	[Token(Token = "0x40059F6")]
	[FieldOffset(Offset = "0x18")]
	public List<MainEventFlagProgressData> datas;
}
