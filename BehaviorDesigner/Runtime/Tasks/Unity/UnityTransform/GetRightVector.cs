using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001332 RID: 4914
	[Token(Token = "0x2000CFD")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CFA0", Offset = "0x14D0A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CFA0", Offset = "0x14D0A1")]
	public class GetRightVector : Action
	{
		// Token: 0x060073AD RID: 29613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006061")]
		[Address(RVA = "0x299C8A0", Offset = "0x299C9A1", VA = "0x299C8A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x00027F30 File Offset: 0x00026130
		[Token(Token = "0x6006062")]
		[Address(RVA = "0x299C9A0", Offset = "0x299CAA1", VA = "0x299C9A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006063")]
		[Address(RVA = "0x299CA90", Offset = "0x299CB91", VA = "0x299CA90", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006064")]
		[Address(RVA = "0x299CB20", Offset = "0x299CC21", VA = "0x299CB20")]
		public GetRightVector()
		{
		}

		// Token: 0x0401B69B RID: 112283
		[Token(Token = "0x40180BC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185CC0", Offset = "0x185DC1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B69C RID: 112284
		[Token(Token = "0x40180BD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185D00", Offset = "0x185E01")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x185D00", Offset = "0x185E01")]
		public SharedVector3 storeValue;

		// Token: 0x0401B69D RID: 112285
		[Token(Token = "0x40180BE")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B69E RID: 112286
		[Token(Token = "0x40180BF")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
