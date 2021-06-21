using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200011C RID: 284
[Token(Token = "0x20000E0")]
public class MonsterActionBehaviorChecker : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000611 RID: 1553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000159")]
	private MonsterBehaviorController MonsterBehaviorController
	{
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1D80B70", Offset = "0x1D80C71", VA = "0x1D80B70")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00004338 File Offset: 0x00002538
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x1D80C30", Offset = "0x1D80D31", VA = "0x1D80C30", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x1D80C40", Offset = "0x1D80D41", VA = "0x1D80C40", Slot = "9")]
	public override void OnEnd()
	{
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x1D80ED0", Offset = "0x1D80FD1", VA = "0x1D80ED0")]
	public MonsterActionBehaviorChecker()
	{
	}

	// Token: 0x04000354 RID: 852
	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x50")]
	public SharedInt Index;

	// Token: 0x04000355 RID: 853
	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x58")]
	private MonsterBehaviorController _MonsterBehaviorController;
}
