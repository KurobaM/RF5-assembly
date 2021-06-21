using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D0A RID: 3338
	[Token(Token = "0x2000899")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x147FC0", Offset = "0x1480C1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x147FC0", Offset = "0x1480C1")]
	public class GrounderQuadruped : Grounder
	{
		// Token: 0x0600554B RID: 21835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004729")]
		[Address(RVA = "0x2C08AF0", Offset = "0x2C08BF1", VA = "0x2C08AF0", Slot = "5")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9CE0", Offset = "0x1A9DE1")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600472A")]
		[Address(RVA = "0x2C08B40", Offset = "0x2C08C41", VA = "0x2C08B40", Slot = "6")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9D20", Offset = "0x1A9E21")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600472B")]
		[Address(RVA = "0x2C08B90", Offset = "0x2C08C91", VA = "0x2C08B90", Slot = "4")]
		public override void ResetPosition()
		{
		}

		// Token: 0x0600554E RID: 21838 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		[Token(Token = "0x600472C")]
		[Address(RVA = "0x2C08BD0", Offset = "0x2C08CD1", VA = "0x2C08BD0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x0001C110 File Offset: 0x0001A310
		[Token(Token = "0x600472D")]
		[Address(RVA = "0x2C08D00", Offset = "0x2C08E01", VA = "0x2C08D00")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600472E")]
		[Address(RVA = "0x2C08EC0", Offset = "0x2C08FC1", VA = "0x2C08EC0")]
		private void OnDisable()
		{
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600472F")]
		[Address(RVA = "0x2C08F30", Offset = "0x2C09031", VA = "0x2C08F30")]
		private void Update()
		{
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004730")]
		[Address(RVA = "0x2C08FF0", Offset = "0x2C090F1", VA = "0x2C08FF0")]
		private void Initiate()
		{
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004731")]
		[Address(RVA = "0x2C09320", Offset = "0x2C09421", VA = "0x2C09320")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref GrounderQuadruped.Foot[] f, int indexOffset)
		{
			return null;
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004732")]
		[Address(RVA = "0x2C09750", Offset = "0x2C09851", VA = "0x2C09750")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004733")]
		[Address(RVA = "0x2C098A0", Offset = "0x2C099A1", VA = "0x2C098A0")]
		private void RootRotation()
		{
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004734")]
		[Address(RVA = "0x2C09D50", Offset = "0x2C09E51", VA = "0x2C09D50")]
		private void OnSolverUpdate()
		{
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004735")]
		[Address(RVA = "0x2C0A5C0", Offset = "0x2C0A6C1", VA = "0x2C0A5C0")]
		private void UpdateForefeetRoot()
		{
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004736")]
		[Address(RVA = "0x2C0A880", Offset = "0x2C0A981", VA = "0x2C0A880")]
		private void SetFootIK(GrounderQuadruped.Foot foot, float maxOffset)
		{
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004737")]
		[Address(RVA = "0x2C0A9E0", Offset = "0x2C0AAE1", VA = "0x2C0A9E0")]
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004738")]
		[Address(RVA = "0x2C0ACC0", Offset = "0x2C0ADC1", VA = "0x2C0ACC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004739")]
		[Address(RVA = "0x2C0AD00", Offset = "0x2C0AE01", VA = "0x2C0AD00")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473A")]
		[Address(RVA = "0x2C0AEF0", Offset = "0x2C0AFF1", VA = "0x2C0AEF0")]
		public GrounderQuadruped()
		{
		}

		// Token: 0x0400B4AA RID: 46250
		[Token(Token = "0x40087C6")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178EB0", Offset = "0x178FB1")]
		public Grounding forelegSolver;

		// Token: 0x0400B4AB RID: 46251
		[Token(Token = "0x40087C7")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178EF0", Offset = "0x178FF1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x178EF0", Offset = "0x178FF1")]
		public float rootRotationWeight;

		// Token: 0x0400B4AC RID: 46252
		[Token(Token = "0x40087C8")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178F50", Offset = "0x179051")]
		[Attribute(Name = "RangeAttribute", RVA = "0x178F50", Offset = "0x179051")]
		public float minRootRotation;

		// Token: 0x0400B4AD RID: 46253
		[Token(Token = "0x40087C9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178FB0", Offset = "0x1790B1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x178FB0", Offset = "0x1790B1")]
		public float maxRootRotation;

		// Token: 0x0400B4AE RID: 46254
		[Token(Token = "0x40087CA")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179010", Offset = "0x179111")]
		public float rootRotationSpeed;

		// Token: 0x0400B4AF RID: 46255
		[Token(Token = "0x40087CB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179050", Offset = "0x179151")]
		public float maxLegOffset;

		// Token: 0x0400B4B0 RID: 46256
		[Token(Token = "0x40087CC")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179090", Offset = "0x179191")]
		public float maxForeLegOffset;

		// Token: 0x0400B4B1 RID: 46257
		[Token(Token = "0x40087CD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1790D0", Offset = "0x1791D1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1790D0", Offset = "0x1791D1")]
		public float maintainHeadRotationWeight;

		// Token: 0x0400B4B2 RID: 46258
		[Token(Token = "0x40087CE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179130", Offset = "0x179231")]
		public Transform characterRoot;

		// Token: 0x0400B4B3 RID: 46259
		[Token(Token = "0x40087CF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179170", Offset = "0x179271")]
		public Transform pelvis;

		// Token: 0x0400B4B4 RID: 46260
		[Token(Token = "0x40087D0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1791B0", Offset = "0x1792B1")]
		public Transform lastSpineBone;

		// Token: 0x0400B4B5 RID: 46261
		[Token(Token = "0x40087D1")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1791F0", Offset = "0x1792F1")]
		public Transform head;

		// Token: 0x0400B4B6 RID: 46262
		[Token(Token = "0x40087D2")]
		[FieldOffset(Offset = "0x88")]
		public IK[] legs;

		// Token: 0x0400B4B7 RID: 46263
		[Token(Token = "0x40087D3")]
		[FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		// Token: 0x0400B4B8 RID: 46264
		[Token(Token = "0x40087D4")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "HideInInspector", RVA = "0x179230", Offset = "0x179331")]
		public Vector3 gravity;

		// Token: 0x0400B4B9 RID: 46265
		[Token(Token = "0x40087D5")]
		[FieldOffset(Offset = "0xA8")]
		private GrounderQuadruped.Foot[] feet;

		// Token: 0x0400B4BA RID: 46266
		[Token(Token = "0x40087D6")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		// Token: 0x0400B4BB RID: 46267
		[Token(Token = "0x40087D7")]
		[FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		// Token: 0x0400B4BC RID: 46268
		[Token(Token = "0x40087D8")]
		[FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		// Token: 0x0400B4BD RID: 46269
		[Token(Token = "0x40087D9")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		// Token: 0x0400B4BE RID: 46270
		[Token(Token = "0x40087DA")]
		[FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		// Token: 0x0400B4BF RID: 46271
		[Token(Token = "0x40087DB")]
		[FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		// Token: 0x0400B4C0 RID: 46272
		[Token(Token = "0x40087DC")]
		[FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		// Token: 0x0400B4C1 RID: 46273
		[Token(Token = "0x40087DD")]
		[FieldOffset(Offset = "0x10C")]
		private bool solved;

		// Token: 0x0400B4C2 RID: 46274
		[Token(Token = "0x40087DE")]
		[FieldOffset(Offset = "0x110")]
		private float angle;

		// Token: 0x0400B4C3 RID: 46275
		[Token(Token = "0x40087DF")]
		[FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		// Token: 0x0400B4C4 RID: 46276
		[Token(Token = "0x40087E0")]
		[FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		// Token: 0x0400B4C5 RID: 46277
		[Token(Token = "0x40087E1")]
		[FieldOffset(Offset = "0x130")]
		private float lastWeight;

		// Token: 0x0400B4C6 RID: 46278
		[Token(Token = "0x40087E2")]
		[FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		// Token: 0x02000D0B RID: 3339
		[Token(Token = "0x20013EA")]
		public struct Foot
		{
			// Token: 0x0600555D RID: 21853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078EC")]
			[Address(RVA = "0x37BEC0", Offset = "0x37BFC1", VA = "0x37BEC0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}

			// Token: 0x0400B4C7 RID: 46279
			[Token(Token = "0x401B928")]
			[FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			// Token: 0x0400B4C8 RID: 46280
			[Token(Token = "0x401B929")]
			[FieldOffset(Offset = "0x8")]
			public Transform transform;

			// Token: 0x0400B4C9 RID: 46281
			[Token(Token = "0x401B92A")]
			[FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			// Token: 0x0400B4CA RID: 46282
			[Token(Token = "0x401B92B")]
			[FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;
		}
	}
}
