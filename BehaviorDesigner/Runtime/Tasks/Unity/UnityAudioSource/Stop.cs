using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200149F RID: 5279
	[Token(Token = "0x2000E65")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1556F0", Offset = "0x1557F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1556F0", Offset = "0x1557F1")]
	public class Stop : Action
	{
		// Token: 0x060078C7 RID: 30919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657B")]
		[Address(RVA = "0x28DEB20", Offset = "0x28DEC21", VA = "0x28DEB20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078C8 RID: 30920 RVA: 0x0002A108 File Offset: 0x00028308
		[Token(Token = "0x600657C")]
		[Address(RVA = "0x28DEC20", Offset = "0x28DED21", VA = "0x28DEC20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078C9 RID: 30921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657D")]
		[Address(RVA = "0x28DED00", Offset = "0x28DEE01", VA = "0x28DED00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657E")]
		[Address(RVA = "0x28DED10", Offset = "0x28DEE11", VA = "0x28DED10")]
		public Stop()
		{
		}

		// Token: 0x0401BB7E RID: 113534
		[Token(Token = "0x401857C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192530", Offset = "0x192631")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB7F RID: 113535
		[Token(Token = "0x401857D")]
		[FieldOffset(Offset = "0x58")]
		private AudioSource audioSource;

		// Token: 0x0401BB80 RID: 113536
		[Token(Token = "0x401857E")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
