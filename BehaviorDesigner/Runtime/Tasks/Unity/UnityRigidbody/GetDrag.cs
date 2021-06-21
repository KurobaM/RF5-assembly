using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013A3 RID: 5027
	[Token(Token = "0x2000D6E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FA50", Offset = "0x14FB51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FA50", Offset = "0x14FB51")]
	public class GetDrag : Action
	{
		// Token: 0x06007542 RID: 30018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F6")]
		[Address(RVA = "0x29912C0", Offset = "0x29913C1", VA = "0x29912C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x000289C8 File Offset: 0x00026BC8
		[Token(Token = "0x60061F7")]
		[Address(RVA = "0x29913C0", Offset = "0x29914C1", VA = "0x29913C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F8")]
		[Address(RVA = "0x29914B0", Offset = "0x29915B1", VA = "0x29914B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F9")]
		[Address(RVA = "0x2991500", Offset = "0x2991601", VA = "0x2991500")]
		public GetDrag()
		{
		}

		// Token: 0x0401B809 RID: 112649
		[Token(Token = "0x401822A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189AD0", Offset = "0x189BD1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B80A RID: 112650
		[Token(Token = "0x401822B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189B10", Offset = "0x189C11")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x189B10", Offset = "0x189C11")]
		public SharedFloat storeValue;

		// Token: 0x0401B80B RID: 112651
		[Token(Token = "0x401822C")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B80C RID: 112652
		[Token(Token = "0x401822D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
