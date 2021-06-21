using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200149D RID: 5277
	[Token(Token = "0x2000E63")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155630", Offset = "0x155731")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155630", Offset = "0x155731")]
	public class SetVelocityUpdateMode : Action
	{
		// Token: 0x060078BF RID: 30911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006573")]
		[Address(RVA = "0x28DE6B0", Offset = "0x28DE7B1", VA = "0x28DE6B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x0002A0D8 File Offset: 0x000282D8
		[Token(Token = "0x6006574")]
		[Address(RVA = "0x28DE7B0", Offset = "0x28DE8B1", VA = "0x28DE7B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078C1 RID: 30913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006575")]
		[Address(RVA = "0x28DE890", Offset = "0x28DE991", VA = "0x28DE890", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078C2 RID: 30914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006576")]
		[Address(RVA = "0x28DE8C0", Offset = "0x28DE9C1", VA = "0x28DE8C0")]
		public SetVelocityUpdateMode()
		{
		}

		// Token: 0x0401BB76 RID: 113526
		[Token(Token = "0x4018574")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192430", Offset = "0x192531")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB77 RID: 113527
		[Token(Token = "0x4018575")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192470", Offset = "0x192571")]
		public AudioVelocityUpdateMode velocityUpdateMode;

		// Token: 0x0401BB78 RID: 113528
		[Token(Token = "0x4018576")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB79 RID: 113529
		[Token(Token = "0x4018577")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
