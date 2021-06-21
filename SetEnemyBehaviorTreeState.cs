using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000159 RID: 345
[Token(Token = "0x200010D")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145500", Offset = "0x145601")]
public class SetEnemyBehaviorTreeState : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x0600073D RID: 1853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061C")]
	[Address(RVA = "0x1E343F0", Offset = "0x1E344F1", VA = "0x1E343F0", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00004968 File Offset: 0x00002B68
	[Token(Token = "0x600061D")]
	[Address(RVA = "0x1E34400", Offset = "0x1E34501", VA = "0x1E34400", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061E")]
	[Address(RVA = "0x1E34470", Offset = "0x1E34571", VA = "0x1E34470", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061F")]
	[Address(RVA = "0x1E34480", Offset = "0x1E34581", VA = "0x1E34480")]
	public SetEnemyBehaviorTreeState()
	{
	}

	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x50")]
	public SharedEnemyBehaviorTreeState stateValue;

	// Token: 0x0400042C RID: 1068
	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x58")]
	public EnemyBehaviorTreeState state;
}
