using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012EE RID: 4846
	[Token(Token = "0x2000CBB")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14B6C0", Offset = "0x14B7C1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14B6C0", Offset = "0x14B7C1")]
	public class HasEnteredTrigger : Conditional
	{
		// Token: 0x060072B6 RID: 29366 RVA: 0x00027828 File Offset: 0x00025A28
		[Token(Token = "0x6005F6A")]
		[Address(RVA = "0x2212020", Offset = "0x2212121", VA = "0x2212020", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6B")]
		[Address(RVA = "0x2212040", Offset = "0x2212141", VA = "0x2212040", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6C")]
		[Address(RVA = "0x2212050", Offset = "0x2212151", VA = "0x2212050", Slot = "20")]
		public override void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6D")]
		[Address(RVA = "0x2212140", Offset = "0x2212241", VA = "0x2212140", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6E")]
		[Address(RVA = "0x2212240", Offset = "0x2212341", VA = "0x2212240")]
		public HasEnteredTrigger()
		{
		}

		// Token: 0x0401B5CC RID: 112076
		[Token(Token = "0x4017FF5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183320", Offset = "0x183421")]
		public SharedString tag;

		// Token: 0x0401B5CD RID: 112077
		[Token(Token = "0x4017FF6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183360", Offset = "0x183461")]
		public SharedGameObject otherGameObject;

		// Token: 0x0401B5CE RID: 112078
		[Token(Token = "0x4017FF7")]
		[FieldOffset(Offset = "0x60")]
		private bool enteredTrigger;
	}
}
