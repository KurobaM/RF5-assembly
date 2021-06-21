using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x0200146B RID: 5227
	[Token(Token = "0x2000E31")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154370", Offset = "0x154471")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154370", Offset = "0x154471")]
	public class SimpleMove : Action
	{
		// Token: 0x060077FA RID: 30714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064AE")]
		[Address(RVA = "0x28E3480", Offset = "0x28E3581", VA = "0x28E3480", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x00029C28 File Offset: 0x00027E28
		[Token(Token = "0x60064AF")]
		[Address(RVA = "0x28E3580", Offset = "0x28E3681", VA = "0x28E3580", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B0")]
		[Address(RVA = "0x28E3670", Offset = "0x28E3771", VA = "0x28E3670", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B1")]
		[Address(RVA = "0x28E3700", Offset = "0x28E3801", VA = "0x28E3700")]
		public SimpleMove()
		{
		}

		// Token: 0x0401BAB7 RID: 113335
		[Token(Token = "0x40184B5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190AB0", Offset = "0x190BB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAB8 RID: 113336
		[Token(Token = "0x40184B6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190AF0", Offset = "0x190BF1")]
		public SharedVector3 speed;

		// Token: 0x0401BAB9 RID: 113337
		[Token(Token = "0x40184B7")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BABA RID: 113338
		[Token(Token = "0x40184B8")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
