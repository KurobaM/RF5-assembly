using System;
using Il2CppDummyDll;

// Token: 0x02000617 RID: 1559
[Token(Token = "0x2000464")]
public interface InteractionInterface : FocusInterface
{
	// Token: 0x06002682 RID: 9858
	[Token(Token = "0x6002082")]
	void DoInteraction(HumanController character);

	// Token: 0x06002683 RID: 9859
	[Token(Token = "0x6002083")]
	bool CanInteraction(HumanController character);

	// Token: 0x06002684 RID: 9860
	[Token(Token = "0x6002084")]
	void DoInteraction(MonsterControllerBase character);

	// Token: 0x06002685 RID: 9861
	[Token(Token = "0x6002085")]
	bool CanInteraction(MonsterControllerBase character);

	// Token: 0x06002686 RID: 9862
	[Token(Token = "0x6002086")]
	string GetInteractionButtonHint();
}
