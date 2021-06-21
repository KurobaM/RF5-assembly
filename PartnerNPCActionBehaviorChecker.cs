using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000125 RID: 293
[Token(Token = "0x20000E9")]
public class PartnerNPCActionBehaviorChecker : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015D")]
	private PartnerNPCBehaviorController PartenrNPCBehaviorController
	{
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x2134E00", Offset = "0x2134F01", VA = "0x2134E00")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00004428 File Offset: 0x00002628
	[Token(Token = "0x6000552")]
	[Address(RVA = "0x2134EC0", Offset = "0x2134FC1", VA = "0x2134EC0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000553")]
	[Address(RVA = "0x2134ED0", Offset = "0x2134FD1", VA = "0x2134ED0", Slot = "9")]
	public override void OnEnd()
	{
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000554")]
	[Address(RVA = "0x2135090", Offset = "0x2135191", VA = "0x2135090")]
	public PartnerNPCActionBehaviorChecker()
	{
	}

	// Token: 0x04000377 RID: 887
	[Token(Token = "0x40002C0")]
	[FieldOffset(Offset = "0x50")]
	public SharedInt Index;

	// Token: 0x04000378 RID: 888
	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x58")]
	private PartnerNPCBehaviorController _PartnerNPCBehaviorController;
}
