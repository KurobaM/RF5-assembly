using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200136D RID: 4973
	[Token(Token = "0x2000D38")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E5C0", Offset = "0x14E6C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E5C0", Offset = "0x14E6C1")]
	public class SetSharedBool : Action
	{
		// Token: 0x0600747C RID: 29820 RVA: 0x000284B8 File Offset: 0x000266B8
		[Token(Token = "0x6006130")]
		[Address(RVA = "0x22216A0", Offset = "0x22217A1", VA = "0x22216A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600747D RID: 29821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006131")]
		[Address(RVA = "0x2221720", Offset = "0x2221821", VA = "0x2221720", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600747E RID: 29822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006132")]
		[Address(RVA = "0x2221850", Offset = "0x2221951", VA = "0x2221850")]
		public SetSharedBool()
		{
		}

		// Token: 0x0401B751 RID: 112465
		[Token(Token = "0x4018172")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187BD0", Offset = "0x187CD1")]
		public SharedBool targetValue;

		// Token: 0x0401B752 RID: 112466
		[Token(Token = "0x4018173")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x187C10", Offset = "0x187D11")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187C10", Offset = "0x187D11")]
		public SharedBool targetVariable;
	}
}
