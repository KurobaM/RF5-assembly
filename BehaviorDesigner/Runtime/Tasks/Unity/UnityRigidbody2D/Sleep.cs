using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001398 RID: 5016
	[Token(Token = "0x2000D63")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F5E0", Offset = "0x14F6E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F5E0", Offset = "0x14F6E1")]
	public class Sleep : Conditional
	{
		// Token: 0x06007516 RID: 29974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CA")]
		[Address(RVA = "0x29988D0", Offset = "0x29989D1", VA = "0x29988D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007517 RID: 29975 RVA: 0x000288C0 File Offset: 0x00026AC0
		[Token(Token = "0x60061CB")]
		[Address(RVA = "0x29989D0", Offset = "0x2998AD1", VA = "0x29989D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007518 RID: 29976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CC")]
		[Address(RVA = "0x2998AB0", Offset = "0x2998BB1", VA = "0x2998AB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007519 RID: 29977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061CD")]
		[Address(RVA = "0x2998AC0", Offset = "0x2998BC1", VA = "0x2998AC0")]
		public Sleep()
		{
		}

		// Token: 0x0401B7D5 RID: 112597
		[Token(Token = "0x40181F6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189320", Offset = "0x189421")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7D6 RID: 112598
		[Token(Token = "0x40181F7")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7D7 RID: 112599
		[Token(Token = "0x40181F8")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
