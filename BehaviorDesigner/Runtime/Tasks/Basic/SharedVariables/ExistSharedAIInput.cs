using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	// Token: 0x020014D0 RID: 5328
	[Token(Token = "0x2000E93")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156830", Offset = "0x156931")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156830", Offset = "0x156931")]
	public class ExistSharedAIInput : Conditional
	{
		// Token: 0x06007995 RID: 31125 RVA: 0x0002A5A0 File Offset: 0x000287A0
		[Token(Token = "0x6006637")]
		[Address(RVA = "0x220ECE0", Offset = "0x220EDE1", VA = "0x220ECE0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006638")]
		[Address(RVA = "0x220ED80", Offset = "0x220EE81", VA = "0x220ED80", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007997 RID: 31127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006639")]
		[Address(RVA = "0x220ED90", Offset = "0x220EE91", VA = "0x220ED90")]
		public ExistSharedAIInput()
		{
		}

		// Token: 0x0401BC60 RID: 113760
		[Token(Token = "0x4018652")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194460", Offset = "0x194561")]
		public SharedAIInput variable;
	}
}
