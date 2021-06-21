using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013B4 RID: 5044
	[Token(Token = "0x2000D7F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1500B0", Offset = "0x1501B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1500B0", Offset = "0x1501B1")]
	public class SetFreezeRotation : Action
	{
		// Token: 0x06007586 RID: 30086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623A")]
		[Address(RVA = "0x2993B30", Offset = "0x2993C31", VA = "0x2993B30", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x00028B60 File Offset: 0x00026D60
		[Token(Token = "0x600623B")]
		[Address(RVA = "0x2993C30", Offset = "0x2993D31", VA = "0x2993C30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623C")]
		[Address(RVA = "0x2993D30", Offset = "0x2993E31", VA = "0x2993D30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600623D")]
		[Address(RVA = "0x2993D80", Offset = "0x2993E81", VA = "0x2993D80")]
		public SetFreezeRotation()
		{
		}

		// Token: 0x0401B84B RID: 112715
		[Token(Token = "0x401826C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A350", Offset = "0x18A451")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B84C RID: 112716
		[Token(Token = "0x401826D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A390", Offset = "0x18A491")]
		public SharedBool freezeRotation;

		// Token: 0x0401B84D RID: 112717
		[Token(Token = "0x401826E")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B84E RID: 112718
		[Token(Token = "0x401826F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
