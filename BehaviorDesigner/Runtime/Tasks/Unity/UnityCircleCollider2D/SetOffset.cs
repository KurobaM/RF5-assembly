using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCircleCollider2D
{
	// Token: 0x0200145B RID: 5211
	[Token(Token = "0x2000E21")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153D70", Offset = "0x153E71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153D70", Offset = "0x153E71")]
	public class SetOffset : Action
	{
		// Token: 0x060077B9 RID: 30649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646D")]
		[Address(RVA = "0x28E3C40", Offset = "0x28E3D41", VA = "0x28E3C40", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x00029AA8 File Offset: 0x00027CA8
		[Token(Token = "0x600646E")]
		[Address(RVA = "0x28E3D40", Offset = "0x28E3E41", VA = "0x28E3D40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600646F")]
		[Address(RVA = "0x28E3E80", Offset = "0x28E3F81", VA = "0x28E3E80", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006470")]
		[Address(RVA = "0x28E3F10", Offset = "0x28E4011", VA = "0x28E3F10")]
		public SetOffset()
		{
		}

		// Token: 0x0401BA78 RID: 113272
		[Token(Token = "0x4018476")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190250", Offset = "0x190351")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA79 RID: 113273
		[Token(Token = "0x4018477")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190290", Offset = "0x190391")]
		public SharedVector3 offset;

		// Token: 0x0401BA7A RID: 113274
		[Token(Token = "0x4018478")]
		[FieldOffset(Offset = "0x60")]
		private CircleCollider2D circleCollider2D;

		// Token: 0x0401BA7B RID: 113275
		[Token(Token = "0x4018479")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
