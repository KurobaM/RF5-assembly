using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200132A RID: 4906
	[Token(Token = "0x2000CF5")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CCA0", Offset = "0x14CDA1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CCA0", Offset = "0x14CDA1")]
	public class GetEulerAngles : Action
	{
		// Token: 0x0600738D RID: 29581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006041")]
		[Address(RVA = "0x299B460", Offset = "0x299B561", VA = "0x299B460", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x00027E70 File Offset: 0x00026070
		[Token(Token = "0x6006042")]
		[Address(RVA = "0x299B560", Offset = "0x299B661", VA = "0x299B560", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006043")]
		[Address(RVA = "0x299B650", Offset = "0x299B751", VA = "0x299B650", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006044")]
		[Address(RVA = "0x299B6E0", Offset = "0x299B7E1", VA = "0x299B6E0")]
		public GetEulerAngles()
		{
		}

		// Token: 0x0401B67B RID: 112251
		[Token(Token = "0x401809C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185840", Offset = "0x185941")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B67C RID: 112252
		[Token(Token = "0x401809D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185880", Offset = "0x185981")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185880", Offset = "0x185981")]
		public SharedVector3 storeValue;

		// Token: 0x0401B67D RID: 112253
		[Token(Token = "0x401809E")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B67E RID: 112254
		[Token(Token = "0x401809F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
