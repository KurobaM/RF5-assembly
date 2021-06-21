using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000129 RID: 297
[Token(Token = "0x20000ED")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144F80", Offset = "0x145081")]
public class PartnerNPCGrantAttribute : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x17000166 RID: 358
	// (get) Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000160")]
	private PartnerNPCController PartnerNPCController
	{
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x2138DD0", Offset = "0x2138ED1", VA = "0x2138DD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000569")]
	[Address(RVA = "0x2138E30", Offset = "0x2138F31", VA = "0x2138E30", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x000044E8 File Offset: 0x000026E8
	[Token(Token = "0x600056A")]
	[Address(RVA = "0x2139060", Offset = "0x2139161", VA = "0x2139060", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056B")]
	[Address(RVA = "0x2139070", Offset = "0x2139171", VA = "0x2139070")]
	public PartnerNPCGrantAttribute()
	{
	}

	// Token: 0x0400038C RID: 908
	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x50")]
	public SharedPartnerNPCBehaviorController SharedPartnerBehaviorController;

	// Token: 0x0400038D RID: 909
	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x58")]
	public SharedAttackAttribute Attribute;

	// Token: 0x0400038E RID: 910
	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x60")]
	public SharedFloat Duration;
}
