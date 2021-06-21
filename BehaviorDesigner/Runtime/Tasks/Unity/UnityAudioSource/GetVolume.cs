using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001488 RID: 5256
	[Token(Token = "0x2000E4E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154E50", Offset = "0x154F51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154E50", Offset = "0x154F51")]
	public class GetVolume : Action
	{
		// Token: 0x0600786B RID: 30827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651F")]
		[Address(RVA = "0x28DB5A0", Offset = "0x28DB6A1", VA = "0x28DB5A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x00029EE0 File Offset: 0x000280E0
		[Token(Token = "0x6006520")]
		[Address(RVA = "0x28DB6A0", Offset = "0x28DB7A1", VA = "0x28DB6A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006521")]
		[Address(RVA = "0x28DB790", Offset = "0x28DB891", VA = "0x28DB790", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006522")]
		[Address(RVA = "0x28DB7E0", Offset = "0x28DB8E1", VA = "0x28DB7E0")]
		public GetVolume()
		{
		}

		// Token: 0x0401BB24 RID: 113444
		[Token(Token = "0x4018522")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191A20", Offset = "0x191B21")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB25 RID: 113445
		[Token(Token = "0x4018523")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191A60", Offset = "0x191B61")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x191A60", Offset = "0x191B61")]
		public SharedFloat storeValue;

		// Token: 0x0401BB26 RID: 113446
		[Token(Token = "0x4018524")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB27 RID: 113447
		[Token(Token = "0x4018525")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
