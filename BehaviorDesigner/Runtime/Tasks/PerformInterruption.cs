using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012D6 RID: 4822
	[Token(Token = "0x2000CA3")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14ACA0", Offset = "0x14ADA1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14ACA0", Offset = "0x14ADA1")]
	public class PerformInterruption : Action
	{
		// Token: 0x0600721B RID: 29211 RVA: 0x000273A8 File Offset: 0x000255A8
		[Token(Token = "0x6005ECF")]
		[Address(RVA = "0x2217EF0", Offset = "0x2217FF1", VA = "0x2217EF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED0")]
		[Address(RVA = "0x2218030", Offset = "0x2218131", VA = "0x2218030", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED1")]
		[Address(RVA = "0x22180F0", Offset = "0x22181F1", VA = "0x22180F0")]
		public PerformInterruption()
		{
		}

		// Token: 0x0401B56B RID: 111979
		[Token(Token = "0x4017F94")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182460", Offset = "0x182561")]
		public Interrupt[] interruptTasks;

		// Token: 0x0401B56C RID: 111980
		[Token(Token = "0x4017F95")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1824A0", Offset = "0x1825A1")]
		public SharedBool interruptSuccess;
	}
}
