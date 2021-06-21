using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	// Token: 0x020013D0 RID: 5072
	[Token(Token = "0x2000D9B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150B30", Offset = "0x150C31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150B30", Offset = "0x150C31")]
	public class HasKey : Conditional
	{
		// Token: 0x060075E5 RID: 30181 RVA: 0x00028E00 File Offset: 0x00027000
		[Token(Token = "0x6006299")]
		[Address(RVA = "0x298DE30", Offset = "0x298DF31", VA = "0x298DE30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629A")]
		[Address(RVA = "0x298DEA0", Offset = "0x298DFA1", VA = "0x298DEA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629B")]
		[Address(RVA = "0x298DF00", Offset = "0x298E001", VA = "0x298DF00")]
		public HasKey()
		{
		}

		// Token: 0x0401B8A1 RID: 112801
		[Token(Token = "0x40182C2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B3B0", Offset = "0x18B4B1")]
		public SharedString key;
	}
}
