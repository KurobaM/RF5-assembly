using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013B7 RID: 5047
	[Token(Token = "0x2000D82")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1501D0", Offset = "0x1502D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1501D0", Offset = "0x1502D1")]
	public class SetPosition : Action
	{
		// Token: 0x06007592 RID: 30098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006246")]
		[Address(RVA = "0x2994240", Offset = "0x2994341", VA = "0x2994240", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00028BA8 File Offset: 0x00026DA8
		[Token(Token = "0x6006247")]
		[Address(RVA = "0x2994340", Offset = "0x2994441", VA = "0x2994340", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006248")]
		[Address(RVA = "0x2994430", Offset = "0x2994531", VA = "0x2994430", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006249")]
		[Address(RVA = "0x29944C0", Offset = "0x29945C1", VA = "0x29944C0")]
		public SetPosition()
		{
		}

		// Token: 0x0401B857 RID: 112727
		[Token(Token = "0x4018278")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A4D0", Offset = "0x18A5D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B858 RID: 112728
		[Token(Token = "0x4018279")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A510", Offset = "0x18A611")]
		public SharedVector3 position;

		// Token: 0x0401B859 RID: 112729
		[Token(Token = "0x401827A")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B85A RID: 112730
		[Token(Token = "0x401827B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
