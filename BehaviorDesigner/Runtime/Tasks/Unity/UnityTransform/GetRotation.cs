using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001333 RID: 4915
	[Token(Token = "0x2000CFE")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D000", Offset = "0x14D101")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D000", Offset = "0x14D101")]
	public class GetRotation : Action
	{
		// Token: 0x060073B1 RID: 29617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006065")]
		[Address(RVA = "0x299CB30", Offset = "0x299CC31", VA = "0x299CB30", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x00027F48 File Offset: 0x00026148
		[Token(Token = "0x6006066")]
		[Address(RVA = "0x299CC30", Offset = "0x299CD31", VA = "0x299CC30", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006067")]
		[Address(RVA = "0x299CD20", Offset = "0x299CE21", VA = "0x299CD20", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006068")]
		[Address(RVA = "0x299CDB0", Offset = "0x299CEB1", VA = "0x299CDB0")]
		public GetRotation()
		{
		}

		// Token: 0x0401B69F RID: 112287
		[Token(Token = "0x40180C0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185D50", Offset = "0x185E51")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6A0 RID: 112288
		[Token(Token = "0x40180C1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185D90", Offset = "0x185E91")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185D90", Offset = "0x185E91")]
		public SharedQuaternion storeValue;

		// Token: 0x0401B6A1 RID: 112289
		[Token(Token = "0x40180C2")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6A2 RID: 112290
		[Token(Token = "0x40180C3")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
