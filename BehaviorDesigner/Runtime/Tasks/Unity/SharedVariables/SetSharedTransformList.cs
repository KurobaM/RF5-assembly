using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001379 RID: 4985
	[Token(Token = "0x2000D44")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EA40", Offset = "0x14EB41")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EA40", Offset = "0x14EB41")]
	public class SetSharedTransformList : Action
	{
		// Token: 0x060074A0 RID: 29856 RVA: 0x000285D8 File Offset: 0x000267D8
		[Token(Token = "0x6006154")]
		[Address(RVA = "0x28D0B80", Offset = "0x28D0C81", VA = "0x28D0B80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006155")]
		[Address(RVA = "0x28D0C00", Offset = "0x28D0D01", VA = "0x28D0C00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006156")]
		[Address(RVA = "0x28D0C40", Offset = "0x28D0D41", VA = "0x28D0C40")]
		public SetSharedTransformList()
		{
		}

		// Token: 0x0401B76A RID: 112490
		[Token(Token = "0x401818B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1882D0", Offset = "0x1883D1")]
		public SharedTransformList targetValue;

		// Token: 0x0401B76B RID: 112491
		[Token(Token = "0x401818C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188310", Offset = "0x188411")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188310", Offset = "0x188411")]
		public SharedTransformList targetVariable;
	}
}
