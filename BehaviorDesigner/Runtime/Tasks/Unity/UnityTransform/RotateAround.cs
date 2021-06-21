using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001338 RID: 4920
	[Token(Token = "0x2000D03")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D1E0", Offset = "0x14D2E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D1E0", Offset = "0x14D2E1")]
	public class RotateAround : Action
	{
		// Token: 0x060073C5 RID: 29637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006079")]
		[Address(RVA = "0x299D890", Offset = "0x299D991", VA = "0x299D890", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x00027FC0 File Offset: 0x000261C0
		[Token(Token = "0x600607A")]
		[Address(RVA = "0x299D990", Offset = "0x299DA91", VA = "0x299D990", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607B")]
		[Address(RVA = "0x299DB00", Offset = "0x299DC01", VA = "0x299DB00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600607C")]
		[Address(RVA = "0x299DBD0", Offset = "0x299DCD1", VA = "0x299DBD0")]
		public RotateAround()
		{
		}

		// Token: 0x0401B6B6 RID: 112310
		[Token(Token = "0x40180D7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1860B0", Offset = "0x1861B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6B7 RID: 112311
		[Token(Token = "0x40180D8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1860F0", Offset = "0x1861F1")]
		public SharedVector3 point;

		// Token: 0x0401B6B8 RID: 112312
		[Token(Token = "0x40180D9")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186130", Offset = "0x186231")]
		public SharedVector3 axis;

		// Token: 0x0401B6B9 RID: 112313
		[Token(Token = "0x40180DA")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186170", Offset = "0x186271")]
		public SharedFloat angle;

		// Token: 0x0401B6BA RID: 112314
		[Token(Token = "0x40180DB")]
		[FieldOffset(Offset = "0x70")]
		private Transform targetTransform;

		// Token: 0x0401B6BB RID: 112315
		[Token(Token = "0x40180DC")]
		[FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;
	}
}
