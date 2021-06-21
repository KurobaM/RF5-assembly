using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001486 RID: 5254
	[Token(Token = "0x2000E4C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154D90", Offset = "0x154E91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154D90", Offset = "0x154E91")]
	public class GetTime : Action
	{
		// Token: 0x06007863 RID: 30819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006517")]
		[Address(RVA = "0x28DB0F0", Offset = "0x28DB1F1", VA = "0x28DB0F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x00029EB0 File Offset: 0x000280B0
		[Token(Token = "0x6006518")]
		[Address(RVA = "0x28DB1F0", Offset = "0x28DB2F1", VA = "0x28DB1F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006519")]
		[Address(RVA = "0x28DB2E0", Offset = "0x28DB3E1", VA = "0x28DB2E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651A")]
		[Address(RVA = "0x28DB330", Offset = "0x28DB431", VA = "0x28DB330")]
		public GetTime()
		{
		}

		// Token: 0x0401BB1C RID: 113436
		[Token(Token = "0x401851A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191900", Offset = "0x191A01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB1D RID: 113437
		[Token(Token = "0x401851B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191940", Offset = "0x191A41")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x191940", Offset = "0x191A41")]
		public SharedFloat storeValue;

		// Token: 0x0401BB1E RID: 113438
		[Token(Token = "0x401851C")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB1F RID: 113439
		[Token(Token = "0x401851D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
