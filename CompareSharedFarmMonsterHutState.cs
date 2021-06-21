using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200015B RID: 347
[Token(Token = "0x200010F")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145540", Offset = "0x145641")]
public class CompareSharedFarmMonsterHutState : Conditional
{
	// Token: 0x06000744 RID: 1860 RVA: 0x00004980 File Offset: 0x00002B80
	[Token(Token = "0x6000623")]
	[Address(RVA = "0x20DCE10", Offset = "0x20DCF11", VA = "0x20DCE10", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000624")]
	[Address(RVA = "0x20DCEF0", Offset = "0x20DCFF1", VA = "0x20DCEF0", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000625")]
	[Address(RVA = "0x20DCF30", Offset = "0x20DD031", VA = "0x20DCF30")]
	public CompareSharedFarmMonsterHutState()
	{
	}

	// Token: 0x0400042D RID: 1069
	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x15BE40", Offset = "0x15BF41")]
	public SharedFarmMonsterHutState variable;

	// Token: 0x0400042E RID: 1070
	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x15BE80", Offset = "0x15BF81")]
	public SharedFarmMonsterHutState compareTo;
}
