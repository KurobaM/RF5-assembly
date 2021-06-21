using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBoxCollider2D
{
	// Token: 0x02001474 RID: 5236
	[Token(Token = "0x2000E3A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1546D0", Offset = "0x1547D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1546D0", Offset = "0x1547D1")]
	public class GetSize : Action
	{
		// Token: 0x0600781E RID: 30750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D2")]
		[Address(RVA = "0x28DFB60", Offset = "0x28DFC61", VA = "0x28DFB60", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00029D00 File Offset: 0x00027F00
		[Token(Token = "0x60064D3")]
		[Address(RVA = "0x28DFC60", Offset = "0x28DFD61", VA = "0x28DFC60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D4")]
		[Address(RVA = "0x28DFD50", Offset = "0x28DFE51", VA = "0x28DFD50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D5")]
		[Address(RVA = "0x28DFDE0", Offset = "0x28DFEE1", VA = "0x28DFDE0")]
		public GetSize()
		{
		}

		// Token: 0x0401BADB RID: 113371
		[Token(Token = "0x40184D9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190F70", Offset = "0x191071")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BADC RID: 113372
		[Token(Token = "0x40184DA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190FB0", Offset = "0x1910B1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190FB0", Offset = "0x1910B1")]
		public SharedVector2 storeValue;

		// Token: 0x0401BADD RID: 113373
		[Token(Token = "0x40184DB")]
		[FieldOffset(Offset = "0x60")]
		private BoxCollider2D boxCollider2D;

		// Token: 0x0401BADE RID: 113374
		[Token(Token = "0x40184DC")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
