using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001494 RID: 5268
	[Token(Token = "0x2000E5A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1552D0", Offset = "0x1553D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1552D0", Offset = "0x1553D1")]
	public class SetMinDistance : Action
	{
		// Token: 0x0600789B RID: 30875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600654F")]
		[Address(RVA = "0x28DD170", Offset = "0x28DD271", VA = "0x28DD170", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600789C RID: 30876 RVA: 0x0002A000 File Offset: 0x00028200
		[Token(Token = "0x6006550")]
		[Address(RVA = "0x28DD270", Offset = "0x28DD371", VA = "0x28DD270", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006551")]
		[Address(RVA = "0x28DD360", Offset = "0x28DD461", VA = "0x28DD360", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600789E RID: 30878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006552")]
		[Address(RVA = "0x28DD3B0", Offset = "0x28DD4B1", VA = "0x28DD3B0")]
		public SetMinDistance()
		{
		}

		// Token: 0x0401BB52 RID: 113490
		[Token(Token = "0x4018550")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191FB0", Offset = "0x1920B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB53 RID: 113491
		[Token(Token = "0x4018551")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191FF0", Offset = "0x1920F1")]
		public SharedFloat minDistance;

		// Token: 0x0401BB54 RID: 113492
		[Token(Token = "0x4018552")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB55 RID: 113493
		[Token(Token = "0x4018553")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
