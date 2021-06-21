using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200133C RID: 4924
	[Token(Token = "0x2000D07")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D360", Offset = "0x14D461")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D360", Offset = "0x14D461")]
	public class SetLocalPosition : Action
	{
		// Token: 0x060073D5 RID: 29653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006089")]
		[Address(RVA = "0x299E390", Offset = "0x299E491", VA = "0x299E390", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073D6 RID: 29654 RVA: 0x00028020 File Offset: 0x00026220
		[Token(Token = "0x600608A")]
		[Address(RVA = "0x299E490", Offset = "0x299E591", VA = "0x299E490", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073D7 RID: 29655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608B")]
		[Address(RVA = "0x299E580", Offset = "0x299E681", VA = "0x299E580", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073D8 RID: 29656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608C")]
		[Address(RVA = "0x299E610", Offset = "0x299E711", VA = "0x299E610")]
		public SetLocalPosition()
		{
		}

		// Token: 0x0401B6C8 RID: 112328
		[Token(Token = "0x40180E9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186330", Offset = "0x186431")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6C9 RID: 112329
		[Token(Token = "0x40180EA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186370", Offset = "0x186471")]
		public SharedVector3 localPosition;

		// Token: 0x0401B6CA RID: 112330
		[Token(Token = "0x40180EB")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6CB RID: 112331
		[Token(Token = "0x40180EC")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
