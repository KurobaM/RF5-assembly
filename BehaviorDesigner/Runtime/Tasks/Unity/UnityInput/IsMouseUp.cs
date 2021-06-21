using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x02001443 RID: 5187
	[Token(Token = "0x2000E09")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153470", Offset = "0x153571")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153470", Offset = "0x153571")]
	public class IsMouseUp : Conditional
	{
		// Token: 0x0600776D RID: 30573 RVA: 0x00029850 File Offset: 0x00027A50
		[Token(Token = "0x6006421")]
		[Address(RVA = "0x28E69D0", Offset = "0x28E6AD1", VA = "0x28E69D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006422")]
		[Address(RVA = "0x28E6A40", Offset = "0x28E6B41", VA = "0x28E6A40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006423")]
		[Address(RVA = "0x28E6A80", Offset = "0x28E6B81", VA = "0x28E6A80")]
		public IsMouseUp()
		{
		}

		// Token: 0x0401BA3C RID: 113212
		[Token(Token = "0x401843A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F4C0", Offset = "0x18F5C1")]
		public SharedInt buttonIndex;
	}
}
