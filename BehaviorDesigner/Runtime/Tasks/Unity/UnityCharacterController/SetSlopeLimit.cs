using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x02001469 RID: 5225
	[Token(Token = "0x2000E2F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1542B0", Offset = "0x1543B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1542B0", Offset = "0x1543B1")]
	public class SetSlopeLimit : Action
	{
		// Token: 0x060077F2 RID: 30706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A6")]
		[Address(RVA = "0x28E2FE0", Offset = "0x28E30E1", VA = "0x28E2FE0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x00029BF8 File Offset: 0x00027DF8
		[Token(Token = "0x60064A7")]
		[Address(RVA = "0x28E30E0", Offset = "0x28E31E1", VA = "0x28E30E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A8")]
		[Address(RVA = "0x28E31D0", Offset = "0x28E32D1", VA = "0x28E31D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A9")]
		[Address(RVA = "0x28E3220", Offset = "0x28E3321", VA = "0x28E3220")]
		public SetSlopeLimit()
		{
		}

		// Token: 0x0401BAAF RID: 113327
		[Token(Token = "0x40184AD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1909B0", Offset = "0x190AB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAB0 RID: 113328
		[Token(Token = "0x40184AE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1909F0", Offset = "0x190AF1")]
		public SharedFloat slopeLimit;

		// Token: 0x0401BAB1 RID: 113329
		[Token(Token = "0x40184AF")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BAB2 RID: 113330
		[Token(Token = "0x40184B0")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
