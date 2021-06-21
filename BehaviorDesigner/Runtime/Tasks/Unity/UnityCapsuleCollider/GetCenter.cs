using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCapsuleCollider
{
	// Token: 0x0200146C RID: 5228
	[Token(Token = "0x2000E32")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1543D0", Offset = "0x1544D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1543D0", Offset = "0x1544D1")]
	public class GetCenter : Action
	{
		// Token: 0x060077FE RID: 30718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B2")]
		[Address(RVA = "0x28E0080", Offset = "0x28E0181", VA = "0x28E0080", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x00029C40 File Offset: 0x00027E40
		[Token(Token = "0x60064B3")]
		[Address(RVA = "0x28E0180", Offset = "0x28E0281", VA = "0x28E0180", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B4")]
		[Address(RVA = "0x28E0270", Offset = "0x28E0371", VA = "0x28E0270", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B5")]
		[Address(RVA = "0x28E0300", Offset = "0x28E0401", VA = "0x28E0300")]
		public GetCenter()
		{
		}

		// Token: 0x0401BABB RID: 113339
		[Token(Token = "0x40184B9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190B30", Offset = "0x190C31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BABC RID: 113340
		[Token(Token = "0x40184BA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190B70", Offset = "0x190C71")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190B70", Offset = "0x190C71")]
		public SharedVector3 storeValue;

		// Token: 0x0401BABD RID: 113341
		[Token(Token = "0x40184BB")]
		[FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		// Token: 0x0401BABE RID: 113342
		[Token(Token = "0x40184BC")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
