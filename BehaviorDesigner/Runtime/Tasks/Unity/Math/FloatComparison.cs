using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200140F RID: 5135
	[Token(Token = "0x2000DD9")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152270", Offset = "0x152371")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152270", Offset = "0x152371")]
	public class FloatComparison : Conditional
	{
		// Token: 0x060076CC RID: 30412 RVA: 0x000293D0 File Offset: 0x000275D0
		[Token(Token = "0x6006380")]
		[Address(RVA = "0x221CF50", Offset = "0x221D051", VA = "0x221CF50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076CD RID: 30413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006381")]
		[Address(RVA = "0x221D1E0", Offset = "0x221D2E1", VA = "0x221D1E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076CE RID: 30414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006382")]
		[Address(RVA = "0x221D260", Offset = "0x221D361", VA = "0x221D260")]
		public FloatComparison()
		{
		}

		// Token: 0x0401B994 RID: 113044
		[Token(Token = "0x40183B0")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DA20", Offset = "0x18DB21")]
		public FloatComparison.Operation operation;

		// Token: 0x0401B995 RID: 113045
		[Token(Token = "0x40183B1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DA60", Offset = "0x18DB61")]
		public SharedFloat float1;

		// Token: 0x0401B996 RID: 113046
		[Token(Token = "0x40183B2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DAA0", Offset = "0x18DBA1")]
		public SharedFloat float2;

		// Token: 0x02001410 RID: 5136
		[Token(Token = "0x20015A2")]
		public enum Operation
		{
			// Token: 0x0401B998 RID: 113048
			[Token(Token = "0x401C1F1")]
			LessThan,
			// Token: 0x0401B999 RID: 113049
			[Token(Token = "0x401C1F2")]
			LessThanOrEqualTo,
			// Token: 0x0401B99A RID: 113050
			[Token(Token = "0x401C1F3")]
			EqualTo,
			// Token: 0x0401B99B RID: 113051
			[Token(Token = "0x401C1F4")]
			NotEqualTo,
			// Token: 0x0401B99C RID: 113052
			[Token(Token = "0x401C1F5")]
			GreaterThanOrEqualTo,
			// Token: 0x0401B99D RID: 113053
			[Token(Token = "0x401C1F6")]
			GreaterThan
		}
	}
}
