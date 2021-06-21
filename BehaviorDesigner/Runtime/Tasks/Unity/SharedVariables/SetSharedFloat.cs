using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200136F RID: 4975
	[Token(Token = "0x2000D3A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E680", Offset = "0x14E781")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E680", Offset = "0x14E781")]
	public class SetSharedFloat : Action
	{
		// Token: 0x06007482 RID: 29826 RVA: 0x000284E8 File Offset: 0x000266E8
		[Token(Token = "0x6006136")]
		[Address(RVA = "0x2221A60", Offset = "0x2221B61", VA = "0x2221A60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007483 RID: 29827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006137")]
		[Address(RVA = "0x2221AE0", Offset = "0x2221BE1", VA = "0x2221AE0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007484 RID: 29828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006138")]
		[Address(RVA = "0x2221C30", Offset = "0x2221D31", VA = "0x2221C30")]
		public SetSharedFloat()
		{
		}

		// Token: 0x0401B755 RID: 112469
		[Token(Token = "0x4018176")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187CF0", Offset = "0x187DF1")]
		public SharedFloat targetValue;

		// Token: 0x0401B756 RID: 112470
		[Token(Token = "0x4018177")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x187D30", Offset = "0x187E31")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187D30", Offset = "0x187E31")]
		public SharedFloat targetVariable;
	}
}
