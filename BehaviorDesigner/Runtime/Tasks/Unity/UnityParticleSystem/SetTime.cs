using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013F5 RID: 5109
	[Token(Token = "0x2000DC0")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151910", Offset = "0x151A11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151910", Offset = "0x151A11")]
	public class SetTime : Action
	{
		// Token: 0x0600766D RID: 30317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006321")]
		[Address(RVA = "0x298BBC0", Offset = "0x298BCC1", VA = "0x298BBC0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x00029178 File Offset: 0x00027378
		[Token(Token = "0x6006322")]
		[Address(RVA = "0x298BCC0", Offset = "0x298BDC1", VA = "0x298BCC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006323")]
		[Address(RVA = "0x298BDB0", Offset = "0x298BEB1", VA = "0x298BDB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006324")]
		[Address(RVA = "0x298BE00", Offset = "0x298BF01", VA = "0x298BE00")]
		public SetTime()
		{
		}

		// Token: 0x0401B939 RID: 112953
		[Token(Token = "0x401835A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CE30", Offset = "0x18CF31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B93A RID: 112954
		[Token(Token = "0x401835B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CE70", Offset = "0x18CF71")]
		public SharedFloat time;

		// Token: 0x0401B93B RID: 112955
		[Token(Token = "0x401835C")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B93C RID: 112956
		[Token(Token = "0x401835D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
