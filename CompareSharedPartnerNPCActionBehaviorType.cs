using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000152 RID: 338
[Token(Token = "0x2000106")]
public class CompareSharedPartnerNPCActionBehaviorType : Conditional
{
	// Token: 0x0600072A RID: 1834 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x6000609")]
	[Address(RVA = "0x20DD400", Offset = "0x20DD501", VA = "0x20DD400", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060A")]
	[Address(RVA = "0x20DD4E0", Offset = "0x20DD5E1", VA = "0x20DD4E0", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060B")]
	[Address(RVA = "0x20DD520", Offset = "0x20DD621", VA = "0x20DD520")]
	public CompareSharedPartnerNPCActionBehaviorType()
	{
	}

	// Token: 0x04000414 RID: 1044
	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x50")]
	public SharedPartnerNPCActionBehaviorType variable;

	// Token: 0x04000415 RID: 1045
	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x58")]
	public SharedPartnerNPCActionBehaviorType compareTo;
}
