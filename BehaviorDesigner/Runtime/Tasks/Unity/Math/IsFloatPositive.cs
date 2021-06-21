using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x02001419 RID: 5145
	[Token(Token = "0x2000DDF")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1524B0", Offset = "0x1525B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1524B0", Offset = "0x1525B1")]
	public class IsFloatPositive : Conditional
	{
		// Token: 0x060076DE RID: 30430 RVA: 0x00029460 File Offset: 0x00027660
		[Token(Token = "0x6006392")]
		[Address(RVA = "0x221E220", Offset = "0x221E321", VA = "0x221E220", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006393")]
		[Address(RVA = "0x221E290", Offset = "0x221E391", VA = "0x221E290", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006394")]
		[Address(RVA = "0x221E350", Offset = "0x221E451", VA = "0x221E350")]
		public IsFloatPositive()
		{
		}

		// Token: 0x0401B9C4 RID: 113092
		[Token(Token = "0x40183C2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18DEB0", Offset = "0x18DFB1")]
		public SharedFloat floatVariable;
	}
}
