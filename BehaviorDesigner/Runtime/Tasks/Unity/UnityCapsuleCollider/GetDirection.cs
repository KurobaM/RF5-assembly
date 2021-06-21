using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCapsuleCollider
{
	// Token: 0x0200146D RID: 5229
	[Token(Token = "0x2000E33")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154430", Offset = "0x154531")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154430", Offset = "0x154531")]
	public class GetDirection : Action
	{
		// Token: 0x06007802 RID: 30722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B6")]
		[Address(RVA = "0x28E0310", Offset = "0x28E0411", VA = "0x28E0310", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x00029C58 File Offset: 0x00027E58
		[Token(Token = "0x60064B7")]
		[Address(RVA = "0x28E0410", Offset = "0x28E0511", VA = "0x28E0410", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B8")]
		[Address(RVA = "0x28E0510", Offset = "0x28E0611", VA = "0x28E0510", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B9")]
		[Address(RVA = "0x28E0560", Offset = "0x28E0661", VA = "0x28E0560")]
		public GetDirection()
		{
		}

		// Token: 0x0401BABF RID: 113343
		[Token(Token = "0x40184BD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190BC0", Offset = "0x190CC1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAC0 RID: 113344
		[Token(Token = "0x40184BE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190C00", Offset = "0x190D01")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190C00", Offset = "0x190D01")]
		public SharedInt storeValue;

		// Token: 0x0401BAC1 RID: 113345
		[Token(Token = "0x40184BF")]
		[FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		// Token: 0x0401BAC2 RID: 113346
		[Token(Token = "0x40184C0")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
