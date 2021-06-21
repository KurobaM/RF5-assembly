using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200140A RID: 5130
	[Token(Token = "0x2000DD5")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1520F0", Offset = "0x1521F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1520F0", Offset = "0x1521F1")]
	public class BoolFlip : Action
	{
		// Token: 0x060076C0 RID: 30400 RVA: 0x00029370 File Offset: 0x00027570
		[Token(Token = "0x6006374")]
		[Address(RVA = "0x221C730", Offset = "0x221C831", VA = "0x221C730", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006375")]
		[Address(RVA = "0x221C7B0", Offset = "0x221C8B1", VA = "0x221C7B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006376")]
		[Address(RVA = "0x221C810", Offset = "0x221C911", VA = "0x221C810")]
		public BoolFlip()
		{
		}

		// Token: 0x0401B986 RID: 113030
		[Token(Token = "0x40183A7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D7E0", Offset = "0x18D8E1")]
		public SharedBool boolVariable;
	}
}
