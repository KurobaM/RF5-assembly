using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001395 RID: 5013
	[Token(Token = "0x2000D60")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F4C0", Offset = "0x14F5C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F4C0", Offset = "0x14F5C1")]
	public class SetIsKinematic : Action
	{
		// Token: 0x0600750A RID: 29962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061BE")]
		[Address(RVA = "0x2998190", Offset = "0x2998291", VA = "0x2998190", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x00028878 File Offset: 0x00026A78
		[Token(Token = "0x60061BF")]
		[Address(RVA = "0x2998290", Offset = "0x2998391", VA = "0x2998290", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C0")]
		[Address(RVA = "0x2998390", Offset = "0x2998491", VA = "0x2998390", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600750D RID: 29965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C1")]
		[Address(RVA = "0x29983E0", Offset = "0x29984E1", VA = "0x29983E0")]
		public SetIsKinematic()
		{
		}

		// Token: 0x0401B7C9 RID: 112585
		[Token(Token = "0x40181EA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1891A0", Offset = "0x1892A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7CA RID: 112586
		[Token(Token = "0x40181EB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1891E0", Offset = "0x1892E1")]
		public SharedBool isKinematic;

		// Token: 0x0401B7CB RID: 112587
		[Token(Token = "0x40181EC")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7CC RID: 112588
		[Token(Token = "0x40181ED")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
