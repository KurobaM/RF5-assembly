using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012E6 RID: 4838
	[Token(Token = "0x2000CB3")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B3C0", Offset = "0x14B4C1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B3C0", Offset = "0x14B4C1")]
	public class RandomSequence : Composite
	{
		// Token: 0x06007273 RID: 29299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F27")]
		[Address(RVA = "0x2218CE0", Offset = "0x2218DE1", VA = "0x2218CE0", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x06007274 RID: 29300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F28")]
		[Address(RVA = "0x2218DA0", Offset = "0x2218EA1", VA = "0x2218DA0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x00027630 File Offset: 0x00025830
		[Token(Token = "0x6005F29")]
		[Address(RVA = "0x2218EF0", Offset = "0x2218FF1", VA = "0x2218EF0", Slot = "32")]
		public override int CurrentChildIndex()
		{
			return 0;
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x00027648 File Offset: 0x00025848
		[Token(Token = "0x6005F2A")]
		[Address(RVA = "0x2218F50", Offset = "0x2219051", VA = "0x2218F50", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2B")]
		[Address(RVA = "0x2218FD0", Offset = "0x22190D1", VA = "0x2218FD0", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2C")]
		[Address(RVA = "0x2219050", Offset = "0x2219151", VA = "0x2219050", Slot = "42")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2D")]
		[Address(RVA = "0x22190C0", Offset = "0x22191C1", VA = "0x22190C0", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2E")]
		[Address(RVA = "0x2219120", Offset = "0x2219221", VA = "0x2219120", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2F")]
		[Address(RVA = "0x2218DB0", Offset = "0x2218EB1", VA = "0x2218DB0")]
		private void ShuffleChilden()
		{
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F30")]
		[Address(RVA = "0x2219130", Offset = "0x2219231", VA = "0x2219130")]
		public RandomSequence()
		{
		}

		// Token: 0x0401B5AE RID: 112046
		[Token(Token = "0x4017FD7")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183070", Offset = "0x183171")]
		public int seed;

		// Token: 0x0401B5AF RID: 112047
		[Token(Token = "0x4017FD8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1830B0", Offset = "0x1831B1")]
		public bool useSeed;

		// Token: 0x0401B5B0 RID: 112048
		[Token(Token = "0x4017FD9")]
		[FieldOffset(Offset = "0x68")]
		private List<int> childIndexList;

		// Token: 0x0401B5B1 RID: 112049
		[Token(Token = "0x4017FDA")]
		[FieldOffset(Offset = "0x70")]
		private Stack<int> childrenExecutionOrder;

		// Token: 0x0401B5B2 RID: 112050
		[Token(Token = "0x4017FDB")]
		[FieldOffset(Offset = "0x78")]
		private TaskStatus executionStatus;
	}
}
