using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D0D RID: 3341
	[Token(Token = "0x200089B")]
	[Serializable]
	public class Grounding
	{
		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600556B RID: 21867 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600556C RID: 21868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008AB")]
		public Grounding.Leg[] legs
		{
			[Token(Token = "0x6004748")]
			[Address(RVA = "0x2C0BF80", Offset = "0x2C0C081", VA = "0x2C0BF80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9E20", Offset = "0x1A9F21")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004749")]
			[Address(RVA = "0x2C0BF90", Offset = "0x2C0C091", VA = "0x2C0BF90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9E30", Offset = "0x1A9F31")]
			private set
			{
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600556D RID: 21869 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600556E RID: 21870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008AC")]
		public Grounding.Pelvis pelvis
		{
			[Token(Token = "0x600474A")]
			[Address(RVA = "0x2C0BFA0", Offset = "0x2C0C0A1", VA = "0x2C0BFA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9E40", Offset = "0x1A9F41")]
			get
			{
				return null;
			}
			[Token(Token = "0x600474B")]
			[Address(RVA = "0x2C0BFB0", Offset = "0x2C0C0B1", VA = "0x2C0BFB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9E50", Offset = "0x1A9F51")]
			private set
			{
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600556F RID: 21871 RVA: 0x0001C140 File Offset: 0x0001A340
		// (set) Token: 0x06005570 RID: 21872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008AD")]
		public bool isGrounded
		{
			[Token(Token = "0x600474C")]
			[Address(RVA = "0x2C0BFC0", Offset = "0x2C0C0C1", VA = "0x2C0BFC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9E60", Offset = "0x1A9F61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600474D")]
			[Address(RVA = "0x2C0BFD0", Offset = "0x2C0C0D1", VA = "0x2C0BFD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9E70", Offset = "0x1A9F71")]
			private set
			{
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06005571 RID: 21873 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005572 RID: 21874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008AE")]
		public Transform root
		{
			[Token(Token = "0x600474E")]
			[Address(RVA = "0x2C0BFE0", Offset = "0x2C0C0E1", VA = "0x2C0BFE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9E80", Offset = "0x1A9F81")]
			get
			{
				return null;
			}
			[Token(Token = "0x600474F")]
			[Address(RVA = "0x2C0BFF0", Offset = "0x2C0C0F1", VA = "0x2C0BFF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9E90", Offset = "0x1A9F91")]
			private set
			{
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06005573 RID: 21875 RVA: 0x0001C158 File Offset: 0x0001A358
		// (set) Token: 0x06005574 RID: 21876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008AF")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6004750")]
			[Address(RVA = "0x2C0C000", Offset = "0x2C0C101", VA = "0x2C0C000")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9EA0", Offset = "0x1A9FA1")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6004751")]
			[Address(RVA = "0x2C0C030", Offset = "0x2C0C131", VA = "0x2C0C030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9EB0", Offset = "0x1A9FB1")]
			private set
			{
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06005575 RID: 21877 RVA: 0x0001C170 File Offset: 0x0001A370
		[Token(Token = "0x170008B0")]
		public bool rootGrounded
		{
			[Token(Token = "0x6004752")]
			[Address(RVA = "0x2C0C050", Offset = "0x2C0C151", VA = "0x2C0C050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x0001C188 File Offset: 0x0001A388
		[Token(Token = "0x6004753")]
		[Address(RVA = "0x2C0C0B0", Offset = "0x2C0C1B1", VA = "0x2C0C0B0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
		[Token(Token = "0x6004754")]
		[Address(RVA = "0x2C0C4B0", Offset = "0x2C0C5B1", VA = "0x2C0C4B0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004755")]
		[Address(RVA = "0x2C04FF0", Offset = "0x2C050F1", VA = "0x2C04FF0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004756")]
		[Address(RVA = "0x2C05880", Offset = "0x2C05981", VA = "0x2C05880")]
		public void Update()
		{
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
		[Token(Token = "0x6004757")]
		[Address(RVA = "0x2C079E0", Offset = "0x2C07AE1", VA = "0x2C079E0")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004758")]
		[Address(RVA = "0x2C04AD0", Offset = "0x2C04BD1", VA = "0x2C04AD0")]
		public void Reset()
		{
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004759")]
		[Address(RVA = "0x2C0C7C0", Offset = "0x2C0C8C1", VA = "0x2C0C7C0")]
		public void LogWarning(string message)
		{
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x0600557D RID: 21885 RVA: 0x0001C1D0 File Offset: 0x0001A3D0
		[Token(Token = "0x170008B1")]
		public Vector3 up
		{
			[Token(Token = "0x600475A")]
			[Address(RVA = "0x2C05BD0", Offset = "0x2C05CD1", VA = "0x2C05BD0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x0001C1E8 File Offset: 0x0001A3E8
		[Token(Token = "0x600475B")]
		[Address(RVA = "0x2C0D6D0", Offset = "0x2C0D7D1", VA = "0x2C0D6D0")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return 0f;
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x0001C200 File Offset: 0x0001A400
		[Token(Token = "0x600475C")]
		[Address(RVA = "0x2C0D840", Offset = "0x2C0D941", VA = "0x2C0D840")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06005580 RID: 21888 RVA: 0x0001C218 File Offset: 0x0001A418
		[Token(Token = "0x170008B2")]
		private bool useRootRotation
		{
			[Token(Token = "0x600475D")]
			[Address(RVA = "0x2C0D600", Offset = "0x2C0D701", VA = "0x2C0D600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x0001C230 File Offset: 0x0001A430
		[Token(Token = "0x600475E")]
		[Address(RVA = "0x2C0D950", Offset = "0x2C0DA51", VA = "0x2C0D950")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600475F")]
		[Address(RVA = "0x2C046A0", Offset = "0x2C047A1", VA = "0x2C046A0")]
		public Grounding()
		{
		}

		// Token: 0x0400B4CD RID: 46285
		[Token(Token = "0x40087E5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179280", Offset = "0x179381")]
		public LayerMask layers;

		// Token: 0x0400B4CE RID: 46286
		[Token(Token = "0x40087E6")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1792C0", Offset = "0x1793C1")]
		public float maxStep;

		// Token: 0x0400B4CF RID: 46287
		[Token(Token = "0x40087E7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179300", Offset = "0x179401")]
		public float heightOffset;

		// Token: 0x0400B4D0 RID: 46288
		[Token(Token = "0x40087E8")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179340", Offset = "0x179441")]
		public float footSpeed;

		// Token: 0x0400B4D1 RID: 46289
		[Token(Token = "0x40087E9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179380", Offset = "0x179481")]
		public float footRadius;

		// Token: 0x0400B4D2 RID: 46290
		[Token(Token = "0x40087EA")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1793C0", Offset = "0x1794C1")]
		[Attribute(Name = "HideInInspector", RVA = "0x1793C0", Offset = "0x1794C1")]
		public float footCenterOffset;

		// Token: 0x0400B4D3 RID: 46291
		[Token(Token = "0x40087EB")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179410", Offset = "0x179511")]
		public float prediction;

		// Token: 0x0400B4D4 RID: 46292
		[Token(Token = "0x40087EC")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179450", Offset = "0x179551")]
		[Attribute(Name = "RangeAttribute", RVA = "0x179450", Offset = "0x179551")]
		public float footRotationWeight;

		// Token: 0x0400B4D5 RID: 46293
		[Token(Token = "0x40087ED")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1794B0", Offset = "0x1795B1")]
		public float footRotationSpeed;

		// Token: 0x0400B4D6 RID: 46294
		[Token(Token = "0x40087EE")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1794F0", Offset = "0x1795F1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1794F0", Offset = "0x1795F1")]
		public float maxFootRotationAngle;

		// Token: 0x0400B4D7 RID: 46295
		[Token(Token = "0x40087EF")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179550", Offset = "0x179651")]
		public bool rotateSolver;

		// Token: 0x0400B4D8 RID: 46296
		[Token(Token = "0x40087F0")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179590", Offset = "0x179691")]
		public float pelvisSpeed;

		// Token: 0x0400B4D9 RID: 46297
		[Token(Token = "0x40087F1")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1795D0", Offset = "0x1796D1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1795D0", Offset = "0x1796D1")]
		public float pelvisDamper;

		// Token: 0x0400B4DA RID: 46298
		[Token(Token = "0x40087F2")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179630", Offset = "0x179731")]
		public float lowerPelvisWeight;

		// Token: 0x0400B4DB RID: 46299
		[Token(Token = "0x40087F3")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179670", Offset = "0x179771")]
		public float liftPelvisWeight;

		// Token: 0x0400B4DC RID: 46300
		[Token(Token = "0x40087F4")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1796B0", Offset = "0x1797B1")]
		public float rootSphereCastRadius;

		// Token: 0x0400B4DD RID: 46301
		[Token(Token = "0x40087F5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1796F0", Offset = "0x1797F1")]
		public bool overstepFallsDown;

		// Token: 0x0400B4DE RID: 46302
		[Token(Token = "0x40087F6")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179730", Offset = "0x179831")]
		public Grounding.Quality quality;

		// Token: 0x0400B4DF RID: 46303
		[Token(Token = "0x40087F7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x179770", Offset = "0x179871")]
		private Grounding.Leg[] <legs>k__BackingField;

		// Token: 0x0400B4E0 RID: 46304
		[Token(Token = "0x40087F8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x179780", Offset = "0x179881")]
		private Grounding.Pelvis <pelvis>k__BackingField;

		// Token: 0x0400B4E1 RID: 46305
		[Token(Token = "0x40087F9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x179790", Offset = "0x179891")]
		private bool <isGrounded>k__BackingField;

		// Token: 0x0400B4E2 RID: 46306
		[Token(Token = "0x40087FA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1797A0", Offset = "0x1798A1")]
		private Transform <root>k__BackingField;

		// Token: 0x0400B4E3 RID: 46307
		[Token(Token = "0x40087FB")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1797B0", Offset = "0x1798B1")]
		private RaycastHit <rootHit>k__BackingField;

		// Token: 0x0400B4E4 RID: 46308
		[Token(Token = "0x40087FC")]
		[FieldOffset(Offset = "0xA4")]
		private bool initiated;

		// Token: 0x02000D0E RID: 3342
		[Token(Token = "0x20013EB")]
		[Serializable]
		public enum Quality
		{
			// Token: 0x0400B4E6 RID: 46310
			[Token(Token = "0x401B92D")]
			Fastest,
			// Token: 0x0400B4E7 RID: 46311
			[Token(Token = "0x401B92E")]
			Simple,
			// Token: 0x0400B4E8 RID: 46312
			[Token(Token = "0x401B92F")]
			Best
		}

		// Token: 0x02000D0F RID: 3343
		[Token(Token = "0x20013EC")]
		public class Leg
		{
			// Token: 0x17000AF5 RID: 2805
			// (get) Token: 0x06005583 RID: 21891 RVA: 0x0001C248 File Offset: 0x0001A448
			// (set) Token: 0x06005584 RID: 21892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DFF")]
			public bool isGrounded
			{
				[Token(Token = "0x60078ED")]
				[Address(RVA = "0x2C0DA40", Offset = "0x2C0DB41", VA = "0x2C0DA40")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4AF0", Offset = "0x1B4BF1")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60078EE")]
				[Address(RVA = "0x2C0DA50", Offset = "0x2C0DB51", VA = "0x2C0DA50")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4B00", Offset = "0x1B4C01")]
				private set
				{
				}
			}

			// Token: 0x17000AF6 RID: 2806
			// (get) Token: 0x06005585 RID: 21893 RVA: 0x0001C260 File Offset: 0x0001A460
			// (set) Token: 0x06005586 RID: 21894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E00")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60078EF")]
				[Address(RVA = "0x2C0DA60", Offset = "0x2C0DB61", VA = "0x2C0DA60")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4B10", Offset = "0x1B4C11")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60078F0")]
				[Address(RVA = "0x2C0DA70", Offset = "0x2C0DB71", VA = "0x2C0DA70")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4B20", Offset = "0x1B4C21")]
				private set
				{
				}
			}

			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x06005587 RID: 21895 RVA: 0x0001C278 File Offset: 0x0001A478
			// (set) Token: 0x06005588 RID: 21896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E01")]
			public bool initiated
			{
				[Token(Token = "0x60078F1")]
				[Address(RVA = "0x2C0DA80", Offset = "0x2C0DB81", VA = "0x2C0DA80")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4B30", Offset = "0x1B4C31")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60078F2")]
				[Address(RVA = "0x2C0DA90", Offset = "0x2C0DB91", VA = "0x2C0DA90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4B40", Offset = "0x1B4C41")]
				private set
				{
				}
			}

			// Token: 0x17000AF8 RID: 2808
			// (get) Token: 0x06005589 RID: 21897 RVA: 0x0001C290 File Offset: 0x0001A490
			// (set) Token: 0x0600558A RID: 21898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E02")]
			public float heightFromGround
			{
				[Token(Token = "0x60078F3")]
				[Address(RVA = "0x2C0DAA0", Offset = "0x2C0DBA1", VA = "0x2C0DAA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4B50", Offset = "0x1B4C51")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60078F4")]
				[Address(RVA = "0x2C0DAB0", Offset = "0x2C0DBB1", VA = "0x2C0DAB0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4B60", Offset = "0x1B4C61")]
				private set
				{
				}
			}

			// Token: 0x17000AF9 RID: 2809
			// (get) Token: 0x0600558B RID: 21899 RVA: 0x0001C2A8 File Offset: 0x0001A4A8
			// (set) Token: 0x0600558C RID: 21900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E03")]
			public Vector3 velocity
			{
				[Token(Token = "0x60078F5")]
				[Address(RVA = "0x2C0DAC0", Offset = "0x2C0DBC1", VA = "0x2C0DAC0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4B70", Offset = "0x1B4C71")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60078F6")]
				[Address(RVA = "0x2C0DAD0", Offset = "0x2C0DBD1", VA = "0x2C0DAD0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4B80", Offset = "0x1B4C81")]
				private set
				{
				}
			}

			// Token: 0x17000AFA RID: 2810
			// (get) Token: 0x0600558D RID: 21901 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600558E RID: 21902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E04")]
			public Transform transform
			{
				[Token(Token = "0x60078F7")]
				[Address(RVA = "0x2C0DAE0", Offset = "0x2C0DBE1", VA = "0x2C0DAE0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4B90", Offset = "0x1B4C91")]
				get
				{
					return null;
				}
				[Token(Token = "0x60078F8")]
				[Address(RVA = "0x2C0DAF0", Offset = "0x2C0DBF1", VA = "0x2C0DAF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4BA0", Offset = "0x1B4CA1")]
				private set
				{
				}
			}

			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x0600558F RID: 21903 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
			// (set) Token: 0x06005590 RID: 21904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E05")]
			public float IKOffset
			{
				[Token(Token = "0x60078F9")]
				[Address(RVA = "0x2C0DB00", Offset = "0x2C0DC01", VA = "0x2C0DB00")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4BB0", Offset = "0x1B4CB1")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60078FA")]
				[Address(RVA = "0x2C0DB10", Offset = "0x2C0DC11", VA = "0x2C0DB10")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4BC0", Offset = "0x1B4CC1")]
				private set
				{
				}
			}

			// Token: 0x17000AFC RID: 2812
			// (get) Token: 0x06005591 RID: 21905 RVA: 0x0001C2D8 File Offset: 0x0001A4D8
			// (set) Token: 0x06005592 RID: 21906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E06")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60078FB")]
				[Address(RVA = "0x2C0DB20", Offset = "0x2C0DC21", VA = "0x2C0DB20")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4BD0", Offset = "0x1B4CD1")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60078FC")]
				[Address(RVA = "0x2C0DB50", Offset = "0x2C0DC51", VA = "0x2C0DB50")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4BE0", Offset = "0x1B4CE1")]
				private set
				{
				}
			}

			// Token: 0x17000AFD RID: 2813
			// (get) Token: 0x06005593 RID: 21907 RVA: 0x0001C2F0 File Offset: 0x0001A4F0
			// (set) Token: 0x06005594 RID: 21908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E07")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60078FD")]
				[Address(RVA = "0x2C0DB70", Offset = "0x2C0DC71", VA = "0x2C0DB70")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4BF0", Offset = "0x1B4CF1")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60078FE")]
				[Address(RVA = "0x2C0DBA0", Offset = "0x2C0DCA1", VA = "0x2C0DBA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4C00", Offset = "0x1B4D01")]
				private set
				{
				}
			}

			// Token: 0x17000AFE RID: 2814
			// (get) Token: 0x06005595 RID: 21909 RVA: 0x0001C308 File Offset: 0x0001A508
			[Token(Token = "0x17000E08")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60078FF")]
				[Address(RVA = "0x2C0DBC0", Offset = "0x2C0DCC1", VA = "0x2C0DBC0")]
				get
				{
					return default(RaycastHit);
				}
			}

			// Token: 0x06005596 RID: 21910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007900")]
			[Address(RVA = "0x2C0DC30", Offset = "0x2C0DD31", VA = "0x2C0DC30")]
			public void SetFootPosition(Vector3 position)
			{
			}

			// Token: 0x06005597 RID: 21911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007901")]
			[Address(RVA = "0x2C0C670", Offset = "0x2C0C771", VA = "0x2C0C670")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			// Token: 0x06005598 RID: 21912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007902")]
			[Address(RVA = "0x2C0DC50", Offset = "0x2C0DD51", VA = "0x2C0DC50")]
			public void OnEnable()
			{
			}

			// Token: 0x06005599 RID: 21913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007903")]
			[Address(RVA = "0x2C0D540", Offset = "0x2C0D641", VA = "0x2C0D540")]
			public void Reset()
			{
			}

			// Token: 0x0600559A RID: 21914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007904")]
			[Address(RVA = "0x2C0C7E0", Offset = "0x2C0C8E1", VA = "0x2C0C7E0")]
			public void Process()
			{
			}

			// Token: 0x17000AFF RID: 2815
			// (get) Token: 0x0600559B RID: 21915 RVA: 0x0001C320 File Offset: 0x0001A520
			[Token(Token = "0x17000E09")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6007905")]
				[Address(RVA = "0x2C0E9C0", Offset = "0x2C0EAC1", VA = "0x2C0E9C0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600559C RID: 21916 RVA: 0x0001C338 File Offset: 0x0001A538
			[Token(Token = "0x6007906")]
			[Address(RVA = "0x2C0E460", Offset = "0x2C0E561", VA = "0x2C0E460")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			// Token: 0x0600559D RID: 21917 RVA: 0x0001C350 File Offset: 0x0001A550
			[Token(Token = "0x6007907")]
			[Address(RVA = "0x2C0DCA0", Offset = "0x2C0DDA1", VA = "0x2C0DCA0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			// Token: 0x0600559E RID: 21918 RVA: 0x0001C368 File Offset: 0x0001A568
			[Token(Token = "0x6007908")]
			[Address(RVA = "0x2C0EB50", Offset = "0x2C0EC51", VA = "0x2C0EB50")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			// Token: 0x0600559F RID: 21919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007909")]
			[Address(RVA = "0x2C0E0B0", Offset = "0x2C0E1B1", VA = "0x2C0E0B0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			// Token: 0x060055A0 RID: 21920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600790A")]
			[Address(RVA = "0x2C0E1E0", Offset = "0x2C0E2E1", VA = "0x2C0E1E0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			// Token: 0x060055A1 RID: 21921 RVA: 0x0001C380 File Offset: 0x0001A580
			[Token(Token = "0x600790B")]
			[Address(RVA = "0x2C0EC50", Offset = "0x2C0ED51", VA = "0x2C0EC50")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return 0f;
			}

			// Token: 0x060055A2 RID: 21922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600790C")]
			[Address(RVA = "0x2C0EA50", Offset = "0x2C0EB51", VA = "0x2C0EA50")]
			private void RotateFoot()
			{
			}

			// Token: 0x060055A3 RID: 21923 RVA: 0x0001C398 File Offset: 0x0001A598
			[Token(Token = "0x600790D")]
			[Address(RVA = "0x2C0EDE0", Offset = "0x2C0EEE1", VA = "0x2C0EDE0")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			// Token: 0x17000B00 RID: 2816
			// (get) Token: 0x060055A4 RID: 21924 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
			[Token(Token = "0x17000E0A")]
			private float rootYOffset
			{
				[Token(Token = "0x600790E")]
				[Address(RVA = "0x2C0ECB0", Offset = "0x2C0EDB1", VA = "0x2C0ECB0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060055A5 RID: 21925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600790F")]
			[Address(RVA = "0x2C0C5B0", Offset = "0x2C0C6B1", VA = "0x2C0C5B0")]
			public Leg()
			{
			}

			// Token: 0x0400B4E9 RID: 46313
			[Token(Token = "0x401B930")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BA0", Offset = "0x195CA1")]
			private bool <isGrounded>k__BackingField;

			// Token: 0x0400B4EA RID: 46314
			[Token(Token = "0x401B931")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BB0", Offset = "0x195CB1")]
			private Vector3 <IKPosition>k__BackingField;

			// Token: 0x0400B4EB RID: 46315
			[Token(Token = "0x401B932")]
			[FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			// Token: 0x0400B4EC RID: 46316
			[Token(Token = "0x401B933")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BC0", Offset = "0x195CC1")]
			private bool <initiated>k__BackingField;

			// Token: 0x0400B4ED RID: 46317
			[Token(Token = "0x401B934")]
			[FieldOffset(Offset = "0x34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BD0", Offset = "0x195CD1")]
			private float <heightFromGround>k__BackingField;

			// Token: 0x0400B4EE RID: 46318
			[Token(Token = "0x401B935")]
			[FieldOffset(Offset = "0x38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BE0", Offset = "0x195CE1")]
			private Vector3 <velocity>k__BackingField;

			// Token: 0x0400B4EF RID: 46319
			[Token(Token = "0x401B936")]
			[FieldOffset(Offset = "0x48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BF0", Offset = "0x195CF1")]
			private Transform <transform>k__BackingField;

			// Token: 0x0400B4F0 RID: 46320
			[Token(Token = "0x401B937")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195C00", Offset = "0x195D01")]
			private float <IKOffset>k__BackingField;

			// Token: 0x0400B4F1 RID: 46321
			[Token(Token = "0x401B938")]
			[FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			// Token: 0x0400B4F2 RID: 46322
			[Token(Token = "0x401B939")]
			[FieldOffset(Offset = "0x58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195C10", Offset = "0x195D11")]
			private RaycastHit <heelHit>k__BackingField;

			// Token: 0x0400B4F3 RID: 46323
			[Token(Token = "0x401B93A")]
			[FieldOffset(Offset = "0x84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195C20", Offset = "0x195D21")]
			private RaycastHit <capsuleHit>k__BackingField;

			// Token: 0x0400B4F4 RID: 46324
			[Token(Token = "0x401B93B")]
			[FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			// Token: 0x0400B4F5 RID: 46325
			[Token(Token = "0x401B93C")]
			[FieldOffset(Offset = "0xB8")]
			private float lastTime;

			// Token: 0x0400B4F6 RID: 46326
			[Token(Token = "0x401B93D")]
			[FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			// Token: 0x0400B4F7 RID: 46327
			[Token(Token = "0x401B93E")]
			[FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			// Token: 0x0400B4F8 RID: 46328
			[Token(Token = "0x401B93F")]
			[FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			// Token: 0x0400B4F9 RID: 46329
			[Token(Token = "0x401B940")]
			[FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			// Token: 0x0400B4FA RID: 46330
			[Token(Token = "0x401B941")]
			[FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			// Token: 0x0400B4FB RID: 46331
			[Token(Token = "0x401B942")]
			[FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			// Token: 0x0400B4FC RID: 46332
			[Token(Token = "0x401B943")]
			[FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			// Token: 0x0400B4FD RID: 46333
			[Token(Token = "0x401B944")]
			[FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;
		}

		// Token: 0x02000D10 RID: 3344
		[Token(Token = "0x20013ED")]
		public class Pelvis
		{
			// Token: 0x17000B01 RID: 2817
			// (get) Token: 0x060055A6 RID: 21926 RVA: 0x0001C3C8 File Offset: 0x0001A5C8
			// (set) Token: 0x060055A7 RID: 21927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E0B")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6007910")]
				[Address(RVA = "0x2C0EEF0", Offset = "0x2C0EFF1", VA = "0x2C0EEF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4C10", Offset = "0x1B4D11")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6007911")]
				[Address(RVA = "0x2C0EF00", Offset = "0x2C0F001", VA = "0x2C0EF00")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4C20", Offset = "0x1B4D21")]
				private set
				{
				}
			}

			// Token: 0x17000B02 RID: 2818
			// (get) Token: 0x060055A8 RID: 21928 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
			// (set) Token: 0x060055A9 RID: 21929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E0C")]
			public float heightOffset
			{
				[Token(Token = "0x6007912")]
				[Address(RVA = "0x2C0EF10", Offset = "0x2C0F011", VA = "0x2C0EF10")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4C30", Offset = "0x1B4D31")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6007913")]
				[Address(RVA = "0x2C0EF20", Offset = "0x2C0F021", VA = "0x2C0EF20")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4C40", Offset = "0x1B4D41")]
				private set
				{
				}
			}

			// Token: 0x060055AA RID: 21930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007914")]
			[Address(RVA = "0x2C0C790", Offset = "0x2C0C891", VA = "0x2C0C790")]
			public void Initiate(Grounding grounding)
			{
			}

			// Token: 0x060055AB RID: 21931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007915")]
			[Address(RVA = "0x2C0D490", Offset = "0x2C0D591", VA = "0x2C0D490")]
			public void Reset()
			{
			}

			// Token: 0x060055AC RID: 21932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007916")]
			[Address(RVA = "0x2C0EF30", Offset = "0x2C0F031", VA = "0x2C0EF30")]
			public void OnEnable()
			{
			}

			// Token: 0x060055AD RID: 21933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007917")]
			[Address(RVA = "0x2C0D210", Offset = "0x2C0D311", VA = "0x2C0D210")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			// Token: 0x060055AE RID: 21934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007918")]
			[Address(RVA = "0x2C0C660", Offset = "0x2C0C761", VA = "0x2C0C660")]
			public Pelvis()
			{
			}

			// Token: 0x0400B4FE RID: 46334
			[Token(Token = "0x401B945")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195C30", Offset = "0x195D31")]
			private Vector3 <IKOffset>k__BackingField;

			// Token: 0x0400B4FF RID: 46335
			[Token(Token = "0x401B946")]
			[FieldOffset(Offset = "0x1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195C40", Offset = "0x195D41")]
			private float <heightOffset>k__BackingField;

			// Token: 0x0400B500 RID: 46336
			[Token(Token = "0x401B947")]
			[FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			// Token: 0x0400B501 RID: 46337
			[Token(Token = "0x401B948")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			// Token: 0x0400B502 RID: 46338
			[Token(Token = "0x401B949")]
			[FieldOffset(Offset = "0x34")]
			private float damperF;

			// Token: 0x0400B503 RID: 46339
			[Token(Token = "0x401B94A")]
			[FieldOffset(Offset = "0x38")]
			private bool initiated;

			// Token: 0x0400B504 RID: 46340
			[Token(Token = "0x401B94B")]
			[FieldOffset(Offset = "0x3C")]
			private float lastTime;
		}
	}
}
