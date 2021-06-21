using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001370 RID: 4976
	[Token(Token = "0x2000D3B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E6E0", Offset = "0x14E7E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E6E0", Offset = "0x14E7E1")]
	public class SetSharedGameObject : Action
	{
		// Token: 0x06007485 RID: 29829 RVA: 0x00028500 File Offset: 0x00026700
		[Token(Token = "0x6006139")]
		[Address(RVA = "0x2221C40", Offset = "0x2221D41", VA = "0x2221C40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613A")]
		[Address(RVA = "0x2221D40", Offset = "0x2221E41", VA = "0x2221D40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613B")]
		[Address(RVA = "0x2221E10", Offset = "0x2221F11", VA = "0x2221E10")]
		public SetSharedGameObject()
		{
		}

		// Token: 0x0401B757 RID: 112471
		[Token(Token = "0x4018178")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187D80", Offset = "0x187E81")]
		public SharedGameObject targetValue;

		// Token: 0x0401B758 RID: 112472
		[Token(Token = "0x4018179")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x187DC0", Offset = "0x187EC1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187DC0", Offset = "0x187EC1")]
		public SharedGameObject targetVariable;

		// Token: 0x0401B759 RID: 112473
		[Token(Token = "0x401817A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187E10", Offset = "0x187F11")]
		public SharedBool valueCanBeNull;
	}
}
