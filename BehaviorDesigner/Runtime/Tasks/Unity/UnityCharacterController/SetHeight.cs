using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x02001467 RID: 5223
	[Token(Token = "0x2000E2D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1541F0", Offset = "0x1542F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1541F0", Offset = "0x1542F1")]
	public class SetHeight : Action
	{
		// Token: 0x060077EA RID: 30698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649E")]
		[Address(RVA = "0x28E2B40", Offset = "0x28E2C41", VA = "0x28E2B40", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x00029BC8 File Offset: 0x00027DC8
		[Token(Token = "0x600649F")]
		[Address(RVA = "0x28E2C40", Offset = "0x28E2D41", VA = "0x28E2C40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A0")]
		[Address(RVA = "0x28E2D30", Offset = "0x28E2E31", VA = "0x28E2D30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A1")]
		[Address(RVA = "0x28E2D80", Offset = "0x28E2E81", VA = "0x28E2D80")]
		public SetHeight()
		{
		}

		// Token: 0x0401BAA7 RID: 113319
		[Token(Token = "0x40184A5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1908B0", Offset = "0x1909B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAA8 RID: 113320
		[Token(Token = "0x40184A6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1908F0", Offset = "0x1909F1")]
		public SharedFloat height;

		// Token: 0x0401BAA9 RID: 113321
		[Token(Token = "0x40184A7")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BAAA RID: 113322
		[Token(Token = "0x40184A8")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
