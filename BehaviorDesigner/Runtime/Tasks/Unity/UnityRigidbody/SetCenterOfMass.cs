using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013B1 RID: 5041
	[Token(Token = "0x2000D7C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FF90", Offset = "0x150091")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FF90", Offset = "0x150091")]
	public class SetCenterOfMass : Action
	{
		// Token: 0x0600757A RID: 30074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600622E")]
		[Address(RVA = "0x2993430", Offset = "0x2993531", VA = "0x2993430", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x00028B18 File Offset: 0x00026D18
		[Token(Token = "0x600622F")]
		[Address(RVA = "0x2993530", Offset = "0x2993631", VA = "0x2993530", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006230")]
		[Address(RVA = "0x2993620", Offset = "0x2993721", VA = "0x2993620", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006231")]
		[Address(RVA = "0x29936B0", Offset = "0x29937B1", VA = "0x29936B0")]
		public SetCenterOfMass()
		{
		}

		// Token: 0x0401B83F RID: 112703
		[Token(Token = "0x4018260")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A1D0", Offset = "0x18A2D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B840 RID: 112704
		[Token(Token = "0x4018261")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A210", Offset = "0x18A311")]
		public SharedVector3 centerOfMass;

		// Token: 0x0401B841 RID: 112705
		[Token(Token = "0x4018262")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B842 RID: 112706
		[Token(Token = "0x4018263")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
