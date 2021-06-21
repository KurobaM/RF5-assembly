using System;
using Il2CppDummyDll;
using UnityEngine;

namespace XftWeapon
{
	// Token: 0x02000BC5 RID: 3013
	[Token(Token = "0x20007D5")]
	public class SplineControlPoint
	{
		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06004CFD RID: 19709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F1")]
		public SplineControlPoint NextControlPoint
		{
			[Token(Token = "0x6004094")]
			[Address(RVA = "0x1E588A0", Offset = "0x1E589A1", VA = "0x1E588A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06004CFE RID: 19710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F2")]
		public SplineControlPoint PreviousControlPoint
		{
			[Token(Token = "0x6004095")]
			[Address(RVA = "0x1E58960", Offset = "0x1E58A61", VA = "0x1E58960")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06004CFF RID: 19711 RVA: 0x00018768 File Offset: 0x00016968
		[Token(Token = "0x170007F3")]
		public Vector3 NextPosition
		{
			[Token(Token = "0x6004096")]
			[Address(RVA = "0x1E58A20", Offset = "0x1E58B21", VA = "0x1E58A20")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06004D00 RID: 19712 RVA: 0x00018780 File Offset: 0x00016980
		[Token(Token = "0x170007F4")]
		public Vector3 PreviousPosition
		{
			[Token(Token = "0x6004097")]
			[Address(RVA = "0x1E58A40", Offset = "0x1E58B41", VA = "0x1E58A40")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06004D01 RID: 19713 RVA: 0x00018798 File Offset: 0x00016998
		[Token(Token = "0x170007F5")]
		public Vector3 NextNormal
		{
			[Token(Token = "0x6004098")]
			[Address(RVA = "0x1E58A60", Offset = "0x1E58B61", VA = "0x1E58A60")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06004D02 RID: 19714 RVA: 0x000187B0 File Offset: 0x000169B0
		[Token(Token = "0x170007F6")]
		public Vector3 PreviousNormal
		{
			[Token(Token = "0x6004099")]
			[Address(RVA = "0x1E58A80", Offset = "0x1E58B81", VA = "0x1E58A80")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06004D03 RID: 19715 RVA: 0x000187C8 File Offset: 0x000169C8
		[Token(Token = "0x170007F7")]
		public bool IsValid
		{
			[Token(Token = "0x600409A")]
			[Address(RVA = "0x1E58730", Offset = "0x1E58831", VA = "0x1E58730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x000187E0 File Offset: 0x000169E0
		[Token(Token = "0x600409B")]
		[Address(RVA = "0x1E58AA0", Offset = "0x1E58BA1", VA = "0x1E58AA0")]
		private Vector3 GetNext2Position()
		{
			return default(Vector3);
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x000187F8 File Offset: 0x000169F8
		[Token(Token = "0x600409C")]
		[Address(RVA = "0x1E58C20", Offset = "0x1E58D21", VA = "0x1E58C20")]
		private Vector3 GetNext2Normal()
		{
			return default(Vector3);
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x00018810 File Offset: 0x00016A10
		[Token(Token = "0x600409D")]
		[Address(RVA = "0x1E57DF0", Offset = "0x1E57EF1", VA = "0x1E57DF0")]
		public Vector3 Interpolate(float localF)
		{
			return default(Vector3);
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x00018828 File Offset: 0x00016A28
		[Token(Token = "0x600409E")]
		[Address(RVA = "0x1E58000", Offset = "0x1E58101", VA = "0x1E58000")]
		public Vector3 InterpolateNormal(float localF)
		{
			return default(Vector3);
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409F")]
		[Address(RVA = "0x1E582F0", Offset = "0x1E583F1", VA = "0x1E582F0")]
		public void Init(Spline owner)
		{
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A0")]
		[Address(RVA = "0x1E582E0", Offset = "0x1E583E1", VA = "0x1E582E0")]
		public SplineControlPoint()
		{
		}

		// Token: 0x0400AE87 RID: 44679
		[Token(Token = "0x40083A4")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		// Token: 0x0400AE88 RID: 44680
		[Token(Token = "0x40083A5")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 Normal;

		// Token: 0x0400AE89 RID: 44681
		[Token(Token = "0x40083A6")]
		[FieldOffset(Offset = "0x28")]
		public int ControlPointIndex;

		// Token: 0x0400AE8A RID: 44682
		[Token(Token = "0x40083A7")]
		[FieldOffset(Offset = "0x2C")]
		public int SegmentIndex;

		// Token: 0x0400AE8B RID: 44683
		[Token(Token = "0x40083A8")]
		[FieldOffset(Offset = "0x30")]
		public float Dist;

		// Token: 0x0400AE8C RID: 44684
		[Token(Token = "0x40083A9")]
		[FieldOffset(Offset = "0x38")]
		protected Spline mSpline;
	}
}
