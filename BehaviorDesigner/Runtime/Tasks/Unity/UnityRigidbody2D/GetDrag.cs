using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001386 RID: 4998
	[Token(Token = "0x2000D51")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EF20", Offset = "0x14F021")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EF20", Offset = "0x14F021")]
	public class GetDrag : Action
	{
		// Token: 0x060074CE RID: 29902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006182")]
		[Address(RVA = "0x2995EB0", Offset = "0x2995FB1", VA = "0x2995EB0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x00028710 File Offset: 0x00026910
		[Token(Token = "0x6006183")]
		[Address(RVA = "0x2995FB0", Offset = "0x29960B1", VA = "0x2995FB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006184")]
		[Address(RVA = "0x29960A0", Offset = "0x29961A1", VA = "0x29960A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006185")]
		[Address(RVA = "0x29960F0", Offset = "0x29961F1", VA = "0x29960F0")]
		public GetDrag()
		{
		}

		// Token: 0x0401B78F RID: 112527
		[Token(Token = "0x40181B0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188A30", Offset = "0x188B31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B790 RID: 112528
		[Token(Token = "0x40181B1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188A70", Offset = "0x188B71")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188A70", Offset = "0x188B71")]
		public SharedFloat storeValue;

		// Token: 0x0401B791 RID: 112529
		[Token(Token = "0x40181B2")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B792 RID: 112530
		[Token(Token = "0x40181B3")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
