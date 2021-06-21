using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012EF RID: 4847
	[Token(Token = "0x2000CBC")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B720", Offset = "0x14B821")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14B720", Offset = "0x14B821")]
	public class HasEnteredTrigger2D : Conditional
	{
		// Token: 0x060072BB RID: 29371 RVA: 0x00027840 File Offset: 0x00025A40
		[Token(Token = "0x6005F6F")]
		[Address(RVA = "0x2212340", Offset = "0x2212441", VA = "0x2212340", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F70")]
		[Address(RVA = "0x2212360", Offset = "0x2212461", VA = "0x2212360", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F71")]
		[Address(RVA = "0x2212370", Offset = "0x2212471", VA = "0x2212370", Slot = "24")]
		public override void OnTriggerEnter2D(Collider2D other)
		{
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F72")]
		[Address(RVA = "0x2212460", Offset = "0x2212561", VA = "0x2212460", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F73")]
		[Address(RVA = "0x2212560", Offset = "0x2212661", VA = "0x2212560")]
		public HasEnteredTrigger2D()
		{
		}

		// Token: 0x0401B5CF RID: 112079
		[Token(Token = "0x4017FF8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1833A0", Offset = "0x1834A1")]
		public SharedString tag;

		// Token: 0x0401B5D0 RID: 112080
		[Token(Token = "0x4017FF9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1833E0", Offset = "0x1834E1")]
		public SharedGameObject otherGameObject;

		// Token: 0x0401B5D1 RID: 112081
		[Token(Token = "0x4017FFA")]
		[FieldOffset(Offset = "0x60")]
		private bool enteredTrigger;
	}
}
