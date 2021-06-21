using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x0200139F RID: 5023
	[Token(Token = "0x2000D6A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F8D0", Offset = "0x14F9D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F8D0", Offset = "0x14F9D1")]
	public class AddTorque : Action
	{
		// Token: 0x06007532 RID: 30002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E6")]
		[Address(RVA = "0x29908A0", Offset = "0x29909A1", VA = "0x29908A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x00028968 File Offset: 0x00026B68
		[Token(Token = "0x60061E7")]
		[Address(RVA = "0x29909A0", Offset = "0x2990AA1", VA = "0x29909A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E8")]
		[Address(RVA = "0x2990AA0", Offset = "0x2990BA1", VA = "0x2990AA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E9")]
		[Address(RVA = "0x2990B40", Offset = "0x2990C41", VA = "0x2990B40")]
		public AddTorque()
		{
		}

		// Token: 0x0401B7F8 RID: 112632
		[Token(Token = "0x4018219")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189860", Offset = "0x189961")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7F9 RID: 112633
		[Token(Token = "0x401821A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1898A0", Offset = "0x1899A1")]
		public SharedVector3 torque;

		// Token: 0x0401B7FA RID: 112634
		[Token(Token = "0x401821B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1898E0", Offset = "0x1899E1")]
		public ForceMode forceMode;

		// Token: 0x0401B7FB RID: 112635
		[Token(Token = "0x401821C")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody rigidbody;

		// Token: 0x0401B7FC RID: 112636
		[Token(Token = "0x401821D")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
