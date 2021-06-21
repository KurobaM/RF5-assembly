using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014CB RID: 5323
	[Token(Token = "0x2000E8E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156650", Offset = "0x156751")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156650", Offset = "0x156751")]
	public class SetAnimatePhysics : Action
	{
		// Token: 0x06007982 RID: 31106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006624")]
		[Address(RVA = "0x28D3D90", Offset = "0x28D3E91", VA = "0x28D3D90", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x0002A528 File Offset: 0x00028728
		[Token(Token = "0x6006625")]
		[Address(RVA = "0x28D3E90", Offset = "0x28D3F91", VA = "0x28D3E90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006626")]
		[Address(RVA = "0x28D3F90", Offset = "0x28D4091", VA = "0x28D3F90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006627")]
		[Address(RVA = "0x28D4000", Offset = "0x28D4101", VA = "0x28D4000")]
		public SetAnimatePhysics()
		{
		}

		// Token: 0x0401BC50 RID: 113744
		[Token(Token = "0x4018642")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194260", Offset = "0x194361")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC51 RID: 113745
		[Token(Token = "0x4018643")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1942A0", Offset = "0x1943A1")]
		public SharedBool animatePhysics;

		// Token: 0x0401BC52 RID: 113746
		[Token(Token = "0x4018644")]
		[FieldOffset(Offset = "0x60")]
		private Animation animation;

		// Token: 0x0401BC53 RID: 113747
		[Token(Token = "0x4018645")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
