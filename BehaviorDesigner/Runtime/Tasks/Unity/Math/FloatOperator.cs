using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x02001411 RID: 5137
	[Token(Token = "0x2000DDA")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1522D0", Offset = "0x1523D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1522D0", Offset = "0x1523D1")]
	public class FloatOperator : Action
	{
		// Token: 0x060076CF RID: 30415 RVA: 0x000293E8 File Offset: 0x000275E8
		[Token(Token = "0x6006383")]
		[Address(RVA = "0x221D270", Offset = "0x221D371", VA = "0x221D270", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006384")]
		[Address(RVA = "0x221D520", Offset = "0x221D621", VA = "0x221D520", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076D1 RID: 30417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006385")]
		[Address(RVA = "0x221D6F0", Offset = "0x221D7F1", VA = "0x221D6F0")]
		public FloatOperator()
		{
		}

		// Token: 0x0401B99E RID: 113054
		[Token(Token = "0x40183B3")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DAE0", Offset = "0x18DBE1")]
		public FloatOperator.Operation operation;

		// Token: 0x0401B99F RID: 113055
		[Token(Token = "0x40183B4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DB20", Offset = "0x18DC21")]
		public SharedFloat float1;

		// Token: 0x0401B9A0 RID: 113056
		[Token(Token = "0x40183B5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DB60", Offset = "0x18DC61")]
		public SharedFloat float2;

		// Token: 0x0401B9A1 RID: 113057
		[Token(Token = "0x40183B6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DBA0", Offset = "0x18DCA1")]
		public SharedFloat storeResult;

		// Token: 0x02001412 RID: 5138
		[Token(Token = "0x20015A3")]
		public enum Operation
		{
			// Token: 0x0401B9A3 RID: 113059
			[Token(Token = "0x401C1F8")]
			Add,
			// Token: 0x0401B9A4 RID: 113060
			[Token(Token = "0x401C1F9")]
			Subtract,
			// Token: 0x0401B9A5 RID: 113061
			[Token(Token = "0x401C1FA")]
			Multiply,
			// Token: 0x0401B9A6 RID: 113062
			[Token(Token = "0x401C1FB")]
			Divide,
			// Token: 0x0401B9A7 RID: 113063
			[Token(Token = "0x401C1FC")]
			Min,
			// Token: 0x0401B9A8 RID: 113064
			[Token(Token = "0x401C1FD")]
			Max,
			// Token: 0x0401B9A9 RID: 113065
			[Token(Token = "0x401C1FE")]
			Modulo
		}
	}
}
