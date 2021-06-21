using System;
using BinaryStream;
using Il2CppDummyDll;

namespace RF5SHIPPING
{
	// Token: 0x02000E79 RID: 3705
	[Token(Token = "0x2000980")]
	[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x1496A0", Offset = "0x1497A1")]
	public class SeedLevelRecords
	{
		// Token: 0x06006105 RID: 24837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005054")]
		[Address(RVA = "0x2176730", Offset = "0x2176831", VA = "0x2176730")]
		public SeedLevelRecords()
		{
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005055")]
		[Address(RVA = "0x2176760", Offset = "0x2176861", VA = "0x2176760")]
		public void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005056")]
		[Address(RVA = "0x21767B0", Offset = "0x21768B1", VA = "0x21767B0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C0C9 RID: 49353
		[Token(Token = "0x400907C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EC40", Offset = "0x17ED41")]
		public ItemID ItemId;

		// Token: 0x0400C0CA RID: 49354
		[Token(Token = "0x400907D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "KeyAttribute", RVA = "0x17EC60", Offset = "0x17ED61")]
		public int maxLv;
	}
}
