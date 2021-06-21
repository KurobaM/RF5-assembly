using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x020013AC RID: 5036
	[Token(Token = "0x2000D77")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14FDB0", Offset = "0x14FEB1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14FDB0", Offset = "0x14FEB1")]
	public class IsSleeping : Conditional
	{
		// Token: 0x06007566 RID: 30054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600621A")]
		[Address(RVA = "0x2992830", Offset = "0x2992931", VA = "0x2992830", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007567 RID: 30055 RVA: 0x00028AA0 File Offset: 0x00026CA0
		[Token(Token = "0x600621B")]
		[Address(RVA = "0x2992930", Offset = "0x2992A31", VA = "0x2992930", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007568 RID: 30056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600621C")]
		[Address(RVA = "0x2992A10", Offset = "0x2992B11", VA = "0x2992A10", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007569 RID: 30057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600621D")]
		[Address(RVA = "0x2992A20", Offset = "0x2992B21", VA = "0x2992A20")]
		public IsSleeping()
		{
		}

		// Token: 0x0401B82C RID: 112684
		[Token(Token = "0x401824D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189F90", Offset = "0x18A091")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B82D RID: 112685
		[Token(Token = "0x401824E")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		// Token: 0x0401B82E RID: 112686
		[Token(Token = "0x401824F")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
