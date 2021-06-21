using System;
using Il2CppDummyDll;

// Token: 0x0200042B RID: 1067
[Token(Token = "0x2000337")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145C20", Offset = "0x145D21")]
public struct EventCheckId
{
	// Token: 0x04005CDB RID: 23771
	[Token(Token = "0x4005922")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162E50", Offset = "0x162F51")]
	public int CheckTriggerType;

	// Token: 0x04005CDC RID: 23772
	[Token(Token = "0x4005923")]
	[FieldOffset(Offset = "0x4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162E90", Offset = "0x162F91")]
	public int CheckTriggerId;

	// Token: 0x04005CDD RID: 23773
	[Token(Token = "0x4005924")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162ED0", Offset = "0x162FD1")]
	public string CheckScriptName;

	// Token: 0x04005CDE RID: 23774
	[Token(Token = "0x4005925")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162F10", Offset = "0x163011")]
	public string CheckEnemyName;
}
