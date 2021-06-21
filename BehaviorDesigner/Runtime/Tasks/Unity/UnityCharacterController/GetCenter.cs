using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
	// Token: 0x0200145D RID: 5213
	[Token(Token = "0x2000E23")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153E30", Offset = "0x153F31")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153E30", Offset = "0x153F31")]
	public class GetCenter : Action
	{
		// Token: 0x060077C1 RID: 30657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006475")]
		[Address(RVA = "0x28E13A0", Offset = "0x28E14A1", VA = "0x28E13A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x00029AD8 File Offset: 0x00027CD8
		[Token(Token = "0x6006476")]
		[Address(RVA = "0x28E14A0", Offset = "0x28E15A1", VA = "0x28E14A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006477")]
		[Address(RVA = "0x28E1590", Offset = "0x28E1691", VA = "0x28E1590", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006478")]
		[Address(RVA = "0x28E1620", Offset = "0x28E1721", VA = "0x28E1620")]
		public GetCenter()
		{
		}

		// Token: 0x0401BA80 RID: 113280
		[Token(Token = "0x401847E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190350", Offset = "0x190451")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA81 RID: 113281
		[Token(Token = "0x401847F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190390", Offset = "0x190491")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x190390", Offset = "0x190491")]
		public SharedVector3 storeValue;

		// Token: 0x0401BA82 RID: 113282
		[Token(Token = "0x4018480")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController characterController;

		// Token: 0x0401BA83 RID: 113283
		[Token(Token = "0x4018481")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
