using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200136A RID: 4970
	[Token(Token = "0x2000D35")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E4A0", Offset = "0x14E5A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E4A0", Offset = "0x14E5A1")]
	public class CompareSharedVector2 : Conditional
	{
		// Token: 0x06007473 RID: 29811 RVA: 0x00028470 File Offset: 0x00026670
		[Token(Token = "0x6006127")]
		[Address(RVA = "0x2220FA0", Offset = "0x22210A1", VA = "0x2220FA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007474 RID: 29812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006128")]
		[Address(RVA = "0x2221040", Offset = "0x2221141", VA = "0x2221040", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006129")]
		[Address(RVA = "0x22211D0", Offset = "0x22212D1", VA = "0x22211D0")]
		public CompareSharedVector2()
		{
		}

		// Token: 0x0401B74B RID: 112459
		[Token(Token = "0x401816C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187A50", Offset = "0x187B51")]
		public SharedVector2 variable;

		// Token: 0x0401B74C RID: 112460
		[Token(Token = "0x401816D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187A90", Offset = "0x187B91")]
		public SharedVector2 compareTo;
	}
}
