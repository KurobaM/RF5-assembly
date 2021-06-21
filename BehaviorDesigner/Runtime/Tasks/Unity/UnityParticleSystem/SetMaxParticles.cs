using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013ED RID: 5101
	[Token(Token = "0x2000DB8")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151610", Offset = "0x151711")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151610", Offset = "0x151711")]
	public class SetMaxParticles : Action
	{
		// Token: 0x0600764D RID: 30285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006301")]
		[Address(RVA = "0x298A740", Offset = "0x298A841", VA = "0x298A740", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x000290B8 File Offset: 0x000272B8
		[Token(Token = "0x6006302")]
		[Address(RVA = "0x298A840", Offset = "0x298A941", VA = "0x298A840", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006303")]
		[Address(RVA = "0x298A950", Offset = "0x298AA51", VA = "0x298A950", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006304")]
		[Address(RVA = "0x298A9A0", Offset = "0x298AAA1", VA = "0x298A9A0")]
		public SetMaxParticles()
		{
		}

		// Token: 0x0401B919 RID: 112921
		[Token(Token = "0x401833A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CA30", Offset = "0x18CB31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B91A RID: 112922
		[Token(Token = "0x401833B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CA70", Offset = "0x18CB71")]
		public SharedInt maxParticles;

		// Token: 0x0401B91B RID: 112923
		[Token(Token = "0x401833C")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B91C RID: 112924
		[Token(Token = "0x401833D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
