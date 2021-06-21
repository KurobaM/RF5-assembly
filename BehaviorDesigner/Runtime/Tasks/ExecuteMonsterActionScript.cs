using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012C5 RID: 4805
	[Token(Token = "0x2000C92")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A5D0", Offset = "0x14A6D1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A5D0", Offset = "0x14A6D1")]
	public class ExecuteMonsterActionScript : Action
	{
		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060071DE RID: 29150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B30")]
		public MonsterBehaviorController MonsterBehaviorController
		{
			[Token(Token = "0x6005E92")]
			[Address(RVA = "0x2210A10", Offset = "0x2210B11", VA = "0x2210A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E93")]
		[Address(RVA = "0x2210AD0", Offset = "0x2210BD1", VA = "0x2210AD0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060071E0 RID: 29152 RVA: 0x000271F8 File Offset: 0x000253F8
		[Token(Token = "0x6005E94")]
		[Address(RVA = "0x2210BB0", Offset = "0x2210CB1", VA = "0x2210BB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E95")]
		[Address(RVA = "0x2210FA0", Offset = "0x22110A1", VA = "0x2210FA0")]
		public ExecuteMonsterActionScript()
		{
		}

		// Token: 0x0401B528 RID: 111912
		[Token(Token = "0x4017F51")]
		[FieldOffset(Offset = "0x50")]
		public SharedBool UseBaseActionScript;

		// Token: 0x0401B529 RID: 111913
		[Token(Token = "0x4017F52")]
		[FieldOffset(Offset = "0x58")]
		private MonsterBehaviorController _MonsterBehaviorController;
	}
}
