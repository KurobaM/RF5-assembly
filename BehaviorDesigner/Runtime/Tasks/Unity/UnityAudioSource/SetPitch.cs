using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001496 RID: 5270
	[Token(Token = "0x2000E5C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155390", Offset = "0x155491")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155390", Offset = "0x155491")]
	public class SetPitch : Action
	{
		// Token: 0x060078A3 RID: 30883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006557")]
		[Address(RVA = "0x28DD620", Offset = "0x28DD721", VA = "0x28DD620", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078A4 RID: 30884 RVA: 0x0002A030 File Offset: 0x00028230
		[Token(Token = "0x6006558")]
		[Address(RVA = "0x28DD720", Offset = "0x28DD821", VA = "0x28DD720", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006559")]
		[Address(RVA = "0x28DD810", Offset = "0x28DD911", VA = "0x28DD810", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655A")]
		[Address(RVA = "0x28DD860", Offset = "0x28DD961", VA = "0x28DD860")]
		public SetPitch()
		{
		}

		// Token: 0x0401BB5A RID: 113498
		[Token(Token = "0x4018558")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1920B0", Offset = "0x1921B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB5B RID: 113499
		[Token(Token = "0x4018559")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1920F0", Offset = "0x1921F1")]
		public SharedFloat pitch;

		// Token: 0x0401BB5C RID: 113500
		[Token(Token = "0x401855A")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB5D RID: 113501
		[Token(Token = "0x401855B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
