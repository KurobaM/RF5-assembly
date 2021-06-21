using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D09 RID: 3337
	[Token(Token = "0x2000898")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x147F60", Offset = "0x148061")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x147F60", Offset = "0x148061")]
	public class GrounderIK : Grounder
	{
		// Token: 0x0600553F RID: 21823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471D")]
		[Address(RVA = "0x2C070F0", Offset = "0x2C071F1", VA = "0x2C070F0", Slot = "5")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9C60", Offset = "0x1A9D61")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471E")]
		[Address(RVA = "0x2C07140", Offset = "0x2C07241", VA = "0x2C07140", Slot = "6")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9CA0", Offset = "0x1A9DA1")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471F")]
		[Address(RVA = "0x2C07190", Offset = "0x2C07291", VA = "0x2C07190", Slot = "4")]
		public override void ResetPosition()
		{
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		[Token(Token = "0x6004720")]
		[Address(RVA = "0x2C071B0", Offset = "0x2C072B1", VA = "0x2C071B0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004721")]
		[Address(RVA = "0x2C073A0", Offset = "0x2C074A1", VA = "0x2C073A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004722")]
		[Address(RVA = "0x2C074A0", Offset = "0x2C075A1", VA = "0x2C074A0")]
		private void Update()
		{
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004723")]
		[Address(RVA = "0x2C07C00", Offset = "0x2C07D01", VA = "0x2C07C00")]
		private void Initiate()
		{
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004724")]
		[Address(RVA = "0x2C08050", Offset = "0x2C08151", VA = "0x2C08050")]
		private void OnSolverUpdate()
		{
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004725")]
		[Address(RVA = "0x2C082D0", Offset = "0x2C083D1", VA = "0x2C082D0")]
		private void SetLegIK(int index)
		{
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004726")]
		[Address(RVA = "0x2C08600", Offset = "0x2C08701", VA = "0x2C08600")]
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004727")]
		[Address(RVA = "0x2C087A0", Offset = "0x2C088A1", VA = "0x2C087A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004728")]
		[Address(RVA = "0x2C08990", Offset = "0x2C08A91", VA = "0x2C08990")]
		public GrounderIK()
		{
		}

		// Token: 0x0400B49C RID: 46236
		[Token(Token = "0x40087B8")]
		[FieldOffset(Offset = "0x40")]
		public IK[] legs;

		// Token: 0x0400B49D RID: 46237
		[Token(Token = "0x40087B9")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178D50", Offset = "0x178E51")]
		public Transform pelvis;

		// Token: 0x0400B49E RID: 46238
		[Token(Token = "0x40087BA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178D90", Offset = "0x178E91")]
		public Transform characterRoot;

		// Token: 0x0400B49F RID: 46239
		[Token(Token = "0x40087BB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178DD0", Offset = "0x178ED1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x178DD0", Offset = "0x178ED1")]
		public float rootRotationWeight;

		// Token: 0x0400B4A0 RID: 46240
		[Token(Token = "0x40087BC")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178E30", Offset = "0x178F31")]
		public float rootRotationSpeed;

		// Token: 0x0400B4A1 RID: 46241
		[Token(Token = "0x40087BD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178E70", Offset = "0x178F71")]
		public float maxRootRotationAngle;

		// Token: 0x0400B4A2 RID: 46242
		[Token(Token = "0x40087BE")]
		[FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		// Token: 0x0400B4A3 RID: 46243
		[Token(Token = "0x40087BF")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		// Token: 0x0400B4A4 RID: 46244
		[Token(Token = "0x40087C0")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		// Token: 0x0400B4A5 RID: 46245
		[Token(Token = "0x40087C1")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		// Token: 0x0400B4A6 RID: 46246
		[Token(Token = "0x40087C2")]
		[FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		// Token: 0x0400B4A7 RID: 46247
		[Token(Token = "0x40087C3")]
		[FieldOffset(Offset = "0x94")]
		private bool solved;

		// Token: 0x0400B4A8 RID: 46248
		[Token(Token = "0x40087C4")]
		[FieldOffset(Offset = "0x98")]
		private float lastWeight;

		// Token: 0x0400B4A9 RID: 46249
		[Token(Token = "0x40087C5")]
		[FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;
	}
}
