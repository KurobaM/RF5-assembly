using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000144 RID: 324
[Token(Token = "0x20000F8")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145180", Offset = "0x145281")]
public class ChangeCautionSerchCharacterParameter : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x1700017A RID: 378
	// (get) Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000166")]
	private SearchCharacterController SearchCharacterController
	{
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1E826F0", Offset = "0x1E827F1", VA = "0x1E826F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x1E82710", Offset = "0x1E82811", VA = "0x1E82710", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x1E82780", Offset = "0x1E82881", VA = "0x1E82780", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00004740 File Offset: 0x00002940
	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x1E82890", Offset = "0x1E82991", VA = "0x1E82890", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x1E829C0", Offset = "0x1E82AC1", VA = "0x1E829C0")]
	public ChangeCautionSerchCharacterParameter()
	{
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00004758 File Offset: 0x00002958
	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x1E829D0", Offset = "0x1E82AD1", VA = "0x1E829D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A8B0", Offset = "0x19A9B1")]
	private bool <OnStart>b__7_0(MonsterSearchRangePair arrayData)
	{
		return default(bool);
	}

	// Token: 0x040003ED RID: 1005
	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x50")]
	public SharedInt SearchType;

	// Token: 0x040003EE RID: 1006
	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x58")]
	public SharedBool IsCaution;

	// Token: 0x040003EF RID: 1007
	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x60")]
	private SearchCharacterController.SearchParameter BaseParameter;

	// Token: 0x040003F0 RID: 1008
	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x68")]
	private MonsterBehaviorController MonsterBehaviorController;
}
