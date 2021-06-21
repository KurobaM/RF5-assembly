using System;
using Il2CppDummyDll;

// Token: 0x02000614 RID: 1556
[Token(Token = "0x2000461")]
public interface ChopInteractionInterface : ToolInteractionInterface, FocusInterface
{
	// Token: 0x06002674 RID: 9844
	[Token(Token = "0x6002074")]
	void DoChop(HumanController humanController);

	// Token: 0x06002675 RID: 9845
	[Token(Token = "0x6002075")]
	bool CanChop(HumanController humanController);
}
