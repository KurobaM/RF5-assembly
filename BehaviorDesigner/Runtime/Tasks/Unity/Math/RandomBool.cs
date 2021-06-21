using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200141D RID: 5149
	[Token(Token = "0x2000DE3")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152630", Offset = "0x152731")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152630", Offset = "0x152731")]
	public class RandomBool : Action
	{
		// Token: 0x060076EA RID: 30442 RVA: 0x000294C0 File Offset: 0x000276C0
		[Token(Token = "0x600639E")]
		[Address(RVA = "0x221EB50", Offset = "0x221EC51", VA = "0x221EB50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639F")]
		[Address(RVA = "0x221EBD0", Offset = "0x221ECD1", VA = "0x221EBD0")]
		public RandomBool()
		{
		}

		// Token: 0x0401B9CE RID: 113102
		[Token(Token = "0x40183CC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E150", Offset = "0x18E251")]
		public SharedBool storeResult;
	}
}
