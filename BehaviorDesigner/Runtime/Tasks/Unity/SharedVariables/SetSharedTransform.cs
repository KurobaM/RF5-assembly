using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001378 RID: 4984
	[Token(Token = "0x2000D43")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E9E0", Offset = "0x14EAE1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E9E0", Offset = "0x14EAE1")]
	public class SetSharedTransform : Action
	{
		// Token: 0x0600749D RID: 29853 RVA: 0x000285C0 File Offset: 0x000267C0
		[Token(Token = "0x6006151")]
		[Address(RVA = "0x28D0A50", Offset = "0x28D0B51", VA = "0x28D0A50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600749E RID: 29854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006152")]
		[Address(RVA = "0x28D0B30", Offset = "0x28D0C31", VA = "0x28D0B30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600749F RID: 29855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006153")]
		[Address(RVA = "0x28D0B70", Offset = "0x28D0C71", VA = "0x28D0B70")]
		public SetSharedTransform()
		{
		}

		// Token: 0x0401B768 RID: 112488
		[Token(Token = "0x4018189")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188240", Offset = "0x188341")]
		public SharedTransform targetValue;

		// Token: 0x0401B769 RID: 112489
		[Token(Token = "0x401818A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188280", Offset = "0x188381")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188280", Offset = "0x188381")]
		public SharedTransform targetVariable;
	}
}
