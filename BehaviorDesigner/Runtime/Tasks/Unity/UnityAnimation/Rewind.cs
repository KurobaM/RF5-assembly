using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014C9 RID: 5321
	[Token(Token = "0x2000E8C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156590", Offset = "0x156691")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156590", Offset = "0x156691")]
	public class Rewind : Action
	{
		// Token: 0x0600797A RID: 31098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661C")]
		[Address(RVA = "0x28D38D0", Offset = "0x28D39D1", VA = "0x28D38D0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600797B RID: 31099 RVA: 0x0002A4F8 File Offset: 0x000286F8
		[Token(Token = "0x600661D")]
		[Address(RVA = "0x28D39D0", Offset = "0x28D3AD1", VA = "0x28D39D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661E")]
		[Address(RVA = "0x28D3B00", Offset = "0x28D3C01", VA = "0x28D3B00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600797D RID: 31101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600661F")]
		[Address(RVA = "0x28D3B80", Offset = "0x28D3C81", VA = "0x28D3B80")]
		public Rewind()
		{
		}

		// Token: 0x0401BC49 RID: 113737
		[Token(Token = "0x401863B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1941A0", Offset = "0x1942A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC4A RID: 113738
		[Token(Token = "0x401863C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1941E0", Offset = "0x1942E1")]
		public SharedString animationName;

		// Token: 0x0401BC4B RID: 113739
		[Token(Token = "0x401863D")]
		[FieldOffset(Offset = "0x60")]
		private Animation animation;

		// Token: 0x0401BC4C RID: 113740
		[Token(Token = "0x401863E")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
