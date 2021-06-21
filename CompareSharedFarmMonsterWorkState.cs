using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200015D RID: 349
[Token(Token = "0x2000111")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1455C0", Offset = "0x1456C1")]
public class CompareSharedFarmMonsterWorkState : Conditional
{
	// Token: 0x0600074A RID: 1866 RVA: 0x000049B0 File Offset: 0x00002BB0
	[Token(Token = "0x6000629")]
	[Address(RVA = "0x20DD070", Offset = "0x20DD171", VA = "0x20DD070", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062A")]
	[Address(RVA = "0x20DD150", Offset = "0x20DD251", VA = "0x20DD150", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062B")]
	[Address(RVA = "0x20DD190", Offset = "0x20DD291", VA = "0x20DD190")]
	public CompareSharedFarmMonsterWorkState()
	{
	}

	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x15BF40", Offset = "0x15C041")]
	public SharedFarmMonsterWorkState variable;

	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x15BF80", Offset = "0x15C081")]
	public SharedFarmMonsterWorkState compareTo;
}
