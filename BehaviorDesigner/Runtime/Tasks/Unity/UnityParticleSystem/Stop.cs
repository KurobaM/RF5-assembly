using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013F7 RID: 5111
	[Token(Token = "0x2000DC2")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1519D0", Offset = "0x151AD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1519D0", Offset = "0x151AD1")]
	public class Stop : Action
	{
		// Token: 0x06007675 RID: 30325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006329")]
		[Address(RVA = "0x298C060", Offset = "0x298C161", VA = "0x298C060", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x000291A8 File Offset: 0x000273A8
		[Token(Token = "0x600632A")]
		[Address(RVA = "0x298C160", Offset = "0x298C261", VA = "0x298C160", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600632B")]
		[Address(RVA = "0x298C240", Offset = "0x298C341", VA = "0x298C240", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600632C")]
		[Address(RVA = "0x298C250", Offset = "0x298C351", VA = "0x298C250")]
		public Stop()
		{
		}

		// Token: 0x0401B941 RID: 112961
		[Token(Token = "0x4018362")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18CF30", Offset = "0x18D031")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B942 RID: 112962
		[Token(Token = "0x4018363")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B943 RID: 112963
		[Token(Token = "0x4018364")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
