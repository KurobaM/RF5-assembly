using System;
using Define;
using Festival;
using Il2CppDummyDll;

// Token: 0x02000890 RID: 2192
[Token(Token = "0x20005AB")]
public static class StampEnumConvert
{
	// Token: 0x060039B4 RID: 14772 RVA: 0x00013F08 File Offset: 0x00012108
	[Token(Token = "0x6003027")]
	[Address(RVA = "0x23886F0", Offset = "0x23887F1", VA = "0x23886F0")]
	public static StampEnum EventToStampEnum(Event _event)
	{
		return StampEnum.Shipping;
	}

	// Token: 0x060039B5 RID: 14773 RVA: 0x00013F20 File Offset: 0x00012120
	[Token(Token = "0x6003028")]
	[Address(RVA = "0x2388720", Offset = "0x2388821", VA = "0x2388720")]
	public static StampEnum MinigameToStampEnum(FestivalType _type)
	{
		return StampEnum.Shipping;
	}
}
