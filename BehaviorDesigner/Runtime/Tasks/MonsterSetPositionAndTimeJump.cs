using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012C8 RID: 4808
	[Token(Token = "0x2000C95")]
	public class MonsterSetPositionAndTimeJump : Action
	{
		// Token: 0x060071E8 RID: 29160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9C")]
		[Address(RVA = "0x22150C0", Offset = "0x22151C1", VA = "0x22150C0", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x00027240 File Offset: 0x00025440
		[Token(Token = "0x6005E9D")]
		[Address(RVA = "0x2215190", Offset = "0x2215291", VA = "0x2215190", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9E")]
		[Address(RVA = "0x2215480", Offset = "0x2215581", VA = "0x2215480", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071EB RID: 29163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9F")]
		[Address(RVA = "0x2215490", Offset = "0x2215591", VA = "0x2215490")]
		public MonsterSetPositionAndTimeJump()
		{
		}

		// Token: 0x0401B52F RID: 111919
		[Token(Token = "0x4017F58")]
		[FieldOffset(Offset = "0x50")]
		public SharedVector3 ArrivePosition;

		// Token: 0x0401B530 RID: 111920
		[Token(Token = "0x4017F59")]
		[FieldOffset(Offset = "0x58")]
		public SharedFloat JumpTime;

		// Token: 0x0401B531 RID: 111921
		[Token(Token = "0x4017F5A")]
		[FieldOffset(Offset = "0x60")]
		public SharedVector3 ReturnJumpVelocity;

		// Token: 0x0401B532 RID: 111922
		[Token(Token = "0x4017F5B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string JumpTimeKeyName;

		// Token: 0x0401B533 RID: 111923
		[Token(Token = "0x4017F5C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string JumpArrivePositionKeyName;

		// Token: 0x0401B534 RID: 111924
		[Token(Token = "0x4017F5D")]
		[FieldOffset(Offset = "0x68")]
		private AIInput AIInput;
	}
}
