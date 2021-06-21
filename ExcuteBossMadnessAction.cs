using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000119 RID: 281
[Token(Token = "0x20000DD")]
public class ExcuteBossMadnessAction : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000157")]
	private BossBehaviorController BossBehaviorController
	{
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x21BD0C0", Offset = "0x21BD1C1", VA = "0x21BD0C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x000042F0 File Offset: 0x000024F0
	[Token(Token = "0x6000525")]
	[Address(RVA = "0x21BD180", Offset = "0x21BD281", VA = "0x21BD180", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000526")]
	[Address(RVA = "0x21BD260", Offset = "0x21BD361", VA = "0x21BD260")]
	public ExcuteBossMadnessAction()
	{
	}

	// Token: 0x0400034E RID: 846
	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x50")]
	private BossBehaviorController _BossBehaviorController;
}
