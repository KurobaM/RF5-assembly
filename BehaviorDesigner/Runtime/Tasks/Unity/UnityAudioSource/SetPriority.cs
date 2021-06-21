using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001497 RID: 5271
	[Token(Token = "0x2000E5D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1553F0", Offset = "0x1554F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1553F0", Offset = "0x1554F1")]
	public class SetPriority : Action
	{
		// Token: 0x060078A7 RID: 30887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655B")]
		[Address(RVA = "0x28DD870", Offset = "0x28DD971", VA = "0x28DD870", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x0002A048 File Offset: 0x00028248
		[Token(Token = "0x600655C")]
		[Address(RVA = "0x28DD970", Offset = "0x28DDA71", VA = "0x28DD970", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655D")]
		[Address(RVA = "0x28DDA70", Offset = "0x28DDB71", VA = "0x28DDA70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655E")]
		[Address(RVA = "0x28DDAC0", Offset = "0x28DDBC1", VA = "0x28DDAC0")]
		public SetPriority()
		{
		}

		// Token: 0x0401BB5E RID: 113502
		[Token(Token = "0x401855C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192130", Offset = "0x192231")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB5F RID: 113503
		[Token(Token = "0x401855D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192170", Offset = "0x192271")]
		public SharedInt priority;

		// Token: 0x0401BB60 RID: 113504
		[Token(Token = "0x401855E")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB61 RID: 113505
		[Token(Token = "0x401855F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
