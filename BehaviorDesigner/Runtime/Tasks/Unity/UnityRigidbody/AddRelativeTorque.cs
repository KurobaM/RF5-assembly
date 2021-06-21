using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x0200139E RID: 5022
	[Token(Token = "0x2000D69")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F870", Offset = "0x14F971")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F870", Offset = "0x14F971")]
	public class AddRelativeTorque : Action
	{
		// Token: 0x0600752E RID: 29998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E2")]
		[Address(RVA = "0x2990670", Offset = "0x2990771", VA = "0x2990670", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x00028950 File Offset: 0x00026B50
		[Token(Token = "0x60061E3")]
		[Address(RVA = "0x2990770", Offset = "0x2990871", VA = "0x2990770", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E4")]
		[Address(RVA = "0x29907F0", Offset = "0x29908F1", VA = "0x29907F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E5")]
		[Address(RVA = "0x2990890", Offset = "0x2990991", VA = "0x2990890")]
		public AddRelativeTorque()
		{
		}

		// Token: 0x0401B7F3 RID: 112627
		[Token(Token = "0x4018214")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1897A0", Offset = "0x1898A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7F4 RID: 112628
		[Token(Token = "0x4018215")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1897E0", Offset = "0x1898E1")]
		public SharedVector3 torque;

		// Token: 0x0401B7F5 RID: 112629
		[Token(Token = "0x4018216")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189820", Offset = "0x189921")]
		public ForceMode forceMode;

		// Token: 0x0401B7F6 RID: 112630
		[Token(Token = "0x4018217")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody rigidbody;

		// Token: 0x0401B7F7 RID: 112631
		[Token(Token = "0x4018218")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
