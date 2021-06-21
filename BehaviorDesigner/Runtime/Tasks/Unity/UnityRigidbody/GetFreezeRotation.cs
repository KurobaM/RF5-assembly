using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013A4 RID: 5028
	[Token(Token = "0x2000D6F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FAB0", Offset = "0x14FBB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FAB0", Offset = "0x14FBB1")]
	public class GetFreezeRotation : Action
	{
		// Token: 0x06007546 RID: 30022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FA")]
		[Address(RVA = "0x2991510", Offset = "0x2991611", VA = "0x2991510", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007547 RID: 30023 RVA: 0x000289E0 File Offset: 0x00026BE0
		[Token(Token = "0x60061FB")]
		[Address(RVA = "0x2991610", Offset = "0x2991711", VA = "0x2991610", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FC")]
		[Address(RVA = "0x2991710", Offset = "0x2991811", VA = "0x2991710", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FD")]
		[Address(RVA = "0x2991760", Offset = "0x2991861", VA = "0x2991760")]
		public GetFreezeRotation()
		{
		}

		// Token: 0x0401B80D RID: 112653
		[Token(Token = "0x401822E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189B60", Offset = "0x189C61")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B80E RID: 112654
		[Token(Token = "0x401822F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189BA0", Offset = "0x189CA1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x189BA0", Offset = "0x189CA1")]
		public SharedBool storeValue;

		// Token: 0x0401B80F RID: 112655
		[Token(Token = "0x4018230")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B810 RID: 112656
		[Token(Token = "0x4018231")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
