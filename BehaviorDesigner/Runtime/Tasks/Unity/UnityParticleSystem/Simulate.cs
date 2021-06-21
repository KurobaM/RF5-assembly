using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013F6 RID: 5110
	[Token(Token = "0x2000DC1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x151970", Offset = "0x151A71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x151970", Offset = "0x151A71")]
	public class Simulate : Action
	{
		// Token: 0x06007671 RID: 30321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006325")]
		[Address(RVA = "0x298BE10", Offset = "0x298BF11", VA = "0x298BE10", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x00029190 File Offset: 0x00027390
		[Token(Token = "0x6006326")]
		[Address(RVA = "0x298BF10", Offset = "0x298C011", VA = "0x298BF10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006327")]
		[Address(RVA = "0x298C000", Offset = "0x298C101", VA = "0x298C000", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006328")]
		[Address(RVA = "0x298C050", Offset = "0x298C151", VA = "0x298C050")]
		public Simulate()
		{
		}

		// Token: 0x0401B93D RID: 112957
		[Token(Token = "0x401835E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CEB0", Offset = "0x18CFB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B93E RID: 112958
		[Token(Token = "0x401835F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CEF0", Offset = "0x18CFF1")]
		public SharedFloat time;

		// Token: 0x0401B93F RID: 112959
		[Token(Token = "0x4018360")]
		[FieldOffset(Offset = "0x60")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B940 RID: 112960
		[Token(Token = "0x4018361")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
