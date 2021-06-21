using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x02001439 RID: 5177
	[Token(Token = "0x2000DFF")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1530B0", Offset = "0x1531B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1530B0", Offset = "0x1531B1")]
	public class GetAxisRaw : Action
	{
		// Token: 0x0600774F RID: 30543 RVA: 0x00029760 File Offset: 0x00027960
		[Token(Token = "0x6006403")]
		[Address(RVA = "0x28E6160", Offset = "0x28E6261", VA = "0x28E6160", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006404")]
		[Address(RVA = "0x28E6220", Offset = "0x28E6321", VA = "0x28E6220", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006405")]
		[Address(RVA = "0x28E62C0", Offset = "0x28E63C1", VA = "0x28E62C0")]
		public GetAxisRaw()
		{
		}

		// Token: 0x0401BA2D RID: 113197
		[Token(Token = "0x401842B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F0B0", Offset = "0x18F1B1")]
		public SharedString axisName;

		// Token: 0x0401BA2E RID: 113198
		[Token(Token = "0x401842C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F0F0", Offset = "0x18F1F1")]
		public SharedFloat multiplier;

		// Token: 0x0401BA2F RID: 113199
		[Token(Token = "0x401842D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18F130", Offset = "0x18F231")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F130", Offset = "0x18F231")]
		public SharedFloat storeResult;
	}
}
