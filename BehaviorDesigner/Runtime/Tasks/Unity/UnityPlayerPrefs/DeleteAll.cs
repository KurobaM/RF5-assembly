using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	// Token: 0x020013CB RID: 5067
	[Token(Token = "0x2000D96")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150950", Offset = "0x150A51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150950", Offset = "0x150A51")]
	public class DeleteAll : Action
	{
		// Token: 0x060075D7 RID: 30167 RVA: 0x00028D88 File Offset: 0x00026F88
		[Token(Token = "0x600628B")]
		[Address(RVA = "0x298D8E0", Offset = "0x298D9E1", VA = "0x298D8E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628C")]
		[Address(RVA = "0x298D900", Offset = "0x298DA01", VA = "0x298D900")]
		public DeleteAll()
		{
		}
	}
}
