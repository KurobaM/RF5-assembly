using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRigidbody
{
	// Token: 0x0200139C RID: 5020
	[Token(Token = "0x2000D67")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14F7B0", Offset = "0x14F8B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14F7B0", Offset = "0x14F8B1")]
	public class AddForceAtPosition : Action
	{
		// Token: 0x06007526 RID: 29990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061DA")]
		[Address(RVA = "0x29900B0", Offset = "0x29901B1", VA = "0x29900B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007527 RID: 29991 RVA: 0x00028920 File Offset: 0x00026B20
		[Token(Token = "0x60061DB")]
		[Address(RVA = "0x29901B0", Offset = "0x29902B1", VA = "0x29901B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007528 RID: 29992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061DC")]
		[Address(RVA = "0x29902F0", Offset = "0x29903F1", VA = "0x29902F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061DD")]
		[Address(RVA = "0x29903B0", Offset = "0x29904B1", VA = "0x29903B0")]
		public AddForceAtPosition()
		{
		}

		// Token: 0x0401B7E8 RID: 112616
		[Token(Token = "0x4018209")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1895E0", Offset = "0x1896E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B7E9 RID: 112617
		[Token(Token = "0x401820A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189620", Offset = "0x189721")]
		public SharedVector3 force;

		// Token: 0x0401B7EA RID: 112618
		[Token(Token = "0x401820B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x189660", Offset = "0x189761")]
		public SharedVector3 position;

		// Token: 0x0401B7EB RID: 112619
		[Token(Token = "0x401820C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1896A0", Offset = "0x1897A1")]
		public ForceMode forceMode;

		// Token: 0x0401B7EC RID: 112620
		[Token(Token = "0x401820D")]
		[FieldOffset(Offset = "0x70")]
		private Rigidbody rigidbody;

		// Token: 0x0401B7ED RID: 112621
		[Token(Token = "0x401820E")]
		[FieldOffset(Offset = "0x78")]
		private GameObject prevGameObject;
	}
}
