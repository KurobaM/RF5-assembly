using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C59 RID: 3161
	[Token(Token = "0x200080A")]
	public class AdvancingFront
	{
		// Token: 0x06005039 RID: 20537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600426A")]
		[Address(RVA = "0x249FEB0", Offset = "0x249FFB1", VA = "0x249FEB0")]
		public AdvancingFront(AdvancingFrontNode head, AdvancingFrontNode tail)
		{
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600426B")]
		[Address(RVA = "0x249FF10", Offset = "0x24A0011", VA = "0x249FF10")]
		public void AddNode(AdvancingFrontNode node)
		{
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600426C")]
		[Address(RVA = "0x249FF20", Offset = "0x24A0021", VA = "0x249FF20")]
		public void RemoveNode(AdvancingFrontNode node)
		{
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426D")]
		[Address(RVA = "0x249FF30", Offset = "0x24A0031", VA = "0x249FF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426E")]
		[Address(RVA = "0x24A0050", Offset = "0x24A0151", VA = "0x24A0050")]
		private AdvancingFrontNode FindSearchNode(double x)
		{
			return null;
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600426F")]
		[Address(RVA = "0x24A0060", Offset = "0x24A0161", VA = "0x24A0060")]
		public AdvancingFrontNode LocateNode(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004270")]
		[Address(RVA = "0x24A0110", Offset = "0x24A0211", VA = "0x24A0110")]
		private AdvancingFrontNode LocateNode(double x)
		{
			return null;
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004271")]
		[Address(RVA = "0x24A01A0", Offset = "0x24A02A1", VA = "0x24A01A0")]
		public AdvancingFrontNode LocatePoint(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x0400B0D4 RID: 45268
		[Token(Token = "0x4008494")]
		[FieldOffset(Offset = "0x10")]
		public AdvancingFrontNode Head;

		// Token: 0x0400B0D5 RID: 45269
		[Token(Token = "0x4008495")]
		[FieldOffset(Offset = "0x18")]
		public AdvancingFrontNode Tail;

		// Token: 0x0400B0D6 RID: 45270
		[Token(Token = "0x4008496")]
		[FieldOffset(Offset = "0x20")]
		protected AdvancingFrontNode Search;
	}
}
