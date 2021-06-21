using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000447 RID: 1095
[Token(Token = "0x2000347")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145D00", Offset = "0x145E01")]
[Serializable]
public class EventScheduleDataTable : ScriptableObject
{
	// Token: 0x06001A8C RID: 6796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001796")]
	[Address(RVA = "0x21B7650", Offset = "0x21B7751", VA = "0x21B7650")]
	public EventScheduleDataTable()
	{
	}

	// Token: 0x04005D6E RID: 23918
	[Token(Token = "0x40059A8")]
	[FieldOffset(Offset = "0x18")]
	public List<EventScheduleData> datas;
}
