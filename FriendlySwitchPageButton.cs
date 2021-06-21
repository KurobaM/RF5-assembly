using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x02000A0E RID: 2574
[Token(Token = "0x20006C0")]
public class FriendlySwitchPageButton : ButtonWorkBase
{
	// Token: 0x06004372 RID: 17266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003871")]
	[Address(RVA = "0x23D0DD0", Offset = "0x23D0ED1", VA = "0x23D0DD0", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x06004373 RID: 17267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003872")]
	[Address(RVA = "0x23D0DE0", Offset = "0x23D0EE1", VA = "0x23D0DE0", Slot = "7")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004374 RID: 17268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003873")]
	[Address(RVA = "0x23D1050", Offset = "0x23D1151", VA = "0x23D1050")]
	public FriendlySwitchPageButton()
	{
	}

	// Token: 0x0400A251 RID: 41553
	[Token(Token = "0x4007AA8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GenerateFriendlistButton.FriendType FriendType;

	// Token: 0x0400A252 RID: 41554
	[Token(Token = "0x4007AA9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GenerateFriendlistButton generator;

	// Token: 0x0400A253 RID: 41555
	[Token(Token = "0x4007AAA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<GameObject> OpenObjects;

	// Token: 0x0400A254 RID: 41556
	[Token(Token = "0x4007AAB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<GameObject> CloseObjects;
}
