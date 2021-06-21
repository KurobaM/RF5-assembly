using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200147E RID: 5246
	[Token(Token = "0x2000E44")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154A90", Offset = "0x154B91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154A90", Offset = "0x154B91")]
	public class GetIgnoreListenerVolume : Action
	{
		// Token: 0x06007843 RID: 30787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F7")]
		[Address(RVA = "0x28D9E30", Offset = "0x28D9F31", VA = "0x28D9E30", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x00029DF0 File Offset: 0x00027FF0
		[Token(Token = "0x60064F8")]
		[Address(RVA = "0x28D9F30", Offset = "0x28DA031", VA = "0x28D9F30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F9")]
		[Address(RVA = "0x28DA030", Offset = "0x28DA131", VA = "0x28DA030", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FA")]
		[Address(RVA = "0x28DA080", Offset = "0x28DA181", VA = "0x28DA080")]
		public GetIgnoreListenerVolume()
		{
		}

		// Token: 0x0401BAFC RID: 113404
		[Token(Token = "0x40184FA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191480", Offset = "0x191581")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAFD RID: 113405
		[Token(Token = "0x40184FB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1914C0", Offset = "0x1915C1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1914C0", Offset = "0x1915C1")]
		public SharedBool storeValue;

		// Token: 0x0401BAFE RID: 113406
		[Token(Token = "0x40184FC")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BAFF RID: 113407
		[Token(Token = "0x40184FD")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
