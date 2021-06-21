using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001490 RID: 5264
	[Token(Token = "0x2000E56")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155150", Offset = "0x155251")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155150", Offset = "0x155251")]
	public class SetIgnoreListenerVolume : Action
	{
		// Token: 0x0600788B RID: 30859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653F")]
		[Address(RVA = "0x28DCA60", Offset = "0x28DCB61", VA = "0x28DCA60", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600788C RID: 30860 RVA: 0x00029FA0 File Offset: 0x000281A0
		[Token(Token = "0x6006540")]
		[Address(RVA = "0x28DCB60", Offset = "0x28DCC61", VA = "0x28DCB60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600788D RID: 30861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006541")]
		[Address(RVA = "0x28DCC60", Offset = "0x28DCD61", VA = "0x28DCC60", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600788E RID: 30862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006542")]
		[Address(RVA = "0x28DCCB0", Offset = "0x28DCDB1", VA = "0x28DCCB0")]
		public SetIgnoreListenerVolume()
		{
		}

		// Token: 0x0401BB42 RID: 113474
		[Token(Token = "0x4018540")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191DB0", Offset = "0x191EB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB43 RID: 113475
		[Token(Token = "0x4018541")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191DF0", Offset = "0x191EF1")]
		public SharedBool ignoreListenerVolume;

		// Token: 0x0401BB44 RID: 113476
		[Token(Token = "0x4018542")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB45 RID: 113477
		[Token(Token = "0x4018543")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
