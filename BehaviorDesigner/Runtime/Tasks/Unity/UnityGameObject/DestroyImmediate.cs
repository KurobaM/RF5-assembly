using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x02001449 RID: 5193
	[Token(Token = "0x2000E0F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1536B0", Offset = "0x1537B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1536B0", Offset = "0x1537B1")]
	public class DestroyImmediate : Action
	{
		// Token: 0x0600777F RID: 30591 RVA: 0x000298E0 File Offset: 0x00027AE0
		[Token(Token = "0x6006433")]
		[Address(RVA = "0x28E5060", Offset = "0x28E5161", VA = "0x28E5060", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007780 RID: 30592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006434")]
		[Address(RVA = "0x28E5100", Offset = "0x28E5201", VA = "0x28E5100", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006435")]
		[Address(RVA = "0x28E5110", Offset = "0x28E5211", VA = "0x28E5110")]
		public DestroyImmediate()
		{
		}

		// Token: 0x0401BA45 RID: 113221
		[Token(Token = "0x4018443")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F700", Offset = "0x18F801")]
		public SharedGameObject targetGameObject;
	}
}
