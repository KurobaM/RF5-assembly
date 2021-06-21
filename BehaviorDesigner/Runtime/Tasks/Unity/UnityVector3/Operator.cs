using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001310 RID: 4880
	[Token(Token = "0x2000CDD")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C3A0", Offset = "0x14C4A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C3A0", Offset = "0x14C4A1")]
	public class Operator : Action
	{
		// Token: 0x06007341 RID: 29505 RVA: 0x00027C30 File Offset: 0x00025E30
		[Token(Token = "0x6005FF5")]
		[Address(RVA = "0x244AC50", Offset = "0x244AD51", VA = "0x244AC50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF6")]
		[Address(RVA = "0x244AE90", Offset = "0x244AF91", VA = "0x244AE90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF7")]
		[Address(RVA = "0x244AF50", Offset = "0x244B051", VA = "0x244AF50")]
		public Operator()
		{
		}

		// Token: 0x0401B625 RID: 112165
		[Token(Token = "0x401804E")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184590", Offset = "0x184691")]
		public Operator.Operation operation;

		// Token: 0x0401B626 RID: 112166
		[Token(Token = "0x401804F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1845D0", Offset = "0x1846D1")]
		public SharedVector3 firstVector3;

		// Token: 0x0401B627 RID: 112167
		[Token(Token = "0x4018050")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184610", Offset = "0x184711")]
		public SharedVector3 secondVector3;

		// Token: 0x0401B628 RID: 112168
		[Token(Token = "0x4018051")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184650", Offset = "0x184751")]
		public SharedVector3 storeResult;

		// Token: 0x02001311 RID: 4881
		[Token(Token = "0x200159F")]
		public enum Operation
		{
			// Token: 0x0401B62A RID: 112170
			[Token(Token = "0x401C1E4")]
			Add,
			// Token: 0x0401B62B RID: 112171
			[Token(Token = "0x401C1E5")]
			Subtract,
			// Token: 0x0401B62C RID: 112172
			[Token(Token = "0x401C1E6")]
			Scale
		}
	}
}
