using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200015C RID: 348
[Token(Token = "0x2000110")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145580", Offset = "0x145681")]
public class CompareSharedFarmMonsterState : Conditional
{
	// Token: 0x06000747 RID: 1863 RVA: 0x00004998 File Offset: 0x00002B98
	[Token(Token = "0x6000626")]
	[Address(RVA = "0x20DCF40", Offset = "0x20DD041", VA = "0x20DCF40", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000627")]
	[Address(RVA = "0x20DD020", Offset = "0x20DD121", VA = "0x20DD020", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000628")]
	[Address(RVA = "0x20DD060", Offset = "0x20DD161", VA = "0x20DD060")]
	public CompareSharedFarmMonsterState()
	{
	}

	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x15BEC0", Offset = "0x15BFC1")]
	public SharedFarmMonsterState variable;

	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x400033B")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x15BF00", Offset = "0x15C001")]
	public SharedFarmMonsterState compareTo;
}
