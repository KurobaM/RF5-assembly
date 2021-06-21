using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012EB RID: 4843
	[Token(Token = "0x2000CB8")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B5A0", Offset = "0x14B6A1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14B5A0", Offset = "0x14B6A1")]
	public class HasReceivedEvent : Conditional
	{
		// Token: 0x060072A2 RID: 29346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F56")]
		[Address(RVA = "0x22131F0", Offset = "0x22132F1", VA = "0x22131F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x000277E0 File Offset: 0x000259E0
		[Token(Token = "0x6005F57")]
		[Address(RVA = "0x2213400", Offset = "0x2213501", VA = "0x2213400", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F58")]
		[Address(RVA = "0x2213420", Offset = "0x2213521", VA = "0x2213420", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F59")]
		[Address(RVA = "0x2213630", Offset = "0x2213731", VA = "0x2213630")]
		private void ReceivedEvent()
		{
		}

		// Token: 0x060072A6 RID: 29350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5A")]
		[Address(RVA = "0x2213640", Offset = "0x2213741", VA = "0x2213640")]
		private void ReceivedEvent(object arg1)
		{
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5B")]
		[Address(RVA = "0x22136A0", Offset = "0x22137A1", VA = "0x22136A0")]
		private void ReceivedEvent(object arg1, object arg2)
		{
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5C")]
		[Address(RVA = "0x2213740", Offset = "0x2213841", VA = "0x2213740")]
		private void ReceivedEvent(object arg1, object arg2, object arg3)
		{
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5D")]
		[Address(RVA = "0x2213810", Offset = "0x2213911", VA = "0x2213810", Slot = "15")]
		public override void OnBehaviorComplete()
		{
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5E")]
		[Address(RVA = "0x2213A10", Offset = "0x2213B11", VA = "0x2213A10", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5F")]
		[Address(RVA = "0x2213B00", Offset = "0x2213C01", VA = "0x2213B00")]
		public HasReceivedEvent()
		{
		}

		// Token: 0x0401B5C0 RID: 112064
		[Token(Token = "0x4017FE9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1830F0", Offset = "0x1831F1")]
		public SharedString eventName;

		// Token: 0x0401B5C1 RID: 112065
		[Token(Token = "0x4017FEA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183130", Offset = "0x183231")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x183130", Offset = "0x183231")]
		public SharedVariable storedValue1;

		// Token: 0x0401B5C2 RID: 112066
		[Token(Token = "0x4017FEB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183180", Offset = "0x183281")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x183180", Offset = "0x183281")]
		public SharedVariable storedValue2;

		// Token: 0x0401B5C3 RID: 112067
		[Token(Token = "0x4017FEC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1831D0", Offset = "0x1832D1")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x1831D0", Offset = "0x1832D1")]
		public SharedVariable storedValue3;

		// Token: 0x0401B5C4 RID: 112068
		[Token(Token = "0x4017FED")]
		[FieldOffset(Offset = "0x70")]
		private bool eventReceived;

		// Token: 0x0401B5C5 RID: 112069
		[Token(Token = "0x4017FEE")]
		[FieldOffset(Offset = "0x71")]
		private bool registered;
	}
}
