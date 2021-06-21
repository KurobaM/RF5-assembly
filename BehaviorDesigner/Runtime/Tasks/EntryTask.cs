using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x02001300 RID: 4864
	[Token(Token = "0x2000CCD")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14BDC0", Offset = "0x14BEC1")]
	public class EntryTask : ParentTask
	{
		// Token: 0x06007312 RID: 29458 RVA: 0x00027AB0 File Offset: 0x00025CB0
		[Token(Token = "0x6005FC6")]
		[Address(RVA = "0x22109F0", Offset = "0x2210AF1", VA = "0x22109F0", Slot = "30")]
		public override int MaxChildren()
		{
			return 0;
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0x2210A00", Offset = "0x2210B01", VA = "0x2210A00")]
		public EntryTask()
		{
		}
	}
}
