using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001377 RID: 4983
	[Token(Token = "0x2000D42")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E980", Offset = "0x14EA81")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E980", Offset = "0x14EA81")]
	public class SetSharedString : Action
	{
		// Token: 0x0600749A RID: 29850 RVA: 0x000285A8 File Offset: 0x000267A8
		[Token(Token = "0x600614E")]
		[Address(RVA = "0x28D0940", Offset = "0x28D0A41", VA = "0x28D0940", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614F")]
		[Address(RVA = "0x28D09C0", Offset = "0x28D0AC1", VA = "0x28D09C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600749C RID: 29852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006150")]
		[Address(RVA = "0x28D0A40", Offset = "0x28D0B41", VA = "0x28D0A40")]
		public SetSharedString()
		{
		}

		// Token: 0x0401B766 RID: 112486
		[Token(Token = "0x4018187")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1881B0", Offset = "0x1882B1")]
		public SharedString targetValue;

		// Token: 0x0401B767 RID: 112487
		[Token(Token = "0x4018188")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1881F0", Offset = "0x1882F1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1881F0", Offset = "0x1882F1")]
		public SharedString targetVariable;
	}
}
