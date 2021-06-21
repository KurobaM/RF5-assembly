using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	// Token: 0x020013CC RID: 5068
	[Token(Token = "0x2000D97")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1509B0", Offset = "0x150AB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1509B0", Offset = "0x150AB1")]
	public class DeleteKey : Action
	{
		// Token: 0x060075D9 RID: 30169 RVA: 0x00028DA0 File Offset: 0x00026FA0
		[Token(Token = "0x600628D")]
		[Address(RVA = "0x298D910", Offset = "0x298DA11", VA = "0x298D910", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628E")]
		[Address(RVA = "0x298D980", Offset = "0x298DA81", VA = "0x298D980", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628F")]
		[Address(RVA = "0x298D9E0", Offset = "0x298DAE1", VA = "0x298D9E0")]
		public DeleteKey()
		{
		}

		// Token: 0x0401B897 RID: 112791
		[Token(Token = "0x40182B8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B100", Offset = "0x18B201")]
		public SharedString key;
	}
}
