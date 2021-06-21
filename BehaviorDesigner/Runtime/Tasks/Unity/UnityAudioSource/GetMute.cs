using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001482 RID: 5250
	[Token(Token = "0x2000E48")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154C10", Offset = "0x154D11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154C10", Offset = "0x154D11")]
	public class GetMute : Action
	{
		// Token: 0x06007853 RID: 30803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006507")]
		[Address(RVA = "0x28DA790", Offset = "0x28DA891", VA = "0x28DA790", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x00029E50 File Offset: 0x00028050
		[Token(Token = "0x6006508")]
		[Address(RVA = "0x28DA890", Offset = "0x28DA991", VA = "0x28DA890", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006509")]
		[Address(RVA = "0x28DA990", Offset = "0x28DAA91", VA = "0x28DA990", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600650A")]
		[Address(RVA = "0x28DA9E0", Offset = "0x28DAAE1", VA = "0x28DA9E0")]
		public GetMute()
		{
		}

		// Token: 0x0401BB0C RID: 113420
		[Token(Token = "0x401850A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1916C0", Offset = "0x1917C1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB0D RID: 113421
		[Token(Token = "0x401850B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191700", Offset = "0x191801")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x191700", Offset = "0x191801")]
		public SharedBool storeValue;

		// Token: 0x0401BB0E RID: 113422
		[Token(Token = "0x401850C")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB0F RID: 113423
		[Token(Token = "0x401850D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
