using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000803 RID: 2051
[Token(Token = "0x2000549")]
[Serializable]
public class NpcLifeCycleTimeData
{
	// Token: 0x060036BF RID: 14015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D87")]
	[Address(RVA = "0x1F48150", Offset = "0x1F48251", VA = "0x1F48150")]
	public NpcLifeCycleTimeData()
	{
	}

	// Token: 0x040079B3 RID: 31155
	[Token(Token = "0x4006E42")]
	[FieldOffset(Offset = "0x10")]
	public Place TargetPlace;

	// Token: 0x040079B4 RID: 31156
	[Token(Token = "0x4006E43")]
	[FieldOffset(Offset = "0x18")]
	public string TargetPlaceName;

	// Token: 0x040079B5 RID: 31157
	[Token(Token = "0x4006E44")]
	[FieldOffset(Offset = "0x20")]
	public NpcState TargetState;

	// Token: 0x040079B6 RID: 31158
	[Token(Token = "0x4006E45")]
	[FieldOffset(Offset = "0x28")]
	public string ActionName;

	// Token: 0x040079B7 RID: 31159
	[Token(Token = "0x4006E46")]
	[FieldOffset(Offset = "0x30")]
	public string LoopActionName;

	// Token: 0x040079B8 RID: 31160
	[Token(Token = "0x4006E47")]
	[FieldOffset(Offset = "0x38")]
	public string EndActionName;

	// Token: 0x040079B9 RID: 31161
	[Token(Token = "0x4006E48")]
	[FieldOffset(Offset = "0x40")]
	public string EndActionClearName;
}
