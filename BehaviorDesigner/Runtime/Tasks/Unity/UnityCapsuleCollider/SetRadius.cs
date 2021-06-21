using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCapsuleCollider
{
	// Token: 0x02001473 RID: 5235
	[Token(Token = "0x2000E39")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154670", Offset = "0x154771")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154670", Offset = "0x154771")]
	public class SetRadius : Action
	{
		// Token: 0x0600781A RID: 30746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CE")]
		[Address(RVA = "0x28E1150", Offset = "0x28E1251", VA = "0x28E1150", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x00029CE8 File Offset: 0x00027EE8
		[Token(Token = "0x60064CF")]
		[Address(RVA = "0x28E1250", Offset = "0x28E1351", VA = "0x28E1250", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D0")]
		[Address(RVA = "0x28E1340", Offset = "0x28E1441", VA = "0x28E1340", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D1")]
		[Address(RVA = "0x28E1390", Offset = "0x28E1491", VA = "0x28E1390")]
		public SetRadius()
		{
		}

		// Token: 0x0401BAD7 RID: 113367
		[Token(Token = "0x40184D5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190EF0", Offset = "0x190FF1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAD8 RID: 113368
		[Token(Token = "0x40184D6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190F30", Offset = "0x191031")]
		public SharedFloat radius;

		// Token: 0x0401BAD9 RID: 113369
		[Token(Token = "0x40184D7")]
		[FieldOffset(Offset = "0x60")]
		private CapsuleCollider capsuleCollider;

		// Token: 0x0401BADA RID: 113370
		[Token(Token = "0x40184D8")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
