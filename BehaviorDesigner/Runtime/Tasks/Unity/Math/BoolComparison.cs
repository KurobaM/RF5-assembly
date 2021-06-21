using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x02001409 RID: 5129
	[Token(Token = "0x2000DD4")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152090", Offset = "0x152191")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152090", Offset = "0x152191")]
	public class BoolComparison : Conditional
	{
		// Token: 0x060076BD RID: 30397 RVA: 0x00029358 File Offset: 0x00027558
		[Token(Token = "0x6006371")]
		[Address(RVA = "0x221C560", Offset = "0x221C661", VA = "0x221C560", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006372")]
		[Address(RVA = "0x221C5F0", Offset = "0x221C6F1", VA = "0x221C5F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006373")]
		[Address(RVA = "0x221C720", Offset = "0x221C821", VA = "0x221C720")]
		public BoolComparison()
		{
		}

		// Token: 0x0401B984 RID: 113028
		[Token(Token = "0x40183A5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D760", Offset = "0x18D861")]
		public SharedBool bool1;

		// Token: 0x0401B985 RID: 113029
		[Token(Token = "0x40183A6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D7A0", Offset = "0x18D8A1")]
		public SharedBool bool2;
	}
}
