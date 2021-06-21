using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012F7 RID: 4855
	[Token(Token = "0x2000CC4")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BA60", Offset = "0x14BB61")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14BA60", Offset = "0x14BB61")]
	public class ConditionalEvaluator : Decorator
	{
		// Token: 0x060072DE RID: 29406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F92")]
		[Address(RVA = "0x2210560", Offset = "0x2210661", VA = "0x2210560", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F93")]
		[Address(RVA = "0x22105E0", Offset = "0x22106E1", VA = "0x22105E0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060072E0 RID: 29408 RVA: 0x00027900 File Offset: 0x00025B00
		[Token(Token = "0x6005F94")]
		[Address(RVA = "0x2210600", Offset = "0x2210701", VA = "0x2210600", Slot = "33")]
		public override bool CanExecute()
		{
			return default(bool);
		}

		// Token: 0x060072E1 RID: 29409 RVA: 0x00027918 File Offset: 0x00025B18
		[Token(Token = "0x6005F95")]
		[Address(RVA = "0x2210670", Offset = "0x2210771", VA = "0x2210670", Slot = "35")]
		public override bool CanReevaluate()
		{
			return default(bool);
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x00027930 File Offset: 0x00025B30
		[Token(Token = "0x6005F96")]
		[Address(RVA = "0x22106D0", Offset = "0x22107D1", VA = "0x22106D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F97")]
		[Address(RVA = "0x2210720", Offset = "0x2210821", VA = "0x2210720", Slot = "36")]
		public override void OnChildExecuted(TaskStatus childStatus)
		{
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x00027948 File Offset: 0x00025B48
		[Token(Token = "0x6005F98")]
		[Address(RVA = "0x2210730", Offset = "0x2210831", VA = "0x2210730", Slot = "41")]
		public override TaskStatus OverrideStatus()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x00027960 File Offset: 0x00025B60
		[Token(Token = "0x6005F99")]
		[Address(RVA = "0x2210740", Offset = "0x2210841", VA = "0x2210740", Slot = "40")]
		public override TaskStatus OverrideStatus(TaskStatus status)
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0x2210750", Offset = "0x2210851", VA = "0x2210750", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0x2210780", Offset = "0x2210881", VA = "0x2210780", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0x2210790", Offset = "0x2210891", VA = "0x2210790")]
		public ConditionalEvaluator()
		{
		}

		// Token: 0x0401B5E9 RID: 112105
		[Token(Token = "0x4018012")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1838E0", Offset = "0x1839E1")]
		public SharedBool reevaluate;

		// Token: 0x0401B5EA RID: 112106
		[Token(Token = "0x4018013")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "InspectTaskAttribute", RVA = "0x183920", Offset = "0x183A21")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183920", Offset = "0x183A21")]
		public Conditional conditionalTask;

		// Token: 0x0401B5EB RID: 112107
		[Token(Token = "0x4018014")]
		[FieldOffset(Offset = "0x68")]
		private TaskStatus executionStatus;

		// Token: 0x0401B5EC RID: 112108
		[Token(Token = "0x4018015")]
		[FieldOffset(Offset = "0x6C")]
		private bool checkConditionalTask;

		// Token: 0x0401B5ED RID: 112109
		[Token(Token = "0x4018016")]
		[FieldOffset(Offset = "0x6D")]
		private bool conditionalTaskFailed;
	}
}
