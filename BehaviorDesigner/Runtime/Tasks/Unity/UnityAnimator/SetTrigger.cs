using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014BC RID: 5308
	[Token(Token = "0x2000E7F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1560B0", Offset = "0x1561B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1560B0", Offset = "0x1561B1")]
	public class SetTrigger : Action
	{
		// Token: 0x06007945 RID: 31045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E7")]
		[Address(RVA = "0x28D8BC0", Offset = "0x28D8CC1", VA = "0x28D8BC0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x0002A3C0 File Offset: 0x000285C0
		[Token(Token = "0x60065E8")]
		[Address(RVA = "0x28D8CC0", Offset = "0x28D8DC1", VA = "0x28D8CC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E9")]
		[Address(RVA = "0x28D8DC0", Offset = "0x28D8EC1", VA = "0x28D8DC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EA")]
		[Address(RVA = "0x28D8E30", Offset = "0x28D8F31", VA = "0x28D8E30")]
		public SetTrigger()
		{
		}

		// Token: 0x0401BC0B RID: 113675
		[Token(Token = "0x40185FD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1938D0", Offset = "0x1939D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC0C RID: 113676
		[Token(Token = "0x40185FE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193910", Offset = "0x193A11")]
		public SharedString paramaterName;

		// Token: 0x0401BC0D RID: 113677
		[Token(Token = "0x40185FF")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BC0E RID: 113678
		[Token(Token = "0x4018600")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
