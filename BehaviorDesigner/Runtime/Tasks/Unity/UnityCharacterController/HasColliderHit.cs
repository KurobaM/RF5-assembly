using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x02001463 RID: 5219
	[Token(Token = "0x2000E29")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154070", Offset = "0x154171")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154070", Offset = "0x154171")]
	public class HasColliderHit : Conditional
	{
		// Token: 0x060077D9 RID: 30681 RVA: 0x00029B68 File Offset: 0x00027D68
		[Token(Token = "0x600648D")]
		[Address(RVA = "0x28E2200", Offset = "0x28E2301", VA = "0x28E2200", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600648E")]
		[Address(RVA = "0x28E2220", Offset = "0x28E2321", VA = "0x28E2220", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600648F")]
		[Address(RVA = "0x28E2230", Offset = "0x28E2331", VA = "0x28E2230", Slot = "26")]
		public override void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006490")]
		[Address(RVA = "0x28E2330", Offset = "0x28E2431", VA = "0x28E2330", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006491")]
		[Address(RVA = "0x28E23B0", Offset = "0x28E24B1", VA = "0x28E23B0")]
		public HasColliderHit()
		{
		}

		// Token: 0x0401BA98 RID: 113304
		[Token(Token = "0x4018496")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1906B0", Offset = "0x1907B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA99 RID: 113305
		[Token(Token = "0x4018497")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1906F0", Offset = "0x1907F1")]
		public SharedString tag;

		// Token: 0x0401BA9A RID: 113306
		[Token(Token = "0x4018498")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190730", Offset = "0x190831")]
		public SharedGameObject collidedGameObject;

		// Token: 0x0401BA9B RID: 113307
		[Token(Token = "0x4018499")]
		[FieldOffset(Offset = "0x68")]
		private bool enteredCollision;
	}
}
