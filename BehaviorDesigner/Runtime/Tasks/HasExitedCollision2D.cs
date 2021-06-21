using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012F1 RID: 4849
	[Token(Token = "0x2000CBE")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B7E0", Offset = "0x14B8E1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14B7E0", Offset = "0x14B8E1")]
	public class HasExitedCollision2D : Conditional
	{
		// Token: 0x060072C5 RID: 29381 RVA: 0x00027870 File Offset: 0x00025A70
		[Token(Token = "0x6005F79")]
		[Address(RVA = "0x2212890", Offset = "0x2212991", VA = "0x2212890", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0x22128B0", Offset = "0x22129B1", VA = "0x22128B0", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0x22128C0", Offset = "0x22129C1", VA = "0x22128C0", Slot = "23")]
		public override void OnCollisionExit2D(Collision2D collision)
		{
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0x22129B0", Offset = "0x2212AB1", VA = "0x22129B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072C9 RID: 29385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0x2212AB0", Offset = "0x2212BB1", VA = "0x2212AB0")]
		public HasExitedCollision2D()
		{
		}

		// Token: 0x0401B5D5 RID: 112085
		[Token(Token = "0x4017FFE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1834A0", Offset = "0x1835A1")]
		public SharedString tag;

		// Token: 0x0401B5D6 RID: 112086
		[Token(Token = "0x4017FFF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1834E0", Offset = "0x1835E1")]
		public SharedGameObject collidedGameObject;

		// Token: 0x0401B5D7 RID: 112087
		[Token(Token = "0x4018000")]
		[FieldOffset(Offset = "0x60")]
		private bool exitedCollision;
	}
}
