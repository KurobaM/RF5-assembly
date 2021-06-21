using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x02001384 RID: 4996
	[Token(Token = "0x2000D4F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14EE60", Offset = "0x14EF61")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14EE60", Offset = "0x14EF61")]
	public class GetAngularDrag : Action
	{
		// Token: 0x060074C6 RID: 29894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617A")]
		[Address(RVA = "0x2995A10", Offset = "0x2995B11", VA = "0x2995A10", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x000286E0 File Offset: 0x000268E0
		[Token(Token = "0x600617B")]
		[Address(RVA = "0x2995B10", Offset = "0x2995C11", VA = "0x2995B10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617C")]
		[Address(RVA = "0x2995C00", Offset = "0x2995D01", VA = "0x2995C00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617D")]
		[Address(RVA = "0x2995C50", Offset = "0x2995D51", VA = "0x2995C50")]
		public GetAngularDrag()
		{
		}

		// Token: 0x0401B787 RID: 112519
		[Token(Token = "0x40181A8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188910", Offset = "0x188A11")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B788 RID: 112520
		[Token(Token = "0x40181A9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188950", Offset = "0x188A51")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188950", Offset = "0x188A51")]
		public SharedFloat storeValue;

		// Token: 0x0401B789 RID: 112521
		[Token(Token = "0x40181AA")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B78A RID: 112522
		[Token(Token = "0x40181AB")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
