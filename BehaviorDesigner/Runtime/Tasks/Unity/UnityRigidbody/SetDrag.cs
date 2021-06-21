using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013B3 RID: 5043
	[Token(Token = "0x2000D7E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150050", Offset = "0x150151")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150050", Offset = "0x150151")]
	public class SetDrag : Action
	{
		// Token: 0x06007582 RID: 30082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006236")]
		[Address(RVA = "0x29938E0", Offset = "0x29939E1", VA = "0x29938E0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x00028B48 File Offset: 0x00026D48
		[Token(Token = "0x6006237")]
		[Address(RVA = "0x29939E0", Offset = "0x2993AE1", VA = "0x29939E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006238")]
		[Address(RVA = "0x2993AD0", Offset = "0x2993BD1", VA = "0x2993AD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006239")]
		[Address(RVA = "0x2993B20", Offset = "0x2993C21", VA = "0x2993B20")]
		public SetDrag()
		{
		}

		// Token: 0x0401B847 RID: 112711
		[Token(Token = "0x4018268")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A2D0", Offset = "0x18A3D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B848 RID: 112712
		[Token(Token = "0x4018269")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A310", Offset = "0x18A411")]
		public SharedFloat drag;

		// Token: 0x0401B849 RID: 112713
		[Token(Token = "0x401826A")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B84A RID: 112714
		[Token(Token = "0x401826B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
