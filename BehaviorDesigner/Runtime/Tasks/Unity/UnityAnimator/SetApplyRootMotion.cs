using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014B1 RID: 5297
	[Token(Token = "0x2000E77")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155DB0", Offset = "0x155EB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155DB0", Offset = "0x155EB1")]
	public class SetApplyRootMotion : Action
	{
		// Token: 0x0600790E RID: 30990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C2")]
		[Address(RVA = "0x28D6FE0", Offset = "0x28D70E1", VA = "0x28D6FE0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x0002A2B8 File Offset: 0x000284B8
		[Token(Token = "0x60065C3")]
		[Address(RVA = "0x28D70E0", Offset = "0x28D71E1", VA = "0x28D70E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C4")]
		[Address(RVA = "0x28D71E0", Offset = "0x28D72E1", VA = "0x28D71E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C5")]
		[Address(RVA = "0x28D7230", Offset = "0x28D7331", VA = "0x28D7230")]
		public SetApplyRootMotion()
		{
		}

		// Token: 0x0401BBD3 RID: 113619
		[Token(Token = "0x40185D1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193290", Offset = "0x193391")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBD4 RID: 113620
		[Token(Token = "0x40185D2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1932D0", Offset = "0x1933D1")]
		public SharedBool rootMotion;

		// Token: 0x0401BBD5 RID: 113621
		[Token(Token = "0x40185D3")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BBD6 RID: 113622
		[Token(Token = "0x40185D4")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
