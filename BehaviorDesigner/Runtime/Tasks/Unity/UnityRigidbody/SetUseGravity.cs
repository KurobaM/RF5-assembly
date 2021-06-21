using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013B9 RID: 5049
	[Token(Token = "0x2000D84")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150290", Offset = "0x150391")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150290", Offset = "0x150391")]
	public class SetUseGravity : Action
	{
		// Token: 0x0600759A RID: 30106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624E")]
		[Address(RVA = "0x2994760", Offset = "0x2994861", VA = "0x2994760", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x00028BD8 File Offset: 0x00026DD8
		[Token(Token = "0x600624F")]
		[Address(RVA = "0x2994860", Offset = "0x2994961", VA = "0x2994860", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006250")]
		[Address(RVA = "0x2994960", Offset = "0x2994A61", VA = "0x2994960", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006251")]
		[Address(RVA = "0x29949B0", Offset = "0x2994AB1", VA = "0x29949B0")]
		public SetUseGravity()
		{
		}

		// Token: 0x0401B85F RID: 112735
		[Token(Token = "0x4018280")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A5D0", Offset = "0x18A6D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B860 RID: 112736
		[Token(Token = "0x4018281")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A610", Offset = "0x18A711")]
		public SharedBool useGravity;

		// Token: 0x0401B861 RID: 112737
		[Token(Token = "0x4018282")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B862 RID: 112738
		[Token(Token = "0x4018283")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
