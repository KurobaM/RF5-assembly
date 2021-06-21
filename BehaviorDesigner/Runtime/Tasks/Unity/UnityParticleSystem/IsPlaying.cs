using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013E6 RID: 5094
	[Token(Token = "0x2000DB1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151370", Offset = "0x151471")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151370", Offset = "0x151471")]
	public class IsPlaying : Conditional
	{
		// Token: 0x06007631 RID: 30257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E5")]
		[Address(RVA = "0x2989810", Offset = "0x2989911", VA = "0x2989810", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x00029010 File Offset: 0x00027210
		[Token(Token = "0x60062E6")]
		[Address(RVA = "0x2989910", Offset = "0x2989A11", VA = "0x2989910", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E7")]
		[Address(RVA = "0x29899F0", Offset = "0x2989AF1", VA = "0x29899F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E8")]
		[Address(RVA = "0x2989A00", Offset = "0x2989B01", VA = "0x2989A00")]
		public IsPlaying()
		{
		}

		// Token: 0x0401B901 RID: 112897
		[Token(Token = "0x4018322")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C7B0", Offset = "0x18C8B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B902 RID: 112898
		[Token(Token = "0x4018323")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B903 RID: 112899
		[Token(Token = "0x4018324")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
