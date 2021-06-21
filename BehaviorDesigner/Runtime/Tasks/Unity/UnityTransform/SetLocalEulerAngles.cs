using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200133B RID: 4923
	[Token(Token = "0x2000D06")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D300", Offset = "0x14D401")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D300", Offset = "0x14D401")]
	public class SetLocalEulerAngles : Action
	{
		// Token: 0x060073D1 RID: 29649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006085")]
		[Address(RVA = "0x299E100", Offset = "0x299E201", VA = "0x299E100", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073D2 RID: 29650 RVA: 0x00028008 File Offset: 0x00026208
		[Token(Token = "0x6006086")]
		[Address(RVA = "0x299E200", Offset = "0x299E301", VA = "0x299E200", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073D3 RID: 29651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006087")]
		[Address(RVA = "0x299E2F0", Offset = "0x299E3F1", VA = "0x299E2F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006088")]
		[Address(RVA = "0x299E380", Offset = "0x299E481", VA = "0x299E380")]
		public SetLocalEulerAngles()
		{
		}

		// Token: 0x0401B6C4 RID: 112324
		[Token(Token = "0x40180E5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1862B0", Offset = "0x1863B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6C5 RID: 112325
		[Token(Token = "0x40180E6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1862F0", Offset = "0x1863F1")]
		public SharedVector3 localEulerAngles;

		// Token: 0x0401B6C6 RID: 112326
		[Token(Token = "0x40180E7")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6C7 RID: 112327
		[Token(Token = "0x40180E8")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
