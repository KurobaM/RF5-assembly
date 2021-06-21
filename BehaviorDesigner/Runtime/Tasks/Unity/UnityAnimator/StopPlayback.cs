using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014BF RID: 5311
	[Token(Token = "0x2000E82")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1561D0", Offset = "0x1562D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1561D0", Offset = "0x1562D1")]
	public class StopPlayback : Action
	{
		// Token: 0x06007951 RID: 31057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F3")]
		[Address(RVA = "0x28D9260", Offset = "0x28D9361", VA = "0x28D9260", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x0002A408 File Offset: 0x00028608
		[Token(Token = "0x60065F4")]
		[Address(RVA = "0x28D9360", Offset = "0x28D9461", VA = "0x28D9360", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F5")]
		[Address(RVA = "0x28D9440", Offset = "0x28D9541", VA = "0x28D9440", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F6")]
		[Address(RVA = "0x28D9450", Offset = "0x28D9551", VA = "0x28D9450")]
		public StopPlayback()
		{
		}

		// Token: 0x0401BC16 RID: 113686
		[Token(Token = "0x4018608")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193A10", Offset = "0x193B11")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC17 RID: 113687
		[Token(Token = "0x4018609")]
		[FieldOffset(Offset = "0x58")]
		private Animator animator;

		// Token: 0x0401BC18 RID: 113688
		[Token(Token = "0x401860A")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
