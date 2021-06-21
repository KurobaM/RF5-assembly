using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013DD RID: 5085
	[Token(Token = "0x2000DA8")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151010", Offset = "0x151111")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151010", Offset = "0x151111")]
	public class GetEmissionRate : Action
	{
		// Token: 0x0600760D RID: 30221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C1")]
		[Address(RVA = "0x2988320", Offset = "0x2988421", VA = "0x2988320", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x00028F38 File Offset: 0x00027138
		[Token(Token = "0x60062C2")]
		[Address(RVA = "0x2988420", Offset = "0x2988521", VA = "0x2988420", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C3")]
		[Address(RVA = "0x2988510", Offset = "0x2988611", VA = "0x2988510", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C4")]
		[Address(RVA = "0x2988560", Offset = "0x2988661", VA = "0x2988560")]
		public GetEmissionRate()
		{
		}

		// Token: 0x0401B8DF RID: 112863
		[Token(Token = "0x4018300")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C340", Offset = "0x18C441")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8E0 RID: 112864
		[Token(Token = "0x4018301")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C380", Offset = "0x18C481")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18C380", Offset = "0x18C481")]
		public SharedFloat storeResult;

		// Token: 0x0401B8E1 RID: 112865
		[Token(Token = "0x4018302")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B8E2 RID: 112866
		[Token(Token = "0x4018303")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
