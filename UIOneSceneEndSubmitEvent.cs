using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A92 RID: 2706
[Token(Token = "0x2000716")]
public class UIOneSceneEndSubmitEvent : MonoBehaviour
{
	// Token: 0x0600466B RID: 18027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AEF")]
	[Address(RVA = "0x1EAA750", Offset = "0x1EAA851", VA = "0x1EAA750")]
	private void EnterInIdel()
	{
	}

	// Token: 0x0600466C RID: 18028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AF0")]
	[Address(RVA = "0x1EAA760", Offset = "0x1EAA861", VA = "0x1EAA760")]
	private void Update()
	{
	}

	// Token: 0x0600466D RID: 18029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AF1")]
	[Address(RVA = "0x1EAA8C0", Offset = "0x1EAA9C1", VA = "0x1EAA8C0")]
	public void EndOnTouch()
	{
	}

	// Token: 0x0600466E RID: 18030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AF2")]
	[Address(RVA = "0x1EAA930", Offset = "0x1EAAA31", VA = "0x1EAA930")]
	public UIOneSceneEndSubmitEvent()
	{
	}

	// Token: 0x0400A56D RID: 42349
	[Token(Token = "0x4007CF4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool isIdelIntered;

	// Token: 0x0400A56E RID: 42350
	[Token(Token = "0x4007CF5")]
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool PlayOKSound;

	// Token: 0x0400A56F RID: 42351
	[Token(Token = "0x4007CF6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ChoiceButton ChoiceButton;
}
