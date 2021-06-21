using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200147D RID: 5245
	[Token(Token = "0x2000E43")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154A30", Offset = "0x154B31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154A30", Offset = "0x154B31")]
	public class GetIgnoreListenerPause : Action
	{
		// Token: 0x0600783F RID: 30783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F3")]
		[Address(RVA = "0x28D9BD0", Offset = "0x28D9CD1", VA = "0x28D9BD0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x00029DD8 File Offset: 0x00027FD8
		[Token(Token = "0x60064F4")]
		[Address(RVA = "0x28D9CD0", Offset = "0x28D9DD1", VA = "0x28D9CD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F5")]
		[Address(RVA = "0x28D9DD0", Offset = "0x28D9ED1", VA = "0x28D9DD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F6")]
		[Address(RVA = "0x28D9E20", Offset = "0x28D9F21", VA = "0x28D9E20")]
		public GetIgnoreListenerPause()
		{
		}

		// Token: 0x0401BAF8 RID: 113400
		[Token(Token = "0x40184F6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1913F0", Offset = "0x1914F1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAF9 RID: 113401
		[Token(Token = "0x40184F7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191430", Offset = "0x191531")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x191430", Offset = "0x191531")]
		public SharedBool storeValue;

		// Token: 0x0401BAFA RID: 113402
		[Token(Token = "0x40184F8")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BAFB RID: 113403
		[Token(Token = "0x40184F9")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
