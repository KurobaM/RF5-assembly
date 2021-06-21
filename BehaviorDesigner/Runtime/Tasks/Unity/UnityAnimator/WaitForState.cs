using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014C1 RID: 5313
	[Token(Token = "0x2000E84")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156290", Offset = "0x156391")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156290", Offset = "0x156391")]
	public class WaitForState : Action
	{
		// Token: 0x06007959 RID: 31065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FB")]
		[Address(RVA = "0x28D9660", Offset = "0x28D9761", VA = "0x28D9660", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FC")]
		[Address(RVA = "0x28D96D0", Offset = "0x28D97D1", VA = "0x28D96D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x0002A438 File Offset: 0x00028638
		[Token(Token = "0x60065FD")]
		[Address(RVA = "0x28D99C0", Offset = "0x28D9AC1", VA = "0x28D99C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FE")]
		[Address(RVA = "0x28D9B00", Offset = "0x28D9C01", VA = "0x28D9B00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065FF")]
		[Address(RVA = "0x28D9B90", Offset = "0x28D9C91", VA = "0x28D9B90")]
		public WaitForState()
		{
		}

		// Token: 0x0401BC1C RID: 113692
		[Token(Token = "0x401860E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193A90", Offset = "0x193B91")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC1D RID: 113693
		[Token(Token = "0x401860F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193AD0", Offset = "0x193BD1")]
		public SharedString stateName;

		// Token: 0x0401BC1E RID: 113694
		[Token(Token = "0x4018610")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193B10", Offset = "0x193C11")]
		public SharedInt layer;

		// Token: 0x0401BC1F RID: 113695
		[Token(Token = "0x4018611")]
		[FieldOffset(Offset = "0x68")]
		private Animator animator;

		// Token: 0x0401BC20 RID: 113696
		[Token(Token = "0x4018612")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;

		// Token: 0x0401BC21 RID: 113697
		[Token(Token = "0x4018613")]
		[FieldOffset(Offset = "0x78")]
		private int stateHash;
	}
}
