using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012FB RID: 4859
	[Token(Token = "0x2000CC8")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BBE0", Offset = "0x14BCE1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14BBE0", Offset = "0x14BCE1")]
	public class ReturnFailure : Decorator
	{
		// Token: 0x060072F9 RID: 29433 RVA: 0x000279F0 File Offset: 0x00025BF0
		[Token(Token = "0x6005FAD")]
		[Address(RVA = "0x2219770", Offset = "0x2219871", VA = "0x2219770", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x060072FA RID: 29434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0x2219790", Offset = "0x2219891", VA = "0x2219790", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x00027A08 File Offset: 0x00025C08
		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0x22197A0", Offset = "0x22198A1", VA = "0x22197A0", Slot = "34")]
		public override TaskStatus Decorate(TaskStatus status)
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0x22197B0", Offset = "0x22198B1", VA = "0x22197B0", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0x22197C0", Offset = "0x22198C1", VA = "0x22197C0")]
		public ReturnFailure()
		{
		}

		// Token: 0x0401B5F6 RID: 112118
		[Token(Token = "0x401801F")]
		[FieldOffset(Offset = "0x58")]
		private TaskStatus executionStatus;
	}
}
