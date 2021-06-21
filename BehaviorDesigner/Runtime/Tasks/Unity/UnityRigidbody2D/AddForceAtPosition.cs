using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001382 RID: 4994
	[Token(Token = "0x2000D4D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EDA0", Offset = "0x14EEA1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EDA0", Offset = "0x14EEA1")]
	public class AddForceAtPosition : Action
	{
		// Token: 0x060074BE RID: 29886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006172")]
		[Address(RVA = "0x29954E0", Offset = "0x29955E1", VA = "0x29954E0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074BF RID: 29887 RVA: 0x000286B0 File Offset: 0x000268B0
		[Token(Token = "0x6006173")]
		[Address(RVA = "0x29955E0", Offset = "0x29956E1", VA = "0x29955E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006174")]
		[Address(RVA = "0x2995700", Offset = "0x2995801", VA = "0x2995700", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006175")]
		[Address(RVA = "0x29957B0", Offset = "0x29958B1", VA = "0x29957B0")]
		public AddForceAtPosition()
		{
		}

		// Token: 0x0401B77E RID: 112510
		[Token(Token = "0x401819F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1887D0", Offset = "0x1888D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B77F RID: 112511
		[Token(Token = "0x40181A0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188810", Offset = "0x188911")]
		public SharedVector2 force;

		// Token: 0x0401B780 RID: 112512
		[Token(Token = "0x40181A1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188850", Offset = "0x188951")]
		public SharedVector2 position;

		// Token: 0x0401B781 RID: 112513
		[Token(Token = "0x40181A2")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B782 RID: 112514
		[Token(Token = "0x40181A3")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
