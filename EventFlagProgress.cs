using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200043F RID: 1087
[Token(Token = "0x200033F")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145CA0", Offset = "0x145DA1")]
[Serializable]
public class EventFlagProgress : ScriptableObject
{
	// Token: 0x06001A7A RID: 6778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001784")]
	[Address(RVA = "0x21FBA50", Offset = "0x21FBB51", VA = "0x21FBA50")]
	public EventFlagProgress()
	{
	}

	// Token: 0x04005D4E RID: 23886
	[Token(Token = "0x4005988")]
	[FieldOffset(Offset = "0x18")]
	public List<EventFlagProgressData> datas;
}
