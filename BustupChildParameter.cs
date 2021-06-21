using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020007E3 RID: 2019
[Token(Token = "0x200053B")]
public class BustupChildParameter
{
	// Token: 0x17000742 RID: 1858
	// (get) Token: 0x060034D6 RID: 13526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005AB")]
	private ChildData data
	{
		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x219AAF0", Offset = "0x219ABF1", VA = "0x219AAF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000743 RID: 1859
	// (get) Token: 0x060034D7 RID: 13527 RVA: 0x00012018 File Offset: 0x00010218
	[Token(Token = "0x170005AC")]
	public Gender Gender
	{
		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x219AB30", Offset = "0x219AC31", VA = "0x219AB30")]
		get
		{
			return Gender.None;
		}
	}

	// Token: 0x17000744 RID: 1860
	// (get) Token: 0x060034D8 RID: 13528 RVA: 0x00012030 File Offset: 0x00010230
	[Token(Token = "0x170005AD")]
	public int Character
	{
		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x219AB90", Offset = "0x219AC91", VA = "0x219AB90")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000745 RID: 1861
	// (get) Token: 0x060034D9 RID: 13529 RVA: 0x00012048 File Offset: 0x00010248
	[Token(Token = "0x170005AE")]
	public int HairColor
	{
		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x219ABE0", Offset = "0x219ACE1", VA = "0x219ABE0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060034DA RID: 13530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BFC")]
	[Address(RVA = "0x219AC80", Offset = "0x219AD81", VA = "0x219AC80")]
	public BustupChildParameter(int _npcId)
	{
	}

	// Token: 0x04007873 RID: 30835
	[Token(Token = "0x4006D59")]
	[FieldOffset(Offset = "0x10")]
	private int npcId;
}
