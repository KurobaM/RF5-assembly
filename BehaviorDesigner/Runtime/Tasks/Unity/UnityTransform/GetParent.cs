using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001330 RID: 4912
	[Token(Token = "0x2000CFB")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CEE0", Offset = "0x14CFE1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CEE0", Offset = "0x14CFE1")]
	public class GetParent : Action
	{
		// Token: 0x060073A5 RID: 29605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006059")]
		[Address(RVA = "0x299C3C0", Offset = "0x299C4C1", VA = "0x299C3C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x00027F00 File Offset: 0x00026100
		[Token(Token = "0x600605A")]
		[Address(RVA = "0x299C4C0", Offset = "0x299C5C1", VA = "0x299C4C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600605B")]
		[Address(RVA = "0x299C5C0", Offset = "0x299C6C1", VA = "0x299C5C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600605C")]
		[Address(RVA = "0x299C600", Offset = "0x299C701", VA = "0x299C600")]
		public GetParent()
		{
		}

		// Token: 0x0401B693 RID: 112275
		[Token(Token = "0x40180B4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185BA0", Offset = "0x185CA1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B694 RID: 112276
		[Token(Token = "0x40180B5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185BE0", Offset = "0x185CE1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185BE0", Offset = "0x185CE1")]
		public SharedTransform storeValue;

		// Token: 0x0401B695 RID: 112277
		[Token(Token = "0x40180B6")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B696 RID: 112278
		[Token(Token = "0x40180B7")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
