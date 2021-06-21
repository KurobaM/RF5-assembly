using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001498 RID: 5272
	[Token(Token = "0x2000E5E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155450", Offset = "0x155551")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155450", Offset = "0x155551")]
	public class SetRolloffMode : Action
	{
		// Token: 0x060078AB RID: 30891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655F")]
		[Address(RVA = "0x28DDAD0", Offset = "0x28DDBD1", VA = "0x28DDAD0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x0002A060 File Offset: 0x00028260
		[Token(Token = "0x6006560")]
		[Address(RVA = "0x28DDBD0", Offset = "0x28DDCD1", VA = "0x28DDBD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078AD RID: 30893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006561")]
		[Address(RVA = "0x28DDCB0", Offset = "0x28DDDB1", VA = "0x28DDCB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078AE RID: 30894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006562")]
		[Address(RVA = "0x28DDCE0", Offset = "0x28DDDE1", VA = "0x28DDCE0")]
		public SetRolloffMode()
		{
		}

		// Token: 0x0401BB62 RID: 113506
		[Token(Token = "0x4018560")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1921B0", Offset = "0x1922B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB63 RID: 113507
		[Token(Token = "0x4018561")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1921F0", Offset = "0x1922F1")]
		public AudioRolloffMode rolloffMode;

		// Token: 0x0401BB64 RID: 113508
		[Token(Token = "0x4018562")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB65 RID: 113509
		[Token(Token = "0x4018563")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
