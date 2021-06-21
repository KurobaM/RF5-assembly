using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000131 RID: 305
[Token(Token = "0x20000F5")]
public class UpdatePartnerMovementOaderType : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x17000168 RID: 360
	// (get) Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000162")]
	private PartnerMovementController PartnerMovementController
	{
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1E46320", Offset = "0x1E46421", VA = "0x1E46320")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000589")]
	[Address(RVA = "0x1E46410", Offset = "0x1E46511", VA = "0x1E46410", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00004608 File Offset: 0x00002808
	[Token(Token = "0x600058A")]
	[Address(RVA = "0x1E464E0", Offset = "0x1E465E1", VA = "0x1E464E0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058B")]
	[Address(RVA = "0x1E46650", Offset = "0x1E46751", VA = "0x1E46650")]
	public UpdatePartnerMovementOaderType()
	{
	}

	// Token: 0x0400039B RID: 923
	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x50")]
	public SharedPartnerMovementOrderType SharedPartnerMovementOrderType;

	// Token: 0x0400039C RID: 924
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x58")]
	public SharedBool IsChangePreviousType;

	// Token: 0x0400039D RID: 925
	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x60")]
	private AIInput AIInput;
}
