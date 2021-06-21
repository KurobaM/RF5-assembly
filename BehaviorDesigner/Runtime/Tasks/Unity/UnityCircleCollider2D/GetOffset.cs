using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCircleCollider2D
{
	// Token: 0x02001459 RID: 5209
	[Token(Token = "0x2000E1F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153CB0", Offset = "0x153DB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153CB0", Offset = "0x153DB1")]
	public class GetOffset : Action
	{
		// Token: 0x060077B1 RID: 30641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006465")]
		[Address(RVA = "0x28E3710", Offset = "0x28E3811", VA = "0x28E3710", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x00029A78 File Offset: 0x00027C78
		[Token(Token = "0x6006466")]
		[Address(RVA = "0x28E3810", Offset = "0x28E3911", VA = "0x28E3810", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006467")]
		[Address(RVA = "0x28E3950", Offset = "0x28E3A51", VA = "0x28E3950", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006468")]
		[Address(RVA = "0x28E39E0", Offset = "0x28E3AE1", VA = "0x28E39E0")]
		public GetOffset()
		{
		}

		// Token: 0x0401BA70 RID: 113264
		[Token(Token = "0x401846E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190130", Offset = "0x190231")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA71 RID: 113265
		[Token(Token = "0x401846F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190170", Offset = "0x190271")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190170", Offset = "0x190271")]
		public SharedVector3 storeValue;

		// Token: 0x0401BA72 RID: 113266
		[Token(Token = "0x4018470")]
		[FieldOffset(Offset = "0x60")]
		private CircleCollider2D circleCollider2D;

		// Token: 0x0401BA73 RID: 113267
		[Token(Token = "0x4018471")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
