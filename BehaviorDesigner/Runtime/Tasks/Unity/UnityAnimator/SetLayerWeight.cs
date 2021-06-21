using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014B8 RID: 5304
	[Token(Token = "0x2000E7B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155F30", Offset = "0x156031")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155F30", Offset = "0x156031")]
	public class SetLayerWeight : Action
	{
		// Token: 0x06007933 RID: 31027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D5")]
		[Address(RVA = "0x28D81F0", Offset = "0x28D82F1", VA = "0x28D81F0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x0002A360 File Offset: 0x00028560
		[Token(Token = "0x60065D6")]
		[Address(RVA = "0x28D82F0", Offset = "0x28D83F1", VA = "0x28D82F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D7")]
		[Address(RVA = "0x28D8410", Offset = "0x28D8511", VA = "0x28D8410", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D8")]
		[Address(RVA = "0x28D8470", Offset = "0x28D8571", VA = "0x28D8470")]
		public SetLayerWeight()
		{
		}

		// Token: 0x0401BBF8 RID: 113656
		[Token(Token = "0x40185EA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193610", Offset = "0x193711")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBF9 RID: 113657
		[Token(Token = "0x40185EB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193650", Offset = "0x193751")]
		public SharedInt index;

		// Token: 0x0401BBFA RID: 113658
		[Token(Token = "0x40185EC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193690", Offset = "0x193791")]
		public SharedFloat weight;

		// Token: 0x0401BBFB RID: 113659
		[Token(Token = "0x40185ED")]
		[FieldOffset(Offset = "0x68")]
		private Animator animator;

		// Token: 0x0401BBFC RID: 113660
		[Token(Token = "0x40185EE")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
