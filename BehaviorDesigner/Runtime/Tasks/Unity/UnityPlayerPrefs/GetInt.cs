using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	// Token: 0x020013CE RID: 5070
	[Token(Token = "0x2000D99")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150A70", Offset = "0x150B71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150A70", Offset = "0x150B71")]
	public class GetInt : Action
	{
		// Token: 0x060075DF RID: 30175 RVA: 0x00028DD0 File Offset: 0x00026FD0
		[Token(Token = "0x6006293")]
		[Address(RVA = "0x298DB60", Offset = "0x298DC61", VA = "0x298DB60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006294")]
		[Address(RVA = "0x298DC20", Offset = "0x298DD21", VA = "0x298DC20", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006295")]
		[Address(RVA = "0x298DCC0", Offset = "0x298DDC1", VA = "0x298DCC0")]
		public GetInt()
		{
		}

		// Token: 0x0401B89B RID: 112795
		[Token(Token = "0x40182BC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B210", Offset = "0x18B311")]
		public SharedString key;

		// Token: 0x0401B89C RID: 112796
		[Token(Token = "0x40182BD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B250", Offset = "0x18B351")]
		public SharedInt defaultValue;

		// Token: 0x0401B89D RID: 112797
		[Token(Token = "0x40182BE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B290", Offset = "0x18B391")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18B290", Offset = "0x18B391")]
		public SharedInt storeResult;
	}
}
