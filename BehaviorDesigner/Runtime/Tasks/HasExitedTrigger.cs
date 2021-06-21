using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012F2 RID: 4850
	[Token(Token = "0x2000CBF")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B840", Offset = "0x14B941")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14B840", Offset = "0x14B941")]
	public class HasExitedTrigger : Conditional
	{
		// Token: 0x060072CA RID: 29386 RVA: 0x00027888 File Offset: 0x00025A88
		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0x2212BB0", Offset = "0x2212CB1", VA = "0x2212BB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0x2212BD0", Offset = "0x2212CD1", VA = "0x2212BD0", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F80")]
		[Address(RVA = "0x2212BE0", Offset = "0x2212CE1", VA = "0x2212BE0", Slot = "21")]
		public override void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F81")]
		[Address(RVA = "0x2212CD0", Offset = "0x2212DD1", VA = "0x2212CD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F82")]
		[Address(RVA = "0x2212DD0", Offset = "0x2212ED1", VA = "0x2212DD0")]
		public HasExitedTrigger()
		{
		}

		// Token: 0x0401B5D8 RID: 112088
		[Token(Token = "0x4018001")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183520", Offset = "0x183621")]
		public SharedString tag;

		// Token: 0x0401B5D9 RID: 112089
		[Token(Token = "0x4018002")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183560", Offset = "0x183661")]
		public SharedGameObject otherGameObject;

		// Token: 0x0401B5DA RID: 112090
		[Token(Token = "0x4018003")]
		[FieldOffset(Offset = "0x60")]
		private bool exitedTrigger;
	}
}
