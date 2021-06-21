using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001383 RID: 4995
	[Token(Token = "0x2000D4E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EE00", Offset = "0x14EF01")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EE00", Offset = "0x14EF01")]
	public class AddTorque : Action
	{
		// Token: 0x060074C2 RID: 29890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006176")]
		[Address(RVA = "0x29957C0", Offset = "0x29958C1", VA = "0x29957C0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x000286C8 File Offset: 0x000268C8
		[Token(Token = "0x6006177")]
		[Address(RVA = "0x29958C0", Offset = "0x29959C1", VA = "0x29958C0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006178")]
		[Address(RVA = "0x29959B0", Offset = "0x2995AB1", VA = "0x29959B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006179")]
		[Address(RVA = "0x2995A00", Offset = "0x2995B01", VA = "0x2995A00")]
		public AddTorque()
		{
		}

		// Token: 0x0401B783 RID: 112515
		[Token(Token = "0x40181A4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188890", Offset = "0x188991")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B784 RID: 112516
		[Token(Token = "0x40181A5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1888D0", Offset = "0x1889D1")]
		public SharedFloat torque;

		// Token: 0x0401B785 RID: 112517
		[Token(Token = "0x40181A6")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B786 RID: 112518
		[Token(Token = "0x40181A7")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
