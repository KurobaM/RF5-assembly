using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200141C RID: 5148
	[Token(Token = "0x2000DE2")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1525D0", Offset = "0x1526D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1525D0", Offset = "0x1526D1")]
	public class LerpAngle : Action
	{
		// Token: 0x060076E7 RID: 30439 RVA: 0x000294A8 File Offset: 0x000276A8
		[Token(Token = "0x600639B")]
		[Address(RVA = "0x221E7F0", Offset = "0x221E8F1", VA = "0x221E7F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639C")]
		[Address(RVA = "0x221E8F0", Offset = "0x221E9F1", VA = "0x221E8F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639D")]
		[Address(RVA = "0x221EB40", Offset = "0x221EC41", VA = "0x221EB40")]
		public LerpAngle()
		{
		}

		// Token: 0x0401B9CA RID: 113098
		[Token(Token = "0x40183C8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E040", Offset = "0x18E141")]
		public SharedFloat fromValue;

		// Token: 0x0401B9CB RID: 113099
		[Token(Token = "0x40183C9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E080", Offset = "0x18E181")]
		public SharedFloat toValue;

		// Token: 0x0401B9CC RID: 113100
		[Token(Token = "0x40183CA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E0C0", Offset = "0x18E1C1")]
		public SharedFloat lerpAmount;

		// Token: 0x0401B9CD RID: 113101
		[Token(Token = "0x40183CB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E100", Offset = "0x18E201")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18E100", Offset = "0x18E201")]
		public SharedFloat storeResult;
	}
}
