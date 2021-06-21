using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012C2 RID: 4802
	[Token(Token = "0x2000C8F")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A470", Offset = "0x14A571")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A470", Offset = "0x14A571")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14A470", Offset = "0x14A571")]
	public class CalcBehaviorParameter : Action
	{
		// Token: 0x060071D1 RID: 29137 RVA: 0x000271B0 File Offset: 0x000253B0
		[Token(Token = "0x6005E85")]
		[Address(RVA = "0x220F4C0", Offset = "0x220F5C1", VA = "0x220F4C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E86")]
		[Address(RVA = "0x220F5D0", Offset = "0x220F6D1", VA = "0x220F5D0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071D3 RID: 29139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E87")]
		[Address(RVA = "0x220F630", Offset = "0x220F731", VA = "0x220F630")]
		public CalcBehaviorParameter()
		{
		}

		// Token: 0x0401B51A RID: 111898
		[Token(Token = "0x4017F43")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181960", Offset = "0x181A61")]
		public SharedFloat MoveSpeedMax;

		// Token: 0x0401B51B RID: 111899
		[Token(Token = "0x4017F44")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1819A0", Offset = "0x181AA1")]
		public SharedFloat ReturnArriveDistance;

		// Token: 0x0401B51C RID: 111900
		[Token(Token = "0x4017F45")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1819E0", Offset = "0x181AE1")]
		public SharedFloat AngularSpeed;

		// Token: 0x0401B51D RID: 111901
		[Token(Token = "0x4017F46")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181A20", Offset = "0x181B21")]
		public SharedFloat ReturnRotationDelta;
	}
}
