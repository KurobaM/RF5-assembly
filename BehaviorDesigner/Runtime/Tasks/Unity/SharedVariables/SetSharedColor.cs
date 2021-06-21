using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200136E RID: 4974
	[Token(Token = "0x2000D39")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E620", Offset = "0x14E721")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E620", Offset = "0x14E721")]
	public class SetSharedColor : Action
	{
		// Token: 0x0600747F RID: 29823 RVA: 0x000284D0 File Offset: 0x000266D0
		[Token(Token = "0x6006133")]
		[Address(RVA = "0x2221860", Offset = "0x2221961", VA = "0x2221860", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006134")]
		[Address(RVA = "0x22218E0", Offset = "0x22219E1", VA = "0x22218E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007481 RID: 29825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006135")]
		[Address(RVA = "0x2221A50", Offset = "0x2221B51", VA = "0x2221A50")]
		public SetSharedColor()
		{
		}

		// Token: 0x0401B753 RID: 112467
		[Token(Token = "0x4018174")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187C60", Offset = "0x187D61")]
		public SharedColor targetValue;

		// Token: 0x0401B754 RID: 112468
		[Token(Token = "0x4018175")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x187CA0", Offset = "0x187DA1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187CA0", Offset = "0x187DA1")]
		public SharedColor targetVariable;
	}
}
