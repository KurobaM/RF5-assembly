using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000442 RID: 1090
[Token(Token = "0x2000342")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145CB0", Offset = "0x145DB1")]
[Serializable]
public class EventPoint : ScriptableObject
{
	// Token: 0x06001A7E RID: 6782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001788")]
	[Address(RVA = "0x21B5DE0", Offset = "0x21B5EE1", VA = "0x21B5DE0")]
	public EventPoint()
	{
	}

	// Token: 0x04005D5B RID: 23899
	[Token(Token = "0x4005995")]
	[FieldOffset(Offset = "0x18")]
	public List<EventPointData> datas;
}
