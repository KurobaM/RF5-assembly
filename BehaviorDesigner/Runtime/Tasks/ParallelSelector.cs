using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012E3 RID: 4835
	[Token(Token = "0x2000CB0")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B2A0", Offset = "0x14B3A1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B2A0", Offset = "0x14B3A1")]
	public class ParallelSelector : Composite
	{
		// Token: 0x06007258 RID: 29272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0C")]
		[Address(RVA = "0x22173B0", Offset = "0x22174B1", VA = "0x22173B0", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x06007259 RID: 29273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0D")]
		[Address(RVA = "0x2217420", Offset = "0x2217521", VA = "0x2217420", Slot = "39")]
		public override void OnChildStarted(int childIndex)
		{
		}

		// Token: 0x0600725A RID: 29274 RVA: 0x00027570 File Offset: 0x00025770
		[Token(Token = "0x6005F0E")]
		[Address(RVA = "0x2217470", Offset = "0x2217571", VA = "0x2217470", Slot = "31")]
		public override bool CanRunParallelChildren()
		{
			return default(bool);
		}

		// Token: 0x0600725B RID: 29275 RVA: 0x00027588 File Offset: 0x00025788
		[Token(Token = "0x6005F0F")]
		[Address(RVA = "0x2217480", Offset = "0x2217581", VA = "0x2217480", Slot = "32")]
		public override int CurrentChildIndex()
		{
			return 0;
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x000275A0 File Offset: 0x000257A0
		[Token(Token = "0x6005F10")]
		[Address(RVA = "0x2217490", Offset = "0x2217591", VA = "0x2217490", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F11")]
		[Address(RVA = "0x22174F0", Offset = "0x22175F1", VA = "0x22174F0", Slot = "37")]
		public override void OnChildExecuted(int childIndex, TaskStatus childStatus)
		{
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F12")]
		[Address(RVA = "0x2217530", Offset = "0x2217631", VA = "0x2217530", Slot = "42")]
		public override void OnConditionalAbort(int childIndex)
		{
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x000275B8 File Offset: 0x000257B8
		[Token(Token = "0x6005F13")]
		[Address(RVA = "0x2217590", Offset = "0x2217691", VA = "0x2217590", Slot = "40")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007260 RID: 29280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F14")]
		[Address(RVA = "0x2217630", Offset = "0x2217731", VA = "0x2217630", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F15")]
		[Address(RVA = "0x2217690", Offset = "0x2217791", VA = "0x2217690")]
		public ParallelSelector()
		{
		}

		// Token: 0x0401B5A4 RID: 112036
		[Token(Token = "0x4017FCD")]
		[FieldOffset(Offset = "0x5C")]
		private int currentChildIndex;

		// Token: 0x0401B5A5 RID: 112037
		[Token(Token = "0x4017FCE")]
		[FieldOffset(Offset = "0x60")]
		private TaskStatus[] executionStatus;
	}
}
