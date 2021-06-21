using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000123 RID: 291
[Token(Token = "0x20000E7")]
public class ExecutePartnerNPCActionBehaviorList : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x17000162 RID: 354
	// (get) Token: 0x0600062F RID: 1583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015C")]
	private PartnerNPCBehaviorController PartnerNPCBehaviorController
	{
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x21BD800", Offset = "0x21BD901", VA = "0x21BD800")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x000043F8 File Offset: 0x000025F8
	[Token(Token = "0x600054C")]
	[Address(RVA = "0x21BD8C0", Offset = "0x21BD9C1", VA = "0x21BD8C0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054D")]
	[Address(RVA = "0x21BDC80", Offset = "0x21BDD81", VA = "0x21BDC80")]
	public ExecutePartnerNPCActionBehaviorList()
	{
	}

	// Token: 0x04000371 RID: 881
	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x50")]
	public SharedInt Index;

	// Token: 0x04000372 RID: 882
	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x58")]
	public SharedPartnerNPCActionBehaviorType SharedPartnerActionType;

	// Token: 0x04000373 RID: 883
	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x60")]
	private PartnerNPCBehaviorController _PartnerNPCBehaviorController;
}
