using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200133D RID: 4925
	[Token(Token = "0x2000D08")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D3C0", Offset = "0x14D4C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D3C0", Offset = "0x14D4C1")]
	public class SetLocalRotation : Action
	{
		// Token: 0x060073D9 RID: 29657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608D")]
		[Address(RVA = "0x299E620", Offset = "0x299E721", VA = "0x299E620", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x00028038 File Offset: 0x00026238
		[Token(Token = "0x600608E")]
		[Address(RVA = "0x299E720", Offset = "0x299E821", VA = "0x299E720", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600608F")]
		[Address(RVA = "0x299E810", Offset = "0x299E911", VA = "0x299E810", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006090")]
		[Address(RVA = "0x299E8A0", Offset = "0x299E9A1", VA = "0x299E8A0")]
		public SetLocalRotation()
		{
		}

		// Token: 0x0401B6CC RID: 112332
		[Token(Token = "0x40180ED")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1863B0", Offset = "0x1864B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6CD RID: 112333
		[Token(Token = "0x40180EE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1863F0", Offset = "0x1864F1")]
		public SharedQuaternion localRotation;

		// Token: 0x0401B6CE RID: 112334
		[Token(Token = "0x40180EF")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6CF RID: 112335
		[Token(Token = "0x40180F0")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
