using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012EA RID: 4842
	[Token(Token = "0x2000CB7")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B540", Offset = "0x14B641")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B540", Offset = "0x14B641")]
	public class UtilitySelector : Composite
	{
		// Token: 0x06007295 RID: 29333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F49")]
		[Address(RVA = "0x244BA50", Offset = "0x244BB51", VA = "0x244BA50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007296 RID: 29334 RVA: 0x00027750 File Offset: 0x00025950
		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0x244BB40", Offset = "0x244BC41", VA = "0x244BB40", Slot = "32")]
		public override int CurrentChildIndex()
		{
			return 0;
		}

		// Token: 0x06007297 RID: 29335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4B")]
		[Address(RVA = "0x244BB50", Offset = "0x244BC51", VA = "0x244BB50", Slot = "39")]
		public override void OnChildStarted(int childIndex)
		{
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x00027768 File Offset: 0x00025968
		[Token(Token = "0x6005F4C")]
		[Address(RVA = "0x244BB60", Offset = "0x244BC61", VA = "0x244BB60", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4D")]
		[Address(RVA = "0x244BBF0", Offset = "0x244BCF1", VA = "0x244BBF0", Slot = "37")]
		public override void OnChildExecuted(int childIndex, TaskStatus childStatus)
		{
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4E")]
		[Address(RVA = "0x244BD40", Offset = "0x244BE41", VA = "0x244BD40", Slot = "42")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4F")]
		[Address(RVA = "0x244BD50", Offset = "0x244BE51", VA = "0x244BD50", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x00027780 File Offset: 0x00025980
		[Token(Token = "0x6005F50")]
		[Address(RVA = "0x244BD60", Offset = "0x244BE61", VA = "0x244BD60", Slot = "40")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x00027798 File Offset: 0x00025998
		[Token(Token = "0x6005F51")]
		[Address(RVA = "0x244BD70", Offset = "0x244BE71", VA = "0x244BD70", Slot = "31")]
		public override bool CanRunParallelChildren()
		{
			return default(bool);
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x000277B0 File Offset: 0x000259B0
		[Token(Token = "0x6005F52")]
		[Address(RVA = "0x244BD80", Offset = "0x244BE81", VA = "0x244BD80", Slot = "35")]
		public override bool CanReevaluate()
		{
			return default(bool);
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x000277C8 File Offset: 0x000259C8
		[Token(Token = "0x6005F53")]
		[Address(RVA = "0x244BD90", Offset = "0x244BE91", VA = "0x244BD90", Slot = "43")]
		public override bool OnReevaluationStarted()
		{
			return default(bool);
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F54")]
		[Address(RVA = "0x244BDB0", Offset = "0x244BEB1", VA = "0x244BDB0", Slot = "44")]
		public override void OnReevaluationEnded(TaskStatus status)
		{
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F55")]
		[Address(RVA = "0x244BF50", Offset = "0x244C051", VA = "0x244BF50")]
		public UtilitySelector()
		{
		}

		// Token: 0x0401B5BB RID: 112059
		[Token(Token = "0x4017FE4")]
		[FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		// Token: 0x0401B5BC RID: 112060
		[Token(Token = "0x4017FE5")]
		[FieldOffset(Offset = "0x60")]
		private float highestUtility;

		// Token: 0x0401B5BD RID: 112061
		[Token(Token = "0x4017FE6")]
		[FieldOffset(Offset = "0x64")]
		private TaskStatus executionStatus;

		// Token: 0x0401B5BE RID: 112062
		[Token(Token = "0x4017FE7")]
		[FieldOffset(Offset = "0x68")]
		private bool reevaluating;

		// Token: 0x0401B5BF RID: 112063
		[Token(Token = "0x4017FE8")]
		[FieldOffset(Offset = "0x70")]
		private List<int> availableChildren;
	}
}
