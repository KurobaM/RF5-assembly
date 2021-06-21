using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013E0 RID: 5088
	[Token(Token = "0x2000DAB")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151130", Offset = "0x151231")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151130", Offset = "0x151231")]
	public class GetMaxParticles : Action
	{
		// Token: 0x06007619 RID: 30233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062CD")]
		[Address(RVA = "0x2988A70", Offset = "0x2988B71", VA = "0x2988A70", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x00028F80 File Offset: 0x00027180
		[Token(Token = "0x60062CE")]
		[Address(RVA = "0x2988B70", Offset = "0x2988C71", VA = "0x2988B70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062CF")]
		[Address(RVA = "0x2988C90", Offset = "0x2988D91", VA = "0x2988C90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D0")]
		[Address(RVA = "0x2988CE0", Offset = "0x2988DE1", VA = "0x2988CE0")]
		public GetMaxParticles()
		{
		}

		// Token: 0x0401B8EB RID: 112875
		[Token(Token = "0x401830C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C4F0", Offset = "0x18C5F1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8EC RID: 112876
		[Token(Token = "0x401830D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C530", Offset = "0x18C631")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18C530", Offset = "0x18C631")]
		public SharedFloat storeResult;

		// Token: 0x0401B8ED RID: 112877
		[Token(Token = "0x401830E")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B8EE RID: 112878
		[Token(Token = "0x401830F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
