using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013E9 RID: 5097
	[Token(Token = "0x2000DB4")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151490", Offset = "0x151591")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151490", Offset = "0x151591")]
	public class Play : Action
	{
		// Token: 0x0600763D RID: 30269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F1")]
		[Address(RVA = "0x2989E10", Offset = "0x2989F11", VA = "0x2989E10", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00029058 File Offset: 0x00027258
		[Token(Token = "0x60062F2")]
		[Address(RVA = "0x2989F10", Offset = "0x298A011", VA = "0x2989F10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F3")]
		[Address(RVA = "0x2989FF0", Offset = "0x298A0F1", VA = "0x2989FF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F4")]
		[Address(RVA = "0x298A000", Offset = "0x298A101", VA = "0x298A000")]
		public Play()
		{
		}

		// Token: 0x0401B90A RID: 112906
		[Token(Token = "0x401832B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C870", Offset = "0x18C971")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B90B RID: 112907
		[Token(Token = "0x401832C")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B90C RID: 112908
		[Token(Token = "0x401832D")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
