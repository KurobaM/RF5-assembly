using System;
using Define;
using Il2CppDummyDll;

namespace RF5SHOP
{
	// Token: 0x02000E68 RID: 3688
	[Token(Token = "0x2000971")]
	[Serializable]
	public struct ShopNpcTalk
	{
		// Token: 0x0400BFDF RID: 49119
		[Token(Token = "0x4008F98")]
		[FieldOffset(Offset = "0x0")]
		public NpcShopType NpcShopType;

		// Token: 0x0400BFE0 RID: 49120
		[Token(Token = "0x4008F99")]
		[FieldOffset(Offset = "0x4")]
		public int TalkType;

		// Token: 0x0400BFE1 RID: 49121
		[Token(Token = "0x4008F9A")]
		[FieldOffset(Offset = "0x8")]
		public NPCID NPCID;

		// Token: 0x0400BFE2 RID: 49122
		[Token(Token = "0x4008F9B")]
		[FieldOffset(Offset = "0x10")]
		public string TalkTextId;

		// Token: 0x0400BFE3 RID: 49123
		[Token(Token = "0x4008F9C")]
		[FieldOffset(Offset = "0x18")]
		public SoundID voiceId;

		// Token: 0x0400BFE4 RID: 49124
		[Token(Token = "0x4008F9D")]
		[FieldOffset(Offset = "0x1C")]
		public int FaceVariable;

		// Token: 0x0400BFE5 RID: 49125
		[Token(Token = "0x4008F9E")]
		[FieldOffset(Offset = "0x20")]
		public float mouthTime;

		// Token: 0x0400BFE6 RID: 49126
		[Token(Token = "0x4008F9F")]
		[FieldOffset(Offset = "0x24")]
		public float duration;

		// Token: 0x0400BFE7 RID: 49127
		[Token(Token = "0x4008FA0")]
		[FieldOffset(Offset = "0x28")]
		public float presetX;

		// Token: 0x0400BFE8 RID: 49128
		[Token(Token = "0x4008FA1")]
		[FieldOffset(Offset = "0x2C")]
		public float presetY;
	}
}
