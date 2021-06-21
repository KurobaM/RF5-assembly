using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCircleCollider2D
{
	// Token: 0x0200145C RID: 5212
	[Token(Token = "0x2000E22")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153DD0", Offset = "0x153ED1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153DD0", Offset = "0x153ED1")]
	public class SetRadius : Action
	{
		// Token: 0x060077BD RID: 30653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006471")]
		[Address(RVA = "0x28E3F20", Offset = "0x28E4021", VA = "0x28E3F20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060077BE RID: 30654 RVA: 0x00029AC0 File Offset: 0x00027CC0
		[Token(Token = "0x6006472")]
		[Address(RVA = "0x28E4020", Offset = "0x28E4121", VA = "0x28E4020", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060077BF RID: 30655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006473")]
		[Address(RVA = "0x28E4110", Offset = "0x28E4211", VA = "0x28E4110", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006474")]
		[Address(RVA = "0x28E4160", Offset = "0x28E4261", VA = "0x28E4160")]
		public SetRadius()
		{
		}

		// Token: 0x0401BA7C RID: 113276
		[Token(Token = "0x401847A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1902D0", Offset = "0x1903D1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA7D RID: 113277
		[Token(Token = "0x401847B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x190310", Offset = "0x190411")]
		public SharedFloat radius;

		// Token: 0x0401BA7E RID: 113278
		[Token(Token = "0x401847C")]
		[FieldOffset(Offset = "0x60")]
		private CircleCollider2D circleCollider2D;

		// Token: 0x0401BA7F RID: 113279
		[Token(Token = "0x401847D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
