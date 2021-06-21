using System;
using Il2CppDummyDll;

// Token: 0x0200061A RID: 1562
[Token(Token = "0x2000467")]
public interface PotInteractionInterface : ToolInteractionInterface, FocusInterface
{
	// Token: 0x0600268C RID: 9868
	[Token(Token = "0x600208C")]
	bool UsePot(HumanController humanController, EquipItemData equipItemData);

	// Token: 0x0600268D RID: 9869
	[Token(Token = "0x600208D")]
	bool CanUsePot(HumanController humanController, EquipItemData equipItemData, bool isRange);
}
