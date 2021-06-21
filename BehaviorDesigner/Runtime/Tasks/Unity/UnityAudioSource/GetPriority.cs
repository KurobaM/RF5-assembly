using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001484 RID: 5252
	[Token(Token = "0x2000E4A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154CD0", Offset = "0x154DD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154CD0", Offset = "0x154DD1")]
	public class GetPriority : Action
	{
		// Token: 0x0600785B RID: 30811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650F")]
		[Address(RVA = "0x28DAC40", Offset = "0x28DAD41", VA = "0x28DAC40", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x00029E80 File Offset: 0x00028080
		[Token(Token = "0x6006510")]
		[Address(RVA = "0x28DAD40", Offset = "0x28DAE41", VA = "0x28DAD40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006511")]
		[Address(RVA = "0x28DAE40", Offset = "0x28DAF41", VA = "0x28DAE40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006512")]
		[Address(RVA = "0x28DAE90", Offset = "0x28DAF91", VA = "0x28DAE90")]
		public GetPriority()
		{
		}

		// Token: 0x0401BB14 RID: 113428
		[Token(Token = "0x4018512")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1917E0", Offset = "0x1918E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB15 RID: 113429
		[Token(Token = "0x4018513")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191820", Offset = "0x191921")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x191820", Offset = "0x191921")]
		public SharedInt storeValue;

		// Token: 0x0401BB16 RID: 113430
		[Token(Token = "0x4018514")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB17 RID: 113431
		[Token(Token = "0x4018515")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
