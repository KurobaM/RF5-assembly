using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x0200146A RID: 5226
	[Token(Token = "0x2000E30")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154310", Offset = "0x154411")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154310", Offset = "0x154411")]
	public class SetStepOffset : Action
	{
		// Token: 0x060077F6 RID: 30710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AA")]
		[Address(RVA = "0x28E3230", Offset = "0x28E3331", VA = "0x28E3230", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x00029C10 File Offset: 0x00027E10
		[Token(Token = "0x60064AB")]
		[Address(RVA = "0x28E3330", Offset = "0x28E3431", VA = "0x28E3330", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077F8 RID: 30712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AC")]
		[Address(RVA = "0x28E3420", Offset = "0x28E3521", VA = "0x28E3420", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AD")]
		[Address(RVA = "0x28E3470", Offset = "0x28E3571", VA = "0x28E3470")]
		public SetStepOffset()
		{
		}

		// Token: 0x0401BAB3 RID: 113331
		[Token(Token = "0x40184B1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190A30", Offset = "0x190B31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAB4 RID: 113332
		[Token(Token = "0x40184B2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190A70", Offset = "0x190B71")]
		public SharedFloat stepOffset;

		// Token: 0x0401BAB5 RID: 113333
		[Token(Token = "0x40184B3")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BAB6 RID: 113334
		[Token(Token = "0x40184B4")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
