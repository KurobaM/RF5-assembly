using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001385 RID: 4997
	[Token(Token = "0x2000D50")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EEC0", Offset = "0x14EFC1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EEC0", Offset = "0x14EFC1")]
	public class GetAngularVelocity : Action
	{
		// Token: 0x060074CA RID: 29898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617E")]
		[Address(RVA = "0x2995C60", Offset = "0x2995D61", VA = "0x2995C60", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x000286F8 File Offset: 0x000268F8
		[Token(Token = "0x600617F")]
		[Address(RVA = "0x2995D60", Offset = "0x2995E61", VA = "0x2995D60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006180")]
		[Address(RVA = "0x2995E50", Offset = "0x2995F51", VA = "0x2995E50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006181")]
		[Address(RVA = "0x2995EA0", Offset = "0x2995FA1", VA = "0x2995EA0")]
		public GetAngularVelocity()
		{
		}

		// Token: 0x0401B78B RID: 112523
		[Token(Token = "0x40181AC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1889A0", Offset = "0x188AA1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B78C RID: 112524
		[Token(Token = "0x40181AD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1889E0", Offset = "0x188AE1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1889E0", Offset = "0x188AE1")]
		public SharedFloat storeValue;

		// Token: 0x0401B78D RID: 112525
		[Token(Token = "0x40181AE")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B78E RID: 112526
		[Token(Token = "0x40181AF")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
