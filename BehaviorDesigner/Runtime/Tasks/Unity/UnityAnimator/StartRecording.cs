using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014BE RID: 5310
	[Token(Token = "0x2000E81")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156170", Offset = "0x156271")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156170", Offset = "0x156271")]
	public class StartRecording : Action
	{
		// Token: 0x0600794D RID: 31053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065EF")]
		[Address(RVA = "0x28D9040", Offset = "0x28D9141", VA = "0x28D9040", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x0002A3F0 File Offset: 0x000285F0
		[Token(Token = "0x60065F0")]
		[Address(RVA = "0x28D9140", Offset = "0x28D9241", VA = "0x28D9140", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F1")]
		[Address(RVA = "0x28D9220", Offset = "0x28D9321", VA = "0x28D9220", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F2")]
		[Address(RVA = "0x28D9250", Offset = "0x28D9351", VA = "0x28D9250")]
		public StartRecording()
		{
		}

		// Token: 0x0401BC12 RID: 113682
		[Token(Token = "0x4018604")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193990", Offset = "0x193A91")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC13 RID: 113683
		[Token(Token = "0x4018605")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1939D0", Offset = "0x193AD1")]
		public int frameCount;

		// Token: 0x0401BC14 RID: 113684
		[Token(Token = "0x4018606")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BC15 RID: 113685
		[Token(Token = "0x4018607")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
