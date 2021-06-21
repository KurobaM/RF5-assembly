using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013E1 RID: 5089
	[Token(Token = "0x2000DAC")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151190", Offset = "0x151291")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151190", Offset = "0x151291")]
	public class GetParticleCount : Action
	{
		// Token: 0x0600761D RID: 30237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D1")]
		[Address(RVA = "0x2988CF0", Offset = "0x2988DF1", VA = "0x2988CF0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x00028F98 File Offset: 0x00027198
		[Token(Token = "0x60062D2")]
		[Address(RVA = "0x2988DF0", Offset = "0x2988EF1", VA = "0x2988DF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D3")]
		[Address(RVA = "0x2988EF0", Offset = "0x2988FF1", VA = "0x2988EF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D4")]
		[Address(RVA = "0x2988F40", Offset = "0x2989041", VA = "0x2988F40")]
		public GetParticleCount()
		{
		}

		// Token: 0x0401B8EF RID: 112879
		[Token(Token = "0x4018310")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C580", Offset = "0x18C681")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8F0 RID: 112880
		[Token(Token = "0x4018311")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C5C0", Offset = "0x18C6C1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18C5C0", Offset = "0x18C6C1")]
		public SharedFloat storeResult;

		// Token: 0x0401B8F1 RID: 112881
		[Token(Token = "0x4018312")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B8F2 RID: 112882
		[Token(Token = "0x4018313")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
