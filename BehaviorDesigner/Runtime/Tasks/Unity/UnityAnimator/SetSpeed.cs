using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014BB RID: 5307
	[Token(Token = "0x2000E7E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156050", Offset = "0x156151")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156050", Offset = "0x156151")]
	public class SetSpeed : Action
	{
		// Token: 0x06007941 RID: 31041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E3")]
		[Address(RVA = "0x28D8970", Offset = "0x28D8A71", VA = "0x28D8970", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x0002A3A8 File Offset: 0x000285A8
		[Token(Token = "0x60065E4")]
		[Address(RVA = "0x28D8A70", Offset = "0x28D8B71", VA = "0x28D8A70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007943 RID: 31043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E5")]
		[Address(RVA = "0x28D8B60", Offset = "0x28D8C61", VA = "0x28D8B60", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007944 RID: 31044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065E6")]
		[Address(RVA = "0x28D8BB0", Offset = "0x28D8CB1", VA = "0x28D8BB0")]
		public SetSpeed()
		{
		}

		// Token: 0x0401BC07 RID: 113671
		[Token(Token = "0x40185F9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193850", Offset = "0x193951")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC08 RID: 113672
		[Token(Token = "0x40185FA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193890", Offset = "0x193991")]
		public SharedFloat speed;

		// Token: 0x0401BC09 RID: 113673
		[Token(Token = "0x40185FB")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BC0A RID: 113674
		[Token(Token = "0x40185FC")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
