using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x0200145F RID: 5215
	[Token(Token = "0x2000E25")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153EF0", Offset = "0x153FF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153EF0", Offset = "0x153FF1")]
	public class GetRadius : Action
	{
		// Token: 0x060077C9 RID: 30665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647D")]
		[Address(RVA = "0x28E1880", Offset = "0x28E1981", VA = "0x28E1880", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x00029B08 File Offset: 0x00027D08
		[Token(Token = "0x600647E")]
		[Address(RVA = "0x28E1980", Offset = "0x28E1A81", VA = "0x28E1980", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647F")]
		[Address(RVA = "0x28E1A70", Offset = "0x28E1B71", VA = "0x28E1A70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006480")]
		[Address(RVA = "0x28E1AC0", Offset = "0x28E1BC1", VA = "0x28E1AC0")]
		public GetRadius()
		{
		}

		// Token: 0x0401BA88 RID: 113288
		[Token(Token = "0x4018486")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190470", Offset = "0x190571")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA89 RID: 113289
		[Token(Token = "0x4018487")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1904B0", Offset = "0x1905B1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1904B0", Offset = "0x1905B1")]
		public SharedFloat storeValue;

		// Token: 0x0401BA8A RID: 113290
		[Token(Token = "0x4018488")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BA8B RID: 113291
		[Token(Token = "0x4018489")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
