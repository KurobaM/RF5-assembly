using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x0200138F RID: 5007
	[Token(Token = "0x2000D5A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F280", Offset = "0x14F381")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F280", Offset = "0x14F381")]
	public class MovePosition : Action
	{
		// Token: 0x060074F2 RID: 29938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A6")]
		[Address(RVA = "0x2997370", Offset = "0x2997471", VA = "0x2997370", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x000287E8 File Offset: 0x000269E8
		[Token(Token = "0x60061A7")]
		[Address(RVA = "0x2997470", Offset = "0x2997571", VA = "0x2997470", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A8")]
		[Address(RVA = "0x2997560", Offset = "0x2997661", VA = "0x2997560", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A9")]
		[Address(RVA = "0x29975F0", Offset = "0x29976F1", VA = "0x29975F0")]
		public MovePosition()
		{
		}

		// Token: 0x0401B7B1 RID: 112561
		[Token(Token = "0x40181D2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188EA0", Offset = "0x188FA1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7B2 RID: 112562
		[Token(Token = "0x40181D3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188EE0", Offset = "0x188FE1")]
		public SharedVector2 position;

		// Token: 0x0401B7B3 RID: 112563
		[Token(Token = "0x40181D4")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7B4 RID: 112564
		[Token(Token = "0x40181D5")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
