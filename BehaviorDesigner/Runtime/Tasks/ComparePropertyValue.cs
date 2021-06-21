using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012F6 RID: 4854
	[Token(Token = "0x2000CC3")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B9D0", Offset = "0x14BAD1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14B9D0", Offset = "0x14BAD1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B9D0", Offset = "0x14BAD1")]
	public class ComparePropertyValue : Conditional
	{
		// Token: 0x060072DB RID: 29403 RVA: 0x000278E8 File Offset: 0x00025AE8
		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0x2210220", Offset = "0x2210321", VA = "0x2210220", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072DC RID: 29404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F90")]
		[Address(RVA = "0x22104F0", Offset = "0x22105F1", VA = "0x22104F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072DD RID: 29405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F91")]
		[Address(RVA = "0x2210550", Offset = "0x2210651", VA = "0x2210550")]
		public ComparePropertyValue()
		{
		}

		// Token: 0x0401B5E5 RID: 112101
		[Token(Token = "0x401800E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1837E0", Offset = "0x1838E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B5E6 RID: 112102
		[Token(Token = "0x401800F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183820", Offset = "0x183921")]
		public SharedString componentName;

		// Token: 0x0401B5E7 RID: 112103
		[Token(Token = "0x4018010")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183860", Offset = "0x183961")]
		public SharedString propertyName;

		// Token: 0x0401B5E8 RID: 112104
		[Token(Token = "0x4018011")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1838A0", Offset = "0x1839A1")]
		public SharedVariable compareValue;
	}
}
