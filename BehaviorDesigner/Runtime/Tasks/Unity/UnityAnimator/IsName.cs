using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014AD RID: 5293
	[Token(Token = "0x2000E73")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155C30", Offset = "0x155D31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155C30", Offset = "0x155D31")]
	public class IsName : Conditional
	{
		// Token: 0x060078FE RID: 30974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B2")]
		[Address(RVA = "0x28D6420", Offset = "0x28D6521", VA = "0x28D6420", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x0002A258 File Offset: 0x00028458
		[Token(Token = "0x60065B3")]
		[Address(RVA = "0x28D6520", Offset = "0x28D6621", VA = "0x28D6520", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B4")]
		[Address(RVA = "0x28D6680", Offset = "0x28D6781", VA = "0x28D6680", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B5")]
		[Address(RVA = "0x28D6710", Offset = "0x28D6811", VA = "0x28D6710")]
		public IsName()
		{
		}

		// Token: 0x0401BBBA RID: 113594
		[Token(Token = "0x40185B8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192E50", Offset = "0x192F51")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBBB RID: 113595
		[Token(Token = "0x40185B9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192E90", Offset = "0x192F91")]
		public SharedInt index;

		// Token: 0x0401BBBC RID: 113596
		[Token(Token = "0x40185BA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192ED0", Offset = "0x192FD1")]
		public SharedString name;

		// Token: 0x0401BBBD RID: 113597
		[Token(Token = "0x40185BB")]
		[FieldOffset(Offset = "0x68")]
		private Animator animator;

		// Token: 0x0401BBBE RID: 113598
		[Token(Token = "0x40185BC")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
