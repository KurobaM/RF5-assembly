using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001397 RID: 5015
	[Token(Token = "0x2000D62")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F580", Offset = "0x14F681")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F580", Offset = "0x14F681")]
	public class SetVelocity : Action
	{
		// Token: 0x06007512 RID: 29970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C6")]
		[Address(RVA = "0x2998640", Offset = "0x2998741", VA = "0x2998640", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x000288A8 File Offset: 0x00026AA8
		[Token(Token = "0x60061C7")]
		[Address(RVA = "0x2998740", Offset = "0x2998841", VA = "0x2998740", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C8")]
		[Address(RVA = "0x2998830", Offset = "0x2998931", VA = "0x2998830", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061C9")]
		[Address(RVA = "0x29988C0", Offset = "0x29989C1", VA = "0x29988C0")]
		public SetVelocity()
		{
		}

		// Token: 0x0401B7D1 RID: 112593
		[Token(Token = "0x40181F2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1892A0", Offset = "0x1893A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7D2 RID: 112594
		[Token(Token = "0x40181F3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1892E0", Offset = "0x1893E1")]
		public SharedVector2 velocity;

		// Token: 0x0401B7D3 RID: 112595
		[Token(Token = "0x40181F4")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7D4 RID: 112596
		[Token(Token = "0x40181F5")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
