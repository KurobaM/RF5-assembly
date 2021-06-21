using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001341 RID: 4929
	[Token(Token = "0x2000D0C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D540", Offset = "0x14D641")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D540", Offset = "0x14D641")]
	public class SetRightVector : Action
	{
		// Token: 0x060073E9 RID: 29673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609D")]
		[Address(RVA = "0x299F020", Offset = "0x299F121", VA = "0x299F020", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073EA RID: 29674 RVA: 0x00028098 File Offset: 0x00026298
		[Token(Token = "0x600609E")]
		[Address(RVA = "0x299F120", Offset = "0x299F221", VA = "0x299F120", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073EB RID: 29675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609F")]
		[Address(RVA = "0x299F210", Offset = "0x299F311", VA = "0x299F210", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073EC RID: 29676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A0")]
		[Address(RVA = "0x299F2A0", Offset = "0x299F3A1", VA = "0x299F2A0")]
		public SetRightVector()
		{
		}

		// Token: 0x0401B6DC RID: 112348
		[Token(Token = "0x40180FD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1865B0", Offset = "0x1866B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6DD RID: 112349
		[Token(Token = "0x40180FE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1865F0", Offset = "0x1866F1")]
		public SharedVector3 position;

		// Token: 0x0401B6DE RID: 112350
		[Token(Token = "0x40180FF")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6DF RID: 112351
		[Token(Token = "0x4018100")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
