using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012CA RID: 4810
	[Token(Token = "0x2000C97")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A7E0", Offset = "0x14A8E1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A7E0", Offset = "0x14A8E1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14A7E0", Offset = "0x14A8E1")]
	public class SetActiveMonsterNavMeshAgent : Action
	{
		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x060071F2 RID: 29170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B31")]
		public MonsterBehaviorController MonsterBehaviorController
		{
			[Token(Token = "0x6005EA6")]
			[Address(RVA = "0x221A190", Offset = "0x221A291", VA = "0x221A190")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x00027270 File Offset: 0x00025470
		[Token(Token = "0x6005EA7")]
		[Address(RVA = "0x221A250", Offset = "0x221A351", VA = "0x221A250", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA8")]
		[Address(RVA = "0x221A450", Offset = "0x221A551", VA = "0x221A450")]
		public SetActiveMonsterNavMeshAgent()
		{
		}

		// Token: 0x0401B539 RID: 111929
		[Token(Token = "0x4017F62")]
		[FieldOffset(Offset = "0x50")]
		public MonsterBehaviorController _MonsterBehaviorController;

		// Token: 0x0401B53A RID: 111930
		[Token(Token = "0x4017F63")]
		[FieldOffset(Offset = "0x58")]
		public SharedBool UseNavMeshAgent;

		// Token: 0x0401B53B RID: 111931
		[Token(Token = "0x4017F64")]
		[FieldOffset(Offset = "0x60")]
		public SharedBool IsActive;
	}
}
