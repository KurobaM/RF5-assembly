using System;
using Il2CppDummyDll;

// Token: 0x0200061D RID: 1565
[Token(Token = "0x200046A")]
public interface SmashInteractionInterface : ToolInteractionInterface, FocusInterface
{
	// Token: 0x06002692 RID: 9874
	[Token(Token = "0x6002092")]
	void DoSmash(HumanController humanController);

	// Token: 0x06002693 RID: 9875
	[Token(Token = "0x6002093")]
	bool CanSmash(HumanController humanController);

	// Token: 0x06002694 RID: 9876
	[Token(Token = "0x6002094")]
	void DoBreak(HumanController humanController);

	// Token: 0x06002695 RID: 9877
	[Token(Token = "0x6002095")]
	bool CanBreak(HumanController humanController);
}
