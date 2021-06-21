using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityTransform
{
	// Token: 0x02001342 RID: 4930
	[Token(Token = "0x2000D0D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14D5A0", Offset = "0x14D6A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14D5A0", Offset = "0x14D6A1")]
	public class SetRotation : Action
	{
		// Token: 0x060073ED RID: 29677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A1")]
		[Address(RVA = "0x299F2B0", Offset = "0x299F3B1", VA = "0x299F2B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x000280B0 File Offset: 0x000262B0
		[Token(Token = "0x60060A2")]
		[Address(RVA = "0x299F3B0", Offset = "0x299F4B1", VA = "0x299F3B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A3")]
		[Address(RVA = "0x299F4A0", Offset = "0x299F5A1", VA = "0x299F4A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060073F0 RID: 29680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060A4")]
		[Address(RVA = "0x299F530", Offset = "0x299F631", VA = "0x299F530")]
		public SetRotation()
		{
		}

		// Token: 0x0401B6E0 RID: 112352
		[Token(Token = "0x4018101")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186630", Offset = "0x186731")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B6E1 RID: 112353
		[Token(Token = "0x4018102")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186670", Offset = "0x186771")]
		public SharedQuaternion rotation;

		// Token: 0x0401B6E2 RID: 112354
		[Token(Token = "0x4018103")]
		[FieldOffset(Offset = "0x60")]
		private Transform targetTransform;

		// Token: 0x0401B6E3 RID: 112355
		[Token(Token = "0x4018104")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
