using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012E8 RID: 4840
	[Token(Token = "0x2000CB5")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B480", Offset = "0x14B581")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B480", Offset = "0x14B581")]
	public class SelectorEvaluator : Composite
	{
		// Token: 0x06007283 RID: 29315 RVA: 0x00027690 File Offset: 0x00025890
		[Token(Token = "0x6005F37")]
		[Address(RVA = "0x2219900", Offset = "0x2219A01", VA = "0x2219900", Slot = "32")]
		public override int CurrentChildIndex()
		{
			return 0;
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F38")]
		[Address(RVA = "0x2219910", Offset = "0x2219A11", VA = "0x2219910", Slot = "39")]
		public override void OnChildStarted(int childIndex)
		{
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x000276A8 File Offset: 0x000258A8
		[Token(Token = "0x6005F39")]
		[Address(RVA = "0x2219930", Offset = "0x2219A31", VA = "0x2219930", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3A")]
		[Address(RVA = "0x22199C0", Offset = "0x2219AC1", VA = "0x22199C0", Slot = "37")]
		public override void OnChildExecuted(int childIndex, TaskStatus childStatus)
		{
		}

		// Token: 0x06007287 RID: 29319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3B")]
		[Address(RVA = "0x2219A70", Offset = "0x2219B71", VA = "0x2219A70", Slot = "42")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		// Token: 0x06007288 RID: 29320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3C")]
		[Address(RVA = "0x2219A80", Offset = "0x2219B81", VA = "0x2219A80", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007289 RID: 29321 RVA: 0x000276C0 File Offset: 0x000258C0
		[Token(Token = "0x6005F3D")]
		[Address(RVA = "0x2219A90", Offset = "0x2219B91", VA = "0x2219A90", Slot = "40")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600728A RID: 29322 RVA: 0x000276D8 File Offset: 0x000258D8
		[Token(Token = "0x6005F3E")]
		[Address(RVA = "0x2219AA0", Offset = "0x2219BA1", VA = "0x2219AA0", Slot = "31")]
		public override bool CanRunParallelChildren()
		{
			return default(bool);
		}

		// Token: 0x0600728B RID: 29323 RVA: 0x000276F0 File Offset: 0x000258F0
		[Token(Token = "0x6005F3F")]
		[Address(RVA = "0x2219AB0", Offset = "0x2219BB1", VA = "0x2219AB0", Slot = "35")]
		public override bool CanReevaluate()
		{
			return default(bool);
		}

		// Token: 0x0600728C RID: 29324 RVA: 0x00027708 File Offset: 0x00025908
		[Token(Token = "0x6005F40")]
		[Address(RVA = "0x2219AC0", Offset = "0x2219BC1", VA = "0x2219AC0", Slot = "43")]
		public override bool OnReevaluationStarted()
		{
			return default(bool);
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F41")]
		[Address(RVA = "0x2219AF0", Offset = "0x2219BF1", VA = "0x2219AF0", Slot = "44")]
		public override void OnReevaluationEnded(TaskStatus status)
		{
		}

		// Token: 0x0600728E RID: 29326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F42")]
		[Address(RVA = "0x2219BE0", Offset = "0x2219CE1", VA = "0x2219BE0")]
		public SelectorEvaluator()
		{
		}

		// Token: 0x0401B5B5 RID: 112053
		[Token(Token = "0x4017FDE")]
		[FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		// Token: 0x0401B5B6 RID: 112054
		[Token(Token = "0x4017FDF")]
		[FieldOffset(Offset = "0x60")]
		private TaskStatus executionStatus;

		// Token: 0x0401B5B7 RID: 112055
		[Token(Token = "0x4017FE0")]
		[FieldOffset(Offset = "0x64")]
		private int storedCurrentChildIndex;

		// Token: 0x0401B5B8 RID: 112056
		[Token(Token = "0x4017FE1")]
		[FieldOffset(Offset = "0x68")]
		private TaskStatus storedExecutionStatus;
	}
}
