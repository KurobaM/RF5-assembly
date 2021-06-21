using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012E7 RID: 4839
	[Token(Token = "0x2000CB4")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B420", Offset = "0x14B521")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B420", Offset = "0x14B521")]
	public class Selector : Composite
	{
		// Token: 0x0600727D RID: 29309 RVA: 0x00027660 File Offset: 0x00025860
		[Token(Token = "0x6005F31")]
		[Address(RVA = "0x2219830", Offset = "0x2219931", VA = "0x2219830", Slot = "32")]
		public override int CurrentChildIndex()
		{
			return 0;
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x00027678 File Offset: 0x00025878
		[Token(Token = "0x6005F32")]
		[Address(RVA = "0x2219840", Offset = "0x2219941", VA = "0x2219840", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x0600727F RID: 29311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F33")]
		[Address(RVA = "0x22198C0", Offset = "0x22199C1", VA = "0x22198C0", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x06007280 RID: 29312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F34")]
		[Address(RVA = "0x22198D0", Offset = "0x22199D1", VA = "0x22198D0", Slot = "42")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		// Token: 0x06007281 RID: 29313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F35")]
		[Address(RVA = "0x22198E0", Offset = "0x22199E1", VA = "0x22198E0", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007282 RID: 29314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F36")]
		[Address(RVA = "0x22198F0", Offset = "0x22199F1", VA = "0x22198F0")]
		public Selector()
		{
		}

		// Token: 0x0401B5B3 RID: 112051
		[Token(Token = "0x4017FDC")]
		[FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		// Token: 0x0401B5B4 RID: 112052
		[Token(Token = "0x4017FDD")]
		[FieldOffset(Offset = "0x60")]
		private TaskStatus executionStatus;
	}
}
