using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x0200143A RID: 5178
	[Token(Token = "0x2000E00")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153110", Offset = "0x153211")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153110", Offset = "0x153211")]
	public class GetButton : Action
	{
		// Token: 0x06007752 RID: 30546 RVA: 0x00029778 File Offset: 0x00027978
		[Token(Token = "0x6006406")]
		[Address(RVA = "0x28E62D0", Offset = "0x28E63D1", VA = "0x28E62D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006407")]
		[Address(RVA = "0x28E6360", Offset = "0x28E6461", VA = "0x28E6360", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006408")]
		[Address(RVA = "0x28E63E0", Offset = "0x28E64E1", VA = "0x28E63E0")]
		public GetButton()
		{
		}

		// Token: 0x0401BA30 RID: 113200
		[Token(Token = "0x401842E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F180", Offset = "0x18F281")]
		public SharedString buttonName;

		// Token: 0x0401BA31 RID: 113201
		[Token(Token = "0x401842F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18F1C0", Offset = "0x18F2C1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F1C0", Offset = "0x18F2C1")]
		public SharedBool storeResult;
	}
}
