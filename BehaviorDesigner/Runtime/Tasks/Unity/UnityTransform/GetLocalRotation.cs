using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x0200132E RID: 4910
	[Token(Token = "0x2000CF9")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CE20", Offset = "0x14CF21")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CE20", Offset = "0x14CF21")]
	public class GetLocalRotation : Action
	{
		// Token: 0x0600739D RID: 29597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006051")]
		[Address(RVA = "0x299BEA0", Offset = "0x299BFA1", VA = "0x299BEA0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x00027ED0 File Offset: 0x000260D0
		[Token(Token = "0x6006052")]
		[Address(RVA = "0x299BFA0", Offset = "0x299C0A1", VA = "0x299BFA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006053")]
		[Address(RVA = "0x299C090", Offset = "0x299C191", VA = "0x299C090", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006054")]
		[Address(RVA = "0x299C120", Offset = "0x299C221", VA = "0x299C120")]
		public GetLocalRotation()
		{
		}

		// Token: 0x0401B68B RID: 112267
		[Token(Token = "0x40180AC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185A80", Offset = "0x185B81")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B68C RID: 112268
		[Token(Token = "0x40180AD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185AC0", Offset = "0x185BC1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185AC0", Offset = "0x185BC1")]
		public SharedQuaternion storeValue;

		// Token: 0x0401B68D RID: 112269
		[Token(Token = "0x40180AE")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B68E RID: 112270
		[Token(Token = "0x40180AF")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
