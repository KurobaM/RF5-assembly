using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCircleCollider2D
{
	// Token: 0x0200145A RID: 5210
	[Token(Token = "0x2000E20")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153D10", Offset = "0x153E11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153D10", Offset = "0x153E11")]
	public class GetRadius : Action
	{
		// Token: 0x060077B5 RID: 30645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006469")]
		[Address(RVA = "0x28E39F0", Offset = "0x28E3AF1", VA = "0x28E39F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00029A90 File Offset: 0x00027C90
		[Token(Token = "0x600646A")]
		[Address(RVA = "0x28E3AF0", Offset = "0x28E3BF1", VA = "0x28E3AF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646B")]
		[Address(RVA = "0x28E3BE0", Offset = "0x28E3CE1", VA = "0x28E3BE0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646C")]
		[Address(RVA = "0x28E3C30", Offset = "0x28E3D31", VA = "0x28E3C30")]
		public GetRadius()
		{
		}

		// Token: 0x0401BA74 RID: 113268
		[Token(Token = "0x4018472")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1901C0", Offset = "0x1902C1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA75 RID: 113269
		[Token(Token = "0x4018473")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190200", Offset = "0x190301")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190200", Offset = "0x190301")]
		public SharedFloat storeValue;

		// Token: 0x0401BA76 RID: 113270
		[Token(Token = "0x4018474")]
		[FieldOffset(Offset = "0x60")]
		private CircleCollider2D circleCollider2D;

		// Token: 0x0401BA77 RID: 113271
		[Token(Token = "0x4018475")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
