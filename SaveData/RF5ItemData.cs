using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000ED0 RID: 3792
	[Token(Token = "0x20009B3")]
	public class RF5ItemData : SaveDataValueBase
	{
		// Token: 0x0600631E RID: 25374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600522F")]
		[Address(RVA = "0x1F01E30", Offset = "0x1F01F31", VA = "0x1F01E30")]
		public RF5ItemData()
		{
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005230")]
		[Address(RVA = "0x1F01E40", Offset = "0x1F01F41", VA = "0x1F01E40", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005231")]
		[Address(RVA = "0x1F02230", Offset = "0x1F02331", VA = "0x1F02230")]
		public void InitializeForNewGame()
		{
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005232")]
		[Address(RVA = "0x1F022C0", Offset = "0x1F023C1", VA = "0x1F022C0", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005233")]
		[Address(RVA = "0x1F02320", Offset = "0x1F02421", VA = "0x1F02320", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005234")]
		[Address(RVA = "0x1F02330", Offset = "0x1F02431", VA = "0x1F02330", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005235")]
		[Address(RVA = "0x1F02460", Offset = "0x1F02561", VA = "0x1F02460")]
		public static void Writer_internal(ItemStorageData itemStorageData, BinaryWriter writer)
		{
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005236")]
		[Address(RVA = "0x1F02520", Offset = "0x1F02621", VA = "0x1F02520")]
		public static ItemStorageData Reader0000_internal(BinaryReader reader)
		{
			return null;
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005237")]
		[Address(RVA = "0x1F025E0", Offset = "0x1F026E1", VA = "0x1F025E0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C2F8 RID: 49912
		[Token(Token = "0x400921A")]
		[FieldOffset(Offset = "0x10")]
		public ItemStorageData Rucksack;

		// Token: 0x0400C2F9 RID: 49913
		[Token(Token = "0x400921B")]
		[FieldOffset(Offset = "0x18")]
		public ItemStorageData ItemBox;

		// Token: 0x0400C2FA RID: 49914
		[Token(Token = "0x400921C")]
		[FieldOffset(Offset = "0x20")]
		public ItemStorageData Refrigerator;

		// Token: 0x0400C2FB RID: 49915
		[Token(Token = "0x400921D")]
		[FieldOffset(Offset = "0x28")]
		public ItemStorageData RuneRuck;

		// Token: 0x0400C2FC RID: 49916
		[Token(Token = "0x400921E")]
		[FieldOffset(Offset = "0x30")]
		public ItemStorageData WeaponBox;

		// Token: 0x0400C2FD RID: 49917
		[Token(Token = "0x400921F")]
		[FieldOffset(Offset = "0x38")]
		public ItemStorageData ArmorBox;

		// Token: 0x0400C2FE RID: 49918
		[Token(Token = "0x4009220")]
		[FieldOffset(Offset = "0x40")]
		public ItemStorageData FarmToolBox;

		// Token: 0x0400C2FF RID: 49919
		[Token(Token = "0x4009221")]
		[FieldOffset(Offset = "0x48")]
		public ItemStorageData RuneBox;

		// Token: 0x0400C300 RID: 49920
		[Token(Token = "0x4009222")]
		[FieldOffset(Offset = "0x50")]
		public ItemStorageData ShippingBox;

		// Token: 0x0400C301 RID: 49921
		[Token(Token = "0x4009223")]
		[FieldOffset(Offset = "0x58")]
		public FieldOnGroundItemStorage FieldOnGroundItemStorage;
	}
}
