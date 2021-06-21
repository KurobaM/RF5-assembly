using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C6C RID: 3180
	[Token(Token = "0x200081B")]
	public class EdgeIntersectInfo
	{
		// Token: 0x0600511F RID: 20767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004350")]
		[Address(RVA = "0x27EF150", Offset = "0x27EF251", VA = "0x27EF150")]
		public EdgeIntersectInfo(Edge edgeOne, Edge edgeTwo, Point2D intersectionPoint)
		{
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005121 RID: 20769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000846")]
		public Edge EdgeOne
		{
			[Token(Token = "0x6004351")]
			[Address(RVA = "0x27EF1C0", Offset = "0x27EF2C1", VA = "0x27EF1C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9360", Offset = "0x1A9461")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004352")]
			[Address(RVA = "0x27EF1D0", Offset = "0x27EF2D1", VA = "0x27EF1D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9370", Offset = "0x1A9471")]
			private set
			{
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005123 RID: 20771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000847")]
		public Edge EdgeTwo
		{
			[Token(Token = "0x6004353")]
			[Address(RVA = "0x27EF1E0", Offset = "0x27EF2E1", VA = "0x27EF1E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9380", Offset = "0x1A9481")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004354")]
			[Address(RVA = "0x27EF1F0", Offset = "0x27EF2F1", VA = "0x27EF1F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9390", Offset = "0x1A9491")]
			private set
			{
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005125 RID: 20773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000848")]
		public Point2D IntersectionPoint
		{
			[Token(Token = "0x6004355")]
			[Address(RVA = "0x27EF200", Offset = "0x27EF301", VA = "0x27EF200")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A93A0", Offset = "0x1A94A1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004356")]
			[Address(RVA = "0x27EF210", Offset = "0x27EF311", VA = "0x27EF210")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A93B0", Offset = "0x1A94B1")]
			private set
			{
			}
		}

		// Token: 0x0400B112 RID: 45330
		[Token(Token = "0x40084C8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177220", Offset = "0x177321")]
		private Edge <EdgeOne>k__BackingField;

		// Token: 0x0400B113 RID: 45331
		[Token(Token = "0x40084C9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177230", Offset = "0x177331")]
		private Edge <EdgeTwo>k__BackingField;

		// Token: 0x0400B114 RID: 45332
		[Token(Token = "0x40084CA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177240", Offset = "0x177341")]
		private Point2D <IntersectionPoint>k__BackingField;
	}
}
