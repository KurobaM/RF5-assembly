using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C67 RID: 3175
	[Token(Token = "0x2000818")]
	public class PolygonPoint : TriangulationPoint
	{
		// Token: 0x06005101 RID: 20737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004332")]
		[Address(RVA = "0x27FCB90", Offset = "0x27FCC91", VA = "0x27FCB90")]
		public PolygonPoint(double x, double y)
		{
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06005102 RID: 20738 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005103 RID: 20739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000843")]
		public PolygonPoint Next
		{
			[Token(Token = "0x6004333")]
			[Address(RVA = "0x27FE580", Offset = "0x27FE681", VA = "0x27FE580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9320", Offset = "0x1A9421")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004334")]
			[Address(RVA = "0x27FE590", Offset = "0x27FE691", VA = "0x27FE590")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9330", Offset = "0x1A9431")]
			set
			{
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06005104 RID: 20740 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005105 RID: 20741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000844")]
		public PolygonPoint Previous
		{
			[Token(Token = "0x6004335")]
			[Address(RVA = "0x27FE5A0", Offset = "0x27FE6A1", VA = "0x27FE5A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9340", Offset = "0x1A9441")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004336")]
			[Address(RVA = "0x27FE5B0", Offset = "0x27FE6B1", VA = "0x27FE5B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9350", Offset = "0x1A9451")]
			set
			{
			}
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004337")]
		[Address(RVA = "0x27FE5C0", Offset = "0x27FE6C1", VA = "0x27FE5C0")]
		public static Point2D ToBasePoint(PolygonPoint p)
		{
			return null;
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004338")]
		[Address(RVA = "0x27FE5D0", Offset = "0x27FE6D1", VA = "0x27FE5D0")]
		public static TriangulationPoint ToTriangulationPoint(PolygonPoint p)
		{
			return null;
		}

		// Token: 0x0400B105 RID: 45317
		[Token(Token = "0x40084C5")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177200", Offset = "0x177301")]
		private PolygonPoint <Next>k__BackingField;

		// Token: 0x0400B106 RID: 45318
		[Token(Token = "0x40084C6")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177210", Offset = "0x177311")]
		private PolygonPoint <Previous>k__BackingField;
	}
}
