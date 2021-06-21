using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001372 RID: 4978
	[Token(Token = "0x2000D3D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E7A0", Offset = "0x14E8A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E7A0", Offset = "0x14E8A1")]
	public class SetSharedInt : Action
	{
		// Token: 0x0600748B RID: 29835 RVA: 0x00028530 File Offset: 0x00026730
		[Token(Token = "0x600613F")]
		[Address(RVA = "0x28D0480", Offset = "0x28D0581", VA = "0x28D0480", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006140")]
		[Address(RVA = "0x28D0500", Offset = "0x28D0601", VA = "0x28D0500", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006141")]
		[Address(RVA = "0x28D0550", Offset = "0x28D0651", VA = "0x28D0550")]
		public SetSharedInt()
		{
		}

		// Token: 0x0401B75C RID: 112476
		[Token(Token = "0x401817D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187EE0", Offset = "0x187FE1")]
		public SharedInt targetValue;

		// Token: 0x0401B75D RID: 112477
		[Token(Token = "0x401817E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x187F20", Offset = "0x188021")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187F20", Offset = "0x188021")]
		public SharedInt targetVariable;
	}
}
