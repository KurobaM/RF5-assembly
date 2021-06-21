using System;
using Il2CppDummyDll;

// Token: 0x02000321 RID: 801
[Token(Token = "0x200025C")]
[Serializable]
public struct AutoSaveCheckData
{
	// Token: 0x04000C53 RID: 3155
	[Token(Token = "0x4000968")]
	[FieldOffset(Offset = "0x0")]
	public AutoSaveType PrevAutoSaveType;

	// Token: 0x04000C54 RID: 3156
	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x4")]
	public int PrevAutoSaveTime;

	// Token: 0x04000C55 RID: 3157
	[Token(Token = "0x400096A")]
	[FieldOffset(Offset = "0x8")]
	public int PrevAutoSaveMapId;

	// Token: 0x04000C56 RID: 3158
	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0xC")]
	public bool IsInitGameMain;
}
