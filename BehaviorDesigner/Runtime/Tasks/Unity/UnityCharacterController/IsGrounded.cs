using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x02001464 RID: 5220
	[Token(Token = "0x2000E2A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1540D0", Offset = "0x1541D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1540D0", Offset = "0x1541D1")]
	public class IsGrounded : Conditional
	{
		// Token: 0x060077DE RID: 30686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006492")]
		[Address(RVA = "0x28E2420", Offset = "0x28E2521", VA = "0x28E2420", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x00029B80 File Offset: 0x00027D80
		[Token(Token = "0x6006493")]
		[Address(RVA = "0x28E2520", Offset = "0x28E2621", VA = "0x28E2520", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006494")]
		[Address(RVA = "0x28E2600", Offset = "0x28E2701", VA = "0x28E2600", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006495")]
		[Address(RVA = "0x28E2610", Offset = "0x28E2711", VA = "0x28E2610")]
		public IsGrounded()
		{
		}

		// Token: 0x0401BA9C RID: 113308
		[Token(Token = "0x401849A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190770", Offset = "0x190871")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA9D RID: 113309
		[Token(Token = "0x401849B")]
		[FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		// Token: 0x0401BA9E RID: 113310
		[Token(Token = "0x401849C")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
