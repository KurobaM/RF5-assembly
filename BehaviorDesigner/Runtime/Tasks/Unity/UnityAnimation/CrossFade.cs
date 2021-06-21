using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014C3 RID: 5315
	[Token(Token = "0x2000E86")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156350", Offset = "0x156451")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x156350", Offset = "0x156451")]
	public class CrossFade : Action
	{
		// Token: 0x06007962 RID: 31074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006604")]
		[Address(RVA = "0x28D2730", Offset = "0x28D2831", VA = "0x28D2730", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007963 RID: 31075 RVA: 0x0002A468 File Offset: 0x00028668
		[Token(Token = "0x6006605")]
		[Address(RVA = "0x28D2830", Offset = "0x28D2931", VA = "0x28D2830", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007964 RID: 31076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006606")]
		[Address(RVA = "0x28D2A50", Offset = "0x28D2B51", VA = "0x28D2A50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006607")]
		[Address(RVA = "0x28D2B10", Offset = "0x28D2C11", VA = "0x28D2B10")]
		public CrossFade()
		{
		}

		// Token: 0x0401BC28 RID: 113704
		[Token(Token = "0x401861A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193C50", Offset = "0x193D51")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC29 RID: 113705
		[Token(Token = "0x401861B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193C90", Offset = "0x193D91")]
		public SharedString animationName;

		// Token: 0x0401BC2A RID: 113706
		[Token(Token = "0x401861C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193CD0", Offset = "0x193DD1")]
		public SharedFloat animationSpeed;

		// Token: 0x0401BC2B RID: 113707
		[Token(Token = "0x401861D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193D10", Offset = "0x193E11")]
		public SharedFloat fadeLength;

		// Token: 0x0401BC2C RID: 113708
		[Token(Token = "0x401861E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193D50", Offset = "0x193E51")]
		public PlayMode playMode;

		// Token: 0x0401BC2D RID: 113709
		[Token(Token = "0x401861F")]
		[FieldOffset(Offset = "0x78")]
		private Animation animation;

		// Token: 0x0401BC2E RID: 113710
		[Token(Token = "0x4018620")]
		[FieldOffset(Offset = "0x80")]
		private GameObject prevGameObject;
	}
}
