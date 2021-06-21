using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x0200139B RID: 5019
	[Token(Token = "0x2000D66")]
	[Attribute(Name = "RequiredComponentAttribute", RVA = "0x14F700", Offset = "0x14F801")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F700", Offset = "0x14F801")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F700", Offset = "0x14F801")]
	public class AddForce : Action
	{
		// Token: 0x06007522 RID: 29986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D6")]
		[Address(RVA = "0x298FE00", Offset = "0x298FF01", VA = "0x298FE00", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007523 RID: 29987 RVA: 0x00028908 File Offset: 0x00026B08
		[Token(Token = "0x60061D7")]
		[Address(RVA = "0x298FF00", Offset = "0x2990001", VA = "0x298FF00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007524 RID: 29988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D8")]
		[Address(RVA = "0x2990000", Offset = "0x2990101", VA = "0x2990000", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007525 RID: 29989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061D9")]
		[Address(RVA = "0x29900A0", Offset = "0x29901A1", VA = "0x29900A0")]
		public AddForce()
		{
		}

		// Token: 0x0401B7E3 RID: 112611
		[Token(Token = "0x4018204")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189520", Offset = "0x189621")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7E4 RID: 112612
		[Token(Token = "0x4018205")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189560", Offset = "0x189661")]
		public SharedVector3 force;

		// Token: 0x0401B7E5 RID: 112613
		[Token(Token = "0x4018206")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1895A0", Offset = "0x1896A1")]
		public ForceMode forceMode;

		// Token: 0x0401B7E6 RID: 112614
		[Token(Token = "0x4018207")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody rigidbody;

		// Token: 0x0401B7E7 RID: 112615
		[Token(Token = "0x4018208")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
