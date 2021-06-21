using System;
using Il2CppDummyDll;

// Token: 0x02000618 RID: 1560
[Token(Token = "0x2000465")]
public interface ItemInteractionInterface : FocusInterface
{
	// Token: 0x06002687 RID: 9863
	[Token(Token = "0x6002087")]
	void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow);

	// Token: 0x06002688 RID: 9864
	[Token(Token = "0x6002088")]
	bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow);

	// Token: 0x06002689 RID: 9865
	[Token(Token = "0x6002089")]
	bool CanRapidItemInteraction(HumanController character, ItemData itemData);
}
