using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x0200143D RID: 5181
	[Token(Token = "0x2000E03")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153230", Offset = "0x153331")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153230", Offset = "0x153331")]
	public class GetMousePosition : Action
	{
		// Token: 0x0600775B RID: 30555 RVA: 0x000297C0 File Offset: 0x000279C0
		[Token(Token = "0x600640F")]
		[Address(RVA = "0x28E65B0", Offset = "0x28E66B1", VA = "0x28E65B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006410")]
		[Address(RVA = "0x28E6620", Offset = "0x28E6721", VA = "0x28E6620", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006411")]
		[Address(RVA = "0x28E66A0", Offset = "0x28E67A1", VA = "0x28E66A0")]
		public GetMousePosition()
		{
		}

		// Token: 0x0401BA36 RID: 113206
		[Token(Token = "0x4018434")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18F330", Offset = "0x18F431")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F330", Offset = "0x18F431")]
		public SharedVector3 storeResult;
	}
}
