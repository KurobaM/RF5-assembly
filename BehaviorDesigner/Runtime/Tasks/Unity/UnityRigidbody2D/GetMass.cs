using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001389 RID: 5001
	[Token(Token = "0x2000D54")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F040", Offset = "0x14F141")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F040", Offset = "0x14F141")]
	public class GetMass : Action
	{
		// Token: 0x060074DA RID: 29914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618E")]
		[Address(RVA = "0x29965B0", Offset = "0x29966B1", VA = "0x29965B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x00028758 File Offset: 0x00026958
		[Token(Token = "0x600618F")]
		[Address(RVA = "0x29966B0", Offset = "0x29967B1", VA = "0x29966B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006190")]
		[Address(RVA = "0x29967A0", Offset = "0x29968A1", VA = "0x29967A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006191")]
		[Address(RVA = "0x29967F0", Offset = "0x29968F1", VA = "0x29967F0")]
		public GetMass()
		{
		}

		// Token: 0x0401B79B RID: 112539
		[Token(Token = "0x40181BC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188BE0", Offset = "0x188CE1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B79C RID: 112540
		[Token(Token = "0x40181BD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188C20", Offset = "0x188D21")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188C20", Offset = "0x188D21")]
		public SharedFloat storeValue;

		// Token: 0x0401B79D RID: 112541
		[Token(Token = "0x40181BE")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B79E RID: 112542
		[Token(Token = "0x40181BF")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
