using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200014F RID: 335
[Token(Token = "0x2000103")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145400", Offset = "0x145501")]
public class ResetHateController : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000720 RID: 1824 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016D")]
	private HateController HateController
	{
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x248AD30", Offset = "0x248AE31", VA = "0x248AD30")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000600")]
	[Address(RVA = "0x248ADD0", Offset = "0x248AED1", VA = "0x248ADD0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00004890 File Offset: 0x00002A90
	[Token(Token = "0x6000601")]
	[Address(RVA = "0x248AE40", Offset = "0x248AF41", VA = "0x248AE40", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000602")]
	[Address(RVA = "0x248AEE0", Offset = "0x248AFE1", VA = "0x248AEE0")]
	public ResetHateController()
	{
	}

	// Token: 0x0400040F RID: 1039
	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x50")]
	private AIInput AIInput;
}
