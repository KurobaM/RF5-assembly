using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013A0 RID: 5024
	[Token(Token = "0x2000D6B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F930", Offset = "0x14FA31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F930", Offset = "0x14FA31")]
	public class GetAngularDrag : Action
	{
		// Token: 0x06007536 RID: 30006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061EA")]
		[Address(RVA = "0x2990B50", Offset = "0x2990C51", VA = "0x2990B50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x00028980 File Offset: 0x00026B80
		[Token(Token = "0x60061EB")]
		[Address(RVA = "0x2990C50", Offset = "0x2990D51", VA = "0x2990C50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061EC")]
		[Address(RVA = "0x2990D40", Offset = "0x2990E41", VA = "0x2990D40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061ED")]
		[Address(RVA = "0x2990D90", Offset = "0x2990E91", VA = "0x2990D90")]
		public GetAngularDrag()
		{
		}

		// Token: 0x0401B7FD RID: 112637
		[Token(Token = "0x401821E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189920", Offset = "0x189A21")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7FE RID: 112638
		[Token(Token = "0x401821F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189960", Offset = "0x189A61")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x189960", Offset = "0x189A61")]
		public SharedFloat storeValue;

		// Token: 0x0401B7FF RID: 112639
		[Token(Token = "0x4018220")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B800 RID: 112640
		[Token(Token = "0x4018221")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
