using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012C0 RID: 4800
	[Token(Token = "0x2000C8D")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A380", Offset = "0x14A481")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A380", Offset = "0x14A481")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14A380", Offset = "0x14A481")]
	public class EnemySetPatrolParameter : Action
	{
		// Token: 0x060071C7 RID: 29127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7B")]
		[Address(RVA = "0x22107A0", Offset = "0x22108A1", VA = "0x22107A0", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x00027180 File Offset: 0x00025380
		[Token(Token = "0x6005E7C")]
		[Address(RVA = "0x2210870", Offset = "0x2210971", VA = "0x2210870", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071C9 RID: 29129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7D")]
		[Address(RVA = "0x2210990", Offset = "0x2210A91", VA = "0x2210990", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071CA RID: 29130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7E")]
		[Address(RVA = "0x22109E0", Offset = "0x2210AE1", VA = "0x22109E0")]
		public EnemySetPatrolParameter()
		{
		}

		// Token: 0x0401B510 RID: 111888
		[Token(Token = "0x4017F39")]
		[FieldOffset(Offset = "0x50")]
		private EnemyBehaviorController Controller;

		// Token: 0x0401B511 RID: 111889
		[Token(Token = "0x4017F3A")]
		[FieldOffset(Offset = "0x58")]
		public SharedEnemyBehaviorTreeState SharedEnemyBehaviorTreeState;

		// Token: 0x0401B512 RID: 111890
		[Token(Token = "0x4017F3B")]
		[FieldOffset(Offset = "0x60")]
		public SharedMovementBehaviorType ReturnSharedMovementBehaviorType;

		// Token: 0x0401B513 RID: 111891
		[Token(Token = "0x4017F3C")]
		[FieldOffset(Offset = "0x68")]
		public SharedFloat ReturnMoveSpeedScale;

		// Token: 0x0401B514 RID: 111892
		[Token(Token = "0x4017F3D")]
		[FieldOffset(Offset = "0x70")]
		public SharedFloat ReturnMoveTime;
	}
}
