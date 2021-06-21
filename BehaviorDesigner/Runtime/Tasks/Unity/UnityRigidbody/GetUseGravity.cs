using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013A9 RID: 5033
	[Token(Token = "0x2000D74")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FC90", Offset = "0x14FD91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FC90", Offset = "0x14FD91")]
	public class GetUseGravity : Action
	{
		// Token: 0x0600755A RID: 30042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600620E")]
		[Address(RVA = "0x2992140", Offset = "0x2992241", VA = "0x2992140", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x00028A58 File Offset: 0x00026C58
		[Token(Token = "0x600620F")]
		[Address(RVA = "0x2992240", Offset = "0x2992341", VA = "0x2992240", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600755C RID: 30044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006210")]
		[Address(RVA = "0x2992340", Offset = "0x2992441", VA = "0x2992340", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600755D RID: 30045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006211")]
		[Address(RVA = "0x2992390", Offset = "0x2992491", VA = "0x2992390")]
		public GetUseGravity()
		{
		}

		// Token: 0x0401B821 RID: 112673
		[Token(Token = "0x4018242")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189E30", Offset = "0x189F31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B822 RID: 112674
		[Token(Token = "0x4018243")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189E70", Offset = "0x189F71")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x189E70", Offset = "0x189F71")]
		public SharedBool storeValue;

		// Token: 0x0401B823 RID: 112675
		[Token(Token = "0x4018244")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B824 RID: 112676
		[Token(Token = "0x4018245")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
