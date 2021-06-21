using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200149C RID: 5276
	[Token(Token = "0x2000E62")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1555D0", Offset = "0x1556D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1555D0", Offset = "0x1556D1")]
	public class SetTime : Action
	{
		// Token: 0x060078BB RID: 30907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656F")]
		[Address(RVA = "0x28DE460", Offset = "0x28DE561", VA = "0x28DE460", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x0002A0C0 File Offset: 0x000282C0
		[Token(Token = "0x6006570")]
		[Address(RVA = "0x28DE560", Offset = "0x28DE661", VA = "0x28DE560", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006571")]
		[Address(RVA = "0x28DE650", Offset = "0x28DE751", VA = "0x28DE650", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006572")]
		[Address(RVA = "0x28DE6A0", Offset = "0x28DE7A1", VA = "0x28DE6A0")]
		public SetTime()
		{
		}

		// Token: 0x0401BB72 RID: 113522
		[Token(Token = "0x4018570")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1923B0", Offset = "0x1924B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB73 RID: 113523
		[Token(Token = "0x4018571")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1923F0", Offset = "0x1924F1")]
		public SharedFloat time;

		// Token: 0x0401BB74 RID: 113524
		[Token(Token = "0x4018572")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB75 RID: 113525
		[Token(Token = "0x4018573")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
