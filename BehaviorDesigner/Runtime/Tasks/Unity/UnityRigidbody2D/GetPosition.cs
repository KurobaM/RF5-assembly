using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x0200138A RID: 5002
	[Token(Token = "0x2000D55")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F0A0", Offset = "0x14F1A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F0A0", Offset = "0x14F1A1")]
	public class GetPosition : Action
	{
		// Token: 0x060074DE RID: 29918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006192")]
		[Address(RVA = "0x2996800", Offset = "0x2996901", VA = "0x2996800", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074DF RID: 29919 RVA: 0x00028770 File Offset: 0x00026970
		[Token(Token = "0x6006193")]
		[Address(RVA = "0x2996900", Offset = "0x2996A01", VA = "0x2996900", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006194")]
		[Address(RVA = "0x29969F0", Offset = "0x2996AF1", VA = "0x29969F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006195")]
		[Address(RVA = "0x2996A80", Offset = "0x2996B81", VA = "0x2996A80")]
		public GetPosition()
		{
		}

		// Token: 0x0401B79F RID: 112543
		[Token(Token = "0x40181C0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188C70", Offset = "0x188D71")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7A0 RID: 112544
		[Token(Token = "0x40181C1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188CB0", Offset = "0x188DB1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188CB0", Offset = "0x188DB1")]
		public SharedVector2 storeValue;

		// Token: 0x0401B7A1 RID: 112545
		[Token(Token = "0x40181C2")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7A2 RID: 112546
		[Token(Token = "0x40181C3")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
