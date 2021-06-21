using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001489 RID: 5257
	[Token(Token = "0x2000E4F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154EB0", Offset = "0x154FB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154EB0", Offset = "0x154FB1")]
	public class IsPlaying : Conditional
	{
		// Token: 0x0600786F RID: 30831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006523")]
		[Address(RVA = "0x28DB7F0", Offset = "0x28DB8F1", VA = "0x28DB7F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x00029EF8 File Offset: 0x000280F8
		[Token(Token = "0x6006524")]
		[Address(RVA = "0x28DB8F0", Offset = "0x28DB9F1", VA = "0x28DB8F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007871 RID: 30833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006525")]
		[Address(RVA = "0x28DB9D0", Offset = "0x28DBAD1", VA = "0x28DB9D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007872 RID: 30834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006526")]
		[Address(RVA = "0x28DB9E0", Offset = "0x28DBAE1", VA = "0x28DB9E0")]
		public IsPlaying()
		{
		}

		// Token: 0x0401BB28 RID: 113448
		[Token(Token = "0x4018526")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191AB0", Offset = "0x191BB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB29 RID: 113449
		[Token(Token = "0x4018527")]
		[FieldOffset(Offset = "0x58")]
		private AudioSource audioSource;

		// Token: 0x0401BB2A RID: 113450
		[Token(Token = "0x4018528")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
