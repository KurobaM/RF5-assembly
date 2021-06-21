using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCapsuleCollider
{
	// Token: 0x0200146E RID: 5230
	[Token(Token = "0x2000E34")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154490", Offset = "0x154591")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154490", Offset = "0x154591")]
	public class GetHeight : Action
	{
		// Token: 0x06007806 RID: 30726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BA")]
		[Address(RVA = "0x28E0570", Offset = "0x28E0671", VA = "0x28E0570", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x00029C70 File Offset: 0x00027E70
		[Token(Token = "0x60064BB")]
		[Address(RVA = "0x28E0670", Offset = "0x28E0771", VA = "0x28E0670", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BC")]
		[Address(RVA = "0x28E0760", Offset = "0x28E0861", VA = "0x28E0760", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064BD")]
		[Address(RVA = "0x28E07B0", Offset = "0x28E08B1", VA = "0x28E07B0")]
		public GetHeight()
		{
		}

		// Token: 0x0401BAC3 RID: 113347
		[Token(Token = "0x40184C1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190C50", Offset = "0x190D51")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAC4 RID: 113348
		[Token(Token = "0x40184C2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190C90", Offset = "0x190D91")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190C90", Offset = "0x190D91")]
		public SharedFloat storeValue;

		// Token: 0x0401BAC5 RID: 113349
		[Token(Token = "0x40184C3")]
		[FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		// Token: 0x0401BAC6 RID: 113350
		[Token(Token = "0x40184C4")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
