using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001369 RID: 4969
	[Token(Token = "0x2000D34")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E440", Offset = "0x14E541")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E440", Offset = "0x14E541")]
	public class CompareSharedTransformList : Conditional
	{
		// Token: 0x06007470 RID: 29808 RVA: 0x00028458 File Offset: 0x00026658
		[Token(Token = "0x6006124")]
		[Address(RVA = "0x2220D80", Offset = "0x2220E81", VA = "0x2220D80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006125")]
		[Address(RVA = "0x2220F50", Offset = "0x2221051", VA = "0x2220F50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007472 RID: 29810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006126")]
		[Address(RVA = "0x2220F90", Offset = "0x2221091", VA = "0x2220F90")]
		public CompareSharedTransformList()
		{
		}

		// Token: 0x0401B749 RID: 112457
		[Token(Token = "0x401816A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1879D0", Offset = "0x187AD1")]
		public SharedTransformList variable;

		// Token: 0x0401B74A RID: 112458
		[Token(Token = "0x401816B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187A10", Offset = "0x187B11")]
		public SharedTransformList compareTo;
	}
}
