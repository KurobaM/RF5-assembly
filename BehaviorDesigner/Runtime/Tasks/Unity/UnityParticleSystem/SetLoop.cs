using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013EC RID: 5100
	[Token(Token = "0x2000DB7")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1515B0", Offset = "0x1516B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1515B0", Offset = "0x1516B1")]
	public class SetLoop : Action
	{
		// Token: 0x06007649 RID: 30281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FD")]
		[Address(RVA = "0x298A4D0", Offset = "0x298A5D1", VA = "0x298A4D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x000290A0 File Offset: 0x000272A0
		[Token(Token = "0x60062FE")]
		[Address(RVA = "0x298A5D0", Offset = "0x298A6D1", VA = "0x298A5D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FF")]
		[Address(RVA = "0x298A6E0", Offset = "0x298A7E1", VA = "0x298A6E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006300")]
		[Address(RVA = "0x298A730", Offset = "0x298A831", VA = "0x298A730")]
		public SetLoop()
		{
		}

		// Token: 0x0401B915 RID: 112917
		[Token(Token = "0x4018336")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C9B0", Offset = "0x18CAB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B916 RID: 112918
		[Token(Token = "0x4018337")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C9F0", Offset = "0x18CAF1")]
		public SharedBool loop;

		// Token: 0x0401B917 RID: 112919
		[Token(Token = "0x4018338")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B918 RID: 112920
		[Token(Token = "0x4018339")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
