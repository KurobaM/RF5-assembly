using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001334 RID: 4916
	[Token(Token = "0x2000CFF")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D060", Offset = "0x14D161")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D060", Offset = "0x14D161")]
	public class GetUpVector : Action
	{
		// Token: 0x060073B5 RID: 29621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006069")]
		[Address(RVA = "0x299CDC0", Offset = "0x299CEC1", VA = "0x299CDC0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x00027F60 File Offset: 0x00026160
		[Token(Token = "0x600606A")]
		[Address(RVA = "0x299CEC0", Offset = "0x299CFC1", VA = "0x299CEC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606B")]
		[Address(RVA = "0x299CFB0", Offset = "0x299D0B1", VA = "0x299CFB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606C")]
		[Address(RVA = "0x299D040", Offset = "0x299D141", VA = "0x299D040")]
		public GetUpVector()
		{
		}

		// Token: 0x0401B6A3 RID: 112291
		[Token(Token = "0x40180C4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185DE0", Offset = "0x185EE1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6A4 RID: 112292
		[Token(Token = "0x40180C5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185E20", Offset = "0x185F21")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185E20", Offset = "0x185F21")]
		public SharedVector3 storeValue;

		// Token: 0x0401B6A5 RID: 112293
		[Token(Token = "0x40180C6")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6A6 RID: 112294
		[Token(Token = "0x40180C7")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
