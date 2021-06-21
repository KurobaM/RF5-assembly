using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001426 RID: 5158
	[Token(Token = "0x2000DEC")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152990", Offset = "0x152A91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152990", Offset = "0x152A91")]
	public class GetRange : Action
	{
		// Token: 0x06007707 RID: 30471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BB")]
		[Address(RVA = "0x28E7440", Offset = "0x28E7541", VA = "0x28E7440", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00029598 File Offset: 0x00027798
		[Token(Token = "0x60063BC")]
		[Address(RVA = "0x28E7540", Offset = "0x28E7641", VA = "0x28E7540", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BD")]
		[Address(RVA = "0x28E7630", Offset = "0x28E7731", VA = "0x28E7630", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BE")]
		[Address(RVA = "0x28E7680", Offset = "0x28E7781", VA = "0x28E7680")]
		public GetRange()
		{
		}

		// Token: 0x0401B9E9 RID: 113129
		[Token(Token = "0x40183E7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E6C0", Offset = "0x18E7C1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B9EA RID: 113130
		[Token(Token = "0x40183E8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18E700", Offset = "0x18E801")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E700", Offset = "0x18E801")]
		public SharedFloat storeValue;

		// Token: 0x0401B9EB RID: 113131
		[Token(Token = "0x40183E9")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401B9EC RID: 113132
		[Token(Token = "0x40183EA")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
