using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C73 RID: 3187
	[Token(Token = "0x2000822")]
	public class TriangulationConstraint : Edge
	{
		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600518C RID: 20876 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600518D RID: 20877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000860")]
		public TriangulationPoint P
		{
			[Token(Token = "0x60043BD")]
			[Address(RVA = "0x28066D0", Offset = "0x28067D1", VA = "0x28066D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043BE")]
			[Address(RVA = "0x2806770", Offset = "0x2806871", VA = "0x2806770")]
			set
			{
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600518E RID: 20878 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600518F RID: 20879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000861")]
		public TriangulationPoint Q
		{
			[Token(Token = "0x60043BF")]
			[Address(RVA = "0x28068D0", Offset = "0x28069D1", VA = "0x28068D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043C0")]
			[Address(RVA = "0x2806970", Offset = "0x2806A71", VA = "0x2806970")]
			set
			{
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x0001A688 File Offset: 0x00018888
		[Token(Token = "0x17000862")]
		public uint ConstraintCode
		{
			[Token(Token = "0x60043C1")]
			[Address(RVA = "0x28069C0", Offset = "0x2806AC1", VA = "0x28069C0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C2")]
		[Address(RVA = "0x28069D0", Offset = "0x2806AD1", VA = "0x28069D0")]
		public TriangulationConstraint(TriangulationPoint p1, TriangulationPoint p2)
		{
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C3")]
		[Address(RVA = "0x2806B40", Offset = "0x2806C41", VA = "0x2806B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043C4")]
		[Address(RVA = "0x28067C0", Offset = "0x28068C1", VA = "0x28067C0")]
		public void CalculateContraintCode()
		{
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x0001A6A0 File Offset: 0x000188A0
		[Token(Token = "0x60043C5")]
		[Address(RVA = "0x2806E80", Offset = "0x2806F81", VA = "0x2806E80")]
		public static uint CalculateContraintCode(TriangulationPoint p, TriangulationPoint q)
		{
			return 0U;
		}

		// Token: 0x0400B12F RID: 45359
		[Token(Token = "0x40084E5")]
		[FieldOffset(Offset = "0x20")]
		private uint mContraintCode;
	}
}
