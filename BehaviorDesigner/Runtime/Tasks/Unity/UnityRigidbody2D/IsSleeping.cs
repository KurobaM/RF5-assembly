using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody2D
{
	// Token: 0x0200138E RID: 5006
	[Token(Token = "0x2000D59")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F220", Offset = "0x14F321")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F220", Offset = "0x14F321")]
	public class IsSleeping : Conditional
	{
		// Token: 0x060074EE RID: 29934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A2")]
		[Address(RVA = "0x2997170", Offset = "0x2997271", VA = "0x2997170", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x000287D0 File Offset: 0x000269D0
		[Token(Token = "0x60061A3")]
		[Address(RVA = "0x2997270", Offset = "0x2997371", VA = "0x2997270", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A4")]
		[Address(RVA = "0x2997350", Offset = "0x2997451", VA = "0x2997350", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A5")]
		[Address(RVA = "0x2997360", Offset = "0x2997461", VA = "0x2997360")]
		public IsSleeping()
		{
		}

		// Token: 0x0401B7AE RID: 112558
		[Token(Token = "0x40181CF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188E60", Offset = "0x188F61")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7AF RID: 112559
		[Token(Token = "0x40181D0")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody2D rigidbody2D;

		// Token: 0x0401B7B0 RID: 112560
		[Token(Token = "0x40181D1")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
