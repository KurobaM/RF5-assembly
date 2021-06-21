using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x02001460 RID: 5216
	[Token(Token = "0x2000E26")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153F50", Offset = "0x154051")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153F50", Offset = "0x154051")]
	public class GetSlopeLimit : Action
	{
		// Token: 0x060077CD RID: 30669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006481")]
		[Address(RVA = "0x28E1AD0", Offset = "0x28E1BD1", VA = "0x28E1AD0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x00029B20 File Offset: 0x00027D20
		[Token(Token = "0x6006482")]
		[Address(RVA = "0x28E1BD0", Offset = "0x28E1CD1", VA = "0x28E1BD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006483")]
		[Address(RVA = "0x28E1CC0", Offset = "0x28E1DC1", VA = "0x28E1CC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006484")]
		[Address(RVA = "0x28E1D10", Offset = "0x28E1E11", VA = "0x28E1D10")]
		public GetSlopeLimit()
		{
		}

		// Token: 0x0401BA8C RID: 113292
		[Token(Token = "0x401848A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190500", Offset = "0x190601")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA8D RID: 113293
		[Token(Token = "0x401848B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190540", Offset = "0x190641")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190540", Offset = "0x190641")]
		public SharedFloat storeValue;

		// Token: 0x0401BA8E RID: 113294
		[Token(Token = "0x401848C")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BA8F RID: 113295
		[Token(Token = "0x401848D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
