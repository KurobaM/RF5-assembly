using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001381 RID: 4993
	[Token(Token = "0x2000D4C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14ED40", Offset = "0x14EE41")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14ED40", Offset = "0x14EE41")]
	public class AddForce : Action
	{
		// Token: 0x060074BA RID: 29882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616E")]
		[Address(RVA = "0x2995250", Offset = "0x2995351", VA = "0x2995250", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x00028698 File Offset: 0x00026898
		[Token(Token = "0x600616F")]
		[Address(RVA = "0x2995350", Offset = "0x2995451", VA = "0x2995350", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006170")]
		[Address(RVA = "0x2995440", Offset = "0x2995541", VA = "0x2995440", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006171")]
		[Address(RVA = "0x29954D0", Offset = "0x29955D1", VA = "0x29954D0")]
		public AddForce()
		{
		}

		// Token: 0x0401B77A RID: 112506
		[Token(Token = "0x401819B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188750", Offset = "0x188851")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B77B RID: 112507
		[Token(Token = "0x401819C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188790", Offset = "0x188891")]
		public SharedVector2 force;

		// Token: 0x0401B77C RID: 112508
		[Token(Token = "0x401819D")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B77D RID: 112509
		[Token(Token = "0x401819E")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
