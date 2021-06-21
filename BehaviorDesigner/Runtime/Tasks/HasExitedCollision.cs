using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012F0 RID: 4848
	[Token(Token = "0x2000CBD")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B780", Offset = "0x14B881")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14B780", Offset = "0x14B881")]
	public class HasExitedCollision : Conditional
	{
		// Token: 0x060072C0 RID: 29376 RVA: 0x00027858 File Offset: 0x00025A58
		[Token(Token = "0x6005F74")]
		[Address(RVA = "0x2212660", Offset = "0x2212761", VA = "0x2212660", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072C1 RID: 29377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F75")]
		[Address(RVA = "0x2212680", Offset = "0x2212781", VA = "0x2212680", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F76")]
		[Address(RVA = "0x2212690", Offset = "0x2212791", VA = "0x2212690", Slot = "19")]
		public override void OnCollisionExit(Collision collision)
		{
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F77")]
		[Address(RVA = "0x2212780", Offset = "0x2212881", VA = "0x2212780", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F78")]
		[Address(RVA = "0x2212790", Offset = "0x2212891", VA = "0x2212790")]
		public HasExitedCollision()
		{
		}

		// Token: 0x0401B5D2 RID: 112082
		[Token(Token = "0x4017FFB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183420", Offset = "0x183521")]
		public SharedString tag;

		// Token: 0x0401B5D3 RID: 112083
		[Token(Token = "0x4017FFC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183460", Offset = "0x183561")]
		public SharedGameObject collidedGameObject;

		// Token: 0x0401B5D4 RID: 112084
		[Token(Token = "0x4017FFD")]
		[FieldOffset(Offset = "0x60")]
		private bool exitedCollision;
	}
}
