using System;
using Il2CppDummyDll;

// Token: 0x0200061C RID: 1564
[Token(Token = "0x2000469")]
public interface SlashInteractionInterface : ToolInteractionInterface, FocusInterface
{
	// Token: 0x06002690 RID: 9872
	[Token(Token = "0x6002090")]
	void DoSlash(HumanController humanController);

	// Token: 0x06002691 RID: 9873
	[Token(Token = "0x6002091")]
	bool CanSlash(HumanController humanController);
}
