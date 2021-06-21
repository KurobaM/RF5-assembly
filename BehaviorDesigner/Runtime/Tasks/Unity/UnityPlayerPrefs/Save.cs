using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	// Token: 0x020013D1 RID: 5073
	[Token(Token = "0x2000D9C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150B90", Offset = "0x150C91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150B90", Offset = "0x150C91")]
	public class Save : Action
	{
		// Token: 0x060075E8 RID: 30184 RVA: 0x00028E18 File Offset: 0x00027018
		[Token(Token = "0x600629C")]
		[Address(RVA = "0x298DF10", Offset = "0x298E011", VA = "0x298DF10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629D")]
		[Address(RVA = "0x298DF30", Offset = "0x298E031", VA = "0x298DF30")]
		public Save()
		{
		}
	}
}
