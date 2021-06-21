using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E38 RID: 3640
	[Token(Token = "0x200094D")]
	public class WeldTerrains
	{
		// Token: 0x06005FBE RID: 24510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2F")]
		[Address(RVA = "0x1DAC6D0", Offset = "0x1DAC7D1", VA = "0x1DAC6D0")]
		public static void WeldHeights(float[,] heights, Terrain prevX, Terrain nextZ, Terrain nextX, Terrain prevZ, int margin)
		{
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F30")]
		[Address(RVA = "0x1DAD1D0", Offset = "0x1DAD2D1", VA = "0x1DAD1D0")]
		public static void WeldSplats(float[,,] splats, Terrain prevX, Terrain nextZ, Terrain nextX, Terrain prevZ, int margin)
		{
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F31")]
		[Address(RVA = "0x1DAE180", Offset = "0x1DAE281", VA = "0x1DAE180")]
		public WeldTerrains()
		{
		}
	}
}
