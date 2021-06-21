using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x0200138B RID: 5003
	[Token(Token = "0x2000D56")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F100", Offset = "0x14F201")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F100", Offset = "0x14F201")]
	public class GetRotation : Action
	{
		// Token: 0x060074E2 RID: 29922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006196")]
		[Address(RVA = "0x2996A90", Offset = "0x2996B91", VA = "0x2996A90", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x00028788 File Offset: 0x00026988
		[Token(Token = "0x6006197")]
		[Address(RVA = "0x2996B90", Offset = "0x2996C91", VA = "0x2996B90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006198")]
		[Address(RVA = "0x2996C80", Offset = "0x2996D81", VA = "0x2996C80", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006199")]
		[Address(RVA = "0x2996CD0", Offset = "0x2996DD1", VA = "0x2996CD0")]
		public GetRotation()
		{
		}

		// Token: 0x0401B7A3 RID: 112547
		[Token(Token = "0x40181C4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188D00", Offset = "0x188E01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7A4 RID: 112548
		[Token(Token = "0x40181C5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188D40", Offset = "0x188E41")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188D40", Offset = "0x188E41")]
		public SharedFloat storeValue;

		// Token: 0x0401B7A5 RID: 112549
		[Token(Token = "0x40181C6")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7A6 RID: 112550
		[Token(Token = "0x40181C7")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
