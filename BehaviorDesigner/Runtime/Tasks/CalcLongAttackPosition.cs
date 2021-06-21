using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012C4 RID: 4804
	[Token(Token = "0x2000C91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A540", Offset = "0x14A641")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A540", Offset = "0x14A641")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14A540", Offset = "0x14A641")]
	public class CalcLongAttackPosition : Action
	{
		// Token: 0x060071D9 RID: 29145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8D")]
		[Address(RVA = "0x220F9E0", Offset = "0x220FAE1", VA = "0x220F9E0", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x000271E0 File Offset: 0x000253E0
		[Token(Token = "0x6005E8E")]
		[Address(RVA = "0x220FAB0", Offset = "0x220FBB1", VA = "0x220FAB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071DB RID: 29147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8F")]
		[Address(RVA = "0x220FD00", Offset = "0x220FE01", VA = "0x220FD00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071DC RID: 29148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E90")]
		[Address(RVA = "0x220FD50", Offset = "0x220FE51", VA = "0x220FD50")]
		public CalcLongAttackPosition()
		{
		}

		// Token: 0x0401B523 RID: 111907
		[Token(Token = "0x4017F4C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181B20", Offset = "0x181C21")]
		public SharedFloat LeaveRange;

		// Token: 0x0401B524 RID: 111908
		[Token(Token = "0x4017F4D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181B60", Offset = "0x181C61")]
		public SharedGameObject Target;

		// Token: 0x0401B525 RID: 111909
		[Token(Token = "0x4017F4E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181BA0", Offset = "0x181CA1")]
		public SharedVector3 ReturnCanLongAttackPosition;

		// Token: 0x0401B526 RID: 111910
		[Token(Token = "0x4017F4F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string LeaveRangeKeyName;

		// Token: 0x0401B527 RID: 111911
		[Token(Token = "0x4017F50")]
		[FieldOffset(Offset = "0x68")]
		private AIInput AIInput;
	}
}
