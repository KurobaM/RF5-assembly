using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012FA RID: 4858
	[Token(Token = "0x2000CC7")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BB80", Offset = "0x14BC81")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14BB80", Offset = "0x14BC81")]
	public class Repeater : Decorator
	{
		// Token: 0x060072F4 RID: 29428 RVA: 0x000279D8 File Offset: 0x00025BD8
		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0x22191E0", Offset = "0x22192E1", VA = "0x22191E0", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x060072F5 RID: 29429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0x22192E0", Offset = "0x22193E1", VA = "0x22192E0", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x060072F6 RID: 29430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0x22192F0", Offset = "0x22193F1", VA = "0x22192F0", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0x2219300", Offset = "0x2219401", VA = "0x2219300", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0x2219440", Offset = "0x2219541", VA = "0x2219440")]
		public Repeater()
		{
		}

		// Token: 0x0401B5F1 RID: 112113
		[Token(Token = "0x401801A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183970", Offset = "0x183A71")]
		public SharedInt count;

		// Token: 0x0401B5F2 RID: 112114
		[Token(Token = "0x401801B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1839B0", Offset = "0x183AB1")]
		public SharedBool repeatForever;

		// Token: 0x0401B5F3 RID: 112115
		[Token(Token = "0x401801C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1839F0", Offset = "0x183AF1")]
		public SharedBool endOnFailure;

		// Token: 0x0401B5F4 RID: 112116
		[Token(Token = "0x401801D")]
		[FieldOffset(Offset = "0x70")]
		private int executionCount;

		// Token: 0x0401B5F5 RID: 112117
		[Token(Token = "0x401801E")]
		[FieldOffset(Offset = "0x74")]
		private TaskStatus executionStatus;
	}
}
