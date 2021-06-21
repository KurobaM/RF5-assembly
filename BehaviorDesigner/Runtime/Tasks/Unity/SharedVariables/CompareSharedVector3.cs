using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200136B RID: 4971
	[Token(Token = "0x2000D36")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E500", Offset = "0x14E601")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E500", Offset = "0x14E601")]
	public class CompareSharedVector3 : Conditional
	{
		// Token: 0x06007476 RID: 29814 RVA: 0x00028488 File Offset: 0x00026688
		[Token(Token = "0x600612A")]
		[Address(RVA = "0x22211E0", Offset = "0x22212E1", VA = "0x22211E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612B")]
		[Address(RVA = "0x2221280", Offset = "0x2221381", VA = "0x2221280", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600612C")]
		[Address(RVA = "0x2221430", Offset = "0x2221531", VA = "0x2221430")]
		public CompareSharedVector3()
		{
		}

		// Token: 0x0401B74D RID: 112461
		[Token(Token = "0x401816E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187AD0", Offset = "0x187BD1")]
		public SharedVector3 variable;

		// Token: 0x0401B74E RID: 112462
		[Token(Token = "0x401816F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187B10", Offset = "0x187C11")]
		public SharedVector3 compareTo;
	}
}
