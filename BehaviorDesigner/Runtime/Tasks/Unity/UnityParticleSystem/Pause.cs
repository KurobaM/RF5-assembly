using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013E8 RID: 5096
	[Token(Token = "0x2000DB3")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151430", Offset = "0x151531")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151430", Offset = "0x151531")]
	public class Pause : Action
	{
		// Token: 0x06007639 RID: 30265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062ED")]
		[Address(RVA = "0x2989C10", Offset = "0x2989D11", VA = "0x2989C10", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x00029040 File Offset: 0x00027240
		[Token(Token = "0x60062EE")]
		[Address(RVA = "0x2989D10", Offset = "0x2989E11", VA = "0x2989D10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EF")]
		[Address(RVA = "0x2989DF0", Offset = "0x2989EF1", VA = "0x2989DF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F0")]
		[Address(RVA = "0x2989E00", Offset = "0x2989F01", VA = "0x2989E00")]
		public Pause()
		{
		}

		// Token: 0x0401B907 RID: 112903
		[Token(Token = "0x4018328")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C830", Offset = "0x18C931")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B908 RID: 112904
		[Token(Token = "0x4018329")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B909 RID: 112905
		[Token(Token = "0x401832A")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
