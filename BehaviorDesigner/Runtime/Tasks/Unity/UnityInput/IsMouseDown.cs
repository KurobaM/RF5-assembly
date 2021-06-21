using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x02001442 RID: 5186
	[Token(Token = "0x2000E08")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153410", Offset = "0x153511")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153410", Offset = "0x153511")]
	public class IsMouseDown : Conditional
	{
		// Token: 0x0600776A RID: 30570 RVA: 0x00029838 File Offset: 0x00027A38
		[Token(Token = "0x600641E")]
		[Address(RVA = "0x28E6910", Offset = "0x28E6A11", VA = "0x28E6910", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641F")]
		[Address(RVA = "0x28E6980", Offset = "0x28E6A81", VA = "0x28E6980", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006420")]
		[Address(RVA = "0x28E69C0", Offset = "0x28E6AC1", VA = "0x28E69C0")]
		public IsMouseDown()
		{
		}

		// Token: 0x0401BA3B RID: 113211
		[Token(Token = "0x4018439")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F480", Offset = "0x18F581")]
		public SharedInt buttonIndex;
	}
}
