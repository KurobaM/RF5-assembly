using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200148D RID: 5261
	[Token(Token = "0x2000E53")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155030", Offset = "0x155131")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155030", Offset = "0x155131")]
	public class PlayOneShot : Action
	{
		// Token: 0x0600787F RID: 30847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006533")]
		[Address(RVA = "0x28DC070", Offset = "0x28DC171", VA = "0x28DC070", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x00029F58 File Offset: 0x00028158
		[Token(Token = "0x6006534")]
		[Address(RVA = "0x28DC170", Offset = "0x28DC271", VA = "0x28DC170", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006535")]
		[Address(RVA = "0x28DC2B0", Offset = "0x28DC3B1", VA = "0x28DC2B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006536")]
		[Address(RVA = "0x28DC300", Offset = "0x28DC401", VA = "0x28DC300")]
		public PlayOneShot()
		{
		}

		// Token: 0x0401BB35 RID: 113461
		[Token(Token = "0x4018533")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191BF0", Offset = "0x191CF1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB36 RID: 113462
		[Token(Token = "0x4018534")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191C30", Offset = "0x191D31")]
		public SharedObject clip;

		// Token: 0x0401BB37 RID: 113463
		[Token(Token = "0x4018535")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191C70", Offset = "0x191D71")]
		public SharedFloat volumeScale;

		// Token: 0x0401BB38 RID: 113464
		[Token(Token = "0x4018536")]
		[FieldOffset(Offset = "0x68")]
		private AudioSource audioSource;

		// Token: 0x0401BB39 RID: 113465
		[Token(Token = "0x4018537")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
