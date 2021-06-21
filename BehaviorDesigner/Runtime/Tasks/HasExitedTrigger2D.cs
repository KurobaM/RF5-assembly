using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012F3 RID: 4851
	[Token(Token = "0x2000CC0")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B8A0", Offset = "0x14B9A1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14B8A0", Offset = "0x14B9A1")]
	public class HasExitedTrigger2D : Conditional
	{
		// Token: 0x060072CF RID: 29391 RVA: 0x000278A0 File Offset: 0x00025AA0
		[Token(Token = "0x6005F83")]
		[Address(RVA = "0x2212ED0", Offset = "0x2212FD1", VA = "0x2212ED0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F84")]
		[Address(RVA = "0x2212EF0", Offset = "0x2212FF1", VA = "0x2212EF0", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F85")]
		[Address(RVA = "0x2212F00", Offset = "0x2213001", VA = "0x2212F00", Slot = "25")]
		public override void OnTriggerExit2D(Collider2D other)
		{
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F86")]
		[Address(RVA = "0x2212FF0", Offset = "0x22130F1", VA = "0x2212FF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F87")]
		[Address(RVA = "0x22130F0", Offset = "0x22131F1", VA = "0x22130F0")]
		public HasExitedTrigger2D()
		{
		}

		// Token: 0x0401B5DB RID: 112091
		[Token(Token = "0x4018004")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1835A0", Offset = "0x1836A1")]
		public SharedString tag;

		// Token: 0x0401B5DC RID: 112092
		[Token(Token = "0x4018005")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1835E0", Offset = "0x1836E1")]
		public SharedGameObject otherGameObject;

		// Token: 0x0401B5DD RID: 112093
		[Token(Token = "0x4018006")]
		[FieldOffset(Offset = "0x60")]
		private bool exitedTrigger;
	}
}
