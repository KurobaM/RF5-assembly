using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001388 RID: 5000
	[Token(Token = "0x2000D53")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EFE0", Offset = "0x14F0E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EFE0", Offset = "0x14F0E1")]
	public class GetIsKinematic : Action
	{
		// Token: 0x060074D6 RID: 29910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618A")]
		[Address(RVA = "0x2996350", Offset = "0x2996451", VA = "0x2996350", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x00028740 File Offset: 0x00026940
		[Token(Token = "0x600618B")]
		[Address(RVA = "0x2996450", Offset = "0x2996551", VA = "0x2996450", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618C")]
		[Address(RVA = "0x2996550", Offset = "0x2996651", VA = "0x2996550", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600618D")]
		[Address(RVA = "0x29965A0", Offset = "0x29966A1", VA = "0x29965A0")]
		public GetIsKinematic()
		{
		}

		// Token: 0x0401B797 RID: 112535
		[Token(Token = "0x40181B8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188B50", Offset = "0x188C51")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B798 RID: 112536
		[Token(Token = "0x40181B9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188B90", Offset = "0x188C91")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188B90", Offset = "0x188C91")]
		public SharedBool storeValue;

		// Token: 0x0401B799 RID: 112537
		[Token(Token = "0x40181BA")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B79A RID: 112538
		[Token(Token = "0x40181BB")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
