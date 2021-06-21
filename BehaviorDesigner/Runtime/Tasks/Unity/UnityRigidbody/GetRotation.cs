using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013A8 RID: 5032
	[Token(Token = "0x2000D73")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FC30", Offset = "0x14FD31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FC30", Offset = "0x14FD31")]
	public class GetRotation : Action
	{
		// Token: 0x06007556 RID: 30038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600620A")]
		[Address(RVA = "0x2991EB0", Offset = "0x2991FB1", VA = "0x2991EB0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007557 RID: 30039 RVA: 0x00028A40 File Offset: 0x00026C40
		[Token(Token = "0x600620B")]
		[Address(RVA = "0x2991FB0", Offset = "0x29920B1", VA = "0x2991FB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007558 RID: 30040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600620C")]
		[Address(RVA = "0x29920A0", Offset = "0x29921A1", VA = "0x29920A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600620D")]
		[Address(RVA = "0x2992130", Offset = "0x2992231", VA = "0x2992130")]
		public GetRotation()
		{
		}

		// Token: 0x0401B81D RID: 112669
		[Token(Token = "0x401823E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189DA0", Offset = "0x189EA1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B81E RID: 112670
		[Token(Token = "0x401823F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189DE0", Offset = "0x189EE1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x189DE0", Offset = "0x189EE1")]
		public SharedQuaternion storeValue;

		// Token: 0x0401B81F RID: 112671
		[Token(Token = "0x4018240")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rigidbody;

		// Token: 0x0401B820 RID: 112672
		[Token(Token = "0x4018241")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
