using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x0200143F RID: 5183
	[Token(Token = "0x2000E05")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1532F0", Offset = "0x1533F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1532F0", Offset = "0x1533F1")]
	public class IsButtonUp : Conditional
	{
		// Token: 0x06007761 RID: 30561 RVA: 0x000297F0 File Offset: 0x000279F0
		[Token(Token = "0x6006415")]
		[Address(RVA = "0x28E6790", Offset = "0x28E6891", VA = "0x28E6790", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006416")]
		[Address(RVA = "0x28E6800", Offset = "0x28E6901", VA = "0x28E6800", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006417")]
		[Address(RVA = "0x28E6860", Offset = "0x28E6961", VA = "0x28E6860")]
		public IsButtonUp()
		{
		}

		// Token: 0x0401BA38 RID: 113208
		[Token(Token = "0x4018436")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F3C0", Offset = "0x18F4C1")]
		public SharedString buttonName;
	}
}
