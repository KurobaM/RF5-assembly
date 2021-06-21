using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace XftWeapon
{
	// Token: 0x02000BC4 RID: 3012
	[Token(Token = "0x20007D4")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x1475C0", Offset = "0x1476C1")]
	public class Spline
	{
		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06004CEB RID: 19691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EE")]
		public SplineControlPoint Item
		{
			[Token(Token = "0x6004082")]
			[Address(RVA = "0x1E57560", Offset = "0x1E57661", VA = "0x1E57560")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06004CEC RID: 19692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EF")]
		public List<SplineControlPoint> Segments
		{
			[Token(Token = "0x6004083")]
			[Address(RVA = "0x1E57610", Offset = "0x1E57711", VA = "0x1E57610")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06004CED RID: 19693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F0")]
		public List<SplineControlPoint> ControlPoints
		{
			[Token(Token = "0x6004084")]
			[Address(RVA = "0x1E57620", Offset = "0x1E57721", VA = "0x1E57620")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004085")]
		[Address(RVA = "0x1E57630", Offset = "0x1E57731", VA = "0x1E57630")]
		public SplineControlPoint NextControlPoint(SplineControlPoint controlpoint)
		{
			return null;
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004086")]
		[Address(RVA = "0x1E576F0", Offset = "0x1E577F1", VA = "0x1E576F0")]
		public SplineControlPoint PreviousControlPoint(SplineControlPoint controlpoint)
		{
			return null;
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x000186C0 File Offset: 0x000168C0
		[Token(Token = "0x6004087")]
		[Address(RVA = "0x1E577B0", Offset = "0x1E578B1", VA = "0x1E577B0")]
		public Vector3 NextPosition(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x000186D8 File Offset: 0x000168D8
		[Token(Token = "0x6004088")]
		[Address(RVA = "0x1E57860", Offset = "0x1E57961", VA = "0x1E57860")]
		public Vector3 PreviousPosition(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x000186F0 File Offset: 0x000168F0
		[Token(Token = "0x6004089")]
		[Address(RVA = "0x1E57910", Offset = "0x1E57A11", VA = "0x1E57910")]
		public Vector3 PreviousNormal(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x00018708 File Offset: 0x00016908
		[Token(Token = "0x600408A")]
		[Address(RVA = "0x1E579C0", Offset = "0x1E57AC1", VA = "0x1E579C0")]
		public Vector3 NextNormal(SplineControlPoint controlpoint)
		{
			return default(Vector3);
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600408B")]
		[Address(RVA = "0x1E57A70", Offset = "0x1E57B71", VA = "0x1E57A70")]
		public SplineControlPoint LenToSegment(float t, out float localF)
		{
			return null;
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x00018720 File Offset: 0x00016920
		[Token(Token = "0x600408C")]
		[Address(RVA = "0x1E57C30", Offset = "0x1E57D31", VA = "0x1E57C30")]
		public static Vector3 CatmulRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x00018738 File Offset: 0x00016938
		[Token(Token = "0x600408D")]
		[Address(RVA = "0x1E57DC0", Offset = "0x1E57EC1", VA = "0x1E57DC0")]
		public Vector3 InterpolateByLen(float tl)
		{
			return default(Vector3);
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x00018750 File Offset: 0x00016950
		[Token(Token = "0x600408E")]
		[Address(RVA = "0x1E57FD0", Offset = "0x1E580D1", VA = "0x1E57FD0")]
		public Vector3 InterpolateNormalByLen(float tl)
		{
			return default(Vector3);
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600408F")]
		[Address(RVA = "0x1E581E0", Offset = "0x1E582E1", VA = "0x1E581E0")]
		public SplineControlPoint AddControlPoint(Vector3 pos, Vector3 up)
		{
			return null;
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004090")]
		[Address(RVA = "0x1E58320", Offset = "0x1E58421", VA = "0x1E58320")]
		public void Clear()
		{
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004091")]
		[Address(RVA = "0x1E58380", Offset = "0x1E58481", VA = "0x1E58380")]
		private void RefreshDistance()
		{
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004092")]
		[Address(RVA = "0x1E58580", Offset = "0x1E58681", VA = "0x1E58580")]
		public void RefreshSpline()
		{
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004093")]
		[Address(RVA = "0x1E587F0", Offset = "0x1E588F1", VA = "0x1E587F0")]
		public Spline()
		{
		}

		// Token: 0x0400AE84 RID: 44676
		[Token(Token = "0x40083A1")]
		[FieldOffset(Offset = "0x10")]
		private List<SplineControlPoint> mControlPoints;

		// Token: 0x0400AE85 RID: 44677
		[Token(Token = "0x40083A2")]
		[FieldOffset(Offset = "0x18")]
		private List<SplineControlPoint> mSegments;

		// Token: 0x0400AE86 RID: 44678
		[Token(Token = "0x40083A3")]
		[FieldOffset(Offset = "0x20")]
		public int Granularity;
	}
}
