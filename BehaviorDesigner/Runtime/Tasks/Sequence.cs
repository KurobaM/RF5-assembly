using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012E9 RID: 4841
	[Token(Token = "0x2000CB6")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B4E0", Offset = "0x14B5E1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B4E0", Offset = "0x14B5E1")]
	public class Sequence : Composite
	{
		// Token: 0x0600728F RID: 29327 RVA: 0x00027720 File Offset: 0x00025920
		[Token(Token = "0x6005F43")]
		[Address(RVA = "0x221A0C0", Offset = "0x221A1C1", VA = "0x221A0C0", Slot = "32")]
		public override int CurrentChildIndex()
		{
			return 0;
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x00027738 File Offset: 0x00025938
		[Token(Token = "0x6005F44")]
		[Address(RVA = "0x221A0D0", Offset = "0x221A1D1", VA = "0x221A0D0", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F45")]
		[Address(RVA = "0x221A150", Offset = "0x221A251", VA = "0x221A150", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F46")]
		[Address(RVA = "0x221A160", Offset = "0x221A261", VA = "0x221A160", Slot = "42")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		// Token: 0x06007293 RID: 29331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F47")]
		[Address(RVA = "0x221A170", Offset = "0x221A271", VA = "0x221A170", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007294 RID: 29332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F48")]
		[Address(RVA = "0x221A180", Offset = "0x221A281", VA = "0x221A180")]
		public Sequence()
		{
		}

		// Token: 0x0401B5B9 RID: 112057
		[Token(Token = "0x4017FE2")]
		[FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		// Token: 0x0401B5BA RID: 112058
		[Token(Token = "0x4017FE3")]
		[FieldOffset(Offset = "0x60")]
		private TaskStatus executionStatus;
	}
}
