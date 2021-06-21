using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200132D RID: 4909
	[Token(Token = "0x2000CF8")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CDC0", Offset = "0x14CEC1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CDC0", Offset = "0x14CEC1")]
	public class GetLocalPosition : Action
	{
		// Token: 0x06007399 RID: 29593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604D")]
		[Address(RVA = "0x299BC10", Offset = "0x299BD11", VA = "0x299BC10", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x00027EB8 File Offset: 0x000260B8
		[Token(Token = "0x600604E")]
		[Address(RVA = "0x299BD10", Offset = "0x299BE11", VA = "0x299BD10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600604F")]
		[Address(RVA = "0x299BE00", Offset = "0x299BF01", VA = "0x299BE00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006050")]
		[Address(RVA = "0x299BE90", Offset = "0x299BF91", VA = "0x299BE90")]
		public GetLocalPosition()
		{
		}

		// Token: 0x0401B687 RID: 112263
		[Token(Token = "0x40180A8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1859F0", Offset = "0x185AF1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B688 RID: 112264
		[Token(Token = "0x40180A9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185A30", Offset = "0x185B31")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185A30", Offset = "0x185B31")]
		public SharedVector3 storeValue;

		// Token: 0x0401B689 RID: 112265
		[Token(Token = "0x40180AA")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B68A RID: 112266
		[Token(Token = "0x40180AB")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
