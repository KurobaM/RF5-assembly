using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200135F RID: 4959
	[Token(Token = "0x2000D2A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E080", Offset = "0x14E181")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E080", Offset = "0x14E181")]
	public class CompareSharedFloat : Conditional
	{
		// Token: 0x06007452 RID: 29778 RVA: 0x00028368 File Offset: 0x00026568
		[Token(Token = "0x6006106")]
		[Address(RVA = "0x221F890", Offset = "0x221F991", VA = "0x221F890", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007453 RID: 29779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006107")]
		[Address(RVA = "0x221F930", Offset = "0x221FA31", VA = "0x221F930", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006108")]
		[Address(RVA = "0x221FA80", Offset = "0x221FB81", VA = "0x221FA80")]
		public CompareSharedFloat()
		{
		}

		// Token: 0x0401B735 RID: 112437
		[Token(Token = "0x4018156")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1874D0", Offset = "0x1875D1")]
		public SharedFloat variable;

		// Token: 0x0401B736 RID: 112438
		[Token(Token = "0x4018157")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187510", Offset = "0x187611")]
		public SharedFloat compareTo;
	}
}
