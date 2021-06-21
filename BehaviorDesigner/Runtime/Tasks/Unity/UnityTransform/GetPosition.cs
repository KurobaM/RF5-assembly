using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001331 RID: 4913
	[Token(Token = "0x2000CFC")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CF40", Offset = "0x14D041")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CF40", Offset = "0x14D041")]
	public class GetPosition : Action
	{
		// Token: 0x060073A9 RID: 29609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600605D")]
		[Address(RVA = "0x299C610", Offset = "0x299C711", VA = "0x299C610", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x00027F18 File Offset: 0x00026118
		[Token(Token = "0x600605E")]
		[Address(RVA = "0x299C710", Offset = "0x299C811", VA = "0x299C710", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600605F")]
		[Address(RVA = "0x299C800", Offset = "0x299C901", VA = "0x299C800", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006060")]
		[Address(RVA = "0x299C890", Offset = "0x299C991", VA = "0x299C890")]
		public GetPosition()
		{
		}

		// Token: 0x0401B697 RID: 112279
		[Token(Token = "0x40180B8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185C30", Offset = "0x185D31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B698 RID: 112280
		[Token(Token = "0x40180B9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185C70", Offset = "0x185D71")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185C70", Offset = "0x185D71")]
		public SharedVector3 storeValue;

		// Token: 0x0401B699 RID: 112281
		[Token(Token = "0x40180BA")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B69A RID: 112282
		[Token(Token = "0x40180BB")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
