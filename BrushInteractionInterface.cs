using System;
using Il2CppDummyDll;

// Token: 0x02000613 RID: 1555
[Token(Token = "0x2000460")]
public interface BrushInteractionInterface : ToolInteractionInterface, FocusInterface
{
	// Token: 0x06002672 RID: 9842
	[Token(Token = "0x6002072")]
	bool DoUseBrush(out float size);

	// Token: 0x06002673 RID: 9843
	[Token(Token = "0x6002073")]
	bool CanUseBrush(HumanController character);
}
