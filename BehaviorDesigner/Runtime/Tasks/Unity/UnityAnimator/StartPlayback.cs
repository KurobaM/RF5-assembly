using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014BD RID: 5309
	[Token(Token = "0x2000E80")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156110", Offset = "0x156211")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156110", Offset = "0x156211")]
	public class StartPlayback : Action
	{
		// Token: 0x06007949 RID: 31049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EB")]
		[Address(RVA = "0x28D8E40", Offset = "0x28D8F41", VA = "0x28D8E40", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x0002A3D8 File Offset: 0x000285D8
		[Token(Token = "0x60065EC")]
		[Address(RVA = "0x28D8F40", Offset = "0x28D9041", VA = "0x28D8F40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065ED")]
		[Address(RVA = "0x28D9020", Offset = "0x28D9121", VA = "0x28D9020", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EE")]
		[Address(RVA = "0x28D9030", Offset = "0x28D9131", VA = "0x28D9030")]
		public StartPlayback()
		{
		}

		// Token: 0x0401BC0F RID: 113679
		[Token(Token = "0x4018601")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193950", Offset = "0x193A51")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC10 RID: 113680
		[Token(Token = "0x4018602")]
		[FieldOffset(Offset = "0x58")]
		private Animator animator;

		// Token: 0x0401BC11 RID: 113681
		[Token(Token = "0x4018603")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
