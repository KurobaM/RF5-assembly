using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200132F RID: 4911
	[Token(Token = "0x2000CFA")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CE80", Offset = "0x14CF81")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CE80", Offset = "0x14CF81")]
	public class GetLocalScale : Action
	{
		// Token: 0x060073A1 RID: 29601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006055")]
		[Address(RVA = "0x299C130", Offset = "0x299C231", VA = "0x299C130", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x00027EE8 File Offset: 0x000260E8
		[Token(Token = "0x6006056")]
		[Address(RVA = "0x299C230", Offset = "0x299C331", VA = "0x299C230", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006057")]
		[Address(RVA = "0x299C320", Offset = "0x299C421", VA = "0x299C320", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006058")]
		[Address(RVA = "0x299C3B0", Offset = "0x299C4B1", VA = "0x299C3B0")]
		public GetLocalScale()
		{
		}

		// Token: 0x0401B68F RID: 112271
		[Token(Token = "0x40180B0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185B10", Offset = "0x185C11")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B690 RID: 112272
		[Token(Token = "0x40180B1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185B50", Offset = "0x185C51")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185B50", Offset = "0x185C51")]
		public SharedVector3 storeValue;

		// Token: 0x0401B691 RID: 112273
		[Token(Token = "0x40180B2")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B692 RID: 112274
		[Token(Token = "0x40180B3")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
