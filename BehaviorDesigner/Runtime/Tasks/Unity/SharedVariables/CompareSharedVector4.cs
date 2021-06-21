using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200136C RID: 4972
	[Token(Token = "0x2000D37")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E560", Offset = "0x14E661")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E560", Offset = "0x14E661")]
	public class CompareSharedVector4 : Conditional
	{
		// Token: 0x06007479 RID: 29817 RVA: 0x000284A0 File Offset: 0x000266A0
		[Token(Token = "0x600612D")]
		[Address(RVA = "0x2221440", Offset = "0x2221541", VA = "0x2221440", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612E")]
		[Address(RVA = "0x22214E0", Offset = "0x22215E1", VA = "0x22214E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612F")]
		[Address(RVA = "0x2221690", Offset = "0x2221791", VA = "0x2221690")]
		public CompareSharedVector4()
		{
		}

		// Token: 0x0401B74F RID: 112463
		[Token(Token = "0x4018170")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187B50", Offset = "0x187C51")]
		public SharedVector4 variable;

		// Token: 0x0401B750 RID: 112464
		[Token(Token = "0x4018171")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187B90", Offset = "0x187C91")]
		public SharedVector4 compareTo;
	}
}
