using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014A6 RID: 5286
	[Token(Token = "0x2000E6C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155990", Offset = "0x155A91")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155990", Offset = "0x155A91")]
	public class GetGravityWeight : Action
	{
		// Token: 0x060078E3 RID: 30947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006597")]
		[Address(RVA = "0x28D54A0", Offset = "0x28D55A1", VA = "0x28D54A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x0002A1B0 File Offset: 0x000283B0
		[Token(Token = "0x6006598")]
		[Address(RVA = "0x28D55A0", Offset = "0x28D56A1", VA = "0x28D55A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006599")]
		[Address(RVA = "0x28D5690", Offset = "0x28D5791", VA = "0x28D5690", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659A")]
		[Address(RVA = "0x28D56E0", Offset = "0x28D57E1", VA = "0x28D56E0")]
		public GetGravityWeight()
		{
		}

		// Token: 0x0401BB9E RID: 113566
		[Token(Token = "0x401859C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192A00", Offset = "0x192B01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB9F RID: 113567
		[Token(Token = "0x401859D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192A40", Offset = "0x192B41")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x192A40", Offset = "0x192B41")]
		public SharedFloat storeValue;

		// Token: 0x0401BBA0 RID: 113568
		[Token(Token = "0x401859E")]
		[FieldOffset(Offset = "0x60")]
		private Animator animator;

		// Token: 0x0401BBA1 RID: 113569
		[Token(Token = "0x401859F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
