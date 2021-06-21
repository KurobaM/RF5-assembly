using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D06 RID: 3334
	[Token(Token = "0x2000896")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x147EA0", Offset = "0x147FA1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x147EA0", Offset = "0x147FA1")]
	public class GrounderBipedIK : Grounder
	{
		// Token: 0x06005523 RID: 21795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004703")]
		[Address(RVA = "0x2C049B0", Offset = "0x2C04AB1", VA = "0x2C049B0", Slot = "5")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9B20", Offset = "0x1A9C21")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004704")]
		[Address(RVA = "0x2C04A00", Offset = "0x2C04B01", VA = "0x2C04A00", Slot = "6")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9B60", Offset = "0x1A9C61")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004705")]
		[Address(RVA = "0x2C04A50", Offset = "0x2C04B51", VA = "0x2C04A50", Slot = "4")]
		public override void ResetPosition()
		{
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		[Token(Token = "0x6004706")]
		[Address(RVA = "0x2C04B60", Offset = "0x2C04C61", VA = "0x2C04B60")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004707")]
		[Address(RVA = "0x2C04C20", Offset = "0x2C04D21", VA = "0x2C04C20")]
		private void Update()
		{
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004708")]
		[Address(RVA = "0x2C04CE0", Offset = "0x2C04DE1", VA = "0x2C04CE0")]
		private void Initiate()
		{
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004709")]
		[Address(RVA = "0x2C052C0", Offset = "0x2C053C1", VA = "0x2C052C0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470A")]
		[Address(RVA = "0x2C05320", Offset = "0x2C05421", VA = "0x2C05320")]
		private void OnSolverUpdate()
		{
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470B")]
		[Address(RVA = "0x2C05AF0", Offset = "0x2C05BF1", VA = "0x2C05AF0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470C")]
		[Address(RVA = "0x2C05C70", Offset = "0x2C05D71", VA = "0x2C05C70")]
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470D")]
		[Address(RVA = "0x2C05E00", Offset = "0x2C05F01", VA = "0x2C05E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470E")]
		[Address(RVA = "0x2C05FB0", Offset = "0x2C060B1", VA = "0x2C05FB0")]
		public GrounderBipedIK()
		{
		}

		// Token: 0x0400B489 RID: 46217
		[Token(Token = "0x40087A8")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178BD0", Offset = "0x178CD1")]
		public BipedIK ik;

		// Token: 0x0400B48A RID: 46218
		[Token(Token = "0x40087A9")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178C10", Offset = "0x178D11")]
		public float spineBend;

		// Token: 0x0400B48B RID: 46219
		[Token(Token = "0x40087AA")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178C50", Offset = "0x178D51")]
		public float spineSpeed;

		// Token: 0x0400B48C RID: 46220
		[Token(Token = "0x40087AB")]
		[FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		// Token: 0x0400B48D RID: 46221
		[Token(Token = "0x40087AC")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		// Token: 0x0400B48E RID: 46222
		[Token(Token = "0x40087AD")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		// Token: 0x0400B48F RID: 46223
		[Token(Token = "0x40087AE")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		// Token: 0x0400B490 RID: 46224
		[Token(Token = "0x40087AF")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		// Token: 0x0400B491 RID: 46225
		[Token(Token = "0x40087B0")]
		[FieldOffset(Offset = "0x84")]
		private float lastWeight;
	}
}
