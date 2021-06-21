using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C72 RID: 3186
	[Token(Token = "0x2000821")]
	public class Edge
	{
		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06005186 RID: 20870 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005187 RID: 20871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085E")]
		public Point2D EdgeStart
		{
			[Token(Token = "0x60043B7")]
			[Address(RVA = "0x27EF080", Offset = "0x27EF181", VA = "0x27EF080")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043B8")]
			[Address(RVA = "0x27EF090", Offset = "0x27EF191", VA = "0x27EF090")]
			set
			{
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06005188 RID: 20872 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005189 RID: 20873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085F")]
		public Point2D EdgeEnd
		{
			[Token(Token = "0x60043B9")]
			[Address(RVA = "0x27EF0A0", Offset = "0x27EF1A1", VA = "0x27EF0A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043BA")]
			[Address(RVA = "0x27EF0B0", Offset = "0x27EF1B1", VA = "0x27EF0B0")]
			set
			{
			}
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BB")]
		[Address(RVA = "0x27EF0C0", Offset = "0x27EF1C1", VA = "0x27EF0C0")]
		public Edge()
		{
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043BC")]
		[Address(RVA = "0x27EF100", Offset = "0x27EF201", VA = "0x27EF100")]
		public Edge(Point2D edgeStart, Point2D edgeEnd)
		{
		}

		// Token: 0x0400B12D RID: 45357
		[Token(Token = "0x40084E3")]
		[FieldOffset(Offset = "0x10")]
		protected Point2D mP;

		// Token: 0x0400B12E RID: 45358
		[Token(Token = "0x40084E4")]
		[FieldOffset(Offset = "0x18")]
		protected Point2D mQ;
	}
}
