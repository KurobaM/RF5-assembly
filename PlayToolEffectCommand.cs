using System;
using Il2CppDummyDll;

// Token: 0x020000D7 RID: 215
[Token(Token = "0x20000AD")]
public class PlayToolEffectCommand : ToolActionCommandBase
{
	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x0600041C RID: 1052 RVA: 0x00003798 File Offset: 0x00001998
	[Token(Token = "0x170000E3")]
	public int Slot
	{
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x21434B0", Offset = "0x21435B1", VA = "0x21434B0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x0600041D RID: 1053 RVA: 0x000037B0 File Offset: 0x000019B0
	[Token(Token = "0x170000E4")]
	public float Scale
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x21434D0", Offset = "0x21435D1", VA = "0x21434D0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x21434F0", Offset = "0x21435F1", VA = "0x21434F0")]
	public PlayToolEffectCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x2143550", Offset = "0x2143651", VA = "0x2143550", Slot = "8")]
	public override void DoAction()
	{
	}
}
