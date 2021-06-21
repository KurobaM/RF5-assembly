using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013AB RID: 5035
	[Token(Token = "0x2000D76")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FD50", Offset = "0x14FE51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FD50", Offset = "0x14FE51")]
	public class IsKinematic : Conditional
	{
		// Token: 0x06007562 RID: 30050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006216")]
		[Address(RVA = "0x2992630", Offset = "0x2992731", VA = "0x2992630", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x00028A88 File Offset: 0x00026C88
		[Token(Token = "0x6006217")]
		[Address(RVA = "0x2992730", Offset = "0x2992831", VA = "0x2992730", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006218")]
		[Address(RVA = "0x2992810", Offset = "0x2992911", VA = "0x2992810", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006219")]
		[Address(RVA = "0x2992820", Offset = "0x2992921", VA = "0x2992820")]
		public IsKinematic()
		{
		}

		// Token: 0x0401B829 RID: 112681
		[Token(Token = "0x401824A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189F50", Offset = "0x18A051")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B82A RID: 112682
		[Token(Token = "0x401824B")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		// Token: 0x0401B82B RID: 112683
		[Token(Token = "0x401824C")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
