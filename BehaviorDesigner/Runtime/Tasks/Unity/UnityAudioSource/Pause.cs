using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200148A RID: 5258
	[Token(Token = "0x2000E50")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154F10", Offset = "0x155011")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154F10", Offset = "0x155011")]
	public class Pause : Action
	{
		// Token: 0x06007873 RID: 30835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006527")]
		[Address(RVA = "0x28DB9F0", Offset = "0x28DBAF1", VA = "0x28DB9F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007874 RID: 30836 RVA: 0x00029F10 File Offset: 0x00028110
		[Token(Token = "0x6006528")]
		[Address(RVA = "0x28DBAF0", Offset = "0x28DBBF1", VA = "0x28DBAF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007875 RID: 30837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006529")]
		[Address(RVA = "0x28DBBD0", Offset = "0x28DBCD1", VA = "0x28DBBD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007876 RID: 30838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652A")]
		[Address(RVA = "0x28DBBE0", Offset = "0x28DBCE1", VA = "0x28DBBE0")]
		public Pause()
		{
		}

		// Token: 0x0401BB2B RID: 113451
		[Token(Token = "0x4018529")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191AF0", Offset = "0x191BF1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB2C RID: 113452
		[Token(Token = "0x401852A")]
		[FieldOffset(Offset = "0x58")]
		private AudioSource audioSource;

		// Token: 0x0401BB2D RID: 113453
		[Token(Token = "0x401852B")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
