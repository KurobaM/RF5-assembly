using System;
using Il2CppDummyDll;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000024")]
public abstract class MonsterActionBehaviorCommandBase : ActionBehaviorCommandBase
{
	// Token: 0x06000071 RID: 113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1D80EE0", Offset = "0x1D80FE1", VA = "0x1D80EE0")]
	public MonsterActionBehaviorCommandBase(MonsterActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1D80F20", Offset = "0x1D81021", VA = "0x1D80F20", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x20")]
	protected MonsterActionBehaviorController MonsterActionBehaviorController;
}
