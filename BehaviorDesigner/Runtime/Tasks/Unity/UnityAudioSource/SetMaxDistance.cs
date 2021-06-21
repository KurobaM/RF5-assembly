using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001493 RID: 5267
	[Token(Token = "0x2000E59")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155270", Offset = "0x155371")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155270", Offset = "0x155371")]
	public class SetMaxDistance : Action
	{
		// Token: 0x06007897 RID: 30871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654B")]
		[Address(RVA = "0x28DCF20", Offset = "0x28DD021", VA = "0x28DCF20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007898 RID: 30872 RVA: 0x00029FE8 File Offset: 0x000281E8
		[Token(Token = "0x600654C")]
		[Address(RVA = "0x28DD020", Offset = "0x28DD121", VA = "0x28DD020", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654D")]
		[Address(RVA = "0x28DD110", Offset = "0x28DD211", VA = "0x28DD110", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600789A RID: 30874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654E")]
		[Address(RVA = "0x28DD160", Offset = "0x28DD261", VA = "0x28DD160")]
		public SetMaxDistance()
		{
		}

		// Token: 0x0401BB4E RID: 113486
		[Token(Token = "0x401854C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191F30", Offset = "0x192031")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB4F RID: 113487
		[Token(Token = "0x401854D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191F70", Offset = "0x192071")]
		public SharedFloat maxDistance;

		// Token: 0x0401BB50 RID: 113488
		[Token(Token = "0x401854E")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB51 RID: 113489
		[Token(Token = "0x401854F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
