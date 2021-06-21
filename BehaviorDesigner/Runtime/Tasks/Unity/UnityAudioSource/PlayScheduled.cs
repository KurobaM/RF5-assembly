using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200148E RID: 5262
	[Token(Token = "0x2000E54")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155090", Offset = "0x155191")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155090", Offset = "0x155191")]
	public class PlayScheduled : Action
	{
		// Token: 0x06007883 RID: 30851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006537")]
		[Address(RVA = "0x28DC340", Offset = "0x28DC441", VA = "0x28DC340", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x00029F70 File Offset: 0x00028170
		[Token(Token = "0x6006538")]
		[Address(RVA = "0x28DC440", Offset = "0x28DC541", VA = "0x28DC440", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006539")]
		[Address(RVA = "0x28DC540", Offset = "0x28DC641", VA = "0x28DC540", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653A")]
		[Address(RVA = "0x28DC590", Offset = "0x28DC691", VA = "0x28DC590")]
		public PlayScheduled()
		{
		}

		// Token: 0x0401BB3A RID: 113466
		[Token(Token = "0x4018538")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191CB0", Offset = "0x191DB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB3B RID: 113467
		[Token(Token = "0x4018539")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191CF0", Offset = "0x191DF1")]
		public SharedFloat time;

		// Token: 0x0401BB3C RID: 113468
		[Token(Token = "0x401853A")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		// Token: 0x0401BB3D RID: 113469
		[Token(Token = "0x401853B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
