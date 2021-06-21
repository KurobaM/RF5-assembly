using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012D8 RID: 4824
	[Token(Token = "0x2000CA5")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14AD90", Offset = "0x14AE91")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14AD90", Offset = "0x14AE91")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14AD90", Offset = "0x14AE91")]
	public class GetPropertyValue : Action
	{
		// Token: 0x06007221 RID: 29217 RVA: 0x000273D8 File Offset: 0x000255D8
		[Token(Token = "0x6005ED5")]
		[Address(RVA = "0x22116E0", Offset = "0x22117E1", VA = "0x22116E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED6")]
		[Address(RVA = "0x2211970", Offset = "0x2211A71", VA = "0x2211970", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED7")]
		[Address(RVA = "0x22119D0", Offset = "0x2211AD1", VA = "0x22119D0")]
		public GetPropertyValue()
		{
		}

		// Token: 0x0401B571 RID: 111985
		[Token(Token = "0x4017F9A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1825F0", Offset = "0x1826F1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B572 RID: 111986
		[Token(Token = "0x4017F9B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182630", Offset = "0x182731")]
		public SharedString componentName;

		// Token: 0x0401B573 RID: 111987
		[Token(Token = "0x4017F9C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182670", Offset = "0x182771")]
		public SharedString propertyName;

		// Token: 0x0401B574 RID: 111988
		[Token(Token = "0x4017F9D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1826B0", Offset = "0x1827B1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1826B0", Offset = "0x1827B1")]
		public SharedVariable propertyValue;
	}
}
