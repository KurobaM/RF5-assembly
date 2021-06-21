using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001366 RID: 4966
	[Token(Token = "0x2000D31")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E320", Offset = "0x14E421")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E320", Offset = "0x14E421")]
	public class CompareSharedRect : Conditional
	{
		// Token: 0x06007467 RID: 29799 RVA: 0x00028410 File Offset: 0x00026610
		[Token(Token = "0x600611B")]
		[Address(RVA = "0x2220750", Offset = "0x2220851", VA = "0x2220750", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007468 RID: 29800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611C")]
		[Address(RVA = "0x22207F0", Offset = "0x22208F1", VA = "0x22207F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007469 RID: 29801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611D")]
		[Address(RVA = "0x2220920", Offset = "0x2220A21", VA = "0x2220920")]
		public CompareSharedRect()
		{
		}

		// Token: 0x0401B743 RID: 112451
		[Token(Token = "0x4018164")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187850", Offset = "0x187951")]
		public SharedRect variable;

		// Token: 0x0401B744 RID: 112452
		[Token(Token = "0x4018165")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187890", Offset = "0x187991")]
		public SharedRect compareTo;
	}
}
