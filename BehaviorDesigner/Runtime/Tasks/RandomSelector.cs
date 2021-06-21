using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012E5 RID: 4837
	[Token(Token = "0x2000CB2")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B360", Offset = "0x14B461")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B360", Offset = "0x14B461")]
	public class RandomSelector : Composite
	{
		// Token: 0x06007269 RID: 29289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1D")]
		[Address(RVA = "0x22187E0", Offset = "0x22188E1", VA = "0x22187E0", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x0600726A RID: 29290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1E")]
		[Address(RVA = "0x22188A0", Offset = "0x22189A1", VA = "0x22188A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600726B RID: 29291 RVA: 0x00027600 File Offset: 0x00025800
		[Token(Token = "0x6005F1F")]
		[Address(RVA = "0x22189F0", Offset = "0x2218AF1", VA = "0x22189F0", Slot = "32")]
		public override int CurrentChildIndex()
		{
			return 0;
		}

		// Token: 0x0600726C RID: 29292 RVA: 0x00027618 File Offset: 0x00025818
		[Token(Token = "0x6005F20")]
		[Address(RVA = "0x2218A50", Offset = "0x2218B51", VA = "0x2218A50", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x0600726D RID: 29293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F21")]
		[Address(RVA = "0x2218AD0", Offset = "0x2218BD1", VA = "0x2218AD0", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x0600726E RID: 29294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F22")]
		[Address(RVA = "0x2218B50", Offset = "0x2218C51", VA = "0x2218B50", Slot = "42")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F23")]
		[Address(RVA = "0x2218BC0", Offset = "0x2218CC1", VA = "0x2218BC0", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F24")]
		[Address(RVA = "0x2218C20", Offset = "0x2218D21", VA = "0x2218C20", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007271 RID: 29297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F25")]
		[Address(RVA = "0x22188B0", Offset = "0x22189B1", VA = "0x22188B0")]
		private void ShuffleChilden()
		{
		}

		// Token: 0x06007272 RID: 29298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F26")]
		[Address(RVA = "0x2218C30", Offset = "0x2218D31", VA = "0x2218C30")]
		public RandomSelector()
		{
		}

		// Token: 0x0401B5A9 RID: 112041
		[Token(Token = "0x4017FD2")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182FF0", Offset = "0x1830F1")]
		public int seed;

		// Token: 0x0401B5AA RID: 112042
		[Token(Token = "0x4017FD3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183030", Offset = "0x183131")]
		public bool useSeed;

		// Token: 0x0401B5AB RID: 112043
		[Token(Token = "0x4017FD4")]
		[FieldOffset(Offset = "0x68")]
		private List<int> childIndexList;

		// Token: 0x0401B5AC RID: 112044
		[Token(Token = "0x4017FD5")]
		[FieldOffset(Offset = "0x70")]
		private Stack<int> childrenExecutionOrder;

		// Token: 0x0401B5AD RID: 112045
		[Token(Token = "0x4017FD6")]
		[FieldOffset(Offset = "0x78")]
		private TaskStatus executionStatus;
	}
}
