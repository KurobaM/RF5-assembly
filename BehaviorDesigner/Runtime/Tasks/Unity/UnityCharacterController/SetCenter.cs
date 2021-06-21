using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x02001466 RID: 5222
	[Token(Token = "0x2000E2C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154190", Offset = "0x154291")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154190", Offset = "0x154291")]
	public class SetCenter : Action
	{
		// Token: 0x060077E6 RID: 30694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649A")]
		[Address(RVA = "0x28E28B0", Offset = "0x28E29B1", VA = "0x28E28B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00029BB0 File Offset: 0x00027DB0
		[Token(Token = "0x600649B")]
		[Address(RVA = "0x28E29B0", Offset = "0x28E2AB1", VA = "0x28E29B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649C")]
		[Address(RVA = "0x28E2AA0", Offset = "0x28E2BA1", VA = "0x28E2AA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649D")]
		[Address(RVA = "0x28E2B30", Offset = "0x28E2C31", VA = "0x28E2B30")]
		public SetCenter()
		{
		}

		// Token: 0x0401BAA3 RID: 113315
		[Token(Token = "0x40184A1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190830", Offset = "0x190931")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAA4 RID: 113316
		[Token(Token = "0x40184A2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190870", Offset = "0x190971")]
		public SharedVector3 center;

		// Token: 0x0401BAA5 RID: 113317
		[Token(Token = "0x40184A3")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BAA6 RID: 113318
		[Token(Token = "0x40184A4")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
