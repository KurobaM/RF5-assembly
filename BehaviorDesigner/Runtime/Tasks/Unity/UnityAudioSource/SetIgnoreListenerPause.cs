using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x02001491 RID: 5265
	[Token(Token = "0x2000E57")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1551B0", Offset = "0x1552B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1551B0", Offset = "0x1552B1")]
	public class SetIgnoreListenerPause : Action
	{
		// Token: 0x0600788F RID: 30863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006543")]
		[Address(RVA = "0x28DC800", Offset = "0x28DC901", VA = "0x28DC800", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x00029FB8 File Offset: 0x000281B8
		[Token(Token = "0x6006544")]
		[Address(RVA = "0x28DC900", Offset = "0x28DCA01", VA = "0x28DC900", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006545")]
		[Address(RVA = "0x28DCA00", Offset = "0x28DCB01", VA = "0x28DCA00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006546")]
		[Address(RVA = "0x28DCA50", Offset = "0x28DCB51", VA = "0x28DCA50")]
		public SetIgnoreListenerPause()
		{
		}

		// Token: 0x0401BB46 RID: 113478
		[Token(Token = "0x4018544")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191E30", Offset = "0x191F31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB47 RID: 113479
		[Token(Token = "0x4018545")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191E70", Offset = "0x191F71")]
		public SharedBool ignoreListenerPause;

		// Token: 0x0401BB48 RID: 113480
		[Token(Token = "0x4018546")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB49 RID: 113481
		[Token(Token = "0x4018547")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
