using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014A0 RID: 5280
	[Token(Token = "0x2000E66")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155750", Offset = "0x155851")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155750", Offset = "0x155851")]
	public class CrossFade : Action
	{
		// Token: 0x060078CB RID: 30923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657F")]
		[Address(RVA = "0x28D44E0", Offset = "0x28D45E1", VA = "0x28D44E0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078CC RID: 30924 RVA: 0x0002A120 File Offset: 0x00028320
		[Token(Token = "0x6006580")]
		[Address(RVA = "0x28D45E0", Offset = "0x28D46E1", VA = "0x28D45E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078CD RID: 30925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006581")]
		[Address(RVA = "0x28D4710", Offset = "0x28D4811", VA = "0x28D4710", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078CE RID: 30926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006582")]
		[Address(RVA = "0x28D47B0", Offset = "0x28D48B1", VA = "0x28D47B0")]
		public CrossFade()
		{
		}

		// Token: 0x0401BB81 RID: 113537
		[Token(Token = "0x401857F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192570", Offset = "0x192671")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB82 RID: 113538
		[Token(Token = "0x4018580")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1925B0", Offset = "0x1926B1")]
		public SharedString stateName;

		// Token: 0x0401BB83 RID: 113539
		[Token(Token = "0x4018581")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1925F0", Offset = "0x1926F1")]
		public SharedFloat transitionDuration;

		// Token: 0x0401BB84 RID: 113540
		[Token(Token = "0x4018582")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192630", Offset = "0x192731")]
		public int layer;

		// Token: 0x0401BB85 RID: 113541
		[Token(Token = "0x4018583")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192670", Offset = "0x192771")]
		public float normalizedTime;

		// Token: 0x0401BB86 RID: 113542
		[Token(Token = "0x4018584")]
		[FieldOffset(Offset = "0x70")]
		private Animator animator;

		// Token: 0x0401BB87 RID: 113543
		[Token(Token = "0x4018585")]
		[FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;
	}
}
