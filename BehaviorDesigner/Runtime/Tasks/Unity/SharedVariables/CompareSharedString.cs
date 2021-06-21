using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001367 RID: 4967
	[Token(Token = "0x2000D32")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E380", Offset = "0x14E481")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E380", Offset = "0x14E481")]
	public class CompareSharedString : Conditional
	{
		// Token: 0x0600746A RID: 29802 RVA: 0x00028428 File Offset: 0x00026628
		[Token(Token = "0x600611E")]
		[Address(RVA = "0x2220930", Offset = "0x2220A31", VA = "0x2220930", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611F")]
		[Address(RVA = "0x22209D0", Offset = "0x2220AD1", VA = "0x22209D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600746C RID: 29804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006120")]
		[Address(RVA = "0x2220B50", Offset = "0x2220C51", VA = "0x2220B50")]
		public CompareSharedString()
		{
		}

		// Token: 0x0401B745 RID: 112453
		[Token(Token = "0x4018166")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1878D0", Offset = "0x1879D1")]
		public SharedString variable;

		// Token: 0x0401B746 RID: 112454
		[Token(Token = "0x4018167")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187910", Offset = "0x187A11")]
		public SharedString compareTo;
	}
}
