using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200044B RID: 1099
[Token(Token = "0x200034B")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145D30", Offset = "0x145E31")]
[Serializable]
public class EventUnlockFlag : ScriptableObject
{
	// Token: 0x06001AA1 RID: 6817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AB")]
	[Address(RVA = "0x21BD010", Offset = "0x21BD111", VA = "0x21BD010")]
	public EventUnlockFlag()
	{
	}

	// Token: 0x04005D99 RID: 23961
	[Token(Token = "0x40059D3")]
	[FieldOffset(Offset = "0x18")]
	public List<EventUnlockFlagData> datas;
}
