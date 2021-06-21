using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013E2 RID: 5090
	[Token(Token = "0x2000DAD")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1511F0", Offset = "0x1512F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1511F0", Offset = "0x1512F1")]
	public class GetPlaybackSpeed : Action
	{
		// Token: 0x06007621 RID: 30241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D5")]
		[Address(RVA = "0x2988F50", Offset = "0x2989051", VA = "0x2988F50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x00028FB0 File Offset: 0x000271B0
		[Token(Token = "0x60062D6")]
		[Address(RVA = "0x2989050", Offset = "0x2989151", VA = "0x2989050", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D7")]
		[Address(RVA = "0x2989160", Offset = "0x2989261", VA = "0x2989160", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062D8")]
		[Address(RVA = "0x29891B0", Offset = "0x29892B1", VA = "0x29891B0")]
		public GetPlaybackSpeed()
		{
		}

		// Token: 0x0401B8F3 RID: 112883
		[Token(Token = "0x4018314")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C610", Offset = "0x18C711")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B8F4 RID: 112884
		[Token(Token = "0x4018315")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C650", Offset = "0x18C751")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18C650", Offset = "0x18C751")]
		public SharedFloat storeResult;

		// Token: 0x0401B8F5 RID: 112885
		[Token(Token = "0x4018316")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B8F6 RID: 112886
		[Token(Token = "0x4018317")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
