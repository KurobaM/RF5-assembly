using System;
using Il2CppDummyDll;

namespace Define
{
	// Token: 0x0200121C RID: 4636
	[Token(Token = "0x2000BF0")]
	public enum InteractionType : ushort
	{
		// Token: 0x04018D6C RID: 101740
		[Token(Token = "0x40157D5")]
		NONE,
		// Token: 0x04018D6D RID: 101741
		[Token(Token = "0x40157D6")]
		TALKABLE,
		// Token: 0x04018D6E RID: 101742
		[Token(Token = "0x40157D7")]
		ACTION,
		// Token: 0x04018D6F RID: 101743
		[Token(Token = "0x40157D8")]
		HOLDABLE = 4,
		// Token: 0x04018D70 RID: 101744
		[Token(Token = "0x40157D9")]
		ITEM_TAKEABLE = 8,
		// Token: 0x04018D71 RID: 101745
		[Token(Token = "0x40157DA")]
		ITEM_USEABLE = 16,
		// Token: 0x04018D72 RID: 101746
		[Token(Token = "0x40157DB")]
		ITEM_PUTIN_STAND = 32,
		// Token: 0x04018D73 RID: 101747
		[Token(Token = "0x40157DC")]
		ITEM_PUTIN_SQUAT = 64
	}
}
