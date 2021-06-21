using System;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001132 RID: 4402
	[Token(Token = "0x2000B11")]
	public class FieldTreasureBoxDropItem
	{
		// Token: 0x06006F68 RID: 28520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C53")]
		[Address(RVA = "0x1F86620", Offset = "0x1F86721", VA = "0x1F86620")]
		public FieldTreasureBoxDropItem()
		{
		}

		// Token: 0x0401822C RID: 98860
		[Token(Token = "0x4014CBA")]
		[FieldOffset(Offset = "0x10")]
		public ItemID ItemId;

		// Token: 0x0401822D RID: 98861
		[Token(Token = "0x4014CBB")]
		[FieldOffset(Offset = "0x18")]
		public int[] Levels;
	}
}
