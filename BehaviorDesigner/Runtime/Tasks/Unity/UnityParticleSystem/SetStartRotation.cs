using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013F2 RID: 5106
	[Token(Token = "0x2000DBD")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1517F0", Offset = "0x1518F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1517F0", Offset = "0x1518F1")]
	public class SetStartRotation : Action
	{
		// Token: 0x06007661 RID: 30305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006315")]
		[Address(RVA = "0x298B410", Offset = "0x298B511", VA = "0x298B410", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x00029130 File Offset: 0x00027330
		[Token(Token = "0x6006316")]
		[Address(RVA = "0x298B510", Offset = "0x298B611", VA = "0x298B510", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006317")]
		[Address(RVA = "0x298B640", Offset = "0x298B741", VA = "0x298B640", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006318")]
		[Address(RVA = "0x298B690", Offset = "0x298B791", VA = "0x298B690")]
		public SetStartRotation()
		{
		}

		// Token: 0x0401B92D RID: 112941
		[Token(Token = "0x401834E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CCB0", Offset = "0x18CDB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B92E RID: 112942
		[Token(Token = "0x401834F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CCF0", Offset = "0x18CDF1")]
		public SharedFloat startRotation;

		// Token: 0x0401B92F RID: 112943
		[Token(Token = "0x4018350")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B930 RID: 112944
		[Token(Token = "0x4018351")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
