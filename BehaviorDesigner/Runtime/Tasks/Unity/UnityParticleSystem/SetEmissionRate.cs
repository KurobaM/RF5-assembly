using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013EA RID: 5098
	[Token(Token = "0x2000DB5")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1514F0", Offset = "0x1515F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1514F0", Offset = "0x1515F1")]
	public class SetEmissionRate : Action
	{
		// Token: 0x06007641 RID: 30273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F5")]
		[Address(RVA = "0x298A010", Offset = "0x298A111", VA = "0x298A010", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00029070 File Offset: 0x00027270
		[Token(Token = "0x60062F6")]
		[Address(RVA = "0x298A110", Offset = "0x298A211", VA = "0x298A110", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F7")]
		[Address(RVA = "0x298A200", Offset = "0x298A301", VA = "0x298A200", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F8")]
		[Address(RVA = "0x298A250", Offset = "0x298A351", VA = "0x298A250")]
		public SetEmissionRate()
		{
		}

		// Token: 0x0401B90D RID: 112909
		[Token(Token = "0x401832E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C8B0", Offset = "0x18C9B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B90E RID: 112910
		[Token(Token = "0x401832F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C8F0", Offset = "0x18C9F1")]
		public SharedFloat emissionRate;

		// Token: 0x0401B90F RID: 112911
		[Token(Token = "0x4018330")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B910 RID: 112912
		[Token(Token = "0x4018331")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
