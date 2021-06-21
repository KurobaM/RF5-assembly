using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000873 RID: 2163
[Token(Token = "0x2000597")]
[Serializable]
public struct NpcPlaceSchedule
{
	// Token: 0x04007C86 RID: 31878
	[Token(Token = "0x4007099")]
	[FieldOffset(Offset = "0x0")]
	public List<Schedule> Schedules;

	// Token: 0x04007C87 RID: 31879
	[Token(Token = "0x400709A")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	// Token: 0x04007C88 RID: 31880
	[Token(Token = "0x400709B")]
	[FieldOffset(Offset = "0x10")]
	public int NpcId;
}
