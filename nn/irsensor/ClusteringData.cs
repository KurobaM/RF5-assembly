using System;
using Il2CppDummyDll;
using nn.util;

namespace nn.irsensor
{
	// Token: 0x02001509 RID: 5385
	[Token(Token = "0x2000EC6")]
	public struct ClusteringData : IEquatable<ClusteringData>
	{
		// Token: 0x06007A6A RID: 31338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066F6")]
		[Address(RVA = "0x388660", Offset = "0x388761", VA = "0x388660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x0002ACC0 File Offset: 0x00028EC0
		[Token(Token = "0x60066F7")]
		[Address(RVA = "0x2D7AC20", Offset = "0x2D7AD21", VA = "0x2D7AC20")]
		public static bool operator ==(ClusteringData lhs, ClusteringData rhs)
		{
			return default(bool);
		}

		// Token: 0x06007A6C RID: 31340 RVA: 0x0002ACD8 File Offset: 0x00028ED8
		[Token(Token = "0x60066F8")]
		[Address(RVA = "0x2D7AC90", Offset = "0x2D7AD91", VA = "0x2D7AC90")]
		public static bool operator !=(ClusteringData lhs, ClusteringData rhs)
		{
			return default(bool);
		}

		// Token: 0x06007A6D RID: 31341 RVA: 0x0002ACF0 File Offset: 0x00028EF0
		[Token(Token = "0x60066F9")]
		[Address(RVA = "0x388670", Offset = "0x388771", VA = "0x388670", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x0002AD08 File Offset: 0x00028F08
		[Token(Token = "0x60066FA")]
		[Address(RVA = "0x388680", Offset = "0x388781", VA = "0x388680", Slot = "4")]
		public bool Equals(ClusteringData other)
		{
			return default(bool);
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x0002AD20 File Offset: 0x00028F20
		[Token(Token = "0x60066FB")]
		[Address(RVA = "0x388700", Offset = "0x388801", VA = "0x388700", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BD6B RID: 114027
		[Token(Token = "0x4018728")]
		[FieldOffset(Offset = "0x0")]
		public float averageIntensity;

		// Token: 0x0401BD6C RID: 114028
		[Token(Token = "0x4018729")]
		[FieldOffset(Offset = "0x4")]
		public Float2 centroid;

		// Token: 0x0401BD6D RID: 114029
		[Token(Token = "0x401872A")]
		[FieldOffset(Offset = "0xC")]
		public int pixelCount;

		// Token: 0x0401BD6E RID: 114030
		[Token(Token = "0x401872B")]
		[FieldOffset(Offset = "0x10")]
		public Rect bound;
	}
}
