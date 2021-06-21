using System;
using Il2CppDummyDll;

// Token: 0x02000615 RID: 1557
[Token(Token = "0x2000462")]
public interface FarmDrugInteractionInterface : ToolInteractionInterface, FocusInterface
{
	// Token: 0x06002676 RID: 9846
	[Token(Token = "0x6002076")]
	void DoSpray(HumanController human, ItemData itemData);

	// Token: 0x06002677 RID: 9847
	[Token(Token = "0x6002077")]
	bool CanSpray(HumanController human, ItemData itemData);
}
