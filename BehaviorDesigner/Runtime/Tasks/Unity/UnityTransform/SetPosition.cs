using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001340 RID: 4928
	[Token(Token = "0x2000D0B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D4E0", Offset = "0x14D5E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D4E0", Offset = "0x14D5E1")]
	public class SetPosition : Action
	{
		// Token: 0x060073E5 RID: 29669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006099")]
		[Address(RVA = "0x299ED90", Offset = "0x299EE91", VA = "0x299ED90", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073E6 RID: 29670 RVA: 0x00028080 File Offset: 0x00026280
		[Token(Token = "0x600609A")]
		[Address(RVA = "0x299EE90", Offset = "0x299EF91", VA = "0x299EE90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073E7 RID: 29671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609B")]
		[Address(RVA = "0x299EF80", Offset = "0x299F081", VA = "0x299EF80", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073E8 RID: 29672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609C")]
		[Address(RVA = "0x299F010", Offset = "0x299F111", VA = "0x299F010")]
		public SetPosition()
		{
		}

		// Token: 0x0401B6D8 RID: 112344
		[Token(Token = "0x40180F9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186530", Offset = "0x186631")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6D9 RID: 112345
		[Token(Token = "0x40180FA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186570", Offset = "0x186671")]
		public SharedVector3 position;

		// Token: 0x0401B6DA RID: 112346
		[Token(Token = "0x40180FB")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6DB RID: 112347
		[Token(Token = "0x40180FC")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
