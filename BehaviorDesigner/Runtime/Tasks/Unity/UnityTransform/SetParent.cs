using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200133F RID: 4927
	[Token(Token = "0x2000D0A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D480", Offset = "0x14D581")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D480", Offset = "0x14D581")]
	public class SetParent : Action
	{
		// Token: 0x060073E1 RID: 29665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006095")]
		[Address(RVA = "0x299EB40", Offset = "0x299EC41", VA = "0x299EB40", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x00028068 File Offset: 0x00026268
		[Token(Token = "0x6006096")]
		[Address(RVA = "0x299EC40", Offset = "0x299ED41", VA = "0x299EC40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073E3 RID: 29667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006097")]
		[Address(RVA = "0x299ED40", Offset = "0x299EE41", VA = "0x299ED40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073E4 RID: 29668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006098")]
		[Address(RVA = "0x299ED80", Offset = "0x299EE81", VA = "0x299ED80")]
		public SetParent()
		{
		}

		// Token: 0x0401B6D4 RID: 112340
		[Token(Token = "0x40180F5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1864B0", Offset = "0x1865B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6D5 RID: 112341
		[Token(Token = "0x40180F6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1864F0", Offset = "0x1865F1")]
		public SharedTransform parent;

		// Token: 0x0401B6D6 RID: 112342
		[Token(Token = "0x40180F7")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6D7 RID: 112343
		[Token(Token = "0x40180F8")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
