using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200050D RID: 1293
[Token(Token = "0x20003B0")]
public class FestivalPlayerInput : CharacterInput
{
	// Token: 0x06001F75 RID: 8053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ADF")]
	[Address(RVA = "0x1F81150", Offset = "0x1F81251", VA = "0x1F81150", Slot = "4")]
	protected override void Start()
	{
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x1F81160", Offset = "0x1F81261", VA = "0x1F81160", Slot = "6")]
	public override void SetCharacter(Character character)
	{
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0x1F81210", Offset = "0x1F81311", VA = "0x1F81210")]
	private void Update()
	{
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x0000D308 File Offset: 0x0000B508
	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x1F81690", Offset = "0x1F81791", VA = "0x1F81690")]
	private Vector3 InputDirection(Vector3 _start_forward)
	{
		return default(Vector3);
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE3")]
	[Address(RVA = "0x1F81940", Offset = "0x1F81A41", VA = "0x1F81940")]
	public FestivalPlayerInput()
	{
	}

	// Token: 0x0400666B RID: 26219
	[Token(Token = "0x40060BC")]
	[FieldOffset(Offset = "0x20")]
	private FestivalCharacterController controller;
}
