using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200011D RID: 285
[Token(Token = "0x20000E1")]
public class MonsterExecuteFunctionAction : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000615 RID: 1557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015A")]
	private MonsterBehaviorController MonsterBehaviorController
	{
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1E60700", Offset = "0x1E60801", VA = "0x1E60700")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000532")]
	[Address(RVA = "0x1E607C0", Offset = "0x1E608C1", VA = "0x1E607C0", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x00004350 File Offset: 0x00002550
	[Token(Token = "0x6000533")]
	[Address(RVA = "0x1E60940", Offset = "0x1E60A41", VA = "0x1E60940", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000534")]
	[Address(RVA = "0x1E60A10", Offset = "0x1E60B11", VA = "0x1E60A10", Slot = "9")]
	public override void OnEnd()
	{
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000535")]
	[Address(RVA = "0x1E60BE0", Offset = "0x1E60CE1", VA = "0x1E60BE0")]
	public MonsterExecuteFunctionAction()
	{
	}

	// Token: 0x04000356 RID: 854
	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x50")]
	private MonsterBehaviorController _MonsterBehaviorController;
}
