using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001480 RID: 5248
	[Token(Token = "0x2000E46")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154B50", Offset = "0x154C51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154B50", Offset = "0x154C51")]
	public class GetMaxDistance : Action
	{
		// Token: 0x0600784B RID: 30795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FF")]
		[Address(RVA = "0x28DA2F0", Offset = "0x28DA3F1", VA = "0x28DA2F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x00029E20 File Offset: 0x00028020
		[Token(Token = "0x6006500")]
		[Address(RVA = "0x28DA3F0", Offset = "0x28DA4F1", VA = "0x28DA3F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006501")]
		[Address(RVA = "0x28DA4E0", Offset = "0x28DA5E1", VA = "0x28DA4E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006502")]
		[Address(RVA = "0x28DA530", Offset = "0x28DA631", VA = "0x28DA530")]
		public GetMaxDistance()
		{
		}

		// Token: 0x0401BB04 RID: 113412
		[Token(Token = "0x4018502")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1915A0", Offset = "0x1916A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB05 RID: 113413
		[Token(Token = "0x4018503")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1915E0", Offset = "0x1916E1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1915E0", Offset = "0x1916E1")]
		public SharedFloat storeValue;

		// Token: 0x0401BB06 RID: 113414
		[Token(Token = "0x4018504")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB07 RID: 113415
		[Token(Token = "0x4018505")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
