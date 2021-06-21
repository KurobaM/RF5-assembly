using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x02001465 RID: 5221
	[Token(Token = "0x2000E2B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154130", Offset = "0x154231")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154130", Offset = "0x154231")]
	public class Move : Action
	{
		// Token: 0x060077E2 RID: 30690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006496")]
		[Address(RVA = "0x28E2620", Offset = "0x28E2721", VA = "0x28E2620", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x00029B98 File Offset: 0x00027D98
		[Token(Token = "0x6006497")]
		[Address(RVA = "0x28E2720", Offset = "0x28E2821", VA = "0x28E2720", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006498")]
		[Address(RVA = "0x28E2810", Offset = "0x28E2911", VA = "0x28E2810", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006499")]
		[Address(RVA = "0x28E28A0", Offset = "0x28E29A1", VA = "0x28E28A0")]
		public Move()
		{
		}

		// Token: 0x0401BA9F RID: 113311
		[Token(Token = "0x401849D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1907B0", Offset = "0x1908B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAA0 RID: 113312
		[Token(Token = "0x401849E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1907F0", Offset = "0x1908F1")]
		public SharedVector3 motion;

		// Token: 0x0401BAA1 RID: 113313
		[Token(Token = "0x401849F")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BAA2 RID: 113314
		[Token(Token = "0x40184A0")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
