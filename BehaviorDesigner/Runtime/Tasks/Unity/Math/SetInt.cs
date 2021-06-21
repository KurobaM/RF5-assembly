using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x02001422 RID: 5154
	[Token(Token = "0x2000DE8")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152810", Offset = "0x152911")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152810", Offset = "0x152911")]
	public class SetInt : Action
	{
		// Token: 0x060076F8 RID: 30456 RVA: 0x00029538 File Offset: 0x00027738
		[Token(Token = "0x60063AC")]
		[Address(RVA = "0x221F2D0", Offset = "0x221F3D1", VA = "0x221F2D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AD")]
		[Address(RVA = "0x221F350", Offset = "0x221F451", VA = "0x221F350", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AE")]
		[Address(RVA = "0x221F480", Offset = "0x221F581", VA = "0x221F480")]
		public SetInt()
		{
		}

		// Token: 0x0401B9DB RID: 113115
		[Token(Token = "0x40183D9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E490", Offset = "0x18E591")]
		public SharedInt intValue;

		// Token: 0x0401B9DC RID: 113116
		[Token(Token = "0x40183DA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E4D0", Offset = "0x18E5D1")]
		public SharedInt storeResult;
	}
}
