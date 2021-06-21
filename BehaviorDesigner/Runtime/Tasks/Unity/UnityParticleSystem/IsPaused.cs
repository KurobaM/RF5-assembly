using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013E5 RID: 5093
	[Token(Token = "0x2000DB0")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151310", Offset = "0x151411")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151310", Offset = "0x151411")]
	public class IsPaused : Conditional
	{
		// Token: 0x0600762D RID: 30253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E1")]
		[Address(RVA = "0x2989610", Offset = "0x2989711", VA = "0x2989610", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00028FF8 File Offset: 0x000271F8
		[Token(Token = "0x60062E2")]
		[Address(RVA = "0x2989710", Offset = "0x2989811", VA = "0x2989710", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E3")]
		[Address(RVA = "0x29897F0", Offset = "0x29898F1", VA = "0x29897F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E4")]
		[Address(RVA = "0x2989800", Offset = "0x2989901", VA = "0x2989800")]
		public IsPaused()
		{
		}

		// Token: 0x0401B8FE RID: 112894
		[Token(Token = "0x401831F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C770", Offset = "0x18C871")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8FF RID: 112895
		[Token(Token = "0x4018320")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B900 RID: 112896
		[Token(Token = "0x4018321")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
