using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAudioSource
{
	// Token: 0x0200148B RID: 5259
	[Token(Token = "0x2000E51")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154F70", Offset = "0x155071")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154F70", Offset = "0x155071")]
	public class Play : Action
	{
		// Token: 0x06007877 RID: 30839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652B")]
		[Address(RVA = "0x28DBBF0", Offset = "0x28DBCF1", VA = "0x28DBBF0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007878 RID: 30840 RVA: 0x00029F28 File Offset: 0x00028128
		[Token(Token = "0x600652C")]
		[Address(RVA = "0x28DBCF0", Offset = "0x28DBDF1", VA = "0x28DBCF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652D")]
		[Address(RVA = "0x28DBDD0", Offset = "0x28DBED1", VA = "0x28DBDD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652E")]
		[Address(RVA = "0x28DBDE0", Offset = "0x28DBEE1", VA = "0x28DBDE0")]
		public Play()
		{
		}

		// Token: 0x0401BB2E RID: 113454
		[Token(Token = "0x401852C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191B30", Offset = "0x191C31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB2F RID: 113455
		[Token(Token = "0x401852D")]
		[FieldOffset(Offset = "0x58")]
		private AudioSource audioSource;

		// Token: 0x0401BB30 RID: 113456
		[Token(Token = "0x401852E")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
