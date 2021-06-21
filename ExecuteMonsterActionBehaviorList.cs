using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200011B RID: 283
[Token(Token = "0x20000DF")]
public class ExecuteMonsterActionBehaviorList : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x1700015E RID: 350
	// (get) Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000158")]
	private MonsterBehaviorController MonsterBehaviorController
	{
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x21BD400", Offset = "0x21BD501", VA = "0x21BD400")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00004320 File Offset: 0x00002520
	[Token(Token = "0x600052B")]
	[Address(RVA = "0x21BD4C0", Offset = "0x21BD5C1", VA = "0x21BD4C0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052C")]
	[Address(RVA = "0x21BD7F0", Offset = "0x21BD8F1", VA = "0x21BD7F0")]
	public ExecuteMonsterActionBehaviorList()
	{
	}

	// Token: 0x04000351 RID: 849
	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x50")]
	public SharedInt Index;

	// Token: 0x04000352 RID: 850
	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x58")]
	public SharedMonsterActionBehaviorType SharedMonsterActionType;

	// Token: 0x04000353 RID: 851
	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0x60")]
	private MonsterBehaviorController _MonsterBehaviorController;
}
