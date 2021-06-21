using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013A1 RID: 5025
	[Token(Token = "0x2000D6C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F990", Offset = "0x14FA91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F990", Offset = "0x14FA91")]
	public class GetAngularVelocity : Action
	{
		// Token: 0x0600753A RID: 30010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061EE")]
		[Address(RVA = "0x2990DA0", Offset = "0x2990EA1", VA = "0x2990DA0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x00028998 File Offset: 0x00026B98
		[Token(Token = "0x60061EF")]
		[Address(RVA = "0x2990EA0", Offset = "0x2990FA1", VA = "0x2990EA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F0")]
		[Address(RVA = "0x2990F90", Offset = "0x2991091", VA = "0x2990F90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F1")]
		[Address(RVA = "0x2991020", Offset = "0x2991121", VA = "0x2991020")]
		public GetAngularVelocity()
		{
		}

		// Token: 0x0401B801 RID: 112641
		[Token(Token = "0x4018222")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1899B0", Offset = "0x189AB1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B802 RID: 112642
		[Token(Token = "0x4018223")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1899F0", Offset = "0x189AF1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1899F0", Offset = "0x189AF1")]
		public SharedVector3 storeValue;

		// Token: 0x0401B803 RID: 112643
		[Token(Token = "0x4018224")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B804 RID: 112644
		[Token(Token = "0x4018225")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
