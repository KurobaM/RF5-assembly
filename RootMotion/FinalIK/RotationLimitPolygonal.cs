using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D76 RID: 3446
	[Token(Token = "0x20008D7")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148850", Offset = "0x148951")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148850", Offset = "0x148951")]
	public class RotationLimitPolygonal : RotationLimit
	{
		// Token: 0x0600597D RID: 22909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x27CC140", Offset = "0x27CC241", VA = "0x27CC140")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB6F0", Offset = "0x1AB7F1")]
		private void OpenUserManual()
		{
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x27CC190", Offset = "0x27CC291", VA = "0x27CC190")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB730", Offset = "0x1AB831")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x27CC1E0", Offset = "0x27CC2E1", VA = "0x27CC1E0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB770", Offset = "0x1AB871")]
		private void SupportGroup()
		{
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x27CC230", Offset = "0x27CC331", VA = "0x27CC230")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB7B0", Offset = "0x1AB8B1")]
		private void ASThread()
		{
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x27CC280", Offset = "0x27CC381", VA = "0x27CC280")]
		public void SetLimitPoints(RotationLimitPolygonal.LimitPoint[] points)
		{
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x0001D718 File Offset: 0x0001B918
		[Token(Token = "0x6004A38")]
		[Address(RVA = "0x27CC7C0", Offset = "0x27CC8C1", VA = "0x27CC7C0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A39")]
		[Address(RVA = "0x27CC8C0", Offset = "0x27CC9C1", VA = "0x27CC8C0")]
		private void Start()
		{
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3A")]
		[Address(RVA = "0x27CCED0", Offset = "0x27CCFD1", VA = "0x27CCED0")]
		public void ResetToDefault()
		{
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3B")]
		[Address(RVA = "0x27CC320", Offset = "0x27CC421", VA = "0x27CC320")]
		public void BuildReachCones()
		{
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A3C")]
		[Address(RVA = "0x27CD3C0", Offset = "0x27CD4C1", VA = "0x27CD3C0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x0001D730 File Offset: 0x0001B930
		[Token(Token = "0x6004A3D")]
		[Address(RVA = "0x27CDCB0", Offset = "0x27CDDB1", VA = "0x27CDCB0")]
		private float GetScalar(int k)
		{
			return 0f;
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x0001D748 File Offset: 0x0001B948
		[Token(Token = "0x6004A3E")]
		[Address(RVA = "0x27CDD00", Offset = "0x27CDE01", VA = "0x27CDD00")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x0001D760 File Offset: 0x0001B960
		[Token(Token = "0x6004A3F")]
		[Address(RVA = "0x27CDE50", Offset = "0x27CDF51", VA = "0x27CDE50")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x0001D778 File Offset: 0x0001B978
		[Token(Token = "0x6004A40")]
		[Address(RVA = "0x27CCBA0", Offset = "0x27CCCA1", VA = "0x27CCBA0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x0001D790 File Offset: 0x0001B990
		[Token(Token = "0x6004A41")]
		[Address(RVA = "0x27CDFE0", Offset = "0x27CE0E1", VA = "0x27CDFE0")]
		private int GetReachCone(Vector3 L)
		{
			return 0;
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A42")]
		[Address(RVA = "0x27CE1B0", Offset = "0x27CE2B1", VA = "0x27CE1B0")]
		public RotationLimitPolygonal()
		{
		}

		// Token: 0x0400B8AC RID: 47276
		[Token(Token = "0x4008A42")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17B9F0", Offset = "0x17BAF1")]
		public float twistLimit;

		// Token: 0x0400B8AD RID: 47277
		[Token(Token = "0x4008A43")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17BA10", Offset = "0x17BB11")]
		public int smoothIterations;

		// Token: 0x0400B8AE RID: 47278
		[Token(Token = "0x4008A44")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x17BA30", Offset = "0x17BB31")]
		public RotationLimitPolygonal.LimitPoint[] points;

		// Token: 0x0400B8AF RID: 47279
		[Token(Token = "0x4008A45")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x17BA70", Offset = "0x17BB71")]
		public Vector3[] P;

		// Token: 0x0400B8B0 RID: 47280
		[Token(Token = "0x4008A46")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x17BAB0", Offset = "0x17BBB1")]
		public RotationLimitPolygonal.ReachCone[] reachCones;

		// Token: 0x02000D77 RID: 3447
		[Token(Token = "0x2001415")]
		[Serializable]
		public class ReachCone
		{
			// Token: 0x17000B6D RID: 2925
			// (get) Token: 0x0600598D RID: 22925 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
			[Token(Token = "0x17000E39")]
			public Vector3 o
			{
				[Token(Token = "0x6007A13")]
				[Address(RVA = "0x27CE280", Offset = "0x27CE381", VA = "0x27CE280")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000B6E RID: 2926
			// (get) Token: 0x0600598E RID: 22926 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
			[Token(Token = "0x17000E3A")]
			public Vector3 a
			{
				[Token(Token = "0x6007A14")]
				[Address(RVA = "0x27CE2C0", Offset = "0x27CE3C1", VA = "0x27CE2C0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000B6F RID: 2927
			// (get) Token: 0x0600598F RID: 22927 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
			[Token(Token = "0x17000E3B")]
			public Vector3 b
			{
				[Token(Token = "0x6007A15")]
				[Address(RVA = "0x27CE300", Offset = "0x27CE401", VA = "0x27CE300")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000B70 RID: 2928
			// (get) Token: 0x06005990 RID: 22928 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
			[Token(Token = "0x17000E3C")]
			public Vector3 c
			{
				[Token(Token = "0x6007A16")]
				[Address(RVA = "0x27CE340", Offset = "0x27CE441", VA = "0x27CE340")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06005991 RID: 22929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A17")]
			[Address(RVA = "0x27CD980", Offset = "0x27CDA81", VA = "0x27CD980")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			// Token: 0x17000B71 RID: 2929
			// (get) Token: 0x06005992 RID: 22930 RVA: 0x0001D808 File Offset: 0x0001BA08
			[Token(Token = "0x17000E3D")]
			public bool isValid
			{
				[Token(Token = "0x6007A18")]
				[Address(RVA = "0x27CD320", Offset = "0x27CD421", VA = "0x27CD320")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005993 RID: 22931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A19")]
			[Address(RVA = "0x27CDB00", Offset = "0x27CDC01", VA = "0x27CDB00")]
			public void Calculate()
			{
			}

			// Token: 0x0400B8B1 RID: 47281
			[Token(Token = "0x401BA9C")]
			[FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			// Token: 0x0400B8B2 RID: 47282
			[Token(Token = "0x401BA9D")]
			[FieldOffset(Offset = "0x18")]
			public float volume;

			// Token: 0x0400B8B3 RID: 47283
			[Token(Token = "0x401BA9E")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			// Token: 0x0400B8B4 RID: 47284
			[Token(Token = "0x401BA9F")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 B;
		}

		// Token: 0x02000D78 RID: 3448
		[Token(Token = "0x2001416")]
		[Serializable]
		public class LimitPoint
		{
			// Token: 0x06005994 RID: 22932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A1A")]
			[Address(RVA = "0x27CD330", Offset = "0x27CD431", VA = "0x27CD330")]
			public LimitPoint()
			{
			}

			// Token: 0x0400B8B5 RID: 47285
			[Token(Token = "0x401BAA0")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 point;

			// Token: 0x0400B8B6 RID: 47286
			[Token(Token = "0x401BAA1")]
			[FieldOffset(Offset = "0x1C")]
			public float tangentWeight;
		}
	}
}
