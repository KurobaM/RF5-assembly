using System;
using Define;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x0200111D RID: 4381
	[Token(Token = "0x2000B05")]
	[Serializable]
	public struct FieldHideItemSpawnDataTable
	{
		// Token: 0x040181D5 RID: 98773
		[Token(Token = "0x4014C78")]
		[FieldOffset(Offset = "0x0")]
		public FieldHideItemSpawnID DataID;

		// Token: 0x040181D6 RID: 98774
		[Token(Token = "0x4014C79")]
		[FieldOffset(Offset = "0x4")]
		public ItemLotteryWeightID LotteryWeightID;

		// Token: 0x040181D7 RID: 98775
		[Token(Token = "0x4014C7A")]
		[FieldOffset(Offset = "0x8")]
		public int Level;

		// Token: 0x040181D8 RID: 98776
		[Token(Token = "0x4014C7B")]
		[FieldOffset(Offset = "0xC")]
		public FieldSceneId FieldId;
	}
}
