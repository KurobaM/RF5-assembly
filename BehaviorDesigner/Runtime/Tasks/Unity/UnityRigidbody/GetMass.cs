using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013A6 RID: 5030
	[Token(Token = "0x2000D71")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FB70", Offset = "0x14FC71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FB70", Offset = "0x14FC71")]
	public class GetMass : Action
	{
		// Token: 0x0600754E RID: 30030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006202")]
		[Address(RVA = "0x29919D0", Offset = "0x2991AD1", VA = "0x29919D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x00028A10 File Offset: 0x00026C10
		[Token(Token = "0x6006203")]
		[Address(RVA = "0x2991AD0", Offset = "0x2991BD1", VA = "0x2991AD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006204")]
		[Address(RVA = "0x2991BC0", Offset = "0x2991CC1", VA = "0x2991BC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006205")]
		[Address(RVA = "0x2991C10", Offset = "0x2991D11", VA = "0x2991C10")]
		public GetMass()
		{
		}

		// Token: 0x0401B815 RID: 112661
		[Token(Token = "0x4018236")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189C80", Offset = "0x189D81")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B816 RID: 112662
		[Token(Token = "0x4018237")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189CC0", Offset = "0x189DC1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x189CC0", Offset = "0x189DC1")]
		public SharedFloat storeValue;

		// Token: 0x0401B817 RID: 112663
		[Token(Token = "0x4018238")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B818 RID: 112664
		[Token(Token = "0x4018239")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
