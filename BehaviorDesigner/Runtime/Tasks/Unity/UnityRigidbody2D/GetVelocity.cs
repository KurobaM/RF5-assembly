using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x0200138C RID: 5004
	[Token(Token = "0x2000D57")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F160", Offset = "0x14F261")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F160", Offset = "0x14F261")]
	public class GetVelocity : Action
	{
		// Token: 0x060074E6 RID: 29926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619A")]
		[Address(RVA = "0x2996CE0", Offset = "0x2996DE1", VA = "0x2996CE0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x000287A0 File Offset: 0x000269A0
		[Token(Token = "0x600619B")]
		[Address(RVA = "0x2996DE0", Offset = "0x2996EE1", VA = "0x2996DE0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619C")]
		[Address(RVA = "0x2996ED0", Offset = "0x2996FD1", VA = "0x2996ED0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619D")]
		[Address(RVA = "0x2996F60", Offset = "0x2997061", VA = "0x2996F60")]
		public GetVelocity()
		{
		}

		// Token: 0x0401B7A7 RID: 112551
		[Token(Token = "0x40181C8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188D90", Offset = "0x188E91")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7A8 RID: 112552
		[Token(Token = "0x40181C9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188DD0", Offset = "0x188ED1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188DD0", Offset = "0x188ED1")]
		public SharedVector2 storeValue;

		// Token: 0x0401B7A9 RID: 112553
		[Token(Token = "0x40181CA")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7AA RID: 112554
		[Token(Token = "0x40181CB")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
