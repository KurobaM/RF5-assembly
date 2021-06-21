using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013F1 RID: 5105
	[Token(Token = "0x2000DBC")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151790", Offset = "0x151891")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151790", Offset = "0x151891")]
	public class SetStartLifetime : Action
	{
		// Token: 0x0600765D RID: 30301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006311")]
		[Address(RVA = "0x298B180", Offset = "0x298B281", VA = "0x298B180", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00029118 File Offset: 0x00027318
		[Token(Token = "0x6006312")]
		[Address(RVA = "0x298B280", Offset = "0x298B381", VA = "0x298B280", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006313")]
		[Address(RVA = "0x298B3B0", Offset = "0x298B4B1", VA = "0x298B3B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006314")]
		[Address(RVA = "0x298B400", Offset = "0x298B501", VA = "0x298B400")]
		public SetStartLifetime()
		{
		}

		// Token: 0x0401B929 RID: 112937
		[Token(Token = "0x401834A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CC30", Offset = "0x18CD31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B92A RID: 112938
		[Token(Token = "0x401834B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CC70", Offset = "0x18CD71")]
		public SharedFloat startLifetime;

		// Token: 0x0401B92B RID: 112939
		[Token(Token = "0x401834C")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B92C RID: 112940
		[Token(Token = "0x401834D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
