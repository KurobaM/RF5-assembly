using System;
using Il2CppDummyDll;

namespace ItemFurniture
{
	// Token: 0x0200103F RID: 4159
	[Token(Token = "0x2000A8E")]
	public class AmountStorageFurniture : StorageFurniture
	{
		// Token: 0x0600688E RID: 26766 RVA: 0x00023C40 File Offset: 0x00021E40
		[Token(Token = "0x6005712")]
		[Address(RVA = "0x2239570", Offset = "0x2239671", VA = "0x2239570", Slot = "36")]
		public override bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow)
		{
			return default(bool);
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005713")]
		[Address(RVA = "0x2239620", Offset = "0x2239721", VA = "0x2239620", Slot = "37")]
		public override void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow)
		{
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x00023C58 File Offset: 0x00021E58
		[Token(Token = "0x6005714")]
		[Address(RVA = "0x22395F0", Offset = "0x22396F1", VA = "0x22395F0")]
		public static bool CheckCompost(ItemID id)
		{
			return default(bool);
		}

		// Token: 0x06006891 RID: 26769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005715")]
		[Address(RVA = "0x2239A40", Offset = "0x2239B41", VA = "0x2239A40")]
		public AmountStorageFurniture()
		{
		}
	}
}
