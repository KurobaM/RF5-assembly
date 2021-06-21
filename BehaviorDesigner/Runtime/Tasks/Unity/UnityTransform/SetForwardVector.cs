using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200133A RID: 4922
	[Token(Token = "0x2000D05")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D2A0", Offset = "0x14D3A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D2A0", Offset = "0x14D3A1")]
	public class SetForwardVector : Action
	{
		// Token: 0x060073CD RID: 29645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006081")]
		[Address(RVA = "0x299DE70", Offset = "0x299DF71", VA = "0x299DE70", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x00027FF0 File Offset: 0x000261F0
		[Token(Token = "0x6006082")]
		[Address(RVA = "0x299DF70", Offset = "0x299E071", VA = "0x299DF70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006083")]
		[Address(RVA = "0x299E060", Offset = "0x299E161", VA = "0x299E060", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006084")]
		[Address(RVA = "0x299E0F0", Offset = "0x299E1F1", VA = "0x299E0F0")]
		public SetForwardVector()
		{
		}

		// Token: 0x0401B6C0 RID: 112320
		[Token(Token = "0x40180E1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186230", Offset = "0x186331")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6C1 RID: 112321
		[Token(Token = "0x40180E2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186270", Offset = "0x186371")]
		public SharedVector3 position;

		// Token: 0x0401B6C2 RID: 112322
		[Token(Token = "0x40180E3")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6C3 RID: 112323
		[Token(Token = "0x40180E4")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
