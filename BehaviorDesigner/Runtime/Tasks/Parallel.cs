using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012E1 RID: 4833
	[Token(Token = "0x2000CAE")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B1E0", Offset = "0x14B2E1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B1E0", Offset = "0x14B2E1")]
	public class Parallel : Composite
	{
		// Token: 0x06007244 RID: 29252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF8")]
		[Address(RVA = "0x2216DF0", Offset = "0x2216EF1", VA = "0x2216DF0", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF9")]
		[Address(RVA = "0x2216E60", Offset = "0x2216F61", VA = "0x2216E60", Slot = "39")]
		public override void OnChildStarted(int childIndex)
		{
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x000274B0 File Offset: 0x000256B0
		[Token(Token = "0x6005EFA")]
		[Address(RVA = "0x2216EB0", Offset = "0x2216FB1", VA = "0x2216EB0", Slot = "31")]
		public override bool CanRunParallelChildren()
		{
			return default(bool);
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x000274C8 File Offset: 0x000256C8
		[Token(Token = "0x6005EFB")]
		[Address(RVA = "0x2216EC0", Offset = "0x2216FC1", VA = "0x2216EC0", Slot = "32")]
		public override int CurrentChildIndex()
		{
			return 0;
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x000274E0 File Offset: 0x000256E0
		[Token(Token = "0x6005EFC")]
		[Address(RVA = "0x2216ED0", Offset = "0x2216FD1", VA = "0x2216ED0", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFD")]
		[Address(RVA = "0x2216F30", Offset = "0x2217031", VA = "0x2216F30", Slot = "37")]
		public override void OnChildExecuted(int childIndex, TaskStatus childStatus)
		{
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x000274F8 File Offset: 0x000256F8
		[Token(Token = "0x6005EFE")]
		[Address(RVA = "0x2216F70", Offset = "0x2217071", VA = "0x2216F70", Slot = "40")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFF")]
		[Address(RVA = "0x2217010", Offset = "0x2217111", VA = "0x2217010", Slot = "42")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F00")]
		[Address(RVA = "0x2217070", Offset = "0x2217171", VA = "0x2217070", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F01")]
		[Address(RVA = "0x22170D0", Offset = "0x22171D1", VA = "0x22170D0")]
		public Parallel()
		{
		}

		// Token: 0x0401B5A0 RID: 112032
		[Token(Token = "0x4017FC9")]
		[FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		// Token: 0x0401B5A1 RID: 112033
		[Token(Token = "0x4017FCA")]
		[FieldOffset(Offset = "0x60")]
		private TaskStatus[] executionStatus;
	}
}
