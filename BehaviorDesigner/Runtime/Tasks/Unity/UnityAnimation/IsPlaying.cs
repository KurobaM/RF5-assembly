using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014C6 RID: 5318
	[Token(Token = "0x2000E89")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156470", Offset = "0x156571")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156470", Offset = "0x156571")]
	public class IsPlaying : Conditional
	{
		// Token: 0x0600796E RID: 31086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006610")]
		[Address(RVA = "0x28D30A0", Offset = "0x28D31A1", VA = "0x28D30A0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x0002A4B0 File Offset: 0x000286B0
		[Token(Token = "0x6006611")]
		[Address(RVA = "0x28D31A0", Offset = "0x28D32A1", VA = "0x28D31A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007970 RID: 31088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006612")]
		[Address(RVA = "0x28D32E0", Offset = "0x28D33E1", VA = "0x28D32E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006613")]
		[Address(RVA = "0x28D3360", Offset = "0x28D3461", VA = "0x28D3360")]
		public IsPlaying()
		{
		}

		// Token: 0x0401BC3A RID: 113722
		[Token(Token = "0x401862C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193F60", Offset = "0x194061")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC3B RID: 113723
		[Token(Token = "0x401862D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193FA0", Offset = "0x1940A1")]
		public SharedString animationName;

		// Token: 0x0401BC3C RID: 113724
		[Token(Token = "0x401862E")]
		[FieldOffset(Offset = "0x60")]
		private Animation animation;

		// Token: 0x0401BC3D RID: 113725
		[Token(Token = "0x401862F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
