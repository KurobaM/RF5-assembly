using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001376 RID: 4982
	[Token(Token = "0x2000D41")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E920", Offset = "0x14EA21")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E920", Offset = "0x14EA21")]
	public class SetSharedRect : Action
	{
		// Token: 0x06007497 RID: 29847 RVA: 0x00028590 File Offset: 0x00026790
		[Token(Token = "0x600614B")]
		[Address(RVA = "0x28D0830", Offset = "0x28D0931", VA = "0x28D0830", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614C")]
		[Address(RVA = "0x28D08B0", Offset = "0x28D09B1", VA = "0x28D08B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614D")]
		[Address(RVA = "0x28D0930", Offset = "0x28D0A31", VA = "0x28D0930")]
		public SetSharedRect()
		{
		}

		// Token: 0x0401B764 RID: 112484
		[Token(Token = "0x4018185")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188120", Offset = "0x188221")]
		public SharedRect targetValue;

		// Token: 0x0401B765 RID: 112485
		[Token(Token = "0x4018186")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188160", Offset = "0x188261")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188160", Offset = "0x188261")]
		public SharedRect targetVariable;
	}
}
