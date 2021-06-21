using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001371 RID: 4977
	[Token(Token = "0x2000D3C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E740", Offset = "0x14E841")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E740", Offset = "0x14E841")]
	public class SetSharedGameObjectList : Action
	{
		// Token: 0x06007488 RID: 29832 RVA: 0x00028518 File Offset: 0x00026718
		[Token(Token = "0x600613C")]
		[Address(RVA = "0x28D03B0", Offset = "0x28D04B1", VA = "0x28D03B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613D")]
		[Address(RVA = "0x28D0430", Offset = "0x28D0531", VA = "0x28D0430", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613E")]
		[Address(RVA = "0x28D0470", Offset = "0x28D0571", VA = "0x28D0470")]
		public SetSharedGameObjectList()
		{
		}

		// Token: 0x0401B75A RID: 112474
		[Token(Token = "0x401817B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187E50", Offset = "0x187F51")]
		public SharedGameObjectList targetValue;

		// Token: 0x0401B75B RID: 112475
		[Token(Token = "0x401817C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x187E90", Offset = "0x187F91")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187E90", Offset = "0x187F91")]
		public SharedGameObjectList targetVariable;
	}
}
