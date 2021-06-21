using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001487 RID: 5255
	[Token(Token = "0x2000E4D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154DF0", Offset = "0x154EF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154DF0", Offset = "0x154EF1")]
	public class GetTimeSamples : Action
	{
		// Token: 0x06007867 RID: 30823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651B")]
		[Address(RVA = "0x28DB340", Offset = "0x28DB441", VA = "0x28DB340", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x00029EC8 File Offset: 0x000280C8
		[Token(Token = "0x600651C")]
		[Address(RVA = "0x28DB440", Offset = "0x28DB541", VA = "0x28DB440", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651D")]
		[Address(RVA = "0x28DB540", Offset = "0x28DB641", VA = "0x28DB540", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651E")]
		[Address(RVA = "0x28DB590", Offset = "0x28DB691", VA = "0x28DB590")]
		public GetTimeSamples()
		{
		}

		// Token: 0x0401BB20 RID: 113440
		[Token(Token = "0x401851E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191990", Offset = "0x191A91")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB21 RID: 113441
		[Token(Token = "0x401851F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1919D0", Offset = "0x191AD1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1919D0", Offset = "0x191AD1")]
		public SharedFloat storeValue;

		// Token: 0x0401BB22 RID: 113442
		[Token(Token = "0x4018520")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB23 RID: 113443
		[Token(Token = "0x4018521")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
