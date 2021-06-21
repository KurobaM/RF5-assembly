using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014A7 RID: 5287
	[Token(Token = "0x2000E6D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1559F0", Offset = "0x155AF1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1559F0", Offset = "0x155AF1")]
	public class GetIntegerParameter : Action
	{
		// Token: 0x060078E7 RID: 30951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659B")]
		[Address(RVA = "0x28D56F0", Offset = "0x28D57F1", VA = "0x28D56F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x0002A1C8 File Offset: 0x000283C8
		[Token(Token = "0x600659C")]
		[Address(RVA = "0x28D57F0", Offset = "0x28D58F1", VA = "0x28D57F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659D")]
		[Address(RVA = "0x28D5900", Offset = "0x28D5A01", VA = "0x28D5900", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600659E")]
		[Address(RVA = "0x28D5990", Offset = "0x28D5A91", VA = "0x28D5990")]
		public GetIntegerParameter()
		{
		}

		// Token: 0x0401BBA2 RID: 113570
		[Token(Token = "0x40185A0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192A90", Offset = "0x192B91")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBA3 RID: 113571
		[Token(Token = "0x40185A1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192AD0", Offset = "0x192BD1")]
		public SharedString paramaterName;

		// Token: 0x0401BBA4 RID: 113572
		[Token(Token = "0x40185A2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192B10", Offset = "0x192C11")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x192B10", Offset = "0x192C11")]
		public SharedInt storeValue;

		// Token: 0x0401BBA5 RID: 113573
		[Token(Token = "0x40185A3")]
		[FieldOffset(Offset = "0x68")]
		private Animator animator;

		// Token: 0x0401BBA6 RID: 113574
		[Token(Token = "0x40185A4")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
