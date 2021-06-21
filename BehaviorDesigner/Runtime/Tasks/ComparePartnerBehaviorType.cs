using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012CE RID: 4814
	[Token(Token = "0x2000C9B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A9D0", Offset = "0x14AAD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A9D0", Offset = "0x14AAD1")]
	public class ComparePartnerBehaviorType : Conditional
	{
		// Token: 0x06007204 RID: 29188 RVA: 0x000272E8 File Offset: 0x000254E8
		[Token(Token = "0x6005EB8")]
		[Address(RVA = "0x2210100", Offset = "0x2210201", VA = "0x2210100", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB9")]
		[Address(RVA = "0x2210180", Offset = "0x2210281", VA = "0x2210180")]
		public ComparePartnerBehaviorType()
		{
		}

		// Token: 0x0401B555 RID: 111957
		[Token(Token = "0x4017F7E")]
		[FieldOffset(Offset = "0x50")]
		public SharedPartnerNPCBehaviorController SharedPartnerBehaviorController;

		// Token: 0x0401B556 RID: 111958
		[Token(Token = "0x4017F7F")]
		[FieldOffset(Offset = "0x58")]
		public PartnerBehaviorType PartnerBehaviorType;
	}
}
