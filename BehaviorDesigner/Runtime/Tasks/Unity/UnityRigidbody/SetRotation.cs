using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013B8 RID: 5048
	[Token(Token = "0x2000D83")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150230", Offset = "0x150331")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150230", Offset = "0x150331")]
	public class SetRotation : Action
	{
		// Token: 0x06007596 RID: 30102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624A")]
		[Address(RVA = "0x29944D0", Offset = "0x29945D1", VA = "0x29944D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x00028BC0 File Offset: 0x00026DC0
		[Token(Token = "0x600624B")]
		[Address(RVA = "0x29945D0", Offset = "0x29946D1", VA = "0x29945D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624C")]
		[Address(RVA = "0x29946C0", Offset = "0x29947C1", VA = "0x29946C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624D")]
		[Address(RVA = "0x2994750", Offset = "0x2994851", VA = "0x2994750")]
		public SetRotation()
		{
		}

		// Token: 0x0401B85B RID: 112731
		[Token(Token = "0x401827C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A550", Offset = "0x18A651")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B85C RID: 112732
		[Token(Token = "0x401827D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A590", Offset = "0x18A691")]
		public SharedQuaternion rotation;

		// Token: 0x0401B85D RID: 112733
		[Token(Token = "0x401827E")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B85E RID: 112734
		[Token(Token = "0x401827F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
