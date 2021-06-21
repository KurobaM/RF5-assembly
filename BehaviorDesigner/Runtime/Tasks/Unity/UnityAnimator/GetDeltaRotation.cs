using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014A4 RID: 5284
	[Token(Token = "0x2000E6A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1558D0", Offset = "0x1559D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1558D0", Offset = "0x1559D1")]
	public class GetDeltaRotation : Action
	{
		// Token: 0x060078DB RID: 30939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658F")]
		[Address(RVA = "0x28D4F60", Offset = "0x28D5061", VA = "0x28D4F60", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078DC RID: 30940 RVA: 0x0002A180 File Offset: 0x00028380
		[Token(Token = "0x6006590")]
		[Address(RVA = "0x28D5060", Offset = "0x28D5161", VA = "0x28D5060", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006591")]
		[Address(RVA = "0x28D5150", Offset = "0x28D5251", VA = "0x28D5150", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006592")]
		[Address(RVA = "0x28D51E0", Offset = "0x28D52E1", VA = "0x28D51E0")]
		public GetDeltaRotation()
		{
		}

		// Token: 0x0401BB95 RID: 113557
		[Token(Token = "0x4018593")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1928A0", Offset = "0x1929A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB96 RID: 113558
		[Token(Token = "0x4018594")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1928E0", Offset = "0x1929E1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1928E0", Offset = "0x1929E1")]
		public SharedQuaternion storeValue;

		// Token: 0x0401BB97 RID: 113559
		[Token(Token = "0x4018595")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BB98 RID: 113560
		[Token(Token = "0x4018596")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
