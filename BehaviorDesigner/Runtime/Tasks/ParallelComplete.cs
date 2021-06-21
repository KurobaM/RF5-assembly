using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012E2 RID: 4834
	[Token(Token = "0x2000CAF")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B240", Offset = "0x14B341")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B240", Offset = "0x14B341")]
	public class ParallelComplete : Composite
	{
		// Token: 0x0600724E RID: 29262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F02")]
		[Address(RVA = "0x22170E0", Offset = "0x22171E1", VA = "0x22170E0", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F03")]
		[Address(RVA = "0x2217150", Offset = "0x2217251", VA = "0x2217150", Slot = "39")]
		public override void OnChildStarted(int childIndex)
		{
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x00027510 File Offset: 0x00025710
		[Token(Token = "0x6005F04")]
		[Address(RVA = "0x22171A0", Offset = "0x22172A1", VA = "0x22171A0", Slot = "31")]
		public override bool CanRunParallelChildren()
		{
			return default(bool);
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x00027528 File Offset: 0x00025728
		[Token(Token = "0x6005F05")]
		[Address(RVA = "0x22171B0", Offset = "0x22172B1", VA = "0x22171B0", Slot = "32")]
		public override int CurrentChildIndex()
		{
			return 0;
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x00027540 File Offset: 0x00025740
		[Token(Token = "0x6005F06")]
		[Address(RVA = "0x22171C0", Offset = "0x22172C1", VA = "0x22171C0", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F07")]
		[Address(RVA = "0x2217220", Offset = "0x2217321", VA = "0x2217220", Slot = "37")]
		public override void OnChildExecuted(int childIndex, TaskStatus childStatus)
		{
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F08")]
		[Address(RVA = "0x2217260", Offset = "0x2217361", VA = "0x2217260", Slot = "42")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x00027558 File Offset: 0x00025758
		[Token(Token = "0x6005F09")]
		[Address(RVA = "0x22172C0", Offset = "0x22173C1", VA = "0x22172C0", Slot = "40")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007256 RID: 29270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0A")]
		[Address(RVA = "0x2217340", Offset = "0x2217441", VA = "0x2217340", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007257 RID: 29271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0B")]
		[Address(RVA = "0x22173A0", Offset = "0x22174A1", VA = "0x22173A0")]
		public ParallelComplete()
		{
		}

		// Token: 0x0401B5A2 RID: 112034
		[Token(Token = "0x4017FCB")]
		[FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		// Token: 0x0401B5A3 RID: 112035
		[Token(Token = "0x4017FCC")]
		[FieldOffset(Offset = "0x60")]
		private TaskStatus[] executionStatus;
	}
}
