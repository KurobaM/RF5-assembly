using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001328 RID: 4904
	[Token(Token = "0x2000CF3")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CBE0", Offset = "0x14CCE1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CBE0", Offset = "0x14CCE1")]
	public class GetChild : Action
	{
		// Token: 0x06007385 RID: 29573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006039")]
		[Address(RVA = "0x299AF90", Offset = "0x299B091", VA = "0x299AF90", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x00027E40 File Offset: 0x00026040
		[Token(Token = "0x600603A")]
		[Address(RVA = "0x299B090", Offset = "0x299B191", VA = "0x299B090", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603B")]
		[Address(RVA = "0x299B1A0", Offset = "0x299B2A1", VA = "0x299B1A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600603C")]
		[Address(RVA = "0x299B1F0", Offset = "0x299B2F1", VA = "0x299B1F0")]
		public GetChild()
		{
		}

		// Token: 0x0401B672 RID: 112242
		[Token(Token = "0x4018093")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1856E0", Offset = "0x1857E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B673 RID: 112243
		[Token(Token = "0x4018094")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185720", Offset = "0x185821")]
		public SharedInt index;

		// Token: 0x0401B674 RID: 112244
		[Token(Token = "0x4018095")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185760", Offset = "0x185861")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185760", Offset = "0x185861")]
		public SharedTransform storeValue;

		// Token: 0x0401B675 RID: 112245
		[Token(Token = "0x4018096")]
		[FieldOffset(Offset = "0x68")]
		private Transform targetTransform;

		// Token: 0x0401B676 RID: 112246
		[Token(Token = "0x4018097")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
