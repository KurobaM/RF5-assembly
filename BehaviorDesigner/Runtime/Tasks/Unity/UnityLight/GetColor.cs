using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001423 RID: 5155
	[Token(Token = "0x2000DE9")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152870", Offset = "0x152971")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152870", Offset = "0x152971")]
	public class GetColor : Action
	{
		// Token: 0x060076FB RID: 30459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AF")]
		[Address(RVA = "0x28E6D50", Offset = "0x28E6E51", VA = "0x28E6D50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x00029550 File Offset: 0x00027750
		[Token(Token = "0x60063B0")]
		[Address(RVA = "0x28E6E50", Offset = "0x28E6F51", VA = "0x28E6E50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B1")]
		[Address(RVA = "0x28E6F40", Offset = "0x28E7041", VA = "0x28E6F40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B2")]
		[Address(RVA = "0x28E6F90", Offset = "0x28E7091", VA = "0x28E6F90")]
		public GetColor()
		{
		}

		// Token: 0x0401B9DD RID: 113117
		[Token(Token = "0x40183DB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E510", Offset = "0x18E611")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B9DE RID: 113118
		[Token(Token = "0x40183DC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18E550", Offset = "0x18E651")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E550", Offset = "0x18E651")]
		public SharedColor storeValue;

		// Token: 0x0401B9DF RID: 113119
		[Token(Token = "0x40183DD")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401B9E0 RID: 113120
		[Token(Token = "0x40183DE")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
