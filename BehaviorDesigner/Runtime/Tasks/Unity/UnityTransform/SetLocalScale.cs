using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200133E RID: 4926
	[Token(Token = "0x2000D09")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D420", Offset = "0x14D521")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D420", Offset = "0x14D521")]
	public class SetLocalScale : Action
	{
		// Token: 0x060073DD RID: 29661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006091")]
		[Address(RVA = "0x299E8B0", Offset = "0x299E9B1", VA = "0x299E8B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073DE RID: 29662 RVA: 0x00028050 File Offset: 0x00026250
		[Token(Token = "0x6006092")]
		[Address(RVA = "0x299E9B0", Offset = "0x299EAB1", VA = "0x299E9B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073DF RID: 29663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006093")]
		[Address(RVA = "0x299EAA0", Offset = "0x299EBA1", VA = "0x299EAA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006094")]
		[Address(RVA = "0x299EB30", Offset = "0x299EC31", VA = "0x299EB30")]
		public SetLocalScale()
		{
		}

		// Token: 0x0401B6D0 RID: 112336
		[Token(Token = "0x40180F1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186430", Offset = "0x186531")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6D1 RID: 112337
		[Token(Token = "0x40180F2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186470", Offset = "0x186571")]
		public SharedVector3 localScale;

		// Token: 0x0401B6D2 RID: 112338
		[Token(Token = "0x40180F3")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6D3 RID: 112339
		[Token(Token = "0x40180F4")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
