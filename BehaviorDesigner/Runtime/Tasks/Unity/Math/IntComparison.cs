using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x02001415 RID: 5141
	[Token(Token = "0x2000DDD")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1523F0", Offset = "0x1524F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1523F0", Offset = "0x1524F1")]
	public class IntComparison : Conditional
	{
		// Token: 0x060076D8 RID: 30424 RVA: 0x00029430 File Offset: 0x00027630
		[Token(Token = "0x600638C")]
		[Address(RVA = "0x221DB10", Offset = "0x221DC11", VA = "0x221DB10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638D")]
		[Address(RVA = "0x221DD40", Offset = "0x221DE41", VA = "0x221DD40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638E")]
		[Address(RVA = "0x221DDC0", Offset = "0x221DEC1", VA = "0x221DDC0")]
		public IntComparison()
		{
		}

		// Token: 0x0401B9AE RID: 113070
		[Token(Token = "0x40183BB")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DCE0", Offset = "0x18DDE1")]
		public IntComparison.Operation operation;

		// Token: 0x0401B9AF RID: 113071
		[Token(Token = "0x40183BC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DD20", Offset = "0x18DE21")]
		public SharedInt integer1;

		// Token: 0x0401B9B0 RID: 113072
		[Token(Token = "0x40183BD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DD60", Offset = "0x18DE61")]
		public SharedInt integer2;

		// Token: 0x02001416 RID: 5142
		[Token(Token = "0x20015A4")]
		public enum Operation
		{
			// Token: 0x0401B9B2 RID: 113074
			[Token(Token = "0x401C200")]
			LessThan,
			// Token: 0x0401B9B3 RID: 113075
			[Token(Token = "0x401C201")]
			LessThanOrEqualTo,
			// Token: 0x0401B9B4 RID: 113076
			[Token(Token = "0x401C202")]
			EqualTo,
			// Token: 0x0401B9B5 RID: 113077
			[Token(Token = "0x401C203")]
			NotEqualTo,
			// Token: 0x0401B9B6 RID: 113078
			[Token(Token = "0x401C204")]
			GreaterThanOrEqualTo,
			// Token: 0x0401B9B7 RID: 113079
			[Token(Token = "0x401C205")]
			GreaterThan
		}
	}
}
