using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001335 RID: 4917
	[Token(Token = "0x2000D00")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D0C0", Offset = "0x14D1C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D0C0", Offset = "0x14D1C1")]
	public class IsChildOf : Conditional
	{
		// Token: 0x060073B9 RID: 29625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606D")]
		[Address(RVA = "0x299D050", Offset = "0x299D151", VA = "0x299D050", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x00027F78 File Offset: 0x00026178
		[Token(Token = "0x600606E")]
		[Address(RVA = "0x299D150", Offset = "0x299D251", VA = "0x299D150", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606F")]
		[Address(RVA = "0x299D250", Offset = "0x299D351", VA = "0x299D250", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006070")]
		[Address(RVA = "0x299D290", Offset = "0x299D391", VA = "0x299D290")]
		public IsChildOf()
		{
		}

		// Token: 0x0401B6A7 RID: 112295
		[Token(Token = "0x40180C8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185E70", Offset = "0x185F71")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6A8 RID: 112296
		[Token(Token = "0x40180C9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185EB0", Offset = "0x185FB1")]
		public SharedTransform transformName;

		// Token: 0x0401B6A9 RID: 112297
		[Token(Token = "0x40180CA")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6AA RID: 112298
		[Token(Token = "0x40180CB")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
