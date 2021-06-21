using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013F4 RID: 5108
	[Token(Token = "0x2000DBF")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1518B0", Offset = "0x1519B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1518B0", Offset = "0x1519B1")]
	public class SetStartSpeed : Action
	{
		// Token: 0x06007669 RID: 30313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631D")]
		[Address(RVA = "0x298B930", Offset = "0x298BA31", VA = "0x298B930", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x00029160 File Offset: 0x00027360
		[Token(Token = "0x600631E")]
		[Address(RVA = "0x298BA30", Offset = "0x298BB31", VA = "0x298BA30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600631F")]
		[Address(RVA = "0x298BB60", Offset = "0x298BC61", VA = "0x298BB60", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006320")]
		[Address(RVA = "0x298BBB0", Offset = "0x298BCB1", VA = "0x298BBB0")]
		public SetStartSpeed()
		{
		}

		// Token: 0x0401B935 RID: 112949
		[Token(Token = "0x4018356")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CDB0", Offset = "0x18CEB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B936 RID: 112950
		[Token(Token = "0x4018357")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CDF0", Offset = "0x18CEF1")]
		public SharedFloat startSpeed;

		// Token: 0x0401B937 RID: 112951
		[Token(Token = "0x4018358")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B938 RID: 112952
		[Token(Token = "0x4018359")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
