using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012E4 RID: 4836
	[Token(Token = "0x2000CB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B300", Offset = "0x14B401")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B300", Offset = "0x14B401")]
	public class PrioritySelector : Composite
	{
		// Token: 0x06007262 RID: 29282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F16")]
		[Address(RVA = "0x2218100", Offset = "0x2218201", VA = "0x2218100", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007263 RID: 29283 RVA: 0x000275D0 File Offset: 0x000257D0
		[Token(Token = "0x6005F17")]
		[Address(RVA = "0x2218290", Offset = "0x2218391", VA = "0x2218290", Slot = "32")]
		public override int CurrentChildIndex()
		{
			return 0;
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x000275E8 File Offset: 0x000257E8
		[Token(Token = "0x6005F18")]
		[Address(RVA = "0x2218300", Offset = "0x2218401", VA = "0x2218300", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F19")]
		[Address(RVA = "0x2218380", Offset = "0x2218481", VA = "0x2218380", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1A")]
		[Address(RVA = "0x2218390", Offset = "0x2218491", VA = "0x2218390", Slot = "42")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		// Token: 0x06007267 RID: 29287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1B")]
		[Address(RVA = "0x22183A0", Offset = "0x22184A1", VA = "0x22183A0", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007268 RID: 29288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1C")]
		[Address(RVA = "0x22183B0", Offset = "0x22184B1", VA = "0x22183B0")]
		public PrioritySelector()
		{
		}

		// Token: 0x0401B5A6 RID: 112038
		[Token(Token = "0x4017FCF")]
		[FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		// Token: 0x0401B5A7 RID: 112039
		[Token(Token = "0x4017FD0")]
		[FieldOffset(Offset = "0x60")]
		private TaskStatus executionStatus;

		// Token: 0x0401B5A8 RID: 112040
		[Token(Token = "0x4017FD1")]
		[FieldOffset(Offset = "0x68")]
		private List<int> childrenExecutionOrder;
	}
}
