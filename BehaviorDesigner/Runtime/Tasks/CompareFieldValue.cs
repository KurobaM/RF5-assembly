using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012F5 RID: 4853
	[Token(Token = "0x2000CC2")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B940", Offset = "0x14BA41")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14B940", Offset = "0x14BA41")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B940", Offset = "0x14BA41")]
	public class CompareFieldValue : Conditional
	{
		// Token: 0x060072D8 RID: 29400 RVA: 0x000278D0 File Offset: 0x00025AD0
		[Token(Token = "0x6005F8C")]
		[Address(RVA = "0x220FDC0", Offset = "0x220FEC1", VA = "0x220FDC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0x2210090", Offset = "0x2210191", VA = "0x2210090", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0x22100F0", Offset = "0x22101F1", VA = "0x22100F0")]
		public CompareFieldValue()
		{
		}

		// Token: 0x0401B5E1 RID: 112097
		[Token(Token = "0x401800A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1836E0", Offset = "0x1837E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B5E2 RID: 112098
		[Token(Token = "0x401800B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183720", Offset = "0x183821")]
		public SharedString componentName;

		// Token: 0x0401B5E3 RID: 112099
		[Token(Token = "0x401800C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183760", Offset = "0x183861")]
		public SharedString fieldName;

		// Token: 0x0401B5E4 RID: 112100
		[Token(Token = "0x401800D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1837A0", Offset = "0x1838A1")]
		public SharedVariable compareValue;
	}
}
