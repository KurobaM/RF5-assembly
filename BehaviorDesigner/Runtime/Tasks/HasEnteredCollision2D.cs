using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012ED RID: 4845
	[Token(Token = "0x2000CBA")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B660", Offset = "0x14B761")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14B660", Offset = "0x14B761")]
	public class HasEnteredCollision2D : Conditional
	{
		// Token: 0x060072B1 RID: 29361 RVA: 0x00027810 File Offset: 0x00025A10
		[Token(Token = "0x6005F65")]
		[Address(RVA = "0x2211D00", Offset = "0x2211E01", VA = "0x2211D00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F66")]
		[Address(RVA = "0x2211D20", Offset = "0x2211E21", VA = "0x2211D20", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F67")]
		[Address(RVA = "0x2211D30", Offset = "0x2211E31", VA = "0x2211D30", Slot = "22")]
		public override void OnCollisionEnter2D(Collision2D collision)
		{
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F68")]
		[Address(RVA = "0x2211E20", Offset = "0x2211F21", VA = "0x2211E20", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F69")]
		[Address(RVA = "0x2211F20", Offset = "0x2212021", VA = "0x2211F20")]
		public HasEnteredCollision2D()
		{
		}

		// Token: 0x0401B5C9 RID: 112073
		[Token(Token = "0x4017FF2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1832A0", Offset = "0x1833A1")]
		public SharedString tag;

		// Token: 0x0401B5CA RID: 112074
		[Token(Token = "0x4017FF3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1832E0", Offset = "0x1833E1")]
		public SharedGameObject collidedGameObject;

		// Token: 0x0401B5CB RID: 112075
		[Token(Token = "0x4017FF4")]
		[FieldOffset(Offset = "0x60")]
		private bool enteredCollision;
	}
}
