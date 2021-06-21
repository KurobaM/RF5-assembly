using System;
using Il2CppDummyDll;

// Token: 0x020003D2 RID: 978
[Token(Token = "0x20002F3")]
[Serializable]
public class MemoryDumpData
{
	// Token: 0x06001793 RID: 6035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F6")]
	[Address(RVA = "0x1F23AD0", Offset = "0x1F23BD1", VA = "0x1F23AD0")]
	public MemoryDumpData()
	{
	}

	// Token: 0x040010F6 RID: 4342
	[Token(Token = "0x4000D91")]
	[FieldOffset(Offset = "0x10")]
	public int No;

	// Token: 0x040010F7 RID: 4343
	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0x18")]
	public long Byte;

	// Token: 0x040010F8 RID: 4344
	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0x20")]
	public float MByte;

	// Token: 0x040010F9 RID: 4345
	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0x24")]
	public int InstanceID;

	// Token: 0x040010FA RID: 4346
	[Token(Token = "0x4000D95")]
	[FieldOffset(Offset = "0x28")]
	public string Name;

	// Token: 0x040010FB RID: 4347
	[Token(Token = "0x4000D96")]
	[FieldOffset(Offset = "0x30")]
	public string Path;
}
