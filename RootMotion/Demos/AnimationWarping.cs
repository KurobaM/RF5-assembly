using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CB2 RID: 3250
	[Token(Token = "0x2000856")]
	public class AnimationWarping : OffsetModifier
	{
		// Token: 0x060053A9 RID: 21417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BD")]
		[Address(RVA = "0x29AB480", Offset = "0x29AB581", VA = "0x29AB480", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x0001BC00 File Offset: 0x00019E00
		[Token(Token = "0x60045BE")]
		[Address(RVA = "0x29AB4B0", Offset = "0x29AB5B1", VA = "0x29AB4B0")]
		public float GetWarpWeight(int warpIndex)
		{
			return 0f;
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x29AB6C0", Offset = "0x29AB7C1", VA = "0x29AB6C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C0")]
		[Address(RVA = "0x29ABA90", Offset = "0x29ABB91", VA = "0x29ABA90")]
		private void OnDisable()
		{
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C1")]
		[Address(RVA = "0x29ABB30", Offset = "0x29ABC31", VA = "0x29ABB30")]
		public AnimationWarping()
		{
		}

		// Token: 0x0400B286 RID: 45702
		[Token(Token = "0x4008606")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1778D0", Offset = "0x1779D1")]
		public Animator animator;

		// Token: 0x0400B287 RID: 45703
		[Token(Token = "0x4008607")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177910", Offset = "0x177A11")]
		public AnimationWarping.EffectorMode effectorMode;

		// Token: 0x0400B288 RID: 45704
		[Token(Token = "0x4008608")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x177950", Offset = "0x177A51")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177950", Offset = "0x177A51")]
		public AnimationWarping.Warp[] warps;

		// Token: 0x0400B289 RID: 45705
		[Token(Token = "0x4008609")]
		[FieldOffset(Offset = "0x48")]
		private AnimationWarping.EffectorMode lastMode;

		// Token: 0x02000CB3 RID: 3251
		[Token(Token = "0x20013D5")]
		[Serializable]
		public struct Warp
		{
			// Token: 0x0400B28A RID: 45706
			[Token(Token = "0x401B8C4")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1958D0", Offset = "0x1959D1")]
			public int animationLayer;

			// Token: 0x0400B28B RID: 45707
			[Token(Token = "0x401B8C5")]
			[FieldOffset(Offset = "0x8")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195910", Offset = "0x195A11")]
			public string animationState;

			// Token: 0x0400B28C RID: 45708
			[Token(Token = "0x401B8C6")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195950", Offset = "0x195A51")]
			public AnimationCurve weightCurve;

			// Token: 0x0400B28D RID: 45709
			[Token(Token = "0x401B8C7")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195990", Offset = "0x195A91")]
			public Transform warpFrom;

			// Token: 0x0400B28E RID: 45710
			[Token(Token = "0x401B8C8")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1959D0", Offset = "0x195AD1")]
			public Transform warpTo;

			// Token: 0x0400B28F RID: 45711
			[Token(Token = "0x401B8C9")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195A10", Offset = "0x195B11")]
			public FullBodyBipedEffector effector;
		}

		// Token: 0x02000CB4 RID: 3252
		[Token(Token = "0x20013D6")]
		[Serializable]
		public enum EffectorMode
		{
			// Token: 0x0400B291 RID: 45713
			[Token(Token = "0x401B8CB")]
			PositionOffset,
			// Token: 0x0400B292 RID: 45714
			[Token(Token = "0x401B8CC")]
			Position
		}
	}
}
