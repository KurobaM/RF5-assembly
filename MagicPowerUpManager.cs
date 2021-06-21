using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200064F RID: 1615
[Token(Token = "0x2000487")]
public static class MagicPowerUpManager
{
	// Token: 0x0600282E RID: 10286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002200")]
	[Address(RVA = "0x1F148F0", Offset = "0x1F149F1", VA = "0x1F148F0")]
	public static void SetMagicItem(ItemData _item)
	{
	}

	// Token: 0x0600282F RID: 10287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002201")]
	[Address(RVA = "0x1F14980", Offset = "0x1F14A81", VA = "0x1F14980")]
	public static string GetRequiredItem()
	{
		return null;
	}

	// Token: 0x06002830 RID: 10288 RVA: 0x0000FED0 File Offset: 0x0000E0D0
	[Token(Token = "0x6002202")]
	[Address(RVA = "0x1F14C30", Offset = "0x1F14D31", VA = "0x1F14C30")]
	public static bool CheckRequiredItem()
	{
		return default(bool);
	}

	// Token: 0x06002831 RID: 10289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002203")]
	[Address(RVA = "0x1F14EF0", Offset = "0x1F14FF1", VA = "0x1F14EF0")]
	public static void DoStrengthening()
	{
	}

	// Token: 0x06002832 RID: 10290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002204")]
	[Address(RVA = "0x1F15270", Offset = "0x1F15371", VA = "0x1F15270")]
	public static void ReturnMagicItem()
	{
	}

	// Token: 0x04006F9C RID: 28572
	[Token(Token = "0x400682A")]
	[FieldOffset(Offset = "0x0")]
	private static ItemData magicItem;

	// Token: 0x04006F9D RID: 28573
	[Token(Token = "0x400682B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly List<int> requiredItem;
}
