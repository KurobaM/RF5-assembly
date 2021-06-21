using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014A1 RID: 5281
	[Token(Token = "0x2000E67")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1557B0", Offset = "0x1558B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1557B0", Offset = "0x1558B1")]
	public class GetApplyRootMotion : Action
	{
		// Token: 0x060078CF RID: 30927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006583")]
		[Address(RVA = "0x28D47C0", Offset = "0x28D48C1", VA = "0x28D47C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x0002A138 File Offset: 0x00028338
		[Token(Token = "0x6006584")]
		[Address(RVA = "0x28D48C0", Offset = "0x28D49C1", VA = "0x28D48C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006585")]
		[Address(RVA = "0x28D49C0", Offset = "0x28D4AC1", VA = "0x28D49C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006586")]
		[Address(RVA = "0x28D4A10", Offset = "0x28D4B11", VA = "0x28D4A10")]
		public GetApplyRootMotion()
		{
		}

		// Token: 0x0401BB88 RID: 113544
		[Token(Token = "0x4018586")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1926B0", Offset = "0x1927B1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB89 RID: 113545
		[Token(Token = "0x4018587")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1926F0", Offset = "0x1927F1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1926F0", Offset = "0x1927F1")]
		public SharedBool storeValue;

		// Token: 0x0401BB8A RID: 113546
		[Token(Token = "0x4018588")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BB8B RID: 113547
		[Token(Token = "0x4018589")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
