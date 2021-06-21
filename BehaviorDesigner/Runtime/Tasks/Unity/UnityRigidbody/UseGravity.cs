using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013BC RID: 5052
	[Token(Token = "0x2000D87")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1503B0", Offset = "0x1504B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1503B0", Offset = "0x1504B1")]
	public class UseGravity : Conditional
	{
		// Token: 0x060075A6 RID: 30118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600625A")]
		[Address(RVA = "0x2994E50", Offset = "0x2994F51", VA = "0x2994E50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x00028C20 File Offset: 0x00026E20
		[Token(Token = "0x600625B")]
		[Address(RVA = "0x2994F50", Offset = "0x2995051", VA = "0x2994F50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600625C")]
		[Address(RVA = "0x2995030", Offset = "0x2995131", VA = "0x2995030", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600625D")]
		[Address(RVA = "0x2995040", Offset = "0x2995141", VA = "0x2995040")]
		public UseGravity()
		{
		}

		// Token: 0x0401B86A RID: 112746
		[Token(Token = "0x401828B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A710", Offset = "0x18A811")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B86B RID: 112747
		[Token(Token = "0x401828C")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		// Token: 0x0401B86C RID: 112748
		[Token(Token = "0x401828D")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
