using System;
using BinaryStream;
using Il2CppDummyDll;

namespace RF5SHIPPING
{
	// Token: 0x02000E77 RID: 3703
	[Token(Token = "0x200097E")]
	[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x149660", Offset = "0x149761")]
	public class ShipmentItemRecords
	{
		// Token: 0x060060FF RID: 24831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504E")]
		[Address(RVA = "0x2176800", Offset = "0x2176901", VA = "0x2176800")]
		public ShipmentItemRecords()
		{
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504F")]
		[Address(RVA = "0x2176830", Offset = "0x2176931", VA = "0x2176830")]
		public void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005050")]
		[Address(RVA = "0x21768C0", Offset = "0x21769C1", VA = "0x21768C0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C0BF RID: 49343
		[Token(Token = "0x4009072")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EB00", Offset = "0x17EC01")]
		public ItemID ItemId;

		// Token: 0x0400C0C0 RID: 49344
		[Token(Token = "0x4009073")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EB20", Offset = "0x17EC21")]
		public int ItemDataTableIndex;

		// Token: 0x0400C0C1 RID: 49345
		[Token(Token = "0x4009074")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EB40", Offset = "0x17EC41")]
		public int Pieces;

		// Token: 0x0400C0C2 RID: 49346
		[Token(Token = "0x4009075")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EB60", Offset = "0x17EC61")]
		public long totalPrice;

		// Token: 0x0400C0C3 RID: 49347
		[Token(Token = "0x4009076")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EB80", Offset = "0x17EC81")]
		public int maxLv;

		// Token: 0x0400C0C4 RID: 49348
		[Token(Token = "0x4009077")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EBA0", Offset = "0x17ECA1")]
		public CROWNTYPE crown;
	}
}
