using System;
using Il2CppDummyDll;

// Token: 0x02000619 RID: 1561
[Token(Token = "0x2000466")]
public interface PlowInteractionInterface : ToolInteractionInterface, FocusInterface
{
	// Token: 0x0600268A RID: 9866
	[Token(Token = "0x600208A")]
	void DoPlow(HumanController humanController);

	// Token: 0x0600268B RID: 9867
	[Token(Token = "0x600208B")]
	bool CanPlow(HumanController humanController);
}
