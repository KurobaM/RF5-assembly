using System;
using Il2CppDummyDll;

// Token: 0x020003EB RID: 1003
[Token(Token = "0x200030C")]
public class ItemCollisionSize
{
	// Token: 0x06001796 RID: 6038 RVA: 0x0000A458 File Offset: 0x00008658
	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x2236480", Offset = "0x2236581", VA = "0x2236480")]
	public static float GetSizeValue(ItemSize itemSize)
	{
		return 0f;
	}

	// Token: 0x1700041D RID: 1053
	// (get) Token: 0x06001797 RID: 6039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003B3")]
	public static float[] SizeArray
	{
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x2236510", Offset = "0x2236611", VA = "0x2236510")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x2236620", Offset = "0x2236721", VA = "0x2236620")]
	public ItemCollisionSize()
	{
	}

	// Token: 0x040026B4 RID: 9908
	[Token(Token = "0x400234F")]
	[FieldOffset(Offset = "0x0")]
	public static readonly float Minimum;

	// Token: 0x040026B5 RID: 9909
	[Token(Token = "0x4002350")]
	[FieldOffset(Offset = "0x4")]
	public static readonly float Small;

	// Token: 0x040026B6 RID: 9910
	[Token(Token = "0x4002351")]
	[FieldOffset(Offset = "0x8")]
	public static readonly float Middle;

	// Token: 0x040026B7 RID: 9911
	[Token(Token = "0x4002352")]
	[FieldOffset(Offset = "0xC")]
	public static readonly float Big;

	// Token: 0x040026B8 RID: 9912
	[Token(Token = "0x4002353")]
	[FieldOffset(Offset = "0x10")]
	public static readonly float Gaiant;
}
