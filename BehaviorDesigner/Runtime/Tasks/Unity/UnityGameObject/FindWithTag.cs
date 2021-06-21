using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x0200144C RID: 5196
	[Token(Token = "0x2000E12")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1537D0", Offset = "0x1538D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1537D0", Offset = "0x1538D1")]
	public class FindWithTag : Action
	{
		// Token: 0x06007788 RID: 30600 RVA: 0x00029928 File Offset: 0x00027B28
		[Token(Token = "0x600643C")]
		[Address(RVA = "0x28E53D0", Offset = "0x28E54D1", VA = "0x28E53D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643D")]
		[Address(RVA = "0x28E5550", Offset = "0x28E5651", VA = "0x28E5550", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643E")]
		[Address(RVA = "0x28E55D0", Offset = "0x28E56D1", VA = "0x28E55D0")]
		public FindWithTag()
		{
		}

		// Token: 0x0401BA4A RID: 113226
		[Token(Token = "0x4018448")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F860", Offset = "0x18F961")]
		public SharedString tag;

		// Token: 0x0401BA4B RID: 113227
		[Token(Token = "0x4018449")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F8A0", Offset = "0x18F9A1")]
		public SharedBool random;

		// Token: 0x0401BA4C RID: 113228
		[Token(Token = "0x401844A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F8E0", Offset = "0x18F9E1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18F8E0", Offset = "0x18F9E1")]
		public SharedGameObject storeValue;
	}
}
