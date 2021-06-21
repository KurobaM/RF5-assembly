using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace MonsterHut
{
	// Token: 0x02000EFA RID: 3834
	[Token(Token = "0x20009D1")]
	public class MonsterHutArea : MonoBehaviour, MonsterHutAreaInterface
	{
		// Token: 0x06006497 RID: 25751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539D")]
		[Address(RVA = "0x1E613D0", Offset = "0x1E614D1", VA = "0x1E613D0")]
		public void Initialize()
		{
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x00021AE0 File Offset: 0x0001FCE0
		[Token(Token = "0x600539E")]
		[Address(RVA = "0x1E61450", Offset = "0x1E61551", VA = "0x1E61450", Slot = "4")]
		public int GetFreePointIndex()
		{
			return 0;
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539F")]
		[Address(RVA = "0x1E614C0", Offset = "0x1E615C1", VA = "0x1E614C0", Slot = "5")]
		public void LockPointIndex(int index)
		{
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A0")]
		[Address(RVA = "0x1E61510", Offset = "0x1E61611", VA = "0x1E61510", Slot = "6")]
		public void RelesePointIndex(int index)
		{
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A1")]
		[Address(RVA = "0x1E61560", Offset = "0x1E61661", VA = "0x1E61560", Slot = "9")]
		public Transform GetPointTransfrom(int index)
		{
			return null;
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A2")]
		[Address(RVA = "0x1E61600", Offset = "0x1E61701", VA = "0x1E61600", Slot = "7")]
		public void UpdateLoveLv(int index, int loveLv)
		{
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x00021AF8 File Offset: 0x0001FCF8
		[Token(Token = "0x60053A3")]
		[Address(RVA = "0x1E61650", Offset = "0x1E61751", VA = "0x1E61650", Slot = "8")]
		public bool IsMostLoveLvMonster(int index)
		{
			return default(bool);
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A4")]
		[Address(RVA = "0x1E61660", Offset = "0x1E61761", VA = "0x1E61660")]
		public void SelectMostLoveLevelIndex()
		{
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A5")]
		[Address(RVA = "0x1E61800", Offset = "0x1E61901", VA = "0x1E61800")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A6")]
		[Address(RVA = "0x1E61940", Offset = "0x1E61A41", VA = "0x1E61940")]
		public MonsterHutArea()
		{
		}

		// Token: 0x0400C45D RID: 50269
		[Token(Token = "0x40092F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int AreaIndex;

		// Token: 0x0400C45E RID: 50270
		[Token(Token = "0x40092F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public List<Transform> Transforms;

		// Token: 0x0400C45F RID: 50271
		[Token(Token = "0x40092F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public Collider AreaCollider;

		// Token: 0x0400C460 RID: 50272
		[Token(Token = "0x40092F3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public UnityEventInteger OnPlayerEnterArea;

		// Token: 0x0400C461 RID: 50273
		[Token(Token = "0x40092F4")]
		[FieldOffset(Offset = "0x38")]
		private bool[] IsExistPointFlags;

		// Token: 0x0400C462 RID: 50274
		[Token(Token = "0x40092F5")]
		[FieldOffset(Offset = "0x40")]
		private int[] MonsterLoveLvs;

		// Token: 0x0400C463 RID: 50275
		[Token(Token = "0x40092F6")]
		[FieldOffset(Offset = "0x48")]
		private int MostLoveLvPointIndex;
	}
}
