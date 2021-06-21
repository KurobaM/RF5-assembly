using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200141A RID: 5146
	[Token(Token = "0x2000DE0")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152510", Offset = "0x152611")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152510", Offset = "0x152611")]
	public class IsIntPositive : Conditional
	{
		// Token: 0x060076E1 RID: 30433 RVA: 0x00029478 File Offset: 0x00027678
		[Token(Token = "0x6006395")]
		[Address(RVA = "0x221E360", Offset = "0x221E461", VA = "0x221E360", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076E2 RID: 30434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006396")]
		[Address(RVA = "0x221E3D0", Offset = "0x221E4D1", VA = "0x221E3D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076E3 RID: 30435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006397")]
		[Address(RVA = "0x221E480", Offset = "0x221E581", VA = "0x221E480")]
		public IsIntPositive()
		{
		}

		// Token: 0x0401B9C5 RID: 113093
		[Token(Token = "0x40183C3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DEF0", Offset = "0x18DFF1")]
		public SharedInt intVariable;
	}
}
