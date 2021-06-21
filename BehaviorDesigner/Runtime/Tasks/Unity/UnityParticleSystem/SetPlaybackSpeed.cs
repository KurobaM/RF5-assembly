using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013EE RID: 5102
	[Token(Token = "0x2000DB9")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151670", Offset = "0x151771")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151670", Offset = "0x151771")]
	public class SetPlaybackSpeed : Action
	{
		// Token: 0x06007651 RID: 30289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006305")]
		[Address(RVA = "0x298A9B0", Offset = "0x298AAB1", VA = "0x298A9B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x000290D0 File Offset: 0x000272D0
		[Token(Token = "0x6006306")]
		[Address(RVA = "0x298AAB0", Offset = "0x298ABB1", VA = "0x298AAB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006307")]
		[Address(RVA = "0x298ABC0", Offset = "0x298ACC1", VA = "0x298ABC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006308")]
		[Address(RVA = "0x298AC10", Offset = "0x298AD11", VA = "0x298AC10")]
		public SetPlaybackSpeed()
		{
		}

		// Token: 0x0401B91D RID: 112925
		[Token(Token = "0x401833E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CAB0", Offset = "0x18CBB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B91E RID: 112926
		[Token(Token = "0x401833F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CAF0", Offset = "0x18CBF1")]
		public SharedFloat playbackSpeed;

		// Token: 0x0401B91F RID: 112927
		[Token(Token = "0x4018340")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B920 RID: 112928
		[Token(Token = "0x4018341")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
