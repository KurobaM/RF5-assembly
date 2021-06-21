using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Farm
{
	// Token: 0x02001083 RID: 4227
	[Token(Token = "0x2000AB3")]
	public class CellSetController : MonoBehaviour
	{
		// Token: 0x06006AFE RID: 27390 RVA: 0x00024978 File Offset: 0x00022B78
		[Token(Token = "0x6005911")]
		[Address(RVA = "0x21CE870", Offset = "0x21CE971", VA = "0x21CE870")]
		public bool CheckSameAllPlants()
		{
			return default(bool);
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005912")]
		[Address(RVA = "0x21CB940", Offset = "0x21CBA41", VA = "0x21CB940")]
		public void ChangeLargeSizeCrop(bool isLargeSize, int cellIndex = -1)
		{
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005913")]
		[Address(RVA = "0x21CBEC0", Offset = "0x21CBFC1", VA = "0x21CBEC0")]
		public CellController GetLargeCellController()
		{
			return null;
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x00024990 File Offset: 0x00022B90
		[Token(Token = "0x6005914")]
		[Address(RVA = "0x21CA420", Offset = "0x21CA521", VA = "0x21CA420")]
		public bool IsAllCultivatedEmptyCell()
		{
			return default(bool);
		}

		// Token: 0x06006B02 RID: 27394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005915")]
		[Address(RVA = "0x21CE940", Offset = "0x21CEA41", VA = "0x21CE940")]
		public CellSetController()
		{
		}

		// Token: 0x040172C6 RID: 94918
		[Token(Token = "0x4013EB5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CellController[] cellControllers;

		// Token: 0x040172C7 RID: 94919
		[Token(Token = "0x4013EB6")]
		[FieldOffset(Offset = "0x20")]
		public bool IsLargeSize;

		// Token: 0x040172C8 RID: 94920
		[Token(Token = "0x4013EB7")]
		[FieldOffset(Offset = "0x24")]
		private int largeCellIndex;

		// Token: 0x040172C9 RID: 94921
		[Token(Token = "0x4013EB8")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 largeCellPosition;
	}
}
