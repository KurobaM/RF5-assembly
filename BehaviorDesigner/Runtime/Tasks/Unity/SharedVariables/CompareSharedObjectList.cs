using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001364 RID: 4964
	[Token(Token = "0x2000D2F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E260", Offset = "0x14E361")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E260", Offset = "0x14E361")]
	public class CompareSharedObjectList : Conditional
	{
		// Token: 0x06007461 RID: 29793 RVA: 0x000283E0 File Offset: 0x000265E0
		[Token(Token = "0x6006115")]
		[Address(RVA = "0x22202D0", Offset = "0x22203D1", VA = "0x22202D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006116")]
		[Address(RVA = "0x22204A0", Offset = "0x22205A1", VA = "0x22204A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007463 RID: 29795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006117")]
		[Address(RVA = "0x22204E0", Offset = "0x22205E1", VA = "0x22204E0")]
		public CompareSharedObjectList()
		{
		}

		// Token: 0x0401B73F RID: 112447
		[Token(Token = "0x4018160")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187750", Offset = "0x187851")]
		public SharedObjectList variable;

		// Token: 0x0401B740 RID: 112448
		[Token(Token = "0x4018161")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187790", Offset = "0x187891")]
		public SharedObjectList compareTo;
	}
}
