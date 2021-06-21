using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x02001417 RID: 5143
	[Token(Token = "0x2000DDE")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152450", Offset = "0x152551")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152450", Offset = "0x152551")]
	public class IntOperator : Action
	{
		// Token: 0x060076DB RID: 30427 RVA: 0x00029448 File Offset: 0x00027648
		[Token(Token = "0x600638F")]
		[Address(RVA = "0x221DDD0", Offset = "0x221DED1", VA = "0x221DDD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006390")]
		[Address(RVA = "0x221E070", Offset = "0x221E171", VA = "0x221E070", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006391")]
		[Address(RVA = "0x221E210", Offset = "0x221E311", VA = "0x221E210")]
		public IntOperator()
		{
		}

		// Token: 0x0401B9B8 RID: 113080
		[Token(Token = "0x40183BE")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DDA0", Offset = "0x18DEA1")]
		public IntOperator.Operation operation;

		// Token: 0x0401B9B9 RID: 113081
		[Token(Token = "0x40183BF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DDE0", Offset = "0x18DEE1")]
		public SharedInt integer1;

		// Token: 0x0401B9BA RID: 113082
		[Token(Token = "0x40183C0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DE20", Offset = "0x18DF21")]
		public SharedInt integer2;

		// Token: 0x0401B9BB RID: 113083
		[Token(Token = "0x40183C1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18DE60", Offset = "0x18DF61")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DE60", Offset = "0x18DF61")]
		public SharedInt storeResult;

		// Token: 0x02001418 RID: 5144
		[Token(Token = "0x20015A5")]
		public enum Operation
		{
			// Token: 0x0401B9BD RID: 113085
			[Token(Token = "0x401C207")]
			Add,
			// Token: 0x0401B9BE RID: 113086
			[Token(Token = "0x401C208")]
			Subtract,
			// Token: 0x0401B9BF RID: 113087
			[Token(Token = "0x401C209")]
			Multiply,
			// Token: 0x0401B9C0 RID: 113088
			[Token(Token = "0x401C20A")]
			Divide,
			// Token: 0x0401B9C1 RID: 113089
			[Token(Token = "0x401C20B")]
			Min,
			// Token: 0x0401B9C2 RID: 113090
			[Token(Token = "0x401C20C")]
			Max,
			// Token: 0x0401B9C3 RID: 113091
			[Token(Token = "0x401C20D")]
			Modulo
		}
	}
}
