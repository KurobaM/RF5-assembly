using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013B2 RID: 5042
	[Token(Token = "0x2000D7D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FFF0", Offset = "0x1500F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FFF0", Offset = "0x1500F1")]
	public class SetConstraints : Action
	{
		// Token: 0x0600757E RID: 30078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006232")]
		[Address(RVA = "0x29936C0", Offset = "0x29937C1", VA = "0x29936C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x00028B30 File Offset: 0x00026D30
		[Token(Token = "0x6006233")]
		[Address(RVA = "0x29937C0", Offset = "0x29938C1", VA = "0x29937C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006234")]
		[Address(RVA = "0x29938A0", Offset = "0x29939A1", VA = "0x29938A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006235")]
		[Address(RVA = "0x29938D0", Offset = "0x29939D1", VA = "0x29938D0")]
		public SetConstraints()
		{
		}

		// Token: 0x0401B843 RID: 112707
		[Token(Token = "0x4018264")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A250", Offset = "0x18A351")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B844 RID: 112708
		[Token(Token = "0x4018265")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A290", Offset = "0x18A391")]
		public RigidbodyConstraints constraints;

		// Token: 0x0401B845 RID: 112709
		[Token(Token = "0x4018266")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B846 RID: 112710
		[Token(Token = "0x4018267")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
