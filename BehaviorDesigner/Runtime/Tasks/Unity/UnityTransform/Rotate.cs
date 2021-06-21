using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001337 RID: 4919
	[Token(Token = "0x2000D02")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D180", Offset = "0x14D281")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D180", Offset = "0x14D281")]
	public class Rotate : Action
	{
		// Token: 0x060073C1 RID: 29633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006075")]
		[Address(RVA = "0x299D5E0", Offset = "0x299D6E1", VA = "0x299D5E0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x00027FA8 File Offset: 0x000261A8
		[Token(Token = "0x6006076")]
		[Address(RVA = "0x299D6E0", Offset = "0x299D7E1", VA = "0x299D6E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006077")]
		[Address(RVA = "0x299D7E0", Offset = "0x299D8E1", VA = "0x299D7E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006078")]
		[Address(RVA = "0x299D880", Offset = "0x299D981", VA = "0x299D880")]
		public Rotate()
		{
		}

		// Token: 0x0401B6B1 RID: 112305
		[Token(Token = "0x40180D2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185FF0", Offset = "0x1860F1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6B2 RID: 112306
		[Token(Token = "0x40180D3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186030", Offset = "0x186131")]
		public SharedVector3 eulerAngles;

		// Token: 0x0401B6B3 RID: 112307
		[Token(Token = "0x40180D4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186070", Offset = "0x186171")]
		public Space relativeTo;

		// Token: 0x0401B6B4 RID: 112308
		[Token(Token = "0x40180D5")]
		[FieldOffset(Offset = "0x68")]
		private Transform targetTransform;

		// Token: 0x0401B6B5 RID: 112309
		[Token(Token = "0x40180D6")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
