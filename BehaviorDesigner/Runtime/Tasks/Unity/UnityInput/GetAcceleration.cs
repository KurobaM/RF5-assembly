using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x02001437 RID: 5175
	[Token(Token = "0x2000DFD")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152FF0", Offset = "0x1530F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152FF0", Offset = "0x1530F1")]
	public class GetAcceleration : Action
	{
		// Token: 0x06007749 RID: 30537 RVA: 0x00029730 File Offset: 0x00027930
		[Token(Token = "0x60063FD")]
		[Address(RVA = "0x28E5EF0", Offset = "0x28E5FF1", VA = "0x28E5EF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FE")]
		[Address(RVA = "0x28E5F60", Offset = "0x28E6061", VA = "0x28E5F60", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FF")]
		[Address(RVA = "0x28E5FE0", Offset = "0x28E60E1", VA = "0x28E5FE0")]
		public GetAcceleration()
		{
		}

		// Token: 0x0401BA29 RID: 113193
		[Token(Token = "0x4018427")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18EF90", Offset = "0x18F091")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EF90", Offset = "0x18F091")]
		public SharedVector3 storeResult;
	}
}
