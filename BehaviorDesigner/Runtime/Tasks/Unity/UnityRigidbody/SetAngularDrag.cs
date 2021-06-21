using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013AF RID: 5039
	[Token(Token = "0x2000D7A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FED0", Offset = "0x14FFD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FED0", Offset = "0x14FFD1")]
	public class SetAngularDrag : Action
	{
		// Token: 0x06007572 RID: 30066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006226")]
		[Address(RVA = "0x2992F50", Offset = "0x2993051", VA = "0x2992F50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x00028AE8 File Offset: 0x00026CE8
		[Token(Token = "0x6006227")]
		[Address(RVA = "0x2993050", Offset = "0x2993151", VA = "0x2993050", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006228")]
		[Address(RVA = "0x2993140", Offset = "0x2993241", VA = "0x2993140", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006229")]
		[Address(RVA = "0x2993190", Offset = "0x2993291", VA = "0x2993190")]
		public SetAngularDrag()
		{
		}

		// Token: 0x0401B837 RID: 112695
		[Token(Token = "0x4018258")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A0D0", Offset = "0x18A1D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B838 RID: 112696
		[Token(Token = "0x4018259")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A110", Offset = "0x18A211")]
		public SharedFloat angularDrag;

		// Token: 0x0401B839 RID: 112697
		[Token(Token = "0x401825A")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B83A RID: 112698
		[Token(Token = "0x401825B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
