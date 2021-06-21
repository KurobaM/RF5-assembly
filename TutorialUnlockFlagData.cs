using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020004BE RID: 1214
[Token(Token = "0x2000383")]
[Serializable]
public struct TutorialUnlockFlagData
{
	// Token: 0x0400641A RID: 25626
	[Token(Token = "0x4005EDE")]
	[FieldOffset(Offset = "0x0")]
	public TutorialScriptType Type;

	// Token: 0x0400641B RID: 25627
	[Token(Token = "0x4005EDF")]
	[FieldOffset(Offset = "0x4")]
	public TutorialScriptID ScriptId;

	// Token: 0x0400641C RID: 25628
	[Token(Token = "0x4005EE0")]
	[FieldOffset(Offset = "0x8")]
	public GameFlagData OnFlag;
}
