using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Fishing
{
	// Token: 0x0200106B RID: 4203
	[Token(Token = "0x2000AA7")]
	public class FishingPoint : MonoBehaviour
	{
		// Token: 0x06006A1F RID: 27167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005865")]
		[Address(RVA = "0x1EC44D0", Offset = "0x1EC45D1", VA = "0x1EC44D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005866")]
		[Address(RVA = "0x1EC4540", Offset = "0x1EC4641", VA = "0x1EC4540")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005867")]
		[Address(RVA = "0x1EC4760", Offset = "0x1EC4861", VA = "0x1EC4760")]
		public void DeleteFish()
		{
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005868")]
		[Address(RVA = "0x1EC4840", Offset = "0x1EC4941", VA = "0x1EC4840")]
		public FishingPoint()
		{
		}

		// Token: 0x04017231 RID: 94769
		[Token(Token = "0x4013E50")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public SphereCollider FishSpawnArea;

		// Token: 0x04017232 RID: 94770
		[Token(Token = "0x4013E51")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public BoxCollider FishingBox;

		// Token: 0x04017233 RID: 94771
		[Token(Token = "0x4013E52")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public int FishSpwanTblNo;

		// Token: 0x04017234 RID: 94772
		[Token(Token = "0x4013E53")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "HideInInspector", RVA = "0x180A90", Offset = "0x180B91")]
		public static int PointFishMax;
	}
}
