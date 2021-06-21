using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200147F RID: 5247
	[Token(Token = "0x2000E45")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154AF0", Offset = "0x154BF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154AF0", Offset = "0x154BF1")]
	public class GetLoop : Action
	{
		// Token: 0x06007847 RID: 30791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FB")]
		[Address(RVA = "0x28DA090", Offset = "0x28DA191", VA = "0x28DA090", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x00029E08 File Offset: 0x00028008
		[Token(Token = "0x60064FC")]
		[Address(RVA = "0x28DA190", Offset = "0x28DA291", VA = "0x28DA190", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FD")]
		[Address(RVA = "0x28DA290", Offset = "0x28DA391", VA = "0x28DA290", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FE")]
		[Address(RVA = "0x28DA2E0", Offset = "0x28DA3E1", VA = "0x28DA2E0")]
		public GetLoop()
		{
		}

		// Token: 0x0401BB00 RID: 113408
		[Token(Token = "0x40184FE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191510", Offset = "0x191611")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB01 RID: 113409
		[Token(Token = "0x40184FF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191550", Offset = "0x191651")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x191550", Offset = "0x191651")]
		public SharedBool storeValue;

		// Token: 0x0401BB02 RID: 113410
		[Token(Token = "0x4018500")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB03 RID: 113411
		[Token(Token = "0x4018501")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
