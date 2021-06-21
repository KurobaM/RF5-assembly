using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200149A RID: 5274
	[Token(Token = "0x2000E60")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155510", Offset = "0x155611")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155510", Offset = "0x155611")]
	public class SetScheduledStartTime : Action
	{
		// Token: 0x060078B3 RID: 30899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006567")]
		[Address(RVA = "0x28DDF80", Offset = "0x28DE081", VA = "0x28DDF80", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078B4 RID: 30900 RVA: 0x0002A090 File Offset: 0x00028290
		[Token(Token = "0x6006568")]
		[Address(RVA = "0x28DE080", Offset = "0x28DE181", VA = "0x28DE080", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078B5 RID: 30901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006569")]
		[Address(RVA = "0x28DE180", Offset = "0x28DE281", VA = "0x28DE180", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656A")]
		[Address(RVA = "0x28DE1D0", Offset = "0x28DE2D1", VA = "0x28DE1D0")]
		public SetScheduledStartTime()
		{
		}

		// Token: 0x0401BB6A RID: 113514
		[Token(Token = "0x4018568")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1922B0", Offset = "0x1923B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB6B RID: 113515
		[Token(Token = "0x4018569")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1922F0", Offset = "0x1923F1")]
		public SharedFloat time;

		// Token: 0x0401BB6C RID: 113516
		[Token(Token = "0x401856A")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB6D RID: 113517
		[Token(Token = "0x401856B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
