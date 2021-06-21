using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200014A RID: 330
[Token(Token = "0x20000FE")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145300", Offset = "0x145401")]
public class GetActionScriptWaitTime : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000708 RID: 1800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x1FA8560", Offset = "0x1FA8661", VA = "0x1FA8560", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x1FA8630", Offset = "0x1FA8731", VA = "0x1FA8630", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00004800 File Offset: 0x00002A00
	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x1FA8640", Offset = "0x1FA8741", VA = "0x1FA8640", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x1FA86E0", Offset = "0x1FA87E1", VA = "0x1FA86E0")]
	public GetActionScriptWaitTime()
	{
	}

	// Token: 0x04000403 RID: 1027
	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private SharedFloat MinWaitTime;

	// Token: 0x04000404 RID: 1028
	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SharedFloat MaxWaitTime;

	// Token: 0x04000405 RID: 1029
	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x60")]
	private MonsterBehaviorController MonsterBehaviorController;
}
