using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000154 RID: 340
[Token(Token = "0x2000108")]
public class IsMadness : Conditional
{
	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016E")]
	private BossBehaviorController BossBehaviorController
	{
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x2235AF0", Offset = "0x2235BF1", VA = "0x2235AF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00004908 File Offset: 0x00002B08
	[Token(Token = "0x6000612")]
	[Address(RVA = "0x2235BB0", Offset = "0x2235CB1", VA = "0x2235BB0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000613")]
	[Address(RVA = "0x2235C90", Offset = "0x2235D91", VA = "0x2235C90")]
	public IsMadness()
	{
	}

	// Token: 0x0400041F RID: 1055
	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x50")]
	private BossBehaviorController _BossBehaviorController;
}
