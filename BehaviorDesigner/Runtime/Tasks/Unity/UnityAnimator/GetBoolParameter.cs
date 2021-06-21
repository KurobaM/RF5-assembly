using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014A2 RID: 5282
	[Token(Token = "0x2000E68")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155810", Offset = "0x155911")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155810", Offset = "0x155911")]
	public class GetBoolParameter : Action
	{
		// Token: 0x060078D3 RID: 30931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006587")]
		[Address(RVA = "0x28D4A20", Offset = "0x28D4B21", VA = "0x28D4A20", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x0002A150 File Offset: 0x00028350
		[Token(Token = "0x6006588")]
		[Address(RVA = "0x28D4B20", Offset = "0x28D4C21", VA = "0x28D4B20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006589")]
		[Address(RVA = "0x28D4C30", Offset = "0x28D4D31", VA = "0x28D4C30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658A")]
		[Address(RVA = "0x28D4CC0", Offset = "0x28D4DC1", VA = "0x28D4CC0")]
		public GetBoolParameter()
		{
		}

		// Token: 0x0401BB8C RID: 113548
		[Token(Token = "0x401858A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192740", Offset = "0x192841")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BB8D RID: 113549
		[Token(Token = "0x401858B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x192780", Offset = "0x192881")]
		public SharedString paramaterName;

		// Token: 0x0401BB8E RID: 113550
		[Token(Token = "0x401858C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1927C0", Offset = "0x1928C1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1927C0", Offset = "0x1928C1")]
		public SharedBool storeValue;

		// Token: 0x0401BB8F RID: 113551
		[Token(Token = "0x401858D")]
		[FieldOffset(Offset = "0x68")]
		private Animator animator;

		// Token: 0x0401BB90 RID: 113552
		[Token(Token = "0x401858E")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
