using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014AB RID: 5291
	[Token(Token = "0x2000E71")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155B70", Offset = "0x155C71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155B70", Offset = "0x155C71")]
	public class InterruptMatchTarget : Action
	{
		// Token: 0x060078F6 RID: 30966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065AA")]
		[Address(RVA = "0x28D5F90", Offset = "0x28D6091", VA = "0x28D5F90", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078F7 RID: 30967 RVA: 0x0002A228 File Offset: 0x00028428
		[Token(Token = "0x60065AB")]
		[Address(RVA = "0x28D6090", Offset = "0x28D6191", VA = "0x28D6090", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065AC")]
		[Address(RVA = "0x28D6170", Offset = "0x28D6271", VA = "0x28D6170", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065AD")]
		[Address(RVA = "0x28D61B0", Offset = "0x28D62B1", VA = "0x28D61B0")]
		public InterruptMatchTarget()
		{
		}

		// Token: 0x0401BBB2 RID: 113586
		[Token(Token = "0x40185B0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192D50", Offset = "0x192E51")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBB3 RID: 113587
		[Token(Token = "0x40185B1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192D90", Offset = "0x192E91")]
		public bool completeMatch;

		// Token: 0x0401BBB4 RID: 113588
		[Token(Token = "0x40185B2")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BBB5 RID: 113589
		[Token(Token = "0x40185B3")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
