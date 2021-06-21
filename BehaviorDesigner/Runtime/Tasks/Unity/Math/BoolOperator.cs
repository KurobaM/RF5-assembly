using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200140B RID: 5131
	[Token(Token = "0x2000DD6")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152150", Offset = "0x152251")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152150", Offset = "0x152251")]
	public class BoolOperator : Action
	{
		// Token: 0x060076C3 RID: 30403 RVA: 0x00029388 File Offset: 0x00027588
		[Token(Token = "0x6006377")]
		[Address(RVA = "0x221C820", Offset = "0x221C921", VA = "0x221C820", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076C4 RID: 30404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006378")]
		[Address(RVA = "0x221C9C0", Offset = "0x221CAC1", VA = "0x221C9C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076C5 RID: 30405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006379")]
		[Address(RVA = "0x221CAF0", Offset = "0x221CBF1", VA = "0x221CAF0")]
		public BoolOperator()
		{
		}

		// Token: 0x0401B987 RID: 113031
		[Token(Token = "0x40183A8")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D820", Offset = "0x18D921")]
		public BoolOperator.Operation operation;

		// Token: 0x0401B988 RID: 113032
		[Token(Token = "0x40183A9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D860", Offset = "0x18D961")]
		public SharedBool bool1;

		// Token: 0x0401B989 RID: 113033
		[Token(Token = "0x40183AA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D8A0", Offset = "0x18D9A1")]
		public SharedBool bool2;

		// Token: 0x0401B98A RID: 113034
		[Token(Token = "0x40183AB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D8E0", Offset = "0x18D9E1")]
		public SharedBool storeResult;

		// Token: 0x0200140C RID: 5132
		[Token(Token = "0x20015A1")]
		public enum Operation
		{
			// Token: 0x0401B98C RID: 113036
			[Token(Token = "0x401C1EC")]
			AND,
			// Token: 0x0401B98D RID: 113037
			[Token(Token = "0x401C1ED")]
			OR,
			// Token: 0x0401B98E RID: 113038
			[Token(Token = "0x401C1EE")]
			NAND,
			// Token: 0x0401B98F RID: 113039
			[Token(Token = "0x401C1EF")]
			XOR
		}
	}
}
