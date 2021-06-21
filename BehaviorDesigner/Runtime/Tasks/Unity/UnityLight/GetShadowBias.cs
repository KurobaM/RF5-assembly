using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001427 RID: 5159
	[Token(Token = "0x2000DED")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1529F0", Offset = "0x152AF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1529F0", Offset = "0x152AF1")]
	public class GetShadowBias : Action
	{
		// Token: 0x0600770B RID: 30475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063BF")]
		[Address(RVA = "0x28E7690", Offset = "0x28E7791", VA = "0x28E7690", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x000295B0 File Offset: 0x000277B0
		[Token(Token = "0x60063C0")]
		[Address(RVA = "0x28E7790", Offset = "0x28E7891", VA = "0x28E7790", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C1")]
		[Address(RVA = "0x28E7880", Offset = "0x28E7981", VA = "0x28E7880", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C2")]
		[Address(RVA = "0x28E78D0", Offset = "0x28E79D1", VA = "0x28E78D0")]
		public GetShadowBias()
		{
		}

		// Token: 0x0401B9ED RID: 113133
		[Token(Token = "0x40183EB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E750", Offset = "0x18E851")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B9EE RID: 113134
		[Token(Token = "0x40183EC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18E790", Offset = "0x18E891")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E790", Offset = "0x18E891")]
		public SharedFloat storeValue;

		// Token: 0x0401B9EF RID: 113135
		[Token(Token = "0x40183ED")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401B9F0 RID: 113136
		[Token(Token = "0x40183EE")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
