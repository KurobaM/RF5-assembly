using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200149E RID: 5278
	[Token(Token = "0x2000E64")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155690", Offset = "0x155791")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155690", Offset = "0x155791")]
	public class SetVolume : Action
	{
		// Token: 0x060078C3 RID: 30915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006577")]
		[Address(RVA = "0x28DE8D0", Offset = "0x28DE9D1", VA = "0x28DE8D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078C4 RID: 30916 RVA: 0x0002A0F0 File Offset: 0x000282F0
		[Token(Token = "0x6006578")]
		[Address(RVA = "0x28DE9D0", Offset = "0x28DEAD1", VA = "0x28DE9D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078C5 RID: 30917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006579")]
		[Address(RVA = "0x28DEAC0", Offset = "0x28DEBC1", VA = "0x28DEAC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078C6 RID: 30918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657A")]
		[Address(RVA = "0x28DEB10", Offset = "0x28DEC11", VA = "0x28DEB10")]
		public SetVolume()
		{
		}

		// Token: 0x0401BB7A RID: 113530
		[Token(Token = "0x4018578")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1924B0", Offset = "0x1925B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB7B RID: 113531
		[Token(Token = "0x4018579")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1924F0", Offset = "0x1925F1")]
		public SharedFloat volume;

		// Token: 0x0401BB7C RID: 113532
		[Token(Token = "0x401857A")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB7D RID: 113533
		[Token(Token = "0x401857B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
