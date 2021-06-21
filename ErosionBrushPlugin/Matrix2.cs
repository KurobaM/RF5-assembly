using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E36 RID: 3638
	[Token(Token = "0x200094B")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x149060", Offset = "0x149161")]
	public class Matrix2<T> : ICloneable
	{
		// Token: 0x06005F92 RID: 24466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F03")]
		public Matrix2()
		{
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F04")]
		public Matrix2(int x, int z, [Optional] T[] array)
		{
		}

		// Token: 0x06005F94 RID: 24468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F05")]
		public Matrix2(CoordRect rect, [Optional] T[] array)
		{
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F06")]
		public Matrix2(Coord offset, Coord size, [Optional] T[] array)
		{
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06005F96 RID: 24470 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F97 RID: 24471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C3")]
		public T Item
		{
			[Token(Token = "0x6004F07")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F08")]
			set
			{
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06005F98 RID: 24472 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F99 RID: 24473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C4")]
		public T Item
		{
			[Token(Token = "0x6004F09")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F0A")]
			set
			{
			}
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F0B")]
		public T CheckGet(int x, int z)
		{
			return null;
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06005F9B RID: 24475 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005F9C RID: 24476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C5")]
		public T Item
		{
			[Token(Token = "0x6004F0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F0D")]
			set
			{
			}
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0E")]
		public void Clear()
		{
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F0F")]
		public void ChangeRect(CoordRect newRect)
		{
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F10")]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F11")]
		public Matrix2<T> Clone(Matrix2<T> result)
		{
			return null;
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F12")]
		public void Fill(T v)
		{
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F13")]
		public void Fill(Matrix2<T> m, bool removeBorders = false)
		{
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F14")]
		public void SetPos(int x, int z)
		{
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F15")]
		public void SetPos(int x, int z, int s)
		{
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F16")]
		public void MoveX()
		{
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F17")]
		public void MoveZ()
		{
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F18")]
		public void MovePrevX()
		{
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F19")]
		public void MovePrevZ()
		{
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06005FA9 RID: 24489 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FAA RID: 24490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C6")]
		public T nextX
		{
			[Token(Token = "0x6004F1A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F1B")]
			set
			{
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06005FAB RID: 24491 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FAC RID: 24492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C7")]
		public T prevX
		{
			[Token(Token = "0x6004F1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F1D")]
			set
			{
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06005FAD RID: 24493 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FAE RID: 24494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C8")]
		public T nextZ
		{
			[Token(Token = "0x6004F1E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F1F")]
			set
			{
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06005FAF RID: 24495 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FB0 RID: 24496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C9")]
		public T prevZ
		{
			[Token(Token = "0x6004F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F21")]
			set
			{
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06005FB1 RID: 24497 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FB2 RID: 24498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009CA")]
		public T nextXnextZ
		{
			[Token(Token = "0x6004F22")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F23")]
			set
			{
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06005FB3 RID: 24499 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FB4 RID: 24500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009CB")]
		public T prevXnextZ
		{
			[Token(Token = "0x6004F24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F25")]
			set
			{
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06005FB5 RID: 24501 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FB6 RID: 24502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009CC")]
		public T nextXprevZ
		{
			[Token(Token = "0x6004F26")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F27")]
			set
			{
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06005FB7 RID: 24503 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FB8 RID: 24504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009CD")]
		public T prevXprevZ
		{
			[Token(Token = "0x6004F28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F29")]
			set
			{
			}
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2A")]
		public void RemoveBorders()
		{
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2B")]
		public void RemoveBorders(int borderMinX, int borderMinZ, int borderMaxX, int borderMaxZ)
		{
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2C")]
		public void RemoveBorders(CoordRect centerRect)
		{
		}

		// Token: 0x0400BED0 RID: 48848
		[Token(Token = "0x4008EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] array;

		// Token: 0x0400BED1 RID: 48849
		[Token(Token = "0x4008EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CoordRect rect;

		// Token: 0x0400BED2 RID: 48850
		[Token(Token = "0x4008EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int pos;

		// Token: 0x0400BED3 RID: 48851
		[Token(Token = "0x4008EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int count;
	}
}
