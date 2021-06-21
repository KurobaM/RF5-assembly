using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200148C RID: 5260
	[Token(Token = "0x2000E52")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154FD0", Offset = "0x1550D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154FD0", Offset = "0x1550D1")]
	public class PlayDelayed : Action
	{
		// Token: 0x0600787B RID: 30843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652F")]
		[Address(RVA = "0x28DBDF0", Offset = "0x28DBEF1", VA = "0x28DBDF0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x00029F40 File Offset: 0x00028140
		[Token(Token = "0x6006530")]
		[Address(RVA = "0x28DBEF0", Offset = "0x28DBFF1", VA = "0x28DBEF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006531")]
		[Address(RVA = "0x28DBFE0", Offset = "0x28DC0E1", VA = "0x28DBFE0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006532")]
		[Address(RVA = "0x28DC030", Offset = "0x28DC131", VA = "0x28DC030")]
		public PlayDelayed()
		{
		}

		// Token: 0x0401BB31 RID: 113457
		[Token(Token = "0x401852F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191B70", Offset = "0x191C71")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB32 RID: 113458
		[Token(Token = "0x4018530")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191BB0", Offset = "0x191CB1")]
		public SharedFloat delay;

		// Token: 0x0401BB33 RID: 113459
		[Token(Token = "0x4018531")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB34 RID: 113460
		[Token(Token = "0x4018532")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
