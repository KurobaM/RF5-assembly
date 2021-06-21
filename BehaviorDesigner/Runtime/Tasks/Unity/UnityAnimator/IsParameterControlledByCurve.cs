using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014AE RID: 5294
	[Token(Token = "0x2000E74")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155C90", Offset = "0x155D91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155C90", Offset = "0x155D91")]
	public class IsParameterControlledByCurve : Conditional
	{
		// Token: 0x06007902 RID: 30978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B6")]
		[Address(RVA = "0x28D6720", Offset = "0x28D6821", VA = "0x28D6720", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x0002A270 File Offset: 0x00028470
		[Token(Token = "0x60065B7")]
		[Address(RVA = "0x28D6820", Offset = "0x28D6921", VA = "0x28D6820", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B8")]
		[Address(RVA = "0x28D6920", Offset = "0x28D6A21", VA = "0x28D6920", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007905 RID: 30981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B9")]
		[Address(RVA = "0x28D6990", Offset = "0x28D6A91", VA = "0x28D6990")]
		public IsParameterControlledByCurve()
		{
		}

		// Token: 0x0401BBBF RID: 113599
		[Token(Token = "0x40185BD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192F10", Offset = "0x193011")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBC0 RID: 113600
		[Token(Token = "0x40185BE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192F50", Offset = "0x193051")]
		public SharedString paramaterName;

		// Token: 0x0401BBC1 RID: 113601
		[Token(Token = "0x40185BF")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BBC2 RID: 113602
		[Token(Token = "0x40185C0")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
