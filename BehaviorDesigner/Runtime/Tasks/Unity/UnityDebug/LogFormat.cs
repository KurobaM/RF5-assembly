using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityDebug
{
	// Token: 0x02001455 RID: 5205
	[Token(Token = "0x2000E1B")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153B30", Offset = "0x153C31")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x153B30", Offset = "0x153C31")]
	public class LogFormat : Action
	{
		// Token: 0x060077A3 RID: 30627 RVA: 0x00029A00 File Offset: 0x00027C00
		[Token(Token = "0x6006457")]
		[Address(RVA = "0x28E4660", Offset = "0x28E4761", VA = "0x28E4660", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006458")]
		[Address(RVA = "0x28E4750", Offset = "0x28E4851", VA = "0x28E4750")]
		private object[] buildParamsArray()
		{
			return null;
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x00029A18 File Offset: 0x00027C18
		[Token(Token = "0x6006459")]
		[Address(RVA = "0x28E4A10", Offset = "0x28E4B11", VA = "0x28E4A10")]
		private bool isValid(SharedVariable sv)
		{
			return default(bool);
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645A")]
		[Address(RVA = "0x28E4A40", Offset = "0x28E4B41", VA = "0x28E4A40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645B")]
		[Address(RVA = "0x28E4B10", Offset = "0x28E4C11", VA = "0x28E4B10")]
		public LogFormat()
		{
		}

		// Token: 0x0401BA65 RID: 113253
		[Token(Token = "0x4018463")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FF60", Offset = "0x190061")]
		public SharedString textFormat;

		// Token: 0x0401BA66 RID: 113254
		[Token(Token = "0x4018464")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FFA0", Offset = "0x1900A1")]
		public SharedBool logError;

		// Token: 0x0401BA67 RID: 113255
		[Token(Token = "0x4018465")]
		[FieldOffset(Offset = "0x60")]
		public SharedVariable arg0;

		// Token: 0x0401BA68 RID: 113256
		[Token(Token = "0x4018466")]
		[FieldOffset(Offset = "0x68")]
		public SharedVariable arg1;

		// Token: 0x0401BA69 RID: 113257
		[Token(Token = "0x4018467")]
		[FieldOffset(Offset = "0x70")]
		public SharedVariable arg2;

		// Token: 0x0401BA6A RID: 113258
		[Token(Token = "0x4018468")]
		[FieldOffset(Offset = "0x78")]
		public SharedVariable arg3;
	}
}
