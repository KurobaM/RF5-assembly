using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012F8 RID: 4856
	[Token(Token = "0x2000CC5")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BAC0", Offset = "0x14BBC1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14BAC0", Offset = "0x14BBC1")]
	public class Interrupt : Decorator
	{
		// Token: 0x060072E9 RID: 29417 RVA: 0x00027978 File Offset: 0x00025B78
		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0x2213C20", Offset = "0x2213D21", VA = "0x2213C20", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x060072EA RID: 29418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0x2213C40", Offset = "0x2213D41", VA = "0x2213C40", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0x2213C50", Offset = "0x2213D51", VA = "0x2213C50")]
		public void DoInterrupt(TaskStatus status)
		{
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x00027990 File Offset: 0x00025B90
		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0x2213CF0", Offset = "0x2213DF1", VA = "0x2213CF0", Slot = "41")]
		public override TaskStatus OverrideStatus()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072ED RID: 29421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0x2213D00", Offset = "0x2213E01", VA = "0x2213D00", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0x2213D10", Offset = "0x2213E11", VA = "0x2213D10")]
		public Interrupt()
		{
		}

		// Token: 0x0401B5EE RID: 112110
		[Token(Token = "0x4018017")]
		[FieldOffset(Offset = "0x58")]
		private TaskStatus interruptStatus;

		// Token: 0x0401B5EF RID: 112111
		[Token(Token = "0x4018018")]
		[FieldOffset(Offset = "0x5C")]
		private TaskStatus executionStatus;
	}
}
