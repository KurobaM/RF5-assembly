using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBoxCollider
{
	// Token: 0x02001476 RID: 5238
	[Token(Token = "0x2000E3C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154790", Offset = "0x154891")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154790", Offset = "0x154891")]
	public class GetCenter : Action
	{
		// Token: 0x06007826 RID: 30758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DA")]
		[Address(RVA = "0x28DF120", Offset = "0x28DF221", VA = "0x28DF120", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00029D30 File Offset: 0x00027F30
		[Token(Token = "0x60064DB")]
		[Address(RVA = "0x28DF220", Offset = "0x28DF321", VA = "0x28DF220", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DC")]
		[Address(RVA = "0x28DF310", Offset = "0x28DF411", VA = "0x28DF310", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DD")]
		[Address(RVA = "0x28DF3A0", Offset = "0x28DF4A1", VA = "0x28DF3A0")]
		public GetCenter()
		{
		}

		// Token: 0x0401BAE3 RID: 113379
		[Token(Token = "0x40184E1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191080", Offset = "0x191181")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAE4 RID: 113380
		[Token(Token = "0x40184E2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1910C0", Offset = "0x1911C1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1910C0", Offset = "0x1911C1")]
		public SharedVector3 storeValue;

		// Token: 0x0401BAE5 RID: 113381
		[Token(Token = "0x40184E3")]
		[FieldOffset(Offset = "0x60")]
		private BoxCollider boxCollider;

		// Token: 0x0401BAE6 RID: 113382
		[Token(Token = "0x40184E4")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
