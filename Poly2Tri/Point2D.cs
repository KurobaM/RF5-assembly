using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C82 RID: 3202
	[Token(Token = "0x200082F")]
	public class Point2D : IComparable<Point2D>
	{
		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06005203 RID: 20995 RVA: 0x0001AA48 File Offset: 0x00018C48
		// (set) Token: 0x06005204 RID: 20996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000873")]
		public virtual double X
		{
			[Token(Token = "0x6004424")]
			[Address(RVA = "0x27F04C0", Offset = "0x27F05C1", VA = "0x27F04C0", Slot = "5")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6004425")]
			[Address(RVA = "0x27F04D0", Offset = "0x27F05D1", VA = "0x27F04D0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06005205 RID: 20997 RVA: 0x0001AA60 File Offset: 0x00018C60
		// (set) Token: 0x06005206 RID: 20998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000874")]
		public virtual double Y
		{
			[Token(Token = "0x6004426")]
			[Address(RVA = "0x27F04E0", Offset = "0x27F05E1", VA = "0x27F04E0", Slot = "7")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6004427")]
			[Address(RVA = "0x27F04F0", Offset = "0x27F05F1", VA = "0x27F04F0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06005207 RID: 20999 RVA: 0x0001AA78 File Offset: 0x00018C78
		[Token(Token = "0x17000875")]
		public float Xf
		{
			[Token(Token = "0x6004428")]
			[Address(RVA = "0x27F0500", Offset = "0x27F0601", VA = "0x27F0500")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06005208 RID: 21000 RVA: 0x0001AA90 File Offset: 0x00018C90
		[Token(Token = "0x17000876")]
		public float Yf
		{
			[Token(Token = "0x6004429")]
			[Address(RVA = "0x27F0520", Offset = "0x27F0621", VA = "0x27F0520")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442A")]
		[Address(RVA = "0x27F0540", Offset = "0x27F0641", VA = "0x27F0540")]
		public Point2D()
		{
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442B")]
		[Address(RVA = "0x27F0570", Offset = "0x27F0671", VA = "0x27F0570")]
		public Point2D(double x, double y)
		{
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442C")]
		[Address(RVA = "0x27F05B0", Offset = "0x27F06B1", VA = "0x27F05B0")]
		public Point2D(Point2D p)
		{
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600442D")]
		[Address(RVA = "0x27F0610", Offset = "0x27F0711", VA = "0x27F0610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x0001AAA8 File Offset: 0x00018CA8
		[Token(Token = "0x600442E")]
		[Address(RVA = "0x27F0840", Offset = "0x27F0941", VA = "0x27F0840", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		[Token(Token = "0x600442F")]
		[Address(RVA = "0x27F0850", Offset = "0x27F0951", VA = "0x27F0850", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		[Token(Token = "0x6004430")]
		[Address(RVA = "0x27F0900", Offset = "0x27F0A01", VA = "0x27F0900")]
		public bool Equals(Point2D p)
		{
			return default(bool);
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x0001AAF0 File Offset: 0x00018CF0
		[Token(Token = "0x6004431")]
		[Address(RVA = "0x27F0910", Offset = "0x27F0A11", VA = "0x27F0910")]
		public bool Equals(Point2D p, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x0001AB08 File Offset: 0x00018D08
		[Token(Token = "0x6004432")]
		[Address(RVA = "0x27F0A40", Offset = "0x27F0B41", VA = "0x27F0A40", Slot = "4")]
		public int CompareTo(Point2D other)
		{
			return 0;
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004433")]
		[Address(RVA = "0x27F0B60", Offset = "0x27F0C61", VA = "0x27F0B60", Slot = "9")]
		public virtual void Set(double x, double y)
		{
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004434")]
		[Address(RVA = "0x27F0BB0", Offset = "0x27F0CB1", VA = "0x27F0BB0", Slot = "10")]
		public virtual void Set(Point2D p)
		{
		}

		// Token: 0x06005214 RID: 21012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004435")]
		[Address(RVA = "0x27F0C20", Offset = "0x27F0D21", VA = "0x27F0C20")]
		public void Add(Point2D p)
		{
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004436")]
		[Address(RVA = "0x27F0CC0", Offset = "0x27F0DC1", VA = "0x27F0CC0")]
		public void Add(double scalar)
		{
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004437")]
		[Address(RVA = "0x27F0D30", Offset = "0x27F0E31", VA = "0x27F0D30")]
		public void Subtract(Point2D p)
		{
		}

		// Token: 0x06005217 RID: 21015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004438")]
		[Address(RVA = "0x27F0DD0", Offset = "0x27F0ED1", VA = "0x27F0DD0")]
		public void Subtract(double scalar)
		{
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004439")]
		[Address(RVA = "0x27F0E40", Offset = "0x27F0F41", VA = "0x27F0E40")]
		public void Multiply(Point2D p)
		{
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443A")]
		[Address(RVA = "0x27F0EE0", Offset = "0x27F0FE1", VA = "0x27F0EE0")]
		public void Multiply(double scalar)
		{
		}

		// Token: 0x0600521A RID: 21018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443B")]
		[Address(RVA = "0x27F0F50", Offset = "0x27F1051", VA = "0x27F0F50")]
		public void Divide(Point2D p)
		{
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443C")]
		[Address(RVA = "0x27F0FF0", Offset = "0x27F10F1", VA = "0x27F0FF0")]
		public void Divide(double scalar)
		{
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600443D")]
		[Address(RVA = "0x27F1060", Offset = "0x27F1161", VA = "0x27F1060")]
		public void Negate()
		{
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x0001AB20 File Offset: 0x00018D20
		[Token(Token = "0x600443E")]
		[Address(RVA = "0x27F10C0", Offset = "0x27F11C1", VA = "0x27F10C0")]
		public double Magnitude()
		{
			return 0.0;
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x0001AB38 File Offset: 0x00018D38
		[Token(Token = "0x600443F")]
		[Address(RVA = "0x27F11B0", Offset = "0x27F12B1", VA = "0x27F11B0")]
		public double MagnitudeSquared()
		{
			return 0.0;
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x0001AB50 File Offset: 0x00018D50
		[Token(Token = "0x6004440")]
		[Address(RVA = "0x27F1230", Offset = "0x27F1331", VA = "0x27F1230")]
		public double MagnitudeReciprocal()
		{
			return 0.0;
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004441")]
		[Address(RVA = "0x27F1320", Offset = "0x27F1421", VA = "0x27F1320")]
		public void Normalize()
		{
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x0001AB68 File Offset: 0x00018D68
		[Token(Token = "0x6004442")]
		[Address(RVA = "0x27F1450", Offset = "0x27F1551", VA = "0x27F1450")]
		public double Dot(Point2D p)
		{
			return 0.0;
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x0001AB80 File Offset: 0x00018D80
		[Token(Token = "0x6004443")]
		[Address(RVA = "0x27F14E0", Offset = "0x27F15E1", VA = "0x27F14E0")]
		public double Cross(Point2D p)
		{
			return 0.0;
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004444")]
		[Address(RVA = "0x27F1570", Offset = "0x27F1671", VA = "0x27F1570")]
		public void Clamp(Point2D low, Point2D high)
		{
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004445")]
		[Address(RVA = "0x27F16D0", Offset = "0x27F17D1", VA = "0x27F16D0")]
		public void Abs()
		{
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004446")]
		[Address(RVA = "0x27F1780", Offset = "0x27F1881", VA = "0x27F1780")]
		public void Reciprocal()
		{
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004447")]
		[Address(RVA = "0x27F1830", Offset = "0x27F1931", VA = "0x27F1830")]
		public void Translate(Point2D vector)
		{
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004448")]
		[Address(RVA = "0x27F18D0", Offset = "0x27F19D1", VA = "0x27F18D0")]
		public void Translate(double x, double y)
		{
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004449")]
		[Address(RVA = "0x27F1940", Offset = "0x27F1A41", VA = "0x27F1940")]
		public void Scale(Point2D vector)
		{
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444A")]
		[Address(RVA = "0x27F19E0", Offset = "0x27F1AE1", VA = "0x27F19E0")]
		public void Scale(double scalar)
		{
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444B")]
		[Address(RVA = "0x27F1A50", Offset = "0x27F1B51", VA = "0x27F1A50")]
		public void Scale(double x, double y)
		{
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444C")]
		[Address(RVA = "0x27F1AC0", Offset = "0x27F1BC1", VA = "0x27F1AC0")]
		public void Rotate(double radians)
		{
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444D")]
		[Address(RVA = "0x27F1BB0", Offset = "0x27F1CB1", VA = "0x27F1BB0")]
		public void RotateDegrees(double degrees)
		{
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x0001AB98 File Offset: 0x00018D98
		[Token(Token = "0x600444E")]
		[Address(RVA = "0x27F1BD0", Offset = "0x27F1CD1", VA = "0x27F1BD0")]
		public static double Dot(Point2D lhs, Point2D rhs)
		{
			return 0.0;
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		[Token(Token = "0x600444F")]
		[Address(RVA = "0x27F1C60", Offset = "0x27F1D61", VA = "0x27F1C60")]
		public static double Cross(Point2D lhs, Point2D rhs)
		{
			return 0.0;
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004450")]
		[Address(RVA = "0x27F1CF0", Offset = "0x27F1DF1", VA = "0x27F1CF0")]
		public static Point2D Clamp(Point2D a, Point2D low, Point2D high)
		{
			return null;
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004451")]
		[Address(RVA = "0x27F1DB0", Offset = "0x27F1EB1", VA = "0x27F1DB0")]
		public static Point2D Min(Point2D a, Point2D b)
		{
			return null;
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004452")]
		[Address(RVA = "0x27F1EF0", Offset = "0x27F1FF1", VA = "0x27F1EF0")]
		public static Point2D Max(Point2D a, Point2D b)
		{
			return null;
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004453")]
		[Address(RVA = "0x27F2030", Offset = "0x27F2131", VA = "0x27F2030")]
		public static Point2D Abs(Point2D a)
		{
			return null;
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004454")]
		[Address(RVA = "0x27F20F0", Offset = "0x27F21F1", VA = "0x27F20F0")]
		public static Point2D Reciprocal(Point2D a)
		{
			return null;
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004455")]
		[Address(RVA = "0x27F21A0", Offset = "0x27F22A1", VA = "0x27F21A0")]
		public static Point2D Perpendicular(Point2D lhs, double scalar)
		{
			return null;
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004456")]
		[Address(RVA = "0x27F2250", Offset = "0x27F2351", VA = "0x27F2250")]
		public static Point2D Perpendicular(double scalar, Point2D rhs)
		{
			return null;
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004457")]
		[Address(RVA = "0x27F2300", Offset = "0x27F2401", VA = "0x27F2300")]
		public static Point2D operator +(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004458")]
		[Address(RVA = "0x27F2420", Offset = "0x27F2521", VA = "0x27F2420")]
		public static Point2D operator +(Point2D lhs, double scalar)
		{
			return null;
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004459")]
		[Address(RVA = "0x27F2510", Offset = "0x27F2611", VA = "0x27F2510")]
		public static Point2D operator -(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445A")]
		[Address(RVA = "0x27F2630", Offset = "0x27F2731", VA = "0x27F2630")]
		public static Point2D operator -(Point2D lhs, double scalar)
		{
			return null;
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445B")]
		[Address(RVA = "0x27F2720", Offset = "0x27F2821", VA = "0x27F2720")]
		public static Point2D operator *(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445C")]
		[Address(RVA = "0x27F2840", Offset = "0x27F2941", VA = "0x27F2840")]
		public static Point2D operator *(Point2D lhs, double scalar)
		{
			return null;
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445D")]
		[Address(RVA = "0x27F2930", Offset = "0x27F2A31", VA = "0x27F2930")]
		public static Point2D operator *(double scalar, Point2D lhs)
		{
			return null;
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445E")]
		[Address(RVA = "0x27F2A20", Offset = "0x27F2B21", VA = "0x27F2A20")]
		public static Point2D operator /(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445F")]
		[Address(RVA = "0x27F2B40", Offset = "0x27F2C41", VA = "0x27F2B40")]
		public static Point2D operator /(Point2D lhs, double scalar)
		{
			return null;
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004460")]
		[Address(RVA = "0x27F2C30", Offset = "0x27F2D31", VA = "0x27F2C30")]
		public static Point2D operator -(Point2D p)
		{
			return null;
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		[Token(Token = "0x6004461")]
		[Address(RVA = "0x27F2D10", Offset = "0x27F2E11", VA = "0x27F2D10")]
		public static bool operator <(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		[Token(Token = "0x6004462")]
		[Address(RVA = "0x27F2D40", Offset = "0x27F2E41", VA = "0x27F2D40")]
		public static bool operator >(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		[Token(Token = "0x6004463")]
		[Address(RVA = "0x27F2D70", Offset = "0x27F2E71", VA = "0x27F2D70")]
		public static bool operator <=(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x0001AC10 File Offset: 0x00018E10
		[Token(Token = "0x6004464")]
		[Address(RVA = "0x27F2DA0", Offset = "0x27F2EA1", VA = "0x27F2DA0")]
		public static bool operator >=(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}

		// Token: 0x0400B157 RID: 45399
		[Token(Token = "0x4008501")]
		[FieldOffset(Offset = "0x10")]
		protected double mX;

		// Token: 0x0400B158 RID: 45400
		[Token(Token = "0x4008502")]
		[FieldOffset(Offset = "0x18")]
		protected double mY;
	}
}
