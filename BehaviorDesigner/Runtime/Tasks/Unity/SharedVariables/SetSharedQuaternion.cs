using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001375 RID: 4981
	[Token(Token = "0x2000D40")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E8C0", Offset = "0x14E9C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E8C0", Offset = "0x14E9C1")]
	public class SetSharedQuaternion : Action
	{
		// Token: 0x06007494 RID: 29844 RVA: 0x00028578 File Offset: 0x00026778
		[Token(Token = "0x6006148")]
		[Address(RVA = "0x28D0700", Offset = "0x28D0801", VA = "0x28D0700", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006149")]
		[Address(RVA = "0x28D0780", Offset = "0x28D0881", VA = "0x28D0780", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600614A")]
		[Address(RVA = "0x28D0820", Offset = "0x28D0921", VA = "0x28D0820")]
		public SetSharedQuaternion()
		{
		}

		// Token: 0x0401B762 RID: 112482
		[Token(Token = "0x4018183")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188090", Offset = "0x188191")]
		public SharedQuaternion targetValue;

		// Token: 0x0401B763 RID: 112483
		[Token(Token = "0x4018184")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1880D0", Offset = "0x1881D1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1880D0", Offset = "0x1881D1")]
		public SharedQuaternion targetVariable;
	}
}
