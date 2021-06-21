using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200137B RID: 4987
	[Token(Token = "0x2000D46")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EB00", Offset = "0x14EC01")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EB00", Offset = "0x14EC01")]
	public class SetSharedVector3 : Action
	{
		// Token: 0x060074A6 RID: 29862 RVA: 0x00028608 File Offset: 0x00026808
		[Token(Token = "0x600615A")]
		[Address(RVA = "0x28D0D80", Offset = "0x28D0E81", VA = "0x28D0D80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615B")]
		[Address(RVA = "0x28D0E00", Offset = "0x28D0F01", VA = "0x28D0E00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600615C")]
		[Address(RVA = "0x28D0EA0", Offset = "0x28D0FA1", VA = "0x28D0EA0")]
		public SetSharedVector3()
		{
		}

		// Token: 0x0401B76E RID: 112494
		[Token(Token = "0x401818F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1883F0", Offset = "0x1884F1")]
		public SharedVector3 targetValue;

		// Token: 0x0401B76F RID: 112495
		[Token(Token = "0x4018190")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188430", Offset = "0x188531")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188430", Offset = "0x188531")]
		public SharedVector3 targetVariable;
	}
}
