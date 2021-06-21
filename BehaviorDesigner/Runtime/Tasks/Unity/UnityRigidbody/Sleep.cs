using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013BB RID: 5051
	[Token(Token = "0x2000D86")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150350", Offset = "0x150451")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150350", Offset = "0x150451")]
	public class Sleep : Conditional
	{
		// Token: 0x060075A2 RID: 30114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006256")]
		[Address(RVA = "0x2994C50", Offset = "0x2994D51", VA = "0x2994C50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00028C08 File Offset: 0x00026E08
		[Token(Token = "0x6006257")]
		[Address(RVA = "0x2994D50", Offset = "0x2994E51", VA = "0x2994D50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006258")]
		[Address(RVA = "0x2994E30", Offset = "0x2994F31", VA = "0x2994E30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006259")]
		[Address(RVA = "0x2994E40", Offset = "0x2994F41", VA = "0x2994E40")]
		public Sleep()
		{
		}

		// Token: 0x0401B867 RID: 112743
		[Token(Token = "0x4018288")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A6D0", Offset = "0x18A7D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B868 RID: 112744
		[Token(Token = "0x4018289")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		// Token: 0x0401B869 RID: 112745
		[Token(Token = "0x401828A")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
