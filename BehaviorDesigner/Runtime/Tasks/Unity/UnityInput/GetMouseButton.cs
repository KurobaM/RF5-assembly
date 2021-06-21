using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x0200143C RID: 5180
	[Token(Token = "0x2000E02")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1531D0", Offset = "0x1532D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1531D0", Offset = "0x1532D1")]
	public class GetMouseButton : Action
	{
		// Token: 0x06007758 RID: 30552 RVA: 0x000297A8 File Offset: 0x000279A8
		[Token(Token = "0x600640C")]
		[Address(RVA = "0x28E64C0", Offset = "0x28E65C1", VA = "0x28E64C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640D")]
		[Address(RVA = "0x28E6550", Offset = "0x28E6651", VA = "0x28E6550", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640E")]
		[Address(RVA = "0x28E65A0", Offset = "0x28E66A1", VA = "0x28E65A0")]
		public GetMouseButton()
		{
		}

		// Token: 0x0401BA34 RID: 113204
		[Token(Token = "0x4018432")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F2A0", Offset = "0x18F3A1")]
		public SharedInt buttonIndex;

		// Token: 0x0401BA35 RID: 113205
		[Token(Token = "0x4018433")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18F2E0", Offset = "0x18F3E1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F2E0", Offset = "0x18F3E1")]
		public SharedBool storeResult;
	}
}
