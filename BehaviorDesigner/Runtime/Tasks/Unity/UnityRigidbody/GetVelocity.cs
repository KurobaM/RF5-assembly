using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013AA RID: 5034
	[Token(Token = "0x2000D75")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FCF0", Offset = "0x14FDF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FCF0", Offset = "0x14FDF1")]
	public class GetVelocity : Action
	{
		// Token: 0x0600755E RID: 30046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006212")]
		[Address(RVA = "0x29923A0", Offset = "0x29924A1", VA = "0x29923A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600755F RID: 30047 RVA: 0x00028A70 File Offset: 0x00026C70
		[Token(Token = "0x6006213")]
		[Address(RVA = "0x29924A0", Offset = "0x29925A1", VA = "0x29924A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006214")]
		[Address(RVA = "0x2992590", Offset = "0x2992691", VA = "0x2992590", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006215")]
		[Address(RVA = "0x2992620", Offset = "0x2992721", VA = "0x2992620")]
		public GetVelocity()
		{
		}

		// Token: 0x0401B825 RID: 112677
		[Token(Token = "0x4018246")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189EC0", Offset = "0x189FC1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B826 RID: 112678
		[Token(Token = "0x4018247")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189F00", Offset = "0x18A001")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x189F00", Offset = "0x18A001")]
		public SharedVector3 storeValue;

		// Token: 0x0401B827 RID: 112679
		[Token(Token = "0x4018248")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B828 RID: 112680
		[Token(Token = "0x4018249")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
