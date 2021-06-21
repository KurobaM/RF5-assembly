using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D1D RID: 3357
	[Token(Token = "0x20008A8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148440", Offset = "0x148541")]
	public class VRIK : IK
	{
		// Token: 0x06005601 RID: 22017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B2")]
		[Address(RVA = "0x27D07E0", Offset = "0x27D08E1", VA = "0x27D07E0", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AAA00", Offset = "0x1AAB01")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B3")]
		[Address(RVA = "0x27D0830", Offset = "0x27D0931", VA = "0x27D0830", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AAA40", Offset = "0x1AAB41")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B4")]
		[Address(RVA = "0x27D0880", Offset = "0x27D0981", VA = "0x27D0880")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AAA80", Offset = "0x1AAB81")]
		private void OpenSetupTutorial()
		{
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B5")]
		[Address(RVA = "0x27D08D0", Offset = "0x27D09D1", VA = "0x27D08D0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AAAC0", Offset = "0x1AABC1")]
		public void AutoDetectReferences()
		{
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B6")]
		[Address(RVA = "0x27D0D90", Offset = "0x27D0E91", VA = "0x27D0D90")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AAB00", Offset = "0x1AAC01")]
		public void GuessHandOrientations()
		{
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047B7")]
		[Address(RVA = "0x27D0DC0", Offset = "0x27D0EC1", VA = "0x27D0DC0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B8")]
		[Address(RVA = "0x27D0DD0", Offset = "0x27D0ED1", VA = "0x27D0DD0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B9")]
		[Address(RVA = "0x27D1780", Offset = "0x27D1881", VA = "0x27D1780", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047BA")]
		[Address(RVA = "0x27D1900", Offset = "0x27D1A01", VA = "0x27D1900")]
		public VRIK()
		{
		}

		// Token: 0x0400B513 RID: 46355
		[Token(Token = "0x400880B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ContextMenuItemAttribute", RVA = "0x179840", Offset = "0x179941")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179840", Offset = "0x179941")]
		public VRIK.References references;

		// Token: 0x0400B514 RID: 46356
		[Token(Token = "0x400880C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1798C0", Offset = "0x1799C1")]
		public IKSolverVR solver;

		// Token: 0x02000D1E RID: 3358
		[Token(Token = "0x20013EE")]
		[Serializable]
		public class References
		{
			// Token: 0x0600560A RID: 22026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007919")]
			[Address(RVA = "0x27D19B0", Offset = "0x27D1AB1", VA = "0x27D19B0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			// Token: 0x17000B04 RID: 2820
			// (get) Token: 0x0600560B RID: 22027 RVA: 0x0001C440 File Offset: 0x0001A640
			[Token(Token = "0x17000E0D")]
			public bool isFilled
			{
				[Token(Token = "0x600791A")]
				[Address(RVA = "0x27D12E0", Offset = "0x27D13E1", VA = "0x27D12E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x0600560C RID: 22028 RVA: 0x0001C458 File Offset: 0x0001A658
			[Token(Token = "0x17000E0E")]
			public bool isEmpty
			{
				[Token(Token = "0x600791B")]
				[Address(RVA = "0x27D0E50", Offset = "0x27D0F51", VA = "0x27D0E50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600560D RID: 22029 RVA: 0x0001C470 File Offset: 0x0001A670
			[Token(Token = "0x600791C")]
			[Address(RVA = "0x27D0900", Offset = "0x27D0A01", VA = "0x27D0900")]
			public static bool AutoDetectReferences(Transform root, out VRIK.References references)
			{
				return default(bool);
			}

			// Token: 0x0600560E RID: 22030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600791D")]
			[Address(RVA = "0x27D19A0", Offset = "0x27D1AA1", VA = "0x27D19A0")]
			public References()
			{
			}

			// Token: 0x0400B515 RID: 46357
			[Token(Token = "0x401B94C")]
			[FieldOffset(Offset = "0x10")]
			public Transform root;

			// Token: 0x0400B516 RID: 46358
			[Token(Token = "0x401B94D")]
			[FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			// Token: 0x0400B517 RID: 46359
			[Token(Token = "0x401B94E")]
			[FieldOffset(Offset = "0x20")]
			public Transform spine;

			// Token: 0x0400B518 RID: 46360
			[Token(Token = "0x401B94F")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195C50", Offset = "0x195D51")]
			public Transform chest;

			// Token: 0x0400B519 RID: 46361
			[Token(Token = "0x401B950")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195C90", Offset = "0x195D91")]
			public Transform neck;

			// Token: 0x0400B51A RID: 46362
			[Token(Token = "0x401B951")]
			[FieldOffset(Offset = "0x38")]
			public Transform head;

			// Token: 0x0400B51B RID: 46363
			[Token(Token = "0x401B952")]
			[FieldOffset(Offset = "0x40")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195CD0", Offset = "0x195DD1")]
			public Transform leftShoulder;

			// Token: 0x0400B51C RID: 46364
			[Token(Token = "0x401B953")]
			[FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			// Token: 0x0400B51D RID: 46365
			[Token(Token = "0x401B954")]
			[FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			// Token: 0x0400B51E RID: 46366
			[Token(Token = "0x401B955")]
			[FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			// Token: 0x0400B51F RID: 46367
			[Token(Token = "0x401B956")]
			[FieldOffset(Offset = "0x60")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195D10", Offset = "0x195E11")]
			public Transform rightShoulder;

			// Token: 0x0400B520 RID: 46368
			[Token(Token = "0x401B957")]
			[FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			// Token: 0x0400B521 RID: 46369
			[Token(Token = "0x401B958")]
			[FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			// Token: 0x0400B522 RID: 46370
			[Token(Token = "0x401B959")]
			[FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			// Token: 0x0400B523 RID: 46371
			[Token(Token = "0x401B95A")]
			[FieldOffset(Offset = "0x80")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195D50", Offset = "0x195E51")]
			public Transform leftThigh;

			// Token: 0x0400B524 RID: 46372
			[Token(Token = "0x401B95B")]
			[FieldOffset(Offset = "0x88")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195D90", Offset = "0x195E91")]
			public Transform leftCalf;

			// Token: 0x0400B525 RID: 46373
			[Token(Token = "0x401B95C")]
			[FieldOffset(Offset = "0x90")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195DD0", Offset = "0x195ED1")]
			public Transform leftFoot;

			// Token: 0x0400B526 RID: 46374
			[Token(Token = "0x401B95D")]
			[FieldOffset(Offset = "0x98")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195E10", Offset = "0x195F11")]
			public Transform leftToes;

			// Token: 0x0400B527 RID: 46375
			[Token(Token = "0x401B95E")]
			[FieldOffset(Offset = "0xA0")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195E50", Offset = "0x195F51")]
			public Transform rightThigh;

			// Token: 0x0400B528 RID: 46376
			[Token(Token = "0x401B95F")]
			[FieldOffset(Offset = "0xA8")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195E90", Offset = "0x195F91")]
			public Transform rightCalf;

			// Token: 0x0400B529 RID: 46377
			[Token(Token = "0x401B960")]
			[FieldOffset(Offset = "0xB0")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195ED0", Offset = "0x195FD1")]
			public Transform rightFoot;

			// Token: 0x0400B52A RID: 46378
			[Token(Token = "0x401B961")]
			[FieldOffset(Offset = "0xB8")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195F10", Offset = "0x196011")]
			public Transform rightToes;
		}
	}
}
