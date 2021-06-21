using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x02001468 RID: 5224
	[Token(Token = "0x2000E2E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154250", Offset = "0x154351")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154250", Offset = "0x154351")]
	public class SetRadius : Action
	{
		// Token: 0x060077EE RID: 30702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A2")]
		[Address(RVA = "0x28E2D90", Offset = "0x28E2E91", VA = "0x28E2D90", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x00029BE0 File Offset: 0x00027DE0
		[Token(Token = "0x60064A3")]
		[Address(RVA = "0x28E2E90", Offset = "0x28E2F91", VA = "0x28E2E90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077F0 RID: 30704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A4")]
		[Address(RVA = "0x28E2F80", Offset = "0x28E3081", VA = "0x28E2F80", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A5")]
		[Address(RVA = "0x28E2FD0", Offset = "0x28E30D1", VA = "0x28E2FD0")]
		public SetRadius()
		{
		}

		// Token: 0x0401BAAB RID: 113323
		[Token(Token = "0x40184A9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190930", Offset = "0x190A31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAAC RID: 113324
		[Token(Token = "0x40184AA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190970", Offset = "0x190A71")]
		public SharedFloat radius;

		// Token: 0x0401BAAD RID: 113325
		[Token(Token = "0x40184AB")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BAAE RID: 113326
		[Token(Token = "0x40184AC")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
