using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C74 RID: 3188
	[Token(Token = "0x2000823")]
	public abstract class TriangulationContext
	{
		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06005195 RID: 20885 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005196 RID: 20886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000863")]
		public TriangulationDebugContext DebugContext
		{
			[Token(Token = "0x60043C6")]
			[Address(RVA = "0x2807020", Offset = "0x2807121", VA = "0x2807020")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9460", Offset = "0x1A9561")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043C7")]
			[Address(RVA = "0x2807030", Offset = "0x2807131", VA = "0x2807030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9470", Offset = "0x1A9571")]
			protected set
			{
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06005197 RID: 20887 RVA: 0x0001A6B8 File Offset: 0x000188B8
		// (set) Token: 0x06005198 RID: 20888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000864")]
		public TriangulationMode TriangulationMode
		{
			[Token(Token = "0x60043C8")]
			[Address(RVA = "0x2807040", Offset = "0x2807141", VA = "0x2807040")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9480", Offset = "0x1A9581")]
			get
			{
				return TriangulationMode.Unconstrained;
			}
			[Token(Token = "0x60043C9")]
			[Address(RVA = "0x2807050", Offset = "0x2807151", VA = "0x2807050")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9490", Offset = "0x1A9591")]
			protected set
			{
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06005199 RID: 20889 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600519A RID: 20890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000865")]
		public ITriangulatable Triangulatable
		{
			[Token(Token = "0x60043CA")]
			[Address(RVA = "0x2807060", Offset = "0x2807161", VA = "0x2807060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A94A0", Offset = "0x1A95A1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043CB")]
			[Address(RVA = "0x2807070", Offset = "0x2807171", VA = "0x2807070")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A94B0", Offset = "0x1A95B1")]
			private set
			{
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x0600519B RID: 20891 RVA: 0x0001A6D0 File Offset: 0x000188D0
		// (set) Token: 0x0600519C RID: 20892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000866")]
		public int StepCount
		{
			[Token(Token = "0x60043CC")]
			[Address(RVA = "0x2807080", Offset = "0x2807181", VA = "0x2807080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A94C0", Offset = "0x1A95C1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60043CD")]
			[Address(RVA = "0x2807090", Offset = "0x2807191", VA = "0x2807090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A94D0", Offset = "0x1A95D1")]
			private set
			{
			}
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043CE")]
		[Address(RVA = "0x28070A0", Offset = "0x28071A1", VA = "0x28070A0")]
		public void Done()
		{
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x0600519E RID: 20894
		[Token(Token = "0x17000867")]
		public abstract TriangulationAlgorithm Algorithm { [Token(Token = "0x60043CF")] get; }

		// Token: 0x0600519F RID: 20895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D0")]
		[Address(RVA = "0x28070B0", Offset = "0x28071B1", VA = "0x28070B0", Slot = "5")]
		public virtual void PrepareTriangulation(ITriangulatable t)
		{
		}

		// Token: 0x060051A0 RID: 20896
		[Token(Token = "0x60043D1")]
		public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b);

		// Token: 0x060051A1 RID: 20897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D2")]
		[Address(RVA = "0x28071F0", Offset = "0x28072F1", VA = "0x28071F0")]
		public void Update(string message)
		{
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D3")]
		[Address(RVA = "0x2807200", Offset = "0x2807301", VA = "0x2807200", Slot = "7")]
		public virtual void Clear()
		{
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x060051A3 RID: 20899 RVA: 0x0001A6E8 File Offset: 0x000188E8
		// (set) Token: 0x060051A4 RID: 20900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000868")]
		public virtual bool IsDebugEnabled
		{
			[Token(Token = "0x60043D4")]
			[Address(RVA = "0x2807280", Offset = "0x2807381", VA = "0x2807280", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A94E0", Offset = "0x1A95E1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60043D5")]
			[Address(RVA = "0x2807290", Offset = "0x2807391", VA = "0x2807290", Slot = "9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A94F0", Offset = "0x1A95F1")]
			protected set
			{
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060051A5 RID: 20901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000869")]
		public DTSweepDebugContext DTDebugContext
		{
			[Token(Token = "0x60043D6")]
			[Address(RVA = "0x28072A0", Offset = "0x28073A1", VA = "0x28072A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D7")]
		[Address(RVA = "0x2807340", Offset = "0x2807441", VA = "0x2807340")]
		protected TriangulationContext()
		{
		}

		// Token: 0x0400B130 RID: 45360
		[Token(Token = "0x40084E6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1772A0", Offset = "0x1773A1")]
		private TriangulationDebugContext <DebugContext>k__BackingField;

		// Token: 0x0400B131 RID: 45361
		[Token(Token = "0x40084E7")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<DelaunayTriangle> Triangles;

		// Token: 0x0400B132 RID: 45362
		[Token(Token = "0x40084E8")]
		[FieldOffset(Offset = "0x20")]
		public readonly List<TriangulationPoint> Points;

		// Token: 0x0400B133 RID: 45363
		[Token(Token = "0x40084E9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1772B0", Offset = "0x1773B1")]
		private TriangulationMode <TriangulationMode>k__BackingField;

		// Token: 0x0400B134 RID: 45364
		[Token(Token = "0x40084EA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1772C0", Offset = "0x1773C1")]
		private ITriangulatable <Triangulatable>k__BackingField;

		// Token: 0x0400B135 RID: 45365
		[Token(Token = "0x40084EB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1772D0", Offset = "0x1773D1")]
		private int <StepCount>k__BackingField;

		// Token: 0x0400B136 RID: 45366
		[Token(Token = "0x40084EC")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1772E0", Offset = "0x1773E1")]
		private bool <IsDebugEnabled>k__BackingField;
	}
}
