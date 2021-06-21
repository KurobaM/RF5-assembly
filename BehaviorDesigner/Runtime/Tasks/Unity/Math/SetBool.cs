using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x02001420 RID: 5152
	[Token(Token = "0x2000DE6")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152750", Offset = "0x152851")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152750", Offset = "0x152851")]
	public class SetBool : Action
	{
		// Token: 0x060076F2 RID: 30450 RVA: 0x00029508 File Offset: 0x00027708
		[Token(Token = "0x60063A6")]
		[Address(RVA = "0x221EFB0", Offset = "0x221F0B1", VA = "0x221EFB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A7")]
		[Address(RVA = "0x221F030", Offset = "0x221F131", VA = "0x221F030", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A8")]
		[Address(RVA = "0x221F0E0", Offset = "0x221F1E1", VA = "0x221F0E0")]
		public SetBool()
		{
		}

		// Token: 0x0401B9D7 RID: 113111
		[Token(Token = "0x40183D5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E390", Offset = "0x18E491")]
		public SharedBool boolValue;

		// Token: 0x0401B9D8 RID: 113112
		[Token(Token = "0x40183D6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E3D0", Offset = "0x18E4D1")]
		public SharedBool storeResult;
	}
}
