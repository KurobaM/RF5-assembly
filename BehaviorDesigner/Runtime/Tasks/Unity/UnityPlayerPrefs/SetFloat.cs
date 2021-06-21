using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPlayerPrefs
{
	// Token: 0x020013D2 RID: 5074
	[Token(Token = "0x2000D9D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150BF0", Offset = "0x150CF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150BF0", Offset = "0x150CF1")]
	public class SetFloat : Action
	{
		// Token: 0x060075EA RID: 30186 RVA: 0x00028E30 File Offset: 0x00027030
		[Token(Token = "0x600629E")]
		[Address(RVA = "0x298DF40", Offset = "0x298E041", VA = "0x298DF40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629F")]
		[Address(RVA = "0x298DFD0", Offset = "0x298E0D1", VA = "0x298DFD0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A0")]
		[Address(RVA = "0x298E050", Offset = "0x298E151", VA = "0x298E050")]
		public SetFloat()
		{
		}

		// Token: 0x0401B8A2 RID: 112802
		[Token(Token = "0x40182C3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B3F0", Offset = "0x18B4F1")]
		public SharedString key;

		// Token: 0x0401B8A3 RID: 112803
		[Token(Token = "0x40182C4")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B430", Offset = "0x18B531")]
		public SharedFloat value;
	}
}
