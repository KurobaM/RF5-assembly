using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013AD RID: 5037
	[Token(Token = "0x2000D78")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FE10", Offset = "0x14FF11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FE10", Offset = "0x14FF11")]
	public class MovePosition : Action
	{
		// Token: 0x0600756A RID: 30058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600621E")]
		[Address(RVA = "0x2992A30", Offset = "0x2992B31", VA = "0x2992A30", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x00028AB8 File Offset: 0x00026CB8
		[Token(Token = "0x600621F")]
		[Address(RVA = "0x2992B30", Offset = "0x2992C31", VA = "0x2992B30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006220")]
		[Address(RVA = "0x2992C20", Offset = "0x2992D21", VA = "0x2992C20", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006221")]
		[Address(RVA = "0x2992CB0", Offset = "0x2992DB1", VA = "0x2992CB0")]
		public MovePosition()
		{
		}

		// Token: 0x0401B82F RID: 112687
		[Token(Token = "0x4018250")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189FD0", Offset = "0x18A0D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B830 RID: 112688
		[Token(Token = "0x4018251")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A010", Offset = "0x18A111")]
		public SharedVector3 position;

		// Token: 0x0401B831 RID: 112689
		[Token(Token = "0x4018252")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B832 RID: 112690
		[Token(Token = "0x4018253")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
