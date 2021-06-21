using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012D4 RID: 4820
	[Token(Token = "0x2000CA1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14ABE0", Offset = "0x14ACE1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14ABE0", Offset = "0x14ACE1")]
	public class Idle : Action
	{
		// Token: 0x06007216 RID: 29206 RVA: 0x00027378 File Offset: 0x00025578
		[Token(Token = "0x6005ECA")]
		[Address(RVA = "0x2213C00", Offset = "0x2213D01", VA = "0x2213C00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECB")]
		[Address(RVA = "0x2213C10", Offset = "0x2213D11", VA = "0x2213C10")]
		public Idle()
		{
		}
	}
}
