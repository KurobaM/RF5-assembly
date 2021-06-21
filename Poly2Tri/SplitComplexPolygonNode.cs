using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C6D RID: 3181
	[Token(Token = "0x200081C")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x1476E0", Offset = "0x1477E1")]
	public class SplitComplexPolygonNode
	{
		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x0001A280 File Offset: 0x00018480
		[Token(Token = "0x17000849")]
		public int NumConnected
		{
			[Token(Token = "0x6004357")]
			[Address(RVA = "0x2804810", Offset = "0x2804911", VA = "0x2804810")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06005127 RID: 20775 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005128 RID: 20776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084A")]
		public Point2D Position
		{
			[Token(Token = "0x6004358")]
			[Address(RVA = "0x2806230", Offset = "0x2806331", VA = "0x2806230")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004359")]
			[Address(RVA = "0x2806240", Offset = "0x2806341", VA = "0x2806240")]
			set
			{
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06005129 RID: 20777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084B")]
		public SplitComplexPolygonNode Item
		{
			[Token(Token = "0x600435A")]
			[Address(RVA = "0x2804230", Offset = "0x2804331", VA = "0x2804230")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435B")]
		[Address(RVA = "0x2806250", Offset = "0x2806351", VA = "0x2806250")]
		public SplitComplexPolygonNode()
		{
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435C")]
		[Address(RVA = "0x28040D0", Offset = "0x28041D1", VA = "0x28040D0")]
		public SplitComplexPolygonNode(Point2D pos)
		{
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x0001A298 File Offset: 0x00018498
		[Token(Token = "0x600435D")]
		[Address(RVA = "0x28062D0", Offset = "0x28063D1", VA = "0x28062D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x0001A2B0 File Offset: 0x000184B0
		[Token(Token = "0x600435E")]
		[Address(RVA = "0x28063A0", Offset = "0x28064A1", VA = "0x28063A0")]
		public bool Equals(SplitComplexPolygonNode pn)
		{
			return default(bool);
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x0001A2C8 File Offset: 0x000184C8
		[Token(Token = "0x600435F")]
		[Address(RVA = "0x28063D0", Offset = "0x28064D1", VA = "0x28063D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x0001A2E0 File Offset: 0x000184E0
		[Token(Token = "0x6004360")]
		[Address(RVA = "0x28042B0", Offset = "0x28043B1", VA = "0x28042B0")]
		public static bool operator ==(SplitComplexPolygonNode lhs, SplitComplexPolygonNode rhs)
		{
			return default(bool);
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x0001A2F8 File Offset: 0x000184F8
		[Token(Token = "0x6004361")]
		[Address(RVA = "0x2804860", Offset = "0x2804961", VA = "0x2804860")]
		public static bool operator !=(SplitComplexPolygonNode lhs, SplitComplexPolygonNode rhs)
		{
			return default(bool);
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004362")]
		[Address(RVA = "0x28063E0", Offset = "0x28064E1", VA = "0x28063E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x0001A310 File Offset: 0x00018510
		[Token(Token = "0x6004363")]
		[Address(RVA = "0x2806570", Offset = "0x2806671", VA = "0x2806570")]
		private bool IsRighter(double sinA, double cosA, double sinB, double cosB)
		{
			return default(bool);
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x0001A328 File Offset: 0x00018528
		[Token(Token = "0x6004364")]
		[Address(RVA = "0x28065B0", Offset = "0x28066B1", VA = "0x28065B0")]
		private int remainder(int x, int modulus)
		{
			return 0;
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004365")]
		[Address(RVA = "0x2804170", Offset = "0x2804271", VA = "0x2804170")]
		public void AddConnection(SplitComplexPolygonNode toMe)
		{
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004366")]
		[Address(RVA = "0x28047A0", Offset = "0x28048A1", VA = "0x28047A0")]
		public void RemoveConnection(SplitComplexPolygonNode fromMe)
		{
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004367")]
		[Address(RVA = "0x28065D0", Offset = "0x28066D1", VA = "0x28065D0")]
		private void RemoveConnectionByIndex(int index)
		{
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004368")]
		[Address(RVA = "0x28048D0", Offset = "0x28049D1", VA = "0x28048D0")]
		public void ClearConnections()
		{
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x0001A340 File Offset: 0x00018540
		[Token(Token = "0x6004369")]
		[Address(RVA = "0x2806660", Offset = "0x2806761", VA = "0x2806660")]
		private bool IsConnectedTo(SplitComplexPolygonNode me)
		{
			return default(bool);
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436A")]
		[Address(RVA = "0x2804E90", Offset = "0x2804F91", VA = "0x2804E90")]
		public SplitComplexPolygonNode GetRightestConnection(SplitComplexPolygonNode incoming)
		{
			return null;
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436B")]
		[Address(RVA = "0x2804930", Offset = "0x2804A31", VA = "0x2804930")]
		public SplitComplexPolygonNode GetRightestConnection(Point2D incomingDir)
		{
			return null;
		}

		// Token: 0x0400B115 RID: 45333
		[Token(Token = "0x40084CB")]
		[FieldOffset(Offset = "0x10")]
		private List<SplitComplexPolygonNode> mConnected;

		// Token: 0x0400B116 RID: 45334
		[Token(Token = "0x40084CC")]
		[FieldOffset(Offset = "0x18")]
		private Point2D mPosition;
	}
}
