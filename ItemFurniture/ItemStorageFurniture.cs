using System;
using Define;
using Il2CppDummyDll;

namespace ItemFurniture
{
	// Token: 0x02001050 RID: 4176
	[Token(Token = "0x2000A9A")]
	public class ItemStorageFurniture : StorageFurniture
	{
		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06006919 RID: 26905 RVA: 0x00023EB0 File Offset: 0x000220B0
		[Token(Token = "0x17000A84")]
		private StorageType StorageType
		{
			[Token(Token = "0x600578B")]
			[Address(RVA = "0x2081D20", Offset = "0x2081E21", VA = "0x2081D20")]
			get
			{
				return StorageType.Rucksack;
			}
		}

		// Token: 0x0600691A RID: 26906 RVA: 0x00023EC8 File Offset: 0x000220C8
		[Token(Token = "0x600578C")]
		[Address(RVA = "0x2081DF0", Offset = "0x2081EF1", VA = "0x2081DF0", Slot = "36")]
		public override bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow)
		{
			return default(bool);
		}

		// Token: 0x0600691B RID: 26907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578D")]
		[Address(RVA = "0x2082020", Offset = "0x2082121", VA = "0x2082020", Slot = "37")]
		public override void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow)
		{
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x00023EE0 File Offset: 0x000220E0
		[Token(Token = "0x600578E")]
		[Address(RVA = "0x2081D90", Offset = "0x2081E91", VA = "0x2081D90")]
		private static StorageType FurnitureIDToStorageType(FurnitureID id)
		{
			return StorageType.Rucksack;
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600578F")]
		[Address(RVA = "0x2082380", Offset = "0x2082481", VA = "0x2082380")]
		public ItemStorageFurniture()
		{
		}
	}
}
