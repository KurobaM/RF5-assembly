using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014D9 RID: 5337
	[Token(Token = "0x2000E9C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156B90", Offset = "0x156C91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156B90", Offset = "0x156C91")]
	public class IsActiveSharedPartnerBehaviorController : Conditional
	{
		// Token: 0x060079B0 RID: 31152 RVA: 0x0002A678 File Offset: 0x00028878
		[Token(Token = "0x6006652")]
		[Address(RVA = "0x220F060", Offset = "0x220F161", VA = "0x220F060", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060079B1 RID: 31153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006653")]
		[Address(RVA = "0x220F100", Offset = "0x220F201", VA = "0x220F100", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006654")]
		[Address(RVA = "0x220F110", Offset = "0x220F211", VA = "0x220F110")]
		public IsActiveSharedPartnerBehaviorController()
		{
		}

		// Token: 0x0401BC6F RID: 113775
		[Token(Token = "0x4018661")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194840", Offset = "0x194941")]
		public SharedPartnerNPCBehaviorController variable;
	}
}
