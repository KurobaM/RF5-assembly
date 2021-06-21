using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x0200143E RID: 5182
	[Token(Token = "0x2000E04")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153290", Offset = "0x153391")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153290", Offset = "0x153391")]
	public class IsButtonDown : Conditional
	{
		// Token: 0x0600775E RID: 30558 RVA: 0x000297D8 File Offset: 0x000279D8
		[Token(Token = "0x6006412")]
		[Address(RVA = "0x28E66B0", Offset = "0x28E67B1", VA = "0x28E66B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006413")]
		[Address(RVA = "0x28E6720", Offset = "0x28E6821", VA = "0x28E6720", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006414")]
		[Address(RVA = "0x28E6780", Offset = "0x28E6881", VA = "0x28E6780")]
		public IsButtonDown()
		{
		}

		// Token: 0x0401BA37 RID: 113207
		[Token(Token = "0x4018435")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F380", Offset = "0x18F481")]
		public SharedString buttonName;
	}
}
