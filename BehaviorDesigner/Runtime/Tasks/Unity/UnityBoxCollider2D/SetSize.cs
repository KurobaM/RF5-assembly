using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBoxCollider2D
{
	// Token: 0x02001475 RID: 5237
	[Token(Token = "0x2000E3B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x154730", Offset = "0x154831")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x154730", Offset = "0x154831")]
	public class SetSize : Action
	{
		// Token: 0x06007822 RID: 30754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D6")]
		[Address(RVA = "0x28DFDF0", Offset = "0x28DFEF1", VA = "0x28DFDF0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x00029D18 File Offset: 0x00027F18
		[Token(Token = "0x60064D7")]
		[Address(RVA = "0x28DFEF0", Offset = "0x28DFFF1", VA = "0x28DFEF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D8")]
		[Address(RVA = "0x28DFFE0", Offset = "0x28E00E1", VA = "0x28DFFE0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D9")]
		[Address(RVA = "0x28E0070", Offset = "0x28E0171", VA = "0x28E0070")]
		public SetSize()
		{
		}

		// Token: 0x0401BADF RID: 113375
		[Token(Token = "0x40184DD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191000", Offset = "0x191101")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BAE0 RID: 113376
		[Token(Token = "0x40184DE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191040", Offset = "0x191141")]
		public SharedVector2 size;

		// Token: 0x0401BAE1 RID: 113377
		[Token(Token = "0x40184DF")]
		[FieldOffset(Offset = "0x60")]
		private BoxCollider2D boxCollider2D;

		// Token: 0x0401BAE2 RID: 113378
		[Token(Token = "0x40184E0")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
