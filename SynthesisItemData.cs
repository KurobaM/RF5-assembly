using System;
using Il2CppDummyDll;

// Token: 0x02000859 RID: 2137
[Token(Token = "0x200057E")]
public abstract class SynthesisItemData : NotAmountItemData
{
	// Token: 0x170007EB RID: 2027
	// (get) Token: 0x0600389C RID: 14492 RVA: 0x00013908 File Offset: 0x00011B08
	[Token(Token = "0x17000630")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B87C0", Offset = "0x1B88C1")]
	public override bool IsOriginal
	{
		[Token(Token = "0x6002F20")]
		[Address(RVA = "0x1FB2010", Offset = "0x1FB2111", VA = "0x1FB2010", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600389D RID: 14493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F21")]
	[Address(RVA = "0x1FB2070", Offset = "0x1FB2171", VA = "0x1FB2070", Slot = "10")]
	public override ItemData Copy()
	{
		return null;
	}

	// Token: 0x0600389E RID: 14494
	[Token(Token = "0x6002F22")]
	public abstract bool CheckIsArrenge();

	// Token: 0x0600389F RID: 14495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F23")]
	[Address(RVA = "0x1FB2120", Offset = "0x1FB2221", VA = "0x1FB2120")]
	protected SynthesisItemData()
	{
	}

	// Token: 0x04007B83 RID: 31619
	[Token(Token = "0x4006FA3")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B750", Offset = "0x16B851")]
	public ItemID[] SourceItems;

	// Token: 0x04007B84 RID: 31620
	[Token(Token = "0x4006FA4")]
	public const int SourceMax = 6;
}
