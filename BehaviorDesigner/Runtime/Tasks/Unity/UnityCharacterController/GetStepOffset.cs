using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x02001461 RID: 5217
	[Token(Token = "0x2000E27")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153FB0", Offset = "0x1540B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153FB0", Offset = "0x1540B1")]
	public class GetStepOffset : Action
	{
		// Token: 0x060077D1 RID: 30673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006485")]
		[Address(RVA = "0x28E1D20", Offset = "0x28E1E21", VA = "0x28E1D20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x00029B38 File Offset: 0x00027D38
		[Token(Token = "0x6006486")]
		[Address(RVA = "0x28E1E20", Offset = "0x28E1F21", VA = "0x28E1E20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077D3 RID: 30675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006487")]
		[Address(RVA = "0x28E1F10", Offset = "0x28E2011", VA = "0x28E1F10", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077D4 RID: 30676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006488")]
		[Address(RVA = "0x28E1F60", Offset = "0x28E2061", VA = "0x28E1F60")]
		public GetStepOffset()
		{
		}

		// Token: 0x0401BA90 RID: 113296
		[Token(Token = "0x401848E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190590", Offset = "0x190691")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA91 RID: 113297
		[Token(Token = "0x401848F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1905D0", Offset = "0x1906D1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1905D0", Offset = "0x1906D1")]
		public SharedFloat storeValue;

		// Token: 0x0401BA92 RID: 113298
		[Token(Token = "0x4018490")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BA93 RID: 113299
		[Token(Token = "0x4018491")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
