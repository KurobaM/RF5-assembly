using System;
using Il2CppDummyDll;

// Token: 0x0200061E RID: 1566
[Token(Token = "0x200046B")]
public interface SowInteractionInterface : ToolInteractionInterface, FocusInterface
{
	// Token: 0x06002696 RID: 9878
	[Token(Token = "0x6002096")]
	void DoSow(HumanController human, SeedItemData itemData);

	// Token: 0x06002697 RID: 9879
	[Token(Token = "0x6002097")]
	bool CanSow(HumanController human, SeedItemData itemData);
}
