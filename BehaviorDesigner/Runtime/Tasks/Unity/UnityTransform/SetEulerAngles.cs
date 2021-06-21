using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001339 RID: 4921
	[Token(Token = "0x2000D04")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D240", Offset = "0x14D341")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D240", Offset = "0x14D341")]
	public class SetEulerAngles : Action
	{
		// Token: 0x060073C9 RID: 29641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607D")]
		[Address(RVA = "0x299DBE0", Offset = "0x299DCE1", VA = "0x299DBE0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x00027FD8 File Offset: 0x000261D8
		[Token(Token = "0x600607E")]
		[Address(RVA = "0x299DCE0", Offset = "0x299DDE1", VA = "0x299DCE0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607F")]
		[Address(RVA = "0x299DDD0", Offset = "0x299DED1", VA = "0x299DDD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006080")]
		[Address(RVA = "0x299DE60", Offset = "0x299DF61", VA = "0x299DE60")]
		public SetEulerAngles()
		{
		}

		// Token: 0x0401B6BC RID: 112316
		[Token(Token = "0x40180DD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1861B0", Offset = "0x1862B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6BD RID: 112317
		[Token(Token = "0x40180DE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1861F0", Offset = "0x1862F1")]
		public SharedVector3 eulerAngles;

		// Token: 0x0401B6BE RID: 112318
		[Token(Token = "0x40180DF")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6BF RID: 112319
		[Token(Token = "0x40180E0")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
