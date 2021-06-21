using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001363 RID: 4963
	[Token(Token = "0x2000D2E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E200", Offset = "0x14E301")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E200", Offset = "0x14E301")]
	public class CompareSharedObject : Conditional
	{
		// Token: 0x0600745E RID: 29790 RVA: 0x000283C8 File Offset: 0x000265C8
		[Token(Token = "0x6006112")]
		[Address(RVA = "0x22200B0", Offset = "0x22201B1", VA = "0x22200B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006113")]
		[Address(RVA = "0x2220280", Offset = "0x2220381", VA = "0x2220280", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006114")]
		[Address(RVA = "0x22202C0", Offset = "0x22203C1", VA = "0x22202C0")]
		public CompareSharedObject()
		{
		}

		// Token: 0x0401B73D RID: 112445
		[Token(Token = "0x401815E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1876D0", Offset = "0x1877D1")]
		public SharedObject variable;

		// Token: 0x0401B73E RID: 112446
		[Token(Token = "0x401815F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187710", Offset = "0x187811")]
		public SharedObject compareTo;
	}
}
