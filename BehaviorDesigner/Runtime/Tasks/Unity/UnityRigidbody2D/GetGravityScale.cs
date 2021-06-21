using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001387 RID: 4999
	[Token(Token = "0x2000D52")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EF80", Offset = "0x14F081")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EF80", Offset = "0x14F081")]
	public class GetGravityScale : Action
	{
		// Token: 0x060074D2 RID: 29906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006186")]
		[Address(RVA = "0x2996100", Offset = "0x2996201", VA = "0x2996100", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x00028728 File Offset: 0x00026928
		[Token(Token = "0x6006187")]
		[Address(RVA = "0x2996200", Offset = "0x2996301", VA = "0x2996200", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006188")]
		[Address(RVA = "0x29962F0", Offset = "0x29963F1", VA = "0x29962F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006189")]
		[Address(RVA = "0x2996340", Offset = "0x2996441", VA = "0x2996340")]
		public GetGravityScale()
		{
		}

		// Token: 0x0401B793 RID: 112531
		[Token(Token = "0x40181B4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188AC0", Offset = "0x188BC1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B794 RID: 112532
		[Token(Token = "0x40181B5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188B00", Offset = "0x188C01")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188B00", Offset = "0x188C01")]
		public SharedFloat storeValue;

		// Token: 0x0401B795 RID: 112533
		[Token(Token = "0x40181B6")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B796 RID: 112534
		[Token(Token = "0x40181B7")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
