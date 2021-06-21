using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200014E RID: 334
[Token(Token = "0x2000102")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1453C0", Offset = "0x1454C1")]
public class GetTargetHateController : Conditional
{
	// Token: 0x17000180 RID: 384
	// (get) Token: 0x0600071C RID: 1820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016C")]
	private HateController HateController
	{
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1FA86F0", Offset = "0x1FA87F1", VA = "0x1FA86F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x1FA8790", Offset = "0x1FA8891", VA = "0x1FA8790", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00004878 File Offset: 0x00002A78
	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x1FA8800", Offset = "0x1FA8901", VA = "0x1FA8800", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x1FA89E0", Offset = "0x1FA8AE1", VA = "0x1FA89E0")]
	public GetTargetHateController()
	{
	}

	// Token: 0x0400040D RID: 1037
	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x50")]
	public SharedGameObject Target;

	// Token: 0x0400040E RID: 1038
	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x58")]
	private AIInput AIInput;
}
