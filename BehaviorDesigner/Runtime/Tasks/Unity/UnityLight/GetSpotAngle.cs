using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001429 RID: 5161
	[Token(Token = "0x2000DEF")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152AB0", Offset = "0x152BB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152AB0", Offset = "0x152BB1")]
	public class GetSpotAngle : Action
	{
		// Token: 0x06007713 RID: 30483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C7")]
		[Address(RVA = "0x28E7B30", Offset = "0x28E7C31", VA = "0x28E7B30", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x000295E0 File Offset: 0x000277E0
		[Token(Token = "0x60063C8")]
		[Address(RVA = "0x28E7C30", Offset = "0x28E7D31", VA = "0x28E7C30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C9")]
		[Address(RVA = "0x28E7D20", Offset = "0x28E7E21", VA = "0x28E7D20", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CA")]
		[Address(RVA = "0x28E7D70", Offset = "0x28E7E71", VA = "0x28E7D70")]
		public GetSpotAngle()
		{
		}

		// Token: 0x0401B9F5 RID: 113141
		[Token(Token = "0x40183F3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E870", Offset = "0x18E971")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B9F6 RID: 113142
		[Token(Token = "0x40183F4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18E8B0", Offset = "0x18E9B1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E8B0", Offset = "0x18E9B1")]
		public SharedFloat storeValue;

		// Token: 0x0401B9F7 RID: 113143
		[Token(Token = "0x40183F5")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401B9F8 RID: 113144
		[Token(Token = "0x40183F6")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
