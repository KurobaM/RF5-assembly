using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001495 RID: 5269
	[Token(Token = "0x2000E5B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155330", Offset = "0x155431")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155330", Offset = "0x155431")]
	public class SetMute : Action
	{
		// Token: 0x0600789F RID: 30879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006553")]
		[Address(RVA = "0x28DD3C0", Offset = "0x28DD4C1", VA = "0x28DD3C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078A0 RID: 30880 RVA: 0x0002A018 File Offset: 0x00028218
		[Token(Token = "0x6006554")]
		[Address(RVA = "0x28DD4C0", Offset = "0x28DD5C1", VA = "0x28DD4C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078A1 RID: 30881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006555")]
		[Address(RVA = "0x28DD5C0", Offset = "0x28DD6C1", VA = "0x28DD5C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078A2 RID: 30882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006556")]
		[Address(RVA = "0x28DD610", Offset = "0x28DD711", VA = "0x28DD610")]
		public SetMute()
		{
		}

		// Token: 0x0401BB56 RID: 113494
		[Token(Token = "0x4018554")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192030", Offset = "0x192131")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB57 RID: 113495
		[Token(Token = "0x4018555")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192070", Offset = "0x192171")]
		public SharedBool mute;

		// Token: 0x0401BB58 RID: 113496
		[Token(Token = "0x4018556")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB59 RID: 113497
		[Token(Token = "0x4018557")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
