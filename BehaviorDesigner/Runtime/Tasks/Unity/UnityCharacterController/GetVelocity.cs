using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x02001462 RID: 5218
	[Token(Token = "0x2000E28")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154010", Offset = "0x154111")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154010", Offset = "0x154111")]
	public class GetVelocity : Action
	{
		// Token: 0x060077D5 RID: 30677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006489")]
		[Address(RVA = "0x28E1F70", Offset = "0x28E2071", VA = "0x28E1F70", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x00029B50 File Offset: 0x00027D50
		[Token(Token = "0x600648A")]
		[Address(RVA = "0x28E2070", Offset = "0x28E2171", VA = "0x28E2070", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600648B")]
		[Address(RVA = "0x28E2160", Offset = "0x28E2261", VA = "0x28E2160", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600648C")]
		[Address(RVA = "0x28E21F0", Offset = "0x28E22F1", VA = "0x28E21F0")]
		public GetVelocity()
		{
		}

		// Token: 0x0401BA94 RID: 113300
		[Token(Token = "0x4018492")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190620", Offset = "0x190721")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA95 RID: 113301
		[Token(Token = "0x4018493")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190660", Offset = "0x190761")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190660", Offset = "0x190761")]
		public SharedVector3 storeValue;

		// Token: 0x0401BA96 RID: 113302
		[Token(Token = "0x4018494")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BA97 RID: 113303
		[Token(Token = "0x4018495")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
