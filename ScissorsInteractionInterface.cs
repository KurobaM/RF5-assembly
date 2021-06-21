using System;
using Il2CppDummyDll;

// Token: 0x0200061B RID: 1563
[Token(Token = "0x2000468")]
public interface ScissorsInteractionInterface : ToolInteractionInterface, FocusInterface
{
	// Token: 0x0600268E RID: 9870
	[Token(Token = "0x600208E")]
	bool DoUseScissors(out float size);

	// Token: 0x0600268F RID: 9871
	[Token(Token = "0x600208F")]
	bool CanUseScissors(HumanController character);
}
