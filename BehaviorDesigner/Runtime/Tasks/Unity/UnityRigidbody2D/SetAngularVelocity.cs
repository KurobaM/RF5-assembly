using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001392 RID: 5010
	[Token(Token = "0x2000D5D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F3A0", Offset = "0x14F4A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F3A0", Offset = "0x14F4A1")]
	public class SetAngularVelocity : Action
	{
		// Token: 0x060074FE RID: 29950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B2")]
		[Address(RVA = "0x2997AA0", Offset = "0x2997BA1", VA = "0x2997AA0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x00028830 File Offset: 0x00026A30
		[Token(Token = "0x60061B3")]
		[Address(RVA = "0x2997BA0", Offset = "0x2997CA1", VA = "0x2997BA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007500 RID: 29952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B4")]
		[Address(RVA = "0x2997C90", Offset = "0x2997D91", VA = "0x2997C90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007501 RID: 29953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B5")]
		[Address(RVA = "0x2997CE0", Offset = "0x2997DE1", VA = "0x2997CE0")]
		public SetAngularVelocity()
		{
		}

		// Token: 0x0401B7BD RID: 112573
		[Token(Token = "0x40181DE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189020", Offset = "0x189121")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7BE RID: 112574
		[Token(Token = "0x40181DF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189060", Offset = "0x189161")]
		public SharedFloat angularVelocity;

		// Token: 0x0401B7BF RID: 112575
		[Token(Token = "0x40181E0")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7C0 RID: 112576
		[Token(Token = "0x40181E1")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
