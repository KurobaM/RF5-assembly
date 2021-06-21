using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012D5 RID: 4821
	[Token(Token = "0x2000CA2")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14AC40", Offset = "0x14AD41")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14AC40", Offset = "0x14AD41")]
	public class Log : Action
	{
		// Token: 0x06007218 RID: 29208 RVA: 0x00027390 File Offset: 0x00025590
		[Token(Token = "0x6005ECC")]
		[Address(RVA = "0x2214380", Offset = "0x2214481", VA = "0x2214380", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECD")]
		[Address(RVA = "0x2214600", Offset = "0x2214701", VA = "0x2214600", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECE")]
		[Address(RVA = "0x22147F0", Offset = "0x22148F1", VA = "0x22147F0")]
		public Log()
		{
		}

		// Token: 0x0401B568 RID: 111976
		[Token(Token = "0x4017F91")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1823A0", Offset = "0x1824A1")]
		public SharedString text;

		// Token: 0x0401B569 RID: 111977
		[Token(Token = "0x4017F92")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1823E0", Offset = "0x1824E1")]
		public SharedBool logError;

		// Token: 0x0401B56A RID: 111978
		[Token(Token = "0x4017F93")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182420", Offset = "0x182521")]
		public SharedBool logTime;
	}
}
