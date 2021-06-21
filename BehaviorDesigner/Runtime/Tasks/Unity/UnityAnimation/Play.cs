using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014C7 RID: 5319
	[Token(Token = "0x2000E8A")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1564D0", Offset = "0x1565D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1564D0", Offset = "0x1565D1")]
	public class Play : Action
	{
		// Token: 0x06007972 RID: 31090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006614")]
		[Address(RVA = "0x28D3370", Offset = "0x28D3471", VA = "0x28D3370", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x0002A4C8 File Offset: 0x000286C8
		[Token(Token = "0x6006615")]
		[Address(RVA = "0x28D3470", Offset = "0x28D3571", VA = "0x28D3470", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006616")]
		[Address(RVA = "0x28D35B0", Offset = "0x28D36B1", VA = "0x28D35B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006617")]
		[Address(RVA = "0x28D3630", Offset = "0x28D3731", VA = "0x28D3630")]
		public Play()
		{
		}

		// Token: 0x0401BC3E RID: 113726
		[Token(Token = "0x4018630")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193FE0", Offset = "0x1940E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC3F RID: 113727
		[Token(Token = "0x4018631")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194020", Offset = "0x194121")]
		public SharedString animationName;

		// Token: 0x0401BC40 RID: 113728
		[Token(Token = "0x4018632")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194060", Offset = "0x194161")]
		public PlayMode playMode;

		// Token: 0x0401BC41 RID: 113729
		[Token(Token = "0x4018633")]
		[FieldOffset(Offset = "0x68")]
		private Animation animation;

		// Token: 0x0401BC42 RID: 113730
		[Token(Token = "0x4018634")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
