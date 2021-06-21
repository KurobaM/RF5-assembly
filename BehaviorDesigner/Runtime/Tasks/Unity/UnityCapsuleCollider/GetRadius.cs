using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCapsuleCollider
{
	// Token: 0x0200146F RID: 5231
	[Token(Token = "0x2000E35")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1544F0", Offset = "0x1545F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1544F0", Offset = "0x1545F1")]
	public class GetRadius : Action
	{
		// Token: 0x0600780A RID: 30730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BE")]
		[Address(RVA = "0x28E07C0", Offset = "0x28E08C1", VA = "0x28E07C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x00029C88 File Offset: 0x00027E88
		[Token(Token = "0x60064BF")]
		[Address(RVA = "0x28E08C0", Offset = "0x28E09C1", VA = "0x28E08C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C0")]
		[Address(RVA = "0x28E09B0", Offset = "0x28E0AB1", VA = "0x28E09B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C1")]
		[Address(RVA = "0x28E0A00", Offset = "0x28E0B01", VA = "0x28E0A00")]
		public GetRadius()
		{
		}

		// Token: 0x0401BAC7 RID: 113351
		[Token(Token = "0x40184C5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190CE0", Offset = "0x190DE1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAC8 RID: 113352
		[Token(Token = "0x40184C6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190D20", Offset = "0x190E21")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190D20", Offset = "0x190E21")]
		public SharedFloat storeValue;

		// Token: 0x0401BAC9 RID: 113353
		[Token(Token = "0x40184C7")]
		[FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		// Token: 0x0401BACA RID: 113354
		[Token(Token = "0x40184C8")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
