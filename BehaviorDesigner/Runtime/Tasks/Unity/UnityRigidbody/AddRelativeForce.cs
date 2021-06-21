using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x0200139D RID: 5021
	[Token(Token = "0x2000D68")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F810", Offset = "0x14F911")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F810", Offset = "0x14F911")]
	public class AddRelativeForce : Action
	{
		// Token: 0x0600752A RID: 29994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061DE")]
		[Address(RVA = "0x29903C0", Offset = "0x29904C1", VA = "0x29903C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x00028938 File Offset: 0x00026B38
		[Token(Token = "0x60061DF")]
		[Address(RVA = "0x29904C0", Offset = "0x29905C1", VA = "0x29904C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E0")]
		[Address(RVA = "0x29905C0", Offset = "0x29906C1", VA = "0x29905C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061E1")]
		[Address(RVA = "0x2990660", Offset = "0x2990761", VA = "0x2990660")]
		public AddRelativeForce()
		{
		}

		// Token: 0x0401B7EE RID: 112622
		[Token(Token = "0x401820F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1896E0", Offset = "0x1897E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7EF RID: 112623
		[Token(Token = "0x4018210")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189720", Offset = "0x189821")]
		public SharedVector3 force;

		// Token: 0x0401B7F0 RID: 112624
		[Token(Token = "0x4018211")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189760", Offset = "0x189861")]
		public ForceMode forceMode;

		// Token: 0x0401B7F1 RID: 112625
		[Token(Token = "0x4018212")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody rigidbody;

		// Token: 0x0401B7F2 RID: 112626
		[Token(Token = "0x4018213")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
