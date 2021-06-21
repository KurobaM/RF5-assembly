using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012EC RID: 4844
	[Token(Token = "0x2000CB9")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B600", Offset = "0x14B701")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14B600", Offset = "0x14B701")]
	public class HasEnteredCollision : Conditional
	{
		// Token: 0x060072AC RID: 29356 RVA: 0x000277F8 File Offset: 0x000259F8
		[Token(Token = "0x6005F60")]
		[Address(RVA = "0x22119E0", Offset = "0x2211AE1", VA = "0x22119E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F61")]
		[Address(RVA = "0x2211A00", Offset = "0x2211B01", VA = "0x2211A00", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072AE RID: 29358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F62")]
		[Address(RVA = "0x2211A10", Offset = "0x2211B11", VA = "0x2211A10", Slot = "18")]
		public override void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F63")]
		[Address(RVA = "0x2211B00", Offset = "0x2211C01", VA = "0x2211B00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F64")]
		[Address(RVA = "0x2211C00", Offset = "0x2211D01", VA = "0x2211C00")]
		public HasEnteredCollision()
		{
		}

		// Token: 0x0401B5C6 RID: 112070
		[Token(Token = "0x4017FEF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183220", Offset = "0x183321")]
		public SharedString tag;

		// Token: 0x0401B5C7 RID: 112071
		[Token(Token = "0x4017FF0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183260", Offset = "0x183361")]
		public SharedGameObject collidedGameObject;

		// Token: 0x0401B5C8 RID: 112072
		[Token(Token = "0x4017FF1")]
		[FieldOffset(Offset = "0x60")]
		private bool enteredCollision;
	}
}
