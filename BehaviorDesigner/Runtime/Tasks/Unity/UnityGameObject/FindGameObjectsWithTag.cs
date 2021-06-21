using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x0200144B RID: 5195
	[Token(Token = "0x2000E11")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153770", Offset = "0x153871")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153770", Offset = "0x153871")]
	public class FindGameObjectsWithTag : Action
	{
		// Token: 0x06007785 RID: 30597 RVA: 0x00029910 File Offset: 0x00027B10
		[Token(Token = "0x6006439")]
		[Address(RVA = "0x28E5250", Offset = "0x28E5351", VA = "0x28E5250", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643A")]
		[Address(RVA = "0x28E5340", Offset = "0x28E5441", VA = "0x28E5340", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007787 RID: 30599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643B")]
		[Address(RVA = "0x28E53C0", Offset = "0x28E54C1", VA = "0x28E53C0")]
		public FindGameObjectsWithTag()
		{
		}

		// Token: 0x0401BA48 RID: 113224
		[Token(Token = "0x4018446")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F7D0", Offset = "0x18F8D1")]
		public SharedString tag;

		// Token: 0x0401BA49 RID: 113225
		[Token(Token = "0x4018447")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F810", Offset = "0x18F911")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18F810", Offset = "0x18F911")]
		public SharedGameObjectList storeValue;
	}
}
