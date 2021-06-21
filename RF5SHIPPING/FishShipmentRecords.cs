using System;
using BinaryStream;
using Il2CppDummyDll;

namespace RF5SHIPPING
{
	// Token: 0x02000E78 RID: 3704
	[Token(Token = "0x200097F")]
	[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x149680", Offset = "0x149781")]
	public class FishShipmentRecords
	{
		// Token: 0x06006102 RID: 24834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005051")]
		[Address(RVA = "0x2176620", Offset = "0x2176721", VA = "0x2176620")]
		public FishShipmentRecords()
		{
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005052")]
		[Address(RVA = "0x2176650", Offset = "0x2176751", VA = "0x2176650")]
		public void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005053")]
		[Address(RVA = "0x21766C0", Offset = "0x21767C1", VA = "0x21766C0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C0C5 RID: 49349
		[Token(Token = "0x4009078")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EBC0", Offset = "0x17ECC1")]
		public ItemID ItemId;

		// Token: 0x0400C0C6 RID: 49350
		[Token(Token = "0x4009079")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EBE0", Offset = "0x17ECE1")]
		public int ItemDataTableIndex;

		// Token: 0x0400C0C7 RID: 49351
		[Token(Token = "0x400907A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EC00", Offset = "0x17ED01")]
		public int sizeMax;

		// Token: 0x0400C0C8 RID: 49352
		[Token(Token = "0x400907B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EC20", Offset = "0x17ED21")]
		public CROWNTYPE crown;
	}
}
