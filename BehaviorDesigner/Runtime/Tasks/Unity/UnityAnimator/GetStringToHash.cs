using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014AA RID: 5290
	[Token(Token = "0x2000E70")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155B10", Offset = "0x155C11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155B10", Offset = "0x155C11")]
	public class GetStringToHash : Action
	{
		// Token: 0x060078F3 RID: 30963 RVA: 0x0002A210 File Offset: 0x00028410
		[Token(Token = "0x60065A7")]
		[Address(RVA = "0x28D5E70", Offset = "0x28D5F71", VA = "0x28D5E70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A8")]
		[Address(RVA = "0x28D5F00", Offset = "0x28D6001", VA = "0x28D5F00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078F5 RID: 30965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065A9")]
		[Address(RVA = "0x28D5F80", Offset = "0x28D6081", VA = "0x28D5F80")]
		public GetStringToHash()
		{
		}

		// Token: 0x0401BBB0 RID: 113584
		[Token(Token = "0x40185AE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192CC0", Offset = "0x192DC1")]
		public SharedString stateName;

		// Token: 0x0401BBB1 RID: 113585
		[Token(Token = "0x40185AF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192D00", Offset = "0x192E01")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x192D00", Offset = "0x192E01")]
		public SharedInt storeValue;
	}
}
