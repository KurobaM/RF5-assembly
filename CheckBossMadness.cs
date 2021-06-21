using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000118 RID: 280
[Token(Token = "0x20000DC")]
public class CheckBossMadness : Conditional
{
	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000156")]
	private BossBehaviorController BossBehaviorController
	{
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1E9DCD0", Offset = "0x1E9DDD1", VA = "0x1E9DCD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x000042D8 File Offset: 0x000024D8
	[Token(Token = "0x6000522")]
	[Address(RVA = "0x1E9DD90", Offset = "0x1E9DE91", VA = "0x1E9DD90", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000523")]
	[Address(RVA = "0x1E9DE70", Offset = "0x1E9DF71", VA = "0x1E9DE70")]
	public CheckBossMadness()
	{
	}

	// Token: 0x0400034D RID: 845
	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x50")]
	private BossBehaviorController _BossBehaviorController;
}
