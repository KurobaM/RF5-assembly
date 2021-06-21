using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012CF RID: 4815
	[Token(Token = "0x2000C9C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14AA30", Offset = "0x14AB31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14AA30", Offset = "0x14AB31")]
	public class ComparePartnerMonsterBehaviorType : Conditional
	{
		// Token: 0x06007206 RID: 29190 RVA: 0x00027300 File Offset: 0x00025500
		[Token(Token = "0x6005EBA")]
		[Address(RVA = "0x2210190", Offset = "0x2210291", VA = "0x2210190", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBB")]
		[Address(RVA = "0x2210210", Offset = "0x2210311", VA = "0x2210210")]
		public ComparePartnerMonsterBehaviorType()
		{
		}

		// Token: 0x0401B557 RID: 111959
		[Token(Token = "0x4017F80")]
		[FieldOffset(Offset = "0x50")]
		public SharedPartnerMonsterBehaviorController SharedPartnerMonsterBehaviorController;

		// Token: 0x0401B558 RID: 111960
		[Token(Token = "0x4017F81")]
		[FieldOffset(Offset = "0x58")]
		public PartnerBehaviorType PartnerBehaviorType;
	}
}
