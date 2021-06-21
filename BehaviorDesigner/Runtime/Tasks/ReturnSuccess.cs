using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012FC RID: 4860
	[Token(Token = "0x2000CC9")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BC40", Offset = "0x14BD41")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14BC40", Offset = "0x14BD41")]
	public class ReturnSuccess : Decorator
	{
		// Token: 0x060072FE RID: 29438 RVA: 0x00027A20 File Offset: 0x00025C20
		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0x22197D0", Offset = "0x22198D1", VA = "0x22197D0", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x060072FF RID: 29439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0x22197F0", Offset = "0x22198F1", VA = "0x22197F0", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x00027A38 File Offset: 0x00025C38
		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0x2219800", Offset = "0x2219901", VA = "0x2219800", Slot = "34")]
		public override TaskStatus Decorate(TaskStatus status)
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007301 RID: 29441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB5")]
		[Address(RVA = "0x2219810", Offset = "0x2219911", VA = "0x2219810", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007302 RID: 29442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0x2219820", Offset = "0x2219921", VA = "0x2219820")]
		public ReturnSuccess()
		{
		}

		// Token: 0x0401B5F7 RID: 112119
		[Token(Token = "0x4018020")]
		[FieldOffset(Offset = "0x58")]
		private TaskStatus executionStatus;
	}
}
