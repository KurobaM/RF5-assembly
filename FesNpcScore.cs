using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200042F RID: 1071
[Token(Token = "0x200033B")]
public class FesNpcScore
{
	// Token: 0x060019EF RID: 6639 RVA: 0x0000B358 File Offset: 0x00009558
	[Token(Token = "0x6001715")]
	[Address(RVA = "0x21B34D0", Offset = "0x21B35D1", VA = "0x21B34D0")]
	public static int Compare(FesNpcScore a, FesNpcScore b)
	{
		return 0;
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001716")]
	public static void Swap<T>(IList<T> list, int indexA, int indexB)
	{
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001717")]
	[Address(RVA = "0x21B3500", Offset = "0x21B3601", VA = "0x21B3500")]
	public FesNpcScore()
	{
	}

	// Token: 0x04005D09 RID: 23817
	[Token(Token = "0x4005950")]
	[FieldOffset(Offset = "0x10")]
	public int npcId;

	// Token: 0x04005D0A RID: 23818
	[Token(Token = "0x4005951")]
	[FieldOffset(Offset = "0x14")]
	public int score;
}
