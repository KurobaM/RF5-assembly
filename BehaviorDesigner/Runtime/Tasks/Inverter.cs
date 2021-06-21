using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012F9 RID: 4857
	[Token(Token = "0x2000CC6")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BB20", Offset = "0x14BC21")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14BB20", Offset = "0x14BC21")]
	public class Inverter : Decorator
	{
		// Token: 0x060072EF RID: 29423 RVA: 0x000279A8 File Offset: 0x00025BA8
		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0x2213D20", Offset = "0x2213E21", VA = "0x2213D20", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0x2213D40", Offset = "0x2213E41", VA = "0x2213D40", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x060072F1 RID: 29425 RVA: 0x000279C0 File Offset: 0x00025BC0
		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0x2213D50", Offset = "0x2213E51", VA = "0x2213D50", Slot = "34")]
		public override TaskStatus Decorate(TaskStatus status)
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072F2 RID: 29426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0x2213D70", Offset = "0x2213E71", VA = "0x2213D70", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0x2213D80", Offset = "0x2213E81", VA = "0x2213D80")]
		public Inverter()
		{
		}

		// Token: 0x0401B5F0 RID: 112112
		[Token(Token = "0x4018019")]
		[FieldOffset(Offset = "0x58")]
		private TaskStatus executionStatus;
	}
}
