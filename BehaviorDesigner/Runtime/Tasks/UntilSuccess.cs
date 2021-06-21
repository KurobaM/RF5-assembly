using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012FF RID: 4863
	[Token(Token = "0x2000CCC")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BD60", Offset = "0x14BE61")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14BD60", Offset = "0x14BE61")]
	public class UntilSuccess : Decorator
	{
		// Token: 0x0600730E RID: 29454 RVA: 0x00027A98 File Offset: 0x00025C98
		[Token(Token = "0x6005FC2")]
		[Address(RVA = "0x244B550", Offset = "0x244B651", VA = "0x244B550", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x0600730F RID: 29455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC3")]
		[Address(RVA = "0x244B560", Offset = "0x244B661", VA = "0x244B560", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC4")]
		[Address(RVA = "0x244B570", Offset = "0x244B671", VA = "0x244B570", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC5")]
		[Address(RVA = "0x244B580", Offset = "0x244B681", VA = "0x244B580")]
		public UntilSuccess()
		{
		}

		// Token: 0x0401B5FE RID: 112126
		[Token(Token = "0x4018027")]
		[FieldOffset(Offset = "0x58")]
		private TaskStatus executionStatus;
	}
}
