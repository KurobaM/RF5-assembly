using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014AC RID: 5292
	[Token(Token = "0x2000E72")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155BD0", Offset = "0x155CD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155BD0", Offset = "0x155CD1")]
	public class IsInTransition : Conditional
	{
		// Token: 0x060078FA RID: 30970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065AE")]
		[Address(RVA = "0x28D61C0", Offset = "0x28D62C1", VA = "0x28D61C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x0002A240 File Offset: 0x00028440
		[Token(Token = "0x60065AF")]
		[Address(RVA = "0x28D62C0", Offset = "0x28D63C1", VA = "0x28D62C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B0")]
		[Address(RVA = "0x28D63C0", Offset = "0x28D64C1", VA = "0x28D63C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078FD RID: 30973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B1")]
		[Address(RVA = "0x28D6410", Offset = "0x28D6511", VA = "0x28D6410")]
		public IsInTransition()
		{
		}

		// Token: 0x0401BBB6 RID: 113590
		[Token(Token = "0x40185B4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192DD0", Offset = "0x192ED1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBB7 RID: 113591
		[Token(Token = "0x40185B5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192E10", Offset = "0x192F11")]
		public SharedInt index;

		// Token: 0x0401BBB8 RID: 113592
		[Token(Token = "0x40185B6")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BBB9 RID: 113593
		[Token(Token = "0x40185B7")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
