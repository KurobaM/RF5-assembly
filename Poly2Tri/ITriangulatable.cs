using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C63 RID: 3171
	[Token(Token = "0x2000814")]
	public interface ITriangulatable
	{
		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x0600508D RID: 20621
		[Token(Token = "0x1700081A")]
		IList<DelaunayTriangle> Triangles { [Token(Token = "0x60042BE")] get; }

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x0600508E RID: 20622
		[Token(Token = "0x1700081B")]
		TriangulationMode TriangulationMode { [Token(Token = "0x60042BF")] get; }

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x0600508F RID: 20623
		// (set) Token: 0x06005090 RID: 20624
		[Token(Token = "0x1700081C")]
		string FileName { [Token(Token = "0x60042C0")] get; [Token(Token = "0x60042C1")] set; }

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06005091 RID: 20625
		// (set) Token: 0x06005092 RID: 20626
		[Token(Token = "0x1700081D")]
		bool DisplayFlipX { [Token(Token = "0x60042C2")] get; [Token(Token = "0x60042C3")] set; }

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06005093 RID: 20627
		// (set) Token: 0x06005094 RID: 20628
		[Token(Token = "0x1700081E")]
		bool DisplayFlipY { [Token(Token = "0x60042C4")] get; [Token(Token = "0x60042C5")] set; }

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06005095 RID: 20629
		// (set) Token: 0x06005096 RID: 20630
		[Token(Token = "0x1700081F")]
		float DisplayRotate { [Token(Token = "0x60042C6")] get; [Token(Token = "0x60042C7")] set; }

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06005097 RID: 20631
		// (set) Token: 0x06005098 RID: 20632
		[Token(Token = "0x17000820")]
		double Precision { [Token(Token = "0x60042C8")] get; [Token(Token = "0x60042C9")] set; }

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06005099 RID: 20633
		[Token(Token = "0x17000821")]
		double MinX { [Token(Token = "0x60042CA")] get; }

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x0600509A RID: 20634
		[Token(Token = "0x17000822")]
		double MaxX { [Token(Token = "0x60042CB")] get; }

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x0600509B RID: 20635
		[Token(Token = "0x17000823")]
		double MinY { [Token(Token = "0x60042CC")] get; }

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x0600509C RID: 20636
		[Token(Token = "0x17000824")]
		double MaxY { [Token(Token = "0x60042CD")] get; }

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x0600509D RID: 20637
		[Token(Token = "0x17000825")]
		Rect2D Bounds { [Token(Token = "0x60042CE")] get; }

		// Token: 0x0600509E RID: 20638
		[Token(Token = "0x60042CF")]
		void Prepare(TriangulationContext tcx);

		// Token: 0x0600509F RID: 20639
		[Token(Token = "0x60042D0")]
		void AddTriangle(DelaunayTriangle t);

		// Token: 0x060050A0 RID: 20640
		[Token(Token = "0x60042D1")]
		void AddTriangles(IEnumerable<DelaunayTriangle> list);

		// Token: 0x060050A1 RID: 20641
		[Token(Token = "0x60042D2")]
		void ClearTriangles();
	}
}
