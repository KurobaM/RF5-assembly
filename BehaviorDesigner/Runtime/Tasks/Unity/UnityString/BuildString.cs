using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString
{
	// Token: 0x02001350 RID: 4944
	[Token(Token = "0x2000D1B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DAE0", Offset = "0x14DBE1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DAE0", Offset = "0x14DBE1")]
	public class BuildString : Action
	{
		// Token: 0x06007420 RID: 29728 RVA: 0x00028200 File Offset: 0x00026400
		[Token(Token = "0x60060D4")]
		[Address(RVA = "0x2999680", Offset = "0x2999781", VA = "0x2999680", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D5")]
		[Address(RVA = "0x2999760", Offset = "0x2999861", VA = "0x2999760", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007422 RID: 29730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D6")]
		[Address(RVA = "0x29997A0", Offset = "0x29998A1", VA = "0x29997A0")]
		public BuildString()
		{
		}

		// Token: 0x0401B709 RID: 112393
		[Token(Token = "0x401812A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186B70", Offset = "0x186C71")]
		public SharedString[] source;

		// Token: 0x0401B70A RID: 112394
		[Token(Token = "0x401812B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186BB0", Offset = "0x186CB1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x186BB0", Offset = "0x186CB1")]
		public SharedString storeResult;
	}
}
