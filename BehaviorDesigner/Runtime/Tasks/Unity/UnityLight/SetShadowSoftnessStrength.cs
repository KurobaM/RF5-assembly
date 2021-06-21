using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001431 RID: 5169
	[Token(Token = "0x2000DF7")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152DB0", Offset = "0x152EB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152DB0", Offset = "0x152EB1")]
	public class SetShadowSoftnessStrength : Action
	{
		// Token: 0x06007733 RID: 30515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E7")]
		[Address(RVA = "0x28E8D80", Offset = "0x28E8E81", VA = "0x28E8D80", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x000296A0 File Offset: 0x000278A0
		[Token(Token = "0x60063E8")]
		[Address(RVA = "0x28E8E80", Offset = "0x28E8F81", VA = "0x28E8E80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E9")]
		[Address(RVA = "0x28E8F70", Offset = "0x28E9071", VA = "0x28E8F70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007736 RID: 30518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EA")]
		[Address(RVA = "0x28E8FC0", Offset = "0x28E90C1", VA = "0x28E8FC0")]
		public SetShadowSoftnessStrength()
		{
		}

		// Token: 0x0401BA15 RID: 113173
		[Token(Token = "0x4018413")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EC80", Offset = "0x18ED81")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA16 RID: 113174
		[Token(Token = "0x4018414")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18ECC0", Offset = "0x18EDC1")]
		public SharedFloat shadowStrength;

		// Token: 0x0401BA17 RID: 113175
		[Token(Token = "0x4018415")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401BA18 RID: 113176
		[Token(Token = "0x4018416")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
