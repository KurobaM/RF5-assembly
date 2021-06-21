using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C5F RID: 3167
	[Token(Token = "0x2000810")]
	public class DTSweepDebugContext : TriangulationDebugContext
	{
		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x0600507C RID: 20604 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600507D RID: 20605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000814")]
		public DelaunayTriangle PrimaryTriangle
		{
			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x24ACCC0", Offset = "0x24ACDC1", VA = "0x24ACCC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042AE")]
			[Address(RVA = "0x24A92F0", Offset = "0x24A93F1", VA = "0x24A92F0")]
			set
			{
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x0600507E RID: 20606 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600507F RID: 20607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000815")]
		public DelaunayTriangle SecondaryTriangle
		{
			[Token(Token = "0x60042AF")]
			[Address(RVA = "0x24ACCD0", Offset = "0x24ACDD1", VA = "0x24ACCD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042B0")]
			[Address(RVA = "0x24AAE90", Offset = "0x24AAF91", VA = "0x24AAE90")]
			set
			{
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005081 RID: 20609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000816")]
		public TriangulationPoint ActivePoint
		{
			[Token(Token = "0x60042B1")]
			[Address(RVA = "0x24ACCE0", Offset = "0x24ACDE1", VA = "0x24ACCE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042B2")]
			[Address(RVA = "0x24ACCF0", Offset = "0x24ACDF1", VA = "0x24ACCF0")]
			set
			{
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06005082 RID: 20610 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005083 RID: 20611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000817")]
		public AdvancingFrontNode ActiveNode
		{
			[Token(Token = "0x60042B3")]
			[Address(RVA = "0x24ACD70", Offset = "0x24ACE71", VA = "0x24ACD70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042B4")]
			[Address(RVA = "0x24A81A0", Offset = "0x24A82A1", VA = "0x24A81A0")]
			set
			{
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06005084 RID: 20612 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005085 RID: 20613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000818")]
		public DTSweepConstraint ActiveConstraint
		{
			[Token(Token = "0x60042B5")]
			[Address(RVA = "0x24ACD80", Offset = "0x24ACE81", VA = "0x24ACD80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042B6")]
			[Address(RVA = "0x24A6DD0", Offset = "0x24A6ED1", VA = "0x24A6DD0")]
			set
			{
			}
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B7")]
		[Address(RVA = "0x24AC680", Offset = "0x24AC781", VA = "0x24AC680")]
		public DTSweepDebugContext(DTSweepContext tcx)
		{
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06005087 RID: 20615 RVA: 0x00019E90 File Offset: 0x00018090
		[Token(Token = "0x17000819")]
		public bool IsDebugContext
		{
			[Token(Token = "0x60042B8")]
			[Address(RVA = "0x24ACD90", Offset = "0x24ACE91", VA = "0x24ACD90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B9")]
		[Address(RVA = "0x24ACDA0", Offset = "0x24ACEA1", VA = "0x24ACDA0", Slot = "4")]
		public override void Clear()
		{
		}

		// Token: 0x0400B0EA RID: 45290
		[Token(Token = "0x40084AA")]
		[FieldOffset(Offset = "0x18")]
		private DelaunayTriangle _primaryTriangle;

		// Token: 0x0400B0EB RID: 45291
		[Token(Token = "0x40084AB")]
		[FieldOffset(Offset = "0x20")]
		private DelaunayTriangle _secondaryTriangle;

		// Token: 0x0400B0EC RID: 45292
		[Token(Token = "0x40084AC")]
		[FieldOffset(Offset = "0x28")]
		private TriangulationPoint _activePoint;

		// Token: 0x0400B0ED RID: 45293
		[Token(Token = "0x40084AD")]
		[FieldOffset(Offset = "0x30")]
		private AdvancingFrontNode _activeNode;

		// Token: 0x0400B0EE RID: 45294
		[Token(Token = "0x40084AE")]
		[FieldOffset(Offset = "0x38")]
		private DTSweepConstraint _activeConstraint;
	}
}
