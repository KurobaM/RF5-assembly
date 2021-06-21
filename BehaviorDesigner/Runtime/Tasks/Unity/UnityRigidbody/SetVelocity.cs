using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013BA RID: 5050
	[Token(Token = "0x2000D85")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1502F0", Offset = "0x1503F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1502F0", Offset = "0x1503F1")]
	public class SetVelocity : Action
	{
		// Token: 0x0600759E RID: 30110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006252")]
		[Address(RVA = "0x29949C0", Offset = "0x2994AC1", VA = "0x29949C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x00028BF0 File Offset: 0x00026DF0
		[Token(Token = "0x6006253")]
		[Address(RVA = "0x2994AC0", Offset = "0x2994BC1", VA = "0x2994AC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006254")]
		[Address(RVA = "0x2994BB0", Offset = "0x2994CB1", VA = "0x2994BB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006255")]
		[Address(RVA = "0x2994C40", Offset = "0x2994D41", VA = "0x2994C40")]
		public SetVelocity()
		{
		}

		// Token: 0x0401B863 RID: 112739
		[Token(Token = "0x4018284")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A650", Offset = "0x18A751")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B864 RID: 112740
		[Token(Token = "0x4018285")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A690", Offset = "0x18A791")]
		public SharedVector3 velocity;

		// Token: 0x0401B865 RID: 112741
		[Token(Token = "0x4018286")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B866 RID: 112742
		[Token(Token = "0x4018287")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
