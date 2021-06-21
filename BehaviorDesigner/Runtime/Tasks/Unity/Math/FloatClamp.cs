using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200140E RID: 5134
	[Token(Token = "0x2000DD8")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152210", Offset = "0x152311")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152210", Offset = "0x152311")]
	public class FloatClamp : Action
	{
		// Token: 0x060076C9 RID: 30409 RVA: 0x000293B8 File Offset: 0x000275B8
		[Token(Token = "0x600637D")]
		[Address(RVA = "0x221CC80", Offset = "0x221CD81", VA = "0x221CC80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637E")]
		[Address(RVA = "0x221CD70", Offset = "0x221CE71", VA = "0x221CD70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637F")]
		[Address(RVA = "0x221CF40", Offset = "0x221D041", VA = "0x221CF40")]
		public FloatClamp()
		{
		}

		// Token: 0x0401B991 RID: 113041
		[Token(Token = "0x40183AD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D960", Offset = "0x18DA61")]
		public SharedFloat floatVariable;

		// Token: 0x0401B992 RID: 113042
		[Token(Token = "0x40183AE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D9A0", Offset = "0x18DAA1")]
		public SharedFloat minValue;

		// Token: 0x0401B993 RID: 113043
		[Token(Token = "0x40183AF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D9E0", Offset = "0x18DAE1")]
		public SharedFloat maxValue;
	}
}
