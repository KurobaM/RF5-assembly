using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200148F RID: 5263
	[Token(Token = "0x2000E55")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1550F0", Offset = "0x1551F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1550F0", Offset = "0x1551F1")]
	public class SetAudioClip : Action
	{
		// Token: 0x06007887 RID: 30855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653B")]
		[Address(RVA = "0x28DC5D0", Offset = "0x28DC6D1", VA = "0x28DC5D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x00029F88 File Offset: 0x00028188
		[Token(Token = "0x600653C")]
		[Address(RVA = "0x28DC6D0", Offset = "0x28DC7D1", VA = "0x28DC6D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653D")]
		[Address(RVA = "0x28DC7B0", Offset = "0x28DC8B1", VA = "0x28DC7B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600788A RID: 30858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653E")]
		[Address(RVA = "0x28DC7F0", Offset = "0x28DC8F1", VA = "0x28DC7F0")]
		public SetAudioClip()
		{
		}

		// Token: 0x0401BB3E RID: 113470
		[Token(Token = "0x401853C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191D30", Offset = "0x191E31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB3F RID: 113471
		[Token(Token = "0x401853D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191D70", Offset = "0x191E71")]
		public AudioClip audioClip;

		// Token: 0x0401BB40 RID: 113472
		[Token(Token = "0x401853E")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB41 RID: 113473
		[Token(Token = "0x401853F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
