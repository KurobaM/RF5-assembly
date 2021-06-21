using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014B9 RID: 5305
	[Token(Token = "0x2000E7C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155F90", Offset = "0x156091")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155F90", Offset = "0x156091")]
	public class SetLookAtPosition : Action
	{
		// Token: 0x06007937 RID: 31031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D9")]
		[Address(RVA = "0x28D8480", Offset = "0x28D8581", VA = "0x28D8480", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x0002A378 File Offset: 0x00028578
		[Token(Token = "0x60065DA")]
		[Address(RVA = "0x28D84F0", Offset = "0x28D85F1", VA = "0x28D84F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DB")]
		[Address(RVA = "0x28D85C0", Offset = "0x28D86C1", VA = "0x28D85C0", Slot = "27")]
		public override void OnAnimatorIK()
		{
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DC")]
		[Address(RVA = "0x28D8670", Offset = "0x28D8771", VA = "0x28D8670", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DD")]
		[Address(RVA = "0x28D86F0", Offset = "0x28D87F1", VA = "0x28D86F0")]
		public SetLookAtPosition()
		{
		}

		// Token: 0x0401BBFD RID: 113661
		[Token(Token = "0x40185EF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1936D0", Offset = "0x1937D1")]
		public SharedVector3 position;

		// Token: 0x0401BBFE RID: 113662
		[Token(Token = "0x40185F0")]
		[FieldOffset(Offset = "0x58")]
		private Animator animator;

		// Token: 0x0401BBFF RID: 113663
		[Token(Token = "0x40185F1")]
		[FieldOffset(Offset = "0x60")]
		private bool positionSet;
	}
}
