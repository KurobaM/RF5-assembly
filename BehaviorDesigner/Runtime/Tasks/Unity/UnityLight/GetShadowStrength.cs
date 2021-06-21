using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001428 RID: 5160
	[Token(Token = "0x2000DEE")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152A50", Offset = "0x152B51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152A50", Offset = "0x152B51")]
	public class GetShadowStrength : Action
	{
		// Token: 0x0600770F RID: 30479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C3")]
		[Address(RVA = "0x28E78E0", Offset = "0x28E79E1", VA = "0x28E78E0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x000295C8 File Offset: 0x000277C8
		[Token(Token = "0x60063C4")]
		[Address(RVA = "0x28E79E0", Offset = "0x28E7AE1", VA = "0x28E79E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C5")]
		[Address(RVA = "0x28E7AD0", Offset = "0x28E7BD1", VA = "0x28E7AD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C6")]
		[Address(RVA = "0x28E7B20", Offset = "0x28E7C21", VA = "0x28E7B20")]
		public GetShadowStrength()
		{
		}

		// Token: 0x0401B9F1 RID: 113137
		[Token(Token = "0x40183EF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E7E0", Offset = "0x18E8E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B9F2 RID: 113138
		[Token(Token = "0x40183F0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18E820", Offset = "0x18E921")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E820", Offset = "0x18E921")]
		public SharedFloat storeValue;

		// Token: 0x0401B9F3 RID: 113139
		[Token(Token = "0x40183F1")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401B9F4 RID: 113140
		[Token(Token = "0x40183F2")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
